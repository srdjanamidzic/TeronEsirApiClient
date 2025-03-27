using Newtonsoft.Json;
using System;
using TeronEsirClient.Enums;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Reports.Write
{
    public sealed class TeronEsirReportFilterParameters
    {
        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public bool Print { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string File { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(EnumStringConverter<ReportFormat>))]
        public ReportFormat? Format { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Cashier { get; set; }

        public string Language { get; set; }
    }
}
