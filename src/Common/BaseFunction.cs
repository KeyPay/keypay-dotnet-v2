using System.Collections.Generic;
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

        protected void ApiRequest(string url, Method method = Method.GET)
        {
            var req = new RestRequest(url, method) {JsonSerializer = new CustomSerializer()};
            Api.Execute(req);
        }

        protected T ApiRequest<T>(string url, Method method = Method.GET) where T : new()
        {
            var req = new RestRequest(url, method) {JsonSerializer = new CustomSerializer()};
            var result = Api.Execute<T>(req);
            return result;
        }

        protected TResult ApiRequest<TResult, TInput>(string url, TInput input, Method method = Method.GET) where TResult : new()
        {
            var req = new RestRequest(url, method) {RequestFormat = DataFormat.Json, JsonSerializer = new CustomSerializer()};
            req.AddJsonBody(input);
            var result = Api.Execute<TResult>(req);
            return result;
        }

        protected void ApiRequest(string url, object input, Method method = Method.GET)
        {
            var req = new RestRequest(url, method) {RequestFormat = DataFormat.Json, JsonSerializer = new CustomSerializer()};
            req.AddJsonBody(input);
            Api.Execute(req);
        }

        protected T ApiFileRequest<T>(string url, FileUploadModel file, Method method = Method.POST) where T : new()
        {
            var req = new RestRequest(url, method) {JsonSerializer = new CustomSerializer()};
            req.AddFile(file.FileName, file.File, file.FileName);
            var result = Api.Execute<T>(req);
            return result;
        }

        protected T ApiFileRequest<T>(string url, List<FileUploadModel> files, Method method = Method.POST) where T : new()
        {
            var req = new RestRequest(url, method) {JsonSerializer = new CustomSerializer()};
            foreach (var file in files)
            {
                req.AddFile(file.FileName, file.File, file.FileName);
            }
            var result = Api.Execute<T>(req);
            return result;
        }

        protected T ApiByteArrayRequest<T>(string url, Method method = Method.GET) where T : new()
        {
            var req = new RestRequest(url, method);
            var response = Api.Execute(req);
            var result = JsonConvert.DeserializeObject<T>(response);
            return result;
        }
        protected byte[] ApiByteArrayRequest(string url, Method method = Method.GET)
        {
            var req = new RestRequest(url, method);
            var result = Api.DownloadFile(req);
            return result;
        }

        protected string ApiJsonRequest(string url, Method method = Method.GET)
        {
            var req = new RestRequest(url, method) {JsonSerializer = new CustomSerializer()};
            var result = Api.Execute(req);
            return result;
        }

        protected T ApiJsonRequest<T>(string url, Method method = Method.GET)
        {
            var req = new RestRequest(url, method) {JsonSerializer = new CustomSerializer()};
            var response = Api.Execute(req);
            var result = JsonConvert.DeserializeObject<T>(response);
            return result;
        }
    }
}