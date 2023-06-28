using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CnepAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PessoaJuridicaAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface ICnep
    {
        Task<Cnep> CreateCnep(string abrangenciaDefinidaDecisaoJudicial, string dataFimSancao, string dataInicioSancao, string dataOrigemInformacao, string dataPublicacaoSancao, string dataReferencia, string dataTransitadoJulgado, string detalhamentoPublicacao, string informacoesAdicionaisDoOrgaoSancionador, string linkPublicacao, string numeroProcesso, string textoPublicacao, string valorMulta, int idFundamentacao, int idFonteSancao, int idPessoaJuridica, int idSancionado, int idTipoSancao, int idHistoricoConsulta, List<Fundamentacao> fundamentacao, FonteSancao fonteSancao, OrgaoSancionador orgaoSancionador, PessoaJuridica pessoaJuridica, Sancionado sancionado, TipoSancao tipoSancao, HistoricoConsulta historicoConsulta, ICollection<Fundamentacao> Fundamentacoes);
    }
}
