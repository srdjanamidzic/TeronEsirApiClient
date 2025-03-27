using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using TeronEsirClient.Json;

namespace TeronEsirClient.Models
{
    public sealed class TeronEsirResult
    {
        public bool IsSuccessful { get; private set; }
        public string Message { get; private set; }
        public string RawResponse { get; private set; }

        internal static TeronEsirResult Success(string rawResponse)
        {
            return new TeronEsirResult
            {
                IsSuccessful = true,
                RawResponse = rawResponse
            };
        }

        internal static TeronEsirResult Fail(string message, string rawResponse)
        {
            return new TeronEsirResult
            {
                IsSuccessful = false,
                Message = message,
                RawResponse = rawResponse
            };
        }

        internal static async Task<TeronEsirResult> FromHttpResponseAsync(HttpResponseMessage httpResponseMessage)
        {
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return Success(await httpResponseMessage.Content.ReadAsStringAsync());
            }
            else
            {
                return Fail(httpResponseMessage.ReasonPhrase, await httpResponseMessage.Content.ReadAsStringAsync());
            }
        }
    }

    public sealed class TeronEsirResult<T>
    {
        public bool IsSuccessful { get; private set; }
        public T Value { get; private set; }
        public string Message { get; private set; }
        public string RawResponse { get; private set; }

        internal static TeronEsirResult<T> Success(T value, string rawResponse)
        {
            return new TeronEsirResult<T>
            {
                IsSuccessful = true,
                Value = value,
                RawResponse = rawResponse
            };
        }

        internal static TeronEsirResult<T> Fail(string message, string rawResponse)
        {
            return Fail(message, rawResponse, default);
        }

        internal static TeronEsirResult<T> Fail(string message, string rawResponse, T value)
        {
            return new TeronEsirResult<T>
            {
                IsSuccessful = false,
                Message = message,
                RawResponse = rawResponse,
                Value = value,
            };
        }

        internal static async Task<TeronEsirResult<T>> FromHttpResponseAsync(HttpResponseMessage httpResponseMessage)
        {
            var responseContent = await httpResponseMessage.Content.ReadAsStringAsync();

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                T value = JsonConvert.DeserializeObject<T>(responseContent, GlobalJsonSerializerSettings.Settings);
                return Success(value, responseContent);
            }

            var message = string.Empty;

            try
            {
                var error = JsonConvert.DeserializeObject<TeronEsirError>(responseContent, GlobalJsonSerializerSettings.Settings);
                message = error.Message;
            }
            catch (JsonSerializationException)
            {
                message = httpResponseMessage.ReasonPhrase;
            }

            return Fail(message, responseContent);
        }
    }
}
