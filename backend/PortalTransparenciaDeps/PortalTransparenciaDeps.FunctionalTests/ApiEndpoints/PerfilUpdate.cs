using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace PortalTransparenciaDeps.FunctionalTests.ApiEndpoints
{
    [Collection("Sequential")]
    public class PerfilUpdate : IClassFixture<CustomWebApplicationFactory<WebMarker>>
    {
        private readonly HttpClient _client;
        private const string _newName = "Ultra conservador";

        public PerfilUpdate(CustomWebApplicationFactory<WebMarker> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task UpdateNamePerfil()
        {
            Util.SetJwtToken(_client, PerfilUsuario.AdministradorPortal);
            var request = new UpdatePerfilRequest
            {
                Id = SeedData.TestPerfil1.Id,
                Nome = _newName,
                Ativo = true
            };

            var response = await _client.PutAsync(Util.GetPathWithVersion(UpdatePerfilRequest.Route, 1), Util.GetJson(request));
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var model = Util.LoadObject<UpdatePerfilResponse>(response);

            Assert.NotNull(model);
            Assert.True(model.Id > 0);
            Assert.Equal(_newName, model.Nome);
            Assert.True(model.Ativo);
        }

        [Fact]
        public async Task UpdateNameAndAtivoPerfil()
        {
            Util.SetJwtToken(_client, PerfilUsuario.AdministradorPortal);
            var request = new UpdatePerfilRequest
            {
                Id = SeedData.TestPerfil2.Id,
                Nome = _newName,
                Ativo = false
            };

            var response = await _client.PutAsync(Util.GetPathWithVersion(UpdatePerfilRequest.Route, 1), Util.GetJson(request));
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var model = Util.LoadObject<UpdatePerfilResponse>(response);

            Assert.NotNull(model);
            Assert.True(model.Id > 0);
            Assert.Equal(_newName, model.Nome);
            Assert.False(model.Ativo);
        }

        [Fact]
        public async Task ForbiddenCreateMetricaGivenWrongUser()
        {
            Util.SetJwtToken(_client, PerfilUsuario.UsuarioGestor);
            var request = new UpdatePerfilRequest
            {
                Id = SeedData.TestPerfil1.Id,
                Nome = _newName,
                Ativo = false
            };
            var response = await _client.PutAsync(Util.GetPathWithVersion(UpdatePerfilRequest.Route, 1), Util.GetJson(request));

            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }

        [Fact]
        public async Task UnauthorizedCreateMetricaGivenNoToken()
        {
            var request = new UpdatePerfilRequest
            {
                Id = SeedData.TestPerfil2.Id,
                Nome = _newName,
                Ativo = false
            };
            var response = await _client.PutAsync(Util.GetPathWithVersion(UpdatePerfilRequest.Route, 1), Util.GetJson(request));

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }
    }
}
