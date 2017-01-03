module LinqToSalesforce.GenerationTests

open System
open LinqToSalesforce
open NUnit.Framework
open CodeGeneration

[<Test>]
let ``given table names when I generate entity names`` () =
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


