using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Entities.DadosPublicosAggregate;
using PortalTransparenciaDeps.Core.Models.QA_DadospublicosAggregate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IQA_DadosPublicos
    {
        Task<ExternalResponseObject<DadosModel>> GetDados(string data);
    }
}
