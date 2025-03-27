using Newtonsoft.Json;
using System;
using TeronEsirClient.Enums;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Fiscalization.Read
{
    public sealed class TeronEsirInvoiceRequest
    {
        [JsonConverter(typeof(EnumStringConverter<InvoiceType>))]
        public InvoiceType InvoiceType { get; private set; }

        [JsonConverter(typeof(EnumStringConverter<TransactionType>))]
        public TransactionType TransactionType { get; private set; }
        public TeronEsirPayment[] Payment { get; private set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateAndTimeOfIssue { get; private set; }
        public string Cashier { get; private set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerId { get; private set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerCostCenterId { get; private set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ReferentDocumentNumber { get; private set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ReferentDocumentDT { get; private set; }
        public TeronEsirInvoiceItem[] Items { get; private set; }
        public string InvoiceNumber { get; private set; }
        public TeronEsirInvoiceRequestOptions Options { get; private set; }
    }
}
