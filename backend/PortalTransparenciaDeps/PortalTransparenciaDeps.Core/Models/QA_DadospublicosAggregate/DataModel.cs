using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Models.QA_DadospublicosAggregate
{
    public class Dados
    {
        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("cnpjMatriz")]
        public string CnpjMatriz { get; set; }

        [JsonProperty("tipoUnidade")]
        public string TipoUnidade { get; set; }

        [JsonProperty("razaoSocial")]
        public string RazaoSocial { get; set; }

        [JsonProperty("nomeFantasia")]
        public string NomeFantasia { get; set; }

        [JsonProperty("situacaoCadastral")]
        public string SituacaoCadastral { get; set; }

        [JsonProperty("dataSituacaoCadastral")]
        public string DataSituacaoCadastral { get; set; }

        [JsonProperty("motivoSituacaoCadastral")]
        public string MotivoSituacaoCadastral { get; set; }

        [JsonProperty("nomeCidadeExterior")]
        public string NomeCidadeExterior { get; set; }

        [JsonProperty("nomePais")]
        public string NomePais { get; set; }

        [JsonProperty("naturezaJuridica")]
        public string NaturezaJuridica { get; set; }

        [JsonProperty("dataInicioAtividade")]
        public string DataInicioAtividade { get; set; }

        [JsonProperty("dataInicioAtividadeMatriz")]
        public string DataInicioAtividadeMatriz { get; set; }

        [JsonProperty("cnaePrincipal")]
        public string CnaePrincipal { get; set; }

        [JsonProperty("descricaoTipoLogradouro")]
        public string DescricaoTipoLogradouro { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("municipioCodigoIbge")]
        public string MunicipioCodigoIbge { get; set; }

        [JsonProperty("telefone01")]
        public string Telefone01 { get; set; }

        [JsonProperty("telefone02")]
        public string Telefone02 { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("correioEletronico")]
        public string CorreioEletronico { get; set; }

        [JsonProperty("qualificacaoResponsavel")]
        public string QualificacaoResponsavel { get; set; }

        [JsonProperty("capitalSocialEmpresa")]
        public string CapitalSocialEmpresa { get; set; }

        [JsonProperty("porte")]
        public string Porte { get; set; }

        [JsonProperty("opcaoPeloSimples")]
        public string OpcaoPeloSimples { get; set; }

        [JsonProperty("dataOpcaoPeloSimples")]
        public string DataOpcaoPeloSimples { get; set; }

        [JsonProperty("dataExclusaoOpcaoPeloSimples")]
        public string DataExclusaoOpcaoPeloSimples { get; set; }

        [JsonProperty("opcaoMei")]
        public string OpcaoMei { get; set; }

        [JsonProperty("situacaoEspecial")]
        public string SituacaoEspecial { get; set; }

        [JsonProperty("dataSituacaoEspecial")]
        public string DataSituacaoEspecial { get; set; }

        [JsonProperty("nomeEnteFederativo")]
        public string NomeEnteFederativo { get; set; }

        [JsonProperty("socios")]
        public List<Socio> Socios { get; set; }

        [JsonProperty("cnaesSecundarios")]
        public List<object> CnaesSecundarios { get; set; }
    }
}
