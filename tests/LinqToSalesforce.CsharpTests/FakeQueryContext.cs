using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LinqToSalesforce.CsharpTests
{
    public class FakeQueryContext : IQueryContext
    {
        public object Execute(Expression expression, bool isEnumerable)
        {
            var visitor = new Visitor.RequestExpressionVisitor(expression);
            visitor.Visit();
            Operations = visitor.Operations;
            var rt = visitor.GetReturnType();
            var type = typeof(List<>).MakeGenericType(rt);
            var instance = Activator.CreateInstance(type);

            //var visitor = new QueryExpressionVisitor();
            //var instance = visitor.Visit(expression);

            return instance;
        }

        public Visitor.Operation[] Operations { get; private set; }

        public Queryable<T> GetTable<T>()
        {
            var tableName = typeof(T).Name;
            var queryProvider = new QueryProvider(this, tableName);

            return new Queryable<T>(queryProvider, tableName);
        }
    }

    public class Customer
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birth { get; set; }
    }

    public class Basket
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public decimal TotalAmount { get; set; }
        public int ItemCount { get; set; }
        public bool Received { get; set; }
    }
}