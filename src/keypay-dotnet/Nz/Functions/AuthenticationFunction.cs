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
using KeyPayV2.Nz.Models.Authentication;

namespace KeyPayV2.Nz.Functions
{
    public interface IAuthenticationFunction
    {
        AttemptAccountRecoveryResponseModel RequestAccountRecoveryForMobileApp(AttemptAccountRecoveryRequestModel model);
        Task<AttemptAccountRecoveryResponseModel> RequestAccountRecoveryForMobileAppAsync(AttemptAccountRecoveryRequestModel model, CancellationToken cancellationToken = default);
        GetUserBrandAssociationsResponseModel GetUserBrandAssociationsForMobileApp(MobileAccountRecoveryValidationModel model);
        Task<GetUserBrandAssociationsResponseModel> GetUserBrandAssociationsForMobileAppAsync(MobileAccountRecoveryValidationModel model, CancellationToken cancellationToken = default);
        void OauthToken();
        Task OauthTokenAsync(CancellationToken cancellationToken = default);
        SingleSignOnResponseModel SingleSignOn(int businessId, int employeeId, SingleSignOnRequestModel model);
        Task<SingleSignOnResponseModel> SingleSignOnAsync(int businessId, int employeeId, SingleSignOnRequestModel model, CancellationToken cancellationToken = default);
        SingleSignOnResponseModel SingleSignOn(int businessId, SingleSignOnRequestModel model);
        Task<SingleSignOnResponseModel> SingleSignOnAsync(int businessId, SingleSignOnRequestModel model, CancellationToken cancellationToken = default);
        SingleSignOnResponseModel SingleSignOn(SingleSignOnRequestModel model);
        Task<SingleSignOnResponseModel> SingleSignOnAsync(SingleSignOnRequestModel model, CancellationToken cancellationToken = default);
    }
    public class AuthenticationFunction : BaseFunction, IAuthenticationFunction
    {
        public AuthenticationFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Request Account Recovery for Mobile App
        /// </summary>
        /// <remarks>
        /// Initiates an account recovery request for mobile app users. This endpoint is specifically designed for the EH Work App.
        /// </remarks>
        public AttemptAccountRecoveryResponseModel RequestAccountRecoveryForMobileApp(AttemptAccountRecoveryRequestModel model)
        {
            return ApiRequest<AttemptAccountRecoveryResponseModel,AttemptAccountRecoveryRequestModel>($"/mobileaccountrecovery/attempt", model, Method.Post);
        }

        /// <summary>
        /// Request Account Recovery for Mobile App
        /// </summary>
        /// <remarks>
        /// Initiates an account recovery request for mobile app users. This endpoint is specifically designed for the EH Work App.
        /// </remarks>
        public Task<AttemptAccountRecoveryResponseModel> RequestAccountRecoveryForMobileAppAsync(AttemptAccountRecoveryRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AttemptAccountRecoveryResponseModel,AttemptAccountRecoveryRequestModel>($"/mobileaccountrecovery/attempt", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get User Brand Associations for Mobile App
        /// </summary>
        /// <remarks>
        /// This endpoint is used to get all brands associated with the user after authenticating with encrypted 2FA token
        /// </remarks>
        public GetUserBrandAssociationsResponseModel GetUserBrandAssociationsForMobileApp(MobileAccountRecoveryValidationModel model)
        {
            return ApiRequest<GetUserBrandAssociationsResponseModel,MobileAccountRecoveryValidationModel>($"/mobileaccountrecovery/userbrandassociations", model, Method.Post);
        }

        /// <summary>
        /// Get User Brand Associations for Mobile App
        /// </summary>
        /// <remarks>
        /// This endpoint is used to get all brands associated with the user after authenticating with encrypted 2FA token
        /// </remarks>
        public Task<GetUserBrandAssociationsResponseModel> GetUserBrandAssociationsForMobileAppAsync(MobileAccountRecoveryValidationModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<GetUserBrandAssociationsResponseModel,MobileAccountRecoveryValidationModel>($"/mobileaccountrecovery/userbrandassociations", model, Method.Post, cancellationToken);
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
    }
}
