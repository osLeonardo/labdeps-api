//using PortalTransparenciaDeps.Core.Enums;
//using PortalTransparenciaDeps.Web;
//using PortalTransparenciaDeps.Web.Endpoints.ParametrizacaoMetricaEndpoints;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Xunit;

//namespace PortalTransparenciaDeps.FunctionalTests.ApiEndpoints
//{
//    public class ParametrizacaoMetricaUpdate : IClassFixture<CustomWebApplicationFactory<WebMarker>>
//    {
//        private readonly HttpClient _client;

//        public ParametrizacaoMetricaUpdate(CustomWebApplicationFactory<WebMarker> factory)
//        {
//            _client = factory.CreateClient();
//        }

//        [Fact]
//        public async Task UpdateAndCreateParametrizacaoMetricac()
//        {
//            Util.SetJwtToken(_client, PerfilUsuario.AdministradorPortal);

//            var queryParams = new Dictionary<string, string>
//            {
//                { "metricaId", "1" },
//                { "perfilId", "1" }
//            };
//            var response = await _client.GetAsync(Util.GetPathWithVersion(ListByMetricaOuPerfilRequest.Route, 1, queryParams));
//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

//            var model = Util.LoadObject<List<ListByMetricaOuPerfilResponse>>(response);

//            var parametrizacaoMetricaToUpdate = model.First().Parametrizacoes.First();
//            var data = new UpdateParametrizacaoMetricaRequest
//            {
//                ParametrizacoesMetricas = new List<CriarAtualizarParametrizacaoMetricaViewModel>
//                {
//                    new CriarAtualizarParametrizacaoMetricaViewModel
//                    {
//                        Id = parametrizacaoMetricaToUpdate.Id,
//                        Idade = 60,
//                        MetricaId = model.First().Metrica.Id,
//                        PerfilId = model.First().Perfil.Id,
//                        Multiplicador = 0.85m,
//                        Percentual = 30m
//                    },
//                    new CriarAtualizarParametrizacaoMetricaViewModel
//                    {
//                        Id = null,
//                        Idade = 90,
//                        MetricaId = model.First().Metrica.Id,
//                        PerfilId = model.First().Perfil.Id,
//                        Multiplicador = 0.85m,
//                        Percentual = 25m
//                    }
//                }
//            };

//            response = await _client.PutAsync(Util.GetPathWithVersion(UpdateParametrizacaoMetricaRequest.Route, 1), Util.GetJson(data));

//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

//            response = await _client.GetAsync(Util.GetPathWithVersion(ListByMetricaOuPerfilRequest.Route, 1, queryParams));
//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

//            model = Util.LoadObject<List<ListByMetricaOuPerfilResponse>>(response);

//            var parametrizacaoMetricaUpdated = model.First().Parametrizacoes.Single(x => x.Id == parametrizacaoMetricaToUpdate.Id);
//            var parametrizacaoMetricaCreated = model.First().Parametrizacoes.Single(x => x.Id != parametrizacaoMetricaToUpdate.Id);

//            Assert.Equal(2, model.First().Parametrizacoes.Count);
//            Assert.Equal(60, parametrizacaoMetricaUpdated.Idade);
//            Assert.Equal(0.85m, parametrizacaoMetricaUpdated.Multiplicador);
//            Assert.Equal(30m, parametrizacaoMetricaUpdated.Percentual);

//            Assert.True(parametrizacaoMetricaCreated.Id != Guid.Empty);
//            Assert.Equal(90, parametrizacaoMetricaCreated.Idade);
//            Assert.Equal(0.85m, parametrizacaoMetricaCreated.Multiplicador);
//            Assert.Equal(25m, parametrizacaoMetricaCreated.Percentual);
//        }
//    }
//}
