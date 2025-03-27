using Newtonsoft.Json;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Miscellaneous.Write
{
    public sealed class TeronEsirDirectPrintParameters
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] TextLines { get; set; }

        [JsonProperty("imagePngBase64", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] ImagePng { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string RawBase64 { get; set; }
    }
}
