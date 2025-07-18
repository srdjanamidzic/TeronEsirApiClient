﻿using Newtonsoft.Json;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models.CashRegister.Write
{
    public sealed class TeronEsirCashRegisterWithdraw
    {
        [JsonConverter(typeof(MoneyDecimalConverter))]
        public decimal Amount { get; set; }
    }
}
