using System.Threading.Tasks;
using TeronEsirClient.Models;
using TeronEsirClient.Models.CashRegister.Read;
using TeronEsirClient.Models.CashRegister.Write;

namespace TeronEsirClient.Client
{
    public partial class TeronEsirApiClient
    {
        public async Task<TeronEsirResult> DepositAsync(decimal amount)
        {
            return await DepositAsync(GetParametersFromHttpClient(), amount);
        }

        public async Task<TeronEsirResult> DepositAsync(TeronEsirApiParameters apiParameters, decimal amount)
        {
            var requestMessage = CreatePostRequestMessage(apiParameters, "financial/deposit", new TeronEsirCashRegisterDeposit { Amount = amount });
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult.FromHttpResponseAsync(response);
        }

        public async Task<TeronEsirResult> WithdrawAsync(decimal amount)
        {
            return await WithdrawAsync(GetParametersFromHttpClient(), amount);
        }

        public async Task<TeronEsirResult> WithdrawAsync(TeronEsirApiParameters apiParameters, decimal amount)
        {
            var requestMessage = CreatePostRequestMessage(apiParameters, "financial/withdraw", new TeronEsirCashRegisterWithdraw { Amount = amount });
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult.FromHttpResponseAsync(response);
        }

        public async Task<TeronEsirResult<TeronEsirCashRegisterSummary>> GetSummaryAsync()
        {
            return await GetSummaryAsync(GetParametersFromHttpClient());
        }

        public async Task<TeronEsirResult<TeronEsirCashRegisterSummary>> GetSummaryAsync(TeronEsirApiParameters apiParameters)
        {
            var requestMessage = CreateGetRequestMessage(apiParameters, "financial/summary");
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult<TeronEsirCashRegisterSummary>.FromHttpResponseAsync(response);
        }

        public async Task<TeronEsirResult> ClearFinancialSummaryAsync()
        {
            return await ClearFinancialSummaryAsync(GetParametersFromHttpClient());
        }

        public async Task<TeronEsirResult> ClearFinancialSummaryAsync(TeronEsirApiParameters apiParameters)
        {
            var requestMessage = CreateDeleteRequestMessage(apiParameters, "financial/summary");
            var response = await _httpClient.SendAsync(requestMessage);

            return await TeronEsirResult.FromHttpResponseAsync(response);
        }
    }
}
