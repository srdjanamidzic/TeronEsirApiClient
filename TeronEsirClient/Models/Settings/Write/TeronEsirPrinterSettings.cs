using Newtonsoft.Json;
using TeronEsirClient.Enums;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Settings.Write
{
    public sealed class TeronEsirPrinterSettings
    {
        public string PrinterName { get; set; }
        public PrinterType PrinterType { get; set; }
        public ReceiptLayout ReceiptLayout { get; set; }
        public int ReceiptWidth { get; set; }
        public int ReceiptFontSizeNormal { get; set; }
        public int ReceiptFontSizeLarge { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] ReceiptHeaderImage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] ReceiptHeaderTextLines { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] ReceiptFooterImage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] ReceiptFooterTextLines { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? QrCodeSize { get; set; }
        public int ReceiptFeedLinesBegin { get; set; }
        public int ReceiptFeedLinesEnd { get; set; }
        public ReceiptCutPaper ReceiptCutPaper { get; set; }
        public ReceiptOpenCashDrawer ReceiptOpenCashDrawer { get; set; }
    }
}
