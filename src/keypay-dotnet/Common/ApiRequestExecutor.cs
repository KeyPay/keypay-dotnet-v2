using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using KeyPayV2.Common.Exceptions;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.Json;

namespace KeyPayV2.Common
{
    public class ApiRequestExecutor
    {
        public string Token { get; set; }
        public IAuthenticator Authenticator { get; set; }

        private readonly string baseUrl;
        private readonly string userAgent;

        public Action<RestResponse> ResponseCallback { get; set; }

        public ApiRequestExecutor(string baseUrl, string userAgent = null)
        {
            this.baseUrl = baseUrl;
            this.userAgent = userAgent;
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = GetClient(request);
            var response = client.Execute(request);
            ResponseCallback?.Invoke(response);

            HandleResponse(response, request.Method, request.Resource);

            var result = JsonConvert.DeserializeObject<T>(response.Content);
            return result;
        }

        public async Task<T> ExecuteAsync<T>(RestRequest request, CancellationToken cancellationToken = default) where T : new()
        {
            var client = GetClient(request);
            var response = await client.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);
            ResponseCallback?.Invoke(response);

            HandleResponse(response, request.Method, request.Resource);

            var result = JsonConvert.DeserializeObject<T>(response.Content);
            return result;
        }

        public string Execute(RestRequest request)
        {
            var client = GetClient(request);
            var response = client.Execute(request);
            HandleResponse(response, request.Method, request.Resource);
            return response.Content;
        }

        public async Task<string> ExecuteAsync(RestRequest request, CancellationToken cancellationToken = default)
        {
            var client = GetClient(request);
            var response = await client.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);
            HandleResponse(response, request.Method, request.Resource);
            return response.Content;
        }

        public byte[] DownloadFile(RestRequest request)
        {
            var client = GetClient(request);
            var response = client.DownloadData(request);
            return response;
        }

        public async Task<byte[]> DownloadFileAsync(RestRequest request, CancellationToken cancellationToken = default)
        {
            var client = GetClient(request);
            var response = await client.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);
            return response.RawBytes;
        }

        private RestClient GetClient(RestRequest request)
        {
            var options = new RestClientOptions()
            {
                BaseUrl = new Uri(baseUrl),
                MaxTimeout = 600000, // 10 min timeout for long EI queries
                Authenticator = Authenticator,
                CookieContainer = new CookieContainer(),
            };

            if (!string.IsNullOrEmpty(userAgent))
            {
                options.UserAgent = userAgent;
            }

            var client = new RestClient(
                options,
                configureSerialization: s => s.UseSerializer(() => new RestSharp.Serializers.NewtonsoftJson.JsonNetSerializer())
            );

            request.OnBeforeDeserialization = resp => 
                HandleResponse(resp, request.Method, request.Resource);

            return client;
        }

        private void HandleResponse(RestResponse resp, Method requestMethod, string requestResource)
        {
            ResponseCallback?.Invoke(resp);

            var statusCodeExceptionMessage = resp.ErrorException?.Message?.StartsWith("Request failed with status code") ?? false;
            if (resp.ErrorException != null && !statusCodeExceptionMessage)
            {
                throw resp.ErrorException;
            }
            if (resp.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new TokenExpiredException(resp.StatusDescription);
            }
            var isKeyPayHttpException = resp.StatusCode >= HttpStatusCode.BadRequest && resp.StatusCode <= HttpStatusCode.InternalServerError;
            if (statusCodeExceptionMessage || isKeyPayHttpException)
            {
                throw new KeyPayHttpException(resp.StatusCode, resp.StatusDescription, requestMethod, requestResource, resp.Content);
            }
        }
    }
}