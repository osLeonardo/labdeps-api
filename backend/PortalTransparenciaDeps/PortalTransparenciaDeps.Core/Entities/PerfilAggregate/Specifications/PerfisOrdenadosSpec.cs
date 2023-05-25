using Ardalis.Specification;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using System.Linq;

namespace PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Specifications
{
    public class PerfisOrdenadosSpec : Specification<Perfil>
    {
        public PerfisOrdenadosSpec()
        {
            Query.AsNoTracking().Where(perfil => perfil.Ativo)
                 .OrderBy(perfil => perfil.Ordem);
        }
    }
}
