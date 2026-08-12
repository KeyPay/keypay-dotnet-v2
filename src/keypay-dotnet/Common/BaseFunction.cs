using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KeyPayV2.Common.Models;
using Newtonsoft.Json;
using RestSharp;

namespace KeyPayV2.Common
{
    public abstract class BaseFunction
    {
        protected readonly ApiRequestExecutor Api;

        protected BaseFunction(ApiRequestExecutor api)
        {
            Api = api;
        }

        protected void ApiRequest(string url, Method method)
        {
            var req = new RestRequest(url, method);
            Api.Execute(req);
        }

        protected Task ApiRequestAsync(string url, Method method, CancellationToken cancellationToken)
        {
            var req = new RestRequest(url, method);
            return Api.ExecuteAsync(req, cancellationToken);
        }

        protected T ApiRequest<T>(string url, Method method) where T : new()
        {
            var req = new RestRequest(url, method);
            var result = Api.Execute<T>(req);
            return result;
        }

        protected Task<T> ApiRequestAsync<T>(string url, Method method, CancellationToken cancellationToken) where T : new()
        {
            var req = new RestRequest(url, method);
            return Api.ExecuteAsync<T>(req, cancellationToken);
        }
        
        private void AddJsonBody<TInput>(RestRequest req, TInput input) where TInput : class
        {
            if (input == null && typeof(TInput) == typeof(string))
                req.AddJsonBody("");
            else if(input != null)
                req.AddJsonBody(input);
        }

        protected TResult ApiRequest<TResult, TInput>(string url, TInput input, Method method) where TResult : new() where TInput : class
        {
            var req = new RestRequest(url, method) { RequestFormat = DataFormat.Json };
            AddJsonBody(req, input);
            var result = Api.Execute<TResult>(req);
            return result;
        }

        protected Task<TResult> ApiRequestAsync<TResult, TInput>(string url, TInput input, Method method, CancellationToken cancellationToken) where TResult : new() where TInput : class
        {
            var req = new RestRequest(url, method) { RequestFormat = DataFormat.Json };
            AddJsonBody(req, input);
            return Api.ExecuteAsync<TResult>(req, cancellationToken);
        }

        protected void ApiRequest(string url, object input, Method method)
        {
            var req = new RestRequest(url, method) { RequestFormat = DataFormat.Json };
            AddJsonBody(req, input);
            Api.Execute(req);
        }

        protected Task ApiRequestAsync(string url, object input, Method method, CancellationToken cancellationToken)
        {
            var req = new RestRequest(url, method) { RequestFormat = DataFormat.Json };
            AddJsonBody(req, input);
            return Api.ExecuteAsync(req, cancellationToken);
        }

        protected T ApiFileRequest<T>(string url, FileUploadModel file, Method method) where T : new()
        {
            var req = new RestRequest(url, method);
            req.AddFile("file", file.File, file.FileName);
            var result = Api.Execute<T>(req);
            return result;
        }

        protected Task<T> ApiFileRequestAsync<T>(string url, FileUploadModel file, Method method, CancellationToken cancellationToken) where T : new()
        {
            var req = new RestRequest(url, method);
            req.AddFile("file", file.File, file.FileName);
            return Api.ExecuteAsync<T>(req, cancellationToken);
        }

        protected T ApiFileRequest<T>(string url, List<FileUploadModel> files, Method method) where T : new()
        {
            var req = new RestRequest(url, method);
            foreach (var file in files)
            {
                req.AddFile("file", file.File, file.FileName);
            }
            var result = Api.Execute<T>(req);
            return result;
        }

        protected T ApiByteArrayRequest<T>(string url, Method method) where T : new()
        {
            var req = new RestRequest(url, method);
            var response = Api.Execute(req);
            var result = JsonConvert.DeserializeObject<T>(response);
            return result;
        }
        protected async Task<T> ApiByteArrayRequestAsync<T>(string url, Method method, CancellationToken cancellationToken) where T : new()
        {
            var req = new RestRequest(url, method);
            var response = await Api.ExecuteAsync(req, cancellationToken).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<T>(response);
        }
        protected byte[] ApiByteArrayRequest(string url, Method method)
        {
            var req = new RestRequest(url, method);
            var result = Api.DownloadFile(req);
            return result;
        }
        protected Task<byte[]> ApiByteArrayRequestAsync(string url, Method method, CancellationToken cancellationToken)
        {
            var req = new RestRequest(url, method);
            return Api.DownloadFileAsync(req, cancellationToken);
        }

        protected string ApiJsonRequest(string url, Method method)
        {
            var req = new RestRequest(url, method);
            var result = Api.Execute(req);
            return result;
        }

        protected T ApiJsonRequest<T>(string url, Method method)
        {
            var req = new RestRequest(url, method);
            var response = Api.Execute(req);
            var result = JsonConvert.DeserializeObject<T>(response);
            return result;
        }
        // Legacy overload — kept for backward compatibility with previously-generated clients.
        protected string ConvertEnumerableToQueryString(string parameterName, IEnumerable<string> listOfStrings)
        {
            return listOfStrings != null && listOfStrings.Count() > 0 ? $"&{parameterName}=" + string.Join($"&{parameterName}=", listOfStrings) : "";
        }

        // Builds a complete query string from an ordered set of segments, handling nulls and
        // empty arrays safely. Segments that are null or empty are skipped; the "?" prefix is
        // only emitted when at least one non-empty segment exists.
        protected static string ToQueryString(params string[] segments)
        {
            var nonEmpty = segments.Where(s => !string.IsNullOrEmpty(s)).ToList();
            return nonEmpty.Count > 0 ? "?" + string.Join("&", nonEmpty) : "";
        }

        // Formats an array query parameter as "name=v1&name=v2&...". Returns an empty string
        // when the collection is null or empty so ToQueryString can skip it safely.
        protected static string QsArr(string name, IEnumerable<string> values)
        {
            if (values == null) return "";
            var list = values.ToList();
            return list.Count > 0 ? string.Join("&", list.Select(v => $"{name}={v}")) : "";
        }
    }
}