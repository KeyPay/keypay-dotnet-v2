using System.Threading;
using KeyPayV2.Common.Auth;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Threading.Tasks;
using RestSharp;

namespace KeyPayV2.Common
{
    public interface IBaseApiClient
    {
        void ApiRequest(string url, Method method = Method.Get);
        void ApiRequest<TInput>(string url, TInput input, Method method = Method.Get) where TInput : class;
        Task ApiRequestAsync(string url, Method method = Method.Get, CancellationToken cancellationToken = default);
        Task ApiRequestAsync<TInput>(string url, TInput input, Method method = Method.Get, CancellationToken cancellationToken = default) where TInput : class;

        TResult ApiRequest<TResult>(string url, Method method = Method.Get) where TResult : new();
        Task<TResult> ApiRequestAsync<TResult>(string url, Method method = Method.Get, CancellationToken cancellationToken = default) where TResult : new();
        TResult ApiRequest<TResult, TInput>(string url, TInput input, Method method = Method.Get) where TResult : new() where TInput : class;
        Task<TResult> ApiRequestAsync<TResult, TInput>(string url, TInput input, Method method = Method.Get, CancellationToken cancellationToken = default) where TResult : new() where TInput : class;

        byte[] ApiFileRequest(string url, Method method = Method.Get);
        Task<byte[]> ApiFileRequestAsync(string url, Method method = Method.Get, CancellationToken cancellationToken = default);
        byte[] ApiFileRequest<TInput>(string url, TInput input, Method method = Method.Get) where TInput : class;
        Task<byte[]> ApiFileRequestAsync<TInput>(string url, TInput input, Method method = Method.Get, CancellationToken cancellationToken = default) where TInput : class;
    }

    public abstract class BaseApiClient : IBaseApiClient
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
        }

        protected BaseApiClient(string baseUrl, AuthenticationDetails authenticationDetails, string userAgent = null)
        {
            Api = new ApiRequestExecutor(baseUrl, userAgent) { Authenticator = authenticationDetails.Authenticator };
        }

        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="method">HTTP Method</param>
        public void ApiRequest(string url, Method method = Method.Get)
        {
            var req = new RestRequest(url, method);
            Api.Execute(req);
        }

        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="input">The request body</param>
        /// <param name="method">HTTP Method</param>
        public void ApiRequest<TInput>(string url, TInput input, Method method = Method.Get) where TInput : class
        {
            var req = new RestRequest(url, method);
            AddJsonBody(req, input);
            Api.Execute(req);
        }

        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="method">HTTP Method</param>
        /// <param name="cancellationToken">Cancellation token passed with the request</param>
        public Task ApiRequestAsync(string url, Method method = Method.Get, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest(url, method);
            return Api.ExecuteAsync(req, cancellationToken);
        }

        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="input">The request body</param>
        /// <param name="method">HTTP Method</param>
        /// <param name="cancellationToken">Cancellation token passed with the request</param>
        public Task ApiRequestAsync<TInput>(string url, TInput input, Method method = Method.Get, CancellationToken cancellationToken = default) where TInput : class
        {
            var req = new RestRequest(url, method);
            AddJsonBody(req, input);
            return Api.ExecuteAsync(req, cancellationToken);
        }

        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="method">HTTP Method</param>
        /// <typeparam name="TResult">Data Type of the returned result</typeparam>
        /// <returns>TResult</returns>
        public TResult ApiRequest<TResult>(string url, Method method = Method.Get) where TResult : new()
        {
            var req = new RestRequest(url, method);
            var result = Api.Execute<TResult>(req);
            return result;
        }

        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="method">HTTP Method</param>
        /// <param name="cancellationToken">Cancellation token passed with the request</param>
        /// <typeparam name="TResult">Data Type of the returned result</typeparam>
        /// <returns>TResult</returns>
        public Task<TResult> ApiRequestAsync<TResult>(string url, Method method = Method.Get, CancellationToken cancellationToken = default) where TResult : new()
        {
            var req = new RestRequest(url, method);
            return Api.ExecuteAsync<TResult>(req, cancellationToken);
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
        public TResult ApiRequest<TResult, TInput>(string url, TInput input, Method method = Method.Get) where TResult : new() where TInput : class
        {
            var req = new RestRequest(url, method) { RequestFormat = DataFormat.Json };
            AddJsonBody(req, input);
            var result = Api.Execute<TResult>(req);
            return result;
        }

        private void AddJsonBody<TInput>(RestRequest req, TInput input) where TInput : class
        {
            if (input == null && typeof(TInput) == typeof(string))
                req.AddJsonBody("");
            else if(input != null)
                req.AddJsonBody(input);
        }
        
        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="input">Input parameter</param>
        /// <param name="method">HTTP Method</param>
        /// <param name="cancellationToken">Cancellation token passed with the request</param>
        /// <typeparam name="TResult">Data Type of the returned result</typeparam>
        /// <typeparam name="TInput">Data Type of the input parameter</typeparam>
        /// <returns>TResult</returns>
        public Task<TResult> ApiRequestAsync<TResult, TInput>(string url, TInput input, Method method = Method.Get, CancellationToken cancellationToken = default) where TResult : new() where TInput : class
        {
            var req = new RestRequest(url, method) { RequestFormat = DataFormat.Json };
            AddJsonBody(req, input);
            return Api.ExecuteAsync<TResult>(req, cancellationToken);
        }

        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// and returns a file
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="method">HTTP Method</param>
        /// <returns>byte[]</returns>
        public byte[] ApiFileRequest(string url, Method method = Method.Get)
        {
            var req = new RestRequest(url, method);
            var result = Api.DownloadFile(req);
            return result;
        }

        /// <summary>
        /// Make an API Request to an endpoint that is not listed
        /// and returns a file
        /// </summary>
        /// <param name="url">URL of the endpoint to call</param>
        /// <param name="method">HTTP Method</param>
        /// <param name="cancellationToken">Cancellation token passed with the request</param>
        /// <returns>byte[]</returns>
        public Task<byte[]> ApiFileRequestAsync(string url, Method method = Method.Get, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest(url, method);
            return Api.DownloadFileAsync(req, cancellationToken);
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
        public byte[] ApiFileRequest<TInput>(string url, TInput input, Method method = Method.Get) where TInput : class
        {
            var req = new RestRequest(url, method) { RequestFormat = DataFormat.Json };
            AddJsonBody(req, input);
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
        /// <param name="cancellationToken">Cancellation token passed with the request</param>
        /// <typeparam name="TInput">Data Type of the input parameter</typeparam>
        /// <returns>byte[]</returns>
        public Task<byte[]> ApiFileRequestAsync<TInput>(string url, TInput input, Method method = Method.Get, CancellationToken cancellationToken = default) where TInput : class
        {
            var req = new RestRequest(url, method) { RequestFormat = DataFormat.Json };
            AddJsonBody(req, input);
            return Api.DownloadFileAsync(req, cancellationToken);
        }
    }
}