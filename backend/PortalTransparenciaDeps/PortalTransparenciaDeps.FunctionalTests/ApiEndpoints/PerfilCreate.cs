using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace PortalTransparenciaDeps.FunctionalTests.ApiEndpoints
{
    [Collection("Sequential")]
    public class PerfilCreate : IClassFixture<CustomWebApplicationFactory<WebMarker>>
    {
        private readonly HttpClient _client;

        public PerfilCreate(CustomWebApplicationFactory<WebMarker> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task CreatePerfil()
        {
            Util.SetJwtToken(_client, PerfilUsuario.AdministradorPortal);
            var response = await _client.PostAsJsonAsync(Util.GetPathWithVersion(CreatePerfilRequest.Route, 1), SeedData.CreatePerfil);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var model = Util.LoadObject<CreatePerfilResponse>(response);

            Assert.NotNull(model);
            Assert.True(model.Id > 0);
            Assert.Equal(SeedData.CreatePerfil.Nome, model.Nome);
            Assert.True(model.Ativo);
        }

        [Fact]
        public async Task ForbiddenCreatePerfilGivenWrongUser()
        {
            Util.SetJwtToken(_client, PerfilUsuario.UsuarioGestor);
            var response = await _client.PostAsJsonAsync(Util.GetPathWithVersion(CreatePerfilRequest.Route, 1), SeedData.CreatePerfil);

            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }

        [Fact]
        public async Task UnauthorizedCreatePerfilGivenNoToken()
        {
            var response = await _client.PostAsJsonAsync(Util.GetPathWithVersion(CreatePerfilRequest.Route, 1), SeedData.CreatePerfil);

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }
    }
}
