using Ardalis.Specification;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.SharedKernel.Interfaces
{
    public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
    {
    }
}