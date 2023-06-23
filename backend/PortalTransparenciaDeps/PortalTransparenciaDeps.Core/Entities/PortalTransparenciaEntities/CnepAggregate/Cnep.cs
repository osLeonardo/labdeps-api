using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PessoaJuridicaAggregate;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CnepAggregate
{
    public class Cnep : BaseEntity<int>, IAggregateRoot
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
        public int IdFundamentacao { get; private set; }
        public int IdFonteSancao { get; private set; }
        public int IdPessoaJuridica { get; private set; }
        public int IdSancionado { get; private set; }
        public int IdTipoSancao { get; private set; }
        public int IdHistoricoConsulta { get; private set; }
        public virtual List<Fundamentacao> Fundamentacao { get; private set; }
        public virtual FonteSancao FonteSancao { get; private set; }
        public virtual OrgaoSancionador OrgaoSancionador { get; private set; }
        public virtual PessoaJuridica PessoaJuridica { get; private set; }
        public virtual Sancionado Sancionado { get; private set; }
        public virtual TipoSancao TipoSancao { get; private set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; private set; }
        public virtual ICollection<Fundamentacao> Fundamentacoes { get; private set; }

        protected Cnep() { }
        private Cnep(string abrangenciaDefinidaDecisaoJudicial, string dataFimSancao, string dataInicioSancao, string dataOrigemInformacao, string dataPublicacaoSancao, string dataReferencia, string dataTransitadoJulgado, string detalhamentoPublicacao, string informacoesAdicionaisDoOrgaoSancionador, string linkPublicacao, string numeroProcesso, string textoPublicacao, string valorMulta, int idFundamentacao, int idFonteSancao, int idPessoaJuridica, int idSancionado, int idTipoSancao, int idHistoricoConsulta)
        {
            AbrangenciaDefinidaDecisaoJudicial = Guard.Against.NullOrEmpty(abrangenciaDefinidaDecisaoJudicial, nameof(abrangenciaDefinidaDecisaoJudicial));
            DataFimSancao = Guard.Against.NullOrEmpty(dataFimSancao, nameof(dataFimSancao));
            DataInicioSancao = Guard.Against.NullOrEmpty(dataInicioSancao, nameof(dataInicioSancao));
            DataOrigemInformacao = Guard.Against.NullOrEmpty(dataOrigemInformacao, nameof(dataOrigemInformacao));
            DataPublicacaoSancao = Guard.Against.NullOrEmpty(dataPublicacaoSancao, nameof(dataPublicacaoSancao));
            DataReferencia = Guard.Against.NullOrEmpty(dataReferencia, nameof(dataReferencia));
            DataTransitadoJulgado = Guard.Against.NullOrEmpty(dataTransitadoJulgado, nameof(dataTransitadoJulgado));
            DetalhamentoPublicacao = Guard.Against.NullOrEmpty(detalhamentoPublicacao, nameof(detalhamentoPublicacao));
            InformacoesAdicionaisDoOrgaoSancionador = Guard.Against.NullOrEmpty(informacoesAdicionaisDoOrgaoSancionador, nameof(informacoesAdicionaisDoOrgaoSancionador));
            LinkPublicacao = Guard.Against.NullOrEmpty(linkPublicacao, nameof(linkPublicacao));
            NumeroProcesso = Guard.Against.NullOrEmpty(numeroProcesso, nameof(numeroProcesso));
            TextoPublicacao = Guard.Against.NullOrEmpty(textoPublicacao, nameof(textoPublicacao));
            ValorMulta = Guard.Against.NullOrEmpty(valorMulta, nameof(valorMulta));
            IdFundamentacao = Guard.Against.NegativeOrZero(idFundamentacao, nameof(idFundamentacao));
            IdFonteSancao = Guard.Against.NegativeOrZero(idFonteSancao, nameof(idFonteSancao));
            IdPessoaJuridica = Guard.Against.NegativeOrZero(idPessoaJuridica, nameof(idPessoaJuridica));
            IdSancionado = Guard.Against.NegativeOrZero(idSancionado, nameof(idSancionado));
            IdTipoSancao = Guard.Against.NegativeOrZero(idTipoSancao, nameof(idTipoSancao));
            IdHistoricoConsulta = Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
        }
    }
    public class TipoSancao : BaseEntity<int>, IAggregateRoot
    { 
        public string DescricaoPortal { get; private set; }
        public string DescricaoResumida { get; private set; }
        public virtual ICollection<Cnep> Cneps { get; private set; }

        protected TipoSancao() { }
        private TipoSancao(string descricaoPortal, string descricaoResumida)
        {
            DescricaoPortal = Guard.Against.NullOrEmpty(descricaoPortal, nameof(descricaoPortal));
            DescricaoResumida = Guard.Against.NullOrEmpty(descricaoResumida, nameof(descricaoResumida));
        }
    }
    public class FonteSancao : BaseEntity<int>, IAggregateRoot
    {
        public string EnderecoContato { get; private set; }
        public string NomeExibicao { get; private set; }
        public string TelefoneContato { get; private set; }
        public virtual ICollection<Cnep> Cneps { get; private set; }

        protected FonteSancao() { }
        private FonteSancao(string enderecoContato, string nomeExibicao, string telefoneContato)
        {
            EnderecoContato = Guard.Against.NullOrEmpty(enderecoContato, nameof(enderecoContato));
            NomeExibicao = Guard.Against.NullOrEmpty(nomeExibicao, nameof(nomeExibicao));
            TelefoneContato = Guard.Against.NullOrEmpty(telefoneContato, nameof(telefoneContato));
        }
    }
    public class Sancionado : BaseEntity<int>, IAggregateRoot
    {
        public string CodigoFormatado { get; private set; }
        public string Nome { get; private set; }
        public virtual ICollection<Cnep> Cneps { get; private set; }

        protected Sancionado() { }
        private Sancionado(string codigoFormatado, string nome)
        {
            CodigoFormatado = Guard.Against.NullOrEmpty(codigoFormatado, nameof(codigoFormatado));
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
        }
    }
    public class OrgaoSancionador : BaseEntity<int>, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Poder { get; private set; }
        public string SiglaUf { get; private set; }
        public virtual ICollection<Cnep> Cneps { get; private set; }

        protected OrgaoSancionador() { }
        private OrgaoSancionador(string nome, string poder, string siglaUf)
        {
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            Poder = Guard.Against.NullOrEmpty(poder, nameof(poder));
            SiglaUf = Guard.Against.NullOrEmpty(siglaUf, nameof(siglaUf));
        }
    }
    public class Fundamentacao : BaseEntity<int>, IAggregateRoot
    {
        public string Codigo { get; private set; }
        public string Descricao { get; private set; }
        public int IdCnep { get; private set; }
        public virtual Cnep Cnep { get; private set; }
        public virtual ICollection<Cnep> Cneps { get; private set; }

        protected Fundamentacao() { }
        private Fundamentacao(string codigo, string descricao, int idCnep)
        {
            Codigo = Guard.Against.NullOrEmpty(codigo, nameof(codigo));
            Descricao = Guard.Against.NullOrEmpty(descricao, nameof(descricao));
            IdCnep = Guard.Against.NegativeOrZero(idCnep, nameof(idCnep));
        }
    }
}
