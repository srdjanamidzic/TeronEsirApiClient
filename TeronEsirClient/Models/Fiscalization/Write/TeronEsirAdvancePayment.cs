using Newtonsoft.Json;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.Fiscalization.Write
{
    public sealed class TeronEsirAdvancePayment
    {
        [JsonConverter(typeof(MoneyDecimalConverter))]
        public decimal Amount { get; set; }
        public string Label { get; set; }
    }
}
