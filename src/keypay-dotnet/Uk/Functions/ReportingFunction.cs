using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.Reporting;

namespace KeyPayV2.Uk.Functions
{
    public interface IReportingFunction
    {
        List<BirthdayReportExportModel> BirthdayReport(int businessId, BirthdayReportQueryModel request);
        Task<List<BirthdayReportExportModel>> BirthdayReportAsync(int businessId, BirthdayReportQueryModel request, CancellationToken cancellationToken = default);
        List<DeductionsReportExportModel> DeductionsReport(int businessId);
        Task<List<DeductionsReportExportModel>> DeductionsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<DeductionsReportExportModel> DeductionsReport(int businessId, DeductionsReportQueryModel request);
        Task<List<DeductionsReportExportModel>> DeductionsReportAsync(int businessId, DeductionsReportQueryModel request, CancellationToken cancellationToken = default);
        List<UkDetailedActivityReportExportModel> DetailedActivityReport(int businessId);
        Task<List<UkDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkDetailedActivityReportExportModel> DetailedActivityReport(int businessId, DetailedActivityReportQueryModel request);
        Task<List<UkDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, DetailedActivityReportQueryModel request, CancellationToken cancellationToken = default);
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
        List<EmployerPaymentSummaryReportGridModel> EmployerPaymentSummaryReport(int businessId, EmployerPaymentSummaryReportQueryModel request);
        Task<List<EmployerPaymentSummaryReportGridModel>> EmployerPaymentSummaryReportAsync(int businessId, EmployerPaymentSummaryReportQueryModel request, CancellationToken cancellationToken = default);
        EmployerPaymentSummaryReportGridModel EmployerPaymentSummarySubmission(int businessId, UkEmployerPaymentSummarySubmissionModel epsModel);
        Task<EmployerPaymentSummaryReportGridModel> EmployerPaymentSummarySubmissionAsync(int businessId, UkEmployerPaymentSummarySubmissionModel epsModel, CancellationToken cancellationToken = default);
        EmployerPaymentSummaryReportGridModel EmployerPaymentSummaryReport(int businessId, int id);
        Task<EmployerPaymentSummaryReportGridModel> EmployerPaymentSummaryReportAsync(int businessId, int id, CancellationToken cancellationToken = default);
        byte[] EmployerPaymentSummaryXmlById(int businessId, int id);
        Task<byte[]> EmployerPaymentSummaryXmlByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        EpsResponseXmlApiModel EmployerPaymentSummaryXmlWithoutSubmission(int businessId, EmployerPaymentSummaryRequest epsModel);
        Task<EpsResponseXmlApiModel> EmployerPaymentSummaryXmlWithoutSubmissionAsync(int businessId, EmployerPaymentSummaryRequest epsModel, CancellationToken cancellationToken = default);
        UkLodgePayRunSubmissionResult SubmitFullPaymentSummarySubmission(int businessId, UkFpsRequestApiModel fpsModel);
        Task<UkLodgePayRunSubmissionResult> SubmitFullPaymentSummarySubmissionAsync(int businessId, UkFpsRequestApiModel fpsModel, CancellationToken cancellationToken = default);
        FpsResponseXmlModel FullPaymentSummaryXmlWithoutSubmission(int businessId, UkFpsXmlApiModel fpsModel);
        Task<FpsResponseXmlModel> FullPaymentSummaryXmlWithoutSubmissionAsync(int businessId, UkFpsXmlApiModel fpsModel, CancellationToken cancellationToken = default);
        byte[] FullPaymentSummaryXml(int businessId, string transactionid);
        Task<byte[]> FullPaymentSummaryXmlAsync(int businessId, string transactionid, CancellationToken cancellationToken = default);
        List<UkGrossToNetResponseModel> GrossToNetReport(int businessId);
        Task<List<UkGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkGrossToNetResponseModel> GrossToNetReport(int businessId, GrossToNetReportQueryModel request);
        Task<List<UkGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, GrossToNetReportQueryModel request, CancellationToken cancellationToken = default);
        void JournalReport(int businessId, JournalReportQueryModel request);
        Task JournalReportAsync(int businessId, JournalReportQueryModel request, CancellationToken cancellationToken = default);
        List<UkLeaveBalancesExportModel> LeaveBalancesReport(int businessId);
        Task<List<UkLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkLeaveBalancesExportModel> LeaveBalancesReport(int businessId, LeaveBalancesReportQueryModel request);
        Task<List<UkLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, LeaveBalancesReportQueryModel request, CancellationToken cancellationToken = default);
        List<LeaveHistoryReportGroupModel> LeaveHistoryReport(int businessId);
        Task<List<LeaveHistoryReportGroupModel>> LeaveHistoryReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<LeaveHistoryReportGroupModel> LeaveHistoryReport(int businessId, LeaveHistoryReportQueryModel request);
        Task<List<LeaveHistoryReportGroupModel>> LeaveHistoryReportAsync(int businessId, LeaveHistoryReportQueryModel request, CancellationToken cancellationToken = default);
        List<LeaveLiabilityExportModel> LeaveLiabilityReport(int businessId);
        Task<List<LeaveLiabilityExportModel>> LeaveLiabilityReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<LeaveLiabilityExportModel> LeaveLiabilityReport(int businessId, LeaveLiabilityReportQueryModel request);
        Task<List<LeaveLiabilityExportModel>> LeaveLiabilityReportAsync(int businessId, LeaveLiabilityReportQueryModel request, CancellationToken cancellationToken = default);
        LodgeExbApiResult SubmitExbSubmission(int businessId, ExbRequestApiModel exbModel);
        Task<LodgeExbApiResult> SubmitExbSubmissionAsync(int businessId, ExbRequestApiModel exbModel, CancellationToken cancellationToken = default);
        P11dPublishApiResponseModel PublishP11d(int businessId, PublishP11dRequestModel publishP11dRequestModel);
        Task<P11dPublishApiResponseModel> PublishP11dAsync(int businessId, PublishP11dRequestModel publishP11dRequestModel, CancellationToken cancellationToken = default);
        ExbResponseXmlModel ExbXmlWithoutSubmission(int businessId, ExbXmlApiModel exbModel);
        Task<ExbResponseXmlModel> ExbXmlWithoutSubmissionAsync(int businessId, ExbXmlApiModel exbModel, CancellationToken cancellationToken = default);
        UkP32ReportModel GetP32Report(int businessId, GetP32ReportQueryModel request);
        Task<UkP32ReportModel> GetP32ReportAsync(int businessId, GetP32ReportQueryModel request, CancellationToken cancellationToken = default);
        UkP32ReportModel UpdateP32Report(int businessId, IList<UkP32RequestModel> p32Requests, UpdateP32ReportQueryModel request);
        Task<UkP32ReportModel> UpdateP32ReportAsync(int businessId, IList<UkP32RequestModel> p32Requests, UpdateP32ReportQueryModel request, CancellationToken cancellationToken = default);
        UkApprenticeshipLevySummaryReportModel GetApprenticeshipLevySummaryReport(int businessId, GetApprenticeshipLevySummaryReportQueryModel request);
        Task<UkApprenticeshipLevySummaryReportModel> GetApprenticeshipLevySummaryReportAsync(int businessId, GetApprenticeshipLevySummaryReportQueryModel request, CancellationToken cancellationToken = default);
        UkCISDeductionsSummaryReportModel GetCisDeductionsSummaryReport(int businessId, GetCisDeductionsSummaryReportQueryModel request);
        Task<UkCISDeductionsSummaryReportModel> GetCisDeductionsSummaryReportAsync(int businessId, GetCisDeductionsSummaryReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] GetHmrcPaymentFile(int businessId);
        Task<byte[]> GetHmrcPaymentFileAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] GetHmrcPaymentFile(int businessId, GetHmrcPaymentFileQueryModel request);
        Task<byte[]> GetHmrcPaymentFileAsync(int businessId, GetHmrcPaymentFileQueryModel request, CancellationToken cancellationToken = default);
        UkNIDeductionsSummaryReportModel GetNiDeductionsSummaryReport(int businessId, GetNiDeductionsSummaryReportQueryModel request);
        Task<UkNIDeductionsSummaryReportModel> GetNiDeductionsSummaryReportAsync(int businessId, GetNiDeductionsSummaryReportQueryModel request, CancellationToken cancellationToken = default);
        UkP32ReportAdjustmentsModel GetP32OpeningBalancesAdjustments(int businessId);
        Task<UkP32ReportAdjustmentsModel> GetP32OpeningBalancesAdjustmentsAsync(int businessId, CancellationToken cancellationToken = default);
        UkP32ReportAdjustmentsModel UpdateP32OpeningBalancesAdjustments(int businessId, UkP32ReportAdjustmentsModel p32AdjustmentRequestModel);
        Task<UkP32ReportAdjustmentsModel> UpdateP32OpeningBalancesAdjustmentsAsync(int businessId, UkP32ReportAdjustmentsModel p32AdjustmentRequestModel, CancellationToken cancellationToken = default);
        UkGetP46CarResponseModel GetP46CarReports(int businessId, GetP46CarReportsQueryModel request);
        Task<UkGetP46CarResponseModel> GetP46CarReportsAsync(int businessId, GetP46CarReportsQueryModel request, CancellationToken cancellationToken = default);
        UkP46CarModel IgnoreP46CarDetail(int businessId, UkIgnoreP46CarModel model);
        Task<UkP46CarModel> IgnoreP46CarDetailAsync(int businessId, UkIgnoreP46CarModel model, CancellationToken cancellationToken = default);
        UkP60SummaryForEmployeeDto LoadP60Data(int businessId, int employeeId, LoadP60DataQueryModel request);
        Task<UkP60SummaryForEmployeeDto> LoadP60DataAsync(int businessId, int employeeId, LoadP60DataQueryModel request, CancellationToken cancellationToken = default);
        IsPublishedP60ResponseModel ShowP60Status(int businessId, IsPublishedP60RequestModel isPublishedP60RequestModel);
        Task<IsPublishedP60ResponseModel> ShowP60StatusAsync(int businessId, IsPublishedP60RequestModel isPublishedP60RequestModel, CancellationToken cancellationToken = default);
        ListP60sResult ListP60Data(int businessId, ListP60DataQueryModel request);
        Task<ListP60sResult> ListP60DataAsync(int businessId, ListP60DataQueryModel request, CancellationToken cancellationToken = default);
        PublishP60ApiResponseModel PublishP60(int businessId, PublishP60RequestModel publishP60RequestModel);
        Task<PublishP60ApiResponseModel> PublishP60Async(int businessId, PublishP60RequestModel publishP60RequestModel, CancellationToken cancellationToken = default);
        List<UkPayCategoriesModel> PayCategoriesReport(int businessId);
        Task<List<UkPayCategoriesModel>> PayCategoriesReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkPayCategoriesModel> PayCategoriesReport(int businessId, PayCategoriesReportQueryModel request);
        Task<List<UkPayCategoriesModel>> PayCategoriesReportAsync(int businessId, PayCategoriesReportQueryModel request, CancellationToken cancellationToken = default);
        List<UkPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId);
        Task<List<UkPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId, EmployeePaymentHistoryReportQueryModel request);
        Task<List<UkPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, EmployeePaymentHistoryReportQueryModel request, CancellationToken cancellationToken = default);
        List<UkPayRunInclusionExportModel> PayRunInclusionsReport(int businessId);
        Task<List<UkPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkPayRunInclusionExportModel> PayRunInclusionsReport(int businessId, PayRunInclusionsReportQueryModel request);
        Task<List<UkPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, PayRunInclusionsReportQueryModel request, CancellationToken cancellationToken = default);
        void GetPaySlipsByFinalisedPayRunId(int businessId);
        Task GetPaySlipsByFinalisedPayRunIdAsync(int businessId, CancellationToken cancellationToken = default);
        void GetPaySlipsByFinalisedPayRunId(int businessId, GetPaySlipsByFinalisedPayRunIdQueryModel request);
        Task GetPaySlipsByFinalisedPayRunIdAsync(int businessId, GetPaySlipsByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default);
        List<PensionContributionDataApiModel> PensionContributionsReport(int businessId);
        Task<List<PensionContributionDataApiModel>> PensionContributionsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<PensionContributionDataApiModel> PensionContributionsReport(int businessId, PensionContributionsReportQueryModel request);
        Task<List<PensionContributionDataApiModel>> PensionContributionsReportAsync(int businessId, PensionContributionsReportQueryModel request, CancellationToken cancellationToken = default);
        List<UkRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId);
        Task<List<UkRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId, RosterVsTimesheetComparisonReportQueryModel request);
        Task<List<UkRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, RosterVsTimesheetComparisonReportQueryModel request, CancellationToken cancellationToken = default);
        List<ShiftSwappingReportExportModel> GetShiftSwappingReportByBusinessId(int businessId);
        Task<List<ShiftSwappingReportExportModel>> GetShiftSwappingReportByBusinessIdAsync(int businessId, CancellationToken cancellationToken = default);
        List<ShiftSwappingReportExportModel> GetShiftSwappingReportByBusinessId(int businessId, GetShiftSwappingReportByBusinessIdQueryModel request);
        Task<List<ShiftSwappingReportExportModel>> GetShiftSwappingReportByBusinessIdAsync(int businessId, GetShiftSwappingReportByBusinessIdQueryModel request, CancellationToken cancellationToken = default);
        List<TasksReportExportModel> GetTasksByBusinessId(int businessId);
        Task<List<TasksReportExportModel>> GetTasksByBusinessIdAsync(int businessId, CancellationToken cancellationToken = default);
        List<TasksReportExportModel> GetTasksByBusinessId(int businessId, GetTasksByBusinessIdQueryModel request);
        Task<List<TasksReportExportModel>> GetTasksByBusinessIdAsync(int businessId, GetTasksByBusinessIdQueryModel request, CancellationToken cancellationToken = default);
        List<UkTimesheetExportModel> TimesheetReport(int businessId);
        Task<List<UkTimesheetExportModel>> TimesheetReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkTimesheetExportModel> TimesheetReport(int businessId, TimesheetReportQueryModel request);
        Task<List<UkTimesheetExportModel>> TimesheetReportAsync(int businessId, TimesheetReportQueryModel request, CancellationToken cancellationToken = default);
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
        public List<UkDetailedActivityReportExportModel> DetailedActivityReport(int businessId)
        {
            return ApiRequest<List<UkDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity", Method.Get);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public Task<List<UkDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public List<UkDetailedActivityReportExportModel> DetailedActivityReport(int businessId, DetailedActivityReportQueryModel request)
        {
            return ApiRequest<List<UkDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public Task<List<UkDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, DetailedActivityReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
        /// Employer Payment Summary Report
        /// </summary>
        public List<EmployerPaymentSummaryReportGridModel> EmployerPaymentSummaryReport(int businessId, EmployerPaymentSummaryReportQueryModel request)
        {
            return ApiRequest<List<EmployerPaymentSummaryReportGridModel>>($"/business/{businessId}/report/eps?financialYear={request.FinancialYear}", Method.Get);
        }

        /// <summary>
        /// Employer Payment Summary Report
        /// </summary>
        public Task<List<EmployerPaymentSummaryReportGridModel>> EmployerPaymentSummaryReportAsync(int businessId, EmployerPaymentSummaryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployerPaymentSummaryReportGridModel>>($"/business/{businessId}/report/eps?financialYear={request.FinancialYear}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employer Payment Summary submission
        /// </summary>
        public EmployerPaymentSummaryReportGridModel EmployerPaymentSummarySubmission(int businessId, UkEmployerPaymentSummarySubmissionModel epsModel)
        {
            return ApiRequest<EmployerPaymentSummaryReportGridModel,UkEmployerPaymentSummarySubmissionModel>($"/business/{businessId}/report/eps", epsModel, Method.Post);
        }

        /// <summary>
        /// Employer Payment Summary submission
        /// </summary>
        public Task<EmployerPaymentSummaryReportGridModel> EmployerPaymentSummarySubmissionAsync(int businessId, UkEmployerPaymentSummarySubmissionModel epsModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployerPaymentSummaryReportGridModel,UkEmployerPaymentSummarySubmissionModel>($"/business/{businessId}/report/eps", epsModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Employer Payment Summary Report
        /// </summary>
        public EmployerPaymentSummaryReportGridModel EmployerPaymentSummaryReport(int businessId, int id)
        {
            return ApiRequest<EmployerPaymentSummaryReportGridModel>($"/business/{businessId}/report/eps/{id}", Method.Get);
        }

        /// <summary>
        /// Employer Payment Summary Report
        /// </summary>
        public Task<EmployerPaymentSummaryReportGridModel> EmployerPaymentSummaryReportAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployerPaymentSummaryReportGridModel>($"/business/{businessId}/report/eps/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employer Payment Summary XML By Id
        /// </summary>
        public byte[] EmployerPaymentSummaryXmlById(int businessId, int id)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/eps/{id}/xml", Method.Get);
        }

        /// <summary>
        /// Employer Payment Summary XML By Id
        /// </summary>
        public Task<byte[]> EmployerPaymentSummaryXmlByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/eps/{id}/xml", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employer Payment Summary XML Without Submission
        /// </summary>
        public EpsResponseXmlApiModel EmployerPaymentSummaryXmlWithoutSubmission(int businessId, EmployerPaymentSummaryRequest epsModel)
        {
            return ApiRequest<EpsResponseXmlApiModel,EmployerPaymentSummaryRequest>($"/business/{businessId}/report/eps/epsxml", epsModel, Method.Post);
        }

        /// <summary>
        /// Employer Payment Summary XML Without Submission
        /// </summary>
        public Task<EpsResponseXmlApiModel> EmployerPaymentSummaryXmlWithoutSubmissionAsync(int businessId, EmployerPaymentSummaryRequest epsModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EpsResponseXmlApiModel,EmployerPaymentSummaryRequest>($"/business/{businessId}/report/eps/epsxml", epsModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Submit Full Payment Summary submission
        /// </summary>
        public UkLodgePayRunSubmissionResult SubmitFullPaymentSummarySubmission(int businessId, UkFpsRequestApiModel fpsModel)
        {
            return ApiRequest<UkLodgePayRunSubmissionResult,UkFpsRequestApiModel>($"/business/{businessId}/report/fps", fpsModel, Method.Post);
        }

        /// <summary>
        /// Submit Full Payment Summary submission
        /// </summary>
        public Task<UkLodgePayRunSubmissionResult> SubmitFullPaymentSummarySubmissionAsync(int businessId, UkFpsRequestApiModel fpsModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkLodgePayRunSubmissionResult,UkFpsRequestApiModel>($"/business/{businessId}/report/fps", fpsModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Full Payment Summary XML Without Submission
        /// </summary>
        public FpsResponseXmlModel FullPaymentSummaryXmlWithoutSubmission(int businessId, UkFpsXmlApiModel fpsModel)
        {
            return ApiRequest<FpsResponseXmlModel,UkFpsXmlApiModel>($"/business/{businessId}/report/fps/fpsxml", fpsModel, Method.Post);
        }

        /// <summary>
        /// Full Payment Summary XML Without Submission
        /// </summary>
        public Task<FpsResponseXmlModel> FullPaymentSummaryXmlWithoutSubmissionAsync(int businessId, UkFpsXmlApiModel fpsModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<FpsResponseXmlModel,UkFpsXmlApiModel>($"/business/{businessId}/report/fps/fpsxml", fpsModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Full Payment Summary XML
        /// </summary>
        public byte[] FullPaymentSummaryXml(int businessId, string transactionid)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/fps/xml/{transactionid}", Method.Get);
        }

        /// <summary>
        /// Full Payment Summary XML
        /// </summary>
        public Task<byte[]> FullPaymentSummaryXmlAsync(int businessId, string transactionid, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/fps/xml/{transactionid}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public List<UkGrossToNetResponseModel> GrossToNetReport(int businessId)
        {
            return ApiRequest<List<UkGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet", Method.Get);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public Task<List<UkGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public List<UkGrossToNetResponseModel> GrossToNetReport(int businessId, GrossToNetReportQueryModel request)
        {
            return ApiRequest<List<UkGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?employeeId={request.EmployeeId}{ConvertEnumerableToQueryString("payCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public Task<List<UkGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, GrossToNetReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?employeeId={request.EmployeeId}{ConvertEnumerableToQueryString("payCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
        public List<UkLeaveBalancesExportModel> LeaveBalancesReport(int businessId)
        {
            return ApiRequest<List<UkLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances", Method.Get);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public Task<List<UkLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public List<UkLeaveBalancesExportModel> LeaveBalancesReport(int businessId, LeaveBalancesReportQueryModel request)
        {
            return ApiRequest<List<UkLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&groupBy={request.GroupBy}&employingEntityId={request.EmployingEntityId}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public Task<List<UkLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, LeaveBalancesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&groupBy={request.GroupBy}&employingEntityId={request.EmployingEntityId}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
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
            return ApiRequest<List<LeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&includeApprovedLeave={request.IncludeApprovedLeave}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Leave Liability Report
        /// </summary>
        /// <remarks>
        /// Generates a leave liability report.
        /// </remarks>
        public Task<List<LeaveLiabilityExportModel>> LeaveLiabilityReportAsync(int businessId, LeaveLiabilityReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&includeApprovedLeave={request.IncludeApprovedLeave}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Submit Exb Submission
        /// </summary>
        public LodgeExbApiResult SubmitExbSubmission(int businessId, ExbRequestApiModel exbModel)
        {
            return ApiRequest<LodgeExbApiResult,ExbRequestApiModel>($"/business/{businessId}/report/p11d", exbModel, Method.Post);
        }

        /// <summary>
        /// Submit Exb Submission
        /// </summary>
        public Task<LodgeExbApiResult> SubmitExbSubmissionAsync(int businessId, ExbRequestApiModel exbModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<LodgeExbApiResult,ExbRequestApiModel>($"/business/{businessId}/report/p11d", exbModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Publish P11d
        /// </summary>
        public P11dPublishApiResponseModel PublishP11d(int businessId, PublishP11dRequestModel publishP11dRequestModel)
        {
            return ApiRequest<P11dPublishApiResponseModel,PublishP11dRequestModel>($"/business/{businessId}/report/p11d/publish", publishP11dRequestModel, Method.Post);
        }

        /// <summary>
        /// Publish P11d
        /// </summary>
        public Task<P11dPublishApiResponseModel> PublishP11dAsync(int businessId, PublishP11dRequestModel publishP11dRequestModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<P11dPublishApiResponseModel,PublishP11dRequestModel>($"/business/{businessId}/report/p11d/publish", publishP11dRequestModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Exb Xml Without Submission
        /// </summary>
        public ExbResponseXmlModel ExbXmlWithoutSubmission(int businessId, ExbXmlApiModel exbModel)
        {
            return ApiRequest<ExbResponseXmlModel,ExbXmlApiModel>($"/business/{businessId}/report/p11d/xml", exbModel, Method.Post);
        }

        /// <summary>
        /// Exb Xml Without Submission
        /// </summary>
        public Task<ExbResponseXmlModel> ExbXmlWithoutSubmissionAsync(int businessId, ExbXmlApiModel exbModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ExbResponseXmlModel,ExbXmlApiModel>($"/business/{businessId}/report/p11d/xml", exbModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get P32 Report
        /// </summary>
        /// <remarks>
        /// Gets P32 Report for the financial year
        /// </remarks>
        public UkP32ReportModel GetP32Report(int businessId, GetP32ReportQueryModel request)
        {
            return ApiRequest<UkP32ReportModel>($"/business/{businessId}/report/p32?financialYearEnding={request.FinancialYearEnding}", Method.Get);
        }

        /// <summary>
        /// Get P32 Report
        /// </summary>
        /// <remarks>
        /// Gets P32 Report for the financial year
        /// </remarks>
        public Task<UkP32ReportModel> GetP32ReportAsync(int businessId, GetP32ReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkP32ReportModel>($"/business/{businessId}/report/p32?financialYearEnding={request.FinancialYearEnding}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update P32 Report
        /// </summary>
        /// <remarks>
        /// Update P32 Report for the financial year
        /// </remarks>
        public UkP32ReportModel UpdateP32Report(int businessId, IList<UkP32RequestModel> p32Requests, UpdateP32ReportQueryModel request)
        {
            return ApiRequest<UkP32ReportModel,IList<UkP32RequestModel>>($"/business/{businessId}/report/p32?financialYearEnding={request.FinancialYearEnding}", p32Requests, Method.Put);
        }

        /// <summary>
        /// Update P32 Report
        /// </summary>
        /// <remarks>
        /// Update P32 Report for the financial year
        /// </remarks>
        public Task<UkP32ReportModel> UpdateP32ReportAsync(int businessId, IList<UkP32RequestModel> p32Requests, UpdateP32ReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkP32ReportModel,IList<UkP32RequestModel>>($"/business/{businessId}/report/p32?financialYearEnding={request.FinancialYearEnding}", p32Requests, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Apprenticeship Levy Summary Report
        /// </summary>
        /// <remarks>
        /// Gets Apprenticeship Levy Summary Report for the financial year
        /// </remarks>
        public UkApprenticeshipLevySummaryReportModel GetApprenticeshipLevySummaryReport(int businessId, GetApprenticeshipLevySummaryReportQueryModel request)
        {
            return ApiRequest<UkApprenticeshipLevySummaryReportModel>($"/business/{businessId}/report/p32/apprenticeshiplevy?financialYearEnding={request.FinancialYearEnding}", Method.Get);
        }

        /// <summary>
        /// Get Apprenticeship Levy Summary Report
        /// </summary>
        /// <remarks>
        /// Gets Apprenticeship Levy Summary Report for the financial year
        /// </remarks>
        public Task<UkApprenticeshipLevySummaryReportModel> GetApprenticeshipLevySummaryReportAsync(int businessId, GetApprenticeshipLevySummaryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkApprenticeshipLevySummaryReportModel>($"/business/{businessId}/report/p32/apprenticeshiplevy?financialYearEnding={request.FinancialYearEnding}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get CIS Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets CIS Deductions Summary Report for the financial year
        /// </remarks>
        public UkCISDeductionsSummaryReportModel GetCisDeductionsSummaryReport(int businessId, GetCisDeductionsSummaryReportQueryModel request)
        {
            return ApiRequest<UkCISDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/cisdeductionssummary?financialYearEnding={request.FinancialYearEnding}", Method.Get);
        }

        /// <summary>
        /// Get CIS Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets CIS Deductions Summary Report for the financial year
        /// </remarks>
        public Task<UkCISDeductionsSummaryReportModel> GetCisDeductionsSummaryReportAsync(int businessId, GetCisDeductionsSummaryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkCISDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/cisdeductionssummary?financialYearEnding={request.FinancialYearEnding}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Hmrc Payment File
        /// </summary>
        public byte[] GetHmrcPaymentFile(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/p32/hmrcpaymentfile", Method.Get);
        }

        /// <summary>
        /// Get Hmrc Payment File
        /// </summary>
        public Task<byte[]> GetHmrcPaymentFileAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/p32/hmrcpaymentfile", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Hmrc Payment File
        /// </summary>
        public byte[] GetHmrcPaymentFile(int businessId, GetHmrcPaymentFileQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/p32/hmrcpaymentfile?dateInPayPeriod={request.DateInPayPeriod.ToString("yyyy-MM-ddTHH:mm:ss")}&paymentPeriod={request.PaymentPeriod}", Method.Get);
        }

        /// <summary>
        /// Get Hmrc Payment File
        /// </summary>
        public Task<byte[]> GetHmrcPaymentFileAsync(int businessId, GetHmrcPaymentFileQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/p32/hmrcpaymentfile?dateInPayPeriod={request.DateInPayPeriod.ToString("yyyy-MM-ddTHH:mm:ss")}&paymentPeriod={request.PaymentPeriod}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get NI Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets NI Deductions Summary Report for the financial year
        /// </remarks>
        public UkNIDeductionsSummaryReportModel GetNiDeductionsSummaryReport(int businessId, GetNiDeductionsSummaryReportQueryModel request)
        {
            return ApiRequest<UkNIDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/nideductionssummary?financialYearEnding={request.FinancialYearEnding}", Method.Get);
        }

        /// <summary>
        /// Get NI Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets NI Deductions Summary Report for the financial year
        /// </remarks>
        public Task<UkNIDeductionsSummaryReportModel> GetNiDeductionsSummaryReportAsync(int businessId, GetNiDeductionsSummaryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkNIDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/nideductionssummary?financialYearEnding={request.FinancialYearEnding}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get P32 Opening Balances Adjustments
        /// </summary>
        /// <remarks>
        /// Get P32 Opening Balances Adjustments for the business' initial tax year using this software
        /// </remarks>
        public UkP32ReportAdjustmentsModel GetP32OpeningBalancesAdjustments(int businessId)
        {
            return ApiRequest<UkP32ReportAdjustmentsModel>($"/business/{businessId}/report/p32/openingbalancesadjustments", Method.Get);
        }

        /// <summary>
        /// Get P32 Opening Balances Adjustments
        /// </summary>
        /// <remarks>
        /// Get P32 Opening Balances Adjustments for the business' initial tax year using this software
        /// </remarks>
        public Task<UkP32ReportAdjustmentsModel> GetP32OpeningBalancesAdjustmentsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkP32ReportAdjustmentsModel>($"/business/{businessId}/report/p32/openingbalancesadjustments", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update P32 Opening Balances Adjustments
        /// </summary>
        /// <remarks>
        /// Update P32 Opening Balances Adjustments for the business' initial tax year using this software.
        /// </remarks>
        public UkP32ReportAdjustmentsModel UpdateP32OpeningBalancesAdjustments(int businessId, UkP32ReportAdjustmentsModel p32AdjustmentRequestModel)
        {
            return ApiRequest<UkP32ReportAdjustmentsModel,UkP32ReportAdjustmentsModel>($"/business/{businessId}/report/p32/openingbalancesadjustments", p32AdjustmentRequestModel, Method.Put);
        }

        /// <summary>
        /// Update P32 Opening Balances Adjustments
        /// </summary>
        /// <remarks>
        /// Update P32 Opening Balances Adjustments for the business' initial tax year using this software.
        /// </remarks>
        public Task<UkP32ReportAdjustmentsModel> UpdateP32OpeningBalancesAdjustmentsAsync(int businessId, UkP32ReportAdjustmentsModel p32AdjustmentRequestModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkP32ReportAdjustmentsModel,UkP32ReportAdjustmentsModel>($"/business/{businessId}/report/p32/openingbalancesadjustments", p32AdjustmentRequestModel, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get P46(Car) reports
        /// </summary>
        public UkGetP46CarResponseModel GetP46CarReports(int businessId, GetP46CarReportsQueryModel request)
        {
            return ApiRequest<UkGetP46CarResponseModel>($"/business/{businessId}/report/p46car?reportDate={request.ReportDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Get P46(Car) reports
        /// </summary>
        public Task<UkGetP46CarResponseModel> GetP46CarReportsAsync(int businessId, GetP46CarReportsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkGetP46CarResponseModel>($"/business/{businessId}/report/p46car?reportDate={request.ReportDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Ignore P46(Car) detail
        /// </summary>
        public UkP46CarModel IgnoreP46CarDetail(int businessId, UkIgnoreP46CarModel model)
        {
            return ApiRequest<UkP46CarModel,UkIgnoreP46CarModel>($"/business/{businessId}/report/p46car/ignore", model, Method.Post);
        }

        /// <summary>
        /// Ignore P46(Car) detail
        /// </summary>
        public Task<UkP46CarModel> IgnoreP46CarDetailAsync(int businessId, UkIgnoreP46CarModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkP46CarModel,UkIgnoreP46CarModel>($"/business/{businessId}/report/p46car/ignore", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Load P60 Data
        /// </summary>
        public UkP60SummaryForEmployeeDto LoadP60Data(int businessId, int employeeId, LoadP60DataQueryModel request)
        {
            return ApiRequest<UkP60SummaryForEmployeeDto>($"/business/{businessId}/report/p60/{employeeId}?locationId={request.LocationId}&startDate={request.StartDate.ToString("yyyy-MM-ddTHH:mm:ss")}&endDate={request.EndDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Load P60 Data
        /// </summary>
        public Task<UkP60SummaryForEmployeeDto> LoadP60DataAsync(int businessId, int employeeId, LoadP60DataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkP60SummaryForEmployeeDto>($"/business/{businessId}/report/p60/{employeeId}?locationId={request.LocationId}&startDate={request.StartDate.ToString("yyyy-MM-ddTHH:mm:ss")}&endDate={request.EndDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Show P60 Status
        /// </summary>
        public IsPublishedP60ResponseModel ShowP60Status(int businessId, IsPublishedP60RequestModel isPublishedP60RequestModel)
        {
            return ApiRequest<IsPublishedP60ResponseModel,IsPublishedP60RequestModel>($"/business/{businessId}/report/p60/ispublished", isPublishedP60RequestModel, Method.Post);
        }

        /// <summary>
        /// Show P60 Status
        /// </summary>
        public Task<IsPublishedP60ResponseModel> ShowP60StatusAsync(int businessId, IsPublishedP60RequestModel isPublishedP60RequestModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<IsPublishedP60ResponseModel,IsPublishedP60RequestModel>($"/business/{businessId}/report/p60/ispublished", isPublishedP60RequestModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List P60 Data
        /// </summary>
        public ListP60sResult ListP60Data(int businessId, ListP60DataQueryModel request)
        {
            return ApiRequest<ListP60sResult>($"/business/{businessId}/report/p60/list?financialYearEnding={request.FinancialYearEnding}&locationId={request.LocationId}", Method.Get);
        }

        /// <summary>
        /// List P60 Data
        /// </summary>
        public Task<ListP60sResult> ListP60DataAsync(int businessId, ListP60DataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ListP60sResult>($"/business/{businessId}/report/p60/list?financialYearEnding={request.FinancialYearEnding}&locationId={request.LocationId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Publish P60
        /// </summary>
        public PublishP60ApiResponseModel PublishP60(int businessId, PublishP60RequestModel publishP60RequestModel)
        {
            return ApiRequest<PublishP60ApiResponseModel,PublishP60RequestModel>($"/business/{businessId}/report/p60/publish", publishP60RequestModel, Method.Post);
        }

        /// <summary>
        /// Publish P60
        /// </summary>
        public Task<PublishP60ApiResponseModel> PublishP60Async(int businessId, PublishP60RequestModel publishP60RequestModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PublishP60ApiResponseModel,PublishP60RequestModel>($"/business/{businessId}/report/p60/publish", publishP60RequestModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public List<UkPayCategoriesModel> PayCategoriesReport(int businessId)
        {
            return ApiRequest<List<UkPayCategoriesModel>>($"/business/{businessId}/report/paycategories", Method.Get);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public Task<List<UkPayCategoriesModel>> PayCategoriesReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkPayCategoriesModel>>($"/business/{businessId}/report/paycategories", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public List<UkPayCategoriesModel> PayCategoriesReport(int businessId, PayCategoriesReportQueryModel request)
        {
            return ApiRequest<List<UkPayCategoriesModel>>($"/business/{businessId}/report/paycategories?payScheduleId={request.PayScheduleId}&employeeId={request.EmployeeId}&groupByEarningsLocation={request.GroupByEarningsLocation}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public Task<List<UkPayCategoriesModel>> PayCategoriesReportAsync(int businessId, PayCategoriesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkPayCategoriesModel>>($"/business/{businessId}/report/paycategories?payScheduleId={request.PayScheduleId}&employeeId={request.EmployeeId}&groupByEarningsLocation={request.GroupByEarningsLocation}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public List<UkPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId)
        {
            return ApiRequest<List<UkPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory", Method.Get);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public Task<List<UkPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public List<UkPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId, EmployeePaymentHistoryReportQueryModel request)
        {
            return ApiRequest<List<UkPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?employeeId={request.EmployeeId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public Task<List<UkPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, EmployeePaymentHistoryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?employeeId={request.EmployeeId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public List<UkPayRunInclusionExportModel> PayRunInclusionsReport(int businessId)
        {
            return ApiRequest<List<UkPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions", Method.Get);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public Task<List<UkPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public List<UkPayRunInclusionExportModel> PayRunInclusionsReport(int businessId, PayRunInclusionsReportQueryModel request)
        {
            return ApiRequest<List<UkPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?employeeId={request.EmployeeId}&status={request.Status}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public Task<List<UkPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, PayRunInclusionsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?employeeId={request.EmployeeId}&status={request.Status}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
        /// Pension Contributions Report
        /// </summary>
        /// <remarks>
        /// Generates a pension contributions report.
        /// </remarks>
        public List<PensionContributionDataApiModel> PensionContributionsReport(int businessId)
        {
            return ApiRequest<List<PensionContributionDataApiModel>>($"/business/{businessId}/report/pensioncontributions", Method.Get);
        }

        /// <summary>
        /// Pension Contributions Report
        /// </summary>
        /// <remarks>
        /// Generates a pension contributions report.
        /// </remarks>
        public Task<List<PensionContributionDataApiModel>> PensionContributionsReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PensionContributionDataApiModel>>($"/business/{businessId}/report/pensioncontributions", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pension Contributions Report
        /// </summary>
        /// <remarks>
        /// Generates a pension contributions report.
        /// </remarks>
        public List<PensionContributionDataApiModel> PensionContributionsReport(int businessId, PensionContributionsReportQueryModel request)
        {
            return ApiRequest<List<PensionContributionDataApiModel>>($"/business/{businessId}/report/pensioncontributions?employeeId={request.EmployeeId}&payRunId={request.PayRunId}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&payScheduleId={request.PayScheduleId}&locationId={request.LocationId}", Method.Get);
        }

        /// <summary>
        /// Pension Contributions Report
        /// </summary>
        /// <remarks>
        /// Generates a pension contributions report.
        /// </remarks>
        public Task<List<PensionContributionDataApiModel>> PensionContributionsReportAsync(int businessId, PensionContributionsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PensionContributionDataApiModel>>($"/business/{businessId}/report/pensioncontributions?employeeId={request.EmployeeId}&payRunId={request.PayRunId}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&payScheduleId={request.PayScheduleId}&locationId={request.LocationId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public List<UkRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId)
        {
            return ApiRequest<List<UkRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison", Method.Get);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public Task<List<UkRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public List<UkRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId, RosterVsTimesheetComparisonReportQueryModel request)
        {
            return ApiRequest<List<UkRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("timesheetStatuses", request.TimesheetStatuses?.Select(x => x.ToString()))}&workTypeId={request.WorkTypeId}&rosterLocationId={request.RosterLocationId}&timesheetLocationId={request.TimesheetLocationId}{ConvertEnumerableToQueryString("rosterStatuses", request.RosterStatuses?.Select(x => x.ToString()))}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public Task<List<UkRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, RosterVsTimesheetComparisonReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("timesheetStatuses", request.TimesheetStatuses?.Select(x => x.ToString()))}&workTypeId={request.WorkTypeId}&rosterLocationId={request.RosterLocationId}&timesheetLocationId={request.TimesheetLocationId}{ConvertEnumerableToQueryString("rosterStatuses", request.RosterStatuses?.Select(x => x.ToString()))}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
        public List<UkTimesheetExportModel> TimesheetReport(int businessId)
        {
            return ApiRequest<List<UkTimesheetExportModel>>($"/business/{businessId}/report/timesheet", Method.Get);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public Task<List<UkTimesheetExportModel>> TimesheetReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkTimesheetExportModel>>($"/business/{businessId}/report/timesheet", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public List<UkTimesheetExportModel> TimesheetReport(int businessId, TimesheetReportQueryModel request)
        {
            return ApiRequest<List<UkTimesheetExportModel>>($"/business/{businessId}/report/timesheet?employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("statuses", request.Statuses?.Select(x => x.ToString()))}&workTypeId={request.WorkTypeId}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public Task<List<UkTimesheetExportModel>> TimesheetReportAsync(int businessId, TimesheetReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkTimesheetExportModel>>($"/business/{businessId}/report/timesheet?employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("statuses", request.Statuses?.Select(x => x.ToString()))}&workTypeId={request.WorkTypeId}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }
    }
}
