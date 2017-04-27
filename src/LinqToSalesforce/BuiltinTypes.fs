namespace LinqToSalesforce.BuiltinTypes

open Newtonsoft.Json
open System
open System.Collections

[<CLIMutable>]
type Address = 
  { Accuracy:string
    City:string
    Country:string
    CountryCode:string
    Latitude:string
    Longitude:string
    PostalCode:string
    State:string
    StateCode:string
    Street:string }

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
and MultiSelectPicklistConverter() =
  inherit JsonConverter()
    override __.WriteJson (writer:JsonWriter,value:obj,_:JsonSerializer) =
      writer.WriteRawValue (value.ToString())
      writer.Flush()
    override __.ReadJson (reader:JsonReader,t:Type,_:obj,_:JsonSerializer) =
      let text = reader.Value.ToString()
      let m = t.GetMethod "Parse"
      m.Invoke(null, [|text|])
    override __.CanConvert (objectType:Type) =
      if not objectType.IsGenericType
      then false
      else objectType.GetGenericTypeDefinition() = typedefof<MultiSelectPicklist<_>>
