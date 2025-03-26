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
        UkP32ReportModel GetP32ReportData(int businessId);
        Task<UkP32ReportModel> GetP32ReportDataAsync(int businessId, CancellationToken cancellationToken = default);
        UkP32ReportModel GetP32ReportData(int businessId, GetP32ReportDataQueryModel request);
        Task<UkP32ReportModel> GetP32ReportDataAsync(int businessId, GetP32ReportDataQueryModel request, CancellationToken cancellationToken = default);
        UkP32ReportModel UpdateP32Report(int businessId, IList<UkP32RequestModel> p32Requests);
        Task<UkP32ReportModel> UpdateP32ReportAsync(int businessId, IList<UkP32RequestModel> p32Requests, CancellationToken cancellationToken = default);
        UkP32ReportModel UpdateP32Report(int businessId, IList<UkP32RequestModel> p32Requests, UpdateP32ReportQueryModel request);
        Task<UkP32ReportModel> UpdateP32ReportAsync(int businessId, IList<UkP32RequestModel> p32Requests, UpdateP32ReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] DownloadP32ReportPdf(int businessId);
        Task<byte[]> DownloadP32ReportPdfAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] DownloadP32ReportPdf(int businessId, DownloadP32ReportPdfQueryModel request);
        Task<byte[]> DownloadP32ReportPdfAsync(int businessId, DownloadP32ReportPdfQueryModel request, CancellationToken cancellationToken = default);
        UkNIDeductionsSummaryReportModel GetNiDeductionsSummaryReport(int businessId);
        Task<UkNIDeductionsSummaryReportModel> GetNiDeductionsSummaryReportAsync(int businessId, CancellationToken cancellationToken = default);
        UkNIDeductionsSummaryReportModel GetNiDeductionsSummaryReport(int businessId, GetNiDeductionsSummaryReportQueryModel request);
        Task<UkNIDeductionsSummaryReportModel> GetNiDeductionsSummaryReportAsync(int businessId, GetNiDeductionsSummaryReportQueryModel request, CancellationToken cancellationToken = default);
        UkCISDeductionsSummaryReportModel GetCisDeductionsSummaryReport(int businessId);
        Task<UkCISDeductionsSummaryReportModel> GetCisDeductionsSummaryReportAsync(int businessId, CancellationToken cancellationToken = default);
        UkCISDeductionsSummaryReportModel GetCisDeductionsSummaryReport(int businessId, GetCisDeductionsSummaryReportQueryModel request);
        Task<UkCISDeductionsSummaryReportModel> GetCisDeductionsSummaryReportAsync(int businessId, GetCisDeductionsSummaryReportQueryModel request, CancellationToken cancellationToken = default);
        UkApprenticeshipLevySummaryReportModel GetApprenticeshipLevySummaryReport(int businessId);
        Task<UkApprenticeshipLevySummaryReportModel> GetApprenticeshipLevySummaryReportAsync(int businessId, CancellationToken cancellationToken = default);
        UkApprenticeshipLevySummaryReportModel GetApprenticeshipLevySummaryReport(int businessId, GetApprenticeshipLevySummaryReportQueryModel request);
        Task<UkApprenticeshipLevySummaryReportModel> GetApprenticeshipLevySummaryReportAsync(int businessId, GetApprenticeshipLevySummaryReportQueryModel request, CancellationToken cancellationToken = default);
        UkP32ReportAdjustmentsModel GetP32OpeningBalancesAdjustments(int businessId);
        Task<UkP32ReportAdjustmentsModel> GetP32OpeningBalancesAdjustmentsAsync(int businessId, CancellationToken cancellationToken = default);
        UkP32ReportAdjustmentsModel GetP32OpeningBalancesAdjustments(int businessId, GetP32OpeningBalancesAdjustmentsQueryModel request);
        Task<UkP32ReportAdjustmentsModel> GetP32OpeningBalancesAdjustmentsAsync(int businessId, GetP32OpeningBalancesAdjustmentsQueryModel request, CancellationToken cancellationToken = default);
        UkP32ReportAdjustmentsModel UpdateP32OpeningBalancesAdjustments(int businessId, UkP32ReportAdjustmentsModel p32AdjustmentRequestModel);
        Task<UkP32ReportAdjustmentsModel> UpdateP32OpeningBalancesAdjustmentsAsync(int businessId, UkP32ReportAdjustmentsModel p32AdjustmentRequestModel, CancellationToken cancellationToken = default);
        byte[] GetHmrcPaymentFile(int businessId);
        Task<byte[]> GetHmrcPaymentFileAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] GetHmrcPaymentFile(int businessId, GetHmrcPaymentFileQueryModel request);
        Task<byte[]> GetHmrcPaymentFileAsync(int businessId, GetHmrcPaymentFileQueryModel request, CancellationToken cancellationToken = default);
        P11dPublishApiResponseModel PublishP11d(int businessId, PublishP11dRequestModel publishP11dRequestModel);
        Task<P11dPublishApiResponseModel> PublishP11dAsync(int businessId, PublishP11dRequestModel publishP11dRequestModel, CancellationToken cancellationToken = default);
        LodgeExbApiResult SubmitExbSubmission(int businessId, ExbRequestApiModel exbModel);
        Task<LodgeExbApiResult> SubmitExbSubmissionAsync(int businessId, ExbRequestApiModel exbModel, CancellationToken cancellationToken = default);
        ExbResponseXmlModel ExbXmlWithoutSubmission(int businessId, ExbXmlApiModel exbModel);
        Task<ExbResponseXmlModel> ExbXmlWithoutSubmissionAsync(int businessId, ExbXmlApiModel exbModel, CancellationToken cancellationToken = default);
        UkGetP46CarResponseModel GetP46CarReports(int businessId);
        Task<UkGetP46CarResponseModel> GetP46CarReportsAsync(int businessId, CancellationToken cancellationToken = default);
        UkGetP46CarResponseModel GetP46CarReports(int businessId, GetP46CarReportsQueryModel request);
        Task<UkGetP46CarResponseModel> GetP46CarReportsAsync(int businessId, GetP46CarReportsQueryModel request, CancellationToken cancellationToken = default);
        UkP46CarModel IgnoreP46CarDetail(int businessId, UkIgnoreP46CarModel model);
        Task<UkP46CarModel> IgnoreP46CarDetailAsync(int businessId, UkIgnoreP46CarModel model, CancellationToken cancellationToken = default);
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
        List<UkDetailedActivityReportExportModel> DetailedActivityReport(int businessId);
        Task<List<UkDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkDetailedActivityReportExportModel> DetailedActivityReport(int businessId, DetailedActivityReportQueryModel request);
        Task<List<UkDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, DetailedActivityReportQueryModel request, CancellationToken cancellationToken = default);
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
        List<UkPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId);
        Task<List<UkPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId, EmployeePaymentHistoryReportQueryModel request);
        Task<List<UkPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, EmployeePaymentHistoryReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] EmployeePaymentHistoryReportAsExcel(int businessId);
        Task<byte[]> EmployeePaymentHistoryReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] EmployeePaymentHistoryReportAsExcel(int businessId, EmployeePaymentHistoryReportAsExcelQueryModel request);
        Task<byte[]> EmployeePaymentHistoryReportAsExcelAsync(int businessId, EmployeePaymentHistoryReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        List<EmployerPaymentSummaryReportGridModel> EmployerPaymentSummaryReport(int businessId);
        Task<List<EmployerPaymentSummaryReportGridModel>> EmployerPaymentSummaryReportAsync(int businessId, CancellationToken cancellationToken = default);
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
        byte[] FullPaymentSummaryXml(int businessId, string transactionid);
        Task<byte[]> FullPaymentSummaryXmlAsync(int businessId, string transactionid, CancellationToken cancellationToken = default);
        FpsResponseXmlModel FullPaymentSummaryXmlWithoutSubmission(int businessId, UkFpsXmlApiModel fpsModel);
        Task<FpsResponseXmlModel> FullPaymentSummaryXmlWithoutSubmissionAsync(int businessId, UkFpsXmlApiModel fpsModel, CancellationToken cancellationToken = default);
        List<UkGrossToNetResponseModel> GrossToNetReport(int businessId);
        Task<List<UkGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkGrossToNetResponseModel> GrossToNetReport(int businessId, GrossToNetReportQueryModel request);
        Task<List<UkGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, GrossToNetReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] GrossToNetReportAsExcel(int businessId);
        Task<byte[]> GrossToNetReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] GrossToNetReportAsExcel(int businessId, GrossToNetReportAsExcelQueryModel request);
        Task<byte[]> GrossToNetReportAsExcelAsync(int businessId, GrossToNetReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        List<UkLeaveBalancesExportModel> LeaveBalancesReport(int businessId);
        Task<List<UkLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkLeaveBalancesExportModel> LeaveBalancesReport(int businessId, LeaveBalancesReportQueryModel request);
        Task<List<UkLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, LeaveBalancesReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] LeaveBalancesReportAsExcel(int businessId);
        Task<byte[]> LeaveBalancesReportAsExcelAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] LeaveBalancesReportAsExcel(int businessId, LeaveBalancesReportAsExcelQueryModel request);
        Task<byte[]> LeaveBalancesReportAsExcelAsync(int businessId, LeaveBalancesReportAsExcelQueryModel request, CancellationToken cancellationToken = default);
        List<LeaveHistoryReportGroupModel> LeaveHistoryReport(int businessId);
        Task<List<LeaveHistoryReportGroupModel>> LeaveHistoryReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<LeaveHistoryReportGroupModel> LeaveHistoryReport(int businessId, LeaveHistoryReportQueryModel request);
        Task<List<LeaveHistoryReportGroupModel>> LeaveHistoryReportAsync(int businessId, LeaveHistoryReportQueryModel request, CancellationToken cancellationToken = default);
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
        UkP60SummaryForEmployeeDto LoadP60Data(int businessId, int employeeId);
        Task<UkP60SummaryForEmployeeDto> LoadP60DataAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        UkP60SummaryForEmployeeDto LoadP60Data(int businessId, int employeeId, LoadP60DataQueryModel request);
        Task<UkP60SummaryForEmployeeDto> LoadP60DataAsync(int businessId, int employeeId, LoadP60DataQueryModel request, CancellationToken cancellationToken = default);
        IsPublishedP60ResponseModel ShowP60Status(int businessId, IsPublishedP60RequestModel isPublishedP60RequestModel);
        Task<IsPublishedP60ResponseModel> ShowP60StatusAsync(int businessId, IsPublishedP60RequestModel isPublishedP60RequestModel, CancellationToken cancellationToken = default);
        PublishP60ApiResponseModel PublishP60(int businessId, PublishP60RequestModel publishP60RequestModel);
        Task<PublishP60ApiResponseModel> PublishP60Async(int businessId, PublishP60RequestModel publishP60RequestModel, CancellationToken cancellationToken = default);
        ListP60sResult ListP60Data(int businessId);
        Task<ListP60sResult> ListP60DataAsync(int businessId, CancellationToken cancellationToken = default);
        ListP60sResult ListP60Data(int businessId, ListP60DataQueryModel request);
        Task<ListP60sResult> ListP60DataAsync(int businessId, ListP60DataQueryModel request, CancellationToken cancellationToken = default);
        List<UkPayCategoriesModel> PayCategoriesReport(int businessId);
        Task<List<UkPayCategoriesModel>> PayCategoriesReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkPayCategoriesModel> PayCategoriesReport(int businessId, PayCategoriesReportQueryModel request);
        Task<List<UkPayCategoriesModel>> PayCategoriesReportAsync(int businessId, PayCategoriesReportQueryModel request, CancellationToken cancellationToken = default);
        List<UkPayRunInclusionExportModel> PayRunInclusionsReport(int businessId);
        Task<List<UkPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkPayRunInclusionExportModel> PayRunInclusionsReport(int businessId, PayRunInclusionsReportQueryModel request);
        Task<List<UkPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, PayRunInclusionsReportQueryModel request, CancellationToken cancellationToken = default);
        List<PensionContributionDataApiModel> PensionContributionsReportData(int businessId);
        Task<List<PensionContributionDataApiModel>> PensionContributionsReportDataAsync(int businessId, CancellationToken cancellationToken = default);
        List<PensionContributionDataApiModel> PensionContributionsReportData(int businessId, PensionContributionsReportDataQueryModel request);
        Task<List<PensionContributionDataApiModel>> PensionContributionsReportDataAsync(int businessId, PensionContributionsReportDataQueryModel request, CancellationToken cancellationToken = default);
        byte[] PensionContributionsReportExcelFile(int businessId);
        Task<byte[]> PensionContributionsReportExcelFileAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] PensionContributionsReportExcelFile(int businessId, PensionContributionsReportExcelFileQueryModel request);
        Task<byte[]> PensionContributionsReportExcelFileAsync(int businessId, PensionContributionsReportExcelFileQueryModel request, CancellationToken cancellationToken = default);
        List<UkRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId);
        Task<List<UkRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId, RosterVsTimesheetComparisonReportQueryModel request);
        Task<List<UkRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, RosterVsTimesheetComparisonReportQueryModel request, CancellationToken cancellationToken = default);
        List<UkTimesheetExportModel> TimesheetReport(int businessId);
        Task<List<UkTimesheetExportModel>> TimesheetReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkTimesheetExportModel> TimesheetReport(int businessId, TimesheetReportQueryModel request);
        Task<List<UkTimesheetExportModel>> TimesheetReportAsync(int businessId, TimesheetReportQueryModel request, CancellationToken cancellationToken = default);
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
        List<P45ReportResponseModel> P45Report(int businessId);
        Task<List<P45ReportResponseModel>> P45ReportAsync(int businessId, CancellationToken cancellationToken = default);
        List<P45ReportResponseModel> P45Report(int businessId, P45ReportQueryModel request);
        Task<List<P45ReportResponseModel>> P45ReportAsync(int businessId, P45ReportQueryModel request, CancellationToken cancellationToken = default);
        byte[] P45PdfReport(int businessId);
        Task<byte[]> P45PdfReportAsync(int businessId, CancellationToken cancellationToken = default);
        byte[] P45PdfReport(int businessId, P45PdfReportQueryModel request);
        Task<byte[]> P45PdfReportAsync(int businessId, P45PdfReportQueryModel request, CancellationToken cancellationToken = default);
    }
    public class ReportingFunction : BaseFunction, IReportingFunction
    {
        public ReportingFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get P32 Report data
        /// </summary>
        /// <remarks>
        /// Gets P32 Report data for the financial year
        /// </remarks>
        public UkP32ReportModel GetP32ReportData(int businessId)
        {
            return ApiRequest<UkP32ReportModel>($"/business/{businessId}/report/p32", Method.Get);
        }

        /// <summary>
        /// Get P32 Report data
        /// </summary>
        /// <remarks>
        /// Gets P32 Report data for the financial year
        /// </remarks>
        public Task<UkP32ReportModel> GetP32ReportDataAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkP32ReportModel>($"/business/{businessId}/report/p32", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get P32 Report data
        /// </summary>
        /// <remarks>
        /// Gets P32 Report data for the financial year
        /// </remarks>
        public UkP32ReportModel GetP32ReportData(int businessId, GetP32ReportDataQueryModel request)
        {
            return ApiRequest<UkP32ReportModel>($"/business/{businessId}/report/p32?FinancialYearEnding={request.FinancialYearEnding}&PayeSchemeId={request.PayeSchemeId}&Date={request.Date.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Get P32 Report data
        /// </summary>
        /// <remarks>
        /// Gets P32 Report data for the financial year
        /// </remarks>
        public Task<UkP32ReportModel> GetP32ReportDataAsync(int businessId, GetP32ReportDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkP32ReportModel>($"/business/{businessId}/report/p32?FinancialYearEnding={request.FinancialYearEnding}&PayeSchemeId={request.PayeSchemeId}&Date={request.Date.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update P32 Report
        /// </summary>
        /// <remarks>
        /// Update P32 Report for the financial year
        /// </remarks>
        public UkP32ReportModel UpdateP32Report(int businessId, IList<UkP32RequestModel> p32Requests)
        {
            return ApiRequest<UkP32ReportModel,IList<UkP32RequestModel>>($"/business/{businessId}/report/p32", p32Requests, Method.Put);
        }

        /// <summary>
        /// Update P32 Report
        /// </summary>
        /// <remarks>
        /// Update P32 Report for the financial year
        /// </remarks>
        public Task<UkP32ReportModel> UpdateP32ReportAsync(int businessId, IList<UkP32RequestModel> p32Requests, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkP32ReportModel,IList<UkP32RequestModel>>($"/business/{businessId}/report/p32", p32Requests, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Update P32 Report
        /// </summary>
        /// <remarks>
        /// Update P32 Report for the financial year
        /// </remarks>
        public UkP32ReportModel UpdateP32Report(int businessId, IList<UkP32RequestModel> p32Requests, UpdateP32ReportQueryModel request)
        {
            return ApiRequest<UkP32ReportModel,IList<UkP32RequestModel>>($"/business/{businessId}/report/p32?financialYearEnding={request.FinancialYearEnding}&payeSchemeId={request.PayeSchemeId}", p32Requests, Method.Put);
        }

        /// <summary>
        /// Update P32 Report
        /// </summary>
        /// <remarks>
        /// Update P32 Report for the financial year
        /// </remarks>
        public Task<UkP32ReportModel> UpdateP32ReportAsync(int businessId, IList<UkP32RequestModel> p32Requests, UpdateP32ReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkP32ReportModel,IList<UkP32RequestModel>>($"/business/{businessId}/report/p32?financialYearEnding={request.FinancialYearEnding}&payeSchemeId={request.PayeSchemeId}", p32Requests, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Download P32 Report PDF
        /// </summary>
        /// <remarks>
        /// Downloads P32 Report for the financial year as a PDF
        /// </remarks>
        public byte[] DownloadP32ReportPdf(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/p32/download/pdf", Method.Get);
        }

        /// <summary>
        /// Download P32 Report PDF
        /// </summary>
        /// <remarks>
        /// Downloads P32 Report for the financial year as a PDF
        /// </remarks>
        public Task<byte[]> DownloadP32ReportPdfAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/p32/download/pdf", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Download P32 Report PDF
        /// </summary>
        /// <remarks>
        /// Downloads P32 Report for the financial year as a PDF
        /// </remarks>
        public byte[] DownloadP32ReportPdf(int businessId, DownloadP32ReportPdfQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/p32/download/pdf?financialYearEnding={request.FinancialYearEnding}&payeSchemeId={request.PayeSchemeId}", Method.Get);
        }

        /// <summary>
        /// Download P32 Report PDF
        /// </summary>
        /// <remarks>
        /// Downloads P32 Report for the financial year as a PDF
        /// </remarks>
        public Task<byte[]> DownloadP32ReportPdfAsync(int businessId, DownloadP32ReportPdfQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/p32/download/pdf?financialYearEnding={request.FinancialYearEnding}&payeSchemeId={request.PayeSchemeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get NI Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets NI Deductions Summary Report for the financial year
        /// </remarks>
        public UkNIDeductionsSummaryReportModel GetNiDeductionsSummaryReport(int businessId)
        {
            return ApiRequest<UkNIDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/nideductionssummary", Method.Get);
        }

        /// <summary>
        /// Get NI Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets NI Deductions Summary Report for the financial year
        /// </remarks>
        public Task<UkNIDeductionsSummaryReportModel> GetNiDeductionsSummaryReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkNIDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/nideductionssummary", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get NI Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets NI Deductions Summary Report for the financial year
        /// </remarks>
        public UkNIDeductionsSummaryReportModel GetNiDeductionsSummaryReport(int businessId, GetNiDeductionsSummaryReportQueryModel request)
        {
            return ApiRequest<UkNIDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/nideductionssummary?FinancialYearEnding={request.FinancialYearEnding}&PayeSchemeId={request.PayeSchemeId}&Date={request.Date.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Get NI Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets NI Deductions Summary Report for the financial year
        /// </remarks>
        public Task<UkNIDeductionsSummaryReportModel> GetNiDeductionsSummaryReportAsync(int businessId, GetNiDeductionsSummaryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkNIDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/nideductionssummary?FinancialYearEnding={request.FinancialYearEnding}&PayeSchemeId={request.PayeSchemeId}&Date={request.Date.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get CIS Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets CIS Deductions Summary Report for the financial year
        /// </remarks>
        public UkCISDeductionsSummaryReportModel GetCisDeductionsSummaryReport(int businessId)
        {
            return ApiRequest<UkCISDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/cisdeductionssummary", Method.Get);
        }

        /// <summary>
        /// Get CIS Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets CIS Deductions Summary Report for the financial year
        /// </remarks>
        public Task<UkCISDeductionsSummaryReportModel> GetCisDeductionsSummaryReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkCISDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/cisdeductionssummary", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get CIS Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets CIS Deductions Summary Report for the financial year
        /// </remarks>
        public UkCISDeductionsSummaryReportModel GetCisDeductionsSummaryReport(int businessId, GetCisDeductionsSummaryReportQueryModel request)
        {
            return ApiRequest<UkCISDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/cisdeductionssummary?financialYearEnding={request.FinancialYearEnding}&payeSchemeId={request.PayeSchemeId}", Method.Get);
        }

        /// <summary>
        /// Get CIS Deductions Summary Report
        /// </summary>
        /// <remarks>
        /// Gets CIS Deductions Summary Report for the financial year
        /// </remarks>
        public Task<UkCISDeductionsSummaryReportModel> GetCisDeductionsSummaryReportAsync(int businessId, GetCisDeductionsSummaryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkCISDeductionsSummaryReportModel>($"/business/{businessId}/report/p32/cisdeductionssummary?financialYearEnding={request.FinancialYearEnding}&payeSchemeId={request.PayeSchemeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Apprenticeship Levy Summary Report
        /// </summary>
        /// <remarks>
        /// Gets Apprenticeship Levy Summary Report for the financial year
        /// </remarks>
        public UkApprenticeshipLevySummaryReportModel GetApprenticeshipLevySummaryReport(int businessId)
        {
            return ApiRequest<UkApprenticeshipLevySummaryReportModel>($"/business/{businessId}/report/p32/apprenticeshiplevy", Method.Get);
        }

        /// <summary>
        /// Get Apprenticeship Levy Summary Report
        /// </summary>
        /// <remarks>
        /// Gets Apprenticeship Levy Summary Report for the financial year
        /// </remarks>
        public Task<UkApprenticeshipLevySummaryReportModel> GetApprenticeshipLevySummaryReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkApprenticeshipLevySummaryReportModel>($"/business/{businessId}/report/p32/apprenticeshiplevy", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Apprenticeship Levy Summary Report
        /// </summary>
        /// <remarks>
        /// Gets Apprenticeship Levy Summary Report for the financial year
        /// </remarks>
        public UkApprenticeshipLevySummaryReportModel GetApprenticeshipLevySummaryReport(int businessId, GetApprenticeshipLevySummaryReportQueryModel request)
        {
            return ApiRequest<UkApprenticeshipLevySummaryReportModel>($"/business/{businessId}/report/p32/apprenticeshiplevy?FinancialYearEnding={request.FinancialYearEnding}&PayeSchemeId={request.PayeSchemeId}&Date={request.Date.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Get Apprenticeship Levy Summary Report
        /// </summary>
        /// <remarks>
        /// Gets Apprenticeship Levy Summary Report for the financial year
        /// </remarks>
        public Task<UkApprenticeshipLevySummaryReportModel> GetApprenticeshipLevySummaryReportAsync(int businessId, GetApprenticeshipLevySummaryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkApprenticeshipLevySummaryReportModel>($"/business/{businessId}/report/p32/apprenticeshiplevy?FinancialYearEnding={request.FinancialYearEnding}&PayeSchemeId={request.PayeSchemeId}&Date={request.Date.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
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
        /// Get P32 Opening Balances Adjustments
        /// </summary>
        /// <remarks>
        /// Get P32 Opening Balances Adjustments for the business' initial tax year using this software
        /// </remarks>
        public UkP32ReportAdjustmentsModel GetP32OpeningBalancesAdjustments(int businessId, GetP32OpeningBalancesAdjustmentsQueryModel request)
        {
            return ApiRequest<UkP32ReportAdjustmentsModel>($"/business/{businessId}/report/p32/openingbalancesadjustments?payeSchemeId={request.PayeSchemeId}", Method.Get);
        }

        /// <summary>
        /// Get P32 Opening Balances Adjustments
        /// </summary>
        /// <remarks>
        /// Get P32 Opening Balances Adjustments for the business' initial tax year using this software
        /// </remarks>
        public Task<UkP32ReportAdjustmentsModel> GetP32OpeningBalancesAdjustmentsAsync(int businessId, GetP32OpeningBalancesAdjustmentsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkP32ReportAdjustmentsModel>($"/business/{businessId}/report/p32/openingbalancesadjustments?payeSchemeId={request.PayeSchemeId}", Method.Get, cancellationToken);
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
            return ApiByteArrayRequest($"/business/{businessId}/report/p32/hmrcpaymentfile?DateInPayPeriod={request.DateInPayPeriod.ToString("yyyy-MM-ddTHH:mm:ss")}&PaymentPeriod={request.PaymentPeriod}&PayeSchemeId={request.PayeSchemeId}", Method.Get);
        }

        /// <summary>
        /// Get Hmrc Payment File
        /// </summary>
        public Task<byte[]> GetHmrcPaymentFileAsync(int businessId, GetHmrcPaymentFileQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/p32/hmrcpaymentfile?DateInPayPeriod={request.DateInPayPeriod.ToString("yyyy-MM-ddTHH:mm:ss")}&PaymentPeriod={request.PaymentPeriod}&PayeSchemeId={request.PayeSchemeId}", Method.Get, cancellationToken);
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
        /// Get P46(Car) reports
        /// </summary>
        public UkGetP46CarResponseModel GetP46CarReports(int businessId)
        {
            return ApiRequest<UkGetP46CarResponseModel>($"/business/{businessId}/report/p46car", Method.Get);
        }

        /// <summary>
        /// Get P46(Car) reports
        /// </summary>
        public Task<UkGetP46CarResponseModel> GetP46CarReportsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkGetP46CarResponseModel>($"/business/{businessId}/report/p46car", Method.Get, cancellationToken);
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
            return ApiRequest<List<UkDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public Task<List<UkDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, DetailedActivityReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
            return ApiRequest<List<UkPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?EmployeeId={request.EmployeeId}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public Task<List<UkPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, EmployeePaymentHistoryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?EmployeeId={request.EmployeeId}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
        /// Employer Payment Summary Report
        /// </summary>
        public List<EmployerPaymentSummaryReportGridModel> EmployerPaymentSummaryReport(int businessId)
        {
            return ApiRequest<List<EmployerPaymentSummaryReportGridModel>>($"/business/{businessId}/report/eps", Method.Get);
        }

        /// <summary>
        /// Employer Payment Summary Report
        /// </summary>
        public Task<List<EmployerPaymentSummaryReportGridModel>> EmployerPaymentSummaryReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployerPaymentSummaryReportGridModel>>($"/business/{businessId}/report/eps", Method.Get, cancellationToken);
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
            return ApiRequest<List<UkGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?EmployeeId={request.EmployeeId}{ConvertEnumerableToQueryString("PayCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&GroupBy={request.GroupBy}&PayRunId={request.PayRunId}&FilterType={request.FilterType}&IncludeExpenses={request.IncludeExpenses}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public Task<List<UkGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, GrossToNetReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?EmployeeId={request.EmployeeId}{ConvertEnumerableToQueryString("PayCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&GroupBy={request.GroupBy}&PayRunId={request.PayRunId}&FilterType={request.FilterType}&IncludeExpenses={request.IncludeExpenses}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
            return ApiRequest<List<UkLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?LocationId={request.LocationId}&LeaveTypeId={request.LeaveTypeId}&GroupBy={request.GroupBy}&EmployingEntityId={request.EmployingEntityId}&AsAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public Task<List<UkLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, LeaveBalancesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?LocationId={request.LocationId}&LeaveTypeId={request.LeaveTypeId}&GroupBy={request.GroupBy}&EmployingEntityId={request.EmployingEntityId}&AsAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
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
            return ApiRequest<List<LeaveHistoryReportGroupModel>>($"/business/{businessId}/report/leavehistory?FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&PayScheduleId={request.PayScheduleId}&LocationId={request.LocationId}{ConvertEnumerableToQueryString("EmployeeId", request.EmployeeId?.Select(x => x.ToString()))}&LeaveCategoryId={request.LeaveCategoryId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Leave History Report
        /// </summary>
        /// <remarks>
        /// Generates a leave history report.
        /// </remarks>
        public Task<List<LeaveHistoryReportGroupModel>> LeaveHistoryReportAsync(int businessId, LeaveHistoryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveHistoryReportGroupModel>>($"/business/{businessId}/report/leavehistory?FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&PayScheduleId={request.PayScheduleId}&LocationId={request.LocationId}{ConvertEnumerableToQueryString("EmployeeId", request.EmployeeId?.Select(x => x.ToString()))}&LeaveCategoryId={request.LeaveCategoryId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
        /// Load P60 Data
        /// </summary>
        public UkP60SummaryForEmployeeDto LoadP60Data(int businessId, int employeeId)
        {
            return ApiRequest<UkP60SummaryForEmployeeDto>($"/business/{businessId}/report/p60/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Load P60 Data
        /// </summary>
        public Task<UkP60SummaryForEmployeeDto> LoadP60DataAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkP60SummaryForEmployeeDto>($"/business/{businessId}/report/p60/{employeeId}", Method.Get, cancellationToken);
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
        /// List P60 Data
        /// </summary>
        public ListP60sResult ListP60Data(int businessId)
        {
            return ApiRequest<ListP60sResult>($"/business/{businessId}/report/p60/list", Method.Get);
        }

        /// <summary>
        /// List P60 Data
        /// </summary>
        public Task<ListP60sResult> ListP60DataAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ListP60sResult>($"/business/{businessId}/report/p60/list", Method.Get, cancellationToken);
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
            return ApiRequest<List<UkPayCategoriesModel>>($"/business/{businessId}/report/paycategories?PayScheduleId={request.PayScheduleId}&EmployeeId={request.EmployeeId}&GroupByEarningsLocation={request.GroupByEarningsLocation}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public Task<List<UkPayCategoriesModel>> PayCategoriesReportAsync(int businessId, PayCategoriesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkPayCategoriesModel>>($"/business/{businessId}/report/paycategories?PayScheduleId={request.PayScheduleId}&EmployeeId={request.EmployeeId}&GroupByEarningsLocation={request.GroupByEarningsLocation}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
            return ApiRequest<List<UkPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?EmployeeId={request.EmployeeId}&Status={request.Status}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public Task<List<UkPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, PayRunInclusionsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?EmployeeId={request.EmployeeId}&Status={request.Status}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pension Contributions Report data
        /// </summary>
        /// <remarks>
        /// Generates a pension contributions report data.
        /// </remarks>
        public List<PensionContributionDataApiModel> PensionContributionsReportData(int businessId)
        {
            return ApiRequest<List<PensionContributionDataApiModel>>($"/business/{businessId}/report/pensioncontributions", Method.Get);
        }

        /// <summary>
        /// Pension Contributions Report data
        /// </summary>
        /// <remarks>
        /// Generates a pension contributions report data.
        /// </remarks>
        public Task<List<PensionContributionDataApiModel>> PensionContributionsReportDataAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PensionContributionDataApiModel>>($"/business/{businessId}/report/pensioncontributions", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pension Contributions Report data
        /// </summary>
        /// <remarks>
        /// Generates a pension contributions report data.
        /// </remarks>
        public List<PensionContributionDataApiModel> PensionContributionsReportData(int businessId, PensionContributionsReportDataQueryModel request)
        {
            return ApiRequest<List<PensionContributionDataApiModel>>($"/business/{businessId}/report/pensioncontributions?EmployeeId={request.EmployeeId}&PayRunId={request.PayRunId}&FromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ToDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayScheduleId={request.PayScheduleId}&LocationId={request.LocationId}&ContributionPlanId={request.ContributionPlanId}", Method.Get);
        }

        /// <summary>
        /// Pension Contributions Report data
        /// </summary>
        /// <remarks>
        /// Generates a pension contributions report data.
        /// </remarks>
        public Task<List<PensionContributionDataApiModel>> PensionContributionsReportDataAsync(int businessId, PensionContributionsReportDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PensionContributionDataApiModel>>($"/business/{businessId}/report/pensioncontributions?EmployeeId={request.EmployeeId}&PayRunId={request.PayRunId}&FromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ToDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayScheduleId={request.PayScheduleId}&LocationId={request.LocationId}&ContributionPlanId={request.ContributionPlanId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pension Contributions Report excel file
        /// </summary>
        /// <remarks>
        /// Generates a pension contributions report in xlsx.
        /// </remarks>
        public byte[] PensionContributionsReportExcelFile(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/pensioncontributions/xlsx", Method.Get);
        }

        /// <summary>
        /// Pension Contributions Report excel file
        /// </summary>
        /// <remarks>
        /// Generates a pension contributions report in xlsx.
        /// </remarks>
        public Task<byte[]> PensionContributionsReportExcelFileAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/pensioncontributions/xlsx", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pension Contributions Report excel file
        /// </summary>
        /// <remarks>
        /// Generates a pension contributions report in xlsx.
        /// </remarks>
        public byte[] PensionContributionsReportExcelFile(int businessId, PensionContributionsReportExcelFileQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/pensioncontributions/xlsx?EmployeeId={request.EmployeeId}&PayRunId={request.PayRunId}&FromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ToDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayScheduleId={request.PayScheduleId}&LocationId={request.LocationId}&ContributionPlanId={request.ContributionPlanId}", Method.Get);
        }

        /// <summary>
        /// Pension Contributions Report excel file
        /// </summary>
        /// <remarks>
        /// Generates a pension contributions report in xlsx.
        /// </remarks>
        public Task<byte[]> PensionContributionsReportExcelFileAsync(int businessId, PensionContributionsReportExcelFileQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/pensioncontributions/xlsx?EmployeeId={request.EmployeeId}&PayRunId={request.PayRunId}&FromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&ToDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&PayScheduleId={request.PayScheduleId}&LocationId={request.LocationId}&ContributionPlanId={request.ContributionPlanId}", Method.Get, cancellationToken);
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
            return ApiRequest<List<UkRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?EmployeeId={request.EmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("TimesheetStatuses", request.TimesheetStatuses?.Select(x => x.ToString()))}&WorkTypeId={request.WorkTypeId}&RosterLocationId={request.RosterLocationId}&TimesheetLocationId={request.TimesheetLocationId}{ConvertEnumerableToQueryString("RosterStatuses", request.RosterStatuses?.Select(x => x.ToString()))}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public Task<List<UkRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, RosterVsTimesheetComparisonReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?EmployeeId={request.EmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("TimesheetStatuses", request.TimesheetStatuses?.Select(x => x.ToString()))}&WorkTypeId={request.WorkTypeId}&RosterLocationId={request.RosterLocationId}&TimesheetLocationId={request.TimesheetLocationId}{ConvertEnumerableToQueryString("RosterStatuses", request.RosterStatuses?.Select(x => x.ToString()))}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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
            return ApiRequest<List<UkTimesheetExportModel>>($"/business/{businessId}/report/timesheet?EmployeeId={request.EmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("Statuses", request.Statuses?.Select(x => x.ToString()))}&WorkTypeId={request.WorkTypeId}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public Task<List<UkTimesheetExportModel>> TimesheetReportAsync(int businessId, TimesheetReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkTimesheetExportModel>>($"/business/{businessId}/report/timesheet?EmployeeId={request.EmployeeId}&IncludeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("Statuses", request.Statuses?.Select(x => x.ToString()))}&WorkTypeId={request.WorkTypeId}&PayScheduleId={request.PayScheduleId}&IncludePostTaxDeductions={request.IncludePostTaxDeductions}&FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&LocationId={request.LocationId}&EmployingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
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

        /// <summary>
        /// P45 Report
        /// </summary>
        /// <remarks>
        /// Generates a P45 report data.
        /// </remarks>
        public List<P45ReportResponseModel> P45Report(int businessId)
        {
            return ApiRequest<List<P45ReportResponseModel>>($"/business/{businessId}/report/p45", Method.Get);
        }

        /// <summary>
        /// P45 Report
        /// </summary>
        /// <remarks>
        /// Generates a P45 report data.
        /// </remarks>
        public Task<List<P45ReportResponseModel>> P45ReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<P45ReportResponseModel>>($"/business/{businessId}/report/p45", Method.Get, cancellationToken);
        }

        /// <summary>
        /// P45 Report
        /// </summary>
        /// <remarks>
        /// Generates a P45 report data.
        /// </remarks>
        public List<P45ReportResponseModel> P45Report(int businessId, P45ReportQueryModel request)
        {
            return ApiRequest<List<P45ReportResponseModel>>($"/business/{businessId}/report/p45?payRunId={request.PayRunId}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ConvertEnumerableToQueryString("employeeIds", request.EmployeeIds?.Select(x => x.ToString()))}", Method.Get);
        }

        /// <summary>
        /// P45 Report
        /// </summary>
        /// <remarks>
        /// Generates a P45 report data.
        /// </remarks>
        public Task<List<P45ReportResponseModel>> P45ReportAsync(int businessId, P45ReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<P45ReportResponseModel>>($"/business/{businessId}/report/p45?payRunId={request.PayRunId}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ConvertEnumerableToQueryString("employeeIds", request.EmployeeIds?.Select(x => x.ToString()))}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// P45 PDF Report
        /// </summary>
        /// <remarks>
        /// Generates a P45 report in PDF format.
        /// </remarks>
        public byte[] P45PdfReport(int businessId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/p45/pdf", Method.Get);
        }

        /// <summary>
        /// P45 PDF Report
        /// </summary>
        /// <remarks>
        /// Generates a P45 report in PDF format.
        /// </remarks>
        public Task<byte[]> P45PdfReportAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/p45/pdf", Method.Get, cancellationToken);
        }

        /// <summary>
        /// P45 PDF Report
        /// </summary>
        /// <remarks>
        /// Generates a P45 report in PDF format.
        /// </remarks>
        public byte[] P45PdfReport(int businessId, P45PdfReportQueryModel request)
        {
            return ApiByteArrayRequest($"/business/{businessId}/report/p45/pdf?payRunId={request.PayRunId}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ConvertEnumerableToQueryString("employeeIds", request.EmployeeIds?.Select(x => x.ToString()))}", Method.Get);
        }

        /// <summary>
        /// P45 PDF Report
        /// </summary>
        /// <remarks>
        /// Generates a P45 report in PDF format.
        /// </remarks>
        public Task<byte[]> P45PdfReportAsync(int businessId, P45PdfReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/report/p45/pdf?payRunId={request.PayRunId}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ConvertEnumerableToQueryString("employeeIds", request.EmployeeIds?.Select(x => x.ToString()))}", Method.Get, cancellationToken);
        }
    }
}
