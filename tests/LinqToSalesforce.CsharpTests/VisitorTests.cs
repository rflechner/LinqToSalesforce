using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LinqToSalesforce.CsharpTests
{
    /// <summary>
    /// Tests verify how Visitor components handles standard linq expressions.
    /// </summary>
    [TestFixture]
    public class VisitorTests
    {
        [Test]
        public void Visitor_OrderingSimple()
        {
            // Arrange
            var context = new FakeQueryContext(() => new List<Customer>());

            // Act
            var customers = context.GetTable<Customer>();
            var query = customers.AsQueryable().OrderBy(x => x.Id);
            var queryExp = query.Expression;
            var visitor = new Visitor.RequestExpressionVisitor(queryExp);
            visitor.Visit();

            // Assert
            var actualOperations = visitor.Operations;
            Assert.AreEqual(1, actualOperations.Count());
            var operation = actualOperations.First() as Visitor.Operation.Order;
            AssertOrderOperation(operation, "Id");
        }

        [Test]
        public void Visitor_OrderingDescending()
        {
            // Arrange
            var context = new FakeQueryContext(() => new List<Customer>());

            // Act
            var customers = context.GetTable<Customer>();
            var query = customers.AsQueryable().OrderByDescending(x => x.Id);
            var queryExp = query.Expression;
            var visitor = new Visitor.RequestExpressionVisitor(queryExp);
            visitor.Visit();

            // Assert
            var actualOperations = visitor.Operations;
            Assert.AreEqual(1, actualOperations.Count());
            var operation = actualOperations.First() as Visitor.Operation.Order;
            AssertOrderOperation(operation, "Id", Visitor.OrderDirection.Descending);
        }

        [Test]
        public void Visitor_MultipleOrdering()
        {
            // Arrange
            var context = new FakeQueryContext(() => new List<Customer>());

            // Act
            var customers = context.GetTable<Customer>();
            var query = customers.AsQueryable().OrderBy(x => x.Id).ThenBy(x => x.Lastname);
            var queryExp = query.Expression;
            var visitor = new Visitor.RequestExpressionVisitor(queryExp);
            visitor.Visit();

            // Assert
            var actualOperations = visitor.Operations;
            Assert.AreEqual(2, actualOperations.Count());
            AssertOrderOperation(actualOperations[0] as Visitor.Operation.Order, "Id");
            AssertOrderOperation(actualOperations[1] as Visitor.Operation.Order, "Lastname");
        }

        [Test]
        public void Visitor_MultipleOrderingDifferentDirection()
        {
            // Arrange
            var context = new FakeQueryContext(() => new List<Customer>());

            // Act
            var customers = context.GetTable<Customer>();
            var query = customers.AsQueryable().OrderBy(x => x.Id).ThenByDescending(x => x.Lastname);
            var queryExp = query.Expression;
            var visitor = new Visitor.RequestExpressionVisitor(queryExp);
            visitor.Visit();
            query.ToString();
            // Assert
            var actualOperations = visitor.Operations;
            Assert.AreEqual(2, actualOperations.Count());
            AssertOrderOperation(actualOperations[0] as Visitor.Operation.Order, "Id");
            AssertOrderOperation(actualOperations[1] as Visitor.Operation.Order, "Lastname", Visitor.OrderDirection.Descending);
        }

        private static void AssertOrderOperation(Visitor.Operation.Order operation, string fieldName, Visitor.OrderDirection direction = null)
        {
            if (direction == null) direction = Visitor.OrderDirection.Ascending;

            Assert.IsNotNull(operation);
            Assert.AreEqual(direction, operation.Item1);
            Assert.AreEqual(fieldName, (operation.Item2 as Visitor.Field).Name);
        }
    }
}
