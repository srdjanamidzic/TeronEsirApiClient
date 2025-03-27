using Newtonsoft.Json;
using TeronEsirClient.Enums;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.CashRegister.Read
{
    public sealed class TeronEsirCashRegisterSummaryPaymentType
    {
        public decimal Amount { get; private set; }

        [JsonConverter(typeof(EnumStringConverter<PaymentType>))]
        public PaymentType PaymentType { get; private set; }
    }
}
