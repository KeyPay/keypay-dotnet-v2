using System;
using System.Net;
using KeyPayV2.Common.Exceptions;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace KeyPayV2.Common
{
    public class ApiRequestExecutor
    {
        public string Token { get; set; }
        public IAuthenticator Authenticator { get; set; }

        private readonly string baseUrl;
        private readonly string userAgent;

        public Action<IRestResponse> ResponseCallback { get; set; }

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
            if (response.ErrorException != null)
                throw response.ErrorException;
            if ((int)response.StatusCode >= 400)
            {
                throw new KeyPayHttpException(response.StatusCode, response.StatusDescription, request.Method, request.Resource, response.Content);
            }
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
        public byte[] DownloadFile(RestRequest request)
        {
            var client = GetClient(request);
            var response = client.DownloadData(request);
            return response;
        }

        private RestClient GetClient(RestRequest request)
        {
            var client = new RestClient
            {
                BaseUrl = new Uri(baseUrl),
                Authenticator = Authenticator,
                Timeout = 600000 // 10 min timeout for long EI queries
            };
            client.UserAgent = userAgent ?? client.UserAgent;

            request.OnBeforeDeserialization = resp => HandleResponse(resp, request.Method, request.Resource);
            return client;
        }

        private void HandleResponse(IRestResponse resp, Method requestMethod, string requestResource)
        {
            ResponseCallback?.Invoke(resp);
            if (resp.ErrorException != null)
                throw resp.ErrorException;
            if (resp.StatusCode == HttpStatusCode.Unauthorized)
                throw new TokenExpiredException(resp.StatusDescription);
            if (resp.StatusCode >= HttpStatusCode.BadRequest && resp.StatusCode <= HttpStatusCode.InternalServerError)
                throw new KeyPayHttpException(resp.StatusCode, resp.StatusDescription, requestMethod, requestResource, resp.Content);
        }
    }
}