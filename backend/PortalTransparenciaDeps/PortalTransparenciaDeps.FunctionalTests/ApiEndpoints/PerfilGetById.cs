using Ardalis.HttpClientTestExtensions;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace PortalTransparenciaDeps.FunctionalTests.ApiEndpoints
{
    [Collection("Sequential")]
    public class PerfilGetById : IClassFixture<CustomWebApplicationFactory<WebMarker>>
    {
        private readonly HttpClient _client;

        public PerfilGetById(CustomWebApplicationFactory<WebMarker> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ReturnsSeedPerfilGivenId1()
        {
            Util.SetJwtToken(_client, PerfilUsuario.AdministradorPortal);
            var result = await _client.GetAndDeserializeAsync<GetPerfilByIdResponse>(Util.GetPathWithVersion(GetPerfilByIdRequest.BuildRoute(1), 1));

            Assert.Equal(1, result.Id);
            Assert.Equal(SeedData.TestPerfil1.Nome, result.Nome);
            Assert.Equal(SeedData.TestPerfil1.Ordem, result.Ordem);
        }

        [Fact]
        public async Task ReturnsNotFoundGivenId0()
        {
            string route = GetPerfilByIdRequest.BuildRoute(0);
            _ = await _client.GetAndEnsureNotFoundAsync(route);
        }
    }
}
