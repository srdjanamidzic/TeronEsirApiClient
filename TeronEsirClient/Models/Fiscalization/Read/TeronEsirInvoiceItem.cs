using Newtonsoft.Json;
using System;

namespace TeronEsirClient.Models.Fiscalization.Read
{
    public sealed class TeronEsirInvoiceItem
    {
        public string Name { get; private set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Gtin { get; private set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Plu { get; private set; }
        public string[] Labels { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal TotalAmount { get; private set; }
        public decimal? Discount { get; private set; }
        public decimal? DiscountAmount { get; private set; }
        public Guid? ArticleUuid { get; private set; }
    }
}
