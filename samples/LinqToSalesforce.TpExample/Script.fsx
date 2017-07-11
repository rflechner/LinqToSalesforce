#load "../../packages/FsLab/Themes/AtomChester.fsx"
#load "../../packages/FsLab/FsLab.fsx"

#I @"../../packages/Newtonsoft.Json/lib/net40"
#r "Newtonsoft.Json.dll"
#I "../../src/LinqToSalesforce.TypeProvider/bin/debug/"
#r "LinqToSalesforce.dll"
#r "LinqToSalesforce.TypeProvider.dll"

open Deedle
open System
open FSharp.Charting
open XPlot
open XPlot.Plotly
open System
open System.IO
open System.Net
open LinqToSalesforce
open SalesforceProvider
open Rest
open Rest.OAuth

ServicePointManager.SecurityProtocol <- SecurityProtocolType.Tls12 ||| SecurityProtocolType.Tls11
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
  If you don't know how to get those infos, then follow this tutorial:
  https://rflechner.github.io/LinqToSalesforce/getting_started_with_salesforce.html
*)

Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

let [<Literal>] authfile = @"C:\dev\LinqToSalesforce\src\Files\OAuth.config.json"
let [<Literal>] cacheFolder = __SOURCE_DIRECTORY__ + "\\.cache"
let [<Literal>] slidingExpiration = 200.
type TS = SalesforceTypeProvider<authFile=authfile, instanceName="eu11", cacheFolder=cacheFolder, slidingExpirationMinutes=slidingExpiration>
let authJson = File.ReadAllText authfile
let sf = TS(authJson, cacheFolder, (TimeSpan.FromMinutes slidingExpiration))

query {
  for a in sf.Tables.Accounts do
    select (a.Name, a.CreatedDate)
}
|> Seq.toList
|> List.groupBy(fun (_, date) -> date.ToString("MMMM yyyy", System.Globalization.CultureInfo.InvariantCulture))
|> List.map(fun (month, group) -> month, group.Length)
|> Chart.Line
|> Chart.WithLayout (Layout(title = "Accounts creation by month"))
|> Chart.WithLegend true
|> Chart.WithHeight 500
|> Chart.WithWidth 700

let industryCounts =
  query {
    for a in sf.Tables.Accounts do
      select a.Industry
  }
  |> Seq.toList
  |> List.groupBy (fun industry ->
        if String.IsNullOrWhiteSpace industry
        then "Unknown"
        else industry
    )
  |> List.map(fun (industry, group) -> industry, group.Length)

industryCounts
    |> Chart.Area
    |> Chart.WithLayout (Layout(title = "Accounts by industry"))
    |> Chart.WithLegend true
    |> Chart.WithHeight 500
    |> Chart.WithWidth 700

industryCounts
|> List.map (fun (name, count) -> name => count)
|> Series.ofObservations
