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
using KeyPayV2.Sg.Models.Reporting;

namespace KeyPayV2.Sg.Functions
{
    public interface IReportingFunction
    {
        List<SgCostingReportApiModel> CostingReport(int businessId);
        Task<List<SgCostingReportApiModel>> CostingReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<SgCostingReportApiModel> CostingReport(int businessId, CostingReportQueryModel request);
        Task<List<SgCostingReportApiModel>> CostingReportAsync(int businessId, CostingReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] PayRunAuditReport(int businessId, int payRunId);
        Task<byte[]> PayRunAuditReportAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        byte[] PayRunAuditReport(int businessId, int payRunId, PayRunAuditReportQueryModel request);
        Task<byte[]> PayRunAuditReportAsync(int businessId, int payRunId, PayRunAuditReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] DeprecatedPayRunAuditReport(int businessId, int payRunId);
        Task<byte[]> DeprecatedPayRunAuditReportAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        byte[] DeprecatedPayRunAuditReport(int businessId, int payRunId, DeprecatedPayRunAuditReportQueryModel request);
        Task<byte[]> DeprecatedPayRunAuditReportAsync(int businessId, int payRunId, DeprecatedPayRunAuditReportQueryModel request, CancellationToken cancellationToken = default);
        List<SgCpfApiModel> CpfLodgementReport(int businessId);
        Task<List<SgCpfApiModel>> CpfLodgementReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<SgCpfApiModel> CpfLodgementReport(int businessId, CpfLodgementReportQueryModel request);
        Task<List<SgCpfApiModel>> CpfLodgementReportAsync(int businessId, CpfLodgementReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] DeductionsReportAsExcel(int businessId);
        Task<byte[]> DeductionsReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] DeductionsReportAsExcel(int businessId, DeductionsReportAsExcelQueryModel request);
        Task<byte[]> DeductionsReportAsExcelAsync(int businessId, DeductionsReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        List<SgDetailedActivityReportExportModel> DetailedActivityReport(int businessId);
        Task<List<SgDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<SgDetailedActivityReportExportModel> DetailedActivityReport(int businessId, DetailedActivityReportQueryModel request);
        Task<List<SgDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, DetailedActivityReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] DetailedActivityReportAsExcel(int businessId);
        Task<byte[]> DetailedActivityReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] DetailedActivityReportAsExcel(int businessId, DetailedActivityReportAsExcelQueryModel request);
        Task<byte[]> DetailedActivityReportAsExcelAsync(int businessId, DetailedActivityReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        byte[] DeprecatedDetailedActivityReportAsExcel(int businessId);
        Task<byte[]> DeprecatedDetailedActivityReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] DeprecatedDetailedActivityReportAsExcel(int businessId, DeprecatedDetailedActivityReportAsExcelQueryModel request);
        Task<byte[]> DeprecatedDetailedActivityReportAsExcelAsync(int businessId, DeprecatedDetailedActivityReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        List<EmployeeDetailsReportField> EmployeeDetailsReportFields(int businessId);
        Task<List<EmployeeDetailsReportField>> EmployeeDetailsReportFieldsAsync(int businessId, CancellationToken cancellationToken = default);
        List<SgPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId);
        Task<List<SgPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<SgPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId, EmployeePaymentHistoryReportQueryModel request);
        Task<List<SgPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, EmployeePaymentHistoryReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] EmployeePaymentHistoryReportAsExcel(int businessId);
        Task<byte[]> EmployeePaymentHistoryReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] EmployeePaymentHistoryReportAsExcel(int businessId, EmployeePaymentHistoryReportAsExcelQueryModel request);
        Task<byte[]> EmployeePaymentHistoryReportAsExcelAsync(int businessId, EmployeePaymentHistoryReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        List<SgGrossToNetResponseModel> GrossToNetReport(int businessId);
        Task<List<SgGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<SgGrossToNetResponseModel> GrossToNetReport(int businessId, GrossToNetReportQueryModel request);
        Task<List<SgGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, GrossToNetReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] GrossToNetReportAsExcel(int businessId);
        Task<byte[]> GrossToNetReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] GrossToNetReportAsExcel(int businessId, GrossToNetReportAsExcelQueryModel request);
        Task<byte[]> GrossToNetReportAsExcelAsync(int businessId, GrossToNetReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        List<SgLeaveBalancesExportModel> LeaveBalancesReport(int businessId);
        Task<List<SgLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<SgLeaveBalancesExportModel> LeaveBalancesReport(int businessId, LeaveBalancesReportQueryModel request);
        Task<List<SgLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, LeaveBalancesReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] LeaveBalancesReportAsExcel(int businessId);
        Task<byte[]> LeaveBalancesReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] LeaveBalancesReportAsExcel(int businessId, LeaveBalancesReportAsExcelQueryModel request);
        Task<byte[]> LeaveBalancesReportAsExcelAsync(int businessId, LeaveBalancesReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        List<LeaveLiabilityExportModel> LeaveLiabilityReport(int businessId);
        Task<List<LeaveLiabilityExportModel>> LeaveLiabilityReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<LeaveLiabilityExportModel> LeaveLiabilityReport(int businessId, LeaveLiabilityReportQueryModel request);
        Task<List<LeaveLiabilityExportModel>> LeaveLiabilityReportAsync(int businessId, LeaveLiabilityReportQueryModel request, CancellationToken cancellationToken = default);
        ReportLeaveLiabilityPreparationResponse PrepareLeaveLiabilityReport(int businessId, ReportLeaveLiabilityRequestModel request);
        Task<ReportLeaveLiabilityPreparationResponse> PrepareLeaveLiabilityReportAsync(int businessId, ReportLeaveLiabilityRequestModel request, CancellationToken cancellationToken = default);
        byte[] LeaveLiabilityReportAsExcel(int businessId);
        Task<byte[]> LeaveLiabilityReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] LeaveLiabilityReportAsExcel(int businessId, LeaveLiabilityReportAsExcelQueryModel request);
        Task<byte[]> LeaveLiabilityReportAsExcelAsync(int businessId, LeaveLiabilityReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        List<SgPayCategoriesModel> PayCategoriesReport(int businessId);
        Task<List<SgPayCategoriesModel>> PayCategoriesReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<SgPayCategoriesModel> PayCategoriesReport(int businessId, PayCategoriesReportQueryModel request);
        Task<List<SgPayCategoriesModel>> PayCategoriesReportAsync(int businessId, PayCategoriesReportQueryModel request, CancellationToken cancellationToken = default);
        List<SgPayRunInclusionExportModel> PayRunInclusionsReport(int businessId);
        Task<List<SgPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<SgPayRunInclusionExportModel> PayRunInclusionsReport(int businessId, PayRunInclusionsReportQueryModel request);
        Task<List<SgPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, PayRunInclusionsReportQueryModel request, CancellationToken cancellationToken = default);
        List<SgRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId);
        Task<List<SgRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<SgRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId, RosterVsTimesheetComparisonReportQueryModel request);
        Task<List<SgRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, RosterVsTimesheetComparisonReportQueryModel request, CancellationToken cancellationToken = default);
        List<SgTimesheetExportModel> TimesheetReport(int businessId);
        Task<List<SgTimesheetExportModel>> TimesheetReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<SgTimesheetExportModel> TimesheetReport(int businessId, TimesheetReportQueryModel request);
        Task<List<SgTimesheetExportModel>> TimesheetReportAsync(int businessId, TimesheetReportQueryModel request, CancellationToken cancellationToken = default);
        List<SgWithholdingModel> WithholdingReport(int businessId);
        Task<List<SgWithholdingModel>> WithholdingReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<SgWithholdingModel> WithholdingReport(int businessId, WithholdingReportQueryModel request);
        Task<List<SgWithholdingModel>> WithholdingReportAsync(int businessId, WithholdingReportQueryModel request, CancellationToken cancellationToken = default);
        List<EmployeeDetailsAuditReportApiModel> EmployeeAuditReport(int businessId);
        Task<List<EmployeeDetailsAuditReportApiModel>> EmployeeAuditReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<EmployeeDetailsAuditReportApiModel> EmployeeAuditReport(int businessId, EmployeeAuditReportQueryModel request);
        Task<List<EmployeeDetailsAuditReportApiModel>> EmployeeAuditReportAsync(int businessId, EmployeeAuditReportQueryModel request, CancellationToken cancellationToken = default);
        List<dynamic> EmployeeDetailsReport(int businessId);
        Task<List<dynamic>> EmployeeDetailsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<dynamic> EmployeeDetailsReport(int businessId, EmployeeDetailsReportQueryModel request);
        Task<List<dynamic>> EmployeeDetailsReportAsync(int businessId, EmployeeDetailsReportQueryModel request, CancellationToken cancellationToken = default);
        List<dynamic> EmployeeDetailsReport(int businessId, EmployeeDetailsReportRequestModel model);
        Task<List<dynamic>> EmployeeDetailsReportAsync(int businessId, EmployeeDetailsReportRequestModel model, CancellationToken cancellationToken = default);
        List<BirthdayReportExportModel> BirthdayReport(int businessId);
        Task<List<BirthdayReportExportModel>> BirthdayReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<BirthdayReportExportModel> BirthdayReport(int businessId, BirthdayReportQueryModel request);
        Task<List<BirthdayReportExportModel>> BirthdayReportAsync(int businessId, BirthdayReportQueryModel request, CancellationToken cancellationToken = default);
        List<DeductionsReportExportModel> DeductionsReport(int businessId);
        Task<List<DeductionsReportExportModel>> DeductionsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<DeductionsReportExportModel> DeductionsReport(int businessId, DeductionsReportQueryModel request);
        Task<List<DeductionsReportExportModel>> DeductionsReportAsync(int businessId, DeductionsReportQueryModel request, CancellationToken cancellationToken = default);
        List<DocumentAcknowledgementsReportExportModel> DocumentAcknowledgementsReport(int businessId);
        Task<List<DocumentAcknowledgementsReportExportModel>> DocumentAcknowledgementsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<DocumentAcknowledgementsReportExportModel> DocumentAcknowledgementsReport(int businessId, DocumentAcknowledgementsReportQueryModel request);
        Task<List<DocumentAcknowledgementsReportExportModel>> DocumentAcknowledgementsReportAsync(int businessId, DocumentAcknowledgementsReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] JournalReport(int businessId);
        Task<byte[]> JournalReportAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] JournalReport(int businessId, JournalReportQueryModel request);
        Task<byte[]> JournalReportAsync(int businessId, JournalReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] PayRunVarianceReport(int businessId);
        Task<byte[]> PayRunVarianceReportAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] PayRunVarianceReport(int businessId, PayRunVarianceReportQueryModel request);
        Task<byte[]> PayRunVarianceReportAsync(int businessId, PayRunVarianceReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] DeprecatedPayRunVarianceReport(int businessId);
        Task<byte[]> DeprecatedPayRunVarianceReportAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] DeprecatedPayRunVarianceReport(int businessId, DeprecatedPayRunVarianceReportQueryModel request);
        Task<byte[]> DeprecatedPayRunVarianceReportAsync(int businessId, DeprecatedPayRunVarianceReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] GetPaySlipsByFinalisedPayRunId(int businessId);
        Task<byte[]> GetPaySlipsByFinalisedPayRunIdAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] GetPaySlipsByFinalisedPayRunId(int businessId, GetPaySlipsByFinalisedPayRunIdQueryModel request);
        Task<byte[]> GetPaySlipsByFinalisedPayRunIdAsync(int businessId, GetPaySlipsByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default);
        List<ShiftSwappingReportExportModel> GetShiftSwappingReportByBusinessId(int businessId);
        Task<List<ShiftSwappingReportExportModel>> GetShiftSwappingReportByBusinessIdAsync(int businessId, CancellationToken cancellationToken = default);
        List<ShiftSwappingReportExportModel> GetShiftSwappingReportByBusinessId(int businessId, GetShiftSwappingReportByBusinessIdQueryModel request);
        Task<List<ShiftSwappingReportExportModel>> GetShiftSwappingReportByBusinessIdAsync(int businessId, GetShiftSwappingReportByBusinessIdQueryModel request, CancellationToken cancellationToken = default);
        List<TasksReportExportModel> GetTasksByBusinessId(int businessId);
        Task<List<TasksReportExportModel>> GetTasksByBusinessIdAsync(int businessId, CancellationToken cancellationToken = default);
        List<TasksReportExportModel> GetTasksByBusinessId(int businessId, GetTasksByBusinessIdQueryModel request);
        Task<List<TasksReportExportModel>> GetTasksByBusinessIdAsync(int businessId, GetTasksByBusinessIdQueryModel request, CancellationToken cancellationToken = default);
    }
    public class ReportingFunction : BaseFunction, IReportingFunction
    {
        public ReportingFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public List<SgCostingReportApiModel> CostingReport(int businessId)
        {
            return ApiRequest<List<SgCostingReportApiModel>>($"/business/{businessId}/report/costing", Method.Get);
        }

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public Task<List<SgCostingReportApiModel>> CostingReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgCostingReportApiModel>>($"/business/{businessId}/report/costing", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public List<SgCostingReportApiModel> CostingReport(int businessId, CostingReportQueryModel request)
        {
            return ApiRequest<List<SgCostingReportApiModel>>($"/business/{businessId}/report/costing?ShowZeroPayCategories={request.ShowZeroPayCategories}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public Task<List<SgCostingReportApiModel>> CostingReportAsync(int businessId, CostingReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgCostingReportApiModel>>($"/business/{businessId}/report/costing?ShowZeroPayCategories={request.ShowZeroPayCategories}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Audit Report
        /// </summary>
        /// <remarks>
        /// Pay run audit report
        /// </remarks>
        public byte[] PayRunAuditReport(int businessId, int payRunId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/payrunaudit/{payRunId}/xlsx", Method.Get);
        }

        /// <summary>
        /// Pay Run Audit Report
        /// </summary>
        /// <remarks>
        /// Pay run audit report
        /// </remarks>
        public Task<byte[]> PayRunAuditReportAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/payrunaudit/{payRunId}/xlsx", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Audit Report
        /// </summary>
        /// <remarks>
        /// Pay run audit report
        /// </remarks>
        public byte[] PayRunAuditReport(int businessId, int payRunId, PayRunAuditReportQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/payrunaudit/{payRunId}/xlsx?SingleEmployeeWorksheet={request.SingleEmployeeWorksheet}&ShowAllSummaryDetails={request.ShowAllSummaryDetails}&ShowAllEmployeeDetails={request.ShowAllEmployeeDetails}", Method.Get);
        }

        /// <summary>
        /// Pay Run Audit Report
        /// </summary>
        /// <remarks>
        /// Pay run audit report
        /// </remarks>
        public Task<byte[]> PayRunAuditReportAsync(int businessId, int payRunId, PayRunAuditReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/payrunaudit/{payRunId}/xlsx?SingleEmployeeWorksheet={request.SingleEmployeeWorksheet}&ShowAllSummaryDetails={request.ShowAllSummaryDetails}&ShowAllEmployeeDetails={request.ShowAllEmployeeDetails}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Deprecated Pay Run Audit Report
        /// </summary>
        /// <remarks>
        /// Deprecated: Use /xlsx instead
        /// </remarks>
        public byte[] DeprecatedPayRunAuditReport(int businessId, int payRunId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/payrunaudit/{payRunId}/xlxs", Method.Get);
        }

        /// <summary>
        /// Deprecated Pay Run Audit Report
        /// </summary>
        /// <remarks>
        /// Deprecated: Use /xlsx instead
        /// </remarks>
        public Task<byte[]> DeprecatedPayRunAuditReportAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/payrunaudit/{payRunId}/xlxs", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Deprecated Pay Run Audit Report
        /// </summary>
        /// <remarks>
        /// Deprecated: Use /xlsx instead
        /// </remarks>
        public byte[] DeprecatedPayRunAuditReport(int businessId, int payRunId, DeprecatedPayRunAuditReportQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/payrunaudit/{payRunId}/xlxs?SingleEmployeeWorksheet={request.SingleEmployeeWorksheet}&ShowAllSummaryDetails={request.ShowAllSummaryDetails}&ShowAllEmployeeDetails={request.ShowAllEmployeeDetails}", Method.Get);
        }

        /// <summary>
        /// Deprecated Pay Run Audit Report
        /// </summary>
        /// <remarks>
        /// Deprecated: Use /xlsx instead
        /// </remarks>
        public Task<byte[]> DeprecatedPayRunAuditReportAsync(int businessId, int payRunId, DeprecatedPayRunAuditReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/payrunaudit/{payRunId}/xlxs?SingleEmployeeWorksheet={request.SingleEmployeeWorksheet}&ShowAllSummaryDetails={request.ShowAllSummaryDetails}&ShowAllEmployeeDetails={request.ShowAllEmployeeDetails}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// CPF lodgement report
        /// </summary>
        /// <remarks>
        /// Generates a CPF lodgement report
        /// </remarks>
        public List<SgCpfApiModel> CpfLodgementReport(int businessId)
        {
            return ApiRequest<List<SgCpfApiModel>>($"/business/{businessId}/report/cpf", Method.Get);
        }

        /// <summary>
        /// CPF lodgement report
        /// </summary>
        /// <remarks>
        /// Generates a CPF lodgement report
        /// </remarks>
        public Task<List<SgCpfApiModel>> CpfLodgementReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgCpfApiModel>>($"/business/{businessId}/report/cpf", Method.Get, cancellationToken);
        }

        /// <summary>
        /// CPF lodgement report
        /// </summary>
        /// <remarks>
        /// Generates a CPF lodgement report
        /// </remarks>
        public List<SgCpfApiModel> CpfLodgementReport(int businessId, CpfLodgementReportQueryModel request)
        {
            return ApiRequest<List<SgCpfApiModel>>($"/business/{businessId}/report/cpf?EmployeeId={request.EmployeeId}&PaymentTypeId={request.PaymentTypeId}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// CPF lodgement report
        /// </summary>
        /// <remarks>
        /// Generates a CPF lodgement report
        /// </remarks>
        public Task<List<SgCpfApiModel>> CpfLodgementReportAsync(int businessId, CpfLodgementReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgCpfApiModel>>($"/business/{businessId}/report/cpf?EmployeeId={request.EmployeeId}&PaymentTypeId={request.PaymentTypeId}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Deductions Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Deductions Report as an Excel file.
        /// </remarks>
        public byte[] DeductionsReportAsExcel(int businessId)
        {
            return ApiByteArrayRequest($"/api/payroll/internal/business/{businessId}/report/deductions/xlsx", Method.Get);
        }

        /// <summary>
        /// Deductions Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Deductions Report as an Excel file.
        /// </remarks>
        public Task<byte[]> DeductionsReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/api/payroll/internal/business/{businessId}/report/deductions/xlsx", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Deductions Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Deductions Report as an Excel file.
        /// </remarks>
        public byte[] DeductionsReportAsExcel(int businessId, DeductionsReportAsExcelQueryModel request)
        {
            return ApiByteArrayRequest($"/api/payroll/internal/business/{businessId}/report/deductions/xlsx?PayRunId={request.PayRunId}&EmployeeId={request.EmployeeId}&PayScheduleId={request.PayScheduleId}&LocationId={request.LocationId}&DeductionCategoryId={request.DeductionCategoryId}&FromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ToDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&FilterType={request.FilterType}", Method.Get);
        }

        /// <summary>
        /// Deductions Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Deductions Report as an Excel file.
        /// </remarks>
        public Task<byte[]> DeductionsReportAsExcelAsync(int businessId, DeductionsReportAsExcelQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/api/payroll/internal/business/{businessId}/report/deductions/xlsx?PayRunId={request.PayRunId}&EmployeeId={request.EmployeeId}&PayScheduleId={request.PayScheduleId}&LocationId={request.LocationId}&DeductionCategoryId={request.DeductionCategoryId}&FromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ToDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&FilterType={request.FilterType}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public List<SgDetailedActivityReportExportModel> DetailedActivityReport(int businessId)
        {
            return ApiRequest<List<SgDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity", Method.Get);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public Task<List<SgDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public List<SgDetailedActivityReportExportModel> DetailedActivityReport(int businessId, DetailedActivityReportQueryModel request)
        {
            return ApiRequest<List<SgDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public Task<List<SgDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, DetailedActivityReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Detailed Activity Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Detailed Activity Report as an Excel file.
        /// </remarks>
        public byte[] DetailedActivityReportAsExcel(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/detailedactivity/xlsx", Method.Get);
        }

        /// <summary>
        /// Detailed Activity Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Detailed Activity Report as an Excel file.
        /// </remarks>
        public Task<byte[]> DetailedActivityReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/detailedactivity/xlsx", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Detailed Activity Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Detailed Activity Report as an Excel file.
        /// </remarks>
        public byte[] DetailedActivityReportAsExcel(int businessId, DetailedActivityReportAsExcelQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/detailedactivity/xlsx?FromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ToDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&GroupBy={request.GroupBy}&FilterType={request.FilterType}&PayRunId={request.PayRunId}&PayScheduleId={request.PayScheduleId}{ConvertEnumerableToQueryString("LocationsIds", request.LocationsIds?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("EmployeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&ShowLocationTotalsOnly={request.ShowLocationTotalsOnly}&IncludeEmployeePayRunBreakdown={request.IncludeEmployeePayRunBreakdown}", Method.Get);
        }

        /// <summary>
        /// Detailed Activity Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Detailed Activity Report as an Excel file.
        /// </remarks>
        public Task<byte[]> DetailedActivityReportAsExcelAsync(int businessId, DetailedActivityReportAsExcelQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/detailedactivity/xlsx?FromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ToDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&GroupBy={request.GroupBy}&FilterType={request.FilterType}&PayRunId={request.PayRunId}&PayScheduleId={request.PayScheduleId}{ConvertEnumerableToQueryString("LocationsIds", request.LocationsIds?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("EmployeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&ShowLocationTotalsOnly={request.ShowLocationTotalsOnly}&IncludeEmployeePayRunBreakdown={request.IncludeEmployeePayRunBreakdown}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Deprecated Detailed Activity Report as Excel
        /// </summary>
        /// <remarks>
        /// Deprecated: use /xlsx instead.
        /// </remarks>
        public byte[] DeprecatedDetailedActivityReportAsExcel(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/detailedactivity/xlxs", Method.Get);
        }

        /// <summary>
        /// Deprecated Detailed Activity Report as Excel
        /// </summary>
        /// <remarks>
        /// Deprecated: use /xlsx instead.
        /// </remarks>
        public Task<byte[]> DeprecatedDetailedActivityReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/detailedactivity/xlxs", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Deprecated Detailed Activity Report as Excel
        /// </summary>
        /// <remarks>
        /// Deprecated: use /xlsx instead.
        /// </remarks>
        public byte[] DeprecatedDetailedActivityReportAsExcel(int businessId, DeprecatedDetailedActivityReportAsExcelQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/detailedactivity/xlxs?FromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ToDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&GroupBy={request.GroupBy}&FilterType={request.FilterType}&PayRunId={request.PayRunId}&PayScheduleId={request.PayScheduleId}{ConvertEnumerableToQueryString("LocationsIds", request.LocationsIds?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("EmployeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&ShowLocationTotalsOnly={request.ShowLocationTotalsOnly}&IncludeEmployeePayRunBreakdown={request.IncludeEmployeePayRunBreakdown}", Method.Get);
        }

        /// <summary>
        /// Deprecated Detailed Activity Report as Excel
        /// </summary>
        /// <remarks>
        /// Deprecated: use /xlsx instead.
        /// </remarks>
        public Task<byte[]> DeprecatedDetailedActivityReportAsExcelAsync(int businessId, DeprecatedDetailedActivityReportAsExcelQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/detailedactivity/xlxs?FromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ToDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&GroupBy={request.GroupBy}&FilterType={request.FilterType}&PayRunId={request.PayRunId}&PayScheduleId={request.PayScheduleId}{ConvertEnumerableToQueryString("LocationsIds", request.LocationsIds?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("EmployeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&ShowLocationTotalsOnly={request.ShowLocationTotalsOnly}&IncludeEmployeePayRunBreakdown={request.IncludeEmployeePayRunBreakdown}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Details Report Fields
        /// </summary>
        /// <remarks>
        /// Gets the fields for the Employee Details Report.
        /// </remarks>
        public List<EmployeeDetailsReportField> EmployeeDetailsReportFields(int businessId)
        {
            return ApiRequest<List<EmployeeDetailsReportField>>($"/business/{businessId}/report/employeedetails/fields", Method.Get);
        }

        /// <summary>
        /// Employee Details Report Fields
        /// </summary>
        /// <remarks>
        /// Gets the fields for the Employee Details Report.
        /// </remarks>
        public Task<List<EmployeeDetailsReportField>> EmployeeDetailsReportFieldsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDetailsReportField>>($"/business/{businessId}/report/employeedetails/fields", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public List<SgPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId)
        {
            return ApiRequest<List<SgPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory", Method.Get);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public Task<List<SgPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public List<SgPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId, EmployeePaymentHistoryReportQueryModel request)
        {
            return ApiRequest<List<SgPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?EmployeeId={request.EmployeeId}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public Task<List<SgPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, EmployeePaymentHistoryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?EmployeeId={request.EmployeeId}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Payment History Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report as an Excel file.
        /// </remarks>
        public byte[] EmployeePaymentHistoryReportAsExcel(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/paymenthistory/xlsx", Method.Get);
        }

        /// <summary>
        /// Employee Payment History Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report as an Excel file.
        /// </remarks>
        public Task<byte[]> EmployeePaymentHistoryReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/paymenthistory/xlsx", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Payment History Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report as an Excel file.
        /// </remarks>
        public byte[] EmployeePaymentHistoryReportAsExcel(int businessId, EmployeePaymentHistoryReportAsExcelQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/paymenthistory/xlsx?FilterType={request.FilterType}&PayRunId={request.PayRunId}&EmployeeId={request.EmployeeId}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Employee Payment History Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report as an Excel file.
        /// </remarks>
        public Task<byte[]> EmployeePaymentHistoryReportAsExcelAsync(int businessId, EmployeePaymentHistoryReportAsExcelQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/paymenthistory/xlsx?FilterType={request.FilterType}&PayRunId={request.PayRunId}&EmployeeId={request.EmployeeId}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public List<SgGrossToNetResponseModel> GrossToNetReport(int businessId)
        {
            return ApiRequest<List<SgGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet", Method.Get);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public Task<List<SgGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public List<SgGrossToNetResponseModel> GrossToNetReport(int businessId, GrossToNetReportQueryModel request)
        {
            return ApiRequest<List<SgGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?EmployeeId={request.EmployeeId}{ConvertEnumerableToQueryString("PayCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&GroupBy={request.GroupBy}&PayRunId={request.PayRunId}&FilterType={request.FilterType}&IncludeExpenses={request.IncludeExpenses}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public Task<List<SgGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, GrossToNetReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?EmployeeId={request.EmployeeId}{ConvertEnumerableToQueryString("PayCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&GroupBy={request.GroupBy}&PayRunId={request.PayRunId}&FilterType={request.FilterType}&IncludeExpenses={request.IncludeExpenses}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Gross To Net Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report as an Excel file.
        /// </remarks>
        public byte[] GrossToNetReportAsExcel(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/grosstonet/xlsx", Method.Get);
        }

        /// <summary>
        /// Gross To Net Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report as an Excel file.
        /// </remarks>
        public Task<byte[]> GrossToNetReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/grosstonet/xlsx", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Gross To Net Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report as an Excel file.
        /// </remarks>
        public byte[] GrossToNetReportAsExcel(int businessId, GrossToNetReportAsExcelQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/grosstonet/xlsx?EmployeeId={request.EmployeeId}{ConvertEnumerableToQueryString("PayCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&GroupBy={request.GroupBy}&PayRunId={request.PayRunId}&FilterType={request.FilterType}&IncludeExpenses={request.IncludeExpenses}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Gross To Net Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report as an Excel file.
        /// </remarks>
        public Task<byte[]> GrossToNetReportAsExcelAsync(int businessId, GrossToNetReportAsExcelQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/grosstonet/xlsx?EmployeeId={request.EmployeeId}{ConvertEnumerableToQueryString("PayCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&GroupBy={request.GroupBy}&PayRunId={request.PayRunId}&FilterType={request.FilterType}&IncludeExpenses={request.IncludeExpenses}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public List<SgLeaveBalancesExportModel> LeaveBalancesReport(int businessId)
        {
            return ApiRequest<List<SgLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances", Method.Get);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public Task<List<SgLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public List<SgLeaveBalancesExportModel> LeaveBalancesReport(int businessId, LeaveBalancesReportQueryModel request)
        {
            return ApiRequest<List<SgLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?LocationId={request.LocationId}&LeaveTypeId={request.LeaveTypeId}&GroupBy={request.GroupBy}&EmployingEntityId={request.EmployingEntityId}&AsAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public Task<List<SgLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, LeaveBalancesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?LocationId={request.LocationId}&LeaveTypeId={request.LeaveTypeId}&GroupBy={request.GroupBy}&EmployingEntityId={request.EmployingEntityId}&AsAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Balances Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Leave Balances Report as an Excel file.
        /// </remarks>
        public byte[] LeaveBalancesReportAsExcel(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/leavebalances/xlsx", Method.Get);
        }

        /// <summary>
        /// Leave Balances Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Leave Balances Report as an Excel file.
        /// </remarks>
        public Task<byte[]> LeaveBalancesReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/leavebalances/xlsx", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Balances Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Leave Balances Report as an Excel file.
        /// </remarks>
        public byte[] LeaveBalancesReportAsExcel(int businessId, LeaveBalancesReportAsExcelQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/leavebalances/xlsx?FilterType={request.FilterType}&AsAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayRunId={request.PayRunId}&GroupBy={request.GroupBy}&LocationId={request.LocationId}{ConvertEnumerableToQueryString("LeaveTypeIds", request.LeaveTypeIds?.Select(x => x.ToString()))}&EmployingEntityId={request.EmployingEntityId}&HideLeaveValues={request.HideLeaveValues}", Method.Get);
        }

        /// <summary>
        /// Leave Balances Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Leave Balances Report as an Excel file.
        /// </remarks>
        public Task<byte[]> LeaveBalancesReportAsExcelAsync(int businessId, LeaveBalancesReportAsExcelQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/leavebalances/xlsx?FilterType={request.FilterType}&AsAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayRunId={request.PayRunId}&GroupBy={request.GroupBy}&LocationId={request.LocationId}{ConvertEnumerableToQueryString("LeaveTypeIds", request.LeaveTypeIds?.Select(x => x.ToString()))}&EmployingEntityId={request.EmployingEntityId}&HideLeaveValues={request.HideLeaveValues}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Liability Report
        /// </summary>
        /// <remarks>
        /// Generates a leave liability report.
        /// </remarks>
        public List<LeaveLiabilityExportModel> LeaveLiabilityReport(int businessId)
        {
            return ApiRequest<List<LeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability", Method.Get);
        }

        /// <summary>
        /// Leave Liability Report
        /// </summary>
        /// <remarks>
        /// Generates a leave liability report.
        /// </remarks>
        public Task<List<LeaveLiabilityExportModel>> LeaveLiabilityReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Liability Report
        /// </summary>
        /// <remarks>
        /// Generates a leave liability report.
        /// </remarks>
        public List<LeaveLiabilityExportModel> LeaveLiabilityReport(int businessId, LeaveLiabilityReportQueryModel request)
        {
            return ApiRequest<List<LeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability?JobId={request.JobId}&FilterType={request.FilterType}&LocationId={request.LocationId}&LeaveTypeId={request.LeaveTypeId}&IncludeApprovedLeave={request.IncludeApprovedLeave}&AsAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&EmployingEntityId={request.EmployingEntityId}&PayRunId={request.PayRunId}{ConvertEnumerableToQueryString("LeaveTypeIds", request.LeaveTypeIds?.Select(x => x.ToString()))}&GroupBy={request.GroupBy}", Method.Get);
        }

        /// <summary>
        /// Leave Liability Report
        /// </summary>
        /// <remarks>
        /// Generates a leave liability report.
        /// </remarks>
        public Task<List<LeaveLiabilityExportModel>> LeaveLiabilityReportAsync(int businessId, LeaveLiabilityReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability?JobId={request.JobId}&FilterType={request.FilterType}&LocationId={request.LocationId}&LeaveTypeId={request.LeaveTypeId}&IncludeApprovedLeave={request.IncludeApprovedLeave}&AsAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&EmployingEntityId={request.EmployingEntityId}&PayRunId={request.PayRunId}{ConvertEnumerableToQueryString("LeaveTypeIds", request.LeaveTypeIds?.Select(x => x.ToString()))}&GroupBy={request.GroupBy}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Prepare Leave Liability report
        /// </summary>
        /// <remarks>
        /// Prepare Leave Liability Report job.
        /// </remarks>
        public ReportLeaveLiabilityPreparationResponse PrepareLeaveLiabilityReport(int businessId, ReportLeaveLiabilityRequestModel request)
        {
            return ApiRequest<ReportLeaveLiabilityPreparationResponse,ReportLeaveLiabilityRequestModel>($"/business/{businessId}/report/leaveliability/preparation", request, Method.Post);
        }

        /// <summary>
        /// Prepare Leave Liability report
        /// </summary>
        /// <remarks>
        /// Prepare Leave Liability Report job.
        /// </remarks>
        public Task<ReportLeaveLiabilityPreparationResponse> PrepareLeaveLiabilityReportAsync(int businessId, ReportLeaveLiabilityRequestModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ReportLeaveLiabilityPreparationResponse,ReportLeaveLiabilityRequestModel>($"/business/{businessId}/report/leaveliability/preparation", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Leave Liability report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Leave Liability Report as an Excel file.
        /// </remarks>
        public byte[] LeaveLiabilityReportAsExcel(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/leaveliability/xlsx", Method.Get);
        }

        /// <summary>
        /// Leave Liability report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Leave Liability Report as an Excel file.
        /// </remarks>
        public Task<byte[]> LeaveLiabilityReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/leaveliability/xlsx", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Liability report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Leave Liability Report as an Excel file.
        /// </remarks>
        public byte[] LeaveLiabilityReportAsExcel(int businessId, LeaveLiabilityReportAsExcelQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/leaveliability/xlsx?jobId={request.JobId}", Method.Get);
        }

        /// <summary>
        /// Leave Liability report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a Leave Liability Report as an Excel file.
        /// </remarks>
        public Task<byte[]> LeaveLiabilityReportAsExcelAsync(int businessId, LeaveLiabilityReportAsExcelQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/leaveliability/xlsx?jobId={request.JobId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public List<SgPayCategoriesModel> PayCategoriesReport(int businessId)
        {
            return ApiRequest<List<SgPayCategoriesModel>>($"/business/{businessId}/report/paycategories", Method.Get);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public Task<List<SgPayCategoriesModel>> PayCategoriesReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgPayCategoriesModel>>($"/business/{businessId}/report/paycategories", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public List<SgPayCategoriesModel> PayCategoriesReport(int businessId, PayCategoriesReportQueryModel request)
        {
            return ApiRequest<List<SgPayCategoriesModel>>($"/business/{businessId}/report/paycategories?PayScheduleId={request.PayScheduleId}&EmployeeId={request.EmployeeId}&GroupByEarningsLocation={request.GroupByEarningsLocation}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public Task<List<SgPayCategoriesModel>> PayCategoriesReportAsync(int businessId, PayCategoriesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgPayCategoriesModel>>($"/business/{businessId}/report/paycategories?PayScheduleId={request.PayScheduleId}&EmployeeId={request.EmployeeId}&GroupByEarningsLocation={request.GroupByEarningsLocation}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public List<SgPayRunInclusionExportModel> PayRunInclusionsReport(int businessId)
        {
            return ApiRequest<List<SgPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions", Method.Get);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public Task<List<SgPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public List<SgPayRunInclusionExportModel> PayRunInclusionsReport(int businessId, PayRunInclusionsReportQueryModel request)
        {
            return ApiRequest<List<SgPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?EmployeeId={request.EmployeeId}&Status={request.Status}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public Task<List<SgPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, PayRunInclusionsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?EmployeeId={request.EmployeeId}&Status={request.Status}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public List<SgRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId)
        {
            return ApiRequest<List<SgRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison", Method.Get);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public Task<List<SgRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public List<SgRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId, RosterVsTimesheetComparisonReportQueryModel request)
        {
            return ApiRequest<List<SgRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?EmploymentTypeId={request.EmploymentTypeId}&EmployeeId={request.EmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("TimesheetStatuses", request.TimesheetStatuses?.Select(x => x.ToString()))}&WorkTypeId={request.WorkTypeId}&RosterLocationId={request.RosterLocationId}&TimesheetLocationId={request.TimesheetLocationId}{ConvertEnumerableToQueryString("RosterStatuses", request.RosterStatuses?.Select(x => x.ToString()))}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public Task<List<SgRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, RosterVsTimesheetComparisonReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?EmploymentTypeId={request.EmploymentTypeId}&EmployeeId={request.EmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("TimesheetStatuses", request.TimesheetStatuses?.Select(x => x.ToString()))}&WorkTypeId={request.WorkTypeId}&RosterLocationId={request.RosterLocationId}&TimesheetLocationId={request.TimesheetLocationId}{ConvertEnumerableToQueryString("RosterStatuses", request.RosterStatuses?.Select(x => x.ToString()))}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public List<SgTimesheetExportModel> TimesheetReport(int businessId)
        {
            return ApiRequest<List<SgTimesheetExportModel>>($"/business/{businessId}/report/timesheet", Method.Get);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public Task<List<SgTimesheetExportModel>> TimesheetReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgTimesheetExportModel>>($"/business/{businessId}/report/timesheet", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public List<SgTimesheetExportModel> TimesheetReport(int businessId, TimesheetReportQueryModel request)
        {
            return ApiRequest<List<SgTimesheetExportModel>>($"/business/{businessId}/report/timesheet?EmployeeId={request.EmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("Statuses", request.Statuses?.Select(x => x.ToString()))}&WorkTypeId={request.WorkTypeId}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public Task<List<SgTimesheetExportModel>> TimesheetReportAsync(int businessId, TimesheetReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgTimesheetExportModel>>($"/business/{businessId}/report/timesheet?EmployeeId={request.EmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("Statuses", request.Statuses?.Select(x => x.ToString()))}&WorkTypeId={request.WorkTypeId}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Withholding Report
        /// </summary>
        /// <remarks>
        /// Generates a withholding report, containing a breakdown of the amounts withheld per month for a given date range
        /// </remarks>
        public List<SgWithholdingModel> WithholdingReport(int businessId)
        {
            return ApiRequest<List<SgWithholdingModel>>($"/business/{businessId}/report/withholding", Method.Get);
        }

        /// <summary>
        /// Withholding Report
        /// </summary>
        /// <remarks>
        /// Generates a withholding report, containing a breakdown of the amounts withheld per month for a given date range
        /// </remarks>
        public Task<List<SgWithholdingModel>> WithholdingReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgWithholdingModel>>($"/business/{businessId}/report/withholding", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Withholding Report
        /// </summary>
        /// <remarks>
        /// Generates a withholding report, containing a breakdown of the amounts withheld per month for a given date range
        /// </remarks>
        public List<SgWithholdingModel> WithholdingReport(int businessId, WithholdingReportQueryModel request)
        {
            return ApiRequest<List<SgWithholdingModel>>($"/business/{businessId}/report/withholding?FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Withholding Report
        /// </summary>
        /// <remarks>
        /// Generates a withholding report, containing a breakdown of the amounts withheld per month for a given date range
        /// </remarks>
        public Task<List<SgWithholdingModel>> WithholdingReportAsync(int businessId, WithholdingReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgWithholdingModel>>($"/business/{businessId}/report/withholding?FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Audit Report
        /// </summary>
        /// <remarks>
        /// Generates an Employee Audit Report.
        /// </remarks>
        public List<EmployeeDetailsAuditReportApiModel> EmployeeAuditReport(int businessId)
        {
            return ApiRequest<List<EmployeeDetailsAuditReportApiModel>>($"/business/{businessId}/report/employeeaudit", Method.Get);
        }

        /// <summary>
        /// Employee Audit Report
        /// </summary>
        /// <remarks>
        /// Generates an Employee Audit Report.
        /// </remarks>
        public Task<List<EmployeeDetailsAuditReportApiModel>> EmployeeAuditReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDetailsAuditReportApiModel>>($"/business/{businessId}/report/employeeaudit", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Audit Report
        /// </summary>
        /// <remarks>
        /// Generates an Employee Audit Report.
        /// </remarks>
        public List<EmployeeDetailsAuditReportApiModel> EmployeeAuditReport(int businessId, EmployeeAuditReportQueryModel request)
        {
            return ApiRequest<List<EmployeeDetailsAuditReportApiModel>>($"/business/{businessId}/report/employeeaudit?EmployeeId={request.EmployeeId}&Section={request.Section}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Employee Audit Report
        /// </summary>
        /// <remarks>
        /// Generates an Employee Audit Report.
        /// </remarks>
        public Task<List<EmployeeDetailsAuditReportApiModel>> EmployeeAuditReportAsync(int businessId, EmployeeAuditReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDetailsAuditReportApiModel>>($"/business/{businessId}/report/employeeaudit?EmployeeId={request.EmployeeId}&Section={request.Section}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Details Report
        /// </summary>
        /// <remarks>
        /// Generates an employee details report.
        /// </remarks>
        public List<dynamic> EmployeeDetailsReport(int businessId)
        {
            return ApiRequest<List<dynamic>>($"/business/{businessId}/report/employeedetails", Method.Get);
        }

        /// <summary>
        /// Employee Details Report
        /// </summary>
        /// <remarks>
        /// Generates an employee details report.
        /// </remarks>
        public Task<List<dynamic>> EmployeeDetailsReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<dynamic>>($"/business/{businessId}/report/employeedetails", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Details Report
        /// </summary>
        /// <remarks>
        /// Generates an employee details report.
        /// </remarks>
        public List<dynamic> EmployeeDetailsReport(int businessId, EmployeeDetailsReportQueryModel request)
        {
            return ApiRequest<List<dynamic>>($"/business/{businessId}/report/employeedetails{ConvertEnumerableToQueryString("selectedColumns", request.SelectedColumns?.Select(x => x.ToString()))}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}&includeActive={request.IncludeActive}&includeInactive={request.IncludeInactive}", Method.Get);
        }

        /// <summary>
        /// Employee Details Report
        /// </summary>
        /// <remarks>
        /// Generates an employee details report.
        /// </remarks>
        public Task<List<dynamic>> EmployeeDetailsReportAsync(int businessId, EmployeeDetailsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<dynamic>>($"/business/{businessId}/report/employeedetails{ConvertEnumerableToQueryString("selectedColumns", request.SelectedColumns?.Select(x => x.ToString()))}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}&includeActive={request.IncludeActive}&includeInactive={request.IncludeInactive}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Details Report
        /// </summary>
        /// <remarks>
        /// Generates an employee details report.
        /// </remarks>
        public List<dynamic> EmployeeDetailsReport(int businessId, EmployeeDetailsReportRequestModel model)
        {
            return ApiRequest<List<dynamic>,EmployeeDetailsReportRequestModel>($"/business/{businessId}/report/employeedetails", model, Method.Post);
        }

        /// <summary>
        /// Employee Details Report
        /// </summary>
        /// <remarks>
        /// Generates an employee details report.
        /// </remarks>
        public Task<List<dynamic>> EmployeeDetailsReportAsync(int businessId, EmployeeDetailsReportRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<dynamic>,EmployeeDetailsReportRequestModel>($"/business/{businessId}/report/employeedetails", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Birthday Report
        /// </summary>
        /// <remarks>
        /// Generates a birthday report.
        /// </remarks>
        public List<BirthdayReportExportModel> BirthdayReport(int businessId)
        {
            return ApiRequest<List<BirthdayReportExportModel>>($"/business/{businessId}/report/birthday", Method.Get);
        }

        /// <summary>
        /// Birthday Report
        /// </summary>
        /// <remarks>
        /// Generates a birthday report.
        /// </remarks>
        public Task<List<BirthdayReportExportModel>> BirthdayReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BirthdayReportExportModel>>($"/business/{businessId}/report/birthday", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Birthday Report
        /// </summary>
        /// <remarks>
        /// Generates a birthday report.
        /// </remarks>
        public List<BirthdayReportExportModel> BirthdayReport(int businessId, BirthdayReportQueryModel request)
        {
            return ApiRequest<List<BirthdayReportExportModel>>($"/business/{businessId}/report/birthday?FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Birthday Report
        /// </summary>
        /// <remarks>
        /// Generates a birthday report.
        /// </remarks>
        public Task<List<BirthdayReportExportModel>> BirthdayReportAsync(int businessId, BirthdayReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BirthdayReportExportModel>>($"/business/{businessId}/report/birthday?FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Deductions Report
        /// </summary>
        /// <remarks>
        /// Generates a deductions report.
        /// </remarks>
        public List<DeductionsReportExportModel> DeductionsReport(int businessId)
        {
            return ApiRequest<List<DeductionsReportExportModel>>($"/business/{businessId}/report/deductions", Method.Get);
        }

        /// <summary>
        /// Deductions Report
        /// </summary>
        /// <remarks>
        /// Generates a deductions report.
        /// </remarks>
        public Task<List<DeductionsReportExportModel>> DeductionsReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DeductionsReportExportModel>>($"/business/{businessId}/report/deductions", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Deductions Report
        /// </summary>
        /// <remarks>
        /// Generates a deductions report.
        /// </remarks>
        public List<DeductionsReportExportModel> DeductionsReport(int businessId, DeductionsReportQueryModel request)
        {
            return ApiRequest<List<DeductionsReportExportModel>>($"/business/{businessId}/report/deductions?EmployeeId={request.EmployeeId}&DeductionCategoryId={request.DeductionCategoryId}&DisableRollupReporting={request.DisableRollupReporting}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Deductions Report
        /// </summary>
        /// <remarks>
        /// Generates a deductions report.
        /// </remarks>
        public Task<List<DeductionsReportExportModel>> DeductionsReportAsync(int businessId, DeductionsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DeductionsReportExportModel>>($"/business/{businessId}/report/deductions?EmployeeId={request.EmployeeId}&DeductionCategoryId={request.DeductionCategoryId}&DisableRollupReporting={request.DisableRollupReporting}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Document Acknowledgements Report
        /// </summary>
        /// <remarks>
        /// Generates a document acknowledgements report.
        /// </remarks>
        public List<DocumentAcknowledgementsReportExportModel> DocumentAcknowledgementsReport(int businessId)
        {
            return ApiRequest<List<DocumentAcknowledgementsReportExportModel>>($"/business/{businessId}/report/documentAcknowledgements", Method.Get);
        }

        /// <summary>
        /// Document Acknowledgements Report
        /// </summary>
        /// <remarks>
        /// Generates a document acknowledgements report.
        /// </remarks>
        public Task<List<DocumentAcknowledgementsReportExportModel>> DocumentAcknowledgementsReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DocumentAcknowledgementsReportExportModel>>($"/business/{businessId}/report/documentAcknowledgements", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Document Acknowledgements Report
        /// </summary>
        /// <remarks>
        /// Generates a document acknowledgements report.
        /// </remarks>
        public List<DocumentAcknowledgementsReportExportModel> DocumentAcknowledgementsReport(int businessId, DocumentAcknowledgementsReportQueryModel request)
        {
            return ApiRequest<List<DocumentAcknowledgementsReportExportModel>>($"/business/{businessId}/report/documentAcknowledgements?DocumentId={request.DocumentId}{ConvertEnumerableToQueryString("EmployeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&DocumentStatus={request.DocumentStatus}&EmployingEntityId={request.EmployingEntityId}&LocationId={request.LocationId}", Method.Get);
        }

        /// <summary>
        /// Document Acknowledgements Report
        /// </summary>
        /// <remarks>
        /// Generates a document acknowledgements report.
        /// </remarks>
        public Task<List<DocumentAcknowledgementsReportExportModel>> DocumentAcknowledgementsReportAsync(int businessId, DocumentAcknowledgementsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DocumentAcknowledgementsReportExportModel>>($"/business/{businessId}/report/documentAcknowledgements?DocumentId={request.DocumentId}{ConvertEnumerableToQueryString("EmployeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&DocumentStatus={request.DocumentStatus}&EmployingEntityId={request.EmployingEntityId}&LocationId={request.LocationId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Journal Report
        /// </summary>
        /// <remarks>
        /// Gets the journal for a finalised pay run with the specified Id.
        /// </remarks>
        public byte[] JournalReport(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/journal", Method.Get);
        }

        /// <summary>
        /// Journal Report
        /// </summary>
        /// <remarks>
        /// Gets the journal for a finalised pay run with the specified Id.
        /// </remarks>
        public Task<byte[]> JournalReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/journal", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Journal Report
        /// </summary>
        /// <remarks>
        /// Gets the journal for a finalised pay run with the specified Id.
        /// </remarks>
        public byte[] JournalReport(int businessId, JournalReportQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/journal?PayRunId={request.PayRunId}&JournalView={request.JournalView}&JournalService={request.JournalService}", Method.Get);
        }

        /// <summary>
        /// Journal Report
        /// </summary>
        /// <remarks>
        /// Gets the journal for a finalised pay run with the specified Id.
        /// </remarks>
        public Task<byte[]> JournalReportAsync(int businessId, JournalReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/journal?PayRunId={request.PayRunId}&JournalView={request.JournalView}&JournalService={request.JournalService}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Variance Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run variance report as an Excel file.
        /// </remarks>
        public byte[] PayRunVarianceReport(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/payrunvariance/xlsx", Method.Get);
        }

        /// <summary>
        /// Pay Run Variance Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run variance report as an Excel file.
        /// </remarks>
        public Task<byte[]> PayRunVarianceReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/payrunvariance/xlsx", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Variance Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run variance report as an Excel file.
        /// </remarks>
        public byte[] PayRunVarianceReport(int businessId, PayRunVarianceReportQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/payrunvariance/xlsx?PayRunId1={request.PayRunId1}&PayRunId2={request.PayRunId2}&PayPeriodFrom1={(request.PayPeriodFrom1.HasValue ? request.PayPeriodFrom1.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayPeriodTo1={(request.PayPeriodTo1.HasValue ? request.PayPeriodTo1.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayPeriodFrom2={(request.PayPeriodFrom2.HasValue ? request.PayPeriodFrom2.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayPeriodTo2={(request.PayPeriodTo2.HasValue ? request.PayPeriodTo2.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ComparisonType={request.ComparisonType}&HighlightVariancePercentage={request.HighlightVariancePercentage}&OnlyShowVariances={request.OnlyShowVariances}", Method.Get);
        }

        /// <summary>
        /// Pay Run Variance Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run variance report as an Excel file.
        /// </remarks>
        public Task<byte[]> PayRunVarianceReportAsync(int businessId, PayRunVarianceReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/payrunvariance/xlsx?PayRunId1={request.PayRunId1}&PayRunId2={request.PayRunId2}&PayPeriodFrom1={(request.PayPeriodFrom1.HasValue ? request.PayPeriodFrom1.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayPeriodTo1={(request.PayPeriodTo1.HasValue ? request.PayPeriodTo1.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayPeriodFrom2={(request.PayPeriodFrom2.HasValue ? request.PayPeriodFrom2.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayPeriodTo2={(request.PayPeriodTo2.HasValue ? request.PayPeriodTo2.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ComparisonType={request.ComparisonType}&HighlightVariancePercentage={request.HighlightVariancePercentage}&OnlyShowVariances={request.OnlyShowVariances}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Deprecated Pay Run Variance Report
        /// </summary>
        /// <remarks>
        /// Deprecated: Use /xlsx instead.
        /// </remarks>
        public byte[] DeprecatedPayRunVarianceReport(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/payrunvariance/xlxs", Method.Get);
        }

        /// <summary>
        /// Deprecated Pay Run Variance Report
        /// </summary>
        /// <remarks>
        /// Deprecated: Use /xlsx instead.
        /// </remarks>
        public Task<byte[]> DeprecatedPayRunVarianceReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/payrunvariance/xlxs", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Deprecated Pay Run Variance Report
        /// </summary>
        /// <remarks>
        /// Deprecated: Use /xlsx instead.
        /// </remarks>
        public byte[] DeprecatedPayRunVarianceReport(int businessId, DeprecatedPayRunVarianceReportQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/payrunvariance/xlxs?PayRunId1={request.PayRunId1}&PayRunId2={request.PayRunId2}&PayPeriodFrom1={(request.PayPeriodFrom1.HasValue ? request.PayPeriodFrom1.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayPeriodTo1={(request.PayPeriodTo1.HasValue ? request.PayPeriodTo1.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayPeriodFrom2={(request.PayPeriodFrom2.HasValue ? request.PayPeriodFrom2.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayPeriodTo2={(request.PayPeriodTo2.HasValue ? request.PayPeriodTo2.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ComparisonType={request.ComparisonType}&HighlightVariancePercentage={request.HighlightVariancePercentage}&OnlyShowVariances={request.OnlyShowVariances}", Method.Get);
        }

        /// <summary>
        /// Deprecated Pay Run Variance Report
        /// </summary>
        /// <remarks>
        /// Deprecated: Use /xlsx instead.
        /// </remarks>
        public Task<byte[]> DeprecatedPayRunVarianceReportAsync(int businessId, DeprecatedPayRunVarianceReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/payrunvariance/xlxs?PayRunId1={request.PayRunId1}&PayRunId2={request.PayRunId2}&PayPeriodFrom1={(request.PayPeriodFrom1.HasValue ? request.PayPeriodFrom1.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayPeriodTo1={(request.PayPeriodTo1.HasValue ? request.PayPeriodTo1.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayPeriodFrom2={(request.PayPeriodFrom2.HasValue ? request.PayPeriodFrom2.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayPeriodTo2={(request.PayPeriodTo2.HasValue ? request.PayPeriodTo2.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ComparisonType={request.ComparisonType}&HighlightVariancePercentage={request.HighlightVariancePercentage}&OnlyShowVariances={request.OnlyShowVariances}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Pay Slips by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the pay slips for a finalised pay run with the specified Id.
        /// </remarks>
        public byte[] GetPaySlipsByFinalisedPayRunId(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/payslip", Method.Get);
        }

        /// <summary>
        /// Get Pay Slips by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the pay slips for a finalised pay run with the specified Id.
        /// </remarks>
        public Task<byte[]> GetPaySlipsByFinalisedPayRunIdAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/payslip", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Pay Slips by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the pay slips for a finalised pay run with the specified Id.
        /// </remarks>
        public byte[] GetPaySlipsByFinalisedPayRunId(int businessId, GetPaySlipsByFinalisedPayRunIdQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/payslip?PayRunId={request.PayRunId}&EmployeeId={request.EmployeeId}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Get Pay Slips by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the pay slips for a finalised pay run with the specified Id.
        /// </remarks>
        public Task<byte[]> GetPaySlipsByFinalisedPayRunIdAsync(int businessId, GetPaySlipsByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/payslip?PayRunId={request.PayRunId}&EmployeeId={request.EmployeeId}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get shift swapping report by business id
        /// </summary>
        public List<ShiftSwappingReportExportModel> GetShiftSwappingReportByBusinessId(int businessId)
        {
            return ApiRequest<List<ShiftSwappingReportExportModel>>($"/business/{businessId}/report/shiftswapping", Method.Get);
        }

        /// <summary>
        /// Get shift swapping report by business id
        /// </summary>
        public Task<List<ShiftSwappingReportExportModel>> GetShiftSwappingReportByBusinessIdAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ShiftSwappingReportExportModel>>($"/business/{businessId}/report/shiftswapping", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get shift swapping report by business id
        /// </summary>
        public List<ShiftSwappingReportExportModel> GetShiftSwappingReportByBusinessId(int businessId, GetShiftSwappingReportByBusinessIdQueryModel request)
        {
            return ApiRequest<List<ShiftSwappingReportExportModel>>($"/business/{businessId}/report/shiftswapping?FromEmployeeId={request.FromEmployeeId}&ToEmployeeId={request.ToEmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("Statuses", request.Statuses?.Select(x => x.ToString()))}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Get shift swapping report by business id
        /// </summary>
        public Task<List<ShiftSwappingReportExportModel>> GetShiftSwappingReportByBusinessIdAsync(int businessId, GetShiftSwappingReportByBusinessIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ShiftSwappingReportExportModel>>($"/business/{businessId}/report/shiftswapping?FromEmployeeId={request.FromEmployeeId}&ToEmployeeId={request.ToEmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("Statuses", request.Statuses?.Select(x => x.ToString()))}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get tasks by business id
        /// </summary>
        public List<TasksReportExportModel> GetTasksByBusinessId(int businessId)
        {
            return ApiRequest<List<TasksReportExportModel>>($"/business/{businessId}/report/tasks", Method.Get);
        }

        /// <summary>
        /// Get tasks by business id
        /// </summary>
        public Task<List<TasksReportExportModel>> GetTasksByBusinessIdAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TasksReportExportModel>>($"/business/{businessId}/report/tasks", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get tasks by business id
        /// </summary>
        public List<TasksReportExportModel> GetTasksByBusinessId(int businessId, GetTasksByBusinessIdQueryModel request)
        {
            return ApiRequest<List<TasksReportExportModel>>($"/business/{businessId}/report/tasks?EmployeeId={request.EmployeeId}&PayRunId={request.PayRunId}&FromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ToDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayScheduleId={request.PayScheduleId}&Status={request.Status}", Method.Get);
        }

        /// <summary>
        /// Get tasks by business id
        /// </summary>
        public Task<List<TasksReportExportModel>> GetTasksByBusinessIdAsync(int businessId, GetTasksByBusinessIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TasksReportExportModel>>($"/business/{businessId}/report/tasks?EmployeeId={request.EmployeeId}&PayRunId={request.PayRunId}&FromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ToDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayScheduleId={request.PayScheduleId}&Status={request.Status}", Method.Get, cancellationToken);
        }
    }
}
