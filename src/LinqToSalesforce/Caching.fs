module Caching

open System
open System.IO
open System.Text

let computeKey (s:string) = 
  let md5 = System.Security.Cryptography.MD5.Create()
  let inputBytes = System.Text.Encoding.ASCII.GetBytes s
  let hash = md5.ComputeHash inputBytes
  let sb = new StringBuilder()
  for h in hash do
    sb.Append(h.ToString("X2")) |> ignore
  sb.ToString()

type CacheItem<'t> =
  { Date:DateTime
    Item:'t
    Duration:TimeSpan}
  member __.IsExpired () =
    __.Date + __.Duration < DateTime.UtcNow
  static member Build<'t> (item:'t) (duration:TimeSpan) =
    { Date=DateTime.UtcNow; Item=item; Duration=duration }
  member __.ToJson () =
    Newtonsoft.Json.JsonConvert.SerializeObject __
  static member FromJson (json:string) =
    try
      Newtonsoft.Json.JsonConvert.DeserializeObject<CacheItem<'t>>(json)
    with | e -> raise(Exception("invalid json: " + json, e))

type FileCache(basePath:string) =
  do Directory.CreateDirectory basePath |> ignore
  let locker = Object()
  
  member __.Get<'t> (key:string) =
    lock locker 
      (fun _ ->
        try
          let fp = Path.Combine(basePath, key) 
          if File.Exists fp
          then
            let content = File.ReadAllText fp
            let cacheItem = CacheItem<'t>.FromJson(content)
            if cacheItem.IsExpired ()
            then
              File.Delete fp
              None
            else Some cacheItem.Item
          else None
        with
          | _ -> None
      )

  member __.Add<'t> (key:string) (item:'t) duration =
    lock locker 
      (fun _ ->
        let cacheItem = CacheItem.Build item duration
        let fp = Path.Combine(basePath, key)
        let json = cacheItem.ToJson()
        File.WriteAllText(fp, json)
      )




