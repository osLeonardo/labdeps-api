
using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Entities.DadosPublicosAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Core.Models.QA_DadospublicosAggregate;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace PortalTransparenciaDeps.Infrastructure.QA_DadosPublicos
{
    public class QA_DadosPublicosRest : IQA_DadosPublicos
    {

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
