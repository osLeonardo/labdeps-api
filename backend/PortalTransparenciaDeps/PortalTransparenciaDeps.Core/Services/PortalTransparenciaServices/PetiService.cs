using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PetiAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Services.PortalTransparenciaServices
{
    public class PetiService : IPeti
    {
        public readonly IRepository<Peti> _repository;
        public PetiService(IRepository<Peti> repository)
        {
            _repository = repository;
        }

        public async Task<Peti> CreatePeti(string dataDisponibilizacaoRecurso, string dataMesReferencia, string situacao, float valor, int idMunicipio, int idBeneficiario, int idHistoricoConsulta, Municipio municipio, BeneficiarioPeti beneficiarioPeti, HistoricoConsulta historicoConsulta)
        {
            Guard.Against.NullOrEmpty(dataDisponibilizacaoRecurso, nameof(dataDisponibilizacaoRecurso));
            Guard.Against.NullOrEmpty(dataMesReferencia, nameof(dataMesReferencia));
            Guard.Against.NullOrEmpty(situacao, nameof(situacao));
            Guard.Against.NegativeOrZero(valor, nameof(valor));
            Guard.Against.NegativeOrZero(idMunicipio, nameof(idMunicipio));
            Guard.Against.NegativeOrZero(idBeneficiario, nameof(idBeneficiario));
            Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
            Guard.Against.NegativeOrZero(municipio.Id, nameof(municipio.Id));
            Guard.Against.NegativeOrZero(beneficiarioPeti.Id, nameof(beneficiarioPeti.Id));
            Guard.Against.NegativeOrZero(historicoConsulta.Id, nameof(historicoConsulta.Id));

            Peti historicoPeti = Peti.NewHistoricoPeti(dataDisponibilizacaoRecurso, dataMesReferencia, situacao, valor, idMunicipio, idBeneficiario, idHistoricoConsulta);

            await _repository.AddAsync(historicoPeti);

            return historicoPeti;
        }
    }
}
