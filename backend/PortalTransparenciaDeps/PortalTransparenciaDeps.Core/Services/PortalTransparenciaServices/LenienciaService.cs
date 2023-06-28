using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.LenienciaAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Services.PortalTransparenciaServices
{
    public class LenienciaService : ILeniencia
    {
        public readonly IRepository<Leniencia> _repository;
        public LenienciaService(IRepository<Leniencia> repository)
        {
            _repository = repository;
        }

        public async Task<Leniencia> CreateLeniencia(string dataFimAcordo, string dataInicioAcordo, string orgaoResponsavel, int quantidade, string situacaoAcordo, int idSancoes, int idHistoricoConsulta, List<Sancoes> sancoes, HistoricoConsulta historicoConsulta, ICollection<Sancoes> sancoesLista)
        {
            Guard.Against.NullOrEmpty(dataFimAcordo, nameof(dataFimAcordo));
            Guard.Against.NullOrEmpty(dataInicioAcordo, nameof(dataInicioAcordo));
            Guard.Against.NullOrEmpty(orgaoResponsavel, nameof(orgaoResponsavel));
            Guard.Against.NegativeOrZero(quantidade, nameof(quantidade));
            Guard.Against.NullOrEmpty(situacaoAcordo, nameof(situacaoAcordo));
            Guard.Against.NegativeOrZero(idSancoes, nameof(idSancoes));
            Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
            Guard.Against.Null(sancoes, nameof(sancoes));
            Guard.Against.NegativeOrZero(historicoConsulta.Id, nameof(historicoConsulta.Id));

            Leniencia historicoLeniencia = Leniencia.NewHistoricoLeninecia(dataFimAcordo, dataInicioAcordo, orgaoResponsavel, quantidade, situacaoAcordo, idSancoes, idHistoricoConsulta);

            await _repository.AddAsync(historicoLeniencia);

            return historicoLeniencia;
        }
    }
}
