using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
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

        public ApiRequestExecutor(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = GetClient(request);
            var response = client.Execute(request);
            if (response.ErrorException != null)
                throw response.ErrorException;
            if ((int) response.StatusCode >= 400)
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
            SetSSL();
            var client = new RestClient
            {
                BaseUrl = new Uri(baseUrl),
                Authenticator = Authenticator,
                Timeout = 600000 // 10 min timeout for long EI queries
            };

            request.OnBeforeDeserialization = resp => HandleResponse(resp, request.Method, request.Resource);
            return client;
        }

        private static void HandleResponse(IRestResponse resp, Method requestMethod, string requestResource)
        {
            if (resp.ErrorException != null)
                throw resp.ErrorException;
            if (resp.StatusCode == HttpStatusCode.Unauthorized)
                throw new TokenExpiredException(resp.StatusDescription);
            if (resp.StatusCode >= HttpStatusCode.BadRequest && resp.StatusCode <= HttpStatusCode.InternalServerError)
                throw new KeyPayHttpException(resp.StatusCode, resp.StatusDescription, requestMethod, requestResource, resp.Content);
        }

        //Trust all certificates
        // callback used to validate the certificate in an SSL conversation
        private static bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain,
            SslPolicyErrors policyErrors)
        {
            return true;
        }

        private void SetSSL()
        {
            ServicePointManager.ServerCertificateValidationCallback =
                ((sender, certificate, chain, sslPolicyErrors) => true);

            // trust sender
            ServicePointManager.ServerCertificateValidationCallback
                = ((sender, cert, chain, errors) => true);

            // validate cert by calling a function
            ServicePointManager.ServerCertificateValidationCallback += ValidateRemoteCertificate;
        }

    }
}