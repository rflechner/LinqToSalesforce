namespace LinqToSalesforce

open System
open System.Collections.Generic
open System.Linq
open System.Linq.Expressions
open System.Reflection
open System.Security.Cryptography.X509Certificates
open System.Text
open System.Net
open System.Net.Http
open Newtonsoft
open Newtonsoft.Json
open Newtonsoft.Json.Serialization
open Newtonsoft.Json.Converters
open Newtonsoft.Json.Linq

type Result<'ts,'te> =
  | Success of 'ts
  | Failure of 'te

module Rest =

  type HttpMethod with
    static member Patch = new HttpMethod("PATCH")

  type RemoteException(message, errorCode:string) =
    inherit Exception(message)
    member __.ErrorCode 
      with get () = errorCode
  
  type RemoteError =
    { [<JsonProperty("message")>] Message:string
      [<JsonProperty("errorCode")>] ErrorCode:string }
    member __.ToException() =
      RemoteException(__.Message, __.ErrorCode)

  let fromJson<'t> json =
    try
      JsonConvert.DeserializeObject<'t> json
    with e -> 
      raise (new Exception("Invalid Json " + json, e))
  
  let toJson (o:obj) =
    let settings = new JsonSerializerSettings()
    settings.DateFormatString <- "yyyy-MM-dd"
    JsonConvert.SerializeObject(o, settings)
  
  let private toInsertJson (e:#ISalesforceEntity) =
    let invalidFields = 
      [ "Id"; "LastModifiedDate";"CreatedById"; "MasterRecordId";
        "IsDeleted";"SystemModstamp";"CreatedDate"; "LastActivityDate";
        "LastModifiedById"; "IsClosed"; "ClosedDate"]
    let settings = new JsonSerializerSettings()
    settings.DateFormatString <- "yyyy-MM-dd"
    let properties = e.UpdatedProperties
    for f in invalidFields do
      if properties.ContainsKey f
      then properties.Remove f |> ignore
    let j = JObject.FromObject properties
    JsonConvert.SerializeObject(j, settings)
  
  module Config =
    let mutable IsProduction = true
    let mutable ProductionInstance = "login"
    let BuildUri format =
      let instance = if IsProduction then ProductionInstance else "test"
      Uri (sprintf format instance)
  
  let toBinary (text:string) =
    Encoding.UTF8.GetBytes text

  let toEncodedParams(d:IDictionary<_,_>) =
    let kvs = 
      seq {
        for k in d.Keys do
          let v = ((d.Item k).ToString()) |> Uri.EscapeUriString
          yield sprintf "%s=%s" (k.ToString()) v
      } |> Seq.toArray
    String.Join("&", kvs)

  let send uri contentType me (f: (Headers.HttpRequestHeaders -> unit) option) (text:string) =
    ServicePointManager.SecurityProtocol <- SecurityProtocolType.Tls12 ||| SecurityProtocolType.Tls11
    async {
      use client = new HttpClient()
      use m = new HttpRequestMessage()
      m.Method <- me
      m.RequestUri <- uri
      m.Headers.Accept.Add(Headers.MediaTypeWithQualityHeaderValue.Parse "application/json")
      m.Headers.CacheControl <- Headers.CacheControlHeaderValue.Parse "no-cache"
      match f with
      | Some a -> a m.Headers
      | None -> ()
      use c = new ByteArrayContent(toBinary text)
      c.Headers.ContentType <- Headers.MediaTypeHeaderValue contentType
      m.Content <- c
      return! client.SendAsync m |> Async.AwaitTask
    }

  let sendRawForm uri (text:string) =
    send uri "application/x-www-form-urlencoded" HttpMethod.Post None text

  module OAuth =
    open System.IO

    [<CLIMutable>]
    type ImpersonationParam =
      { ClientId:string
        ClientSecret:string
        SecurityToken:string
        Username:string
        Password:string }
      static member FromJson json = 
        fromJson<ImpersonationParam> json
      member __.ToKeyValues() =
        [ "grant_type","password"
          "client_id",__.ClientId
          "client_secret",__.ClientSecret
          "username",__.Username
          "password",(__.Password + __.SecurityToken) ]
        |> dict
      member __.ToNameValueCollection() =
        let nvc = new Collections.Specialized.NameValueCollection()
        for kv in __.ToKeyValues() do
          nvc.Add(kv.Key, kv.Value)
        nvc

    type Identity =
      { [<JsonProperty("access_token")>] AccessToken:string
        [<JsonProperty("instance_url")>] InstanceUrl:Uri
        [<JsonProperty("id")>] Id:string
        [<JsonProperty("token_type")>] TokenType:string
        [<JsonProperty("issued_at")>] IssuedAt:float
        [<JsonProperty("signature")>] Signature:string }
      member __.IssueDate () =
        let epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
        epoch.AddMilliseconds __.IssuedAt
      member __.Duration() =
        TimeSpan.FromMinutes 10.
      member __.ExpirationDate() =
        (__.IssueDate ()).Add(__.Duration())
      member __.IsExired() =
        DateTime.UtcNow >= __.ExpirationDate()
    
    let authenticateWithCredentials (p:ImpersonationParam) =
      let uri = Config.BuildUri "https://%s.salesforce.com/services/oauth2/token"
      async {
        let! rs = p.ToKeyValues() |> toEncodedParams |> sendRawForm uri
        let! json = rs.Content.ReadAsStringAsync() |> Async.AwaitTask
        return fromJson<Identity> json
      }

  open OAuth
  open Translator

  let get (i:Identity) (uri:Uri) =
    async {
      use client = new HttpClient()
      use m = new HttpRequestMessage()
      m.Method <- HttpMethod.Get
      m.RequestUri <- uri
      m.Headers.Accept.Add(Headers.MediaTypeWithQualityHeaderValue.Parse "application/json")
      m.Headers.CacheControl <- Headers.CacheControlHeaderValue.Parse "no-cache"
      m.Headers.Add("Authorization", sprintf "Bearer %s" i.AccessToken)
      return! client.SendAsync m |> Async.AwaitTask
    }

  let execRest<'r,'q> (i:Identity) uri m (rq:'q) : 'r Async =
    async {
        let f = 
          fun (h:Headers.HttpRequestHeaders) -> 
            h.Add("Authorization", sprintf "Bearer %s" i.AccessToken)
        let! rs = rq |> toJson |> send uri "application/json" m (Some f)
        let! json = rs.Content.ReadAsStringAsync() |> Async.AwaitTask
        return fromJson<'r> json
      }

  type TableDesc =
    { Name:string
      Label:string
      LabelPlural:string
      Fields:FieldDesc list
      RelationShips:RelationShipDef list }
  and RelationShipDef =
    { RelationshipName:string
      ChildSObject:string
      Field: string }
  and FieldDesc =
    { Name:string
      Label:string
      Type:FieldType
      Length:int
      AutoNumber:bool
      Calculated:bool
      ReferenceTo:string list
      Nillable:bool }
  and FieldType =
    | Native of Type
    | Picklist of string list
  let parseType =
    function
    | "id" -> typeof<String>
    | "date"
    | "datetime" -> typeof<DateTime>
    | "boolean" -> typeof<Boolean>
    | "int" -> typeof<int32>
    | "long" -> typeof<int64>
    | "double" -> typeof<double>
    | _ -> typeof<String>

  let getObjectsDescUrls (i:Identity) =
    let uri = Config.BuildUri "https://%s.salesforce.com/services/data/v20.0/sobjects/"
    async {
      let! rs = get i uri
      let! json = rs.Content.ReadAsStringAsync() |> Async.AwaitTask
      let o = JObject.Parse json
      return o.SelectTokens("sobjects[*].urls.describe")
              |> Seq.map (fun d -> d.ToString())
              |> Seq.toList
    }

  let getTableFromUrl (i:Identity) name =
    let baseUrl = Config.BuildUri "https://%s.salesforce.com"
    let url = baseUrl.AbsoluteUri + name
    async {
      let! rs = get i (Uri url)
      let! c = rs.Content.ReadAsStringAsync() |> Async.AwaitTask
      let j = JObject.Parse c
      let name = (j.Item "name").ToString()
      let labelPlural = (j.Item "labelPlural").ToString()
      let label = (j.Item "label").ToString()
      let fields =
        j.Item "fields"
        |> Seq.map (
          fun f -> 
            let autoNumber = f.Item "autoNumber" |> Convert.ToBoolean
            let fname = f.Item "name" |> Convert.ToString
            let fLabel = f.Item "label" |> Convert.ToString
            let typ = f.Item "type" |> Convert.ToString
            let length = f.Item "length" |> Convert.ToInt32
            let calculated = f.Item "calculated" |> Convert.ToBoolean
            let nillable = f.Item "nillable" |> Convert.ToBoolean
            let referenceTo = f.Item "referenceTo" |> fun t -> t.Children() |> Seq.map (fun t -> t.ToString()) |> Seq.toList
            let ft = 
              match typ with
              | "picklist" -> 
                let picklistValues = 
                  f.SelectTokens("picklistValues[*].value")
                  |> Seq.map (fun token -> token.ToString())
                  |> Seq.toList
                Picklist picklistValues
              | _ -> typ |> parseType |> Native
            { Name=fname; Label=fLabel; Type=ft; Length=length; ReferenceTo=referenceTo
              AutoNumber=autoNumber; Calculated=calculated; Nillable=nillable }
          )
        |> Seq.toList
      let childRelationships =
        j.Item "childRelationships"
        |> Seq.map (
          fun r -> 
            let o = r.Item "childSObject" |> Convert.ToString
            let name = r.Item "relationshipName" |> Convert.ToString
            let field = r.Item "field" |> Convert.ToString
            { RelationshipName=name; ChildSObject=o; Field=field }
        ) |> Seq.toList
      return { Name=name; Label=label; LabelPlural=labelPlural; Fields=fields; RelationShips=childRelationships; }
    }

  let getObjectsList (i:Identity) =
    async {
      let! names = getObjectsDescUrls i
      return!
        names
//          |> Seq.take 5
          |> Seq.map (getTableFromUrl i)
          |> Async.Parallel
    }

  type SoqlResult<'t> =
    { [<JsonProperty("totalSize")>] TotalSize:int
      [<JsonProperty("done")>] Done:bool
      [<JsonProperty("records")>] Records:'t[] }
  type InsertResult =
    { [<JsonProperty("id")>] Id:string
      [<JsonProperty("success")>] Success:bool
      [<JsonProperty("errors")>] Errors:string [] }

  let readResponse<'ts,'te> (rs:HttpResponseMessage) =
    async {
      let! json = rs.Content.ReadAsStringAsync() |> Async.AwaitTask
      match rs.StatusCode with
      | HttpStatusCode.Created
      | HttpStatusCode.OK -> return json |> fromJson<'ts> |> Success
      | _ -> return json |> fromJson<'te> |> Failure
    }
  let readRestResponse<'t> =
    readResponse<'t, RemoteError list>

  let executeSoql<'t> (i:Identity) (soql:string) =
    let uri = Config.BuildUri "https://%s.salesforce.com/services/data/v30.0/query/?q="
    let qurl = uri.ToString() + (Uri.EscapeUriString soql)
    async {
      let! rs = get i (Uri qurl)
      return! readRestResponse<'t SoqlResult> rs
    }
    
  let insert (i:Identity) (entity:#ISalesforceEntity) =
    let name = entity.GetType() |> findEntityName
    let uri = (Config.BuildUri "https://%s.salesforce.com/services/data/v30.0/sobjects/").ToString() + name + "/"
    async {
      let f = 
          fun (h:Headers.HttpRequestHeaders) -> 
            h.Add("Authorization", sprintf "Bearer %s" i.AccessToken)
      let! rs = entity |> toInsertJson |> send (Uri uri) "application/json" HttpMethod.Post (Some f)
      return! readRestResponse<InsertResult> rs
    }

  let update (i:Identity) (id:string) (entity:#ISalesforceEntity) =
    let name = entity.GetType() |> findEntityName
    let uri = (Config.BuildUri "https://%s.salesforce.com/services/data/v30.0/sobjects/").ToString() + name + "/" + id + "/"
    async {
      let f = 
          fun (h:Headers.HttpRequestHeaders) -> 
            h.Add("Authorization", sprintf "Bearer %s" i.AccessToken)
      let! rs = entity |> toInsertJson |> send (Uri uri) "application/json" HttpMethod.Patch (Some f)
      let! json = rs.Content.ReadAsStringAsync() |> Async.AwaitTask
      if String.IsNullOrWhiteSpace json
      then return true
      else return false
    }

  let delete (i:Identity) (id:string) (entity:#ISalesforceEntity) =
    let name = entity.GetType() |> findEntityName
    let uri = (Config.BuildUri "https://%s.salesforce.com/services/data/v30.0/sobjects/").ToString() + name + "/" + id + "/"
    async {
      let f = 
          fun (h:Headers.HttpRequestHeaders) -> 
            h.Add("Authorization", sprintf "Bearer %s" i.AccessToken)
      do! entity |> toInsertJson |> send (Uri uri) "application/json" HttpMethod.Delete (Some f) |> Async.Ignore
    }

  type Client (instanceName:string, authparams:ImpersonationParam) =
    let oauth:Identity option ref = ref None
    do Config.ProductionInstance <- instanceName
    let authenticate() =
      oauth := authenticateWithCredentials authparams |> Async.RunSynchronously |> Some
    let checkSession() =
      match !oauth with
      | None -> authenticate()
      | Some o when o.IsExired() -> authenticate()
      | _ -> ()
    let getIdentity() =
      match !oauth with
      | Some o -> o
      | None -> failwith "Not authenticated"
    member __.ExecuteSoql<'t> soql =
      checkSession()
      executeSoql<'t> (getIdentity()) soql
    member __.Insert<'t when 't :> ISalesforceEntity> (entity:'t) =
      checkSession()
      insert (getIdentity()) entity |> Async.RunSynchronously
    member __.Update<'t when 't :> ISalesforceEntity> (entity:'t) =
      checkSession()
      update (getIdentity()) entity.Id entity |> Async.RunSynchronously
    member __.Delete<'t when 't :> ISalesforceEntity> (entity:'t) =
      checkSession()
      delete (getIdentity()) entity.Id entity |> Async.RunSynchronously
    member __.GetTablesList() =
      checkSession()
      getObjectsList (getIdentity()) |> Async.StartAsTask
