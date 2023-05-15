using Ardalis.Specification;
using System.Linq;

namespace PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate.Specifications
{
    public class MetricasWithParametrizacaoSpec : Specification<PerfilMetrica>
    {
        public MetricasWithParametrizacaoSpec()
        {
            Query.AsNoTracking().Where(p => p.ParametrizacoesMetrica.Any());
        }
    }
}
