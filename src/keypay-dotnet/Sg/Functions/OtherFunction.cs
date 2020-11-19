using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.Other;

namespace KeyPayV2.Sg.Functions
{
    public class OtherFunction : BaseFunction
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
            return ApiRequest<List<GiroBankModel>>($"/bank");
        }

        /// <summary>
        /// Get Specific Bank Branch Details
        /// </summary>
        /// <remarks>
        /// Search for bank branch based on a Bank Swift, Branch Code and Account Number.
        /// </remarks>
        public GiroBankBranchModel GetSpecificBankBranchDetails(GetSpecificBankBranchDetailsQueryModel request)
        {
            return ApiRequest<GiroBankBranchModel>($"/bank/branch?bankSwift={request.BankSwift}&branchCode={request.BranchCode}&accountNumber={request.AccountNumber}");
        }

        public List<GiroBankBranchModel> SgBank_Branches(SgBank_BranchesQueryModel request)
        {
            return ApiRequest<List<GiroBankBranchModel>>($"/bank/branches?bankSwift={request.BankSwift}&accountNumber={request.AccountNumber}");
        }

        /// <summary>
        /// Get Specific Bank Details
        /// </summary>
        /// <remarks>
        /// Search for bank based on a Bank Swift
        /// </remarks>
        public GiroBankModel GetSpecificBankDetails(GetSpecificBankDetailsQueryModel request)
        {
            return ApiRequest<GiroBankModel>($"/bank/details?bankSwift={request.BankSwift}");
        }

        public SgPayRunDetailsModel SgPayRunDetails_Get(int businessId, int payRunId)
        {
            return ApiRequest<SgPayRunDetailsModel>($"/business/{businessId}/payrun/{payRunId}/details");
        }

        /// <summary>
        /// Get Payment Files by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the payment files for a finalised pay run with the specified Id.
        /// </remarks>
        public void GetPaymentFilesByFinalisedPayRunId(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request)
        {
            ApiRequest($"/business/{businessId}/report/paymentfile?payRunId={request.PayRunId}&paymentFileId={request.PaymentFileId}");
        }

        /// <summary>
        /// Get Pay Slips by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the pay slips for a finalised pay run with the specified Id.
        /// </remarks>
        public void GetPaySlipsByFinalisedPayRunId(int businessId, GetPaySlipsByFinalisedPayRunIdQueryModel request)
        {
            ApiRequest($"/business/{businessId}/report/payslip?payRunId={request.PayRunId}&employeeId={request.EmployeeId}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        public List<ShiftSwappingReportExportModel> ReportsShiftSwapping_Get(int businessId, ReportsShiftSwapping_GetQueryModel request)
        {
            return ApiRequest<List<ShiftSwappingReportExportModel>>($"/business/{businessId}/report/shiftswapping?fromEmployeeId={request.FromEmployeeId}&toEmployeeId={request.ToEmployeeId}&includeCosts={request.IncludeCosts}&statuses={request.Statuses}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        public List<TasksReportExportModel> ReportsTasksReport_Get(int businessId, ReportsTasksReport_GetQueryModel request)
        {
            return ApiRequest<List<TasksReportExportModel>>($"/business/{businessId}/report/tasks?employeeId={request.EmployeeId}&payRunId={request.PayRunId}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&payScheduleId={request.PayScheduleId}&status={request.Status}");
        }
    }
}
