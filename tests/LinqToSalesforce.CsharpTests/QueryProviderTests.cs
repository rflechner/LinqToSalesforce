using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LinqToSalesforce.CsharpTests
{
    [TestFixture]
    public class QueryProviderTests
    {
        [Test]
        public void QueryProvider_WhenSelectCustomerWhereFirstnameIsPopo_SelectQuery()
        {
            var context = new FakeQueryContext(() => new List<Customer>());

            // Prepare query expression
            var customers = context.GetTable<Customer>();
            var queryExpr = customers.Where(x => x.Firstname == "popo").Expression;
            
            // Execute query expression
            var provider = new QueryProvider(context, "Customer");
            var query = (provider as IQueryProvider).CreateQuery(queryExpr);

            // Asset
            Assert.AreEqual("SELECT  FROM Customer WHERE Firstname = 'popo'", query.ToString());
        }
    }
}
