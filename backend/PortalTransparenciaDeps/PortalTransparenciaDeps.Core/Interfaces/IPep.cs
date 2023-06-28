using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PepAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IPep
    {
        Task<Pep> CreatePep(string codOrgao, string cpf, string descricaoFuncao, string dtFimCarencia, string dtFimExercicio, string dtInicioExercicio, string nivelFuncao, string nome, string nomeOrgao, string siglaFuncao, int idHistoricoConsulta, HistoricoConsulta historicoConsulta);
    }
}
