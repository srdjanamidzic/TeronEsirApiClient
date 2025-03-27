namespace TeronEsirClient.Models.Miscellaneous.Read
{
    public sealed class TeronEsirCompanySearchResult
    {
        public string Name { get; private set; }
        public string City { get; private set; }
        public string TaxId { get; private set; }
        public string RegistrationId { get; private set; }
        public string BudgetId { get; private set; }
    }
}
