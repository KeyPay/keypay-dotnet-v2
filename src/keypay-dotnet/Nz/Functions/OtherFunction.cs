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
using KeyPayV2.Nz.Models.Other;

namespace KeyPayV2.Nz.Functions
{
    public interface IOtherFunction
    {
        void GetPaymentFilesByFinalisedPayRunId(int businessId);
        Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, CancellationToken cancellationToken = default);
        void GetPaymentFilesByFinalisedPayRunId(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request);
        Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default);
        void GetBusinessAdvancedSettings(int businessId);
        Task GetBusinessAdvancedSettingsAsync(int businessId, CancellationToken cancellationToken = default);
        void UpdateBusinessAdvancedSettings(int businessId, NzBusinessAdvancedSettingsModel model);
        Task UpdateBusinessAdvancedSettingsAsync(int businessId, NzBusinessAdvancedSettingsModel model, CancellationToken cancellationToken = default);
        NewUserCreatedModel CreateANewDirectBillingUser(CreateDirectAccountNewUserModel model);
        Task<NewUserCreatedModel> CreateANewDirectBillingUserAsync(CreateDirectAccountNewUserModel model, CancellationToken cancellationToken = default);
    }
    public class OtherFunction : BaseFunction, IOtherFunction
    {
        public OtherFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Payment Files by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the payment files for a finalised pay run with the specified Id.
        /// </remarks>
        public void GetPaymentFilesByFinalisedPayRunId(int businessId)
        {
            ApiRequest($"/business/{businessId}/report/paymentfile", Method.Get);
        }

        /// <summary>
        /// Get Payment Files by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the payment files for a finalised pay run with the specified Id.
        /// </remarks>
        public Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/report/paymentfile", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Payment Files by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the payment files for a finalised pay run with the specified Id.
        /// </remarks>
        public void GetPaymentFilesByFinalisedPayRunId(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request)
        {
            ApiRequest($"/business/{businessId}/report/paymentfile?PayRunId={request.PayRunId}&PaymentFileId={request.PaymentFileId}", Method.Get);
        }

        /// <summary>
        /// Get Payment Files by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the payment files for a finalised pay run with the specified Id.
        /// </remarks>
        public Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/report/paymentfile?PayRunId={request.PayRunId}&PaymentFileId={request.PaymentFileId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get business advanced settings
        /// </summary>
        public void GetBusinessAdvancedSettings(int businessId)
        {
            ApiRequest($"/business/{businessId}/advanced", Method.Get);
        }

        /// <summary>
        /// Get business advanced settings
        /// </summary>
        public Task GetBusinessAdvancedSettingsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/advanced", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update business advanced settings
        /// </summary>
        public void UpdateBusinessAdvancedSettings(int businessId, NzBusinessAdvancedSettingsModel model)
        {
            ApiRequest($"/business/{businessId}/advanced", model, Method.Put);
        }

        /// <summary>
        /// Update business advanced settings
        /// </summary>
        public Task UpdateBusinessAdvancedSettingsAsync(int businessId, NzBusinessAdvancedSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/advanced", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Create a new direct billing user
        /// </summary>
        public NewUserCreatedModel CreateANewDirectBillingUser(CreateDirectAccountNewUserModel model)
        {
            return ApiRequest<NewUserCreatedModel,CreateDirectAccountNewUserModel>($"/user/create-direct-account", model, Method.Post);
        }

        /// <summary>
        /// Create a new direct billing user
        /// </summary>
        public Task<NewUserCreatedModel> CreateANewDirectBillingUserAsync(CreateDirectAccountNewUserModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NewUserCreatedModel,CreateDirectAccountNewUserModel>($"/user/create-direct-account", model, Method.Post, cancellationToken);
        }
    }
}
