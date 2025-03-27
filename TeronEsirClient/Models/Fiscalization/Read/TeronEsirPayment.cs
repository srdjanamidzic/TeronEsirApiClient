using Newtonsoft.Json;
using TeronEsirClient.Enums;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Fiscalization.Read
{
    public sealed class TeronEsirPayment
    {
        [JsonConverter(typeof(EnumStringConverter<PaymentType>))]
        public PaymentType PaymentType { get; private set; }
        public decimal Amount { get; private set; }
    }
}
