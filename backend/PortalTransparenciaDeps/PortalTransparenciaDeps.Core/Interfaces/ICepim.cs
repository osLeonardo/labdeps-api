using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CepimAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PessoaJuridicaAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface ICepim
    {
        Task<Cepim> CreateCepim(string dataReferencia, string motivo, int idConvenio, int idOrgaoSuperior, int idPessoaJuridica, int idHistoricoConsulta, Convenio convenio, OrgaoSuperior orgaoSuperior, PessoaJuridica pessoaJuridica, HistoricoConsulta historicoConsulta);
    }
}
