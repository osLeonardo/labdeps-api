using Ardalis.Specification.EntityFrameworkCore;
using PortalTransparenciaDeps.SharedKernel.Interfaces;

namespace PortalTransparenciaDeps.Infrastructure.Data
{
    // inherit from Ardalis.Specification type
    public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
    {
        public EfRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
