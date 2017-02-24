namespace LinqToSalesforce

open System
open System.Reflection
open Rest
open Rest.OAuth
open System.Collections
open System.Collections.Generic
open System.Linq
open Entities
open Translator
open Visitor

module private ContextHelper =
  let execute<'t when 't :> ISalesforceEntity>(client:Client) (tracker:Tracker) operations tableName =
    let typ = typeof<'t>
    let soql = buildSoql operations typ tableName
    //printfn "SOQL: %s" soql
    let rs = client.ExecuteSoql<'t> soql |> Async.RunSynchronously
    match rs with
    | Success r ->
      let records = r.Records.ToList()
      for r in records do
        r.TrackPropertyUpdates()
        r.PropertyChanged.Add(fun _ -> tracker.Track r)
      records
    | Failure [e] -> e.ToException() |> raise
    | Failure errors -> 
        errors 
          |> List.map (fun e -> e.ToException() :> Exception) 
          |> List.toArray
          |> AggregateException
          |> raise

type RelationShip<'tp,'tc
  when 'tp :> ISalesforceEntity 
  and 'tc :> ISalesforceEntity>(client:Client, referenceField:string, tracker:Tracker, parent:'tp) =

  let loadResults () =
    let childType = typeof<'tc>
    let chidlTableName = findEntityName childType
    let field = { Name=referenceField; DecorationName=None; Type=typeof<string> }
    let cmp = { Field=field; Kind=ComparisonKind.Equal; Target=(Constant(parent.Id)) }
    let operations = 
      [ Select (SelectType childType)
        Where (UnaryComparison(cmp)) ]
    let results = ContextHelper.execute<'tc> client tracker operations chidlTableName
    for r in results do
      RelationShip<'tp,_>.Build childType client tracker r
    results
  let results = lazy (loadResults ())
  member __.Results () =
    results.Value
  interface IEnumerable<'tc> with
    member x.GetEnumerator(): IEnumerator = 
      results.Value.GetEnumerator() :> IEnumerator
    member x.GetEnumerator(): IEnumerator<'tc> = 
      results.Value.GetEnumerator() :> IEnumerator<'tc>

  static member Build (typ:Type) (client:Client) (tracker:Tracker) (parent:#ISalesforceEntity) =
    let td = typedefof<RelationShip<_,_>>
    typ.GetProperties() 
      |> Seq.filter (
          fun p -> 
            p.PropertyType.IsGenericType && (p.PropertyType.GetGenericTypeDefinition() = td)
          )
      |> Seq.iter (
          fun r1 ->
            let ct = parent.GetType()
            let co = r1.PropertyType.GetConstructor([|typeof<Client>; typeof<string>; typeof<Tracker>; ct|])
            let referencedByFieldAttr = r1.GetCustomAttributes<ReferencedByFieldAttribute>() |> Seq.head
            let instance = co.Invoke([|client; referencedByFieldAttr.Name; tracker; parent|])
            r1.SetValue(parent, instance)
         )

type SoqlQueryContext<'t when 't :> ISalesforceEntity>(client:Client, tracker:Tracker) =
  interface IQueryContext with
    member x.Execute expression _ =
      let visitor = new RequestExpressionVisitor(expression)
      visitor.Visit()
      let operations = visitor.Operations |> Seq.toList
      let typ = typeof<'t>
      let tableName = findEntityName typ
      let results = ContextHelper.execute<'t> client tracker operations tableName
      for r in results do
        RelationShip<'t,_>.Build typ client tracker r
      results :> obj

type SoqlContext (instanceName:string, authparams:ImpersonationParam) =
  let client = Client(instanceName, authparams)
  let tracker = new Tracker()
  
  member x.GetTable<'t when 't :> ISalesforceEntity>() =
    let c = new SoqlQueryContext<'t>(client, tracker)
    let tableName = typeof<'t>.Name
    let queryProvider = new QueryProvider(c, tableName)
    new Queryable<'t>(queryProvider, tableName)

  member x.Insert entity =
    match client.Insert entity with
    | Success r ->
        entity.PropertyChanged.Add
          <| fun _ -> tracker.Track entity
        entity.Id <- r.Id
        r.Id
    | Failure [e] -> e.ToException() |> raise
    | Failure errors -> 
        errors 
          |> List.map (fun e -> e.ToException() :> Exception) 
          |> List.toArray
          |> AggregateException
          |> raise
  
  //Note: writing 'member x.Delete = client.Delete' is causing C# interop difficulties because it wants FSharp.Core ref
  member x.Delete entity =
    client.Delete entity

  member x.Save() =
    let entities = tracker.GetTrackedEntities()
    for e in entities do
      client.Update e |> ignore
    tracker.Clear()

