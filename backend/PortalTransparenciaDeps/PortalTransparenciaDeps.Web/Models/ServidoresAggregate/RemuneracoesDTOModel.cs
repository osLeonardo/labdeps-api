using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.ServidoresAggregate
{
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
}
