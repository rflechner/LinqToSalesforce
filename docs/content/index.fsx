(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"
#I "../../bin/LinqToSalesforce"
#r "LinqToSalesforce.dll"
#r "Newtonsoft.Json.dll"

(**
LinqToSalesforce
======================

Documentation

<!--div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      The LinqToSalesforce library can be <a href="https://nuget.org/packages/LinqToSalesforce">installed from NuGet</a>:
      <pre>PM> Install-Package LinqToSalesforce</pre>
    </div>
  </div>
  <div class="span1"></div>
</div-->


<div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      The LinqToSalesforce library can be <a href="https://www.myget.org/Package/Details/romcyber?packageType=nuget&packageId=LinqToSalesforce">installed from MyGet</a>:
      <pre>PM> Install-Package LinqToSalesforce</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

It will be pushed on NuGet.org after more tests and some missing features implementations.

Example
-------

This example demonstrates how to use LINQ to SOQL.
In this example, we search 10 accounts where name starts with "Company" and industry is "Biotechnology".

Then we can iterate their contacts and cases using lazy loading.

This Linq provider is written in FSharp but is originally made to use in CSharp

In csharp
---------

```csharp

var impersonationParam = new Rest.OAuth.ImpersonationParam(clientId, clientId, securityToken, username, password);
var context = new SalesforceDataContext("eu11", impersonationParam);

var accounts = (from a in context.Accounts
                where !a.Name.StartsWith("Company")
                    && a.Industry == PickAccountIndustry.Biotechnology
                select a).Take(10);
foreach (var account in accounts)
{
    WriteLine($"Account {account.Name} Industry: {account.Industry}");
    var contacts = account.Contacts;
    foreach (var contact in contacts)
    {
        WriteLine($"contact: {contact.Name} - {contact.Phone} - {contact.LeadSource}");

        var cases = contact.Cases;
        foreach (var @case in cases)
        {
            WriteLine($"case: {@case.Id}");
        }
    }
}
```

Futur developments
==================

For MONO users
--------------

Salesforce deactivate old SSL protocol versions.

So we need to use something difficult to use with MONO:

```csharp

ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;

```

Solutions will be proposed next.

For FSHARP developpers
----------------------

Code generator is currently generating C# only.
But a type provider will be developed soon because F# type providers are magic.

![giphy1](img/giphy1.gif)


 
Contributing and copyright
--------------------------

The project is hosted on [GitHub][gh] where you can [report issues][issues], fork 
the project and submit pull requests. If you're adding a new public API, please also 
consider adding [samples][content] that can be turned into a documentation. You might
also want to read the [library design notes][readme] to understand how it works.

The library is available under Public Domain license, which allows modification and 
redistribution for both commercial and non-commercial purposes. For more information see the 
[License file][license] in the GitHub repository. 

  [content]: https://github.com/rflechner/LinqToSalesforce/tree/master/docs/content
  [gh]: https://github.com/rflechner/LinqToSalesforce
  [issues]: https://github.com/rflechner/LinqToSalesforce/issues
  [readme]: https://github.com/rflechner/LinqToSalesforce/blob/master/README.md
  [license]: https://github.com/rflechner/LinqToSalesforce/blob/master/LICENSE.txt
*)
