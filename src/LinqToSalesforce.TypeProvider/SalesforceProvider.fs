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
open Caching
open Newtonsoft.Json.Linq
open Microsoft.FSharp.Quotations
open LinqToSalesforce.BuiltinTypes

type TpContext = 
  { Soql:SoqlContext
    CacheFolder:string
    SlidingExpiration:TimeSpan }

type RestApi(cacheFolder, slidingExpiration) =
  let locker = new Object()
  let cache = FileCache cacheFolder
  member __.CacheAndReturns<'t> k (f:unit -> Async<'t>) : 't =
    let key = computeKey k
    match cache.Get<'t> key with
    | Some item -> item
    | None -> 
        async {
          let! item = f()
          cache.Add<'t> key item slidingExpiration
          return item
        } |> Async.RunSynchronously
  member __.Authenticate (authparams:ImpersonationParam) =
    __.CacheAndReturns "oauth" (fun _ -> authenticateWithCredentials authparams)
  member __.GetTablesUrls oauth =
    __.CacheAndReturns "tableNames" (fun _ -> getObjectsDescUrls oauth)
  member __.LoadTableList (authparams:ImpersonationParam) (f:TableDesc -> unit) =
    let oauth = __.Authenticate authparams
    let tableUrls = __.GetTablesUrls oauth
    for url in tableUrls.Values do // |> Seq.take 5 do
      let key = sprintf "key_%s" url
      let table = __.CacheAndReturns key (fun _ -> downloadTableDesc oauth url) |> parseTableDesc
      f table

[<TypeProvider>]
type SalesforceProvider () as this =
  inherit TypeProviderForNamespaces ()
  let ns = "SalesforceProvider"
  let asm = Assembly.GetExecutingAssembly()
  let tyName = "SalesforceTypeProvider"
  let myType = ProvidedTypeDefinition(asm, ns, tyName, None)
  
#if DEBUG
  // to check API traffic with Fiddler
  do System.Net.ServicePointManager.ServerCertificateValidationCallback <- (fun _ _ _ _ -> true)
#endif

  do myType.DefineStaticParameters(
    [ ProvidedStaticParameter("cacheFolder", typeof<string>)
      ProvidedStaticParameter("slidingExpirationMinutes", typeof<float>)
      ProvidedStaticParameter("authFile", typeof<string>)
      ProvidedStaticParameter("instanceName", typeof<string>, "") ],
      fun typeName [|:? string as cacheFolder; :? float as slidingExpirationMinutes; :? string as authFile; :? string as instanceName|] ->
        let ty = ProvidedTypeDefinition(asm, ns, typeName, None)
        if not <| String.IsNullOrWhiteSpace instanceName
        then Config.ProductionInstance <- instanceName

        let slidingExpiration = TimeSpan.FromMinutes slidingExpirationMinutes
        let restApi = RestApi(cacheFolder, slidingExpiration)
        let authJson = File.ReadAllText authFile
        let authparams = ImpersonationParam.FromJson authJson
        
        ProvidedConstructor([], 
              InvokeCode=(
                fun _ -> 
                  <@@ 
                    let imperso = authJson |> ImpersonationParam.FromJson 
                    let id = imperso |> authenticateWithCredentials |> Async.RunSynchronously
                    let ctx = SoqlContext(instanceName, imperso)
                    { Soql=ctx; CacheFolder=cacheFolder; SlidingExpiration=slidingExpiration }
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
                    let ctx = SoqlContext(instanceName, imperso)
                    { Soql=ctx; CacheFolder=cacheFolder; SlidingExpiration=slidingExpiration }
                  @@>
                ))
          |> ty.AddMember
        ProvidedConstructor([
          ProvidedParameter("authJson", typeof<string>)
          ProvidedParameter("cacheFolder", typeof<string>)
          ProvidedParameter("slidingExpiration", typeof<TimeSpan>) ],
              InvokeCode=(
                fun args -> 
                  <@@ 
                    let authJson = %%args.[0]:>string
                    let cacheFolder = %%args.[1]:>string
                    let slidingExpiration = %%args.[2]:>TimeSpan
                    let imperso = authJson |> ImpersonationParam.FromJson 
                    let id = imperso |> authenticateWithCredentials |> Async.RunSynchronously
                    let ctx = SoqlContext(instanceName, imperso)
                    { Soql=ctx; CacheFolder=cacheFolder; SlidingExpiration=slidingExpiration }
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
                  let ctx = SoqlContext(instanceName, imperso)
                  { Soql=ctx; CacheFolder=cacheFolder; SlidingExpiration=slidingExpiration }
                @@>
              ))
          |> ty.AddMember

        ProvidedConstructor(
            [ ProvidedParameter("clientId", typeof<string>)
              ProvidedParameter("clientSecret", typeof<string>)
              ProvidedParameter("securityToken", typeof<string>)
              ProvidedParameter("username", typeof<string>)
              ProvidedParameter("password", typeof<string>)
              ProvidedParameter("cacheFolder", typeof<string>)
              ProvidedParameter("slidingExpiration", typeof<TimeSpan>)],
            InvokeCode=(
              fun args -> 
                <@@ 
                  let clientId = %%args.[0]:>string
                  let clientSecret = %%args.[1]:>string
                  let securityToken = %%args.[2]:>string
                  let username = %%args.[3]:>string
                  let password = %%args.[4]:>string
                  let cacheFolder = %%args.[5]:>string
                  let slidingExpiration = %%args.[6]:>TimeSpan
                  let imperso = 
                    { ClientId=clientId; ClientSecret=clientSecret; 
                      SecurityToken=securityToken; Username=username; Password=password }
                  let id = imperso |> authenticateWithCredentials |> Async.RunSynchronously
                  let ctx = SoqlContext(instanceName, imperso)
                  { Soql=ctx; CacheFolder=cacheFolder; SlidingExpiration=slidingExpiration }
                @@>
              ))
          |> ty.AddMember
          
#if DEBUG
        do ProvidedProperty(AppDomain.CurrentDomain.BaseDirectory, typeof<string>,
            GetterCode = fun args ->
                <@@
                    AppDomain.CurrentDomain.BaseDirectory
                @@>) |> ty.AddMember
#endif

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
                      (%%args.[0]:obj) :?> TpContext
                  @@>) |> ty.AddMember
        
        let saveMethod = 
          ProvidedMethod(
            methodName = "Save", 
            parameters = [ProvidedParameter("entity", typeof<JsonEntity>)],
            returnType = typeof<Result<string, RemoteError list>>,
            InvokeCode = 
              fun args -> 
                  <@@ 
                      let ctx = (%%args.[0]:obj) :?> TpContext
                      let entity = (%%args.[1]:>JsonEntity)
                      let i = ctx.Soql.GetIdentity()
                      let name = entity.GetTableName()
                      match entity.GetId() with
                      | None ->
                          match Rest.insertJsonEntity i entity with
                          | Success r when r.Success -> Success r.Id
                          | Success r -> r.Errors |> Seq.map (fun e -> { ErrorCode=""; Message=e }) |> Seq.toList |> Failure
                          | Failure errors -> Failure errors
                      | Some id ->
                          let json = entity |> Serialization.toInsertJson
                          match Rest.updateEntityName i id name json |> Async.RunSynchronously with
                          | Success r -> Success id
                          | Failure errors -> errors |> Seq.toList |> Failure
                  @@>)
        do saveMethod.AddXmlDoc "Insert or update this entity into Salesforce"
        do ty.AddMember saveMethod

        restApi.LoadTableList authparams (
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
                      | MultiPicklist _ -> typeof<MultiSelectPicklist<string>>
                    let typename = memberType.FullName
                    ProvidedProperty(field.Name, memberType,
                      GetterCode=(fun args -> 
                        <@@
                          let entity = (%%args.[0]:>JsonEntity)
                          entity.GetMemberValue fn typename
                        @@>),
                      SetterCode=(fun args -> 
                          let meth = typeof<JsonEntity>.GetMethod("SetMemberValue")
                          Expr.Call(args.[0],meth,[Expr.Value fn;args.[1]])
                        )
                      ) |> entityType.AddMember
                  // TODO: relationships
                  //for relation in table.RelationShips do
                  //  let name = relation.RelationshipName
                  
                  let tableName = table.Name

                  let createNewMethod = 
                    ProvidedMethod(
                      methodName = "CreateNew", 
                      parameters = [],
                      returnType = entityType, 
                      InvokeCode = 
                        fun args -> 
                            <@@ 
                                let o = new JObject()
                                let jtype = new JObject()
                                jtype.Add("type", JToken.FromObject tableName)
                                o.Add("attributes", jtype)
                                new JsonEntity(o)
                            @@>)
                  do createNewMethod.AddMethodAttrs(MethodAttributes.Static)
                  do createNewMethod.AddXmlDoc "Insert or update this entity into Salesforce"
                  do entityType.AddMember createNewMethod
                  
                  do ty.AddMember entityType
                  
                  let tq = ProvidedTypeBuilder.MakeGenericType(typedefof<System.Linq.IOrderedQueryable<_>>, [entityType])
                  let ct = ProvidedTypeDefinition(table.Name, Some tq ,HideObjectMethods=false)
                  
                  do ty.AddMember ct
                  
                  ProvidedProperty(table.LabelPlural, ct,
                    GetterCode=fun args -> 
                      <@@
                        let tpCtx = (%%args.[0]:>obj) :?> TpContext
                        let ctx = tpCtx.Soql
                        let oauth = ctx.GetIdentity()
                        let restApi = RestApi(tpCtx.CacheFolder, tpCtx.SlidingExpiration)
                        let tableUrls = oauth |> restApi.GetTablesUrls
                        let url = tableUrls.Item tableName
                        let getTable = getTableFromUrl oauth
                        let table = url |> getTable |> Async.RunSynchronously
                        let q = ctx.BuildQueryable<JsonEntity>(table)
                        q
                      @@>
                      )
                  )
        ) |> ignore
        
        ty)

  do this.AddNamespace(ns, [myType])

[<TypeProviderAssembly>]
do ()
