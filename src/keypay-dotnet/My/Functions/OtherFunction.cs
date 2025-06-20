using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.Other;

namespace KeyPayV2.My.Functions
{
    public interface IOtherFunction
    {
        LeaveAccrualRuleModel RetrievesTheLeaveAccrualRuleAssociatedWithTheLeaveCategory(int businessId, int leaveCategoryId);
        Task<LeaveAccrualRuleModel> RetrievesTheLeaveAccrualRuleAssociatedWithTheLeaveCategoryAsync(int businessId, int leaveCategoryId, CancellationToken cancellationToken = default);
        void GetPaymentFilesByFinalisedPayRunId(int businessId);
        Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, CancellationToken cancellationToken = default);
        void GetPaymentFilesByFinalisedPayRunId(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request);
        Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default);
        List<MyBankModel> ListBanks();
        Task<List<MyBankModel>> ListBanksAsync(CancellationToken cancellationToken = default);
        MyEssStatutoryDetailsModel EssStatutoryDetails_Get(int employeeId);
        Task<MyEssStatutoryDetailsModel> EssStatutoryDetails_GetAsync(int employeeId, CancellationToken cancellationToken = default);
        NewUserCreatedModel CreateANewDirectBillingUser(CreateDirectAccountNewUserModel model);
        Task<NewUserCreatedModel> CreateANewDirectBillingUserAsync(CreateDirectAccountNewUserModel model, CancellationToken cancellationToken = default);
    }
    public class OtherFunction : BaseFunction, IOtherFunction
    {
        public OtherFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// retrieves the leave accrual rule associated with the leave category
        /// </summary>
        public LeaveAccrualRuleModel RetrievesTheLeaveAccrualRuleAssociatedWithTheLeaveCategory(int businessId, int leaveCategoryId)
        {
            return ApiRequest<LeaveAccrualRuleModel>($"/business/{businessId}/leavecategory/{leaveCategoryId}/LeaveAccrualRule", Method.Get);
        }

        /// <summary>
        /// retrieves the leave accrual rule associated with the leave category
        /// </summary>
        public Task<LeaveAccrualRuleModel> RetrievesTheLeaveAccrualRuleAssociatedWithTheLeaveCategoryAsync(int businessId, int leaveCategoryId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<LeaveAccrualRuleModel>($"/business/{businessId}/leavecategory/{leaveCategoryId}/LeaveAccrualRule", Method.Get, cancellationToken);
        }

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
        /// List banks
        /// </summary>
        public List<MyBankModel> ListBanks()
        {
            return ApiRequest<List<MyBankModel>>($"/bank", Method.Get);
        }

        /// <summary>
        /// List banks
        /// </summary>
        public Task<List<MyBankModel>> ListBanksAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyBankModel>>($"/bank", Method.Get, cancellationToken);
        }

        public MyEssStatutoryDetailsModel EssStatutoryDetails_Get(int employeeId)
        {
            return ApiRequest<MyEssStatutoryDetailsModel>($"/ess/{employeeId}/statutorydetails", Method.Get);
        }

        public Task<MyEssStatutoryDetailsModel> EssStatutoryDetails_GetAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssStatutoryDetailsModel>($"/ess/{employeeId}/statutorydetails", Method.Get, cancellationToken);
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
