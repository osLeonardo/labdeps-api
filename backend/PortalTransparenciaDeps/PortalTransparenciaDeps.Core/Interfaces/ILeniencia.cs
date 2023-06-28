using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.LenienciaAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface ILeniencia
    {
        Task<Leniencia> CreateLeniencia(string dataFimAcordo, string dataIncioAcordo, string orgaoResponsavel, int quantidade, string situacaoAcordo, int idSancoes, int idHistoricoConsulta, List<Sancoes> sancoes, HistoricoConsulta historicoConsulta, ICollection<Sancoes> sancoesLista);
    }
}
