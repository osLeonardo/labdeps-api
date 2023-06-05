using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IConsultas
    {
        Task<HistoricoConsulta> CreateHistorico(UserLogin user, DateOnly dataConsulta, string tipoConsulta, string codigo, DateOnly dataReferencia, string intervalo);
    }
}
