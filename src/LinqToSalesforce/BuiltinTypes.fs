namespace LinqToSalesforce.BuiltinTypes

open Newtonsoft.Json

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
  { SelectedValue:'t array }
  override __.ToString() =
    let names = __.SelectedValue |> Array.map (fun v -> v.ToString())
    System.String.Join(";", names)
  static member Parse (text:string) =
    let values = 
      text.Split ';'
      |> Array.map (fun part -> System.Convert.ChangeType(part, typeof<'t>) :?> 't)
    { SelectedValue = values }
and MultiSelectPicklistConverter() =
  inherit JsonConverter()
    override __.WriteJson(writer:JsonWriter,value:obj,serializer:JsonSerializer) =
      value.ToString()
      writer.WriteRawValue (value.ToString())
      writer.Flush()
    override __.ReadJson(_:JsonReader,_:Type,_:obj,_:JsonSerializer) =
      unbox ""
    override __.CanConvert(objectType:Type) =
      typeof<IDictionary<string,ObjectDefinition>>.IsAssignableFrom objectType
