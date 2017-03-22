(**
LinqToSalesforce tutorial
=========================

Generating your entities using Visual Studio plugin
---------------------------------------------------

Add diagram into your project:

- Select the project.

- Click on **Tools** ==> **"Create Salesforce linq entities"**.

![screen2](img/sf_plugin_screen2.gif)

Enter your credentials.

![authentication](img/sf_plugin_doc_1.png)

Select entities to generate.

![screen3](img/sf_plugin_screen3.gif)


Generating your entities using command line
------------------------

Developing with Salesforce SOQL Linq provider is like a "DB First" entity framework using.

NuGet packages contains 'LinqToSalesforce.ModelGenerator.exe' in tools folder

![nuget1](img/nuget1.png)

Run it with your credentials in command line:

```shell
 > LinqToSalesforce.ModelGenerator.exe --clientid ... --clientsecret ... --securitytoken ... --login ... 
    \ --password ... --instancename ... --outputfile "absolute_path_to\Models.cs"
```

Your 'Model.cs' should have things like:

```csharp
public class Account : ISalesforceEntity
{
    
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
            return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
    private System.String __Id;
    [EntityField(false)]
    public System.String Id
    {
        get { return __Id; }
        set { SetField(ref __Id, value); }
    }
    private System.String __Name;
    [EntityField(false)]
    public System.String Name
    {
        get { return __Name; }
        set { SetField(ref __Name, value); }
    }
}
// etc ...
```

Reading the database
--------------------

```csharp

using LinqToSalesforce;
using static System.Console;

var impersonationParam = new Rest.OAuth.ImpersonationParam(clientId, clientId, securityToken, username, password);
var context = new SalesforceDataContext("eu11", impersonationParam);

var accounts = (from a in context.Accounts
                where !a.Name.StartsWith("Company")
                select a).Take(10);
foreach (var account in accounts)
{
    WriteLine($"Account {account.Name} Industry: {account.Industry}");
    foreach (var contact in account.Contacts) // lazy load contacts
    {
        WriteLine($"contact: {contact.Name} - {contact.Phone} - {contact.LeadSource}");

        foreach (var @case in contact.Cases) // lazy load contact's cases
            WriteLine($"case: {@case.Id}");
    }
}
```

Updating the database
---------------------

SoqlContext contains an entity tracker.
So you can update your entities with:

```csharp

var accounts = from a in context.Accounts
                where a.Name.StartsWith("Company")
                select a;

foreach (var account in accounts)
{
    var newName = $"{account.Name}_{DateTime.Now.Ticks}";
    WriteLine($"Account {account.Name} renamed to {newName}");
    account.Name = newName;
}

context.Save(); // entities are detached from the tracker and saved on the server

```

Inserting the database
---------------------

SoqlContext contains an "Insert" method.
When you use it, the entity is directly sent to Salesforce and attached to the tracker.
So you can change properties after inserts.

```csharp

for (var i = 0; i < 100; i++)
{
    var account = new Account { Name = $"Company {i}" };
    context.Insert(account);
}

```

Deleting entities
-----------------

```csharp

var accounts = from a in context.Accounts
               where a.Name.StartsWith("Company")
               select a;

foreach (var account in accounts)
{
    context.Delete(account);
}

context.Save();

```


*)

