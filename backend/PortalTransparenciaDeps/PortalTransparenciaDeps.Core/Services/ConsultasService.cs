using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Services
{
    public class ConsultasService : IConsultas
    {
        public readonly IRepository<HistoricoConsulta> _repository;
        public ConsultasService(IRepository<HistoricoConsulta> repository) 
        {
            _repository = repository;
        }
        public async Task<HistoricoConsulta> CreateHistorico(UserLogin user, DateOnly dataConsulta, string tipoConsulta, string codigo, DateOnly dataReferencia, string intervalo)
        {
            Guard.Against.NegativeOrZero(user.Id, nameof(user.Id));
            Guard.Against.Null(dataConsulta, nameof(dataConsulta));
            Guard.Against.NullOrEmpty(tipoConsulta, nameof(tipoConsulta));
            Guard.Against.NullOrEmpty(codigo, nameof(codigo));
            Guard.Against.Null(dataReferencia, nameof(dataReferencia));
            Guard.Against.NullOrEmpty(intervalo, nameof(intervalo));

            HistoricoConsulta historico = HistoricoConsulta.NewConsulta(user, dataConsulta, tipoConsulta, codigo, dataReferencia, intervalo);

            await _repository.AddAsync(historico);

            return historico;
        }
    }
}
