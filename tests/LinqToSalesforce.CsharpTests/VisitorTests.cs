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

            // Assert
            var actualOperations = visitor.Operations;
            Assert.AreEqual(2, actualOperations.Count());
            AssertOrderOperation(actualOperations[0] as Visitor.Operation.Order, "Id");
            AssertOrderOperation(actualOperations[1] as Visitor.Operation.Order, "Lastname", Visitor.OrderDirection.Descending);
        }

        [Test]
        public void Visitor_OrElseExpression()
        {
            // Arrange
            var context = new FakeQueryContext(() => new List<Customer>());

            // Act
            var customers = context.GetTable<Customer>();
            var query = customers.AsQueryable().Where(x => x.Firstname == "popo" || x.Lastname == "papa");
            var queryExp = query.Expression;
            var visitor = new Visitor.RequestExpressionVisitor(queryExp);
            visitor.Visit();

            // Assert
            var actualOperations = visitor.Operations;
            Assert.AreEqual(1, actualOperations.Count());
            var operation = actualOperations.First() as Visitor.Operation.Where;
            var compareOperation = operation.Item as Visitor.WhereArgs.BinaryComparison;
            AssertUnaryComparison(compareOperation.Item1, "Firstname", "popo", Visitor.ComparisonKind.Equal);
            Assert.AreEqual(Visitor.BinaryComparisonKind.Or, compareOperation.Item2);
            AssertUnaryComparison(compareOperation.Item3, "Lastname", "papa", Visitor.ComparisonKind.Equal);
        }

        [Test]
        public void Visitor_AndExpression()
        {
            // Arrange
            var context = new FakeQueryContext(() => new List<Customer>());

            // Act
            var customers = context.GetTable<Customer>();
            var query = customers.AsQueryable().Where(x => x.Firstname == "popo" && x.Lastname == "papa");
            var queryExp = query.Expression;
            var visitor = new Visitor.RequestExpressionVisitor(queryExp);
            visitor.Visit();

            // Assert
            var actualOperations = visitor.Operations;
            Assert.AreEqual(1, actualOperations.Count());
            var operation = actualOperations.First() as Visitor.Operation.Where;
            var compareOperation = operation.Item as Visitor.WhereArgs.BinaryComparison;
            AssertUnaryComparison(compareOperation.Item1, "Firstname", "popo", Visitor.ComparisonKind.Equal);
            Assert.AreEqual(Visitor.BinaryComparisonKind.And, compareOperation.Item2);
            AssertUnaryComparison(compareOperation.Item3, "Lastname", "papa", Visitor.ComparisonKind.Equal);
        }

        #region Helpers
        private static void AssertOrderOperation(Visitor.Operation.Order operation, string fieldName, Visitor.OrderDirection direction = null)
        {
            if (direction == null) direction = Visitor.OrderDirection.Ascending;

            Assert.IsNotNull(operation);
            Assert.AreEqual(direction, operation.Item1);
            Assert.AreEqual(fieldName, (operation.Item2 as Visitor.Field).Name);
        }

        private static void AssertUnaryComparison(Visitor.WhereArgs args, string fieldName, object fieldValue, Visitor.ComparisonKind comparisonKind)
        {
            var unaryOperation = args as Visitor.WhereArgs.UnaryComparison;
            if (unaryOperation == null) Assert.Fail();

            Assert.AreEqual(fieldName, unaryOperation.Item.Field.Name);
            Assert.AreEqual(comparisonKind, unaryOperation.Item.Kind);
            Assert.AreEqual(fieldValue, (unaryOperation.Item.Target as Visitor.ComparisonTarget.Constant).Item);
        }
        #endregion
    }
}
