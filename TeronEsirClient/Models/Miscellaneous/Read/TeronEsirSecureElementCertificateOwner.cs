namespace TeronEsirClient.Models.Miscellaneous.Read
{
    public sealed class TeronEsirSecureElementCertificateOwner
    {
        public string Name { get; private set; }
        public string Location { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string SerialNumber { get; private set; }
        public string Tin { get; private set; }
        public string TaxCoreApiBaseUrl { get; private set; }
    }
}
