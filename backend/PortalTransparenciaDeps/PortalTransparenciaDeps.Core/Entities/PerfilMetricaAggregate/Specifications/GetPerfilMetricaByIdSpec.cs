using Ardalis.Specification;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate;
using System.Linq;

namespace PortalTransparenciaDeps.Core.Entities.PoliticaAggregate.Specifications
{
    public class GetPerfilMetricaByIdSpec : Specification<PerfilMetrica>, ISingleResultSpecification
    {
        public GetPerfilMetricaByIdSpec(int id)
        {
            Query.Where(x => x.Id == id)
                .Include(x => x.Perfil)
                .Include(x => x.ParametrizacoesMetrica)
                    .ThenInclude(x => x.AgrupadorParametrizacao);
        }
    }
}
