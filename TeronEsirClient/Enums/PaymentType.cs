using TeronEsirClient.Enums.Utils;

namespace TeronEsirClient.Enums
{
    public enum PaymentType
    {
        [StringValue("Cash")]
        Cash = 0,

        [StringValue("Card")]
        Card = 1,

        [StringValue("Check")]
        Check = 2,

        [StringValue("WireTransfer")]
        WireTransfer = 3,

        [StringValue("Voucher")]
        Voucher = 4,

        [StringValue("MobileMoney")]
        MobileMoney = 5,

        [StringValue("Other")]
        Other = 6
    }
}
