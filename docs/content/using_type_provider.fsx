(*** hide ***)
#load "../../packages/FsLab/Themes/AtomChester.fsx"
#load "../../packages/FsLab/FsLab.fsx"
#I @"../../packages/Newtonsoft.Json/lib/net40"
#r "Newtonsoft.Json.dll"
#I "../../src/LinqToSalesforce.TypeProvider/bin/debug/"
#r "LinqToSalesforce.dll"
#r "LinqToSalesforce.TypeProvider.dll"



(**

Using F# type provider
======================

For the moment, the NugGet is only on my personal MyGet feed, which can be used as a package source: https://www.myget.org/F/romcyber/api/v2

<div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      The Salesforce.TypeProvider library can be <a href="https://www.myget.org/Package/Details/romcyber?packageType=nuget&packageId=Salesforce.TypeProvider">installed from MyGet</a>:
      <pre>PM> Install-Package Salesforce.TypeProvider</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

In this tutorial we will simply try to generate basic stats of our salesforce accounts
*)

(**
 Open module and namespaces 
*)

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

(**
We must specify TLS protocol versions to avoid misterious Salesforce authentication errors.

(May cause some problems with MONO :( )
*)

ServicePointManager.SecurityProtocol <- SecurityProtocolType.Tls12 ||| SecurityProtocolType.Tls11

(**
We can use a JSON file containing authentication informations.

This json contains something like:
```json
{
    "Clientid":"xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
    "Clientsecret":"xxxxxxxxxxxxxxxxxxxx",
    "Securitytoken":"xxxxxxxxxxxx",
    "Username":"login@mail.com",
    "Password":"xxxxxxxxxxxxx",
    "Instacename":"eu11" // or "login" or "test"
}
```

If you don't know how to get those infos, then follow this tutorial:
https://rflechner.github.io/LinqToSalesforce/getting_started_with_salesforce.html

*)
Environment.CurrentDirectory <- __SOURCE_DIRECTORY__
let [<Literal>] authfile = @"C:\prog\LinqToSalesforce\src\Files\OAuth.config.json"

(**
During the 'Design time' a type provider frequently discovering generated structures.

To reduce risks of exceeding maximum allowed requests per 24 hours, 
we will use a tiny cache stored in files and shared between 'Design time' and 'Runtime'.
*)
let [<Literal>] cacheFolder = __SOURCE_DIRECTORY__ + "\\.cache"
// 200 minutes (if you don't change frequently your tables structures, then increase it)
let [<Literal>] slidingExpiration = 200. 

(**
Generate your type (could take 2 minutes the first time if your bandwith is not good)
*)

type TS = SalesforceTypeProvider<
            authFile=authfile, instanceName="eu11", 
            cacheFolder=cacheFolder, slidingExpirationMinutes=slidingExpiration>

(**
Now instanciate your generated type with authentication informations
*)

let authJson = File.ReadAllText @"C:\prog\LinqToSalesforce\src\Files\OAuth.config.json"
let sf = TS(authJson, cacheFolder, (TimeSpan.FromMinutes slidingExpiration))

(**
Exploring data
--------------

You can create a script like `LinqToSalesforce.TpExample\Script.fsx`.

I suggest you use it with Atom and ionide.io ( cf. http://tomasp.net/blog/2016/fslab-ionide/ )
*)

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

(**
The result is cool

![typeprovider](img/atom_fslab1.png)

Sending data to Salesforce
-----------------------

You can update an entity
*)

let account1 =
  query {
    for a in sf.Tables.Accounts do
      take 1
      select a
  }
  |> Seq.head

account1.Phone <- "1234548478"
sf.Save account1

(**
You can also add a new one
*)

let na = TS.AccountEntity.CreateNew()
na.Name <- "TP Account"
sf.Save na


