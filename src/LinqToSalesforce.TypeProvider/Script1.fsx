open System
open System.Text
open System.Text.RegularExpressions


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



