module LinqToSalesforce.GenerationTests

open System
open LinqToSalesforce
open NUnit.Framework
open CodeGeneration
open Translator

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

type Account () =
  inherit Object()

[<EntityName("Account")>]
type Account_toto () =
  inherit Object()

[<Test>]
let ``given type when I search entity names`` () =
  Assert.AreEqual(findEntityName (typeof<Account>), "Account")
  Assert.AreEqual(findEntityName (typeof<Account_toto>), "Account")


