using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IPerfilMetricaService
    {
        Task AdicionarPerfilMetricaPorPerfilAsync(Perfil perfil);
        Task AtualizarPerfisMetricasAsync(List<CadastroPerfilMetricaDto> perfisMetricas);
    }
}
