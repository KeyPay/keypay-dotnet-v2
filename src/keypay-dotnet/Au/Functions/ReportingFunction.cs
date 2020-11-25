using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.Reporting;

namespace KeyPayV2.Au.Functions
{
    public class ReportingFunction : BaseFunction
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
            return ApiRequest<List<BirthdayReportExportModel>>($"/business/{businessId}/report/birthday?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}");
        }

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public List<AuCostingReportApiModel> CostingReport(int businessId, CostingReportQueryModel request)
        {
            return ApiRequest<List<AuCostingReportApiModel>>($"/business/{businessId}/report/costing?showZeroPayCategories={request.ShowZeroPayCategories}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Deductions Report
        /// </summary>
        /// <remarks>
        /// Generates a deductions report.
        /// </remarks>
        public List<DeductionsReportExportModel> DeductionsReport(int businessId, DeductionsReportQueryModel request)
        {
            return ApiRequest<List<DeductionsReportExportModel>>($"/business/{businessId}/report/deductions?employeeId={request.EmployeeId}&deductionCategoryId={request.DeductionCategoryId}&disableRollupReporting={request.DisableRollupReporting}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public List<AuDetailedActivityReportExportModel> DetailedActivityReport(int businessId, DetailedActivityReportQueryModel request)
        {
            return ApiRequest<List<AuDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Employee Details Report
        /// </summary>
        /// <remarks>
        /// Generates an employee details report.
        /// </remarks>
        public List<dynamic> EmployeeDetailsReport(int businessId, EmployeeDetailsReportQueryModel request)
        {
            return ApiRequest<List<dynamic>>($"/business/{businessId}/report/employeedetails?selectedColumns={request.SelectedColumns}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}&includeActive={request.IncludeActive}&includeInactive={request.IncludeInactive}");
        }

        /// <summary>
        /// Employee Details Report
        /// </summary>
        /// <remarks>
        /// Gets the fields for the Employee Details Report.
        /// </remarks>
        public List<EmployeeDetailsReportField> EmployeeDetailsReport(int businessId)
        {
            return ApiRequest<List<EmployeeDetailsReportField>>($"/business/{businessId}/report/employeedetails/fields");
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public List<AuGrossToNetResponseModel> GrossToNetReport(int businessId, GrossToNetReportQueryModel request)
        {
            return ApiRequest<List<AuGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?employeeId={request.EmployeeId}&payCategoryIds={request.PayCategoryIds}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Journal Report
        /// </summary>
        /// <remarks>
        /// Gets the journal for a finalised pay run with the specified Id.
        /// </remarks>
        public void JournalReport(int businessId, JournalReportQueryModel request)
        {
            ApiRequest($"/business/{businessId}/report/journal?payRunId={request.PayRunId}&journalView={request.JournalView}&journalService={request.JournalService}");
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public List<AuLeaveBalancesExportModel> LeaveBalancesReport(int businessId, LeaveBalancesReportQueryModel request)
        {
            return ApiRequest<List<AuLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&groupBy={request.GroupBy}&employingEntityId={request.EmployingEntityId}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}");
        }

        /// <summary>
        /// Leave History Report
        /// </summary>
        /// <remarks>
        /// Generates a leave history report.
        /// </remarks>
        public List<LeaveHistoryReportGroupModel> LeaveHistoryReport(int businessId, LeaveHistoryReportQueryModel request)
        {
            return ApiRequest<List<LeaveHistoryReportGroupModel>>($"/business/{businessId}/report/leavehistory?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&payScheduleId={request.PayScheduleId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&leaveCategoryId={request.LeaveCategoryId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Leave Liability Report
        /// </summary>
        /// <remarks>
        /// Generates a leave liability report.
        /// </remarks>
        public List<AuLeaveLiabilityExportModel> LeaveLiabilityReport(int businessId, LeaveLiabilityReportQueryModel request)
        {
            return ApiRequest<List<AuLeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&includeApprovedLeave={request.IncludeApprovedLeave}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Ordinary Time Earnings Report
        /// </summary>
        /// <remarks>
        /// Generates an ordinary time earnings report.
        /// </remarks>
        public List<AuOrdinaryTimeEarningsApiModel> OrdinaryTimeEarningsReport(int businessId, OrdinaryTimeEarningsReportQueryModel request)
        {
            return ApiRequest<List<AuOrdinaryTimeEarningsApiModel>>($"/business/{businessId}/report/ordinarytimeearnings?payScheduleId={request.PayScheduleId}&employingEntityId={request.EmployingEntityId}&financialYearEnding={request.FinancialYearEnding}");
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public List<AuPayCategoriesModel> PayCategoriesReport(int businessId, PayCategoriesReportQueryModel request)
        {
            return ApiRequest<List<AuPayCategoriesModel>>($"/business/{businessId}/report/paycategories?payScheduleId={request.PayScheduleId}&employeeId={request.EmployeeId}&groupByEarningsLocation={request.GroupByEarningsLocation}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// PAYG Report
        /// </summary>
        /// <remarks>
        /// Generates a PAYG report.
        /// </remarks>
        public List<PaygReportExportModel> PaygReport(int businessId, PaygReportQueryModel request)
        {
            return ApiRequest<List<PaygReportExportModel>>($"/business/{businessId}/report/payg?state={request.State}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public List<AuPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId, EmployeePaymentHistoryReportQueryModel request)
        {
            return ApiRequest<List<AuPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?employeeId={request.EmployeeId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Payroll Tax Report
        /// </summary>
        /// <remarks>
        /// Generates a payroll tax report.
        /// </remarks>
        public List<PayrollTaxReportExportModel> PayrollTaxReport(int businessId, PayrollTaxReportQueryModel request)
        {
            return ApiRequest<List<PayrollTaxReportExportModel>>($"/business/{businessId}/report/payrolltax?groupBy={request.GroupBy}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Pay Run Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run activity report.
        /// </remarks>
        public List<ActivityReportExportModel> PayRunActivityReport(int businessId, PayRunActivityReportQueryModel request)
        {
            return ApiRequest<List<ActivityReportExportModel>>($"/business/{businessId}/report/payrunactivity?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&payScheduleId={request.PayScheduleId}&locationId={request.LocationId}");
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public List<AuPayRunInclusionExportModel> PayRunInclusionsReport(int businessId, PayRunInclusionsReportQueryModel request)
        {
            return ApiRequest<List<AuPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?employeeId={request.EmployeeId}&status={request.Status}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public List<AuRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId, RosterVsTimesheetComparisonReportQueryModel request)
        {
            return ApiRequest<List<AuRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?employmentTypeId={request.EmploymentTypeId}&employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}&timesheetStatuses={request.TimesheetStatuses}&workTypeId={request.WorkTypeId}&rosterLocationId={request.RosterLocationId}&timesheetLocationId={request.TimesheetLocationId}&rosterStatuses={request.RosterStatuses}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Super Contribution Report (By Employee)
        /// </summary>
        /// <remarks>
        /// Generates a super contribution report by employee.
        /// </remarks>
        public List<SuperAccrualExportModel> SuperContributionReportByEmployee(int businessId, SuperContributionReportByEmployeeQueryModel request)
        {
            return ApiRequest<List<SuperAccrualExportModel>>($"/business/{businessId}/report/supercontributions/byemployee?payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Super Contribution Report (By Super Fund)
        /// </summary>
        /// <remarks>
        /// Generates a super contribution report by super fund.
        /// </remarks>
        public List<SuperContributionsReportExportModel> SuperContributionReportBySuperFund(int businessId, SuperContributionReportBySuperFundQueryModel request)
        {
            return ApiRequest<List<SuperContributionsReportExportModel>>($"/business/{businessId}/report/supercontributions/bysuperfund?payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public List<AuTimesheetExportModel> TimesheetReport(int businessId, TimesheetReportQueryModel request)
        {
            return ApiRequest<List<AuTimesheetExportModel>>($"/business/{businessId}/report/timesheet?employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}&statuses={request.Statuses}&workTypeId={request.WorkTypeId}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }
    }
}
