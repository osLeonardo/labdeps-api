using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel.Extensions;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;

namespace PortalTransparenciaDeps.FunctionalTests
{
    public static class Util
    {
        public static string GerarToken(PerfilUsuario perfil)
        {
            var claim = new Claim(ClaimTypes.Role, perfil.Description());
            return MockJwtTokens.GenerateJwtToken(new List<Claim> { claim });
        }

        public static string GetPathWithVersion(string route, int version)
        {
            return $"api/v{version}/{route}";
        }

        public static string GetPathWithVersion(string route, int version, Dictionary<string, string> queryParams)
        {
            var path = $"api/v{version}/{route}?";
            foreach (var item in queryParams)
            {
                path += $"{item.Key}={item.Value}";
                path += "&";
            }

            return path;
        }

        public static void SetJwtToken(HttpClient client, PerfilUsuario perfil)
        {
            var token = GerarToken(perfil);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public static StringContent GetJson(object data)
        {
            return new StringContent(data.ToJson(), Encoding.UTF8, "application/json");
        }

        public static T LoadObject<T>(HttpResponseMessage response)
        {
            var stringResponse = response.Content.ReadAsStringAsync().Result;
            return stringResponse.FromJson<T>();
        }
    }
}
