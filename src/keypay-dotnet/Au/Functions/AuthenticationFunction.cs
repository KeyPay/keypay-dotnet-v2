using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.Authentication;

namespace KeyPayV2.Au.Functions
{
    public class AuthenticationFunction : BaseFunction
    {
        public AuthenticationFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// can either be called via /api/v2/singlesignon or /api/v2/business/singlesignon (which goes to the business controller)
        /// </remarks>
        public SingleSignOnResponseModel SingleSignOn(int businessId, int employeeId, SingleSignOnRequestModel model)
        {
            return ApiRequest<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/business/{businessId}/employee/{employeeId}/singlesignon", model, Method.POST);
        }

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// can either be called via /api/v2/singlesignon or /api/v2/business/singlesignon (which goes to the business controller)
        /// </remarks>
        public SingleSignOnResponseModel SingleSignOn(int businessId, SingleSignOnRequestModel model)
        {
            return ApiRequest<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/business/{businessId}/singlesignon", model, Method.POST);
        }

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// can either be called via /api/v2/singlesignon or /api/v2/business/singlesignon (which goes to the business controller)
        /// </remarks>
        public SingleSignOnResponseModel SingleSignOn(SingleSignOnRequestModel model)
        {
            return ApiRequest<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/singlesignon", model, Method.POST);
        }

        /// <summary>
        /// OAuth Token
        /// </summary>
        /// <remarks>
        /// See the guide on <a href="http://api.keypay.com.au/guides/OAuth2">OAuth2 authentication</a> for more details.
        /// </remarks>
        public void OauthToken(OauthTokenQueryModel request)
        {
            ApiRequest($"/oauth/token?request={request.Request}", Method.POST);
        }
    }
}
