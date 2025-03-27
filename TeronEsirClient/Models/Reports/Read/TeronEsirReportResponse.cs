using Newtonsoft.Json;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Reports.Read
{
    public sealed class TeronEsirReportResponse
    {
        public string ReportName { get; set; }

        public string FileName { get; set; }

        [JsonProperty("reportPdfBase64", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] ReportPdf { get; private set; }

        [JsonProperty("reportXlsxBase64", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] ReportXlsx { get; private set; }

        [JsonProperty("reportImagePngBase64", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] ReportImagePng { get; private set; }

        public string ReportCsv { get; private set; }

        public string ReportHtml { get; private set; }

    }
}
