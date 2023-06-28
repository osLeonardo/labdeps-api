using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PessoaJuridicaAggregate;
using PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.RemuneracaoAggregate
{
    public class Remuneracao : BaseEntity<int>, IAggregateRoot
    {
        public int IdServidor { get; private set; }
        public int IdRemuneracoesDTO { get; private set; }
        public int IdHistoricoConsulta { get; private set; }
        public virtual Servidor Servidor { get; private set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; private set; }
        public virtual ICollection<RemuneracoesDTO> RemuneracoesDTOs { get; private set; }

        protected Remuneracao() { }
        private Remuneracao(int idServidor, int idRemuneracoesDTO, int idHistoricoConsulta)
        {
            IdServidor = Guard.Against.NegativeOrZero(idServidor, nameof(idServidor));
            IdRemuneracoesDTO = Guard.Against.NegativeOrZero(idRemuneracoesDTO, nameof(idRemuneracoesDTO));
            IdHistoricoConsulta = Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
        }

        public static Remuneracao NewHistoricoRemuneracao(int idServidor, int idRemuneracoesDTO, int idHistoricoConsulta)
        {
            return new Remuneracao(idServidor, idRemuneracoesDTO, idHistoricoConsulta);
        }
    }
    public class Servidor : BaseEntity<int>, IAggregateRoot
    {
        public string CodigoMatriculaFormatado { get; private set; }
        public int FlagAfastado { get; private set; }
        public int IdServidorAposentadoPensionista { get; private set; }
        public string Situacao { get; private set; }
        public string TipoServidor { get; private set; }
        public int IdEstadoExercicio { get; private set; }
        public int IdFuncao { get; private set; }
        public int IdOrgaoServidorExercicio { get; private set; }
        public int IdOrgaoServidorLotacao { get; private set; }
        public int IdPensionistaRepresentante { get; private set; }
        public int IdPessoaJuridica { get; private set; }
        public int IdServidorInativoInstuidorPensao { get; private set; }
        public virtual EstadoExercicio EstadoExercicio { get; private set; }
        public virtual Funcao Funcao { get; private set; }
        public virtual OrgaoServidorExercicio OrgaoServidorExercicio { get; private set; }
        public virtual OrgaoServidorLotacao OrgaoServidorLotacao { get; private set; }
        public virtual PensionistaRepresentante PensionistaRepresentante { get; private set; }
        public virtual PessoaJuridica PessoaJuridica { get; private set; }
        public virtual ServidorInativoInstuidorPensao ServidorInativoInstuidorPensao { get; private set; }
        public virtual ICollection<Remuneracao> Remuneracoes { get; private set; }

        protected Servidor() { }
        private Servidor(string codigoMatriculaFormatado, int flagAfastado, int idServidorAposentadoPensionista, string situacao, string tipoServidor, int idEstadoExercicio, int idFuncao, int idOrgaoServidorExercicio, int idOrgaoServidorLotacao, int idPensionistaRepresentante, int idPessoaJuridica, int idServidorInativoInstituidorPensao)
        {
            CodigoMatriculaFormatado = Guard.Against.NullOrEmpty(codigoMatriculaFormatado, nameof(codigoMatriculaFormatado));
            FlagAfastado = Guard.Against.NegativeOrZero(flagAfastado, nameof(flagAfastado));
            IdServidorAposentadoPensionista = Guard.Against.NegativeOrZero(idServidorAposentadoPensionista, nameof(idServidorAposentadoPensionista));
            Situacao = Guard.Against.NullOrEmpty(situacao, nameof(situacao));
            TipoServidor = Guard.Against.NullOrEmpty(tipoServidor, nameof(tipoServidor));
            IdEstadoExercicio = Guard.Against.NegativeOrZero(idEstadoExercicio, nameof(idEstadoExercicio));
            IdFuncao = Guard.Against.NegativeOrZero(idFuncao, nameof(idFuncao));
            IdOrgaoServidorExercicio = Guard.Against.NegativeOrZero(idOrgaoServidorExercicio, nameof(idOrgaoServidorExercicio));
            IdOrgaoServidorLotacao = Guard.Against.NegativeOrZero(idOrgaoServidorLotacao, nameof(idOrgaoServidorLotacao));
            IdPensionistaRepresentante = Guard.Against.NegativeOrZero(idPensionistaRepresentante, nameof(idPensionistaRepresentante));
            IdPessoaJuridica = Guard.Against.NegativeOrZero(idPessoaJuridica, nameof(idPessoaJuridica));
            IdServidorInativoInstuidorPensao = Guard.Against.NegativeOrZero(idServidorInativoInstituidorPensao, nameof(idServidorInativoInstituidorPensao));
        }
    }
    public class EstadoExercicio : BaseEntity<int>, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Sigla { get; private set; }
        public virtual ICollection<Servidor> Servidores { get; private set; }

        protected EstadoExercicio() { }
        private EstadoExercicio(string nome, string sigla)
        {
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            Sigla = Guard.Against.NullOrEmpty(sigla, nameof(sigla));
        }
    }
    public class Funcao : BaseEntity<int>, IAggregateRoot
    {
        public string CodigoFuncaoCargo { get; private set; }
        public string DescricaoFuncaoCargo { get; private set; }
        public virtual ICollection<Servidor> Servidores { get; private set; }

        protected Funcao() { }
        private Funcao(string codigoFuncaoCargo, string descricaoFuncaoCargo)
        {
            CodigoFuncaoCargo = Guard.Against.NullOrEmpty(codigoFuncaoCargo, nameof(codigoFuncaoCargo));
            DescricaoFuncaoCargo = Guard.Against.NullOrEmpty(descricaoFuncaoCargo, nameof(descricaoFuncaoCargo));
        }
    }
    public class OrgaoServidorExercicio : BaseEntity<int>, IAggregateRoot
    {
        public string Codigo { get; private set; }
        public string CodigoOrgaoVinculado { get; private set; }
        public string Nome { get; private set; }
        public string NomeOrgaoVinculado { get; private set; }
        public string Sigla { get; private set; }
        public virtual ICollection<Servidor> Servidores { get; private set; }

        protected OrgaoServidorExercicio() { }
        private OrgaoServidorExercicio(string codigo, string codigoOrgaoVinculado, string nome, string nomeOrgaoVinculado, string sigla)
        {
            Codigo = Guard.Against.NullOrEmpty(codigo, nameof(codigo));
            CodigoOrgaoVinculado = Guard.Against.NullOrEmpty(codigoOrgaoVinculado, nameof(codigoOrgaoVinculado));
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            NomeOrgaoVinculado = Guard.Against.NullOrEmpty(nomeOrgaoVinculado, nameof(nomeOrgaoVinculado));
            Sigla = Guard.Against.NullOrEmpty(sigla, nameof(sigla));
        }
    }
    public class OrgaoServidorLotacao : BaseEntity<int>, IAggregateRoot
    {
        public string Codigo { get; private set; }
        public string CodigoOrgaoVinculado { get; private set; }
        public string Nome { get; private set; }
        public string NomeOrgaoVinculado { get; private set; }
        public string Sigla { get; private set; }
        public virtual ICollection<Servidor> Servidores { get; private set; }

        protected OrgaoServidorLotacao() { }
        private OrgaoServidorLotacao(string codigo, string codigoOrgaoVinculado, string nome, string nomeOrgaoVinculado, string sigla)
        {
            Codigo = Guard.Against.NullOrEmpty(codigo, nameof(codigo));
            CodigoOrgaoVinculado = Guard.Against.NullOrEmpty(codigoOrgaoVinculado, nameof(codigoOrgaoVinculado));
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            NomeOrgaoVinculado = Guard.Against.NullOrEmpty(nomeOrgaoVinculado, nameof(nomeOrgaoVinculado));
            Sigla = Guard.Against.NullOrEmpty(sigla, nameof(sigla));
        }
    }
    public class PensionistaRepresentante : BaseEntity<int>, IAggregateRoot
    {
        public string CpfFormatado { get; private set; }
        public string Nome { get; private set; }
        public virtual ICollection<Servidor> Servidores { get; private set; }

        protected PensionistaRepresentante() { }
        private PensionistaRepresentante(string cpfFormatado, string nome)
        {
            CpfFormatado = Guard.Against.NullOrEmpty(cpfFormatado, nameof(cpfFormatado));
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
        }
    }
    public class ServidorInativoInstuidorPensao : BaseEntity<int>, IAggregateRoot
    {
        public string CpfFormatado { get; private set; }
        public string Nome { get; private set; }
        public virtual ICollection<Servidor> Servidores { get; private set; }

        protected ServidorInativoInstuidorPensao() { }
        private ServidorInativoInstuidorPensao(string cpfFormatado, string nome)
        {
            CpfFormatado = Guard.Against.NullOrEmpty(cpfFormatado, nameof(cpfFormatado));
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
        }
    }
    public class RemuneracoesDTO : BaseEntity<int>, IAggregateRoot
    {
        public string AbateGratificacaoNatalina { get; private set; }
        public string AbateGratificacaoNatalinaDolar { get; private set; }
        public string AbateRemuneracaoBasicaBruta { get; private set; }
        public string AbateRemuneracaoBasicaBrutaDolar { get; private set; }
        public bool ExisteValorMes { get; private set; }
        public string Ferias { get; private set; }
        public string FeriasDolar { get; private set; }
        public string FundoSaude { get; private set; }
        public string FundoSaudeDolar { get; private set; }
        public string GratificacaoNatalina { get; private set; }
        public string GratificacaoNatalinaDolar { get; private set; }
        public string ImpostoRetidoNaFonte { get; private set; }
        public string ImpostoRetidoNaFonteDolar { get; private set; }
        public string MesAno { get; private set; }
        public string MesAnoPorExtenso { get; private set; }
        public string OutrasDeducoesObrigatorias { get; private set; }
        public string OutrasDeducoesObrigatoriasDolar { get; private set; }
        public string OutrasRemuneracoesEventuais { get; private set; }
        public string OutrasRemuneracoesEventuaisDolar { get; private set; }
        public string PensaoMilitar { get; private set; }
        public string PensaoMilitarDolar { get; private set; }
        public string PrevidenciaOficial { get; private set; }
        public string PrevidenciaOficialDolar { get; private set; }
        public string RemuneracaoBasicaBruta { get; private set; }
        public string RemuneracaoBasicaBrutaDolar { get; private set; }
        public bool RemuneracaoEmpresaPublica { get; private set; }
        public string SkMesReferencia { get; private set; }
        public string TaxaOcupacaoImovelFuncional { get; private set; }
        public string TaxaOcupacaoImovelFuncionalDolar { get; private set; }
        public string ValorTotalHonorariosAdvocaticios { get; private set; }
        public string ValorTotalJetons { get; private set; }
        public string ValorTotalRemuneracaoAposDeducoes { get; private set; }
        public string ValorTotalRemuneracaoDolarAposDeducoes { get; private set; }
        public string VerbasIndenizatorias { get; private set; }
        public string VerbasIndenizatoriasCivil { get; private set; }
        public string VerbasIndenizatoriasCivilDolar { get; private set; }
        public string VerbasIndenizatoriasDolar { get; private set; }
        public string VerbasIndenizatoriasMilitar { get; private set; }
        public string VerbasIndenizatoriasMilitarDolar { get; private set; }
        public string VerbasIndenizatoriasReferentesPDV { get; private set; }
        public string VerbasIndenizatoriasReferentesPDVDolar { get; private set; }
        public int IdHonorariosAdvocaticio { get; private set; }
        public int IdJetons { get; private set; }
        public int IdRubrica { get; private set; }
        public int IdRemuneracao { get; private set; }
        public virtual Remuneracao Remuneracao { get; private set; }
        public List<HonorariosAdvocaticio> HonorariosAdvocaticios { get; private set; }
        public List<Jetons> Jetons { get; private set; }
        public List<Rubrica> Rubricas { get; private set; }
        public virtual ICollection<HonorariosAdvocaticio> HonorariosAdvocaticiosLista { get; private set; }
        public virtual ICollection<Jetons> JetonsLista { get; private set; }
        public virtual ICollection<Rubrica> RubricaLista { get; private set; }

        protected RemuneracoesDTO() { }
        private RemuneracoesDTO(string abateGratificacaoNatalina, string abateGratificacaoNatalinaDolar, string abateRemuneracaoBasicaBruta, string abateRemuneracaoBasicaBrutaDolar, bool existeValorMes, string ferias, string feriasDolar, string fundoSaude, string fundoSaudeDolar, string gratificacaoNatalina, string gratificacaoNatalinaDolar, string impostoRetidoNaFonte, string impostoRetidoNaFonteDolar, string mesAno, string mesAnoPorExtenso, List<string> observacoes, string outrasDeducoesObrigatorias, string outrasDeducoesObrigatoriasDolar, string outrasRemuneracoesEventuais, string outrasRemuneracoesEventuaisDolar, string pensaoMilitar, string pensaoMilitarDolar, string previdenciaOficial, string previdenciaOficialDolar, string remuneracaoBasicaBruta, string remuneracaoBasicaBrutaDolar, bool remuneracaoEmpresaPublica, string skMesReferencia, string taxaOcupacaoImovelFuncional, string taxaOcupacaoImovelFuncionalDolar, string valorTotalHonorariosAdvocaticios, string valorTotalJetons, string valorTotalRemuneracaoAposDeducoes, string valorTotalRemuneracaoDolarAposDeducoes, string verbasIndenizatorias, string verbasIndenizatoriasCivil, string verbasIndenizatoriasCivilDolar, string verbasIndenizatoriasDolar, string verbasIndenizatoriasMilitar, string verbasIndenizatoriasMilitarDolar, string verbasIndenizatoriasReferentesPDV, string verbasIndenizatoriasReferentesPDVDolar, int idHonorariosAdvocaticio, int idJetons, int idRubrica, int idRemuneracao)
        {
            AbateGratificacaoNatalina = Guard.Against.NullOrEmpty(abateGratificacaoNatalina, nameof(abateGratificacaoNatalina));
            AbateGratificacaoNatalinaDolar = Guard.Against.NullOrEmpty(abateGratificacaoNatalinaDolar, nameof(abateGratificacaoNatalinaDolar));
            AbateRemuneracaoBasicaBruta = Guard.Against.NullOrEmpty(abateRemuneracaoBasicaBruta, nameof(abateRemuneracaoBasicaBruta));
            AbateRemuneracaoBasicaBrutaDolar = Guard.Against.NullOrEmpty(abateRemuneracaoBasicaBrutaDolar, nameof(abateRemuneracaoBasicaBrutaDolar));
            ExisteValorMes = true;
            Ferias = Guard.Against.NullOrEmpty(ferias, nameof(ferias));
            FeriasDolar = Guard.Against.NullOrEmpty(feriasDolar, nameof(feriasDolar));
            FundoSaude = Guard.Against.NullOrEmpty(fundoSaude, nameof(fundoSaude));
            FundoSaudeDolar = Guard.Against.NullOrEmpty(fundoSaudeDolar, nameof(fundoSaudeDolar));
            GratificacaoNatalina = Guard.Against.NullOrEmpty(gratificacaoNatalina, nameof(gratificacaoNatalina));
            GratificacaoNatalinaDolar = Guard.Against.NullOrEmpty(gratificacaoNatalinaDolar, nameof(gratificacaoNatalinaDolar));
            ImpostoRetidoNaFonte = Guard.Against.NullOrEmpty(impostoRetidoNaFonte, nameof(impostoRetidoNaFonte));
            ImpostoRetidoNaFonteDolar = Guard.Against.NullOrEmpty(impostoRetidoNaFonteDolar, nameof(impostoRetidoNaFonteDolar));
            MesAno = Guard.Against.NullOrEmpty(mesAno, nameof(mesAno));
            MesAnoPorExtenso = Guard.Against.NullOrEmpty(mesAnoPorExtenso, nameof(mesAnoPorExtenso));
            OutrasDeducoesObrigatorias = Guard.Against.NullOrEmpty(outrasDeducoesObrigatorias, nameof(outrasDeducoesObrigatorias));
            OutrasDeducoesObrigatoriasDolar = Guard.Against.NullOrEmpty(outrasDeducoesObrigatoriasDolar, nameof(outrasDeducoesObrigatoriasDolar));
            OutrasRemuneracoesEventuais = Guard.Against.NullOrEmpty(outrasRemuneracoesEventuais, nameof(outrasRemuneracoesEventuais));
            OutrasRemuneracoesEventuaisDolar = Guard.Against.NullOrEmpty(outrasRemuneracoesEventuaisDolar, nameof(outrasRemuneracoesEventuaisDolar));
            PensaoMilitar = Guard.Against.NullOrEmpty(pensaoMilitar, nameof(pensaoMilitar));
            PensaoMilitarDolar = Guard.Against.NullOrEmpty(pensaoMilitarDolar, nameof(pensaoMilitarDolar));
            PrevidenciaOficial = Guard.Against.NullOrEmpty(previdenciaOficial, nameof(previdenciaOficial));
            PrevidenciaOficialDolar = Guard.Against.NullOrEmpty(previdenciaOficialDolar, nameof(previdenciaOficialDolar));
            RemuneracaoBasicaBruta = Guard.Against.NullOrEmpty(remuneracaoBasicaBruta, nameof(remuneracaoBasicaBruta));
            RemuneracaoBasicaBrutaDolar = Guard.Against.NullOrEmpty(remuneracaoBasicaBrutaDolar, nameof(remuneracaoBasicaBrutaDolar));
            RemuneracaoEmpresaPublica = true;
            SkMesReferencia = Guard.Against.NullOrEmpty(skMesReferencia, nameof(skMesReferencia));
            TaxaOcupacaoImovelFuncional = Guard.Against.NullOrEmpty(taxaOcupacaoImovelFuncional, nameof(taxaOcupacaoImovelFuncional));
            TaxaOcupacaoImovelFuncionalDolar = Guard.Against.NullOrEmpty(taxaOcupacaoImovelFuncionalDolar, nameof(taxaOcupacaoImovelFuncionalDolar));
            ValorTotalHonorariosAdvocaticios = Guard.Against.NullOrEmpty(valorTotalHonorariosAdvocaticios, nameof(valorTotalHonorariosAdvocaticios));
            ValorTotalJetons = Guard.Against.NullOrEmpty(valorTotalJetons, nameof(valorTotalJetons));
            ValorTotalRemuneracaoAposDeducoes = Guard.Against.NullOrEmpty(valorTotalRemuneracaoAposDeducoes, nameof(valorTotalRemuneracaoAposDeducoes));
            ValorTotalRemuneracaoDolarAposDeducoes = Guard.Against.NullOrEmpty(valorTotalRemuneracaoDolarAposDeducoes, nameof(valorTotalRemuneracaoDolarAposDeducoes));
            VerbasIndenizatorias = Guard.Against.NullOrEmpty(verbasIndenizatorias, nameof(verbasIndenizatorias));
            VerbasIndenizatoriasCivil = Guard.Against.NullOrEmpty(verbasIndenizatoriasCivil, nameof(verbasIndenizatoriasCivil));
            VerbasIndenizatoriasCivilDolar = Guard.Against.NullOrEmpty(verbasIndenizatoriasCivilDolar, nameof(verbasIndenizatoriasCivilDolar));
            VerbasIndenizatoriasDolar = Guard.Against.NullOrEmpty(verbasIndenizatoriasDolar, nameof(verbasIndenizatoriasDolar));
            VerbasIndenizatoriasMilitar = Guard.Against.NullOrEmpty(verbasIndenizatoriasMilitar, nameof(verbasIndenizatoriasMilitar));
            VerbasIndenizatoriasMilitarDolar = Guard.Against.NullOrEmpty(verbasIndenizatoriasMilitarDolar, nameof(verbasIndenizatoriasMilitarDolar));
            VerbasIndenizatoriasReferentesPDV = Guard.Against.NullOrEmpty(verbasIndenizatoriasReferentesPDV, nameof(verbasIndenizatoriasReferentesPDV));
            VerbasIndenizatoriasReferentesPDVDolar = Guard.Against.NullOrEmpty(verbasIndenizatoriasReferentesPDVDolar, nameof(verbasIndenizatoriasReferentesPDVDolar));
            IdHonorariosAdvocaticio = Guard.Against.NegativeOrZero(idHonorariosAdvocaticio, nameof(idHonorariosAdvocaticio));
            IdJetons = Guard.Against.NegativeOrZero(idJetons, nameof(idJetons));
            IdRubrica = Guard.Against.NegativeOrZero(idRubrica, nameof(idRubrica));
            IdRemuneracao = Guard.Against.NegativeOrZero(idRemuneracao, nameof(idRemuneracao));
        }
    }
    public class HonorariosAdvocaticio : BaseEntity<int>, IAggregateRoot
    {
        public string MensagemMesReferencia { get; private set; }
        public string MesReferencia { get; private set; }
        public int Valor { get; private set; }
        public string ValorFormatado { get; private set; }
        public int IdRemuneracoesDTO { get; private set; }
        public virtual RemuneracoesDTO RemuneracoesDTO { get; private set; }

        protected HonorariosAdvocaticio() { }
        private HonorariosAdvocaticio(string mensagemMesReferencia, string mesReferencia, int valor, string valorFormatado, int idRemuneracoesDTO)
        {
            MensagemMesReferencia = Guard.Against.NullOrEmpty(mensagemMesReferencia, nameof(mensagemMesReferencia));
            MesReferencia = Guard.Against.NullOrEmpty(mesReferencia, nameof(mesReferencia));
            Valor = Guard.Against.NegativeOrZero(valor, nameof(valor));
            ValorFormatado = Guard.Against.NullOrEmpty(valorFormatado, nameof(valorFormatado));
            IdRemuneracoesDTO = Guard.Against.NegativeOrZero(idRemuneracoesDTO, nameof(idRemuneracoesDTO));
        }
    }
    public class Jetons : BaseEntity<int>, IAggregateRoot
    {
        public string Descricao { get; private set; }
        public string MesReferencia { get; private set; }
        public int Valor { get; private set; }
        public int IdRemuneracoesDTO { get; private set; }
        public virtual RemuneracoesDTO RemuneracoesDTO { get; private set; }

        protected Jetons() { }
        private Jetons(string descricao, string mesReferencia, int valor, int idRemuneracoesDTO)
        {
            Descricao = Guard.Against.NullOrEmpty(descricao, nameof(descricao));
            MesReferencia = Guard.Against.NullOrEmpty(mesReferencia, nameof(mesReferencia));
            Valor = Guard.Against.NegativeOrZero(valor, nameof(valor));
            IdRemuneracoesDTO = Guard.Against.NegativeOrZero(idRemuneracoesDTO, nameof(idRemuneracoesDTO));
        }
    }
    public class Rubrica : BaseEntity<int>, IAggregateRoot
    {
        public string Codigo { get; private set; }
        public string Descricao { get; private set; }
        public string SkMesReferencia { get; private set; }
        public int Valor { get; private set; }
        public int ValorDolar { get; private set; }
        public int IdRemuneracoesDTO { get; private set; }
        public virtual RemuneracoesDTO RemuneracoesDTO { get; private set; }

        public Rubrica(string codigo, string descricao, string skMesReferencia, int valor, int valorDolar, int idRemuneracoesDTO)
        {
            Codigo = Guard.Against.NullOrEmpty(codigo, nameof(codigo));
            Descricao = Guard.Against.NullOrEmpty(descricao, nameof(descricao));
            SkMesReferencia = Guard.Against.NullOrEmpty(skMesReferencia, nameof(skMesReferencia));
            Valor = Guard.Against.NegativeOrZero(valor, nameof(valor));
            ValorDolar = Guard.Against.NegativeOrZero(valorDolar, nameof(valorDolar));
            IdRemuneracoesDTO = Guard.Against.NegativeOrZero(idRemuneracoesDTO, nameof(idRemuneracoesDTO));
        }
    }
}
