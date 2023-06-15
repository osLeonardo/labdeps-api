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
        Task<HistoricoConsulta> CreateHistorico(UserLogin user, DateTime dataConsulta, string tipoConsulta, string codigo, DateTime dataReferencia, string intervalo);
    }
}
