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
open Entities

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
      for url in tableUrls.Values do // |> Seq.take 5 do
        let key = sprintf "key_%s" url
        let! table = cacheAndReturns key (fun () -> getTable url)
        f table
    }

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
        ProvidedConstructor([ProvidedParameter("authJson", typeof<string>)], 
              InvokeCode=(
                fun args -> 
                  <@@ 
                    let authJson = %%args.[0]:>string
                    let imperso = authJson |> ImpersonationParam.FromJson 
                    let id = imperso |> authenticateWithCredentials |> Async.RunSynchronously
                    SoqlContext(instanceName, imperso)
                  @@>
                ))
          |> ty.AddMember
        ProvidedConstructor(
            [ ProvidedParameter("clientId", typeof<string>)
              ProvidedParameter("clientSecret", typeof<string>)
              ProvidedParameter("securityToken", typeof<string>)
              ProvidedParameter("username", typeof<string>)
              ProvidedParameter("password", typeof<string>) ],
            InvokeCode=(
              fun args -> 
                <@@ 
                  let clientId = %%args.[0]:>string
                  let clientSecret = %%args.[1]:>string
                  let securityToken = %%args.[2]:>string
                  let username = %%args.[3]:>string
                  let password = %%args.[4]:>string
                  let imperso = 
                    { ClientId=clientId; ClientSecret=clientSecret; 
                      SecurityToken=securityToken; Username=username; Password=password }
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
                                    baseType = Some typeof<JsonEntity>,
                                    HideObjectMethods = false)
                  for field in table.Fields do
                    let fn = field.Name
                    let memberType = 
                      match field.Type with
                      | Native t -> t
                      | Picklist _ -> typeof<string>
                    let typename = memberType.FullName
                    ProvidedProperty(field.Name, memberType,
                      GetterCode=fun args -> 
                        <@@
                          let entity = (%%args.[0]:>JsonEntity)
                          entity.GetMemberValue fn typename
                        @@>) |> entityType.AddMember
                  // TODO: relationships
                  //for relation in table.RelationShips do
                  //  let name = relation.RelationshipName
                  
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
                        let q = ctx.BuildQueryable<JsonEntity>(table)
                        q
                      @@>
                      )
                  )
        ) |> Async.StartAsTask |> ignore
        
        ty)

  do this.AddNamespace(ns, [myType])

[<TypeProviderAssembly>]
do ()
