namespace ProviderImplementation

open ProviderImplementation.ProvidedTypes
open Microsoft.FSharp.Core.CompilerServices
open System.Reflection
open System
open System.IO
open System.Net
open Newtonsoft.Json
open LinqToSalesforce
open Rest
open Rest.OAuth
open System.ComponentModel
open System.Runtime.Caching

type TableContext = SoqlContext*string

module RestApi =
  let cache = new MemoryCache("RestApi")
  let cacheAndReturns key (f:unit -> 't) =
    if cache.Contains key
    then 
      cache.Get(key) :?> 't
    else
      let result = f()
      let policy = new CacheItemPolicy()
      policy.SlidingExpiration <- TimeSpan.FromMinutes 5.
      cache.Add(key, result, policy) |> ignore
      result

  let getTablesUrls oauth =
    async {
      return! cacheAndReturns "tableNames" (fun () -> getObjectsDescUrls oauth)
    }
  let loadTableList oauth (f:TableDesc -> unit) =
    async {
      let! tableUrls = getTablesUrls oauth
      let getTable = getTableFromUrl oauth
      for url in tableUrls.Values |> Seq.take 5 do
        let key = sprintf "key_%s" url
        let! table = cacheAndReturns key (fun () -> getTable url)
        f table
    }

type BaseEntity () =
  let event = Event<_, _>()
//  let mutable propval = 0.0
//  member this.MyProperty
//    with get() = propval
//    and  set(v) =
//        propval <- v
//        event.Trigger(this, new PropertyChangedEventArgs("MyProperty"))
  interface INotifyPropertyChanged with
    member this.add_PropertyChanged(e) =
        event.Publish.AddHandler(e)
    member this.remove_PropertyChanged(e) =
        event.Publish.RemoveHandler(e)
  interface ISalesforceEntity with
    member val Id="" with get,set
    member this.TrackPropertyUpdates(): unit = 
      ()
    member this.UpdatedProperties: Collections.Generic.IDictionary<string,obj> = 
      [] |> dict

[<TypeProvider>]
type SalesforceProvider () as this =
  inherit TypeProviderForNamespaces ()
  let ns = "SalesforceProvider"
  let asm = Assembly.GetExecutingAssembly()
  let tyName = "SalesforceTypeProvider"
  let myType = ProvidedTypeDefinition(asm, ns, tyName, None)

  do myType.DefineStaticParameters(
    [ ProvidedStaticParameter("authFile", typeof<string>)
      ProvidedStaticParameter("instanceName", typeof<string>, "") ],
      fun typeName [|:? string as authFile; :? string as instanceName|] ->
        let ty = ProvidedTypeDefinition(asm, ns, typeName, None)
        if not <| String.IsNullOrWhiteSpace instanceName
        then Config.ProductionInstance <- instanceName

        let authJson = File.ReadAllText authFile
        let authparams = ImpersonationParam.FromJson authJson
        let oauth = authenticateWithCredentials authparams |> Async.RunSynchronously
      
        ProvidedConstructor([], 
              InvokeCode=(
                fun _ -> 
                  <@@ 
                    let imperso = authJson |> ImpersonationParam.FromJson 
                    let id = imperso |> authenticateWithCredentials |> Async.RunSynchronously
                    SoqlContext(instanceName, imperso)
                  @@>
                ))
          |> ty.AddMember
      
        let tablesType = ProvidedTypeDefinition(
                            "TablesType", 
                            baseType = Some typeof<obj>,
                            HideObjectMethods = true)
        ProvidedConstructor([],
            InvokeCode=
                fun [c]-> 
                    <@@
                        let tables = %%c:TableDesc array
                        tables
                    @@>
            ) |> tablesType.AddMember
        do ty.AddMember tablesType

        do ProvidedProperty("Tables", tablesType,
              GetterCode = fun args ->
                  <@@
                      let a = (%%args.[0]:obj) :?> SoqlContext
                      a
                  @@>) |> ty.AddMember
        
        RestApi.loadTableList oauth (
          fun table ->
                tablesType.AddMemberDelayed (fun () ->
                  
                  let entityType = ProvidedTypeDefinition(
                                    sprintf "%sEntity" table.Name,
                                    baseType = Some typeof<BaseEntity>,
                                    HideObjectMethods = false)
                  for field in table.Fields do
                    let fn = field.Name
                    ProvidedProperty(field.Name, typeof<string>,
                      GetterCode=fun args -> 
                        <@@
                          fn
                        @@>) |> entityType.AddMember
                  
                  do ty.AddMember entityType
                  
                  let tq = ProvidedTypeBuilder.MakeGenericType(typedefof<System.Linq.IOrderedQueryable<_>>, [entityType])
                  let ct = ProvidedTypeDefinition(table.Name, Some tq ,HideObjectMethods=false)
                  
                  do ty.AddMember ct
                  
                  let tableName = table.Name
                  ProvidedProperty(table.LabelPlural, ct,
                    GetterCode=fun args -> 
                      <@@
                        let ctx = (%%args.[0]:>obj) :?> SoqlContext
                        let oauth = ctx.GetIdentity()
                        let tableUrls = oauth |> RestApi.getTablesUrls |> Async.RunSynchronously
                        let url = tableUrls.Item tableName
                        let getTable = getTableFromUrl oauth
                        let table = url |> getTable |> Async.RunSynchronously
                        ctx.BuildQueryable<BaseEntity>(table)
                      @@>
                      )
                  )
        ) |> Async.StartAsTask |> ignore
        
        ty)


  do this.AddNamespace(ns, [myType])

[<TypeProviderAssembly>]
do ()
