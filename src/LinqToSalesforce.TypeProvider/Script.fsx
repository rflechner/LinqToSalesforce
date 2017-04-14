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
//var impersonationParam = new Rest.OAuth.ImpersonationParam(clientId, clientId, securityToken, username, password);
//let impersonationParam = Rest.OAuth.ImpersonationParam.FromJson json
Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

let [<Literal>] authfile = @"C:\prog\LinqToSalesforce\src\Files\OAuth.config.json"
let authparams = authfile |> File.ReadAllText |> ImpersonationParam.FromJson

type TS = SalesforceTypeProvider<authFile=authfile, instanceName="eu11">

let authJson = File.ReadAllText @"C:\prog\LinqToSalesforce\src\Files\OAuth.config.json"
//let sf = TS()
let sf = TS(authJson)
//sf.Tables.Account.Name

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

for a in accounts do
  printfn "name: %A" a.Name
  printfn "CreatedDate: %A" a.CreatedDate



//let gt = sf.Tables.Accounts.GetType().GetGenericArguments().[0]

