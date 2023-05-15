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
//    public class ParametrizacaoMetricaListByMetricaOuPerfil : IClassFixture<CustomWebApplicationFactory<WebMarker>>
//    {
//        private readonly HttpClient _client;

//        public ParametrizacaoMetricaListByMetricaOuPerfil(CustomWebApplicationFactory<WebMarker> factory)
//        {
//            _client = factory.CreateClient();
//        }

//        [Fact]
//        public async Task ListParametrizacaoMetricaByMetrica()
//        {
//            Util.SetJwtToken(_client, PerfilUsuario.AdministradorPortal);

//            var queryParams = new Dictionary<string, string>
//            {
//                { "metricaId", "1" }
//            };
//            var response = await _client.GetAsync(Util.GetPathWithVersion(ListByMetricaOuPerfilRequest.Route, 1, queryParams));
//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

//            var model = Util.LoadObject<List<ListByMetricaOuPerfilResponse>>(response);

//            Assert.NotNull(model);
//            Assert.True(model.All(x => x.Metrica.Id == 1));
//        }

//        [Fact]
//        public async Task ListParametrizacaoMetricaByPerfil()
//        {
//            Util.SetJwtToken(_client, PerfilUsuario.AdministradorPortal);

//            var queryParams = new Dictionary<string, string>
//            {
//                { "perfilId", "1" }
//            };
//            var response = await _client.GetAsync(Util.GetPathWithVersion(ListByMetricaOuPerfilRequest.Route, 1, queryParams));
//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

//            var model = Util.LoadObject<List<ListByMetricaOuPerfilResponse>>(response);

//            Assert.NotNull(model);
//            Assert.True(model.All(x => x.Perfil.Id == 1));
//        }

//        [Fact]
//        public async Task ListParametrizacaoMetricaByPerfilAndMetrica()
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

//            Assert.NotNull(model);
//            Assert.Single(model);
//            Assert.True(model.All(x => x.Perfil.Id == 1));
//            Assert.True(model.All(x => x.Metrica.Id == 1));
//        }
//    }
//}
