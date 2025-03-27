using TeronEsirClient.Enums.Utils;

namespace TeronEsirClient.Enums
{
    public enum LpfrStatus
    {
        [StringValue("0000")]
        AllOk,
        
        [StringValue("0100")]
        PinOk,

        [StringValue("0210")]
        InternetAvailable,

        [StringValue("0220")]
        InternetUnavailable,

        [StringValue("1100")]
        Storage90PercentFull,

        [StringValue("1300")]
        SmartCardNotPresent,

        [StringValue("1400")]
        AuditRequired,

        [StringValue("1500")]
        PinCodeRequired,

        [StringValue("1999")]
        UndefinedWarning,

        [StringValue("2100")]
        PinNotOk,

        [StringValue("2110")]
        CardLocked,

        [StringValue("2210")]
        SecureElementLocked,

        [StringValue("2220")]
        SecureElementCommunicationFailed,

        [StringValue("2230")]
        SecureElementProtocolMismatch,

        [StringValue("2310")]
        InvalidTaxLabels,

        [StringValue("2400")]
        NotConfigured,

        [StringValue("2800")]
        FieldRequired,

        [StringValue("2801")]
        FieldValueTooLong,

        [StringValue("2802")]
        FieldValueTooShort,

        [StringValue("2803")]
        InvalidFieldLength,

        [StringValue("2804")]
        FieldOutOfRange,

        [StringValue("2805")]
        InvalidFieldValue,

        [StringValue("2806")]
        InvalidDataFormat,

        [StringValue("2807")]
        ListTooShort,

        [StringValue("2808")]
        ListTooLong,
    }
}
