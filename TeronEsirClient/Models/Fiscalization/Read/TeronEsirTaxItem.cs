namespace TeronEsirClient.Models.Fiscalization.Read
{
    public sealed class TeronEsirTaxItem
    {
        public string Label { get; private set; }
        public string CategoryName { get; private set; }
        public int CategoryType { get; private set; }
        public decimal Rate { get; private set; }
        public decimal Amount { get; private set; }
    }
}
