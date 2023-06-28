using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.RemuneracaoAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IRemuneracao
    {
        Task<Remuneracao> CreateRemuneracao(int idServidor, int idRemuneracoesDTO, int idHistoricoConsulta, Servidor servidor, HistoricoConsulta historicoConsulta, ICollection<RemuneracoesDTO> remuneracoesDTOs);
    }
}
