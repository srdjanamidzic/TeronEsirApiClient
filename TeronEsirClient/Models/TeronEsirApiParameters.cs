namespace TeronEsirClient.Models
{
    public sealed class TeronEsirApiParameters
    {
        public TeronEsirApiParameters(string baseAddress, string bearerToken)
        {
            BaseAddress = baseAddress;
            BearerToken = bearerToken;
        }

        public string BaseAddress { get; private set; }
        public string BearerToken { get; private set; }
    }
}
