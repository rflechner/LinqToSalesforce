open Argu
open System
open System.IO
open LinqToSalesforce
open Rest
open Rest.OAuth
open System.Data.Entity.Design.PluralizationServices
open System.Globalization

let c = CultureInfo "en-us"
let ps = PluralizationService.CreateService c

type Arguments =
    | [<Mandatory>] Login of string
    | [<Mandatory>] Password of string
    | [<Mandatory>] ClientId of string
    | [<Mandatory>] ClientSecret of string
    | [<Mandatory>] SecurityToken of string
    | [<Mandatory>] InstanceName of string
    | Namespace of string
    | OutputFile of string
with
  interface IArgParserTemplate with
    member s.Usage =
      match s with
      | Login _ -> "specify Salesforce login."
      | Password _ -> "specify Salesforce password."
      | ClientId _ -> "specify application client id."
      | ClientSecret _ -> "specify application client secret."
      | SecurityToken _ -> "specify security token sent by mail."
      | InstanceName _ -> "instance name 'test' or 'login', etc ..."
      | Namespace _ -> "namespace of generated C#."
      | OutputFile _ -> "output file (stdout by default)."

[<EntryPoint>]
let main argv = 
    let parser = ArgumentParser.Create<Arguments>(programName = System.AppDomain.CurrentDomain.FriendlyName)
    try
      let args = parser.Parse argv
      let login = args.GetResult(<@ Login @>)
      let password = args.GetResult(<@ Password @>)
      let clientId = args.GetResult(<@ ClientId @>)
      let clientSecret = args.GetResult(<@ ClientSecret @>)
      let securityToken = args.GetResult(<@ SecurityToken @>)
      let instaceName = args.GetResult(<@ InstanceName @>, defaultValue="login")
      let ns = args.GetResult(<@ Namespace @>, defaultValue="LinqToSalesforce")
      let outputFile = args.GetResult(<@ OutputFile @>, defaultValue="")

      let authparams = 
        { ClientId=clientId
          ClientSecret=clientSecret
          SecurityToken=securityToken
          Username=login
          Password=password }
      Config.ProductionInstance <- instaceName
      let oauth = authenticateWithCredentials authparams |> Async.RunSynchronously
      let log:string Action = new Action<string> (fun s -> ())
      let tables = getObjectsList oauth log |> Async.RunSynchronously
      let cs = CodeGeneration.generateCsharp (Array.ofList tables) ns
      if String.IsNullOrWhiteSpace outputFile
      then printfn "%s" cs
      else File.WriteAllText(outputFile, cs)
    with
    | e -> 
      printf "%s" e.Message
    0 // return an integer exit code
