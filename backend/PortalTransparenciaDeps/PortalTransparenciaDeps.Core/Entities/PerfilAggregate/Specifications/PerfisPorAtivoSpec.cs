using Ardalis.Specification;
using PortalTransparenciaDeps.Core.Specification;
using System.Linq;

namespace PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Specifications
{
    public class PerfisPorAtivoSpec : Specification<Perfil>
    {
        public PerfisPorAtivoSpec(bool ativo, string nome, int? page = null, int? size = null)
        {
            Query
                .AsNoTracking()
                .Where(perfil => perfil.Ativo == ativo);

            if (!string.IsNullOrEmpty(nome))
            {
                Query.Where(perfil => perfil.Nome.ToUpper().Contains(nome.ToUpper()));
            }

            Query.OrderBy(perfil => perfil.Nome);

            if (page.HasValue)
            {
                Query.AplicarPaginacao(page.Value, size.Value);
            }
        }
    }
}
