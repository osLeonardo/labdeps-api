using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Models.SerproAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface ISerproCnpj
    {
        Task<ExternalResponseObject<SerproBasicoModel>> GetConsultaBasica(string ni);
        Task<ExternalResponseObject<SerproQsaModel>> GetConsultaQsa(string ni);
        Task<ExternalResponseObject<SerproEmpresaModel>> GetConsultaEmpresa(string ni);
    }
}
