namespace TeronEsirClient.Models
{
    public sealed class TeronEsirError
    {
        public string Details { get; private set; }
        public string Message { get; private set; }
        public int StatusCode { get; private set; }
    }
}
