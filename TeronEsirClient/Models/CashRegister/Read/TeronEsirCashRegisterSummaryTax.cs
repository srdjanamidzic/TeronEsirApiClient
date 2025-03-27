namespace TeronEsirClient.Models.CashRegister.Read
{
    public sealed class TeronEsirCashRegisterSummaryTax
    {
        public decimal Amount { get; private set; }
        public string Category { get; private set; }
        public string Label { get; private set; }
        public decimal Rate { get; private set; }
    }
}
