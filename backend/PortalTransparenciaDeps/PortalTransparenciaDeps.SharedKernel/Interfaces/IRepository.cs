using Ardalis.Specification;

namespace PortalTransparenciaDeps.SharedKernel.Interfaces
{
    public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
    {
    }
}