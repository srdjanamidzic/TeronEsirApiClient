using Newtonsoft.Json;
using System;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Fiscalization.Read
{
    public sealed class TeronEsirInvoiceResponse
    {
        public string RequestedBy { get; private set; }
        public string SignedBy { get; private set; }
        public DateTime SdcDateTime { get; private set; }
        public string InvoiceCounter { get; private set; }
        public string InvoiceCounterExtension { get; private set; }
        public string InvoiceNumber { get; private set; }
        public string VerificationUrl { get; private set; }

        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] VerificationQRCode { get; private set; }
        public string Journal { get; private set; }
        public int TotalCounter { get; private set; }
        public int TransactionTypeCounter { get; private set; }
        public decimal TotalAmount { get; private set; }
        public string EncryptedInternalData { get; private set; }
        public string Signature { get; private set; }
        public TeronEsirTaxItem[] TaxItems { get; private set; } = Array.Empty<TeronEsirTaxItem>();
        public string BusinessName { get; private set; }
        public string LocationName { get; private set; }
        public string Address { get; private set; }
        public string Tin { get; private set; }
        public string District { get; private set; }
        public int TaxGroupRevision { get; private set; }
        public string Mrc { get; private set; }
        public string Messages { get; private set; }

        [JsonProperty("invoiceImagePngBase64")]
        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] InvoiceImagePng { get; private set; }

        [JsonProperty("invoiceImagePdfBase64")]
        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] InvoiceImagePdf { get; private set; }
        public string InvoiceImageHtml { get; private set; }
    }
}
