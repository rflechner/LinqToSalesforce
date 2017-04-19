namespace LinqToSalesforce

open System
open System.Collections.Generic
open System.ComponentModel
open Newtonsoft.Json.Linq

type ISalesforceEntity = 
  inherit INotifyPropertyChanged
  abstract member Id : string with get,set
  abstract member UpdatedProperties : IDictionary<string, obj> with get
  abstract member TrackPropertyUpdates : unit -> unit

module Entities =
  type JsonEntity (o:JObject) =
    let event = Event<_, _>()
    interface INotifyPropertyChanged with
      member __.add_PropertyChanged(e) =
          event.Publish.AddHandler(e)
      member this.remove_PropertyChanged(e) =
          event.Publish.RemoveHandler(e)
    interface ISalesforceEntity with
      member val Id="" with get,set
      member __.TrackPropertyUpdates(): unit = ()
      member __.UpdatedProperties: IDictionary<string,obj> = [] |> dict
    override __.ToString() = if isNull o then "null" else o.ToString()
    member __.Json = o
    member __.GetMember fn (``type``:Type) =
      let token = o.SelectToken fn
      token.ToObject ``type``
    member __.GetMemberValue fn (typename:string) =
      let ``type`` = Type.GetType typename
      __.GetMember fn ``type``
    member __.SetMemberValue fn (value:obj) =
      let token = o.SelectToken fn
      let jt = JToken.FromObject value
      token.Replace jt

  type Tracker() =
    let entities = new HashSet<ISalesforceEntity>()
    
    member __.Clear() =
      entities.Clear()

    member __.Track e =
      if not <| entities.Contains e
      then entities.Add e |> ignore
    
    member __.GetTrackedEntities() =
      entities |> Seq.toList

