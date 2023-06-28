using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CepimAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PessoaJuridicaAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Services.PortalTransparenciaServices
{
    public class CepimService : ICepim
    {
        public readonly IRepository<Cepim> _repository;
        public CepimService(IRepository<Cepim> repository)
        {
            _repository = repository;
        }

        public async Task<Cepim> CreateCepim(string dataReferencia, string motivo, int idConvenio, int idOrgaoSuperior, int idPessoaJuridica, int idHistoricoConsulta, Convenio convenio, OrgaoSuperior orgaoSuperior, PessoaJuridica pessoaJuridica, HistoricoConsulta historicoConsulta)
        {
            Guard.Against.NullOrEmpty(dataReferencia, nameof(dataReferencia));
            Guard.Against.NullOrEmpty(motivo, nameof(motivo));
            Guard.Against.NegativeOrZero(idConvenio, nameof(idConvenio));
            Guard.Against.NegativeOrZero(idOrgaoSuperior, nameof(idOrgaoSuperior));
            Guard.Against.NegativeOrZero(idPessoaJuridica, nameof(idPessoaJuridica));
            Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
            Guard.Against.NegativeOrZero(convenio.Id, nameof(convenio.Id));
            Guard.Against.NegativeOrZero(orgaoSuperior.Id, nameof(orgaoSuperior.Id));
            Guard.Against.NegativeOrZero(pessoaJuridica.Id, nameof(pessoaJuridica.Id));
            Guard.Against.NegativeOrZero(historicoConsulta.Id, nameof(historicoConsulta.Id));

            Cepim historicoCepim = Cepim.NewHistoricoCepim(dataReferencia, motivo, idConvenio, idOrgaoSuperior, idPessoaJuridica, idHistoricoConsulta);

            await _repository.AddAsync(historicoCepim);

            return historicoCepim;
        }
    }
}
