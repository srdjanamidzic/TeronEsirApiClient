using JsonNet.ContractResolvers;
using Newtonsoft.Json;

namespace TeronEsirClient.Json
{
    internal class GlobalJsonSerializerSettings
    {
        internal static JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            ContractResolver = new PrivateSetterCamelCasePropertyNamesContractResolver(),
        };
    }
}
