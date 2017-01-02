module LinqToSalesforce.GenerationTests

open System
open LinqToSalesforce
open NUnit.Framework

[<Test>]
let ``hello returns 42`` () =
  let result = 42
  printfn "%i" result
  Assert.AreEqual(42,result)

[<Test>]
let ``given table names when I generate entity names`` () =
  let ucFirst (s:string) =
    match s.ToCharArray() |> Seq.toList with
    | c :: t ->
      let f = Char.ToUpper c
      [f] @ t |> List.toArray |> String
    | _ -> s

  let fixName (name:string) = 
    let parts = 
      name.Split([|' ';'_';'-'|], StringSplitOptions.RemoveEmptyEntries)
        |> Array.filter (fun p -> p <> "c")
        |> Array.map ucFirst
    String.Join("", parts)

  let testWith (expected:string) (candidate:string) =
    let result = fixName candidate
    Assert.AreEqual(expected,result)

  testWith "Popo" "popo"
  testWith "Popo" "Popo"
  testWith "PoPo" "PoPo"
  testWith "PoPo" "Po_Po"
  testWith "PoPo" "Po_po"
  testWith "DlrsLookupRollupSummary" "dlrs__LookupRollupSummary__c"
  testWith "LookupRollupSummary" "LookupRollupSummary__c"


