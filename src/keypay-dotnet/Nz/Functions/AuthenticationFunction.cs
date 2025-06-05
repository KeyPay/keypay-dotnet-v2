using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;

namespace KeyPayV2.Nz.Functions
{
    public interface IAuthenticationFunction
    {
        void Token_Post();
        Task Token_PostAsync(CancellationToken cancellationToken = default);
    }
    public class AuthenticationFunction : BaseFunction, IAuthenticationFunction
    {
        public AuthenticationFunction(ApiRequestExecutor api) : base(api) {}

        public void Token_Post()
        {
            ApiRequest($"/oauth/token", Method.Post);
        }

        public Task Token_PostAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/oauth/token", Method.Post, cancellationToken);
        }
    }
}
