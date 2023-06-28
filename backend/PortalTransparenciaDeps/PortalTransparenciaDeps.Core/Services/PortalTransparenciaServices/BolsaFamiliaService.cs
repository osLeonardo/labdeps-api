using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BolsaFamiliaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Services.PortalTransparenciaServices
{
    public class BolsaFamiliaService : IBolsaFamilia
    {
        public readonly IRepository<BolsaFamilia> _repository;
        public BolsaFamiliaService(IRepository<BolsaFamilia> repository)
        {
            _repository = repository;
        }

        public async Task<BolsaFamilia> CreateBolsaFamilia(string dataMesCompetencia, string dataMesReferencia, int quantidadeDependentes, float valor, int idMunicipio, int idTitular, int idHistoricoConsulta, Municipio municipio, TitularBolsaFamilia titularBolsaFamilia, HistoricoConsulta historicoConsulta)
        {
            Guard.Against.NullOrEmpty(dataMesCompetencia, nameof(dataMesCompetencia));
            Guard.Against.NullOrEmpty(dataMesReferencia, nameof(dataMesReferencia));
            Guard.Against.NegativeOrZero(quantidadeDependentes, nameof(quantidadeDependentes));
            Guard.Against.NegativeOrZero(valor, nameof(valor));
            Guard.Against.NegativeOrZero(idMunicipio, nameof(idMunicipio));
            Guard.Against.NegativeOrZero(idTitular, nameof(idTitular));
            Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
            Guard.Against.NegativeOrZero(municipio.Id, nameof(municipio.Id));
            Guard.Against.NegativeOrZero(titularBolsaFamilia.Id, nameof(titularBolsaFamilia.Id));
            Guard.Against.NegativeOrZero(historicoConsulta.Id, nameof(historicoConsulta.Id));

            BolsaFamilia historicoBolsaFamilia = BolsaFamilia.NewHistoricoBolsaFamilia(dataMesCompetencia, dataMesReferencia, quantidadeDependentes, valor, idMunicipio, idTitular, idHistoricoConsulta);

            await _repository.AddAsync(historicoBolsaFamilia);

            return historicoBolsaFamilia;
        }
    }
}
