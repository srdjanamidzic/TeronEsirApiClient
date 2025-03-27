using Newtonsoft.Json;
using System;
using TeronEsirClient.Enums;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Fiscalization.Write
{
    public sealed class TeronEsirInvoiceRequest
    {
        [JsonConverter(typeof(EnumStringConverter<InvoiceType>))]
        public InvoiceType InvoiceType { get; set; }

        [JsonConverter(typeof(EnumStringConverter<TransactionType>))]
        public TransactionType TransactionType { get; set; }
        public TeronEsirPayment[] Payment { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateAndTimeOfIssue { get; set; }
        public string Cashier { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerCostCenterId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ReferentDocumentNumber { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ReferentDocumentDT { get; set; }
        public TeronEsirInvoiceItem[] Items { get; set; }
    }
}
