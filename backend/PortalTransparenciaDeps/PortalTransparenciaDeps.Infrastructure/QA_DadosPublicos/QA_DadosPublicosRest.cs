
using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.DTO;

using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Core.Models.QA_DadospublicosAggregate;

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
            
            string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiZGVwcyIsIm5iZiI6MTY4OTEwMjM5MywiZXhwIjoxNjg5MTA5NTkzLCJpYXQiOjE2ODkxMDIzOTN9.-xFqqnV6Q3N2RjwR9KPK8KSx87M0uAbCGwOIgZLJmU8";
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            string url = $"https://qa-dados-publicos.deps.com.br/api/v1/pessoas?documento={documento}";

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
