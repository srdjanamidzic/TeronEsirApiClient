using Newtonsoft.Json;
using System;
using TeronEsirClient.Enums;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Fiscalization.Write
{
    public sealed class TeronEsirInvoiceSearchParameters
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FromDate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ToDate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(MoneyDecimalConverter))]
        public decimal? AmountFrom { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(MoneyDecimalConverter))]
        public decimal? AmountTo { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(EnumStringConverter<InvoiceType>))]
        public InvoiceType[] InvoiceTypes { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(EnumStringConverter<TransactionType>))]
        public TransactionType[] TransactionTypes { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(EnumStringConverter<PaymentType>))]
        public PaymentType[] PaymentTypes { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ReferentDocumentNumber { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerCostCenterId { get; set; }
    }
}
