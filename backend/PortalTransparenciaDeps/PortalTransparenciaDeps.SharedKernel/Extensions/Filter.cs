using System;
using System.Linq.Expressions;

namespace PortalTransparenciaDeps.SharedKernel.Extensions
{
    public static class Filter
    {
        public static Expression<Func<T, bool>> Create<T>(Expression<Func<T, bool>> predicate = null) => predicate is null ? x => true : predicate;

        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> func1, Expression<Func<T, bool>> func2) => func1 is null ? func1 : func1.CombineWithAndAlso(func2);

        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> func1, Expression<Func<T, bool>> func2) => func1 is null ? func2 : func1.CombineWithOrElse(func2);

        public static Expression<Func<T, bool>> AndWhen<T>(this Expression<Func<T, bool>> func1, Expression<Func<T, bool>> func2, Func<bool> condition)
        {
            var shouldFilter = condition.Invoke();

            if (func1 is null)
            {
                if (!shouldFilter)
                {
                    return null;
                }

                return func2;
            }

            return shouldFilter ? func1.CombineWithAndAlso(func2) : func1;
        }
    }
}
