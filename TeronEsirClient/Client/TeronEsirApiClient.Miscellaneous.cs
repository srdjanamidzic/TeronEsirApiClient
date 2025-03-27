using System.Threading.Tasks;
using TeronEsirClient.Models;
using TeronEsirClient.Models.Miscellaneous.Write;
using TeronEsirClient.Models.Miscellaneous.Read;

namespace TeronEsirClient.Client
{
    public partial class TeronEsirApiClient
    {
        public async Task<TeronEsirResult<TeronEsirCompanySearchResult[]>> SearchCompaniesAsync(TeronEsirCompanySearchParameters searchParameters)
        {
            return await SearchCompaniesAsync(GetParametersFromHttpClient(), searchParameters);
        }

        public async Task<TeronEsirResult<TeronEsirCompanySearchResult[]>> SearchCompaniesAsync(TeronEsirApiParameters apiParameters, TeronEsirCompanySearchParameters searchParameters)
        {
            var requestMessage = CreatePostRequestMessage(apiParameters, "companies", searchParameters);
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult<TeronEsirCompanySearchResult[]>.FromHttpResponseAsync(response);
        }

        public async Task<TeronEsirResult> DirectPrintAsync(TeronEsirDirectPrintParameters directPrintParameters)
        {
            return await DirectPrintAsync(GetParametersFromHttpClient(), directPrintParameters);
        }

        public async Task<TeronEsirResult> DirectPrintAsync(TeronEsirApiParameters apiParameters, TeronEsirDirectPrintParameters directPrintParameters)
        {
            var requestMessage = CreatePostRequestMessage(apiParameters, "device/print", directPrintParameters);
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult.FromHttpResponseAsync(response);
        }

        public async Task<TeronEsirResult> ReleasePrinterAsync()
        {
            return await ReleasePrinterAsync(GetParametersFromHttpClient());
        }

        public async Task<TeronEsirResult> ReleasePrinterAsync(TeronEsirApiParameters apiParameters)
        {
            var requestMessage = CreateDeleteRequestMessage(apiParameters, "device/print");
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult.FromHttpResponseAsync(response);
        }

        public async Task<TeronEsirResult<TeronEsirSecureElementCertificateOwner>> GetSecureElementCertificateOwnerAsync()
        {
            return await GetSecureElementCertificateOwnerAsync(GetParametersFromHttpClient());
        }

        public async Task<TeronEsirResult<TeronEsirSecureElementCertificateOwner>> GetSecureElementCertificateOwnerAsync(TeronEsirApiParameters apiParameters)
        {
            var requestMessage = CreateGetRequestMessage(apiParameters, "certificate");
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult<TeronEsirSecureElementCertificateOwner>.FromHttpResponseAsync(response);
        }
    }
}
