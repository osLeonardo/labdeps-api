using PortalTransparenciaDeps.SharedKernel;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace PortalTransparenciaDeps.FunctionalTests.ApiEndpoints
{
    [Collection("Sequential")]
    public class PingPing : IClassFixture<CustomWebApplicationFactory<WebMarker>>
    {
        private const string ROUTE = "ping";
        private readonly HttpClient _client;

        public PingPing(CustomWebApplicationFactory<WebMarker> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task CanGetResponsePing()
        {
            var response = await _client.GetAsync(Util.GetPathWithVersion(ROUTE, 1));
            var stringResponse = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("Server is alive and version requested is 1", stringResponse);
        }

        [Fact]
        public async Task CanGetResponsePingV2()
        {
            var response = await _client.GetAsync(Util.GetPathWithVersion(ROUTE, 2));
            var stringResponse = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("Server is alive and version requested is 2", stringResponse);
        }
    }
}
