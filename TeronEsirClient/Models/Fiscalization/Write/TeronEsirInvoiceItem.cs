using Newtonsoft.Json;

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
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DiscountAmount { get; set; }
    }
}
