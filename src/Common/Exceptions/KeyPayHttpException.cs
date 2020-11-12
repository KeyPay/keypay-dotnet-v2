using System;
using System.Net;
using RestSharp;
using System.IO;

namespace KeyPayV2.Common.Exceptions
{
    public class KeyPayHttpException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public string StatusMessage { get; }
        public Method RequestMethod { get; }
        public string RequestResource { get; }
        public string ResponseContent { get; }
        
        public KeyPayHttpException(HttpStatusCode statusCode, string message, Method requestMethod, string requestResource, string responseContent) : base($"Error during {requestMethod} to {requestResource}. Received status code {(int)statusCode} : {message}. See ResponseContent property for details")
        {
            StatusCode = statusCode;
            StatusMessage = message;
            RequestMethod = requestMethod;
            RequestResource = requestResource;
            ResponseContent = responseContent;
        }
     }
} 