using Ardalis.Specification;
using System.Linq;

namespace PortalTransparenciaDeps.Core.Specification
{
    public static class SpecificationExtensions
    {
        public static ISpecificationBuilder<T> AplicarPaginacao<T>(this ISpecificationBuilder<T> query, int page, int size)
        {
            var skip = (page - 1) * size;
            return query.Skip(skip).Take(size);
        }
    }
}
