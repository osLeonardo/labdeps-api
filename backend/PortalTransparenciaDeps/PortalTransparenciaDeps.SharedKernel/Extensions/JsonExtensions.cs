using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PortalTransparenciaDeps.SharedKernel.Extensions
{
    public static class JsonExtensions
    {
        private static readonly JsonSerializerSettings _jsonOptions = new()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        public static T FromJson<T>(this string json) =>
            JsonConvert.DeserializeObject<T>(json);

        public static string ToJson<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj, _jsonOptions);
        }
    }
}