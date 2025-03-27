using System.Threading.Tasks;
using TeronEsirClient.Models;
using System;
using TeronEsirClient.Models.Settings.Write;
using TeronEsirClient.Models.Settings.Read;

namespace TeronEsirClient.Client
{
    public partial class TeronEsirApiClient
    {
        public async Task<TeronEsirResult> ConfigureEFakturaAsync(string apiKey)
        {
            return await ConfigureEFakturaAsync(GetParametersFromHttpClient(), apiKey);
        }

        public async Task<TeronEsirResult> ConfigureEFakturaAsync(TeronEsirApiParameters apiParameters, string apiKey)
        {
            var settings = new TeronEsirEFakturaSettings { EFakturaApiKey = apiKey };

            var requestMessage = CreatePostRequestMessage(apiParameters, "settings", settings);
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult.FromHttpResponseAsync(response);
        }

        public async Task<TeronEsirResult> ConfigureLpfrAsync(string url)
        {
            return await ConfigureLpfrAsync(GetParametersFromHttpClient(), url);
        }

        public async Task<TeronEsirResult> ConfigureLpfrAsync(TeronEsirApiParameters apiParameters, string url)
        {
            var settings = new TeronEsirLpfrSettings
            {
                VpfrEnabled = false,
                LpfrUrl = url
            };

            var requestMessage = CreatePostRequestMessage(apiParameters, "settings", settings);
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult.FromHttpResponseAsync(response);
        }

        public async Task<TeronEsirResult> ConfigurePrinterAsync(TeronEsirPrinterSettings printerSettings)
        {
            return await ConfigurePrinterAsync(GetParametersFromHttpClient(), printerSettings);
        }

        public async Task<TeronEsirResult> ConfigurePrinterAsync(TeronEsirApiParameters apiParameters, TeronEsirPrinterSettings printerSettings)
        {
            var requestMessage = CreatePostRequestMessage(apiParameters, "settings", printerSettings);
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult.FromHttpResponseAsync(response);
        }

        public async Task<TeronEsirResult> ConfigureSecurityAsync(TeronEsirSecuritySettings securitySettings)
        {
            return await ConfigureSecurityAsync(GetParametersFromHttpClient(), securitySettings);
        }

        public async Task<TeronEsirResult> ConfigureSecurityAsync(TeronEsirApiParameters apiParameters, TeronEsirSecuritySettings securitySettings)
        {
            var requestMessage = CreatePostRequestMessage(apiParameters, "settings", securitySettings);
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult.FromHttpResponseAsync(response);
        }

        public async Task<TeronEsirResult> ConfigureVpfrAsync(byte[] clientCertificate, string clientCertificatePassword, string pac)
        {
            return await ConfigureVpfrAsync(GetParametersFromHttpClient(), clientCertificate, clientCertificatePassword, pac);
        }

        public async Task<TeronEsirResult> ConfigureVpfrAsync(TeronEsirApiParameters apiParameters, byte[] clientCertificate, string clientCertificatePassword, string pac)
        {
            var settings = new TeronEsirVpfrSettings
            {
                VpfrClientCertificateBase64 = Convert.ToBase64String(clientCertificate),
                VpfrClientCertificatePassword = clientCertificatePassword,
                VpfrPac = pac
            };
            
            var requestMessage = CreatePostRequestMessage(apiParameters, "settings", settings);
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult.FromHttpResponseAsync(response);
        }

        public async Task<TeronEsirResult<TeronEsirSettings>> GetCurrentConfigurationAsync()
        {
            return await GetCurrentConfigurationAsync(GetParametersFromHttpClient());
        }

        public async Task<TeronEsirResult<TeronEsirSettings>> GetCurrentConfigurationAsync(TeronEsirApiParameters apiParameters)
        {
            var requestMessage = CreateGetRequestMessage(apiParameters, "settings");
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult<TeronEsirSettings>.FromHttpResponseAsync(response);
        }

        public async Task<TeronEsirResult> SetRunUiAsync(bool value)
        {
            return await SetRunUiAsync(GetParametersFromHttpClient(), value);
        }

        public async Task<TeronEsirResult> SetRunUiAsync(TeronEsirApiParameters apiParameters, bool value)
        {
            var settings = new TeronEsirMiscellaneousSettings { RunUi = value };
            var requestMessage = CreatePostRequestMessage(apiParameters, "settings", settings);
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult.FromHttpResponseAsync(response);
        }
    }
}
