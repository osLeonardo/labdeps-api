using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Services
{
    public class PortalTransparenciaRest : IPortalTransparencia
    {
        //BENEFÍCIOS
        public async Task<ExternalResponseList<BolsaFamiliaModel>> GetBolsaFamiliaByCpf(int dataCompetencia, int dataReferencia, string codigo, int pagina)
        {
            string key = "chave-api-dados";
            string value = "7c137febe8f79a03ffe7a437026f0e05";
            string url = $"https://api.portaldatransparencia.gov.br/api-de-dados/bolsa-familia-disponivel-por-cpf-ou-nis?anoMesCompetencia={dataCompetencia}&anoMesReferencia={dataReferencia}&codigo={codigo}&pagina={pagina}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add(key, value);
            var response = new ExternalResponseList<BolsaFamiliaModel>();
            using (var client = new HttpClient())
            {
                var responsePortal = await client.SendAsync(request);
                var contentResponse = await responsePortal.Content.ReadAsStringAsync();

                if (responsePortal.IsSuccessStatusCode)
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.DataReturn = JsonSerializer.Deserialize<List<BolsaFamiliaModel>>(contentResponse);
                }
                else
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        public async Task<ExternalResponseList<BpcModel>> GetBpcByCpf(string cpf, int pagina)
        {
            string key = "chave-api-dados";
            string value = "7c137febe8f79a03ffe7a437026f0e05";
            string url = $"https://api.portaldatransparencia.gov.br/api-de-dados/bpc-por-cpf-ou-nis?codigo={cpf}&pagina={pagina}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add(key, value);
            var response = new ExternalResponseList<BpcModel>();
            using(var client = new HttpClient())
            {
                var responsePortal = await client.SendAsync(request);
                var contentResponse = await responsePortal.Content.ReadAsStringAsync();
                
                if(responsePortal.IsSuccessStatusCode)
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.DataReturn = JsonSerializer.Deserialize<List<BpcModel>>(contentResponse);
                }
                else
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        public async Task<ExternalResponseList<PetiModel>> GetPetiByCpf(string codigo, int pagina)
        {
            string key = "chave-api-dados";
            string value = "7c137febe8f79a03ffe7a437026f0e05";
            string url = $"https://api.portaldatransparencia.gov.br/api-de-dados/peti-por-cpf-ou-nis?codigo={codigo}&pagina={pagina}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add(key, value);
            var response = new ExternalResponseList<PetiModel>();
            using (var client = new HttpClient())
            {
                var responsePortal = await client.SendAsync(request);
                var contentResponse = await responsePortal.Content.ReadAsStringAsync();

                if (responsePortal.IsSuccessStatusCode)
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.DataReturn = JsonSerializer.Deserialize<List<PetiModel>>(contentResponse);
                }
                else
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        
        //SANÇÕES
        public async Task<ExternalResponseList<CepimModel>> GetCepimByCnpj(string cnpj, int pagina)
        {
            string key = "chave-api-dados";
            string value = "7c137febe8f79a03ffe7a437026f0e05";
            string url = $"https://api.portaldatransparencia.gov.br/api-de-dados/cepim?cnpjSancionado={cnpj}&pagina={pagina}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add(key, value);
            var response = new ExternalResponseList<CepimModel>();
            using (var client = new HttpClient())
            {
                var responsePortal = await client.SendAsync(request);
                var contentResponse = await responsePortal.Content.ReadAsStringAsync();

                if (responsePortal.IsSuccessStatusCode)
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.DataReturn = JsonSerializer.Deserialize<List<CepimModel>>(contentResponse);
                }
                else
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        public async Task<ExternalResponseList<CnepModel>> GetCnepByCnpj(string cnpj, int pagina)
        {
            string key = "chave-api-dados";
            string value = "7c137febe8f79a03ffe7a437026f0e05";
            string url = $"https://api.portaldatransparencia.gov.br/api-de-dados/cnep?codigoSancionado={cnpj}&pagina={pagina}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add(key, value);
            var response = new ExternalResponseList<CnepModel>();
            using (var client = new HttpClient())
            {
                var responsePortal = await client.SendAsync(request);
                var contentResponse = await responsePortal.Content.ReadAsStringAsync();

                if (responsePortal.IsSuccessStatusCode)
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.DataReturn = JsonSerializer.Deserialize<List<CnepModel>>(contentResponse);
                }
                else
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        public async Task<ExternalResponseList<LenienciaModel>> GetLenienciaByCnpj(string cnpj, int pagina)
        {
            string key = "chave-api-dados";
            string value = "7c137febe8f79a03ffe7a437026f0e05";
            string url = $"https://api.portaldatransparencia.gov.br/api-de-dados/acordos-leniencia?cnpjSancionado={cnpj}&pagina={pagina}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add(key, value);
            var response = new ExternalResponseList<LenienciaModel>();
            using (var client = new HttpClient())
            {
                var responsePortal = await client.SendAsync(request);
                var contentResponse = await responsePortal.Content.ReadAsStringAsync();

                if (responsePortal.IsSuccessStatusCode)
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.DataReturn = JsonSerializer.Deserialize<List<LenienciaModel>>(contentResponse);
                }
                else
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        
        //SERVIDORES DO EXECUTIVO FEDERAL
        public async Task<ExternalResponseList<PepModel>> GetPepByCpf(string cpf, int pagina)
        {
            string key = "chave-api-dados";
            string value = "7c137febe8f79a03ffe7a437026f0e05";
            string url = $"https://api.portaldatransparencia.gov.br/api-de-dados/peps?cpf={cpf}&pagina={pagina}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add(key, value);
            var response = new ExternalResponseList<PepModel>();
            using (var client = new HttpClient())
            {
                var responsePortal = await client.SendAsync(request);
                var contentResponse = await responsePortal.Content.ReadAsStringAsync();

                if (responsePortal.IsSuccessStatusCode)
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.DataReturn = JsonSerializer.Deserialize<List<PepModel>>(contentResponse);
                }
                else
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        public async Task<ExternalResponseList<RemuneracaoModel>> GetRemuneracaoByCpf(string cpf, int data, int pagina)
        {
            string key = "chave-api-dados";
            string value = "7c137febe8f79a03ffe7a437026f0e05";
            string url = $"https://api.portaldatransparencia.gov.br/api-de-dados/servidores/remuneracao?cpf={cpf}&mesAno={data}&pagina={pagina}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add(key, value);
            var response = new ExternalResponseList<RemuneracaoModel>();
            using (var client = new HttpClient())
            {
                var responsePortal = await client.SendAsync(request);
                var contentResponse = await responsePortal.Content.ReadAsStringAsync();

                if (responsePortal.IsSuccessStatusCode)
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.DataReturn = JsonSerializer.Deserialize<List<RemuneracaoModel>>(contentResponse);
                }
                else
                {
                    response.StatusCode = responsePortal.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }
    }
}
