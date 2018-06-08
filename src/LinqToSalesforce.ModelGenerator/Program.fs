open Argu
open System
open System.IO
open LinqToSalesforce
open Rest
open Rest.OAuth

type Arguments =
    | Login of string
    | Password of string
    | ClientId of string
    | ClientSecret of string
    | SecurityToken of string
    | [<Mandatory>] InstanceName of string
    | Namespace of string
    | OutputFile of string
    | OAuthFile of string
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
      | OAuthFile _ -> "OAuthFile (only if you don't pass credentials via other params)."

[<EntryPoint>]
let main argv = 
    let parser = ArgumentParser.Create<Arguments>(programName = System.AppDomain.CurrentDomain.FriendlyName)
    try
      let args = parser.Parse argv
      let login = args.TryGetResult(<@ Login @>)
      let password = args.TryGetResult(<@ Password @>)
      let clientId = args.TryGetResult(<@ ClientId @>)
      let clientSecret = args.TryGetResult(<@ ClientSecret @>)
      let securityToken = args.TryGetResult(<@ SecurityToken @>)
      let instaceName = args.GetResult(<@ InstanceName @>, defaultValue="login")
      let ns = args.GetResult(<@ Namespace @>, defaultValue="LinqToSalesforce")
      let outputFile = args.GetResult(<@ OutputFile @>, defaultValue="")
      let oauthFile = args.TryGetResult(<@ OAuthFile @>)
      
      let impersonation =
        match login, password, clientId, clientSecret, securityToken, oauthFile with
        | Some l, Some p, Some id, Some secret, Some token, None ->
          Some { ClientId=id; ClientSecret=secret; SecurityToken=token; Username=l; Password=p }
        | None, None, None, None, None, Some filePath ->
          filePath |> File.ReadAllText |> ImpersonationParam.FromJson |> Some
        | _ -> None
      match impersonation with
      | Some authparams ->
          Config.ProductionInstance <- instaceName
          let oauth = authenticateWithCredentials authparams |> Async.RunSynchronously
          let tables = getObjectsList oauth |> Async.RunSynchronously
          let cs = CodeGeneration.generateCsharp tables ns
          if String.IsNullOrWhiteSpace outputFile
          then printfn "%s" cs
          else File.WriteAllText(outputFile, cs)
      | None ->
          parser.PrintUsage() |> printfn "%s"
    with
    | e -> 
      printf "%s" e.Message
    0 // return an integer exit code
