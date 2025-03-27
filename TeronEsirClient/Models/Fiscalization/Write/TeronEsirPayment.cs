using Newtonsoft.Json;
using TeronEsirClient.Enums;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Fiscalization.Write
{
    public sealed class TeronEsirPayment
    {
        [JsonConverter(typeof(EnumStringConverter<PaymentType>))]
        public PaymentType PaymentType { get; set; }
        public decimal Amount { get; set; }
    }
}
