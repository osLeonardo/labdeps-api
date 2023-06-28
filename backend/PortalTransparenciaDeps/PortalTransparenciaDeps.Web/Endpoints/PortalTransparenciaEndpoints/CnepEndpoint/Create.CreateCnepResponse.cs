using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CnepAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PessoaJuridicaAggregate;
using System.Collections.Generic;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.CnepEndpoint
{
    public class CreateCnepResponse
    {
        public const string Route = "cnep";
        public string AbrangenciaDefinidaDecisaoJudicial { get; set; }
        public string DataFimSancao { get; set; }
        public string DataInicioSancao { get; set; }
        public string DataOrigemInformacao { get; set; }
        public string DataPublicacaoSancao { get; set; }
        public string DataReferencia { get; set; }
        public string DataTransitadoJulgado { get; set; }
        public string DetalhamentoPublicacao { get; set; }
        public string InformacoesAdicionaisDoOrgaoSancionador { get; set; }
        public string LinkPublicacao { get; set; }
        public string NumeroProcesso { get; set; }
        public string TextoPublicacao { get; set; }
        public string ValorMulta { get; set; }
        public int IdFundamentacao { get; set; }
        public int IdFonteSancao { get; set; }
        public int IdPessoaJuridica { get; set; }
        public int IdSancionado { get; set; }
        public int IdTipoSancao { get; set; }
        public int IdHistoricoConsulta { get; set; }
        public virtual List<Fundamentacao> Fundamentacao { get; set; }
        public virtual FonteSancao FonteSancao { get; set; }
        public virtual OrgaoSancionador OrgaoSancionador { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual Sancionado Sancionado { get; set; }
        public virtual TipoSancao TipoSancao { get; set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; set; }
        public virtual ICollection<Fundamentacao> Fundamentacoes { get; set; }
    }
}
