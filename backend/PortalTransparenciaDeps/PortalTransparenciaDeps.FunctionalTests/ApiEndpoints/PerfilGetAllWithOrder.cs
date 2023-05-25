using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace PortalTransparenciaDeps.FunctionalTests.ApiEndpoints
{
    public class PerfilGetAllWithOrder : IClassFixture<CustomWebApplicationFactory<WebMarker>>
    {
        private readonly HttpClient _client;

        public PerfilGetAllWithOrder(CustomWebApplicationFactory<WebMarker> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ReturnsSeedPerfisWithOrdem()
        {
            Util.SetJwtToken(_client, PerfilUsuario.AdministradorPortal);

            var response = await _client.GetAsync(Util.GetPathWithVersion("perfil/ordenados", 1));
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var model = Util.LoadObject<List<GetAllPerfilWithOrderResponse>>(response);

            Assert.Equal(SeedData.TestPerfil2.Nome, model.First().Nome);
            Assert.Equal(SeedData.TestPerfil2.Ordem, model.First().Ordem);
            Assert.Equal(SeedData.TestPerfil1.Nome, model.Last().Nome);
            Assert.Equal(SeedData.TestPerfil1.Ordem, model.Last().Ordem);
            Assert.Equal(3, model.Count);
        }
    }
}
