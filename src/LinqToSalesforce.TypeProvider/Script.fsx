#I @"../../packages/Newtonsoft.Json/lib/net40"
#r "Newtonsoft.Json.dll"
#I "bin/debug/"
#r "LinqToSalesforce.dll"
#r "LinqToSalesforce.TypeProvider.dll"

open System
open System.IO
open System.Net
open LinqToSalesforce
open SalesforceProvider
open Rest
open Rest.OAuth

System.Net.ServicePointManager.ServerCertificateValidationCallback <- (fun _ _ _ _ -> true)
ServicePointManager.SecurityProtocol <- SecurityProtocolType.Tls12 ||| SecurityProtocolType.Tls11
//let json = Path.Combine(__SOURCE_DIRECTORY__, "../Files/OAuth.config.json") |> File.ReadAllText
(*
  This json contains something like:
{
    "Clientid":"xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
    "Clientsecret":"xxxxxxxxxxxxxxxxxxxx",
    "Securitytoken":"xxxxxxxxxxxx",
    "Username":"login@mail.com",
    "Password":"xxxxxxxxxxxxx",
    "Instacename":"eu11" // or "login" or "test"
}
*)

Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

let [<Literal>] authfile = @"C:\prog\LinqToSalesforce\src\Files\OAuth.config.json"
let [<Literal>] cacheFolder = __SOURCE_DIRECTORY__ + "\\.cache"
let [<Literal>] slidingExpiration = 20.
type TS = SalesforceTypeProvider<authFile=authfile, instanceName="eu11", cacheFolder=cacheFolder, slidingExpirationMinutes=slidingExpiration>

let authJson = File.ReadAllText @"C:\prog\LinqToSalesforce\src\Files\OAuth.config.json"
let sf = TS(authJson, cacheFolder, (TimeSpan.FromMinutes slidingExpiration))

//let users = 
//  query {
//    for u in sf.Tables.Users do
//      where (u.Name.Contains "ro")
//      select u
//  } |> Seq.toArray

let account1 =
  query {
    for a in sf.Tables.Accounts do
      take 1
      select a
  }
  |> Seq.head

account1.Phone <- "1234548478"
sf.Save account1

let accounts =
  query {
    for a in sf.Tables.Accounts do
      // where (a.Name.Contains "cool" || a.Name.Contains "company")
      //where (a.Name = "cool name")
      // take 2
      // //sortBy a.CreatedDate
      // sortByDescending a.CreatedDate
      select (a.Name, a.AccountNumber, a.CreatedDate)
  }
  |> Seq.toArray

let na = TS.AccountEntity.CreateNew()
na.Name <- "TP Account"
sf.Save na

let contacts = 
  query {
    for c in sf.Tables.Contacts do
      select (c.Name)
  } |> Seq.toArray

for a in accounts do
  printfn "name: %A" a.Name
  printfn "CreatedDate: %A" a.CreatedDate



//let gt = sf.Tables.Accounts.GetType().GetGenericArguments().[0]

