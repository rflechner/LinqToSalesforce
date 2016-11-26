using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LinqToSalesforce.CsharpTests
{
    [TestFixture]
    public class ExpressionLinqTests
    {
        [Test]
        public void WhenSelectCustomer_ShouldBeOnlySelectTokenWithAllProperties()
        {
            var context = new FakeQueryContext();
            var customers = context.GetTable<Customer>();
            var selected =
                from c in customers
                select c;
            var array = selected.ToArray();
            Assert.IsTrue(typeof(IEnumerable<Customer>).IsAssignableFrom(array.GetType()));

            Assert.AreEqual(1, context.Operations.Length);
            var @select = context.Operations.OfType<Visitor.Operation.Select>().Single();
            Assert.AreEqual(typeof(Customer), ((Visitor.SelectArgs.SelectType)@select.Item).Item);
        }

        [Test]
        public void WhenSelectCustomerWhereFirstnameIsPopo_ShouldBe2Tokens()
        {
            var context = new FakeQueryContext();
            var customers = context.GetTable<Customer>();
            var selected =
                from c in customers
                where c.Firstname == "popo"
                select c;
            var array = selected.ToArray();
            Assert.IsTrue(typeof(IEnumerable<Customer>).IsAssignableFrom(array.GetType()));

            Assert.AreEqual(1, context.Operations.Length);
            var @where = context.Operations.OfType<Visitor.Operation.Where>().Single();
            var comparison = (Visitor.WhereArgs.UnaryComparison)@where.Item;
            Assert.AreEqual(typeof(string), comparison.Item.Field.Type);
            Assert.AreEqual("Firstname", comparison.Item.Field.Name);
            Assert.AreEqual(Visitor.ComparisonKind.Equal, comparison.Item.Kind);
            Assert.IsTrue(comparison.Item.Target.IsConstant);
            Assert.AreEqual("popo", ((Visitor.ComparisonTarget.Constant)comparison.Item.Target).Item);
        }

        [Test]
        public void WhenSelectBirthCustomerWhereFirstnameIsPopo_ShouldBe2Tokens()
        {
            var context = new FakeQueryContext();
            var customers = context.GetTable<Customer>();
            var selected =
                from c in customers
                where c.Firstname == "popo"
                select c.Birth;
            var array = selected.ToArray();

            Assert.IsTrue(typeof(IEnumerable<DateTime>).IsAssignableFrom(array.GetType()));

            Assert.AreEqual(2, context.Operations.Length);
            var @select = context.Operations.OfType<Visitor.Operation.Select>().Single();
            Assert.AreEqual(typeof(DateTime), ((Visitor.SelectArgs.Fields)@select.Item).Item.Head.Field.Type);
            Assert.AreEqual("Birth", ((Visitor.SelectArgs.Fields)@select.Item).Item.Head.Field.Name);
            Assert.AreEqual(1, ((Visitor.SelectArgs.Fields)@select.Item).Item.Length);

            var @where = context.Operations.OfType<Visitor.Operation.Where>().Single();
            var comparison = (Visitor.WhereArgs.UnaryComparison)@where.Item;
            Assert.AreEqual(typeof(string), comparison.Item.Field.Type);
            Assert.AreEqual("Firstname", comparison.Item.Field.Name);
        }

        [Test]
        public void WhenSelectBirthCustomerWhereFirstnameIsPopoAndBirthGreatherOrEqualThan02Feb1985_ShouldBe2ComparisonAnd1SelectTokens()
        {
            var context = new FakeQueryContext();
            var customers = context.GetTable<Customer>();
            var dateTime = new DateTime(1985, 02, 11);
            var selected =
                from c in customers
                where c.Firstname == "popo" && c.Birth >= dateTime
                select c.Birth;
            var array = selected.ToArray();

            Assert.IsTrue(typeof(IEnumerable<DateTime>).IsAssignableFrom(array.GetType()));

            Assert.AreEqual(2, context.Operations.Length);
            var @select = context.Operations.OfType<Visitor.Operation.Select>().Single();
            Assert.AreEqual(typeof(DateTime), ((Visitor.SelectArgs.Fields)@select.Item).Item.Head.Field.Type);
            Assert.AreEqual("Birth", ((Visitor.SelectArgs.Fields)@select.Item).Item.Head.Field.Name);
            Assert.AreEqual(1, ((Visitor.SelectArgs.Fields)@select.Item).Item.Length);

            var @where = context.Operations.OfType<Visitor.Operation.Where>().Single();
            var binaryComparison = ((Visitor.WhereArgs.BinaryComparison)@where.Item);
            var cmp1 = ((Visitor.WhereArgs.UnaryComparison)binaryComparison.Item1).Item;
            Assert.AreEqual(typeof(string), cmp1.Field.Type);
            Assert.AreEqual("Firstname", cmp1.Field.Name);

            Assert.AreEqual(Visitor.BinaryComparisonKind.And, binaryComparison.Item2);

            var cmp2 = ((Visitor.WhereArgs.UnaryComparison)binaryComparison.Item3).Item;
            Assert.AreEqual(typeof(DateTime), cmp2.Field.Type);
            Assert.AreEqual("Birth", cmp2.Field.Name);

            var value = ((Visitor.ComparisonTarget.Constant)cmp2.Target).Item;
            Assert.AreEqual(dateTime, value);
        }

        [Test]
        public void WhenSelectBirthAndIdCustomerWhereFirstnameIsPopoAndBirthGreatherOrEqualThan02Feb1985_ShouldBe2ComparisonAnd1SelectTokens()
        {
            var context = new FakeQueryContext();
            var customers = context.GetTable<Customer>();
            var dateTime = new DateTime(1985, 02, 11);
            var selected =
                from c in customers
                where c.Firstname == "popo" && c.Birth >= dateTime
                select new
                {
                    c.Id,
                    c.Birth
                };
            var array = selected.ToList();
            var type = array.GetType().GenericTypeArguments.Single();
            var properties = type.GetProperties();
            Assert.AreEqual("Id", properties[0].Name);
            Assert.AreEqual(typeof(Guid), properties[0].PropertyType);
            Assert.AreEqual("Birth", properties[1].Name);
            Assert.AreEqual(typeof(DateTime), properties[1].PropertyType);
        }

        [Test]
        public void WhenSelectCustomerWhereFirstnameIsPopoInnerJoinBasket_ShouldBe2Tokens()
        {
            var context = new FakeQueryContext();
            var customers = context.GetTable<Customer>();
            var baskets = context.GetTable<Basket>();

            var customBaskets =
                from c in customers
                where c.Firstname == "popo"
                join basket in baskets on c.Id equals basket.CustomerId
                select basket;

            var array = customBaskets.ToList();
            Assert.IsTrue(typeof(IEnumerable<Basket>).IsAssignableFrom(array.GetType()));

            Assert.AreEqual(1, context.Operations.Length);
            var @join = context.Operations.OfType<Visitor.Operation.Join>().Single();
            Assert.AreEqual("Id", @join.Item3.Name);
            Assert.AreEqual(typeof(Guid), @join.Item3.Type);
            Assert.AreEqual("CustomerId", @join.Item4.Name);
            Assert.AreEqual(typeof(Guid), @join.Item4.Type);

            var @where = (Visitor.Operation.Where)@join.Item1.Head;
            var comparison = (Visitor.WhereArgs.UnaryComparison)@where.Item;
            Assert.AreEqual(typeof(string), comparison.Item.Field.Type);
            Assert.AreEqual("Firstname", comparison.Item.Field.Name);
            Assert.AreEqual(Visitor.ComparisonKind.Equal, comparison.Item.Kind);
            Assert.IsTrue(comparison.Item.Target.IsConstant);
            Assert.AreEqual("popo", ((Visitor.ComparisonTarget.Constant)comparison.Item.Target).Item);
        }

        [Test]
        public void WhenSelectBirthAsBornDateAndIdCustomerWhereFirstnameIsPopoAndBirthGreatherOrEqualThan02Feb1985_ShouldBe2ComparisonAnd1SelectTokens()
        {
            var context = new FakeQueryContext();
            var customers = context.GetTable<Customer>();
            var dateTime = new DateTime(1985, 02, 11);
            var selected =
                from c in customers
                where c.Firstname == "popo" && c.Birth >= dateTime
                select new
                {
                    c.Id,
                    BornDate = c.Birth
                };
            var soql = selected.ToString();
            var array = selected.ToList();
            var type = array.GetType().GenericTypeArguments.Single();
            var properties = type.GetProperties();
            Assert.AreEqual("Id", properties[0].Name);
            Assert.AreEqual(typeof(Guid), properties[0].PropertyType);
            Assert.AreEqual("BornDate", properties[1].Name);
            Assert.AreEqual(typeof(DateTime), properties[1].PropertyType);
            
            var @select = context.Operations.OfType<Visitor.Operation.Select>().Single();
            Assert.AreEqual(typeof(DateTime), ((Visitor.SelectArgs.Fields)@select.Item).Item[1].Field.Type);
            Assert.AreEqual("Birth", ((Visitor.SelectArgs.Fields)@select.Item).Item[1].Field.Name);
            Assert.AreEqual("BornDate", ((Visitor.SelectArgs.Fields)@select.Item).Item[1].Alias.Value);
            Assert.AreEqual(2, ((Visitor.SelectArgs.Fields)@select.Item).Item.Length);
        }
    }
}
