using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.Reporting;

namespace KeyPayV2.Uk.Functions
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
        public List<UkDetailedActivityReportExportModel> DetailedActivityReport(int businessId, DetailedActivityReportQueryModel request)
        {
            return ApiRequest<List<UkDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Employee Audit Report
        /// </summary>
        /// <remarks>
        /// Generates an Employee Audit Report.
        /// </remarks>
        public List<EmployeeDetailsAuditReportApiModel> EmployeeAuditReport(int businessId, EmployeeAuditReportQueryModel request)
        {
            return ApiRequest<List<EmployeeDetailsAuditReportApiModel>>($"/business/{businessId}/report/employeeaudit?employeeId={request.EmployeeId}&section={request.Section}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
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
        /// Employer Payment Summary Report
        /// </summary>
        public List<EmployerPaymentSummaryReportGridModel> EmployerPaymentSummaryReport(int businessId, EmployerPaymentSummaryReportQueryModel request)
        {
            return ApiRequest<List<EmployerPaymentSummaryReportGridModel>>($"/business/{businessId}/report/eps?financialYear={request.FinancialYear}");
        }

        /// <summary>
        /// Employer Payment Summary submission
        /// </summary>
        public EmployerPaymentSummaryReportGridModel EmployerPaymentSummarySubmission(int businessId, UkEmployerPaymentSummarySubmissionModel epsModel)
        {
            return ApiRequest<EmployerPaymentSummaryReportGridModel,UkEmployerPaymentSummarySubmissionModel>($"/business/{businessId}/report/eps", epsModel, Method.POST);
        }

        /// <summary>
        /// Employer Payment Summary Report
        /// </summary>
        public EmployerPaymentSummaryReportGridModel EmployerPaymentSummaryReport(int businessId, int id)
        {
            return ApiRequest<EmployerPaymentSummaryReportGridModel>($"/business/{businessId}/report/eps/{id}");
        }

        /// <summary>
        /// Employer Payment Summary XML By Id
        /// </summary>
        public byte[] EmployerPaymentSummaryXmlById(int businessId, int id)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/eps/{id}/xml");
        }

        /// <summary>
        /// Employer Payment Summary XML Without Submission
        /// </summary>
        public EpsResponseXmlModel EmployerPaymentSummaryXmlWithoutSubmission(int businessId, EmployerPaymentSummaryRequest epsModel)
        {
            return ApiRequest<EpsResponseXmlModel,EmployerPaymentSummaryRequest>($"/business/{businessId}/report/eps/epsxml", epsModel, Method.POST);
        }

        /// <summary>
        /// Submit Full Payment Summary submission
        /// </summary>
        public UkLodgePayRunSubmissionResult SubmitFullPaymentSummarySubmission(int businessId, UkFpsRequestApiModel fpsModel)
        {
            return ApiRequest<UkLodgePayRunSubmissionResult,UkFpsRequestApiModel>($"/business/{businessId}/report/fps", fpsModel, Method.POST);
        }

        /// <summary>
        /// Full Payment Summary XML Without Submission
        /// </summary>
        public FpsResponseXmlModel FullPaymentSummaryXmlWithoutSubmission(int businessId, UkFpsXmlApiModel fpsModel)
        {
            return ApiRequest<FpsResponseXmlModel,UkFpsXmlApiModel>($"/business/{businessId}/report/fps/fpsxml", fpsModel, Method.POST);
        }

        /// <summary>
        /// Full Payment Summary XML
        /// </summary>
        public byte[] FullPaymentSummaryXml(int businessId, string transactionid)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/fps/xml/{transactionid}");
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public List<UkGrossToNetResponseModel> GrossToNetReport(int businessId, GrossToNetReportQueryModel request)
        {
            return ApiRequest<List<UkGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?employeeId={request.EmployeeId}&payCategoryIds={request.PayCategoryIds}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
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
        public List<UkLeaveBalancesExportModel> LeaveBalancesReport(int businessId, LeaveBalancesReportQueryModel request)
        {
            return ApiRequest<List<UkLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&groupBy={request.GroupBy}&employingEntityId={request.EmployingEntityId}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}");
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
        public List<LeaveLiabilityExportModel> LeaveLiabilityReport(int businessId, LeaveLiabilityReportQueryModel request)
        {
            return ApiRequest<List<LeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&includeApprovedLeave={request.IncludeApprovedLeave}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Submit Exb Submission
        /// </summary>
        public LodgeExbApiResult SubmitExbSubmission(int businessId, ExbRequestApiModel exbModel)
        {
            return ApiRequest<LodgeExbApiResult,ExbRequestApiModel>($"/business/{businessId}/report/p11d", exbModel, Method.POST);
        }

        /// <summary>
        /// Publish P11d
        /// </summary>
        public P11dPublishApiResponseModel PublishP11d(int businessId, PublishP11dRequestModel publishP11dRequestModel)
        {
            return ApiRequest<P11dPublishApiResponseModel,PublishP11dRequestModel>($"/business/{businessId}/report/p11d/publish", publishP11dRequestModel, Method.POST);
        }

        /// <summary>
        /// Exb Xml Without Submission
        /// </summary>
        public ExbResponseXmlModel ExbXmlWithoutSubmission(int businessId, ExbXmlApiModel exbModel)
        {
            return ApiRequest<ExbResponseXmlModel,ExbXmlApiModel>($"/business/{businessId}/report/p11d/xml", exbModel, Method.POST);
        }

        /// <summary>
        /// Get P32 Report
        /// </summary>
        /// <remarks>
        /// Gets P32 Report for the financial year
        /// </remarks>
        public UkP32ReportModel GetP32Report(int businessId, GetP32ReportQueryModel request)
        {
            return ApiRequest<UkP32ReportModel>($"/business/{businessId}/report/p32?financialYearEnding={request.FinancialYearEnding}");
        }

        /// <summary>
        /// Get Apprenticeship Levy Summary Report
        /// </summary>
        /// <remarks>
        /// Gets Apprenticeship Levy Summary Report for the financial year
        /// </remarks>
        public UkApprenticeshipLevySummaryReportModel GetApprenticeshipLevySummaryReport(int businessId, GetApprenticeshipLevySummaryReportQueryModel request)
        {
            return ApiRequest<UkApprenticeshipLevySummaryReportModel>($"/business/{businessId}/report/p32/apprenticeshiplevy?financialYearEnding={request.FinancialYearEnding}");
        }

        /// <summary>
        /// Get CIS Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets CIS Deductions Summary Report for the financial year
        /// </remarks>
        public UkCISDeductionsSummaryReportModel GetCisDeductionsSummaryReport(int businessId, GetCisDeductionsSummaryReportQueryModel request)
        {
            return ApiRequest<UkCISDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/cisdeductionssummary?financialYearEnding={request.FinancialYearEnding}");
        }

        /// <summary>
        /// Get NI Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets NI Deductions Summary Report for the financial year
        /// </remarks>
        public UkNIDeductionsSummaryReportModel GetNiDeductionsSummaryReport(int businessId, GetNiDeductionsSummaryReportQueryModel request)
        {
            return ApiRequest<UkNIDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/nideductionssummary?financialYearEnding={request.FinancialYearEnding}");
        }

        /// <summary>
        /// Load P60 Data
        /// </summary>
        public UkP60SummaryForEmployeeDto LoadP60Data(int businessId, int employeeId, LoadP60DataQueryModel request)
        {
            return ApiRequest<UkP60SummaryForEmployeeDto>($"/business/{businessId}/report/p60/{employeeId}?locationId={request.LocationId}&startDate={request.StartDate.ToString("yyyy-MM-ddTHH:mm:ss")}&endDate={request.EndDate.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// List P60 Data
        /// </summary>
        public ListP60sResult ListP60Data(int businessId, ListP60DataQueryModel request)
        {
            return ApiRequest<ListP60sResult>($"/business/{businessId}/report/p60/list?financialYearEnding={request.FinancialYearEnding}&locationId={request.LocationId}");
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public List<UkPayCategoriesModel> PayCategoriesReport(int businessId, PayCategoriesReportQueryModel request)
        {
            return ApiRequest<List<UkPayCategoriesModel>>($"/business/{businessId}/report/paycategories?payScheduleId={request.PayScheduleId}&employeeId={request.EmployeeId}&groupByEarningsLocation={request.GroupByEarningsLocation}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public List<UkPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId, EmployeePaymentHistoryReportQueryModel request)
        {
            return ApiRequest<List<UkPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?employeeId={request.EmployeeId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public List<UkPayRunInclusionExportModel> PayRunInclusionsReport(int businessId, PayRunInclusionsReportQueryModel request)
        {
            return ApiRequest<List<UkPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?employeeId={request.EmployeeId}&status={request.Status}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Pension Contributions Report
        /// </summary>
        /// <remarks>
        /// Generates a pension contributions report.
        /// </remarks>
        public List<PensionContributionDataApiModel> PensionContributionsReport(int businessId, PensionContributionsReportQueryModel request)
        {
            return ApiRequest<List<PensionContributionDataApiModel>>($"/business/{businessId}/report/pensioncontributions?employeeId={request.EmployeeId}&payRunId={request.PayRunId}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&payScheduleId={request.PayScheduleId}&locationId={request.LocationId}");
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public List<UkRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId, RosterVsTimesheetComparisonReportQueryModel request)
        {
            return ApiRequest<List<UkRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}&timesheetStatuses={request.TimesheetStatuses}&workTypeId={request.WorkTypeId}&rosterLocationId={request.RosterLocationId}&timesheetLocationId={request.TimesheetLocationId}&rosterStatuses={request.RosterStatuses}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public List<UkTimesheetExportModel> TimesheetReport(int businessId, TimesheetReportQueryModel request)
        {
            return ApiRequest<List<UkTimesheetExportModel>>($"/business/{businessId}/report/timesheet?employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}&statuses={request.Statuses}&workTypeId={request.WorkTypeId}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}");
        }
    }
}
