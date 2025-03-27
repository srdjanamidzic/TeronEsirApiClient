namespace TeronEsirClient.Models.Fiscalization.Read
{
    public sealed class TeronEsirTaxCategory
    {
        public string Name { get; private set; }
        public int OrderId { get; private set; }
        public int CategoryType { get; private set; }
        public TeronEsirTaxRate[] TaxRates { get; private set; }
    }
}
