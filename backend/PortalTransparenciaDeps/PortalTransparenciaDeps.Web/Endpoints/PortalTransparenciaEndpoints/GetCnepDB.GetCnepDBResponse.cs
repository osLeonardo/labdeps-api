using System.Collections.Generic;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetCnepDBResponse
    {
        public string AbrangenciaDefinidaDecisaoJudicial { get; private set; }
        public string DataFimSancao { get; private set; }
        public string DataInicioSancao { get; private set; }
        public string DataOrigemInformacao { get; private set; }
        public string DataPublicacaoSancao { get; private set; }
        public string DataReferencia { get; private set; }
        public string DataTransitadoJulgado { get; private set; }
        public string DetalhamentoPublicacao { get; private set; }
        public string InformacoesAdicionaisDoOrgaoSancionador { get; private set; }
        public string LinkPublicacao { get; private set; }
        public string NumeroProcesso { get; private set; }
        public string TextoPublicacao { get; private set; }
        public string ValorMulta { get; private set; }
        public virtual List<Fundamentacao> Fundamentacao { get; private set; }
        public virtual FonteSancao FonteSancao { get; private set; }
        public virtual OrgaoSancionador OrgaoSancionador { get; private set; }
        public virtual PessoaJuridica PessoaJuridica { get; private set; }
        public virtual Sancionado Sancionado { get; private set; }
        public virtual TipoSancao TipoSancao { get; private set; }
    }
    public class FonteSancao
    {
        public string EnderecoContato { get; private set; }
        public string NomeExibicao { get; private set; }
        public string TelefoneContato { get; private set; }
    }
    public class OrgaoSancionador
    {
        public string Nome { get; private set; }
        public string Poder { get; private set; }
        public string SiglaUf { get; private set; }
    }
    public class Sancionado
    {
        public string CodigoFormatado { get; private set; }
        public string Nome { get; private set; }
    }
    public class TipoSancao
    {
        public string DescricaoPortal { get; private set; }
        public string DescricaoResumida { get; private set; }
    }
    public class Fundamentacao
    {
        public string Codigo { get; private set; }
        public string Descricao { get; private set; }
        //public virtual Cnep Cnep { get; private set; } perguntar para o joão se isso fica na DTO ou se mudo o nome
    }
}
