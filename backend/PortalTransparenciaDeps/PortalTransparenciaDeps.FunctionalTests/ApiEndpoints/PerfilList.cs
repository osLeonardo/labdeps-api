using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Base;
using PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace PortalTransparenciaDeps.FunctionalTests.ApiEndpoints
{
    [Collection("Sequential")]
    public class PerfilList : IClassFixture<CustomWebApplicationFactory<WebMarker>>
    {
        private readonly HttpClient _client;

        public PerfilList(CustomWebApplicationFactory<WebMarker> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ListPerfilWithFilter()
        {
            Util.SetJwtToken(_client, PerfilUsuario.AdministradorPortal);

            var queryParams = new Dictionary<string, string>
            {
                { "ativo", "true" },
                { "filter", "cons" },
                { "page", "1" },
                { "size", "10" }
            };

            var response = await _client.GetAsync(Util.GetPathWithVersion(ListPerfilRequest.Route, 1, queryParams));
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var model = Util.LoadObject<PagedResponse<ListPerfilResponse>>(response);

            Assert.NotNull(model);
            Assert.True(model.Items.Count == 1);
            Assert.True(model.TotalItems == 1);
            Assert.Contains(model.Items, x => x.Nome.Equals(SeedData.TestPerfil2.Nome));
        }

        [Fact]
        public async Task ListPerfilWithoutFilter()
        {
            Util.SetJwtToken(_client, PerfilUsuario.AdministradorPortal);

            var queryParams = new Dictionary<string, string>
            {
                { "ativo", "true" },
                { "filter", "" },
                { "page", "1" },
                { "size", "2" }
            };

            var response = await _client.GetAsync(Util.GetPathWithVersion(ListPerfilRequest.Route, 1, queryParams));
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var model = Util.LoadObject<PagedResponse<ListPerfilResponse>>(response);

            Assert.NotNull(model);
            Assert.True(model.Items.Count == 2);
            Assert.True(model.TotalItems == 3);
            Assert.Contains(model.Items, x => x.Nome.Equals(SeedData.TestPerfil1.Nome));
            Assert.Contains(model.Items, x => x.Nome.Equals(SeedData.TestPerfil3.Nome));
        }
    }
}
