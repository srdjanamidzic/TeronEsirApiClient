using Newtonsoft.Json;
using TeronEsirClient.Enums;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Fiscalization.Write
{
    public sealed class TeronEsirFinalInvoice
    {
        public string AdvanceLastInvoiceNumber { get; set; }
        public TeronEsirPayment[] Payment { get; set; }
        public bool Print { get; set; }
        public string Email { get; set; }
        public string PrinterName { get; set; }

        [JsonConverter(typeof(EnumStringConverter<PrinterType>))]
        public PrinterType PrinterType { get; set; }

        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] ReceiptHeaderImage { get; set; }

        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] ReceiptFooterImage { get; set; }
        public string[] ReceiptHeaderTextLines { get; set; }
        public string[] ReceiptFooterTextLines { get; set; }
    }
}
