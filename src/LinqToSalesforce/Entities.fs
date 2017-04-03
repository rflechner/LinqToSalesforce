namespace LinqToSalesforce

open System
open System.Collections.Generic
open System.ComponentModel

type ISalesforceEntity = 
  inherit INotifyPropertyChanged
  abstract member Id : string with get,set
  abstract member UpdatedProperties : IDictionary<string, obj> with get
  abstract member TrackPropertyUpdates : unit -> unit

module Entities =
  
  type Tracker() =
    let entities = new System.Collections.Generic.HashSet<ISalesforceEntity>()
    
    member __.Clear() =
      entities.Clear()

    member __.Track e =
      if not <| entities.Contains e
      then entities.Add e |> ignore
    
    member __.GetTrackedEntities() =
      entities |> Seq.toList

