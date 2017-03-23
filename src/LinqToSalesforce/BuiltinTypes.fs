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

