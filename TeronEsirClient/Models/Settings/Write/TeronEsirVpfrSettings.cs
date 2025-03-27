namespace TeronEsirClient.Models.Settings.Write
{
    public sealed class TeronEsirVpfrSettings
    {
        public bool VpfrEnabled { get; } = true;
        public string VpfrClientCertificateBase64 { get; set; }
        public string VpfrClientCertificatePassword { get; set; }
        public string VpfrPac { get; set; }
    }
}
