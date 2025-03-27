using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TeronEsirClient.Exceptions;
using TeronEsirClient.Json;
using TeronEsirClient.Models;

namespace TeronEsirClient.Client
{
    public partial class TeronEsirApiClient
    {        
        private readonly HttpClient _httpClient;

        public TeronEsirApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> IsAvailableAsync()
        {
            return await IsAvailableAsync(GetParametersFromHttpClient());
        }

        public async Task<bool> IsAvailableAsync(TeronEsirApiParameters apiParameters)
        {
            var requestMessage = CreateGetRequestMessage(apiParameters, "attention");
            var response = await _httpClient.SendAsync(requestMessage);

            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            return true;
        }

        private protected TeronEsirApiParameters GetParametersFromHttpClient()
        {
            string absoluteUri = _httpClient.BaseAddress?.AbsoluteUri;
            string bearerToken = _httpClient.DefaultRequestHeaders.Authorization?.Parameter;

            if (string.IsNullOrWhiteSpace(absoluteUri))
            {
                throw new TeronEsirConnectionException(
                    "Missing base address. Either pass the connection parameters to the method, or configure BaseAddress for the HttpClient.");
            }

            if (string.IsNullOrWhiteSpace(bearerToken))
            {
                throw new TeronEsirConnectionException(
                    "Missing bearer token. Either pass the connection parameters to the method, or configure Authorization header for the HttpClient.");
            }

            return new TeronEsirApiParameters(absoluteUri, bearerToken);
        }

        private protected HttpRequestMessage CreateGetRequestMessage(TeronEsirApiParameters apiParameters, string relativePath, NameValueCollection queryParams = null)
        {
            var uriBuilder = new UriBuilder(FormatUri(apiParameters.BaseAddress));
            uriBuilder.Path += "api/" + relativePath;

            if (queryParams != null)
            {
                uriBuilder.Query = queryParams.ToString();
            }

            return new HttpRequestMessage(HttpMethod.Get, uriBuilder.ToString())
            {
                Headers =
                {
                    { "Authorization", FormatBearerToken(apiParameters.BearerToken) },
                }
            };
        }

        private protected HttpRequestMessage CreatePostRequestMessage(TeronEsirApiParameters apiParameters, string relativePath, string content = null, string contentType = null)
        {
            return new HttpRequestMessage(HttpMethod.Post, FormatUri(apiParameters.BaseAddress) + "api/" + relativePath)
            {
                Content = new StringContent(content, Encoding.UTF8, contentType),
                Headers =
                {
                    { "Authorization", FormatBearerToken(apiParameters.BearerToken) },
                }
            };
        }

        private protected HttpRequestMessage CreatePostRequestMessage(TeronEsirApiParameters apiParameters, string relativePath, object model)
        {
            return CreatePostRequestMessage(apiParameters, relativePath, JsonConvert.SerializeObject(model, GlobalJsonSerializerSettings.Settings), "application/json");
        }

        private protected HttpRequestMessage CreateDeleteRequestMessage(TeronEsirApiParameters apiParameters, string relativePath)
        {
            return new HttpRequestMessage(HttpMethod.Delete, FormatUri(apiParameters.BaseAddress) + "api/" + relativePath)
            {
                Headers =
                {
                    { "Authorization", FormatBearerToken(apiParameters.BearerToken) },
                }
            };
        }

        protected string FormatUri(string uri)
        {
            var formattedUri = uri.Trim();

            if (formattedUri.EndsWith("/"))
            {
                return formattedUri;
            }

            return formattedUri + "/";
        }

        protected string FormatBearerToken(string bearerToken)
        {
            if (bearerToken.StartsWith("Bearer "))
            {
                return bearerToken;
            }
            
            return "Bearer " + bearerToken;
        }
    }
}
