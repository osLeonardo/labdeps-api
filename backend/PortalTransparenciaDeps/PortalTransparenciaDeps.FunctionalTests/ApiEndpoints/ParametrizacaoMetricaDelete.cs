//using PortalTransparenciaDeps.Core.Enums;
//using PortalTransparenciaDeps.Web;
//using PortalTransparenciaDeps.Web.Endpoints.ParametrizacaoMetricaEndpoints;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Xunit;

//namespace PortalTransparenciaDeps.FunctionalTests.ApiEndpoints
//{
//    [Collection("Sequential")]
//    public class ParametrizacaoMetricaDelete : IClassFixture<CustomWebApplicationFactory<WebMarker>>
//    {
//        private readonly HttpClient _client;

//        public ParametrizacaoMetricaDelete(CustomWebApplicationFactory<WebMarker> factory)
//        {
//            _client = factory.CreateClient();
//        }

//        [Fact]
//        public async Task DeleteParametrizacaoMetrica()
//        {
//            Util.SetJwtToken(_client, PerfilUsuario.AdministradorPortal);

//            var queryParams = new Dictionary<string, string>
//            {
//                { "perfilId", "1" },
//                { "metricaId", "1" }
//            };
//            var response = await _client.GetAsync(Util.GetPathWithVersion(ListByMetricaOuPerfilRequest.Route, 1, queryParams));
//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

//            var model = Util.LoadObject<List<ListByMetricaOuPerfilResponse>>(response);

//            var parametrizacaoId = model.First().Parametrizacoes.First().Id;
//            var path = Util.GetPathWithVersion(DeleteParametrizacaoMetricaRequest.BuildRoute(parametrizacaoId), 1);
//            response = await _client.DeleteAsync(path);
//            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);

//            queryParams = new Dictionary<string, string>
//            {
//                { "perfilId", "1" }
//            };

//            response = await _client.GetAsync(Util.GetPathWithVersion(ListByMetricaOuPerfilRequest.Route, 1, queryParams));
//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

//            model = Util.LoadObject<List<ListByMetricaOuPerfilResponse>>(response);

//            Assert.NotNull(model);
//            Assert.DoesNotContain(model, x => x.Metrica.Id == 1);
//        }
//    }
//}
