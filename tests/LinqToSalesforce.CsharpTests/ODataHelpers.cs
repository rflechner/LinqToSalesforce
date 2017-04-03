using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSalesforce.CsharpTests
{
    /// <summary>
    /// ExpressionHelpers: https://github.com/OData/WebApi/blob/master/OData/src/System.Web.OData/OData/ExpressionHelpers.cs
    /// ExpressionHelperMethods: https://github.com/OData/WebApi/blob/master/OData/src/System.Web.OData/OData/ExpressionHelperMethods.cs
    /// LinqParameterContainer: https://github.com/OData/WebApi/blob/master/OData/src/System.Web.Http.OData/OData/Query/Expressions/LinqParameterContainer.cs
    /// </summary>
    public static class ODataHelpers
    {
        private static MethodInfo _enumerableTakeMethod = GenericMethodOf(_ => Enumerable.Take<int>(default(IEnumerable<int>), default(int)));
        private static MethodInfo _queryableTakeMethod = GenericMethodOf(_ => Queryable.Take<int>(default(IQueryable<int>), default(int)));
        private static MethodInfo _skipMethod = GenericMethodOf(_ => Queryable.Skip<int>(default(IQueryable<int>), default(int)));
        private static MethodInfo _enumerableSkipMethod = GenericMethodOf(_ => Enumerable.Skip<int>(default(IEnumerable<int>), default(int)));

        public static Expression Take(Expression source, int count, Type elementType, bool parameterize)
        {
            MethodInfo takeMethod;
            if (typeof(IQueryable).IsAssignableFrom(source.Type))
            {
                takeMethod = _queryableTakeMethod.MakeGenericMethod(elementType);
            }
            else
            {
                takeMethod = _enumerableTakeMethod.MakeGenericMethod(elementType);
            }

            Expression takeValueExpression = parameterize ? LinqParameterContainer.Parameterize(typeof(int), count) : Expression.Constant(count);
            Expression takeQuery = Expression.Call(null, takeMethod, new[] { source, takeValueExpression });
            return takeQuery;
        }

        public static Expression Skip(Expression source, int count, Type type, bool parameterize)
        {
            MethodInfo skipMethod;
            if (typeof(IQueryable).IsAssignableFrom(source.Type))
            {
                skipMethod = _skipMethod.MakeGenericMethod(type);
            }
            else
            {
                skipMethod = _enumerableSkipMethod.MakeGenericMethod(type);
            }

            Expression skipValueExpression = parameterize ? LinqParameterContainer.Parameterize(typeof(int), count) : Expression.Constant(count);
            Expression skipQuery = Expression.Call(null, skipMethod, new[] { source, skipValueExpression });
            return skipQuery;
        }

        private static MethodInfo GenericMethodOf<TReturn>(Expression<Func<object, TReturn>> expression)
        {
            return GenericMethodOf(expression as Expression);
        }

        private static MethodInfo GenericMethodOf(Expression expression)
        {
            LambdaExpression lambdaExpression = expression as LambdaExpression;

            //Contract.Assert(expression.NodeType == ExpressionType.Lambda);
            //Contract.Assert(lambdaExpression != null);
            //Contract.Assert(lambdaExpression.Body.NodeType == ExpressionType.Call);

            return (lambdaExpression.Body as MethodCallExpression).Method.GetGenericMethodDefinition();
        }


        // wraps a constant value so that EntityFramework paramterizes the constant.
        // wraps a constant value so that EntityFramework paramterizes the constant.
        internal abstract class LinqParameterContainer
        {
            private static ConcurrentDictionary<Type, Func<object, LinqParameterContainer>> _ctors = new ConcurrentDictionary<Type, Func<object, LinqParameterContainer>>();

            // the value of the constant.
            public abstract object Property { get; }

            public static Expression Parameterize(Type type, object value)
            {
                // () => new LinqParameterContainer(constant).Property
                // instead of returning a constant expression node, wrap that constant in a class the way compiler 
                // does a closure, so that EF can parameterize the constant (resulting in better performance due to expression translation caching).
                LinqParameterContainer containedValue = LinqParameterContainer.Create(type, value);
                return Expression.Property(Expression.Constant(containedValue), "TypedProperty");
            }

            private static LinqParameterContainer Create(Type type, object value)
            {
                return _ctors.GetOrAdd(type, t =>
                {
                    MethodInfo createMethod = typeof(LinqParameterContainer).GetMethod("CreateInternal").MakeGenericMethod(t);
                    ParameterExpression valueParameter = Expression.Parameter(typeof(object));
                    return
                        Expression.Lambda<Func<object, LinqParameterContainer>>(
                            Expression.Call(
                                createMethod,
                                Expression.Convert(valueParameter, t)),
                            valueParameter)
                        .Compile();
                })(value);
            }

            // invoked dynamically at runtime.
            public static LinqParameterContainer CreateInternal<T>(T value)
            {
                return new TypedLinqParameterContainer<T>(value);
            }

            // having a strongly typed property avoids the a cast in the property access expression that would be 
            // generated for this constant.
            internal class TypedLinqParameterContainer<T> : LinqParameterContainer
            {
                public TypedLinqParameterContainer(T value)
                {
                    TypedProperty = value;
                }

                public T TypedProperty { get; set; }

                public override object Property
                {
                    get { return TypedProperty; }
                }
            }
        }

    }
}
