namespace TeronEsirClient.Models.CashRegister.Read
{
    public sealed class TeronEsirCashRegisterSummaryArticleAdvance
    {
        public decimal Amount { get; private set; }
        public string ArticleName { get; private set; }
        public string Gtin { get; private set; }
        public string Plu { get; private set; }
        public string TaxLabel { get; private set; }
        public decimal Quantity { get; private set; }
    }
}
