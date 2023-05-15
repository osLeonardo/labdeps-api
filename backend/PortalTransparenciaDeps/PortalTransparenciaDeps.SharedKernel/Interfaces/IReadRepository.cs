using Ardalis.Specification;

namespace PortalTransparenciaDeps.SharedKernel.Interfaces
{
    public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
    {
    }
}