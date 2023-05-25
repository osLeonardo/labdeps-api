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
    [Collection("Sequential")]
    public class PerfilUpdateOrdenacao : IClassFixture<CustomWebApplicationFactory<WebMarker>>
    {
        private readonly HttpClient _client;

        public PerfilUpdateOrdenacao(CustomWebApplicationFactory<WebMarker> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task UpdateOrdenacaoPerfis()
        {
            Util.SetJwtToken(_client, PerfilUsuario.AdministradorPortal);
            var request = new UpdateOrdenacaoPerfilRequest
            {
                Ordenacao = new List<OrdenacaoPerfil>
                {
                    new OrdenacaoPerfil { Id = 1, Ordem = 1 },
                    new OrdenacaoPerfil { Id = 2, Ordem = 3 },
                    new OrdenacaoPerfil { Id = 3, Ordem = 2 }
                }
            };

            var response = await _client.PatchAsync(Util.GetPathWithVersion(UpdateOrdenacaoPerfilRequest.Route, 1), Util.GetJson(request));
            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);

            response = await _client.GetAsync(Util.GetPathWithVersion("perfil/ordenados", 1));
            var model = Util.LoadObject<List<GetAllPerfilWithOrderResponse>>(response);

            Assert.Equal(1, model.First().Id);
            Assert.Equal(SeedData.TestPerfil1.Nome, model.First().Nome);

            Assert.Equal(2, model.Last().Id);
            Assert.Equal(SeedData.TestPerfil2.Nome, model.Last().Nome);
        }
    }
}
