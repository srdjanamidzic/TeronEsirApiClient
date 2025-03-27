using TeronEsirClient.Enums.Utils;

namespace TeronEsirClient.Enums
{
    public enum TransactionType
    {
        [StringValue("Sale")]
        Sale,

        [StringValue("Refund")]
        Refund,
    }
}
