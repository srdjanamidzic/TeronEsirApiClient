namespace TeronEsirClient.Models.Settings.Write
{
    public sealed class TeronEsirSecuritySettings
    {
        public bool AuthorizeRemoteClients { get; set; }
        public bool AuthorizeLocalClients { get; set; }
        public string ApiKey { get; set; }
        public string WebserverAddress { get; set; }
    }
}
