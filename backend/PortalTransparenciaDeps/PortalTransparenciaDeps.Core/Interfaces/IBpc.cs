using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BpcAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IBpc
    {
        Task<Bpc> CreateBpc(bool concedidoJudicialmente, string dataMesReferencia, string dataMesCompetencia, bool menor16Anos, float valor, int idMunicipio, int idBeneficiario, int idHistoricoConsulta, Municipio municipio, BeneficiarioBpc beneficiario, HistoricoConsulta historicoConsulta);
    }
}
