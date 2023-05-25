using Ardalis.Specification;
using System.Collections.Generic;
using System.Linq;

namespace PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate.Specifications
{
    public class ListPerfilMetricaByIdsSpec : Specification<PerfilMetrica>
    {
        public ListPerfilMetricaByIdsSpec(List<int> ids)
        {
            Query.Where(x => ids.Contains(x.Id));
        }
    }
}
