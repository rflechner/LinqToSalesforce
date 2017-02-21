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

type Queryable<'t> (provider:IQueryProvider, tableName, expression:Expression option) =
  new (provider:IQueryProvider, tableName) =
    Queryable<'t>(provider, tableName, None)
  member val Provider:IQueryProvider=provider with get, set
  member val TableName:string=tableName with get, set
  member x.BuildExpression() =
    match expression with
    | None -> Expression.Constant(x) :> Expression
    | Some exp -> exp
  override x.ToString() =
    let e = x.BuildExpression()
    let visitor = new Visitor.RequestExpressionVisitor(e)
    visitor.Visit()
    let operations = visitor.Operations |> Seq.toList
    buildSoql operations (typeof<'t>) tableName
  
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
          |> Seq.tryFind (fun a -> typeof<(IEnumerable<_>)>.MakeGenericType(a).IsAssignableFrom t)
      else None

    match seqType with
    | t when t = typeof<string> || isNull t -> None
    | t when t.IsArray -> 
        typeof<IEnumerable<_>>.MakeGenericType(seqType.GetElementType()) |> Some
    | IsInGenericArguments t -> Some t
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
  member private x.BuildUnaryFuncImpl<'rt,'pt>(u:UnaryExpression) =
    let operand = u.Operand :?> LambdaExpression
    match operand.Body with
    | :? MemberExpression as m ->
        match m.Member, m.Expression with
        | (:? PropertyInfo as p), (:? ParameterExpression as pa) ->
            //results.Select(fun r -> p.GetValue(r)) |> box :?> 'TResult
            //results |> Seq.map (fun r -> p.GetValue(r))
            let name = pa.Name
            let parameter = Expression.Parameter(typeof<'pt>, name)
            //let l = Expression.Lambda<Func<'pt, 'rt>>(m, parameter)
            let method = p :?> MethodInfo
            let l = Expression.Call(method, parameter)
            let func = l.Compile()
            func
            //result :?> 'TResult
        | _ -> failwith "UnaryExpression"
    | _ -> failwith "UnaryExpression"
//    let func = Expression.Lambda<Func<'pt, 'rt>>(u, parameter).Compile()
//    let func = Expression.Lambda<'rt>(u, parameter).Compile()
    //u.Method
//    true
  member private x.BuildUnaryFunc(rt:Type, pt:Type, u:UnaryExpression) = 
    let m = x.GetType().GetMethod("BuildUnaryFuncImpl", Reflection.BindingFlags.NonPublic ||| Reflection.BindingFlags.Instance)
    let gm = m.MakeGenericMethod(rt, pt)
    let f = gm.Invoke(x, [|u|])
    f
//  member private x.ExecUnaryImpl<'rt,'pt>(o:obj) : 'rt = 
//    failwith ""
//  member private x.ExecUnary(rt:Type, pt:Type, o:obj) = 
//    let m = x.GetType().GetMethod("ExecUnaryImpl", Reflection.BindingFlags.NonPublic ||| Reflection.BindingFlags.Instance)
//    let gm = m.MakeGenericMethod(rt, pt)
//    let f = gm.Invoke(x, [|o|])
//    true
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
        | _ -> (result :?> IEnumerable<'TResult>).First()
      else 
        let results = (result :?> IEnumerable)
        match expression with
        | :? MethodCallExpression as e when e.Method.Name = "Select" ->
            match e.Arguments.[1] with
            | :? UnaryExpression as u ->
                let garg = result.GetType().GetGenericArguments().Single()
                let garg2 = typeof<'TResult>.GetGenericArguments().Single()
                //let parameter = Expression.Parameter(garg, "value")
                //let func = Expression.Lambda<Func<'TResult>>(u, parameter).Compile()
                //let f = Expression.Lambda(u).Compile()
//                Expression.Call(u)
                //let func = Expression.Lambda<Func<'TResult, obj>>(u, parameter).Compile()
                let f = x.BuildUnaryFunc(garg2, garg, u)
                
//                let operand = u.Operand :?> LambdaExpression
//                match operand.Body with
//                | :? MemberExpression as m ->
//                    match m.Member with
//                    | :? PropertyInfo as p ->
//                        //results.Select(fun r -> p.GetValue(r)) |> box :?> 'TResult
//                        //results |> Seq.map (fun r -> p.GetValue(r))
//                        let l =
//                          seq {
//                            for r in results do
//                              yield p.GetValue r
//                          } |> Seq.toList
//                        l |> box :?> 'TResult
//                        //result :?> 'TResult
//                    | _ -> failwith "UnaryExpression"
//                | _ -> failwith "UnaryExpression"

                result :?> 'TResult

            | _ -> failwith "bug"
        | _ -> result :?> 'TResult
    member x.Execute(expression: Expression): obj = 
      queryContext.Execute expression false
    member x.CreateQuery(expression: Expression): IQueryable = 
      let elementType = TypeSystem.getElementType expression.Type
      let args = [|x:>obj;expression:>obj|]
      let ty = typeof<Queryable<_>>.MakeGenericType(elementType)
      Activator.CreateInstance(ty, args) :?> IQueryable

