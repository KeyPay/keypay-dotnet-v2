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
using KeyPayV2.Sg.Models.Other;

namespace KeyPayV2.Sg.Functions
{
    public interface IOtherFunction
    {
        LeaveAccrualRuleModel RetrievesTheLeaveAccrualRuleAssociatedWithTheLeaveCategory(int businessId, int leaveCategoryId);
        Task<LeaveAccrualRuleModel> RetrievesTheLeaveAccrualRuleAssociatedWithTheLeaveCategoryAsync(int businessId, int leaveCategoryId, CancellationToken cancellationToken = default);
        void GetPaymentFilesByFinalisedPayRunId(int businessId);
        Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, CancellationToken cancellationToken = default);
        void GetPaymentFilesByFinalisedPayRunId(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request);
        Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default);
        List<GiroBankModel> ListBanks();
        Task<List<GiroBankModel>> ListBanksAsync(CancellationToken cancellationToken = default);
        GiroBankBranchModel GetSpecificBankBranchDetails(GetSpecificBankBranchDetailsQueryModel request);
        Task<GiroBankBranchModel> GetSpecificBankBranchDetailsAsync(GetSpecificBankBranchDetailsQueryModel request, CancellationToken cancellationToken = default);
        List<GiroBankBranchModel> SgBank_Branches(SgBank_BranchesQueryModel request);
        Task<List<GiroBankBranchModel>> SgBank_BranchesAsync(SgBank_BranchesQueryModel request, CancellationToken cancellationToken = default);
        GiroBankModel GetSpecificBankDetails(GetSpecificBankDetailsQueryModel request);
        Task<GiroBankModel> GetSpecificBankDetailsAsync(GetSpecificBankDetailsQueryModel request, CancellationToken cancellationToken = default);
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
        /// List Banks
        /// </summary>
        /// <remarks>
        /// Lists all of the banks.
        /// </remarks>
        public List<GiroBankModel> ListBanks()
        {
            return ApiRequest<List<GiroBankModel>>($"/bank", Method.Get);
        }

        /// <summary>
        /// List Banks
        /// </summary>
        /// <remarks>
        /// Lists all of the banks.
        /// </remarks>
        public Task<List<GiroBankModel>> ListBanksAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<GiroBankModel>>($"/bank", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Specific Bank Branch Details
        /// </summary>
        /// <remarks>
        /// Search for bank branch based on a Bank Swift, Branch Code and Account Number.
        /// </remarks>
        public GiroBankBranchModel GetSpecificBankBranchDetails(GetSpecificBankBranchDetailsQueryModel request)
        {
            return ApiRequest<GiroBankBranchModel>($"/bank/branch?bankSwift={request.BankSwift}&branchCode={request.BranchCode}&accountNumber={request.AccountNumber}", Method.Get);
        }

        /// <summary>
        /// Get Specific Bank Branch Details
        /// </summary>
        /// <remarks>
        /// Search for bank branch based on a Bank Swift, Branch Code and Account Number.
        /// </remarks>
        public Task<GiroBankBranchModel> GetSpecificBankBranchDetailsAsync(GetSpecificBankBranchDetailsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<GiroBankBranchModel>($"/bank/branch?bankSwift={request.BankSwift}&branchCode={request.BranchCode}&accountNumber={request.AccountNumber}", Method.Get, cancellationToken);
        }

        public List<GiroBankBranchModel> SgBank_Branches(SgBank_BranchesQueryModel request)
        {
            return ApiRequest<List<GiroBankBranchModel>>($"/bank/branches?bankSwift={request.BankSwift}&accountNumber={request.AccountNumber}", Method.Get);
        }

        public Task<List<GiroBankBranchModel>> SgBank_BranchesAsync(SgBank_BranchesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<GiroBankBranchModel>>($"/bank/branches?bankSwift={request.BankSwift}&accountNumber={request.AccountNumber}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Specific Bank Details
        /// </summary>
        /// <remarks>
        /// Search for bank based on a Bank Swift
        /// </remarks>
        public GiroBankModel GetSpecificBankDetails(GetSpecificBankDetailsQueryModel request)
        {
            return ApiRequest<GiroBankModel>($"/bank/details?bankSwift={request.BankSwift}", Method.Get);
        }

        /// <summary>
        /// Get Specific Bank Details
        /// </summary>
        /// <remarks>
        /// Search for bank based on a Bank Swift
        /// </remarks>
        public Task<GiroBankModel> GetSpecificBankDetailsAsync(GetSpecificBankDetailsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<GiroBankModel>($"/bank/details?bankSwift={request.BankSwift}", Method.Get, cancellationToken);
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
