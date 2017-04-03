using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LinqToSalesforce.CsharpTests
{
    /// <summary>
    /// Tests verify how Visitor components handles scenarios introduced by WebAPI OData components.
    /// OData components use more complex approach to forming Expression, than usually done through Linq.
    /// Tests use original OData components to produce test expressions.
    /// </summary>
    [TestFixture]
    public class VisitorODataTests
    {

        [Test]
        public void Visitor_OData_TakeSimple()
        {
            // Arrange
            var context = new FakeQueryContext(() => new List<Customer>());
            var limit = (int)10;

            // Act
            var customers = context.GetTable<Customer>();
            var queryExp = ODataHelpers.Take(customers.AsQueryable().Expression, limit, typeof(Customer), true);
            var visitor = new Visitor.RequestExpressionVisitor(queryExp);
            visitor.Visit();

            // Assert
            var actualOperations = visitor.Operations;
            Assert.AreEqual(1, actualOperations.Count());
            var takeOperation = actualOperations.First();
            Assert.IsTrue(takeOperation.IsLimit);
            Assert.AreEqual(limit, ((Visitor.Operation.Limit)takeOperation).Item);
        }

        [Test]
        public void Visitor_OData_SkipSimple()
        {
            // Arrange
            var context = new FakeQueryContext(() => new List<Customer>());
            var limit = (int)10;

            // Act
            var customers = context.GetTable<Customer>();
            var queryExp = ODataHelpers.Skip(customers.AsQueryable().Expression, limit, typeof(Customer), true);
            var visitor = new Visitor.RequestExpressionVisitor(queryExp);
            visitor.Visit();

            // Assert
            var actualOperations = visitor.Operations;
            Assert.AreEqual(1, actualOperations.Count());
            var takeOperation = actualOperations.First();
            Assert.IsTrue(takeOperation.IsSkip);
            Assert.AreEqual(limit, ((Visitor.Operation.Skip)takeOperation).Item);
        }


    }
}
