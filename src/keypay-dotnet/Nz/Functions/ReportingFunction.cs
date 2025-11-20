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
using KeyPayV2.Nz.Models.Reporting;

namespace KeyPayV2.Nz.Functions
{
    public interface IReportingFunction
    {
        byte[] PayRunAuditReport(int businessId, int payRunId);
        Task<byte[]> PayRunAuditReportAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        byte[] PayRunAuditReport(int businessId, int payRunId, PayRunAuditReportQueryModel request);
        Task<byte[]> PayRunAuditReportAsync(int businessId, int payRunId, PayRunAuditReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] DeprecatedPayRunAuditReport(int businessId, int payRunId);
        Task<byte[]> DeprecatedPayRunAuditReportAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        byte[] DeprecatedPayRunAuditReport(int businessId, int payRunId, DeprecatedPayRunAuditReportQueryModel request);
        Task<byte[]> DeprecatedPayRunAuditReportAsync(int businessId, int payRunId, DeprecatedPayRunAuditReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] DeductionsReportAsExcel(int businessId);
        Task<byte[]> DeductionsReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] DeductionsReportAsExcel(int businessId, DeductionsReportAsExcelQueryModel request);
        Task<byte[]> DeductionsReportAsExcelAsync(int businessId, DeductionsReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        List<NzDetailedActivityReportExportModel> DetailedActivityReport(int businessId);
        Task<List<NzDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzDetailedActivityReportExportModel> DetailedActivityReport(int businessId, DetailedActivityReportQueryModel request);
        Task<List<NzDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, DetailedActivityReportQueryModel request, CancellationToken cancellationToken = default);
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
        List<NzPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId);
        Task<List<NzPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId, EmployeePaymentHistoryReportQueryModel request);
        Task<List<NzPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, EmployeePaymentHistoryReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] EmployeePaymentHistoryReportAsExcel(int businessId);
        Task<byte[]> EmployeePaymentHistoryReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] EmployeePaymentHistoryReportAsExcel(int businessId, EmployeePaymentHistoryReportAsExcelQueryModel request);
        Task<byte[]> EmployeePaymentHistoryReportAsExcelAsync(int businessId, EmployeePaymentHistoryReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        List<NzGrossToNetResponseModel> GrossToNetReport(int businessId);
        Task<List<NzGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzGrossToNetResponseModel> GrossToNetReport(int businessId, GrossToNetReportQueryModel request);
        Task<List<NzGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, GrossToNetReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] GrossToNetReportAsExcel(int businessId);
        Task<byte[]> GrossToNetReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] GrossToNetReportAsExcel(int businessId, GrossToNetReportAsExcelQueryModel request);
        Task<byte[]> GrossToNetReportAsExcelAsync(int businessId, GrossToNetReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        List<KiwiSaverReportExportModel> KiwisaverReport(int businessId);
        Task<List<KiwiSaverReportExportModel>> KiwisaverReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<KiwiSaverReportExportModel> KiwisaverReport(int businessId, KiwisaverReportQueryModel request);
        Task<List<KiwiSaverReportExportModel>> KiwisaverReportAsync(int businessId, KiwisaverReportQueryModel request, CancellationToken cancellationToken = default);
        void KiwisaverReportAsExcel(int businessId);
        Task KiwisaverReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        void KiwisaverReportAsExcel(int businessId, KiwisaverReportAsExcelQueryModel request);
        Task KiwisaverReportAsExcelAsync(int businessId, KiwisaverReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        List<NzLeaveBalancesExportModel> LeaveBalancesReport(int businessId);
        Task<List<NzLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzLeaveBalancesExportModel> LeaveBalancesReport(int businessId, LeaveBalancesReportQueryModel request);
        Task<List<NzLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, LeaveBalancesReportQueryModel request, CancellationToken cancellationToken = default);
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
        List<NzOrdinaryTimeEarningsApiModel> OrdinaryTimeEarningsReport(int businessId);
        Task<List<NzOrdinaryTimeEarningsApiModel>> OrdinaryTimeEarningsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzOrdinaryTimeEarningsApiModel> OrdinaryTimeEarningsReport(int businessId, OrdinaryTimeEarningsReportQueryModel request);
        Task<List<NzOrdinaryTimeEarningsApiModel>> OrdinaryTimeEarningsReportAsync(int businessId, OrdinaryTimeEarningsReportQueryModel request, CancellationToken cancellationToken = default);
        List<NzPayCategoriesModel> PayCategoriesReport(int businessId);
        Task<List<NzPayCategoriesModel>> PayCategoriesReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzPayCategoriesModel> PayCategoriesReport(int businessId, PayCategoriesReportQueryModel request);
        Task<List<NzPayCategoriesModel>> PayCategoriesReportAsync(int businessId, PayCategoriesReportQueryModel request, CancellationToken cancellationToken = default);
        List<PayeReportExportModel> PayeReport(int businessId);
        Task<List<PayeReportExportModel>> PayeReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<PayeReportExportModel> PayeReport(int businessId, PayeReportQueryModel request);
        Task<List<PayeReportExportModel>> PayeReportAsync(int businessId, PayeReportQueryModel request, CancellationToken cancellationToken = default);
        List<NzPayRunInclusionExportModel> PayRunInclusionsReport(int businessId);
        Task<List<NzPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzPayRunInclusionExportModel> PayRunInclusionsReport(int businessId, PayRunInclusionsReportQueryModel request);
        Task<List<NzPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, PayRunInclusionsReportQueryModel request, CancellationToken cancellationToken = default);
        List<NzRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId);
        Task<List<NzRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId, RosterVsTimesheetComparisonReportQueryModel request);
        Task<List<NzRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, RosterVsTimesheetComparisonReportQueryModel request, CancellationToken cancellationToken = default);
        List<NzTimesheetExportModel> TimesheetReport(int businessId);
        Task<List<NzTimesheetExportModel>> TimesheetReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzTimesheetExportModel> TimesheetReport(int businessId, TimesheetReportQueryModel request);
        Task<List<NzTimesheetExportModel>> TimesheetReportAsync(int businessId, TimesheetReportQueryModel request, CancellationToken cancellationToken = default);
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
        byte[] JournalReport(int businessId);
        Task<byte[]> JournalReportAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] JournalReport(int businessId, JournalReportQueryModel request);
        Task<byte[]> JournalReportAsync(int businessId, JournalReportQueryModel request, CancellationToken cancellationToken = default);
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
        List<NzCostingReportApiModel> CostingReport(int businessId);
        Task<List<NzCostingReportApiModel>> CostingReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzCostingReportApiModel> CostingReport(int businessId, CostingReportQueryModel request);
        Task<List<NzCostingReportApiModel>> CostingReportAsync(int businessId, CostingReportQueryModel request, CancellationToken cancellationToken = default);
    }
    public class ReportingFunction : BaseFunction, IReportingFunction
    {
        public ReportingFunction(ApiRequestExecutor api) : base(api) {}

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
        public List<NzDetailedActivityReportExportModel> DetailedActivityReport(int businessId)
        {
            return ApiRequest<List<NzDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity", Method.Get);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public Task<List<NzDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public List<NzDetailedActivityReportExportModel> DetailedActivityReport(int businessId, DetailedActivityReportQueryModel request)
        {
            return ApiRequest<List<NzDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public Task<List<NzDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, DetailedActivityReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
        public List<NzPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId)
        {
            return ApiRequest<List<NzPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory", Method.Get);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public Task<List<NzPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public List<NzPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId, EmployeePaymentHistoryReportQueryModel request)
        {
            return ApiRequest<List<NzPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?EmployeeId={request.EmployeeId}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public Task<List<NzPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, EmployeePaymentHistoryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?EmployeeId={request.EmployeeId}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
        public List<NzGrossToNetResponseModel> GrossToNetReport(int businessId)
        {
            return ApiRequest<List<NzGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet", Method.Get);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public Task<List<NzGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public List<NzGrossToNetResponseModel> GrossToNetReport(int businessId, GrossToNetReportQueryModel request)
        {
            return ApiRequest<List<NzGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?EmployeeId={request.EmployeeId}{ConvertEnumerableToQueryString("PayCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&GroupBy={request.GroupBy}&PayRunId={request.PayRunId}&FilterType={request.FilterType}&IncludeExpenses={request.IncludeExpenses}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public Task<List<NzGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, GrossToNetReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?EmployeeId={request.EmployeeId}{ConvertEnumerableToQueryString("PayCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&GroupBy={request.GroupBy}&PayRunId={request.PayRunId}&FilterType={request.FilterType}&IncludeExpenses={request.IncludeExpenses}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
        /// KiwiSaver Report
        /// </summary>
        /// <remarks>
        /// Generates a KiwiSaver report.
        /// </remarks>
        public List<KiwiSaverReportExportModel> KiwisaverReport(int businessId)
        {
            return ApiRequest<List<KiwiSaverReportExportModel>>($"/business/{businessId}/report/kiwisaver", Method.Get);
        }

        /// <summary>
        /// KiwiSaver Report
        /// </summary>
        /// <remarks>
        /// Generates a KiwiSaver report.
        /// </remarks>
        public Task<List<KiwiSaverReportExportModel>> KiwisaverReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<KiwiSaverReportExportModel>>($"/business/{businessId}/report/kiwisaver", Method.Get, cancellationToken);
        }

        /// <summary>
        /// KiwiSaver Report
        /// </summary>
        /// <remarks>
        /// Generates a KiwiSaver report.
        /// </remarks>
        public List<KiwiSaverReportExportModel> KiwisaverReport(int businessId, KiwisaverReportQueryModel request)
        {
            return ApiRequest<List<KiwiSaverReportExportModel>>($"/business/{businessId}/report/kiwisaver?EmployeeId={request.EmployeeId}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// KiwiSaver Report
        /// </summary>
        /// <remarks>
        /// Generates a KiwiSaver report.
        /// </remarks>
        public Task<List<KiwiSaverReportExportModel>> KiwisaverReportAsync(int businessId, KiwisaverReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<KiwiSaverReportExportModel>>($"/business/{businessId}/report/kiwisaver?EmployeeId={request.EmployeeId}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// KiwiSaver Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a KiwiSaver Report as an Excel file.
        /// </remarks>
        public void KiwisaverReportAsExcel(int businessId)
        {
            ApiRequest($"/business/{businessId}/report/kiwisaver/xlsx", Method.Get);
        }

        /// <summary>
        /// KiwiSaver Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a KiwiSaver Report as an Excel file.
        /// </remarks>
        public Task KiwisaverReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/report/kiwisaver/xlsx", Method.Get, cancellationToken);
        }

        /// <summary>
        /// KiwiSaver Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a KiwiSaver Report as an Excel file.
        /// </remarks>
        public void KiwisaverReportAsExcel(int businessId, KiwisaverReportAsExcelQueryModel request)
        {
            ApiRequest($"/business/{businessId}/report/kiwisaver/xlsx?FilterType={request.FilterType}&PayScheduleId={request.PayScheduleId}&EmployeeId={request.EmployeeId}&PayRunId={request.PayRunId}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// KiwiSaver Report as Excel
        /// </summary>
        /// <remarks>
        /// Generates a KiwiSaver Report as an Excel file.
        /// </remarks>
        public Task KiwisaverReportAsExcelAsync(int businessId, KiwisaverReportAsExcelQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/report/kiwisaver/xlsx?FilterType={request.FilterType}&PayScheduleId={request.PayScheduleId}&EmployeeId={request.EmployeeId}&PayRunId={request.PayRunId}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public List<NzLeaveBalancesExportModel> LeaveBalancesReport(int businessId)
        {
            return ApiRequest<List<NzLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances", Method.Get);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public Task<List<NzLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public List<NzLeaveBalancesExportModel> LeaveBalancesReport(int businessId, LeaveBalancesReportQueryModel request)
        {
            return ApiRequest<List<NzLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?PayScheduleId={request.PayScheduleId}{ConvertEnumerableToQueryString("EmployeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&LocationId={request.LocationId}&LeaveTypeId={request.LeaveTypeId}&GroupBy={request.GroupBy}&EmployingEntityId={request.EmployingEntityId}&AsAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public Task<List<NzLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, LeaveBalancesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?PayScheduleId={request.PayScheduleId}{ConvertEnumerableToQueryString("EmployeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&LocationId={request.LocationId}&LeaveTypeId={request.LeaveTypeId}&GroupBy={request.GroupBy}&EmployingEntityId={request.EmployingEntityId}&AsAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
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
            return ApiRequest<List<LeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability?PayScheduleId={request.PayScheduleId}{ConvertEnumerableToQueryString("EmployeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&JobId={request.JobId}&FilterType={request.FilterType}&LocationId={request.LocationId}&LeaveTypeId={request.LeaveTypeId}&IncludeApprovedLeave={request.IncludeApprovedLeave}&AsAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&EmployingEntityId={request.EmployingEntityId}&PayRunId={request.PayRunId}{ConvertEnumerableToQueryString("LeaveTypeIds", request.LeaveTypeIds?.Select(x => x.ToString()))}&GroupBy={request.GroupBy}", Method.Get);
        }

        /// <summary>
        /// Leave Liability Report
        /// </summary>
        /// <remarks>
        /// Generates a leave liability report.
        /// </remarks>
        public Task<List<LeaveLiabilityExportModel>> LeaveLiabilityReportAsync(int businessId, LeaveLiabilityReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability?PayScheduleId={request.PayScheduleId}{ConvertEnumerableToQueryString("EmployeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&JobId={request.JobId}&FilterType={request.FilterType}&LocationId={request.LocationId}&LeaveTypeId={request.LeaveTypeId}&IncludeApprovedLeave={request.IncludeApprovedLeave}&AsAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&EmployingEntityId={request.EmployingEntityId}&PayRunId={request.PayRunId}{ConvertEnumerableToQueryString("LeaveTypeIds", request.LeaveTypeIds?.Select(x => x.ToString()))}&GroupBy={request.GroupBy}", Method.Get, cancellationToken);
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
        /// Ordinary Time Earnings Report
        /// </summary>
        /// <remarks>
        /// Generates an ordinary time earnings report.
        /// </remarks>
        public List<NzOrdinaryTimeEarningsApiModel> OrdinaryTimeEarningsReport(int businessId)
        {
            return ApiRequest<List<NzOrdinaryTimeEarningsApiModel>>($"/business/{businessId}/report/ordinarytimeearnings", Method.Get);
        }

        /// <summary>
        /// Ordinary Time Earnings Report
        /// </summary>
        /// <remarks>
        /// Generates an ordinary time earnings report.
        /// </remarks>
        public Task<List<NzOrdinaryTimeEarningsApiModel>> OrdinaryTimeEarningsReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzOrdinaryTimeEarningsApiModel>>($"/business/{businessId}/report/ordinarytimeearnings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Ordinary Time Earnings Report
        /// </summary>
        /// <remarks>
        /// Generates an ordinary time earnings report.
        /// </remarks>
        public List<NzOrdinaryTimeEarningsApiModel> OrdinaryTimeEarningsReport(int businessId, OrdinaryTimeEarningsReportQueryModel request)
        {
            return ApiRequest<List<NzOrdinaryTimeEarningsApiModel>>($"/business/{businessId}/report/ordinarytimeearnings?PayScheduleId={request.PayScheduleId}&EmployingEntityId={request.EmployingEntityId}&FinancialYearEnding={request.FinancialYearEnding}", Method.Get);
        }

        /// <summary>
        /// Ordinary Time Earnings Report
        /// </summary>
        /// <remarks>
        /// Generates an ordinary time earnings report.
        /// </remarks>
        public Task<List<NzOrdinaryTimeEarningsApiModel>> OrdinaryTimeEarningsReportAsync(int businessId, OrdinaryTimeEarningsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzOrdinaryTimeEarningsApiModel>>($"/business/{businessId}/report/ordinarytimeearnings?PayScheduleId={request.PayScheduleId}&EmployingEntityId={request.EmployingEntityId}&FinancialYearEnding={request.FinancialYearEnding}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public List<NzPayCategoriesModel> PayCategoriesReport(int businessId)
        {
            return ApiRequest<List<NzPayCategoriesModel>>($"/business/{businessId}/report/paycategories", Method.Get);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public Task<List<NzPayCategoriesModel>> PayCategoriesReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzPayCategoriesModel>>($"/business/{businessId}/report/paycategories", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public List<NzPayCategoriesModel> PayCategoriesReport(int businessId, PayCategoriesReportQueryModel request)
        {
            return ApiRequest<List<NzPayCategoriesModel>>($"/business/{businessId}/report/paycategories?PayScheduleId={request.PayScheduleId}&EmployeeId={request.EmployeeId}&GroupByEarningsLocation={request.GroupByEarningsLocation}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public Task<List<NzPayCategoriesModel>> PayCategoriesReportAsync(int businessId, PayCategoriesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzPayCategoriesModel>>($"/business/{businessId}/report/paycategories?PayScheduleId={request.PayScheduleId}&EmployeeId={request.EmployeeId}&GroupByEarningsLocation={request.GroupByEarningsLocation}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// PAYE Report
        /// </summary>
        /// <remarks>
        /// Generates a PAYE report.
        /// </remarks>
        public List<PayeReportExportModel> PayeReport(int businessId)
        {
            return ApiRequest<List<PayeReportExportModel>>($"/business/{businessId}/report/paye", Method.Get);
        }

        /// <summary>
        /// PAYE Report
        /// </summary>
        /// <remarks>
        /// Generates a PAYE report.
        /// </remarks>
        public Task<List<PayeReportExportModel>> PayeReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayeReportExportModel>>($"/business/{businessId}/report/paye", Method.Get, cancellationToken);
        }

        /// <summary>
        /// PAYE Report
        /// </summary>
        /// <remarks>
        /// Generates a PAYE report.
        /// </remarks>
        public List<PayeReportExportModel> PayeReport(int businessId, PayeReportQueryModel request)
        {
            return ApiRequest<List<PayeReportExportModel>>($"/business/{businessId}/report/paye?State={request.State}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// PAYE Report
        /// </summary>
        /// <remarks>
        /// Generates a PAYE report.
        /// </remarks>
        public Task<List<PayeReportExportModel>> PayeReportAsync(int businessId, PayeReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayeReportExportModel>>($"/business/{businessId}/report/paye?State={request.State}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public List<NzPayRunInclusionExportModel> PayRunInclusionsReport(int businessId)
        {
            return ApiRequest<List<NzPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions", Method.Get);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public Task<List<NzPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public List<NzPayRunInclusionExportModel> PayRunInclusionsReport(int businessId, PayRunInclusionsReportQueryModel request)
        {
            return ApiRequest<List<NzPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?EmployeeId={request.EmployeeId}&Status={request.Status}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public Task<List<NzPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, PayRunInclusionsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?EmployeeId={request.EmployeeId}&Status={request.Status}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public List<NzRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId)
        {
            return ApiRequest<List<NzRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison", Method.Get);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public Task<List<NzRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public List<NzRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId, RosterVsTimesheetComparisonReportQueryModel request)
        {
            return ApiRequest<List<NzRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?EmploymentTypeId={request.EmploymentTypeId}&EmployeeId={request.EmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("TimesheetStatuses", request.TimesheetStatuses?.Select(x => x.ToString()))}&WorkTypeId={request.WorkTypeId}&RosterLocationId={request.RosterLocationId}&TimesheetLocationId={request.TimesheetLocationId}{ConvertEnumerableToQueryString("RosterStatuses", request.RosterStatuses?.Select(x => x.ToString()))}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public Task<List<NzRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, RosterVsTimesheetComparisonReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?EmploymentTypeId={request.EmploymentTypeId}&EmployeeId={request.EmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("TimesheetStatuses", request.TimesheetStatuses?.Select(x => x.ToString()))}&WorkTypeId={request.WorkTypeId}&RosterLocationId={request.RosterLocationId}&TimesheetLocationId={request.TimesheetLocationId}{ConvertEnumerableToQueryString("RosterStatuses", request.RosterStatuses?.Select(x => x.ToString()))}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public List<NzTimesheetExportModel> TimesheetReport(int businessId)
        {
            return ApiRequest<List<NzTimesheetExportModel>>($"/business/{businessId}/report/timesheet", Method.Get);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public Task<List<NzTimesheetExportModel>> TimesheetReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzTimesheetExportModel>>($"/business/{businessId}/report/timesheet", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public List<NzTimesheetExportModel> TimesheetReport(int businessId, TimesheetReportQueryModel request)
        {
            return ApiRequest<List<NzTimesheetExportModel>>($"/business/{businessId}/report/timesheet?EmployeeId={request.EmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("Statuses", request.Statuses?.Select(x => x.ToString()))}&WorkTypeId={request.WorkTypeId}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public Task<List<NzTimesheetExportModel>> TimesheetReportAsync(int businessId, TimesheetReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzTimesheetExportModel>>($"/business/{businessId}/report/timesheet?EmployeeId={request.EmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("Statuses", request.Statuses?.Select(x => x.ToString()))}&WorkTypeId={request.WorkTypeId}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public List<NzCostingReportApiModel> CostingReport(int businessId)
        {
            return ApiRequest<List<NzCostingReportApiModel>>($"/business/{businessId}/report/costing", Method.Get);
        }

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public Task<List<NzCostingReportApiModel>> CostingReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzCostingReportApiModel>>($"/business/{businessId}/report/costing", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public List<NzCostingReportApiModel> CostingReport(int businessId, CostingReportQueryModel request)
        {
            return ApiRequest<List<NzCostingReportApiModel>>($"/business/{businessId}/report/costing?ShowZeroPayCategories={request.ShowZeroPayCategories}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public Task<List<NzCostingReportApiModel>> CostingReportAsync(int businessId, CostingReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzCostingReportApiModel>>($"/business/{businessId}/report/costing?ShowZeroPayCategories={request.ShowZeroPayCategories}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }
    }
}
