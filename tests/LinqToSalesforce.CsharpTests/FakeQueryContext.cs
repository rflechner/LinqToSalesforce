using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LinqToSalesforce.CsharpTests
{
    public class FakeQueryContext : IQueryContext
    {
        private readonly Func<object>[] _builders;
        private int _buildCount;

        public FakeQueryContext(params Func<object>[] builders)
        {
            _builders = builders;
        }

        private object CreateInstance(Type type)
        {
            if (!_builders.Any())
                return Activator.CreateInstance(type);

            var instance = _builders[_buildCount]();

            if (_buildCount++ >= _builders.Length)
                _buildCount = 0;

            return instance;
        }

        public object Execute(Expression expression, bool isEnumerable)
        {
            var visitor = new Visitor.RequestExpressionVisitor(expression);
            visitor.Visit();
            Operations = visitor.Operations;
            var rt = visitor.GetReturnType();
            var type = typeof(List<>).MakeGenericType(rt);
            var instance = CreateInstance(type);

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