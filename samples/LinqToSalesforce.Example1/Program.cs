using System;
using System.IO;
using System.Linq;
using System.Net;
using static System.Console;

namespace LinqToSalesforce.Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;

            var json = File.ReadAllText("../../../../src/Files/OAuth.config.json");
            /*
             This json contains something like:
            {
                "Clientid":"xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
                "Clientsecret":"xxxxxxxxxxxxxxxxxxxx",
                "Securitytoken":"xxxxxxxxxxxx",
                "Username":"login@mail.com",
                "Password":"xxxxxxxxxxxxx",
                "Instacename":"eu11" // or "login" or "test"
            }
             */
            //var impersonationParam = new Rest.OAuth.ImpersonationParam(clientId, clientId, securityToken, username, password);
            var impersonationParam = Rest.OAuth.ImpersonationParam.FromJson(json);
            var context = new SalesforceDataContext("eu11", impersonationParam);
            try
            {
                var notExisting = context.Accounts.FirstOrDefault(a => a.Name == "dzdzdz");

                var accounts = from a in context.Accounts
                                   //where a.CreatedDate >= DateTime.Today
                              // where a.NumberBugc > 0.1
                               select a;

                var accountCreatedToday = accounts.Take(5).ToList();

                WriteLine($"{accountCreatedToday.Count}");

                for (var i = 0; i < 10; i++)
                {
                    var account = new Account { Name = $"Company {i}" };
                    context.Insert(account);
                }

                RenameAccountsStartingWithCompany(context);

                DeleteAccountsStartingWithCompany(context);

                DisplayAccountsWithTheirContactsAndCases(context);
            }
            catch (AggregateException ex)
            {
                WriteLine($"Error: {ex.Message}");
                foreach (var e in ex.InnerExceptions)
                    WriteLine($"Error: {e.Message}");
            }
            catch (Exception ex)
            {
                WriteLine($"Error: {ex.Message}");
            }

            WriteLine("Press any key to continue ...");
            ReadKey(true);
        }

        static void DeleteAccountsStartingWithCompany(SoqlContext context)
        {
            var accounts = from a in context.GetTable<Account>()
                           where a.Name.StartsWith("Company")
                           select a;

            foreach (var account in accounts)
            {
                context.Delete(account);
            }

            context.Save();
        }

        static void RenameAccountsStartingWithCompany(SoqlContext context)
        {
            var accounts = from a in context.GetTable<Account>()
                           where a.Name.StartsWith("Company")
                           select a;

            foreach (var account in accounts)
            {
                var newName = $"{account.Name}_{DateTime.Now.Ticks}";
                WriteLine($"Account {account.Name} renamed to {newName}");
                account.Name = newName;
            }

            context.Save();
        }

        private static void DisplayAccountsWithTheirContactsAndCases(SoqlContext context)
        {
            var accounts = (from a in context.GetTable<Account>()
                            where !a.Name.StartsWith("Company")
                                && a.Industry == PickAccountIndustry.Biotechnology
                                && PickAccountIndustry.Biotechnology == a.Industry
                            select a)
                //.Skip(1) // not implemented on all REST API versions
                .Take(10)
                .ToList();

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
        }
    }
}
