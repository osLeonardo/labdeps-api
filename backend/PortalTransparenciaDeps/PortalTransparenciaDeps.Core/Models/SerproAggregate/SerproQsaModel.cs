using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Models.SerproAggregate
{

    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);




   

    public class InformacoesAdicionais
    {
        [JsonPropertyName("optanteSimples")]
        public string OptanteSimples { get; set; }

        [JsonPropertyName("optanteMei")]
        public string OptanteMei { get; set; }

        [JsonPropertyName("listaPeriodoSimples")]
        public List<ListaPeriodoSimple> ListaPeriodoSimples { get; set; }
    }

    public class ListaPeriodoSimple
    {
        [JsonPropertyName("dataInicio")]
        public string DataInicio { get; set; }

        [JsonPropertyName("dataFim")]
        public string DataFim { get; set; }
    }




    public class RepresentanteLegal
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("qualificacao")]
        public string Qualificacao { get; set; }
    }

    public class SerproQsaModel
    {
        [JsonPropertyName("ni")]
        public string Ni { get; set; }

        [JsonPropertyName("tipoEstabelecimento")]
        public string TipoEstabelecimento { get; set; }

        [JsonPropertyName("nomeEmpresarial")]
        public string NomeEmpresarial { get; set; }

        [JsonPropertyName("nomeFantasia")]
        public string NomeFantasia { get; set; }

        [JsonPropertyName("situacaoCadastral")]
        public SituacaoCadastral SituacaoCadastral { get; set; }

        [JsonPropertyName("naturezaJuridica")]
        public NaturezaJuridica NaturezaJuridica { get; set; }

        [JsonPropertyName("dataAbertura")]
        public string DataAbertura { get; set; }

        [JsonPropertyName("cnaePrincipal")]
        public CnaePrincipal CnaePrincipal { get; set; }

        [JsonPropertyName("cnaeSecundarias")]
        public List<CnaeSecundaria> CnaeSecundarias { get; set; }

        [JsonPropertyName("endereco")]
        public Endereco Endereco { get; set; }

        [JsonPropertyName("municipioJurisdicao")]
        public MunicipioJurisdicao MunicipioJurisdicao { get; set; }

        [JsonPropertyName("telefones")]
        public List<Telefone> Telefones { get; set; }

        [JsonPropertyName("correioEletronico")]
        public string CorreioEletronico { get; set; }

        [JsonPropertyName("capitalSocial")]
        public double CapitalSocial { get; set; }

        [JsonPropertyName("porte")]
        public string Porte { get; set; }

        [JsonPropertyName("situacaoEspecial")]
        public string SituacaoEspecial { get; set; }

        [JsonPropertyName("dataSituacaoEspecial")]
        public string DataSituacaoEspecial { get; set; }

        [JsonPropertyName("informacoesAdicionais")]
        public InformacoesAdicionais InformacoesAdicionais { get; set; }

        [JsonPropertyName("socios")]
        public List<Socio> Socios { get; set; }
    }
    

    public class Socio
    {
        [JsonPropertyName("tipoSocio")]
        public string TipoSocio { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("qualificacao")]
        public string Qualificacao { get; set; }

        [JsonPropertyName("pais")]
        public Pais Pais { get; set; }

        [JsonPropertyName("representanteLegal")]
        public RepresentanteLegal RepresentanteLegal { get; set; }
    }


}
