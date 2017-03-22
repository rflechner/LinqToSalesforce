namespace LinqToSalesforce

open System
open System.Collections.Generic
open System.Linq
open System.Linq.Expressions
open System.Reflection
open System.Security.Cryptography.X509Certificates
open System.Text

module Visitor =
  open Newtonsoft.Json

  type Field =
    { Name:string
      DecorationName:string option
      Type:Type }
    member __.GetSerializedName() =
      match __.DecorationName with
      | Some d -> d
      | None -> __.Name

  type ComparisonKind =
    | Equal
    | NotEqual
    | GreatherThan
    | SmallerThan
    | GreatherOrEqualThan
    | SmallerOrEqualThan
  and BinaryComparisonKind =
    | And
    | Or
  and ComparisonTarget =
    | Constant of obj
    | OtherField of Field
  and FieldComparison =
    { Field:Field
      Kind:ComparisonKind
      Target:ComparisonTarget }
  and WhereArgs =
    | UnaryComparison of FieldComparison
    | BinaryComparison of WhereArgs * BinaryComparisonKind * WhereArgs
    | FieldFunction of Field * inverted:bool * name:string * args:ComparisonTarget list
  
  type FieldSelect = 
    { Field:Field
      Alias:string option }
    static member WithNoAlias f =
      { Field=f; Alias=None }
    static member WithAlias f a =
      { Field=f; Alias=(Some a) }
  
  type SelectArgs =
    | Fields of FieldSelect list
    | SelectType of Type
  type OrderDirection =
    | Ascending
    | Descending
  
  type Operation =
    | Select of SelectArgs
    | Where of WhereArgs
    | Join of ParsedExpression * ParsedExpression * Field * Field
    | Order of OrderDirection * Field
    | Limit of int
    | Skip of int
    | Count
  and ParsedExpression = Operation list

  let findDecorationName (m:MemberInfo) =
    let attr = m.GetCustomAttribute<JsonPropertyAttribute>()
    if isNull attr then None else Some attr.PropertyName
  
  let (|AndOr|_|) (t:ExpressionType) =
    match t with
    | ExpressionType.And -> Some And
    | ExpressionType.AndAlso -> Some And
    | ExpressionType.Or -> Some Or
    | ExpressionType.OrElse -> Some Or
    | _ -> None
  let (|Comparison|_|) (t:ExpressionType) =
    match t with
    | ExpressionType.Equal -> Some Equal
    | ExpressionType.NotEqual -> Some NotEqual
    | ExpressionType.GreaterThan -> Some GreatherThan
    | ExpressionType.GreaterThanOrEqual -> Some GreatherOrEqualThan
    | ExpressionType.LessThan -> Some SmallerThan
    | ExpressionType.LessThanOrEqual -> Some SmallerOrEqualThan
    | _ -> None
  let (|MemberName|_|) (exp:Expression) =
    match exp with
    | :? MemberExpression as e -> Some e.Member.Name
    | _ -> None
  let (|MemberDecorationName|_|) (exp:Expression) =
    match exp with
    | :? MemberExpression as e ->
        let d = findDecorationName e.Member
        Some (e.Member.Name, d)
    | _ -> None

  let (|BinaryExp|_|) (exp:Expression) =
    match exp with
    | :? BinaryExpression as e -> Some e
    | _ -> None

  let rec (|ConstantExp|_|) (exp:Expression) =
    match exp with
    | :? ConstantExpression as e ->
        let f = (Expression.Lambda e).Compile()
        f.DynamicInvoke() |> Some
    | :? MemberExpression as e -> 
        match e.Member, e.Expression with
        | :? FieldInfo as f, ConstantExp v -> Some (f.GetValue v)
        | :? PropertyInfo as f, ConstantExp v -> Some (f.GetValue v)
        | :? FieldInfo as f, null -> Some (f.GetValue null)
        | :? PropertyInfo as f, null -> Some (f.GetValue null)
        | _ -> None
    | _ -> None
  
  let (|ConvertMethod|_|) (exp:Expression) =
    match exp with
    | :? UnaryExpression as e when e.NodeType = ExpressionType.Convert ->
        match e.Operand with
        | :? MemberExpression as x ->
          let d = findDecorationName x.Member
          Some (x.Member.Name, d, e.Method)
        | _ -> None
    | _ -> None

  let rec (|ConvertExp|_|) (exp:Expression) =
    match exp with
    | :? UnaryExpression as e when e.NodeType = ExpressionType.Convert ->
        match e.Operand with
        | :? ConstantExpression as e ->
          let f = (Expression.Lambda e).Compile()
          f.DynamicInvoke() |> Some
        | :? UnaryExpression as e -> (|ConvertExp|_|) e
        | _ -> None
    | _ -> None
  
  let parseSelectArgs (node:Expression) =
    match node with
    | :? LambdaExpression as e ->
        Select (SelectType e.ReturnType)
    | :? UnaryExpression as e ->
        let operand = e.Operand :?> LambdaExpression
        match operand.Body with
        | :? MemberExpression as m ->
          Select (Fields [FieldSelect.WithNoAlias{Name=m.Member.Name; Type=operand.ReturnType; DecorationName=(findDecorationName m.Member)}])
        | :? ParameterExpression as exp ->
          Select (SelectType exp.Type)
        | :? NewExpression as exp ->
          let fields = 
            exp.Members 
            |> Seq.map (fun m -> 
                let p = m :?> PropertyInfo // TODO: handle fields
                {Name=m.Name; Type=p.PropertyType; DecorationName=(findDecorationName m)})
            |> Seq.toList
          let names = 
            exp.Arguments
            |> Seq.map (fun a -> (a :?> MemberExpression).Member.Name)
            |> Seq.toList
          let fs =
            (fields, names) 
            ||> List.map2 (
                fun field alias ->
                  if field.Name <> alias
                  then FieldSelect.WithAlias ({field with Name=alias}) field.Name
                  else FieldSelect.WithNoAlias field )
          Select (Fields fs)
        | _ -> failwithf "Cannot convert %A" node
    | _ -> failwithf "Cannot convert %A" node

  let parseOrderArgs d (node:Expression) =
    match node with
    | :? UnaryExpression as e ->
        let operand = e.Operand :?> LambdaExpression
        match operand.Body with
        | :? MemberExpression as m ->
          let f = {Name=m.Member.Name; Type=operand.ReturnType; DecorationName=(findDecorationName m.Member)}
          Order (d, f)
        | _ -> failwithf "Cannot convert %A" node
    | _ -> failwithf "Cannot convert %A" node

  let limitMethods = [ "First"; "FirstOrDefault"; "Single"; "SingleOrDefault" ]
  let (|LimitMethods|_|) (exp:Expression) =
    match exp with
    | :? MethodCallExpression as e -> 
      if limitMethods |> List.exists(fun n -> e.Method.Name = n)
      then Some e
      else None
    | _ -> None

  let rec parseWhereArgs (node:Expression) =
    let parseMemberExpression m =
      match node.NodeType, m with
        | ExpressionType.Not, MemberDecorationName (name,d) -> 
            let f = { Type=m.Type; Name=name; DecorationName=d }
            let c = { Field=f; Kind=NotEqual; Target= Constant true }
            UnaryComparison c
        | ExpressionType.MemberAccess, MemberDecorationName (name,d) when node.Type = typeof<Boolean> -> 
            let f = { Type=m.Type; Name=name; DecorationName=d }
            let c = { Field=f; Kind=Equal; Target= Constant true }
            UnaryComparison c
        | n,_ -> failwithf "nodetype %A is not implemented" n
    let parseFunctionCall (m:MethodCallExpression) inverted =
      match m.Object with
      | MemberDecorationName (name,d) ->
          let f = { Type=m.Type; Name=name; DecorationName=d }
          let args = 
            m.Arguments 
            |> Seq.choose (|ConstantExp|_|) 
            |> Seq.map Constant
            |> Seq.toList
          FieldFunction(f, inverted, m.Method.Name, args)
      | _ -> failwithf "Cannot convert %A" node
    match node with
    | :? BinaryExpression as exp ->
        match exp.NodeType, exp.Left, exp.Right with
        | AndOr kind, BinaryExp left, BinaryExp right ->
            let subLeft = parseWhereArgs left
            let subRight = parseWhereArgs right
            BinaryComparison(subLeft, kind, subRight)
        | Comparison kind, MemberDecorationName (name,d), ConstantExp value ->
            let f = { Type=exp.Left.Type; Name=name; DecorationName=d }
            let c = { Field=f; Kind=kind; Target= Constant value }
            UnaryComparison c
        | AndOr kind, left, right ->
            let subLeft = parseWhereArgs left
            let subRight = parseWhereArgs right
            BinaryComparison(subLeft, kind, subRight)
        | Comparison kind, ConvertMethod (name, d, _), ConstantExp value ->
            let f = { Type=exp.Left.Type; Name=name; DecorationName=d }
            let c = { Field=f; Kind=kind; Target= Constant value }
            UnaryComparison c
        | Comparison kind, ConstantExp value, ConvertMethod (name, d, _) ->
            let f = { Type=exp.Left.Type; Name=name; DecorationName=d }
            let c = { Field=f; Kind=kind; Target= Constant value }
            UnaryComparison c
        | Comparison kind, MemberDecorationName (name,d), ConvertExp value ->
            let f = { Type=exp.Left.Type; Name=name; DecorationName=d }
            let c = { Field=f; Kind=kind; Target= Constant value }
            UnaryComparison c
        | _ -> failwithf "Cannot translate %A" exp
    | :? UnaryExpression as e ->
        match e.Operand with
        | :? LambdaExpression as o ->
            parseWhereArgs o.Body
        | :? MemberExpression as m ->
            parseMemberExpression m
        | :? MethodCallExpression as m ->
            parseFunctionCall m (e.NodeType = ExpressionType.Not)
        | _ -> failwithf "Cannot convert %A" e.Operand
    | :? MemberExpression as m ->
        parseMemberExpression m
    | :? MethodCallExpression as m ->
        parseFunctionCall m (node.NodeType = ExpressionType.Not)
    | _ -> failwithf "Cannot convert %A" node
  let rec parseExpression (node:Expression) acc =
    match node with
    | :? MethodCallExpression as e when e.Method.Name = "Select" ->
        let select = e.Arguments.Item 1 |> parseSelectArgs
        parseExpression (e.Arguments.Item 0) (select :: acc)
    | :? MethodCallExpression as e when e.Method.Name = "Where" && e.Arguments.Count = 2 ->
        let arg = e.Arguments.Item 1
        let args = parseWhereArgs arg
        let t2 = parseExpression (e.Arguments.Item 0) []
        (Where args) :: acc @ t2
    | :? MethodCallExpression as e when e.Method.Name = "Join" && e.Arguments.Count = 5 ->
        let parseJoinPart (exp:Expression) =
          match exp with
          | :? ConstantExpression as e ->
              [Select (SelectType e.Type)]
          | _ -> parseExpression exp []
        let rec parseJoinField (exp:Expression) =
          match exp with
          | :? UnaryExpression as e ->
              parseJoinField e.Operand
          | :? LambdaExpression as e ->
              parseJoinField e.Body
          | :? MemberExpression as e ->
              let p = e.Member :?> PropertyInfo
              {Name=e.Member.Name; Type=p.PropertyType; DecorationName=(findDecorationName e.Member)}
          | e -> failwithf "Cannot convert %A" e
        let left = e.Arguments.Item 0
        let right = e.Arguments.Item 1
        let part1 = parseJoinPart left
        let part2 = parseJoinPart right
        let f1 = e.Arguments.Item 2 |> parseJoinField
        let f2 = e.Arguments.Item 3 |> parseJoinField
        Join(part1, part2, f1, f2) :: acc
    | :? MethodCallExpression as e when e.Method.Name = "OrderBy" ->
        let order = e.Arguments.Item 1 |> parseOrderArgs Ascending
        parseExpression (e.Arguments.Item 0) (order :: acc)
    | :? MethodCallExpression as e when e.Method.Name = "OrderByDescending" ->
        let order = e.Arguments.Item 1 |> parseOrderArgs Descending
        parseExpression (e.Arguments.Item 0) (order :: acc)
    | :? MethodCallExpression as e when e.Method.Name = "ThenBy" ->
        let order = e.Arguments.Item 1 |> parseOrderArgs Ascending
        parseExpression (e.Arguments.Item 0) (order :: acc)
    | :? MethodCallExpression as e when e.Method.Name = "ThenByDescending" ->
        let order = e.Arguments.Item 1 |> parseOrderArgs Descending
        parseExpression (e.Arguments.Item 0) (order :: acc)
    | LimitMethods e when e.Arguments.Count = 1 ->
        let token = Limit 1
        parseExpression (e.Arguments.Item 0) (token :: acc)
    | LimitMethods e when e.Arguments.Count = 2 ->
        let limit = Limit 1
        let arg = e.Arguments.Item 1
        let args = parseWhereArgs arg
        parseExpression (e.Arguments.Item 0) ((Where args) :: limit :: acc)
    | :? MethodCallExpression as e when e.Method.Name = "Take" ->
        let getMemberExpressionValue (exp: Expression) = 
            match exp with
            | :? ConstantExpression as e -> e.Value :?> int
            | :? MemberExpression as e -> Expression.Lambda(e).Compile().DynamicInvoke() :?> int
        let count = getMemberExpressionValue (e.Arguments.Item 1)
        let token = Limit count
        parseExpression (e.Arguments.Item 0) (token :: acc)
    | :? MethodCallExpression as e when e.Method.Name = "Skip" ->
        let getMemberExpressionValue (exp: Expression) = 
            match exp with
            | :? ConstantExpression as e -> e.Value :?> int
            | :? MemberExpression as e -> Expression.Lambda(e).Compile().DynamicInvoke() :?> int
        let count = getMemberExpressionValue (e.Arguments.Item 1)
        let token = Skip count
        parseExpression (e.Arguments.Item 0) (token :: acc)
    | :? MethodCallExpression as e when e.Method.Name = "Count" ->
        match e.Arguments.Item 0 with
        | :? ConstantExpression as exp ->
            parseExpression exp (Count :: acc)
        | :? MethodCallExpression as mc2 ->
            let subExp = mc2.Arguments.Item 1
            let args = parseWhereArgs subExp
            parseExpression mc2 (Count :: acc)
        | _ ->
            failwithf "Method not visited: '%s'" e.Method.Name
    | :? MethodCallExpression as e ->
        failwithf "Method not visited: '%s'" e.Method.Name
    | _ -> acc

  type RequestExpressionVisitor(mainExpression:Expression) = 
    let operations:Operation list ref = ref []
    
    member __.Operations
      with
           get () = (!operations).ToArray()

    member __.GetReturnType() =
      let rec searchType (op:Operation list) =
        match op with
        | Select (Fields[s]) :: _ -> s.Field.Type
        | Select (SelectType ty) :: _ -> ty
        | []-> 
            match mainExpression.Type.GenericTypeArguments |> Seq.tryHead with
            | Some t -> t
            | None -> typeof<obj>
        | _ :: t -> searchType t
      searchType !operations

    member __.Visit() =
      operations := parseExpression mainExpression []
