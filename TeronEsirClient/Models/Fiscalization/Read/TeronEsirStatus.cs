using Newtonsoft.Json;
using System;
using TeronEsirClient.Enums;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Fiscalization.Read
{
    public sealed class TeronEsirStatus
    {
        public bool IsPinRequired { get; private set; }
        public bool AuditRequired { get; private set; }

        public DateTime SdcDateTime { get; private set; }
        public string LastInvoiceNumber { get; private set; }

        public string ProtocolVersion { get; private set; }
        public string SecureElementVersion { get; private set; }
        public string HardwareVersion { get; private set; }
        public string SoftwareVersion { get; private set; }

        public string DeviceSerialNumber { get; private set; }
        public string Make { get; private set; }
        public string Model { get; private set; }

        public string[] Mssc { get; private set; } = Array.Empty<string>();

        [JsonProperty(ItemConverterType = typeof(EnumStringConverter<LpfrStatus>))]
        public LpfrStatus[] Gsc { get; private set; } = Array.Empty<LpfrStatus>();

        public string[] SupportedLanguages { get; private set; } = Array.Empty<string>();

        public string Uid { get; private set; }
        public string TaxCoreApi { get; private set; }

        public TeronEsirTaxRates CurrentTaxRates { get; private set; }
        public TeronEsirTaxRates[] AllTaxRates { get; private set; } = Array.Empty<TeronEsirTaxRates>();
    }
}
