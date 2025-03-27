using Newtonsoft.Json;
using System;
using TeronEsirClient.Enums;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Settings.Read
{
    public sealed class TeronEsirSettings
    {
        public string[] Languages { get; private set; } = Array.Empty<string>();
        public string Language { get; private set; }
        public string ApplicationLanguage { get; private set; }

        public string LpfrUrl { get; private set; }

        public bool VpfrEnabled { get; private set; }

        [JsonProperty("vpfrClientCertificateBase64")]
        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] VpfrClientCerificate { get; private set; }
        public string VpfrClientCerificatePassword { get; private set; }
        public string VpfrPac { get; private set; }
        public string VpfrCerificateBusinessName { get; private set; }
        public string VpfrCerificateShopName { get; private set; }
        public string VpfrCerificateAddress { get; private set; }
        public string VpfrCerificateCity { get; private set; }
        public string VpfrCerificateCountry { get; private set; }
        public string VpfrCerificateSerialNumber { get; private set; }
        public string VpfrUrl { get; private set; }

        public bool RunUi { get; private set; }
        public string PosName { get; private set; }

        public bool AuthorizeRemoteClients { get; private set; }
        public bool AuthorizeLocalClients { get; private set; }
        public string ApiKey { get; private set; }

        public string PrinterName { get; private set; }

        public string[] AvailablePrinters { get; private set; }

        [JsonProperty(ItemConverterType = typeof(EnumStringConverter<PrinterType>))]
        public PrinterType[] AvailablePrinterTypes { get; private set; }

        [JsonConverter(typeof(EnumStringConverter<PrinterType>))]
        public PrinterType PrinterType { get; private set; }
        public int? PrinterDpi { get; private set; }
        public int? PaperWidth { get; private set; }
        public int? PaperHeight { get; private set; }
        public int? PaperMargin { get; private set; }

        [JsonConverter(typeof(EnumStringConverter<ReceiptLayout>))]
        public ReceiptLayout ReceiptLayout { get; private set; }

        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] ReceiptHeaderImage { get; private set; }
        public string[] ReceiptHeaderTextLines { get; private set; } = Array.Empty<string>();

        [JsonConverter(typeof(ByteArrayBase64Converter))]
        public byte[] ReceiptFooterImage { get; private set; }
        public string[] ReceiptFooterTextLines { get; private set; } = Array.Empty<string>();
        public string ReceiptDiscountText { get; private set; }
        public int? ReceiptSplitMaxHeight { get; private set; }
        public int ReceiptWidth { get; private set; }
        public int ReceiptFontSizeNormal { get; private set; }
        public int ReceiptFontSizeLarge { get; private set; }
        public decimal ReceiptLetterSpacingNormal { get; private set; }
        public decimal ReceiptLetterSpacingCondensed { get; private set; }
        public int ReceiptFeedLinesBegin { get; private set; }
        public int ReceiptFeedLinesEnd { get; private set; }
        public int ReceiptsDelay { get; private set; }

        [JsonConverter(typeof(EnumStringConverter<ReceiptCutPaper>))]
        public ReceiptCutPaper ReceiptCutPaper { get; private set; }

        [JsonConverter(typeof(EnumStringConverter<ReceiptOpenCashDrawer>))]
        public ReceiptOpenCashDrawer ReceiptOpenCashDrawer { get; private set; }
        public string ReceiptCustomCommandBegin { get; private set; }
        public string ReceiptCustomCommandEnd { get; private set; }
        public int? QrCodeSize { get; private set; }

        // Represented as int in the JSON, only in this model
        public PaymentType[] AllowedPaymentTypes { get; private set; } = Array.Empty<PaymentType>();

        public string ScaleDeviceName { get; private set; }
        public string ScaleProtocol { get; private set; }
        public int? ScaleDeviceRs232BaudRate { get; private set; }
        public int? ScaleDeviceRs232DataBits { get; private set; }
        public int? ScaleDeviceRs232Parity { get; private set; }
        public int? ScaleDeviceRs232StopBits { get; private set; }
        public int? ScaleDeviceRs232HardwareFlowControl { get; private set; }
        public string[] AvailableScaleDevices { get; private set; } = Array.Empty<string>();
        public string[] AvailableScaleProtocols { get; private set; } = Array.Empty<string>();

        public bool DisplayEnabled { get; private set; }
        public string DisplayHandler { get; private set; }
        public string DisplayDeviceName { get; private set; }
        public string DisplayProtocol { get; private set; }
        public int? DisplayDeviceRs232BaudRate { get; private set; }
        public int? DisplayDeviceRs232DataBits { get; private set; }
        public int? DisplayDeviceRs232Parity { get; private set; }
        public int? DisplayDeviceRs232StopBits { get; private set; }
        public int? DisplayDeviceRs232HardwareFlowControl { get; private set; }
        public int? DisplayTextCols { get; private set; }
        public int? DisplayTextRows { get; private set; }
        public string DisplayTextCodePage { get; private set; }
        public string[] AvailableDisplayDevices { get; private set; } = Array.Empty<string>();

        public string EftPosDeviceName { get; private set; }
        public string EftPosProtocol { get; private set; }
        public int? EftPosDeviceRs232BaudRate { get; private set; }
        public int? EftPosDeviceRs232DataBits { get; private set; }
        public int? EftPosDeviceRs232Parity { get; private set; }
        public int? EftPosDeviceRs232StopBits { get; private set; }
        public int? EftPosDeviceRs232HardwareFlowControl { get; private set; }
        public string EftPosCredentials { get; private set; }
        public string[] AvailableEftPosDevices { get; private set; } = Array.Empty<string>();
        public string[] AvailableEftPosProtocols { get; private set; } = Array.Empty<string>();

        public string EFakturaApiKey { get; private set; }
        public bool EFakturaTest { get; private set; }
        public string EFakturaCompanyName { get; private set; }
        public string EFakturaCompanyAddress { get; private set; }
        public string EFakturaCompanyCity { get; private set; }
        public string EFakturaCompanyEMail { get; private set; }
        public string EFakturaCompanyPhone { get; private set; }
        public string EFakturaCompanyBankAccount { get; private set; }
        public string EFakturaCompanyRegistrationId { get; private set; }
        public string EFakturaCompanyTaxId { get; private set; }
        public bool SyncReceipts { get; private set; }

        public Lpfr Lpfr { get; private set; }

        public bool IssueCopyOnRefund { get; private set; }
        
        public string CustomTabName { get; private set; }
        public string CustomTabUrl { get; private set; }
    }

    public sealed class Lpfr
    {
        public string[] AvailableSmartCardReaders { get; private set; } = Array.Empty<string>();
        public bool CanHaveMultipleSmartCardReaders { get; private set; }
        public string SmartCardReaderName { get; private set; }
        public string ExternalStorageFolder { get; private set; }
        public string[] Languages { get; private set; } = Array.Empty<string>();
        public bool AuthorizeRemoteClients { get; private set; }
        public bool AuthorizeLocalClients { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string ApiKey { get; private set; }
    }
}
