using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.RemuneracaoAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Services.PortalTransparenciaServices
{
    public class RemuneracaoService : IRemuneracao
    {
        public readonly IRepository<Remuneracao> _repository;
        public RemuneracaoService(IRepository<Remuneracao> repository)
        {
            _repository = repository;
        }

        public async Task<Remuneracao> CreateRemuneracao(int idServidor, int idRemuneracoesDTO, int idHistoricoConsulta, Servidor servidor, HistoricoConsulta historicoConsulta, ICollection<RemuneracoesDTO> remuneracoesDTOs)
        {
            Guard.Against.NegativeOrZero(idServidor, nameof(idServidor));
            Guard.Against.NegativeOrZero(idRemuneracoesDTO, nameof(idRemuneracoesDTO));
            Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
            Guard.Against.NegativeOrZero(servidor.Id, nameof(servidor.Id));
            Guard.Against.NegativeOrZero(historicoConsulta.Id, nameof (historicoConsulta.Id));

            Remuneracao historicoRemuneracao = Remuneracao.NewHistoricoRemuneracao(idServidor, idRemuneracoesDTO, idHistoricoConsulta);

            await _repository.AddAsync(historicoRemuneracao);

            return historicoRemuneracao;
        }
    }
}
