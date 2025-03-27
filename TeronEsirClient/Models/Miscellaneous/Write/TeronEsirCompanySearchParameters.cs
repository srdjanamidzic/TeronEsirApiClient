using Newtonsoft.Json;

namespace TeronEsirClient.Models.Miscellaneous.Write
{
    public sealed class TeronEsirCompanySearchParameters
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string TaxId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string RegistrationId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BudgetId { get; set; }
    }
}
