using KeyPayV2.Common.Auth;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using KeyPayV2.Common.Models;
using RestSharp;

namespace KeyPayV2.Common
{
    public abstract class BaseApiClient
    {
        protected readonly ApiRequestExecutor Api;

        protected BaseApiClient(string baseUrl, AuthenticationDetails authenticationDetails)
        {
            JsonConvert.DefaultSettings = () =>
            {
                var settings = new JsonSerializerSettings();
                settings.Converters.Add(new StringEnumConverter());
                return settings;
            };
            Api = new ApiRequestExecutor(baseUrl) {Authenticator = authenticationDetails.Authenticator};
        }

        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="method">HTTP Method</param>
        public void ApiRequest(string url, Method method = Method.GET)
        {
            var req = new RestRequest(url, method) {JsonSerializer = new CustomSerializer()};
            Api.Execute(req);
        }

        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="method">HTTP Method</param>
        /// <typeparam name="TResult">Data Type of the returned result</typeparam>
        /// <returns>TResult</returns>
        public TResult ApiRequest<TResult>(string url, Method method = Method.GET) where TResult : new()
        {
            var req = new RestRequest(url, method) {JsonSerializer = new CustomSerializer()};
            var result = Api.Execute<TResult>(req);
            return result;
        }

        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="input">Input parameter</param>
        /// <param name="method">HTTP Method</param>
        /// <typeparam name="TResult">Data Type of the returned result</typeparam>
        /// <typeparam name="TInput">Data Type of the input parameter</typeparam>
        /// <returns>TResult</returns>
        public TResult ApiRequest<TResult, TInput>(string url, TInput input, Method method = Method.GET) where TResult : new()
        {
            var req = new RestRequest(url, method) {RequestFormat = DataFormat.Json, JsonSerializer = new CustomSerializer()};
            req.AddJsonBody(input);
            var result = Api.Execute<TResult>(req);
            return result;
        }

        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// and returns a file
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="method">HTTP Method</param>
        /// <returns>byte[]</returns>
        public byte[] ApiFileRequest(string url, Method method = Method.GET)
        {
            var req = new RestRequest(url, method) {JsonSerializer = new CustomSerializer()};
            var result = Api.DownloadFile(req);
            return result;
        }
        
        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// and returns a file
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="input">Input parameter</param>
        /// <param name="method">HTTP Method</param>
        /// <typeparam name="TInput">Data Type of the input parameter</typeparam>
        /// <returns>byte[]</returns>
        public byte[] ApiFileRequest<TInput>(string url, TInput input, Method method = Method.GET)
        {
            var req = new RestRequest(url, method) {RequestFormat = DataFormat.Json, JsonSerializer = new CustomSerializer()};
            req.AddJsonBody(input);
            var result = Api.DownloadFile(req);
            return result;
        }
    }
}