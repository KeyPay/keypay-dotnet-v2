using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.Reporting;

namespace KeyPayV2.Au.Functions
{
    public interface IReportingFunction
    {
        List<BirthdayReportExportModel> BirthdayReport(int businessId, BirthdayReportQueryModel request);
        Task<List<BirthdayReportExportModel>> BirthdayReportAsync(int businessId, BirthdayReportQueryModel request, CancellationToken cancellationToken = default);
        List<AuCostingReportApiModel> CostingReport(int businessId);
        Task<List<AuCostingReportApiModel>> CostingReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<AuCostingReportApiModel> CostingReport(int businessId, CostingReportQueryModel request);
        Task<List<AuCostingReportApiModel>> CostingReportAsync(int businessId, CostingReportQueryModel request, CancellationToken cancellationToken = default);
        List<DeductionsReportExportModel> DeductionsReport(int businessId);
        Task<List<DeductionsReportExportModel>> DeductionsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<DeductionsReportExportModel> DeductionsReport(int businessId, DeductionsReportQueryModel request);
        Task<List<DeductionsReportExportModel>> DeductionsReportAsync(int businessId, DeductionsReportQueryModel request, CancellationToken cancellationToken = default);
        List<AuDetailedActivityReportExportModel> DetailedActivityReport(int businessId);
        Task<List<AuDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<AuDetailedActivityReportExportModel> DetailedActivityReport(int businessId, DetailedActivityReportQueryModel request);
        Task<List<AuDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, DetailedActivityReportQueryModel request, CancellationToken cancellationToken = default);
        List<DocumentAcknowledgementsReportExportModel> DocumentAcknowledgementsReport(int businessId);
        Task<List<DocumentAcknowledgementsReportExportModel>> DocumentAcknowledgementsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<DocumentAcknowledgementsReportExportModel> DocumentAcknowledgementsReport(int businessId, DocumentAcknowledgementsReportQueryModel request);
        Task<List<DocumentAcknowledgementsReportExportModel>> DocumentAcknowledgementsReportAsync(int businessId, DocumentAcknowledgementsReportQueryModel request, CancellationToken cancellationToken = default);
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
        List<EmployeeDetailsReportField> EmployeeDetailsReportFields(int businessId);
        Task<List<EmployeeDetailsReportField>> EmployeeDetailsReportFieldsAsync(int businessId, CancellationToken cancellationToken = default);
        List<AuGrossToNetResponseModel> GrossToNetReport(int businessId);
        Task<List<AuGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<AuGrossToNetResponseModel> GrossToNetReport(int businessId, GrossToNetReportQueryModel request);
        Task<List<AuGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, GrossToNetReportQueryModel request, CancellationToken cancellationToken = default);
        void JournalReport(int businessId, JournalReportQueryModel request);
        Task JournalReportAsync(int businessId, JournalReportQueryModel request, CancellationToken cancellationToken = default);
        List<AuLeaveBalancesExportModel> LeaveBalancesReport(int businessId);
        Task<List<AuLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<AuLeaveBalancesExportModel> LeaveBalancesReport(int businessId, LeaveBalancesReportQueryModel request);
        Task<List<AuLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, LeaveBalancesReportQueryModel request, CancellationToken cancellationToken = default);
        List<LeaveHistoryReportGroupModel> LeaveHistoryReport(int businessId);
        Task<List<LeaveHistoryReportGroupModel>> LeaveHistoryReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<LeaveHistoryReportGroupModel> LeaveHistoryReport(int businessId, LeaveHistoryReportQueryModel request);
        Task<List<LeaveHistoryReportGroupModel>> LeaveHistoryReportAsync(int businessId, LeaveHistoryReportQueryModel request, CancellationToken cancellationToken = default);
        List<AuLeaveLiabilityExportModel> LeaveLiabilityReport(int businessId);
        Task<List<AuLeaveLiabilityExportModel>> LeaveLiabilityReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<AuLeaveLiabilityExportModel> LeaveLiabilityReport(int businessId, LeaveLiabilityReportQueryModel request);
        Task<List<AuLeaveLiabilityExportModel>> LeaveLiabilityReportAsync(int businessId, LeaveLiabilityReportQueryModel request, CancellationToken cancellationToken = default);
        List<AuOrdinaryTimeEarningsApiModel> OrdinaryTimeEarningsReport(int businessId);
        Task<List<AuOrdinaryTimeEarningsApiModel>> OrdinaryTimeEarningsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<AuOrdinaryTimeEarningsApiModel> OrdinaryTimeEarningsReport(int businessId, OrdinaryTimeEarningsReportQueryModel request);
        Task<List<AuOrdinaryTimeEarningsApiModel>> OrdinaryTimeEarningsReportAsync(int businessId, OrdinaryTimeEarningsReportQueryModel request, CancellationToken cancellationToken = default);
        List<AuPayCategoriesModel> PayCategoriesReport(int businessId);
        Task<List<AuPayCategoriesModel>> PayCategoriesReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<AuPayCategoriesModel> PayCategoriesReport(int businessId, PayCategoriesReportQueryModel request);
        Task<List<AuPayCategoriesModel>> PayCategoriesReportAsync(int businessId, PayCategoriesReportQueryModel request, CancellationToken cancellationToken = default);
        List<PaygReportExportModel> PaygReport(int businessId);
        Task<List<PaygReportExportModel>> PaygReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<PaygReportExportModel> PaygReport(int businessId, PaygReportQueryModel request);
        Task<List<PaygReportExportModel>> PaygReportAsync(int businessId, PaygReportQueryModel request, CancellationToken cancellationToken = default);
        List<AuPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId);
        Task<List<AuPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<AuPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId, EmployeePaymentHistoryReportQueryModel request);
        Task<List<AuPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, EmployeePaymentHistoryReportQueryModel request, CancellationToken cancellationToken = default);
        List<PayrollTaxReportExportModel> PayrollTaxReport(int businessId);
        Task<List<PayrollTaxReportExportModel>> PayrollTaxReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<PayrollTaxReportExportModel> PayrollTaxReport(int businessId, PayrollTaxReportQueryModel request);
        Task<List<PayrollTaxReportExportModel>> PayrollTaxReportAsync(int businessId, PayrollTaxReportQueryModel request, CancellationToken cancellationToken = default);
        List<ActivityReportExportModel> PayRunActivityReport(int businessId, PayRunActivityReportQueryModel request);
        Task<List<ActivityReportExportModel>> PayRunActivityReportAsync(int businessId, PayRunActivityReportQueryModel request, CancellationToken cancellationToken = default);
        List<AuPayRunInclusionExportModel> PayRunInclusionsReport(int businessId);
        Task<List<AuPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<AuPayRunInclusionExportModel> PayRunInclusionsReport(int businessId, PayRunInclusionsReportQueryModel request);
        Task<List<AuPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, PayRunInclusionsReportQueryModel request, CancellationToken cancellationToken = default);
        void GetPaySlipsByFinalisedPayRunId(int businessId);
        Task GetPaySlipsByFinalisedPayRunIdAsync(int businessId, CancellationToken cancellationToken = default);
        void GetPaySlipsByFinalisedPayRunId(int businessId, GetPaySlipsByFinalisedPayRunIdQueryModel request);
        Task GetPaySlipsByFinalisedPayRunIdAsync(int businessId, GetPaySlipsByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default);
        List<AuRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId);
        Task<List<AuRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<AuRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId, RosterVsTimesheetComparisonReportQueryModel request);
        Task<List<AuRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, RosterVsTimesheetComparisonReportQueryModel request, CancellationToken cancellationToken = default);
        List<ShiftSwappingReportExportModel> GetShiftSwappingReportByBusinessId(int businessId);
        Task<List<ShiftSwappingReportExportModel>> GetShiftSwappingReportByBusinessIdAsync(int businessId, CancellationToken cancellationToken = default);
        List<ShiftSwappingReportExportModel> GetShiftSwappingReportByBusinessId(int businessId, GetShiftSwappingReportByBusinessIdQueryModel request);
        Task<List<ShiftSwappingReportExportModel>> GetShiftSwappingReportByBusinessIdAsync(int businessId, GetShiftSwappingReportByBusinessIdQueryModel request, CancellationToken cancellationToken = default);
        List<SuperAccrualExportModel> SuperContributionReportByEmployee(int businessId);
        Task<List<SuperAccrualExportModel>> SuperContributionReportByEmployeeAsync(int businessId, CancellationToken cancellationToken = default);
        List<SuperAccrualExportModel> SuperContributionReportByEmployee(int businessId, SuperContributionReportByEmployeeQueryModel request);
        Task<List<SuperAccrualExportModel>> SuperContributionReportByEmployeeAsync(int businessId, SuperContributionReportByEmployeeQueryModel request, CancellationToken cancellationToken = default);
        List<SuperContributionsReportExportModel> SuperContributionReportBySuperFund(int businessId);
        Task<List<SuperContributionsReportExportModel>> SuperContributionReportBySuperFundAsync(int businessId, CancellationToken cancellationToken = default);
        List<SuperContributionsReportExportModel> SuperContributionReportBySuperFund(int businessId, SuperContributionReportBySuperFundQueryModel request);
        Task<List<SuperContributionsReportExportModel>> SuperContributionReportBySuperFundAsync(int businessId, SuperContributionReportBySuperFundQueryModel request, CancellationToken cancellationToken = default);
        List<TasksReportExportModel> GetTasksByBusinessId(int businessId);
        Task<List<TasksReportExportModel>> GetTasksByBusinessIdAsync(int businessId, CancellationToken cancellationToken = default);
        List<TasksReportExportModel> GetTasksByBusinessId(int businessId, GetTasksByBusinessIdQueryModel request);
        Task<List<TasksReportExportModel>> GetTasksByBusinessIdAsync(int businessId, GetTasksByBusinessIdQueryModel request, CancellationToken cancellationToken = default);
        List<AuTimesheetExportModel> TimesheetReport(int businessId);
        Task<List<AuTimesheetExportModel>> TimesheetReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<AuTimesheetExportModel> TimesheetReport(int businessId, TimesheetReportQueryModel request);
        Task<List<AuTimesheetExportModel>> TimesheetReportAsync(int businessId, TimesheetReportQueryModel request, CancellationToken cancellationToken = default);
    }
    public class ReportingFunction : BaseFunction, IReportingFunction
    {
        public ReportingFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Birthday Report
        /// </summary>
        /// <remarks>
        /// Generates a birthday report.
        /// </remarks>
        public List<BirthdayReportExportModel> BirthdayReport(int businessId, BirthdayReportQueryModel request)
        {
            return ApiRequest<List<BirthdayReportExportModel>>($"/business/{businessId}/report/birthday?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}", Method.Get);
        }

        /// <summary>
        /// Birthday Report
        /// </summary>
        /// <remarks>
        /// Generates a birthday report.
        /// </remarks>
        public Task<List<BirthdayReportExportModel>> BirthdayReportAsync(int businessId, BirthdayReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BirthdayReportExportModel>>($"/business/{businessId}/report/birthday?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public List<AuCostingReportApiModel> CostingReport(int businessId)
        {
            return ApiRequest<List<AuCostingReportApiModel>>($"/business/{businessId}/report/costing", Method.Get);
        }

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public Task<List<AuCostingReportApiModel>> CostingReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuCostingReportApiModel>>($"/business/{businessId}/report/costing", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public List<AuCostingReportApiModel> CostingReport(int businessId, CostingReportQueryModel request)
        {
            return ApiRequest<List<AuCostingReportApiModel>>($"/business/{businessId}/report/costing?showZeroPayCategories={request.ShowZeroPayCategories}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public Task<List<AuCostingReportApiModel>> CostingReportAsync(int businessId, CostingReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuCostingReportApiModel>>($"/business/{businessId}/report/costing?showZeroPayCategories={request.ShowZeroPayCategories}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
            return ApiRequest<List<DeductionsReportExportModel>>($"/business/{businessId}/report/deductions?employeeId={request.EmployeeId}&deductionCategoryId={request.DeductionCategoryId}&disableRollupReporting={request.DisableRollupReporting}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Deductions Report
        /// </summary>
        /// <remarks>
        /// Generates a deductions report.
        /// </remarks>
        public Task<List<DeductionsReportExportModel>> DeductionsReportAsync(int businessId, DeductionsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DeductionsReportExportModel>>($"/business/{businessId}/report/deductions?employeeId={request.EmployeeId}&deductionCategoryId={request.DeductionCategoryId}&disableRollupReporting={request.DisableRollupReporting}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public List<AuDetailedActivityReportExportModel> DetailedActivityReport(int businessId)
        {
            return ApiRequest<List<AuDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity", Method.Get);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public Task<List<AuDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public List<AuDetailedActivityReportExportModel> DetailedActivityReport(int businessId, DetailedActivityReportQueryModel request)
        {
            return ApiRequest<List<AuDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public Task<List<AuDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, DetailedActivityReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
            return ApiRequest<List<DocumentAcknowledgementsReportExportModel>>($"/business/{businessId}/report/documentAcknowledgements?documentId={request.DocumentId}{ConvertEnumerableToQueryString("employeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&documentStatus={request.DocumentStatus}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Get);
        }

        /// <summary>
        /// Document Acknowledgements Report
        /// </summary>
        /// <remarks>
        /// Generates a document acknowledgements report.
        /// </remarks>
        public Task<List<DocumentAcknowledgementsReportExportModel>> DocumentAcknowledgementsReportAsync(int businessId, DocumentAcknowledgementsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DocumentAcknowledgementsReportExportModel>>($"/business/{businessId}/report/documentAcknowledgements?documentId={request.DocumentId}{ConvertEnumerableToQueryString("employeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&documentStatus={request.DocumentStatus}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Get, cancellationToken);
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
            return ApiRequest<List<EmployeeDetailsAuditReportApiModel>>($"/business/{businessId}/report/employeeaudit?employeeId={request.EmployeeId}&section={request.Section}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Employee Audit Report
        /// </summary>
        /// <remarks>
        /// Generates an Employee Audit Report.
        /// </remarks>
        public Task<List<EmployeeDetailsAuditReportApiModel>> EmployeeAuditReportAsync(int businessId, EmployeeAuditReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDetailsAuditReportApiModel>>($"/business/{businessId}/report/employeeaudit?employeeId={request.EmployeeId}&section={request.Section}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public List<AuGrossToNetResponseModel> GrossToNetReport(int businessId)
        {
            return ApiRequest<List<AuGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet", Method.Get);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public Task<List<AuGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public List<AuGrossToNetResponseModel> GrossToNetReport(int businessId, GrossToNetReportQueryModel request)
        {
            return ApiRequest<List<AuGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?employeeId={request.EmployeeId}{ConvertEnumerableToQueryString("payCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public Task<List<AuGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, GrossToNetReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?employeeId={request.EmployeeId}{ConvertEnumerableToQueryString("payCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Journal Report
        /// </summary>
        /// <remarks>
        /// Gets the journal for a finalised pay run with the specified Id.
        /// </remarks>
        public void JournalReport(int businessId, JournalReportQueryModel request)
        {
            ApiRequest($"/business/{businessId}/report/journal?payRunId={request.PayRunId}&journalView={request.JournalView}&journalService={request.JournalService}", Method.Get);
        }

        /// <summary>
        /// Journal Report
        /// </summary>
        /// <remarks>
        /// Gets the journal for a finalised pay run with the specified Id.
        /// </remarks>
        public Task JournalReportAsync(int businessId, JournalReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/report/journal?payRunId={request.PayRunId}&journalView={request.JournalView}&journalService={request.JournalService}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public List<AuLeaveBalancesExportModel> LeaveBalancesReport(int businessId)
        {
            return ApiRequest<List<AuLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances", Method.Get);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public Task<List<AuLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public List<AuLeaveBalancesExportModel> LeaveBalancesReport(int businessId, LeaveBalancesReportQueryModel request)
        {
            return ApiRequest<List<AuLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&groupBy={request.GroupBy}&employingEntityId={request.EmployingEntityId}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public Task<List<AuLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, LeaveBalancesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&groupBy={request.GroupBy}&employingEntityId={request.EmployingEntityId}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave History Report
        /// </summary>
        /// <remarks>
        /// Generates a leave history report.
        /// </remarks>
        public List<LeaveHistoryReportGroupModel> LeaveHistoryReport(int businessId)
        {
            return ApiRequest<List<LeaveHistoryReportGroupModel>>($"/business/{businessId}/report/leavehistory", Method.Get);
        }

        /// <summary>
        /// Leave History Report
        /// </summary>
        /// <remarks>
        /// Generates a leave history report.
        /// </remarks>
        public Task<List<LeaveHistoryReportGroupModel>> LeaveHistoryReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveHistoryReportGroupModel>>($"/business/{businessId}/report/leavehistory", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave History Report
        /// </summary>
        /// <remarks>
        /// Generates a leave history report.
        /// </remarks>
        public List<LeaveHistoryReportGroupModel> LeaveHistoryReport(int businessId, LeaveHistoryReportQueryModel request)
        {
            return ApiRequest<List<LeaveHistoryReportGroupModel>>($"/business/{businessId}/report/leavehistory?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ConvertEnumerableToQueryString("employeeId", request.EmployeeId?.Select(x => x.ToString()))}&leaveCategoryId={request.LeaveCategoryId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Leave History Report
        /// </summary>
        /// <remarks>
        /// Generates a leave history report.
        /// </remarks>
        public Task<List<LeaveHistoryReportGroupModel>> LeaveHistoryReportAsync(int businessId, LeaveHistoryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveHistoryReportGroupModel>>($"/business/{businessId}/report/leavehistory?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ConvertEnumerableToQueryString("employeeId", request.EmployeeId?.Select(x => x.ToString()))}&leaveCategoryId={request.LeaveCategoryId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Liability Report
        /// </summary>
        /// <remarks>
        /// Generates a leave liability report.
        /// </remarks>
        public List<AuLeaveLiabilityExportModel> LeaveLiabilityReport(int businessId)
        {
            return ApiRequest<List<AuLeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability", Method.Get);
        }

        /// <summary>
        /// Leave Liability Report
        /// </summary>
        /// <remarks>
        /// Generates a leave liability report.
        /// </remarks>
        public Task<List<AuLeaveLiabilityExportModel>> LeaveLiabilityReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuLeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Liability Report
        /// </summary>
        /// <remarks>
        /// Generates a leave liability report.
        /// </remarks>
        public List<AuLeaveLiabilityExportModel> LeaveLiabilityReport(int businessId, LeaveLiabilityReportQueryModel request)
        {
            return ApiRequest<List<AuLeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&includeApprovedLeave={request.IncludeApprovedLeave}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Leave Liability Report
        /// </summary>
        /// <remarks>
        /// Generates a leave liability report.
        /// </remarks>
        public Task<List<AuLeaveLiabilityExportModel>> LeaveLiabilityReportAsync(int businessId, LeaveLiabilityReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuLeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&includeApprovedLeave={request.IncludeApprovedLeave}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Ordinary Time Earnings Report
        /// </summary>
        /// <remarks>
        /// Generates an ordinary time earnings report.
        /// </remarks>
        public List<AuOrdinaryTimeEarningsApiModel> OrdinaryTimeEarningsReport(int businessId)
        {
            return ApiRequest<List<AuOrdinaryTimeEarningsApiModel>>($"/business/{businessId}/report/ordinarytimeearnings", Method.Get);
        }

        /// <summary>
        /// Ordinary Time Earnings Report
        /// </summary>
        /// <remarks>
        /// Generates an ordinary time earnings report.
        /// </remarks>
        public Task<List<AuOrdinaryTimeEarningsApiModel>> OrdinaryTimeEarningsReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuOrdinaryTimeEarningsApiModel>>($"/business/{businessId}/report/ordinarytimeearnings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Ordinary Time Earnings Report
        /// </summary>
        /// <remarks>
        /// Generates an ordinary time earnings report.
        /// </remarks>
        public List<AuOrdinaryTimeEarningsApiModel> OrdinaryTimeEarningsReport(int businessId, OrdinaryTimeEarningsReportQueryModel request)
        {
            return ApiRequest<List<AuOrdinaryTimeEarningsApiModel>>($"/business/{businessId}/report/ordinarytimeearnings?payScheduleId={request.PayScheduleId}&employingEntityId={request.EmployingEntityId}&financialYearEnding={request.FinancialYearEnding}", Method.Get);
        }

        /// <summary>
        /// Ordinary Time Earnings Report
        /// </summary>
        /// <remarks>
        /// Generates an ordinary time earnings report.
        /// </remarks>
        public Task<List<AuOrdinaryTimeEarningsApiModel>> OrdinaryTimeEarningsReportAsync(int businessId, OrdinaryTimeEarningsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuOrdinaryTimeEarningsApiModel>>($"/business/{businessId}/report/ordinarytimeearnings?payScheduleId={request.PayScheduleId}&employingEntityId={request.EmployingEntityId}&financialYearEnding={request.FinancialYearEnding}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public List<AuPayCategoriesModel> PayCategoriesReport(int businessId)
        {
            return ApiRequest<List<AuPayCategoriesModel>>($"/business/{businessId}/report/paycategories", Method.Get);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public Task<List<AuPayCategoriesModel>> PayCategoriesReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuPayCategoriesModel>>($"/business/{businessId}/report/paycategories", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public List<AuPayCategoriesModel> PayCategoriesReport(int businessId, PayCategoriesReportQueryModel request)
        {
            return ApiRequest<List<AuPayCategoriesModel>>($"/business/{businessId}/report/paycategories?payScheduleId={request.PayScheduleId}&employeeId={request.EmployeeId}&groupByEarningsLocation={request.GroupByEarningsLocation}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public Task<List<AuPayCategoriesModel>> PayCategoriesReportAsync(int businessId, PayCategoriesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuPayCategoriesModel>>($"/business/{businessId}/report/paycategories?payScheduleId={request.PayScheduleId}&employeeId={request.EmployeeId}&groupByEarningsLocation={request.GroupByEarningsLocation}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// PAYG Report
        /// </summary>
        /// <remarks>
        /// Generates a PAYG report.
        /// </remarks>
        public List<PaygReportExportModel> PaygReport(int businessId)
        {
            return ApiRequest<List<PaygReportExportModel>>($"/business/{businessId}/report/payg", Method.Get);
        }

        /// <summary>
        /// PAYG Report
        /// </summary>
        /// <remarks>
        /// Generates a PAYG report.
        /// </remarks>
        public Task<List<PaygReportExportModel>> PaygReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PaygReportExportModel>>($"/business/{businessId}/report/payg", Method.Get, cancellationToken);
        }

        /// <summary>
        /// PAYG Report
        /// </summary>
        /// <remarks>
        /// Generates a PAYG report.
        /// </remarks>
        public List<PaygReportExportModel> PaygReport(int businessId, PaygReportQueryModel request)
        {
            return ApiRequest<List<PaygReportExportModel>>($"/business/{businessId}/report/payg?state={request.State}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// PAYG Report
        /// </summary>
        /// <remarks>
        /// Generates a PAYG report.
        /// </remarks>
        public Task<List<PaygReportExportModel>> PaygReportAsync(int businessId, PaygReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PaygReportExportModel>>($"/business/{businessId}/report/payg?state={request.State}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public List<AuPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId)
        {
            return ApiRequest<List<AuPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory", Method.Get);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public Task<List<AuPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public List<AuPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId, EmployeePaymentHistoryReportQueryModel request)
        {
            return ApiRequest<List<AuPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?employeeId={request.EmployeeId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public Task<List<AuPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, EmployeePaymentHistoryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?employeeId={request.EmployeeId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Payroll Tax Report
        /// </summary>
        /// <remarks>
        /// Generates a payroll tax report.
        /// </remarks>
        public List<PayrollTaxReportExportModel> PayrollTaxReport(int businessId)
        {
            return ApiRequest<List<PayrollTaxReportExportModel>>($"/business/{businessId}/report/payrolltax", Method.Get);
        }

        /// <summary>
        /// Payroll Tax Report
        /// </summary>
        /// <remarks>
        /// Generates a payroll tax report.
        /// </remarks>
        public Task<List<PayrollTaxReportExportModel>> PayrollTaxReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayrollTaxReportExportModel>>($"/business/{businessId}/report/payrolltax", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Payroll Tax Report
        /// </summary>
        /// <remarks>
        /// Generates a payroll tax report.
        /// </remarks>
        public List<PayrollTaxReportExportModel> PayrollTaxReport(int businessId, PayrollTaxReportQueryModel request)
        {
            return ApiRequest<List<PayrollTaxReportExportModel>>($"/business/{businessId}/report/payrolltax?groupBy={request.GroupBy}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Payroll Tax Report
        /// </summary>
        /// <remarks>
        /// Generates a payroll tax report.
        /// </remarks>
        public Task<List<PayrollTaxReportExportModel>> PayrollTaxReportAsync(int businessId, PayrollTaxReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayrollTaxReportExportModel>>($"/business/{businessId}/report/payrolltax?groupBy={request.GroupBy}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run activity report.
        /// </remarks>
        public List<ActivityReportExportModel> PayRunActivityReport(int businessId, PayRunActivityReportQueryModel request)
        {
            return ApiRequest<List<ActivityReportExportModel>>($"/business/{businessId}/report/payrunactivity?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&payScheduleId={request.PayScheduleId}&locationId={request.LocationId}", Method.Get);
        }

        /// <summary>
        /// Pay Run Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run activity report.
        /// </remarks>
        public Task<List<ActivityReportExportModel>> PayRunActivityReportAsync(int businessId, PayRunActivityReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ActivityReportExportModel>>($"/business/{businessId}/report/payrunactivity?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&payScheduleId={request.PayScheduleId}&locationId={request.LocationId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public List<AuPayRunInclusionExportModel> PayRunInclusionsReport(int businessId)
        {
            return ApiRequest<List<AuPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions", Method.Get);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public Task<List<AuPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public List<AuPayRunInclusionExportModel> PayRunInclusionsReport(int businessId, PayRunInclusionsReportQueryModel request)
        {
            return ApiRequest<List<AuPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?employeeId={request.EmployeeId}&status={request.Status}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public Task<List<AuPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, PayRunInclusionsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?employeeId={request.EmployeeId}&status={request.Status}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Pay Slips by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the pay slips for a finalised pay run with the specified Id.
        /// </remarks>
        public void GetPaySlipsByFinalisedPayRunId(int businessId)
        {
            ApiRequest($"/business/{businessId}/report/payslip", Method.Get);
        }

        /// <summary>
        /// Get Pay Slips by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the pay slips for a finalised pay run with the specified Id.
        /// </remarks>
        public Task GetPaySlipsByFinalisedPayRunIdAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/report/payslip", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Pay Slips by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the pay slips for a finalised pay run with the specified Id.
        /// </remarks>
        public void GetPaySlipsByFinalisedPayRunId(int businessId, GetPaySlipsByFinalisedPayRunIdQueryModel request)
        {
            ApiRequest($"/business/{businessId}/report/payslip?payRunId={request.PayRunId}&employeeId={request.EmployeeId}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Get Pay Slips by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the pay slips for a finalised pay run with the specified Id.
        /// </remarks>
        public Task GetPaySlipsByFinalisedPayRunIdAsync(int businessId, GetPaySlipsByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/report/payslip?payRunId={request.PayRunId}&employeeId={request.EmployeeId}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public List<AuRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId)
        {
            return ApiRequest<List<AuRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison", Method.Get);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public Task<List<AuRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public List<AuRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId, RosterVsTimesheetComparisonReportQueryModel request)
        {
            return ApiRequest<List<AuRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?employmentTypeId={request.EmploymentTypeId}&employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("timesheetStatuses", request.TimesheetStatuses?.Select(x => x.ToString()))}&workTypeId={request.WorkTypeId}&rosterLocationId={request.RosterLocationId}&timesheetLocationId={request.TimesheetLocationId}{ConvertEnumerableToQueryString("rosterStatuses", request.RosterStatuses?.Select(x => x.ToString()))}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public Task<List<AuRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, RosterVsTimesheetComparisonReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?employmentTypeId={request.EmploymentTypeId}&employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("timesheetStatuses", request.TimesheetStatuses?.Select(x => x.ToString()))}&workTypeId={request.WorkTypeId}&rosterLocationId={request.RosterLocationId}&timesheetLocationId={request.TimesheetLocationId}{ConvertEnumerableToQueryString("rosterStatuses", request.RosterStatuses?.Select(x => x.ToString()))}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
            return ApiRequest<List<ShiftSwappingReportExportModel>>($"/business/{businessId}/report/shiftswapping?fromEmployeeId={request.FromEmployeeId}&toEmployeeId={request.ToEmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("statuses", request.Statuses?.Select(x => x.ToString()))}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Get shift swapping report by business id
        /// </summary>
        public Task<List<ShiftSwappingReportExportModel>> GetShiftSwappingReportByBusinessIdAsync(int businessId, GetShiftSwappingReportByBusinessIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ShiftSwappingReportExportModel>>($"/business/{businessId}/report/shiftswapping?fromEmployeeId={request.FromEmployeeId}&toEmployeeId={request.ToEmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("statuses", request.Statuses?.Select(x => x.ToString()))}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Super Contribution Report (By Employee)
        /// </summary>
        /// <remarks>
        /// Generates a super contribution report by employee.
        /// </remarks>
        public List<SuperAccrualExportModel> SuperContributionReportByEmployee(int businessId)
        {
            return ApiRequest<List<SuperAccrualExportModel>>($"/business/{businessId}/report/supercontributions/byemployee", Method.Get);
        }

        /// <summary>
        /// Super Contribution Report (By Employee)
        /// </summary>
        /// <remarks>
        /// Generates a super contribution report by employee.
        /// </remarks>
        public Task<List<SuperAccrualExportModel>> SuperContributionReportByEmployeeAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SuperAccrualExportModel>>($"/business/{businessId}/report/supercontributions/byemployee", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Super Contribution Report (By Employee)
        /// </summary>
        /// <remarks>
        /// Generates a super contribution report by employee.
        /// </remarks>
        public List<SuperAccrualExportModel> SuperContributionReportByEmployee(int businessId, SuperContributionReportByEmployeeQueryModel request)
        {
            return ApiRequest<List<SuperAccrualExportModel>>($"/business/{businessId}/report/supercontributions/byemployee?payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Super Contribution Report (By Employee)
        /// </summary>
        /// <remarks>
        /// Generates a super contribution report by employee.
        /// </remarks>
        public Task<List<SuperAccrualExportModel>> SuperContributionReportByEmployeeAsync(int businessId, SuperContributionReportByEmployeeQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SuperAccrualExportModel>>($"/business/{businessId}/report/supercontributions/byemployee?payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Super Contribution Report (By Super Fund)
        /// </summary>
        /// <remarks>
        /// Generates a super contribution report by super fund.
        /// </remarks>
        public List<SuperContributionsReportExportModel> SuperContributionReportBySuperFund(int businessId)
        {
            return ApiRequest<List<SuperContributionsReportExportModel>>($"/business/{businessId}/report/supercontributions/bysuperfund", Method.Get);
        }

        /// <summary>
        /// Super Contribution Report (By Super Fund)
        /// </summary>
        /// <remarks>
        /// Generates a super contribution report by super fund.
        /// </remarks>
        public Task<List<SuperContributionsReportExportModel>> SuperContributionReportBySuperFundAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SuperContributionsReportExportModel>>($"/business/{businessId}/report/supercontributions/bysuperfund", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Super Contribution Report (By Super Fund)
        /// </summary>
        /// <remarks>
        /// Generates a super contribution report by super fund.
        /// </remarks>
        public List<SuperContributionsReportExportModel> SuperContributionReportBySuperFund(int businessId, SuperContributionReportBySuperFundQueryModel request)
        {
            return ApiRequest<List<SuperContributionsReportExportModel>>($"/business/{businessId}/report/supercontributions/bysuperfund?payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Super Contribution Report (By Super Fund)
        /// </summary>
        /// <remarks>
        /// Generates a super contribution report by super fund.
        /// </remarks>
        public Task<List<SuperContributionsReportExportModel>> SuperContributionReportBySuperFundAsync(int businessId, SuperContributionReportBySuperFundQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SuperContributionsReportExportModel>>($"/business/{businessId}/report/supercontributions/bysuperfund?payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
            return ApiRequest<List<TasksReportExportModel>>($"/business/{businessId}/report/tasks?employeeId={request.EmployeeId}&payRunId={request.PayRunId}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&payScheduleId={request.PayScheduleId}&status={request.Status}", Method.Get);
        }

        /// <summary>
        /// Get tasks by business id
        /// </summary>
        public Task<List<TasksReportExportModel>> GetTasksByBusinessIdAsync(int businessId, GetTasksByBusinessIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TasksReportExportModel>>($"/business/{businessId}/report/tasks?employeeId={request.EmployeeId}&payRunId={request.PayRunId}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&payScheduleId={request.PayScheduleId}&status={request.Status}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public List<AuTimesheetExportModel> TimesheetReport(int businessId)
        {
            return ApiRequest<List<AuTimesheetExportModel>>($"/business/{businessId}/report/timesheet", Method.Get);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public Task<List<AuTimesheetExportModel>> TimesheetReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuTimesheetExportModel>>($"/business/{businessId}/report/timesheet", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public List<AuTimesheetExportModel> TimesheetReport(int businessId, TimesheetReportQueryModel request)
        {
            return ApiRequest<List<AuTimesheetExportModel>>($"/business/{businessId}/report/timesheet?employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("statuses", request.Statuses?.Select(x => x.ToString()))}&workTypeId={request.WorkTypeId}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public Task<List<AuTimesheetExportModel>> TimesheetReportAsync(int businessId, TimesheetReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuTimesheetExportModel>>($"/business/{businessId}/report/timesheet?employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("statuses", request.Statuses?.Select(x => x.ToString()))}&workTypeId={request.WorkTypeId}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }
    }
}
