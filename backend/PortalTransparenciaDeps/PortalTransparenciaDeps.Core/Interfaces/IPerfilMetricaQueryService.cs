using PortalTransparenciaDeps.Core.DTO;
using System.Collections.Generic;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IPerfilMetricaQueryService
    {
        List<ParametrizacaoMetricaDto> ListParametrizacaoMetricaPorPerfilOuMetrica(int? perfilId, int? metricaId);
    }
}
