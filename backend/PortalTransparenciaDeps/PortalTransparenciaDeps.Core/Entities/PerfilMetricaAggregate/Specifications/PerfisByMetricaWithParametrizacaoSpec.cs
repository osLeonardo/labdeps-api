using Ardalis.Specification;
using System.Linq;

namespace PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate.Specifications
{
    public class PerfisByMetricaWithParametrizacaoSpec : Specification<PerfilMetrica>
    {
        public PerfisByMetricaWithParametrizacaoSpec(int metricaId)
        {
            Query.AsNoTracking()
                .Where(p => p.MetricaId == metricaId && p.ParametrizacoesMetrica.Any() && p.Perfil.Ativo)
                .Include(p => p.Perfil)
                .OrderBy(p => p.Perfil.Ordem);
        }
    }
}
