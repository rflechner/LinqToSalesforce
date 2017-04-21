#I @"..\..\packages\Newtonsoft.Json\lib\net45\"
#r "Newtonsoft.Json.dll"
#load "../LinqToSalesforce/Caching.fs"

open System
open System.IO
open System.Text
open System.Text.RegularExpressions
open Caching

let parseTypeProviderMemberName exp =
  let regex = new Regex(@".* ToFSharpFunc .* GetMemberValue .* Invoke .* \""(?<MemberName>[a-zA-Z0-9\s_-]*)\""", RegexOptions.IgnorePatternWhitespace)
  let m = regex.Match exp
  if m.Success
  then Some(m.Groups.["MemberName"].Value)
  else None

let exp1 = """Convert(ToFSharpFunc(arg00 => ToFSharpFunc(arg10 => a.GetMemberValue(arg00, arg10))).Invoke("Name").Invoke("System.String"))"""
let exp2 = """ToFSharpFunc(arg00 => ToFSharpFunc(arg10 => a.GetMemberValue(arg00, arg10))).Invoke("Name").Invoke("System.String")"""

let m1 = parseTypeProviderMemberName exp1
let m2 = parseTypeProviderMemberName exp2


let cache = FileCache (Path.Combine(__SOURCE_DIRECTORY__, ".cache"))

cache.Get<string> "001"
cache.Add "001" "coucou" (TimeSpan.FromMinutes 1.)
cache.Get<string> "001"

let k2 = computeKey "http://www.romcyber.com/fsharp/2016/04/30/Huffman-in-Fsharp.html"


