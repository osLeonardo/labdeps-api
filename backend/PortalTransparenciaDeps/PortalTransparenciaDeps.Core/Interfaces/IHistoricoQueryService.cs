using PortalTransparenciaDeps.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IHistoricoQueryService
    {
        List<HistoricoDto> ListHistorico();
        HistoricoDto GetHistorico(int id);
    }
}
