using TeronEsirClient.Enums.Utils;

namespace TeronEsirClient.Enums
{
    public enum InvoiceType
    {
        [StringValue("Normal")]
        Normal,

        [StringValue("Proforma")]
        Proforma,

        [StringValue("Copy")]
        Copy,

        [StringValue("Training")]
        Training,

        [StringValue("Advance")]
        Advance,
    }
}
