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

let sf = TS()
//sf.Tables.Account.Name

query {
  for a in sf.Tables.Accounts do
    yield a
} |> Seq.take 2


let gt = sf.Tables.Accounts.GetType().GetGenericArguments().[0]
