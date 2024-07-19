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
        List<GiroBankModel> ListBanks();
        Task<List<GiroBankModel>> ListBanksAsync(CancellationToken cancellationToken = default);
        GiroBankBranchModel GetSpecificBankBranchDetails(GetSpecificBankBranchDetailsQueryModel request);
        Task<GiroBankBranchModel> GetSpecificBankBranchDetailsAsync(GetSpecificBankBranchDetailsQueryModel request, CancellationToken cancellationToken = default);
        List<GiroBankBranchModel> SgBank_Branches(SgBank_BranchesQueryModel request);
        Task<List<GiroBankBranchModel>> SgBank_BranchesAsync(SgBank_BranchesQueryModel request, CancellationToken cancellationToken = default);
        GiroBankModel GetSpecificBankDetails(GetSpecificBankDetailsQueryModel request);
        Task<GiroBankModel> GetSpecificBankDetailsAsync(GetSpecificBankDetailsQueryModel request, CancellationToken cancellationToken = default);
        SgPayRunDetailsModel SgPayRunDetails_Get(int businessId, int payRunId);
        Task<SgPayRunDetailsModel> SgPayRunDetails_GetAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        void GetPaymentFilesByFinalisedPayRunId(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request);
        Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default);
    }
    public class OtherFunction : BaseFunction, IOtherFunction
    {
        public OtherFunction(ApiRequestExecutor api) : base(api) {}

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

        public SgPayRunDetailsModel SgPayRunDetails_Get(int businessId, int payRunId)
        {
            return ApiRequest<SgPayRunDetailsModel>($"/business/{businessId}/payrun/{payRunId}/details", Method.Get);
        }

        public Task<SgPayRunDetailsModel> SgPayRunDetails_GetAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayRunDetailsModel>($"/business/{businessId}/payrun/{payRunId}/details", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Payment Files by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the payment files for a finalised pay run with the specified Id.
        /// </remarks>
        public void GetPaymentFilesByFinalisedPayRunId(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request)
        {
            ApiRequest($"/business/{businessId}/report/paymentfile?payRunId={request.PayRunId}&paymentFileId={request.PaymentFileId}", Method.Get);
        }

        /// <summary>
        /// Get Payment Files by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the payment files for a finalised pay run with the specified Id.
        /// </remarks>
        public Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/report/paymentfile?payRunId={request.PayRunId}&paymentFileId={request.PaymentFileId}", Method.Get, cancellationToken);
        }
    }
}
