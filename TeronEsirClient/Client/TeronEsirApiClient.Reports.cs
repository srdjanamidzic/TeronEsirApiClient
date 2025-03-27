using System.Threading.Tasks;
using TeronEsirClient.Models;
using TeronEsirClient.Models.Reports.Write;
using TeronEsirClient.Models.Reports.Read;

namespace TeronEsirClient.Client
{
    public partial class TeronEsirApiClient
    {
        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetSummaryReportAsync(TeronEsirReportFilterParameters filterParameters)
        {
            return await GetSummaryReportAsync(GetParametersFromHttpClient(), filterParameters);
        }
        
        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetSummaryReportAsync(TeronEsirApiParameters apiParameters, TeronEsirReportFilterParameters filterParameters)
        {
            return await GetReportAsync("summary", apiParameters, filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetSummaryByTaxReportAsync(TeronEsirReportFilterParameters filterParameters)
        {
            return await GetSummaryByTaxReportAsync(GetParametersFromHttpClient(), filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetSummaryByTaxReportAsync(TeronEsirApiParameters apiParameters, TeronEsirReportFilterParameters filterParameters)
        {
            return await GetReportAsync("summaryByTax", apiParameters, filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetSummaryByCashiersReportAsync(TeronEsirReportFilterParameters filterParameters)
        {
            return await GetSummaryByCashiersReportAsync(GetParametersFromHttpClient(), filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetSummaryByCashiersReportAsync(TeronEsirApiParameters apiParameters, TeronEsirReportFilterParameters filterParameters)
        {
            return await GetReportAsync("summaryByCashiers", apiParameters, filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetSummaryByPaymentTypesReportAsync(TeronEsirReportFilterParameters filterParameters)
        {
            return await GetSummaryByPaymentTypesReportAsync(GetParametersFromHttpClient(), filterParameters);
        }
        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetSummaryByPaymentTypesReportAsync(TeronEsirApiParameters apiParameters, TeronEsirReportFilterParameters filterParameters)
        {
            return await GetReportAsync("summaryByPaymentTypes", apiParameters, filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetSummaryByArticlesReportAsync(TeronEsirReportFilterParameters filterParameters)
        {
            return await GetSummaryByArticlesReportAsync(GetParametersFromHttpClient(), filterParameters);
        }
        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetSummaryByArticlesReportAsync(TeronEsirApiParameters apiParameters, TeronEsirReportFilterParameters filterParameters)
        {
            return await GetReportAsync("summaryByArticles", apiParameters, filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetSummaryByCategoriesReportAsync(TeronEsirReportFilterParameters filterParameters)
        {
            return await GetSummaryByCategoriesReportAsync(GetParametersFromHttpClient(), filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetSummaryByCategoriesReportAsync(TeronEsirApiParameters apiParameters, TeronEsirReportFilterParameters filterParameters)
        {
            return await GetReportAsync("summaryByCategories", apiParameters, filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetTransactionsReportAsync(TeronEsirReportFilterParameters filterParameters)
        {
            return await GetTransactionsReportAsync(GetParametersFromHttpClient(), filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetTransactionsReportAsync(TeronEsirApiParameters apiParameters, TeronEsirReportFilterParameters filterParameters)
        {
            return await GetReportAsync("transactions", apiParameters, filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetInventoryReportAsync(TeronEsirReportFilterParameters filterParameters)
        {
            return await GetInventoryReportAsync(GetParametersFromHttpClient(), filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetInventoryReportAsync(TeronEsirApiParameters apiParameters, TeronEsirReportFilterParameters filterParameters)
        {
            return await GetReportAsync("inventory", apiParameters, filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetAdvanceReceiptsReportAsync(TeronEsirReportFilterParameters filterParameters)
        {
            return await GetAdvanceReceiptsReportAsync(GetParametersFromHttpClient(), filterParameters);
        }

        public async Task<TeronEsirResult<TeronEsirReportResponse>> GetAdvanceReceiptsReportAsync(TeronEsirApiParameters apiParameters, TeronEsirReportFilterParameters filterParameters)
        {
            return await GetReportAsync("advance-receipts", apiParameters, filterParameters);
        }

        private async Task<TeronEsirResult<TeronEsirReportResponse>> GetReportAsync(string path, TeronEsirApiParameters apiParameters, TeronEsirReportFilterParameters filterParameters)
        {
            string fullReportRelativePath = $"financial/report/{path}";

            var requestMessage = CreatePostRequestMessage(apiParameters, fullReportRelativePath, filterParameters);
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult<TeronEsirReportResponse>.FromHttpResponseAsync(response);
        }
    }
}
