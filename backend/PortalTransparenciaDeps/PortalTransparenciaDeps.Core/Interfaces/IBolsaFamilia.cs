using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BolsaFamiliaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IBolsaFamilia
    {
        Task<BolsaFamilia> CreateBolsaFamilia(string dataMesCompetencia, string dataMesReferencia, int quantidadeDependentes, float valor, int idMunicipio, int idTitular, int idHistoricoConsulta, Municipio municipio, TitularBolsaFamilia titularBolsaFamilia, HistoricoConsulta historicoConsulta);
    }
}
