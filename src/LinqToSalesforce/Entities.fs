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
  //  let mutable propval = 0.0
  //  member this.MyProperty
  //    with get() = propval
  //    and  set(v) =
  //        propval <- v
  //        event.Trigger(this, new PropertyChangedEventArgs("MyProperty"))
    interface INotifyPropertyChanged with
      member this.add_PropertyChanged(e) =
          event.Publish.AddHandler(e)
      member this.remove_PropertyChanged(e) =
          event.Publish.RemoveHandler(e)
    interface ISalesforceEntity with
      member val Id="" with get,set
      member this.TrackPropertyUpdates(): unit = 
        ()
      member this.UpdatedProperties: Collections.Generic.IDictionary<string,obj> = 
        [] |> dict
    override __.ToString() =
      if isNull o then "null" else o.ToString()

  type Tracker() =
    let entities = new System.Collections.Generic.HashSet<ISalesforceEntity>()
    
    member __.Clear() =
      entities.Clear()

    member __.Track e =
      if not <| entities.Contains e
      then entities.Add e |> ignore
    
    member __.GetTrackedEntities() =
      entities |> Seq.toList

