using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BpcAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;
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
    public class BpcService : IBpc
    {
        public readonly IRepository<Bpc> _repository;
        public BpcService(IRepository<Bpc> repository)
        {
            _repository = repository;
        }

        public async Task<Bpc> CreateBpc(bool concedidoJudicialmente, string dataMesReferencia, string dataMesCompetencia, bool menor16Anos, float valor, int idMunicipio, int idBeneficiario, int idHistoricoConsulta, Municipio municipio, BeneficiarioBpc beneficiario, HistoricoConsulta historicoConsulta)
        {
            Guard.Against.Null(concedidoJudicialmente, nameof(concedidoJudicialmente));
            Guard.Against.NullOrEmpty(dataMesCompetencia, nameof(dataMesCompetencia));
            Guard.Against.NullOrEmpty(dataMesReferencia, nameof(dataMesReferencia));
            Guard.Against.Null(menor16Anos, nameof(menor16Anos));
            Guard.Against.NegativeOrZero(valor, nameof(valor));
            Guard.Against.NegativeOrZero(idMunicipio, nameof(idMunicipio));
            Guard.Against.NegativeOrZero(idBeneficiario, nameof(idBeneficiario));
            Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
            Guard.Against.NegativeOrZero(municipio.Id, nameof(municipio.Id));
            Guard.Against.NegativeOrZero(beneficiario.Id, nameof(beneficiario.Id));
            Guard.Against.NegativeOrZero(historicoConsulta.Id, nameof(historicoConsulta.Id));

            Bpc historicoBpc = Bpc.NewHistoricoBpc(concedidoJudicialmente, dataMesCompetencia, dataMesReferencia, menor16Anos, valor, idMunicipio, idBeneficiario, idHistoricoConsulta);

            await _repository.AddAsync(historicoBpc);

            return historicoBpc;
        }
    }
}
