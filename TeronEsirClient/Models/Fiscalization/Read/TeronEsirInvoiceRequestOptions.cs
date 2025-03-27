namespace TeronEsirClient.Models.Fiscalization.Read
{
    public sealed class TeronEsirInvoiceRequestOptions
    {
        public int OmitQRCodeGen { get; private set; }
        public string OmitTextualRepresentation { get; private set; }
    }
}
