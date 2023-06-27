
using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Entities.DadosPublicosAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Core.Models.QA_DadospublicosAggregate;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System.Dynamic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace PortalTransparenciaDeps.Infrastructure.QA_DadosPublicos
{
    public class QA_DadosPublicosRest : IQA_DadosPublicos
    {
        private readonly IRepository<Dados> _repository;

        public QA_DadosPublicosRest(IRepository<Dados> repository)
        {
            _repository = repository;
        }

        public async Task<Dados> CreateDados
            (
                string cnpj, string cnpjMatriz, string tipoUnidade, string razaoSocial, string nomeFantasia, 
                string situacaoCadastral, string dataSituacaoCadastral, string motivoSituacaoCadastral, 
                string nomeCidadeExterior, string nomePais, string naturezaJuridica, string dataInicioAtividade, 
                string dataInicioAtividadeMatriz, string cnaePrincipal, string descricaoTipoLogradouro, string logradouro, 
                string numero, string complemento, string bairro, string cep, string uf, string municipio, 
                string municipioCodigoIbge, string telefone01, string telefone02, string fax, string correioEletronico, 
                string qualificacaoResponsavel, string capitalSocialEmpresa, string porte, string opcaoPeloSimples, 
                string dataOpcaoPeloSimples, string dataExclusaoOpcaoPeloSimples, string opcaoMei, string situacaoEspecial, 
                string dataSituacaoEspecial, string nomeEnteFederativo
            )
        {
            Guard.Against.NullOrEmpty(cnpj, nameof(cnpj));
            Guard.Against.NullOrEmpty(cnpjMatriz, nameof(cnpjMatriz));
            Guard.Against.NullOrEmpty(tipoUnidade, nameof(tipoUnidade));
            Guard.Against.NullOrEmpty(razaoSocial, nameof(razaoSocial));
            Guard.Against.NullOrEmpty(nomeFantasia, nameof(nomeFantasia));
            Guard.Against.NullOrEmpty(situacaoCadastral, nameof(situacaoCadastral));
            Guard.Against.NullOrEmpty(dataSituacaoCadastral, nameof(dataSituacaoCadastral));
            Guard.Against.NullOrEmpty(motivoSituacaoCadastral, nameof(motivoSituacaoCadastral));
            Guard.Against.NullOrEmpty(dataInicioAtividadeMatriz, nameof(dataInicioAtividadeMatriz));
            Guard.Against.NullOrEmpty(cnaePrincipal, nameof(cnaePrincipal));
            Guard.Against.NullOrEmpty(descricaoTipoLogradouro, nameof(descricaoTipoLogradouro));
            Guard.Against.NullOrEmpty(logradouro, nameof(logradouro));
            Guard.Against.NullOrEmpty(numero, nameof(numero));
            Guard.Against.NullOrEmpty(complemento, nameof(complemento));
            Guard.Against.NullOrEmpty(bairro, nameof(bairro));
            Guard.Against.NullOrEmpty(uf, nameof(uf));
            Guard.Against.NullOrEmpty(municipio, nameof(municipio));
            Guard.Against.NullOrEmpty(qualificacaoResponsavel, nameof(qualificacaoResponsavel));
            Guard.Against.NullOrEmpty(capitalSocialEmpresa, nameof(capitalSocialEmpresa));
            Guard.Against.NullOrEmpty(porte, nameof(porte));
            Guard.Against.NullOrEmpty(opcaoPeloSimples, nameof(opcaoPeloSimples));
            Guard.Against.NullOrEmpty(dataOpcaoPeloSimples, nameof(dataOpcaoPeloSimples));
            Guard.Against.NullOrEmpty(dataExclusaoOpcaoPeloSimples, nameof(dataExclusaoOpcaoPeloSimples));
            Guard.Against.NullOrEmpty(opcaoMei, nameof(opcaoMei));
            Guard.Against.NullOrEmpty(situacaoEspecial, nameof(situacaoEspecial));
            Guard.Against.NullOrEmpty(dataSituacaoEspecial, nameof(dataSituacaoEspecial));
            Guard.Against.NullOrEmpty(nomeEnteFederativo, nameof(nomeEnteFederativo));

            var CreateDadosPublicos = Dados.NewData
                (
                        cnpj, cnpjMatriz, tipoUnidade, razaoSocial, nomeFantasia, situacaoCadastral, dataSituacaoCadastral,
                        motivoSituacaoCadastral, nomeCidadeExterior, nomePais, naturezaJuridica, dataInicioAtividade,
                        dataInicioAtividadeMatriz, cnaePrincipal, descricaoTipoLogradouro, logradouro, numero, complemento,
                        bairro, cep, uf, municipio, municipioCodigoIbge, telefone01, telefone02, correioEletronico,
                        opcaoPeloSimples, qualificacaoResponsavel, capitalSocialEmpresa, porte, dataOpcaoPeloSimples,
                        dataExclusaoOpcaoPeloSimples, dataSituacaoEspecial, opcaoMei, situacaoEspecial, fax,
                        nomeEnteFederativo
                );

            await _repository.AddAsync(CreateDadosPublicos);
            return CreateDadosPublicos;
        }

        public async Task<ExternalResponseObject<DadosModel>> GetDados(string documento)
        {
            HttpClient httpClient = new HttpClient();
            
            string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiZGVwcyIsIm5iZiI6MTY4NzgxMTMwNSwiZXhwIjoxNjg3ODE4NTA1LCJpYXQiOjE2ODc4MTEzMDV9.C2VEngRUA56EqsrBIqEV2mk8br4hDOZNjdj_wAo1UzY";
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            string url = $"https://qa-dados-publicos.deps.com.br/api/v1/pessoas?documento={documento}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var response = new ExternalResponseObject<DadosModel>();
            using(httpClient) 
            {
                var responseDadosPublicos = await httpClient.GetAsync(url);
                var contentResponse = await responseDadosPublicos.Content.ReadAsStringAsync();
                
                if (responseDadosPublicos.IsSuccessStatusCode)
                {
                    response.StatusCode = responseDadosPublicos.StatusCode;
                    response.DataReturn = JsonSerializer.Deserialize<DadosModel>(contentResponse);
                }

                else
                {
                    response.StatusCode = responseDadosPublicos.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }
    }
}
