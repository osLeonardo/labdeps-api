using Ardalis.Specification;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using System.Linq;

namespace PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Specifications
{
    public class PerfisComOrdemMaiorOuIgualSpec : Specification<Perfil>
    {
        public PerfisComOrdemMaiorOuIgualSpec(int ordem)
        {
            Query.AsNoTracking().Where(perfil => perfil.Ordem >= ordem)
                .OrderBy(perfil => perfil.Ordem);
        }
    }
}
