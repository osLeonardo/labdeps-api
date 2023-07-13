using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Core.Models.SerproAggregate;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Serpro
{
    public class SerproRest : ISerproCnpj
    {
        public async Task<ExternalResponseObject<SerproBasicoModel>> GetConsultaBasica(string ni)
        {
            HttpClient httpClient = new HttpClient();
            string token = "06aef429-a981-3ec5-a1f8-71d38d86481e";
            Console.WriteLine(token);
            Type tipo = token.GetType();
            Console.WriteLine(tipo);
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            string url = $"https://gateway.apiserpro.serpro.gov.br/consulta-cnpj-df-trial/v2/basica/{ni}";
            var response = new ExternalResponseObject<SerproBasicoModel>();
            using (httpClient)
            {
                var responseSerproConsultaBasica = await httpClient.GetAsync(url);
                var contentResponse = await responseSerproConsultaBasica.Content.ReadAsStringAsync();

                    if (responseSerproConsultaBasica.IsSuccessStatusCode)
                {
                    response.StatusCode = responseSerproConsultaBasica.StatusCode;
                    response.DataReturn = JsonSerializer.Deserialize<SerproBasicoModel>(contentResponse);
                    Console.WriteLine(response);
                }

                else
                {
                    response.StatusCode = responseSerproConsultaBasica.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        public async Task<ExternalResponseObject<SerproEmpresaModel>> GetConsultaEmpresa(string ni)
        {
            HttpClient httpClient = new HttpClient();
            string token = "06aef429-a981-3ec5-a1f8-71d38d86481e";
            Console.WriteLine(token);
            Type tipo = token.GetType();
            Console.WriteLine(tipo);
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            string url = $"https://gateway.apiserpro.serpro.gov.br/consulta-cnpj-df-trial/v2/empresa/{ni}";
            var response = new ExternalResponseObject<SerproEmpresaModel>();
            using (httpClient)
            {
                var responseSerproEmpresa = await httpClient.GetAsync(url);
                var contentResponse = await responseSerproEmpresa.Content.ReadAsStringAsync();

                if (responseSerproEmpresa.IsSuccessStatusCode)
                {
                    response.StatusCode = responseSerproEmpresa.StatusCode;
                    response.DataReturn = JsonSerializer.Deserialize<SerproEmpresaModel>(contentResponse);
                    Console.WriteLine(response);
                }

                else
                {
                    response.StatusCode = responseSerproEmpresa.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        public async Task<ExternalResponseObject<SerproQsaModel>> GetConsultaQsa(string ni)
        {
            HttpClient httpClient = new HttpClient();
            string token = "06aef429-a981-3ec5-a1f8-71d38d86481e";
            Console.WriteLine(token);
            Type tipo = token.GetType();
            Console.WriteLine(tipo);
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            string url = $"https://gateway.apiserpro.serpro.gov.br/consulta-cnpj-df-trial/v2/qsa/{ni}";
            var response = new ExternalResponseObject<SerproQsaModel>();
            using (httpClient)
            {
                var responseSerproQsa = await httpClient.GetAsync(url);
                var contentResponse = await responseSerproQsa.Content.ReadAsStringAsync();

                if (responseSerproQsa.IsSuccessStatusCode)
                {
                    response.StatusCode = responseSerproQsa.StatusCode;
                    response.DataReturn = JsonSerializer.Deserialize<SerproQsaModel>(contentResponse);
                    Console.WriteLine(response);
                }

                else
                {
                    response.StatusCode = responseSerproQsa.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }
    }
}
