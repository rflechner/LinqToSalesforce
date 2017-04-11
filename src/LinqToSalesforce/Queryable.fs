namespace LinqToSalesforce

open System
open System.Reflection
open System.Collections
open System.Collections.Generic
open System.Linq
open System.Linq.Expressions
open Translator

type IQueryContext =
  abstract member Execute : Expression -> bool -> obj

module FieldsProviders =
  let fieldsFromTypeProvider<'t> () =
    let t = (typeof<'t>)
    t.GetProperties()
    |> Seq.filter (fun p -> p.GetCustomAttributes<EntityFieldAttribute>().Any())
    |> Seq.map (fun p -> p.GetSerializedName())
    |> Seq.toArray

type Queryable<'t> (provider:IQueryProvider, tableName, expression:Expression option) =
  new (provider:IQueryProvider, tableName) =
    Queryable<'t>(provider, tableName, None)
  new (args: obj array) =
    Queryable<'t>(args.[0] :?> IQueryProvider, args.[1] :?> string, args.[2] :?> Expression option)
  
  member val Provider:IQueryProvider=provider with get, set
  member val TableName:string=tableName with get, set
  member val FieldsProvider=FieldsProviders.fieldsFromTypeProvider<'t> with get, set

  member x.BuildExpression() =
    match expression with
    | None -> Expression.Constant(x) :> Expression
    | Some exp -> exp
  member x.ProvideOperations () =
    let e = x.BuildExpression()
    let visitor = new Visitor.RequestExpressionVisitor(e)
    visitor.Visit()
    visitor.Operations |> Seq.toList
  override x.ToString() =
    let operations = x.ProvideOperations ()
    buildSoql operations (typeof<'t>) tableName x.FieldsProvider
  
  interface IOrderedQueryable<'t> with
    member x.ElementType: Type = 
      typeof<'t>
    member x.Expression: Expression = 
      x.BuildExpression()
    member x.GetEnumerator(): IEnumerator = 
      x.Provider.Execute<IEnumerable>(x.BuildExpression()).GetEnumerator()
    member x.GetEnumerator(): IEnumerator<'t> = 
      x.Provider.Execute<IEnumerable<'t>>(x.BuildExpression()).GetEnumerator()
    member x.Provider: IQueryProvider = 
      x.Provider
    
module TypeSystem =
  let rec findIEnumerable(seqType:Type) =

    let (|InterfacesHaveIenum|_|) (t:Type) =
      match t.GetInterfaces() |> Seq.toList with
      | [] -> None
      | ifaces -> 
          ifaces
            |> Seq.choose (fun i -> findIEnumerable i)
            |> Seq.tryHead

    let (|IsInGenericArguments|_|) (t:Type) =
      if t.IsGenericType
      then
        t.GetGenericArguments()
          |> Seq.tryFind (fun a -> typedefof<(IEnumerable<_>)>.MakeGenericType(a).IsAssignableFrom t)
      else None

    match seqType with
    | t when t = typeof<string> || isNull t -> None
    | t when t.IsArray -> 
        typeof<IEnumerable<_>>.MakeGenericType(seqType.GetElementType()) |> Some
    | IsInGenericArguments t -> typedefof<(IEnumerable<_>)>.MakeGenericType(t) |> Some
    | InterfacesHaveIenum t -> Some t
    | t when t.BaseType <> null && t.BaseType <> typeof<obj> ->
        findIEnumerable t.BaseType
    | _ -> None

  let getElementType(seqType:Type) =
    match findIEnumerable seqType with
    | None -> seqType
    | Some ienum ->
        ienum.GetGenericArguments() |> Seq.head

type QueryProvider (queryContext:IQueryContext, tableName) =

  let rec findSelect (exp:MethodCallExpression) : UnaryExpression option =
    if exp.Arguments.Count < 0
    then None
    else
      if exp.Method.Name = "Select"
      then
          match exp.Arguments.[1] with
          | :? UnaryExpression as u -> Some u
          | _ -> None
        else
          match exp.Arguments.[0] with
          | :? MethodCallExpression as sub -> findSelect sub
          | _ -> None

  member private x.BuildSelectMemberFunc<'rt,'pt>(m:MemberExpression) =
    match m.Member, m.Expression with
    | (:? PropertyInfo as p), (:? ParameterExpression as pa) ->
        let parameter = Expression.Parameter(typeof<'pt>, pa.Name)
        let property = Expression.Property(parameter, p)
        let l = Expression.Lambda<Func<'pt, 'rt>>(property, parameter)
        l.Compile()
    | _ -> failwith "MemberExpression"

  member private x.SelectProperties<'rt,'pt>(u:UnaryExpression, results:IEnumerable<'pt>) : IEnumerable<'rt> =
    let operand = u.Operand :?> LambdaExpression
    let paramType = typeof<'pt>
    match operand.Body with
    | :? MemberExpression as m ->
      let f = x.BuildSelectMemberFunc<'rt,'pt>(m)
      results |> Seq.map f.Invoke
    | :? NewExpression as e ->
      let names = 
            e.Arguments
            |> Seq.map (fun a -> (a :?> MemberExpression).Member.Name)
            |> Seq.toList
      let properties = paramType.GetProperties() |> Seq.map (fun m -> m.Name, m) |> dict
      let toArgs result = 
        names 
        |> Seq.map (
            fun n ->
              let m = properties.Item n
              m.GetValue result )
        |> Seq.toArray
      results |> Seq.map (fun r -> r |> toArgs |> e.Constructor.Invoke :?> 'rt )
    | :? ParameterExpression ->
        results :?> IEnumerable<'rt>
    | _ -> failwith "SelectProperties"

  interface IQueryProvider with
    member x.CreateQuery(exp: Expression): IQueryable<'TElement> = 
      (new Queryable<'TElement>(x, tableName, Some exp)) :> IQueryable<'TElement>

    member x.Execute(expression: Expression): 'TResult = 
      let result = queryContext.Execute expression false
      if not <| typeof<IEnumerable>.IsAssignableFrom typeof<'TResult>
      then
        match expression with
        | :? MethodCallExpression as e when e.Method.Name = "FirstOrDefault" ->
            (result :?> IEnumerable<'TResult>).FirstOrDefault()
        | :? MethodCallExpression as e when e.Method.Name = "Single" ->
            (result :?> IEnumerable<'TResult>).Single()
        | :? MethodCallExpression as e when e.Method.Name = "SingleOrDefault" ->
            (result :?> IEnumerable<'TResult>).SingleOrDefault()
        | :? MethodCallExpression as e when e.Method.Name = "Count" ->
            result :?> 'TResult
        | _ -> (result :?> IEnumerable<'TResult>).First()
      else 
        let results = (result :?> IEnumerable)
        let modelType = result.GetType().GetGenericArguments() |> Seq.head
        let selectedType = typeof<'TResult>.GetGenericArguments() |> Seq.head
        let m = x.GetType().GetMethod("SelectProperties", BindingFlags.NonPublic ||| BindingFlags.Instance)
        let selector = m.MakeGenericMethod(selectedType, modelType)
        match expression with
        | :? MethodCallExpression as e when e.Method.Name = "Select" ->
            match e.Arguments.[1] with
            | :? UnaryExpression as u ->
                selector.Invoke(x, [|u:>obj; results:>obj|]) :?> 'TResult
            | _ -> failwith "Not implemented select case"
        | :? MethodCallExpression as e when e.Method.Name = "Take" || e.Method.Name = "Skip" ->
              match findSelect e with
              | Some u -> selector.Invoke(x, [|u:>obj; results:>obj|]) :?> 'TResult
              | _ -> result :?> 'TResult
        | _ -> result :?> 'TResult
    member x.Execute(expression: Expression): obj = 
      queryContext.Execute expression false
    member x.CreateQuery(expression: Expression): IQueryable = 
      let elementType = TypeSystem.getElementType expression.Type
      let args : obj[] = [|x; tableName; Some expression|]
      let ty = typedefof<Queryable<_>>.MakeGenericType(elementType)
      Activator.CreateInstance(ty, args) :?> IQueryable
