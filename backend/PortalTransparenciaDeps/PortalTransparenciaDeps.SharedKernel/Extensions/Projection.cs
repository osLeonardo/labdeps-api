using System;
using System.Linq.Expressions;

namespace PortalTransparenciaDeps.SharedKernel.Extensions
{
    public static class Projection
    {
        public static Expression<Func<T, T>> Create<T>(Expression<Func<T, T>> predicate = null) => predicate is null ? null : predicate;

        public static Expression<Func<TIn, TOut>> Create<TIn, TOut>(Expression<Func<TIn, TOut>> predicate = null) => predicate is null ? null : predicate;

        public static Expression<Func<TIn, TOut>> And<TIn, TOut>(this Expression<Func<TIn, TOut>> func1, Expression<Func<TIn, TOut>> func2) => func1 is null ? func2 : func1.CombineWithAndAlso(func2);

        public static Expression<Func<TIn, TOut>> Or<TIn, TOut>(this Expression<Func<TIn, TOut>> func1, Expression<Func<TIn, TOut>> func2) => func1 is null ? func2 : func1.CombineWithOrElse(func2);

        public static Expression<Func<TIn, TOut>> AndWhen<TIn, TOut>(this Expression<Func<TIn, TOut>> func1, Expression<Func<TIn, TOut>> func2, Func<bool> condition)
        {
            var shouldProject = condition.Invoke();

            if (func1 is null)
            {
                if (!shouldProject)
                {
                    return null;
                }

                return func2;
            }

            return shouldProject ? func1.CombineWithAndAlso(func2) : func1;
        }
    }
}
