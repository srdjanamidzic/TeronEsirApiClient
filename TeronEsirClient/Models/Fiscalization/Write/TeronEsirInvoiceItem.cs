using Newtonsoft.Json;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Fiscalization.Write
{
    public sealed class TeronEsirInvoiceItem
    {
        public string Name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Gtin { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Plu { get; set; }
        public string[] Labels { get; set; }

        [JsonConverter(typeof(MoneyDecimalConverter))]
        public decimal UnitPrice { get; set; }

        [JsonConverter(typeof(QuantityDecimalConverter))]
        public decimal Quantity { get; set; }

        [JsonConverter(typeof(MoneyDecimalConverter))]
        public decimal TotalAmount { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(MoneyDecimalConverter))]
        public decimal? Discount { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(MoneyDecimalConverter))]
        public decimal? DiscountAmount { get; set; }
    }
}
