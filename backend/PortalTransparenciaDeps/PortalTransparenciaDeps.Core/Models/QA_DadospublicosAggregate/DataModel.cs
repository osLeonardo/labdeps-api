
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Core.Models.QA_DadospublicosAggregate
{


    public class DadosModel
    {
        [JsonPropertyName("data")]
        public DataModel Data { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("errors")]
        public string Errors { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }

    public class DataModel
    {
        [JsonPropertyName("cnpj")]
        public string Cnpj { get; set; }

        [JsonPropertyName("cnpjMatriz")]
        public string CnpjMatriz { get; set; }

        [JsonPropertyName("tipoUnidade")]
        public string TipoUnidade { get; set; }

        [JsonPropertyName("razaoSocial")]
        public string RazaoSocial { get; set; }

        [JsonPropertyName("nomeFantasia")]
        public string NomeFantasia { get; set; }

        [JsonPropertyName("situacaoCadastral")]
        public string SituacaoCadastral { get; set; }

        [JsonPropertyName("dataSituacaoCadastral")]
        public string DataSituacaoCadastral { get; set; }

        [JsonPropertyName("motivoSituacaoCadastral")]
        public string MotivoSituacaoCadastral { get; set; }

        [JsonPropertyName("nomeCidadeExterior")]
        public string NomeCidadeExterior { get; set; }

        [JsonPropertyName("nomePais")]
        public string NomePais { get; set; }

        [JsonPropertyName("naturezaJuridica")]
        public string NaturezaJuridica { get; set; }

        [JsonPropertyName("dataInicioAtividade")]
        public string DataInicioAtividade { get; set; }

        [JsonPropertyName("dataInicioAtividadeMatriz")]
        public string DataInicioAtividadeMatriz { get; set; }

        [JsonPropertyName("cnaePrincipal")]
        public string CnaePrincipal { get; set; }

        [JsonPropertyName("descricaoTipoLogradouro")]
        public string DescricaoTipoLogradouro { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("numero")]
        public string Numero { get; set; }

        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("municipio")]
        public string Municipio { get; set; }

        [JsonPropertyName("municipioCodigoIbge")]
        public string MunicipioCodigoIbge { get; set; }

        [JsonPropertyName("telefone01")]
        public string Telefone01 { get; set; }

        [JsonPropertyName("telefone02")]
        public string Telefone02 { get; set; }

        [JsonPropertyName("fax")]
        public string Fax { get; set; }

        [JsonPropertyName("correioEletronico")]
        public string CorreioEletronico { get; set; }

        [JsonPropertyName("qualificacaoResponsavel")]
        public string QualificacaoResponsavel { get; set; }

        [JsonPropertyName("capitalSocialEmpresa")]
        public string CapitalSocialEmpresa { get; set; }

        [JsonPropertyName("porte")]
        public string Porte { get; set; }

        [JsonPropertyName("opcaoPeloSimples")]
        public string OpcaoPeloSimples { get; set; }

        [JsonPropertyName("dataOpcaoPeloSimples")]
        public string DataOpcaoPeloSimples { get; set; }

        [JsonPropertyName("dataExclusaoOpcaoPeloSimples")]
        public string DataExclusaoOpcaoPeloSimples { get; set; }

        [JsonPropertyName("opcaoMei")]
        public string OpcaoMei { get; set; }

        [JsonPropertyName("situacaoEspecial")]
        public string SituacaoEspecial { get; set; }

        [JsonPropertyName("dataSituacaoEspecial")]
        public string DataSituacaoEspecial { get; set; }

        [JsonPropertyName("nomeEnteFederativo")]
        public string NomeEnteFederativo { get; set; }

        [JsonPropertyName("socios")]
        public List<SocioModel> Socios { get; set; }

        [JsonPropertyName("cnaesSecundarios")]
        public List<CnaesSecundarioModel> CnaesSecundarios { get; set; }
    }

    public class SocioModel
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("documento")]
        public string Documento { get; set; }

        [JsonPropertyName("qualificacao")]
        public string Qualificacao { get; set; }
    }

}
