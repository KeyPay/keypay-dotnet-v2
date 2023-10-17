using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.Authentication;

namespace KeyPayV2.Sg.Functions
{
    public interface IAuthenticationFunction
    {
        SingleSignOnResponseModel SingleSignOn(int businessId, int employeeId, SingleSignOnRequestModel model);
        Task<SingleSignOnResponseModel> SingleSignOnAsync(int businessId, int employeeId, SingleSignOnRequestModel model, CancellationToken cancellationToken = default);
        SingleSignOnResponseModel SingleSignOn(int businessId, SingleSignOnRequestModel model);
        Task<SingleSignOnResponseModel> SingleSignOnAsync(int businessId, SingleSignOnRequestModel model, CancellationToken cancellationToken = default);
        SingleSignOnResponseModel SingleSignOn(SingleSignOnRequestModel model);
        Task<SingleSignOnResponseModel> SingleSignOnAsync(SingleSignOnRequestModel model, CancellationToken cancellationToken = default);
        void OauthToken();
        Task OauthTokenAsync(CancellationToken cancellationToken = default);
    }
    public class AuthenticationFunction : BaseFunction, IAuthenticationFunction
    {
        public AuthenticationFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// Request for SSO URL that provides authenticated access to KeyPay. See the guide on <a href="http://api.keypay.com.au/guides/SSO">SSO Requests</a> for more details.
        /// </remarks>
        public SingleSignOnResponseModel SingleSignOn(int businessId, int employeeId, SingleSignOnRequestModel model)
        {
            return ApiRequest<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/business/{businessId}/employee/{employeeId}/singlesignon", model, Method.Post);
        }

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// Request for SSO URL that provides authenticated access to KeyPay. See the guide on <a href="http://api.keypay.com.au/guides/SSO">SSO Requests</a> for more details.
        /// </remarks>
        public Task<SingleSignOnResponseModel> SingleSignOnAsync(int businessId, int employeeId, SingleSignOnRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/business/{businessId}/employee/{employeeId}/singlesignon", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// Request for SSO URL that provides authenticated access to KeyPay. See the guide on <a href="http://api.keypay.com.au/guides/SSO">SSO Requests</a> for more details.
        /// </remarks>
        public SingleSignOnResponseModel SingleSignOn(int businessId, SingleSignOnRequestModel model)
        {
            return ApiRequest<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/business/{businessId}/singlesignon", model, Method.Post);
        }

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// Request for SSO URL that provides authenticated access to KeyPay. See the guide on <a href="http://api.keypay.com.au/guides/SSO">SSO Requests</a> for more details.
        /// </remarks>
        public Task<SingleSignOnResponseModel> SingleSignOnAsync(int businessId, SingleSignOnRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/business/{businessId}/singlesignon", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// Request for SSO URL that provides authenticated access to KeyPay. See the guide on <a href="http://api.keypay.com.au/guides/SSO">SSO Requests</a> for more details.
        /// </remarks>
        public SingleSignOnResponseModel SingleSignOn(SingleSignOnRequestModel model)
        {
            return ApiRequest<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/singlesignon", model, Method.Post);
        }

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// Request for SSO URL that provides authenticated access to KeyPay. See the guide on <a href="http://api.keypay.com.au/guides/SSO">SSO Requests</a> for more details.
        /// </remarks>
        public Task<SingleSignOnResponseModel> SingleSignOnAsync(SingleSignOnRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/singlesignon", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// OAuth Token
        /// </summary>
        /// <remarks>
        /// See the guide on <a href="http://api.keypay.com.au/guides/OAuth2">OAuth2 authentication</a> for more details.
        /// </remarks>
        public void OauthToken()
        {
            ApiRequest($"/oauth/token", Method.Post);
        }

        /// <summary>
        /// OAuth Token
        /// </summary>
        /// <remarks>
        /// See the guide on <a href="http://api.keypay.com.au/guides/OAuth2">OAuth2 authentication</a> for more details.
        /// </remarks>
        public Task OauthTokenAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/oauth/token", Method.Post, cancellationToken);
        }
    }
}
