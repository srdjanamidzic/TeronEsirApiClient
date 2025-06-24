using Newtonsoft.Json;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.CashRegister.Write
{
    public sealed class TeronEsirCashRegisterDeposit
    {
        [JsonConverter(typeof(MoneyDecimalConverter))]
        public decimal Amount { get; set; }
    }
}
