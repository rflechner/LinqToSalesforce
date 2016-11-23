namespace LinqToSalesforce

open System
open System.Text
open LinqToSalesforce
open System.Collections.Generic
open System.Linq
open System.Linq.Expressions
open System.Reflection
open System.Security.Cryptography.X509Certificates
open System.Net
open System.Net.Http
open Newtonsoft
open Newtonsoft.Json.Linq
open Newtonsoft.Json
open Newtonsoft.Json.Serialization
open Newtonsoft.Json.Converters
open LinqToSalesforce.Visitor

type EntityFieldAttribute () =
  inherit Attribute ()

type ReferencedByFieldAttribute (name:string) =
  inherit Attribute ()
  member __.Name 
    with get () = name

module Translator =
  
  type MemberInfo with
    member __.GetSerializedName() =
      let attr = __.GetCustomAttribute<JsonPropertyAttribute>()
      if isNull attr then __.Name else attr.PropertyName

  let buildSelectFromNames (names:string array) =
    let b = StringBuilder("SELECT ")
    String.Join(", ", names) |> b.Append |> ignore
    b.Append " " |> ignore
    b.ToString()

  let buildSelectFromType (t:Type) =
    t.GetProperties()
    |> Seq.filter (fun p -> p.GetCustomAttributes<EntityFieldAttribute>().Any())
    |> Seq.map (fun p -> p.GetSerializedName())
    |> Seq.toArray
    |> buildSelectFromNames

  let buildSelectFromFields (fields:FieldSelect list) =
    fields
    |> Seq.map (
        fun f -> 
          match f.Alias with
          | Some a -> a
          | None -> f.Field.GetSerializedName()
        )
    |> Seq.toArray
    |> buildSelectFromNames

  let buildSelect(op:Operation list) =
    op
    |> List.choose (
          function
          | Select args ->
              match args with
              | Fields fields ->
                  Some (buildSelectFromFields fields)
              | SelectType t -> 
                  Some (buildSelectFromType t)
          | _ -> None
       )
    |> List.tryHead

  let translateComparer =
    function
    | Equal -> "="
    | NotEqual -> "!="
    | GreatherThan -> ">"
    | SmallerThan -> "<"
    | GreatherOrEqualThan -> ">="
    | SmallerOrEqualThan -> "<="

  let translateTarget =
    function
    | Constant o -> 
        match o with
        | _ when isNull o -> "NULL"
        | :? string as s -> sprintf "'%s'" s
        | :? DateTime as d -> sprintf "'%s'" (d.ToString("yyyy-MM-dd"))
        | _ -> o.ToString()
    | OtherField f -> f.Name

  let buildFromUnary(c:FieldComparison) =
    sprintf "%s %s %s" 
      (c.Field.GetSerializedName())
      (translateComparer c.Kind)
      (translateTarget c.Target)

  let translateBinaryKind =
    function
    | Or -> "OR"
    | And -> "AND"

  let rec translateWhere =
    function
    | UnaryComparison c ->
        buildFromUnary c
    | BinaryComparison (arg1,c,arg2) ->
        sprintf "(%s) %s (%s)" 
          (translateWhere arg1)
          (translateBinaryKind c)
          (translateWhere arg2)
    | FieldFunction(field, inverted, name, args) ->
        match name, inverted, args with
        | "Contains", false, [Constant(arg)] ->
          sprintf "%s like '%%%s%%'" (field.GetSerializedName()) (arg.ToString())
        | "Contains", true, [Constant(arg)] ->
          sprintf "(NOT %s like '%%%s%%')" (field.GetSerializedName()) (arg.ToString())
        | "StartsWith", _, [Constant(arg)] ->
          let inv = if inverted then "NOT" else ""
          sprintf "(%s %s like '%s%%')" inv (field.GetSerializedName()) (arg.ToString())
        | "EndsWith", _, [Constant(arg)] ->
          let inv = if inverted then "NOT" else ""
          sprintf "(%s %s like '%%%s')" inv (field.GetSerializedName()) (arg.ToString())
        | _ -> failwithf "function %s is cannot be translated to SOQL" name

  let rec buildWhere(op:Operation list) =
    op
    |> List.choose (
        function
        | Where w -> Some (translateWhere w)
        | _ -> None )
  let rec buildOrder(op:Operation list) =
    op
    |> List.choose (
        function
        | Order (Ascending, f) -> Some (sprintf "ORDER BY %s" f.Name)
        | Order (Descending, f) -> Some (sprintf "ORDER BY %s DESC" f.Name)
        | _ -> None )

  let rec buildLimit(op:Operation list) =
    op
    |> List.choose (
        function
        | Limit count -> Some (sprintf "LIMIT %d" count)
        | _ -> None )

  let rec buildSkip(op:Operation list) =
    op
    |> List.choose (
        function
        | Skip count -> Some (sprintf "OFFSET %d" count)
        | _ -> None )

  let buildSoql (op:Operation list) (t:Type) tableName =
    let b = StringBuilder()
    match buildSelect op with
    | Some s ->  b.Append s |> ignore
    | None -> buildSelectFromType t |> b.Append |> ignore
    b.Append (sprintf "FROM %s " tableName) |> ignore
    match buildWhere op with
    | [] -> ()
    | [w] -> b.Append (sprintf "WHERE %s" w) |> ignore
    | ws -> 
        let l =
          ws
          |> List.map (sprintf "(%s)")
          |> List.toArray
        let s = String.Join(" AND ", l)
        b.Append (sprintf "WHERE %s" s) |> ignore
    match buildOrder op with
    | [] -> ()
    | o :: _ -> b.Append " " |> ignore; b.Append o |> ignore
    
    match buildLimit op with
    | [] -> ()
    | o :: _ -> b.Append " " |> ignore; b.Append o |> ignore

    match buildSkip op with
    | [] -> ()
    | o :: _ -> b.Append " " |> ignore; b.Append o |> ignore

    b.ToString()


