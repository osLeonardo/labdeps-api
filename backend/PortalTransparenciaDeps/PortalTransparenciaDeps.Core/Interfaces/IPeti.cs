using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PetiAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IPeti
    {
        Task<Peti> CreatePeti(string dataDisponibilizacaoRecurso, string datMesReferencia, string situacao, float valor, int idMunicipio, int idBeneficiario, int idHistoricoConsulta, Municipio municipio, BeneficiarioPeti beneficiarioPeti, HistoricoConsulta historicoConsulta);
    }
}
