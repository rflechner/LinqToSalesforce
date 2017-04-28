namespace LinqToSalesforce.BuiltinTypes

open Newtonsoft.Json
open System
open System.Collections

[<CLIMutable>]
type Address = 
  { [<JsonProperty("geocodeAccuracy")>] GeocodeAccuracy:string
    [<JsonProperty("city")>] City:string
    [<JsonProperty("country")>] Country:string
    [<JsonProperty("countryCode")>] CountryCode:string
    [<JsonProperty("latitude")>] Latitude:string
    [<JsonProperty("longitude")>] Longitude:string
    [<JsonProperty("postalCode")>] PostalCode:string
    [<JsonProperty("state")>] State:string
    [<JsonProperty("stateCode")>] StateCode:string
    [<JsonProperty("street")>] Street:string }

[<CLIMutable>]
type MultiSelectPicklist<'t> =
  { SelectedValues:'t array }
  override __.ToString() =
    let names = __.SelectedValues |> Array.map (fun v -> v.ToString())
    System.String.Join(";", names)
  static member Parse (text:string) =
    let parts = text.Split ';'
    let parse = typeof<'t>.GetMethod "Parse"
    let values = 
      parts
      |> Seq.map (fun p -> parse.Invoke (null, [|p|]))
      |> Seq.cast<'t>
      |> Seq.toArray
    { SelectedValues = values }
  static member From(values:string array) = 
    let t = typeof<'t> //TODO: change this for better perfs ...
    let m = t.GetMethod "Parse"
    let vals = values |> Array.map (fun a -> m.Invoke(null, [|a|]) :?> 't)
    { SelectedValues = vals }
  static member op_Implicit = MultiSelectPicklist<'t>.From

and MultiSelectPicklistConverter() =
  inherit JsonConverter()
    override __.WriteJson (writer:JsonWriter,value:obj,_:JsonSerializer) =
      writer.WriteValue(value.ToString())
      writer.Flush()
    override __.ReadJson (reader:JsonReader,t:Type,_:obj,_:JsonSerializer) =
      if isNull reader.Value
      then
        null
      else
        let text = reader.Value.ToString()
        let m = t.GetMethod "Parse"
        m.Invoke(null, [|text|])
    override __.CanConvert (objectType:Type) =
      if not objectType.IsGenericType
      then false
      else objectType.GetGenericTypeDefinition() = typedefof<MultiSelectPicklist<_>>
