using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PepAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Services.PortalTransparenciaServices
{
    public class PepService : IPep
    {
        public readonly IRepository<Pep> _repository;
        public PepService(IRepository<Pep> repository)
        {
            _repository = repository;
        }

        public async Task<Pep> CreatePep(string codOrgao, string cpf, string descricaoFuncao, string dtFimCarencia, string dtFimExercicio, string dtInicioExercicio, string nivelFuncao, string nome, string nomeOrgao, string siglaFuncao, int idHistoricoConsulta, HistoricoConsulta historicoConsulta)
        {
            Guard.Against.NullOrEmpty(codOrgao, nameof(codOrgao));
            Guard.Against.NullOrEmpty(cpf, nameof(cpf));
            Guard.Against.NullOrEmpty(descricaoFuncao, nameof(descricaoFuncao));
            Guard.Against.NullOrEmpty(dtFimCarencia, nameof(dtFimCarencia));
            Guard.Against.NullOrEmpty(dtFimExercicio, nameof(dtFimExercicio));
            Guard.Against.NullOrEmpty(dtInicioExercicio, nameof(dtInicioExercicio));
            Guard.Against.NullOrEmpty(nivelFuncao, nameof(nivelFuncao));
            Guard.Against.NullOrEmpty(nome, nameof(nome));
            Guard.Against.NullOrEmpty(nomeOrgao, nameof(nomeOrgao));
            Guard.Against.NullOrEmpty(siglaFuncao, nameof(siglaFuncao));
            Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
            Guard.Against.NegativeOrZero(historicoConsulta.Id, nameof(historicoConsulta.Id));

            Pep historicoPep = Pep.NewHistoricoPep(codOrgao, cpf, descricaoFuncao, dtFimCarencia, dtFimExercicio, dtInicioExercicio, nivelFuncao, nome, nomeOrgao, siglaFuncao, idHistoricoConsulta);

            await _repository.AddAsync(historicoPep);

            return historicoPep;
        }
    }
}
