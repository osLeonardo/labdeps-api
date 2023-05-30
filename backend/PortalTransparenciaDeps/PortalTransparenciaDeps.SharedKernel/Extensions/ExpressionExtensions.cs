using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PortalTransparenciaDeps.SharedKernel.Extensions
{
    internal static class ExpressionExtensions
    {
        public static Expression<Func<TIn, TOut>> CombineWithAndAlso<TIn, TOut>(this Expression<Func<TIn, TOut>> func1, Expression<Func<TIn, TOut>> func2)
        {
            return Expression.Lambda<Func<TIn, TOut>>(
                Expression.AndAlso(
                    func1.Body, new ExpressionParameterReplacer(func2.Parameters, func1.Parameters).Visit(func2.Body)),
                func1.Parameters);
        }

        public static Expression<Func<TIn, TOut>> CombineWithOrElse<TIn, TOut>(this Expression<Func<TIn, TOut>> func1, Expression<Func<TIn, TOut>> func2)
        {
            return Expression.Lambda<Func<TIn, TOut>>(
                Expression.OrElse(
                    func1.Body, new ExpressionParameterReplacer(func2.Parameters, func1.Parameters).Visit(func2.Body)),
                func1.Parameters);
        }

        private class ExpressionParameterReplacer : ExpressionVisitor
        {
            public ExpressionParameterReplacer(IList<ParameterExpression> fromParameters, IList<ParameterExpression> toParameters)
            {
                ParameterReplacements = new Dictionary<ParameterExpression, ParameterExpression>();
                for (int i = 0; i != fromParameters.Count && i != toParameters.Count; i++)
                    ParameterReplacements.Add(fromParameters[i], toParameters[i]);
            }

            private IDictionary<ParameterExpression, ParameterExpression> ParameterReplacements { get; set; }

            protected override Expression VisitParameter(ParameterExpression node)
            {
                ParameterExpression replacement;
                if (ParameterReplacements.TryGetValue(node, out replacement))
                    node = replacement;
                return base.VisitParameter(node);
            }
        }
    }
}
