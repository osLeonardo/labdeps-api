using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Models.SerproAggregate
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

    public class SerproEmpresaModel
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

}
