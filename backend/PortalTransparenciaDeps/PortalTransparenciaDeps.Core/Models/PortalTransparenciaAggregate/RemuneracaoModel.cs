using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate
{
    public class RemuneracaoModel
    {
        [JsonPropertyName("remuneracoesDTO")]
        public List<RemuneracoesDTOModel> RemuneracoesDTO { get; set; }

        [JsonPropertyName("servidor")]
        public ServidorModel Servidor { get; set; }
    }

    public class RemuneracoesDTOModel
    {
        [JsonPropertyName("abateGratificacaoNatalina")]
        public string AbateGratificacaoNatalina { get; set; }

        [JsonPropertyName("abateGratificacaoNatalinaDolar")]
        public string AbateGratificacaoNatalinaDolar { get; set; }

        [JsonPropertyName("abateRemuneracaoBasicaBruta")]
        public string AbateRemuneracaoBasicaBruta { get; set; }

        [JsonPropertyName("abateRemuneracaoBasicaBrutaDolar")]
        public string AbateRemuneracaoBasicaBrutaDolar { get; set; }

        [JsonPropertyName("existeValorMes")]
        public bool ExisteValorMes { get; set; }

        [JsonPropertyName("ferias")]
        public string Ferias { get; set; }

        [JsonPropertyName("feriasDolar")]
        public string FeriasDolar { get; set; }

        [JsonPropertyName("fundoSaude")]
        public string FundoSaude { get; set; }

        [JsonPropertyName("fundoSaudeDolar")]
        public string FundoSaudeDolar { get; set; }

        [JsonPropertyName("gratificacaoNatalina")]
        public string GratificacaoNatalina { get; set; }

        [JsonPropertyName("gratificacaoNatalinaDolar")]
        public string GratificacaoNatalinaDolar { get; set; }

        [JsonPropertyName("honorariosAdvocaticios")]
        public List<HonorariosAdvocaticioModel> HonorariosAdvocaticios { get; set; }

        [JsonPropertyName("impostoRetidoNaFonte")]
        public string ImpostoRetidoNaFonte { get; set; }

        [JsonPropertyName("impostoRetidoNaFonteDolar")]
        public string ImpostoRetidoNaFonteDolar { get; set; }

        [JsonPropertyName("jetons")]
        public List<JetonsModel> Jetons { get; set; }

        [JsonPropertyName("mesAno")]
        public string MesAno { get; set; }

        [JsonPropertyName("mesAnoPorExtenso")]
        public string MesAnoPorExtenso { get; set; }

        [JsonPropertyName("observacoes")]
        public List<string> Observacoes { get; set; }

        [JsonPropertyName("outrasDeducoesObrigatorias")]
        public string OutrasDeducoesObrigatorias { get; set; }

        [JsonPropertyName("outrasDeducoesObrigatoriasDolar")]
        public string OutrasDeducoesObrigatoriasDolar { get; set; }

        [JsonPropertyName("outrasRemuneracoesEventuais")]
        public string OutrasRemuneracoesEventuais { get; set; }

        [JsonPropertyName("outrasRemuneracoesEventuaisDolar")]
        public string OutrasRemuneracoesEventuaisDolar { get; set; }

        [JsonPropertyName("pensaoMilitar")]
        public string PensaoMilitar { get; set; }

        [JsonPropertyName("pensaoMilitarDolar")]
        public string PensaoMilitarDolar { get; set; }

        [JsonPropertyName("previdenciaOficial")]
        public string PrevidenciaOficial { get; set; }

        [JsonPropertyName("previdenciaOficialDolar")]
        public string PrevidenciaOficialDolar { get; set; }

        [JsonPropertyName("remuneracaoBasicaBruta")]
        public string RemuneracaoBasicaBruta { get; set; }

        [JsonPropertyName("remuneracaoBasicaBrutaDolar")]
        public string RemuneracaoBasicaBrutaDolar { get; set; }

        [JsonPropertyName("remuneracaoEmpresaPublica")]
        public bool RemuneracaoEmpresaPublica { get; set; }

        [JsonPropertyName("rubricas")]
        public List<RubricaModel> Rubricas { get; set; }

        [JsonPropertyName("skMesReferencia")]
        public string SkMesReferencia { get; set; }

        [JsonPropertyName("taxaOcupacaoImovelFuncional")]
        public string TaxaOcupacaoImovelFuncional { get; set; }

        [JsonPropertyName("taxaOcupacaoImovelFuncionalDolar")]
        public string TaxaOcupacaoImovelFuncionalDolar { get; set; }

        [JsonPropertyName("valorTotalHonorariosAdvocaticios")]
        public string ValorTotalHonorariosAdvocaticios { get; set; }

        [JsonPropertyName("valorTotalJetons")]
        public string ValorTotalJetons { get; set; }

        [JsonPropertyName("valorTotalRemuneracaoAposDeducoes")]
        public string ValorTotalRemuneracaoAposDeducoes { get; set; }

        [JsonPropertyName("valorTotalRemuneracaoDolarAposDeducoes")]
        public string ValorTotalRemuneracaoDolarAposDeducoes { get; set; }

        [JsonPropertyName("verbasIndenizatorias")]
        public string VerbasIndenizatorias { get; set; }

        [JsonPropertyName("verbasIndenizatoriasCivil")]
        public string VerbasIndenizatoriasCivil { get; set; }

        [JsonPropertyName("verbasIndenizatoriasCivilDolar")]
        public string VerbasIndenizatoriasCivilDolar { get; set; }

        [JsonPropertyName("verbasIndenizatoriasDolar")]
        public string VerbasIndenizatoriasDolar { get; set; }

        [JsonPropertyName("verbasIndenizatoriasMilitar")]
        public string VerbasIndenizatoriasMilitar { get; set; }

        [JsonPropertyName("verbasIndenizatoriasMilitarDolar")]
        public string VerbasIndenizatoriasMilitarDolar { get; set; }

        [JsonPropertyName("verbasIndenizatoriasReferentesPDV")]
        public string VerbasIndenizatoriasReferentesPDV { get; set; }

        [JsonPropertyName("verbasIndenizatoriasReferentesPDVDolar")]
        public string VerbasIndenizatoriasReferentesPDVDolar { get; set; }
    }
    public class HonorariosAdvocaticioModel
    {
        [JsonPropertyName("mensagemMesReferencia")]
        public string MensagemMesReferencia { get; set; }

        [JsonPropertyName("mesReferencia")]
        public string MesReferencia { get; set; }

        [JsonPropertyName("valor")]
        public int Valor { get; set; }

        [JsonPropertyName("valorFormatado")]
        public string ValorFormatado { get; set; }
    }

    public class JetonsModel
    {
        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("mesReferencia")]
        public string MesReferencia { get; set; }

        [JsonPropertyName("valor")]
        public int Valor { get; set; }
    }

    public class RubricaModel
    {
        [JsonPropertyName("codigo")]
        public string Codigo { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("skMesReferencia")]
        public string SkMesReferencia { get; set; }

        [JsonPropertyName("valor")]
        public int Valor { get; set; }

        [JsonPropertyName("valorDolar")]
        public int ValorDolar { get; set; }
    }

    public class ServidorModel
    {
        [JsonPropertyName("codigoMatriculaFormatado")]
        public string CodigoMatriculaFormatado { get; set; }

        [JsonPropertyName("estadoExercicio")]
        public EstadoExercicioModel EstadoExercicio { get; set; }

        [JsonPropertyName("flagAfastado")]
        public int FlagAfastado { get; set; }

        [JsonPropertyName("funcao")]
        public FuncaoModel Funcao { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("idServidorAposentadoPensionista")]
        public int IdServidorAposentadoPensionista { get; set; }

        [JsonPropertyName("orgaoServidorExercicio")]
        public OrgaoServidorExercicioModel OrgaoServidorExercicio { get; set; }

        [JsonPropertyName("orgaoServidorLotacao")]
        public OrgaoServidorLotacaoModel OrgaoServidorLotacao { get; set; }

        [JsonPropertyName("pensionistaRepresentante")]
        public PensionistaRepresentanteModel PensionistaRepresentante { get; set; }

        [JsonPropertyName("pessoa")]
        public PessoaJuridicaModel Pessoa { get; set; }

        [JsonPropertyName("servidorInativoInstuidorPensao")]
        public ServidorInativoInstuidorPensaoModel ServidorInativoInstuidorPensao { get; set; }

        [JsonPropertyName("situacao")]
        public string Situacao { get; set; }

        [JsonPropertyName("tipoServidor")]
        public string TipoServidor { get; set; }
    }

    public class EstadoExercicioModel
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }
    }

    public class FuncaoModel
    {
        [JsonPropertyName("codigoFuncaoCargo")]
        public string CodigoFuncaoCargo { get; set; }

        [JsonPropertyName("descricaoFuncaoCargo")]
        public string DescricaoFuncaoCargo { get; set; }
    }

    public class OrgaoServidorExercicioModel
    {
        [JsonPropertyName("codigo")]
        public string Codigo { get; set; }

        [JsonPropertyName("codigoOrgaoVinculado")]
        public string CodigoOrgaoVinculado { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("nomeOrgaoVinculado")]
        public string NomeOrgaoVinculado { get; set; }

        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }
    }

    public class OrgaoServidorLotacaoModel
    {
        [JsonPropertyName("codigo")]
        public string Codigo { get; set; }

        [JsonPropertyName("codigoOrgaoVinculado")]
        public string CodigoOrgaoVinculado { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("nomeOrgaoVinculado")]
        public string NomeOrgaoVinculado { get; set; }

        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }
    }

    public class PensionistaRepresentanteModel
    {
        [JsonPropertyName("cpfFormatado")]
        public string CpfFormatado { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }
    }

    public class ServidorInativoInstuidorPensaoModel
    {
        [JsonPropertyName("cpfFormatado")]
        public string CpfFormatado { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }
    }
}
