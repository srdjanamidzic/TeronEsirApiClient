using Newtonsoft.Json;
using System;
using TeronEsirClient.Enums;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Fiscalization.Write
{
    public sealed class TeronEsirInvoice
    {
        public TeronEsirInvoiceRequest InvoiceRequest { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Print { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? RenderReceiptImage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(EnumStringConverter<ReceiptLayout>))]
        public ReceiptLayout? ReceiptLayout { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(EnumStringConverter<ReceiptImageFormat>))]
        public ReceiptImageFormat? ReceiptImageFormat { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string PrinterName { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(EnumStringConverter<PrinterType>))]
        public PrinterType? PrinterType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] ReceiptHeaderImage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] ReceiptFooterImage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] ReceiptHeaderTextLines { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] ReceiptFooterTextLines { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AdvancePaid { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AdvanceTax { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TeronEsirAdvancePayment[] AdvancePayment { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TeronEsirInvoiceItem[] OriginalItems { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AdvanceLastInvoiceNumber { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AdvanceLastInvoiceDateTime { get; set; }
    }
}
