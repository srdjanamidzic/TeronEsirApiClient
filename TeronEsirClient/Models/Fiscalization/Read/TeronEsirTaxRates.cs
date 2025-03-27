using System;

namespace TeronEsirClient.Models.Fiscalization.Read
{
    public sealed class TeronEsirTaxRates
    {
        public DateTime ValidFrom { get; private set; }
        public int GroupId { get; private set; }
        public TeronEsirTaxCategory[] TaxCategories { get; private set; } = Array.Empty<TeronEsirTaxCategory>();
    }
}
