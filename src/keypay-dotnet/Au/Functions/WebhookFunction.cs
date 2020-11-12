using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.Webhook;

namespace KeyPayV2.Au.Functions
{
    public class WebhookFunction : BaseFunction
    {
        public WebhookFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Web Hook Registrations
        /// </summary>
        /// <remarks>
        /// Returns a collection containing the registered web hook instances for the user.
        /// </remarks>
        public List<WebHook> ListWebHookRegistrations(int businessId)
        {
            return ApiRequest<List<WebHook>>($"/business/{businessId}/webhookregistrations");
        }

        /// <summary>
        /// Register Web Hook
        /// </summary>
        /// <remarks>
        /// Registers a new web hook.
        /// </remarks>
        public WebHook RegisterWebHook(int businessId, WebHook webHook)
        {
            return ApiRequest<WebHook,WebHook>($"/business/{businessId}/webhookregistrations", webHook, Method.POST);
        }

        /// <summary>
        /// Delete all Web Hook Registrations
        /// </summary>
        /// <remarks>
        /// Deletes all the web hook registrations.
        /// </remarks>
        public void DeleteAllWebHookRegistrations(int businessId)
        {
            ApiRequest($"/business/{businessId}/webhookregistrations", Method.DELETE);
        }

        /// <summary>
        /// Get Web Hook Registration by ID
        /// </summary>
        /// <remarks>
        /// Gets the registered web hook instance with the specified ID.
        /// </remarks>
        public WebHook GetWebHookRegistrationById(int businessId, string id)
        {
            return ApiRequest<WebHook>($"/business/{businessId}/webhookregistrations/{id}");
        }

        /// <summary>
        /// Update Web Hook Registration
        /// </summary>
        /// <remarks>
        /// Updates the web hook registration with the specified ID.
        /// </remarks>
        public void UpdateWebHookRegistration(int businessId, string id, WebHook webHook)
        {
            ApiRequest($"/business/{businessId}/webhookregistrations/{id}", webHook, Method.PUT);
        }

        /// <summary>
        /// Delete Web Hook Registration
        /// </summary>
        /// <remarks>
        /// Deletes the web hook registration with the specified ID.
        /// </remarks>
        public void DeleteWebHookRegistration(int businessId, string id)
        {
            ApiRequest($"/business/{businessId}/webhookregistrations/{id}", Method.DELETE);
        }

        /// <summary>
        /// Test Web Hook
        /// </summary>
        /// <remarks>
        /// Tests a web hook given a registration ID and a filter string.
        /// </remarks>
        public void TestWebHook(int businessId, string id, TestWebHookQueryModel request)
        {
            ApiRequest($"/business/{businessId}/webhookregistrations/{id}/test?filter={request.Filter}");
        }
    }
}
