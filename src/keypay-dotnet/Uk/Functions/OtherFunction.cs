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
using KeyPayV2.Uk.Models.Other;

namespace KeyPayV2.Uk.Functions
{
    public interface IOtherFunction
    {
        void AwardPackage_Put(AwardPackage_PutQueryModel request);
        Task AwardPackage_PutAsync(AwardPackage_PutQueryModel request, CancellationToken cancellationToken = default);
        void CreatesANewAwardPackageAndAssignsToTheSpecifiedBusiness(AwardPackageDataModel package, CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessQueryModel request);
        Task CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessAsync(AwardPackageDataModel package, CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessQueryModel request, CancellationToken cancellationToken = default);
        void BulkActionHmrc_HmrcSettings(int businessId, BulkActionRequest model);
        Task BulkActionHmrc_HmrcSettingsAsync(int businessId, BulkActionRequest model, CancellationToken cancellationToken = default);
        void BulkActionHmrc_Metadata(int businessId, BulkActionMetadataRequest model);
        Task BulkActionHmrc_MetadataAsync(int businessId, BulkActionMetadataRequest model, CancellationToken cancellationToken = default);
        EmployeeUpdateResponseModelWithAdditionalInfo EmployeeAdmin_PostEmployeeAndReturnAdditionalInfo(int businessId, UkUnstructuredEmployeeModel model);
        Task<EmployeeUpdateResponseModelWithAdditionalInfo> EmployeeAdmin_PostEmployeeAndReturnAdditionalInfoAsync(int businessId, UkUnstructuredEmployeeModel model, CancellationToken cancellationToken = default);
        EmployeeUpdateResponseModelWithAdditionalInfo EmployeeAdmin_PostEmployeeAndReturnAdditionalInfo(int businessId, UkUnstructuredEmployeeModel model, EmployeeAdmin_PostEmployeeAndReturnAdditionalInfoQueryModel request);
        Task<EmployeeUpdateResponseModelWithAdditionalInfo> EmployeeAdmin_PostEmployeeAndReturnAdditionalInfoAsync(int businessId, UkUnstructuredEmployeeModel model, EmployeeAdmin_PostEmployeeAndReturnAdditionalInfoQueryModel request, CancellationToken cancellationToken = default);
        void FixInconsistentDataTest_RetrieveMissingPayCategoryIdForPayCategoryExtUkRecordsRecords(int businessId, FixInconsistentDataTest_RetrieveMissingPayCategoryIdForPayCategoryExtUkRecordsRecordsQueryModel request);
        Task FixInconsistentDataTest_RetrieveMissingPayCategoryIdForPayCategoryExtUkRecordsRecordsAsync(int businessId, FixInconsistentDataTest_RetrieveMissingPayCategoryIdForPayCategoryExtUkRecordsRecordsQueryModel request, CancellationToken cancellationToken = default);
        void FixInconsistentDataTest_RetrieveBusinessesForMissingPayCategoryExtUkRecords(int businessId, FixInconsistentDataTest_RetrieveBusinessesForMissingPayCategoryExtUkRecordsQueryModel request);
        Task FixInconsistentDataTest_RetrieveBusinessesForMissingPayCategoryExtUkRecordsAsync(int businessId, FixInconsistentDataTest_RetrieveBusinessesForMissingPayCategoryExtUkRecordsQueryModel request, CancellationToken cancellationToken = default);
        InconsistentNIRecordsModel CorrectNiRecordInconsistencies(CorrectNiRecordInconsistenciesQueryModel request);
        Task<InconsistentNIRecordsModel> CorrectNiRecordInconsistenciesAsync(CorrectNiRecordInconsistenciesQueryModel request, CancellationToken cancellationToken = default);
        InconsistentNIRecordsModel ListNiRecordInconsistencies(ListNiRecordInconsistenciesQueryModel request);
        Task<InconsistentNIRecordsModel> ListNiRecordInconsistenciesAsync(ListNiRecordInconsistenciesQueryModel request, CancellationToken cancellationToken = default);
        List<RosterLiveLeaveAccruals> ReportsRosterLiveLeaveExport_Get(int businessId, ReportsRosterLiveLeaveExport_GetQueryModel request);
        Task<List<RosterLiveLeaveAccruals>> ReportsRosterLiveLeaveExport_GetAsync(int businessId, ReportsRosterLiveLeaveExport_GetQueryModel request, CancellationToken cancellationToken = default);
        List<MLCSuperReportExportModel> ReportsMLCSuper_Get(int businessId, ReportsMLCSuper_GetQueryModel request);
        Task<List<MLCSuperReportExportModel>> ReportsMLCSuper_GetAsync(int businessId, ReportsMLCSuper_GetQueryModel request, CancellationToken cancellationToken = default);
        void GetPaymentFilesByFinalisedPayRunId(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request);
        Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default);
        List<PayrollExemptReportExportModel> ReportsPayrollExempt_Get(int businessId);
        Task<List<PayrollExemptReportExportModel>> ReportsPayrollExempt_GetAsync(int businessId, CancellationToken cancellationToken = default);
        List<PayrollExemptReportExportModel> ReportsPayrollExempt_Get(int businessId, ReportsPayrollExempt_GetQueryModel request);
        Task<List<PayrollExemptReportExportModel>> ReportsPayrollExempt_GetAsync(int businessId, ReportsPayrollExempt_GetQueryModel request, CancellationToken cancellationToken = default);
        List<WorkersCompReportGridModel> ReportsWorkersComp_Get(int businessId, ReportsWorkersComp_GetQueryModel request);
        Task<List<WorkersCompReportGridModel>> ReportsWorkersComp_GetAsync(int businessId, ReportsWorkersComp_GetQueryModel request, CancellationToken cancellationToken = default);
        void UpdateStatusEvent(int businessId, IList<TeamCollaborationUpdateStatusModel> model, UpdateStatusEventQueryModel request);
        Task UpdateStatusEventAsync(int businessId, IList<TeamCollaborationUpdateStatusModel> model, UpdateStatusEventQueryModel request, CancellationToken cancellationToken = default);
        List<P11ReportDataModel> UkGetP11ReportDataTest_Generate(int businessId, P11GenerationModel request);
        Task<List<P11ReportDataModel>> UkGetP11ReportDataTest_GenerateAsync(int businessId, P11GenerationModel request, CancellationToken cancellationToken = default);
    }
    public class OtherFunction : BaseFunction, IOtherFunction
    {
        public OtherFunction(ApiRequestExecutor api) : base(api) {}

        public void AwardPackage_Put(AwardPackage_PutQueryModel request)
        {
            ApiRequest($"/admin/awardpackage?url={request.Url}&businessId={request.BusinessId}", Method.Put);
        }

        public Task AwardPackage_PutAsync(AwardPackage_PutQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/admin/awardpackage?url={request.Url}&businessId={request.BusinessId}", Method.Put, cancellationToken);
        }

        /// <summary>
        /// creates a new award package and assigns to the specified business
        /// </summary>
        public void CreatesANewAwardPackageAndAssignsToTheSpecifiedBusiness(AwardPackageDataModel package, CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessQueryModel request)
        {
            ApiRequest($"/admin/awardpackage?businessId={request.BusinessId}", package, Method.Post);
        }

        /// <summary>
        /// creates a new award package and assigns to the specified business
        /// </summary>
        public Task CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessAsync(AwardPackageDataModel package, CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/admin/awardpackage?businessId={request.BusinessId}", package, Method.Post, cancellationToken);
        }

        public void BulkActionHmrc_HmrcSettings(int businessId, BulkActionRequest model)
        {
            ApiRequest($"/admin/business/{businessId}/bulkaction/hmrc", model, Method.Post);
        }

        public Task BulkActionHmrc_HmrcSettingsAsync(int businessId, BulkActionRequest model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/admin/business/{businessId}/bulkaction/hmrc", model, Method.Post, cancellationToken);
        }

        public void BulkActionHmrc_Metadata(int businessId, BulkActionMetadataRequest model)
        {
            ApiRequest($"/admin/business/{businessId}/bulkaction/hmrc/metadata", model, Method.Post);
        }

        public Task BulkActionHmrc_MetadataAsync(int businessId, BulkActionMetadataRequest model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/admin/business/{businessId}/bulkaction/hmrc/metadata", model, Method.Post, cancellationToken);
        }

        public EmployeeUpdateResponseModelWithAdditionalInfo EmployeeAdmin_PostEmployeeAndReturnAdditionalInfo(int businessId, UkUnstructuredEmployeeModel model)
        {
            return ApiRequest<EmployeeUpdateResponseModelWithAdditionalInfo,UkUnstructuredEmployeeModel>($"/admin/business/{businessId}/employee/unstructured", model, Method.Post);
        }

        public Task<EmployeeUpdateResponseModelWithAdditionalInfo> EmployeeAdmin_PostEmployeeAndReturnAdditionalInfoAsync(int businessId, UkUnstructuredEmployeeModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeUpdateResponseModelWithAdditionalInfo,UkUnstructuredEmployeeModel>($"/admin/business/{businessId}/employee/unstructured", model, Method.Post, cancellationToken);
        }

        public EmployeeUpdateResponseModelWithAdditionalInfo EmployeeAdmin_PostEmployeeAndReturnAdditionalInfo(int businessId, UkUnstructuredEmployeeModel model, EmployeeAdmin_PostEmployeeAndReturnAdditionalInfoQueryModel request)
        {
            return ApiRequest<EmployeeUpdateResponseModelWithAdditionalInfo,UkUnstructuredEmployeeModel>($"/admin/business/{businessId}/employee/unstructured?matchType={request.MatchType}", model, Method.Post);
        }

        public Task<EmployeeUpdateResponseModelWithAdditionalInfo> EmployeeAdmin_PostEmployeeAndReturnAdditionalInfoAsync(int businessId, UkUnstructuredEmployeeModel model, EmployeeAdmin_PostEmployeeAndReturnAdditionalInfoQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeUpdateResponseModelWithAdditionalInfo,UkUnstructuredEmployeeModel>($"/admin/business/{businessId}/employee/unstructured?matchType={request.MatchType}", model, Method.Post, cancellationToken);
        }

        public void FixInconsistentDataTest_RetrieveMissingPayCategoryIdForPayCategoryExtUkRecordsRecords(int businessId, FixInconsistentDataTest_RetrieveMissingPayCategoryIdForPayCategoryExtUkRecordsRecordsQueryModel request)
        {
            ApiRequest($"/admin/business/{businessId}/fixinconsistentdata/retrieve-businesses-with-missing-paycategoryid-for-paycategoryextuk-records?dateCreated={(request.DateCreated.HasValue ? request.DateCreated.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        public Task FixInconsistentDataTest_RetrieveMissingPayCategoryIdForPayCategoryExtUkRecordsRecordsAsync(int businessId, FixInconsistentDataTest_RetrieveMissingPayCategoryIdForPayCategoryExtUkRecordsRecordsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/admin/business/{businessId}/fixinconsistentdata/retrieve-businesses-with-missing-paycategoryid-for-paycategoryextuk-records?dateCreated={(request.DateCreated.HasValue ? request.DateCreated.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        public void FixInconsistentDataTest_RetrieveBusinessesForMissingPayCategoryExtUkRecords(int businessId, FixInconsistentDataTest_RetrieveBusinessesForMissingPayCategoryExtUkRecordsQueryModel request)
        {
            ApiRequest($"/admin/business/{businessId}/fixinconsistentdata/retrievebusinesseswithmissingpaycategoryrecords?dateCreated={(request.DateCreated.HasValue ? request.DateCreated.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        public Task FixInconsistentDataTest_RetrieveBusinessesForMissingPayCategoryExtUkRecordsAsync(int businessId, FixInconsistentDataTest_RetrieveBusinessesForMissingPayCategoryExtUkRecordsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/admin/business/{businessId}/fixinconsistentdata/retrievebusinesseswithmissingpaycategoryrecords?dateCreated={(request.DateCreated.HasValue ? request.DateCreated.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Correct NI Record Inconsistencies
        /// </summary>
        /// <remarks>
        /// Retrieves all NI records that don't have an open NI record, i.e. that doesn't have a record with ToDate is null,
        /// and corrects them.
        /// </remarks>
        public InconsistentNIRecordsModel CorrectNiRecordInconsistencies(CorrectNiRecordInconsistenciesQueryModel request)
        {
            return ApiRequest<InconsistentNIRecordsModel>($"/admin/business/employee/nationalinsurancerecord/correctnirecordinconsistencies?queryFromDate={request.QueryFromDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Post);
        }

        /// <summary>
        /// Correct NI Record Inconsistencies
        /// </summary>
        /// <remarks>
        /// Retrieves all NI records that don't have an open NI record, i.e. that doesn't have a record with ToDate is null,
        /// and corrects them.
        /// </remarks>
        public Task<InconsistentNIRecordsModel> CorrectNiRecordInconsistenciesAsync(CorrectNiRecordInconsistenciesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<InconsistentNIRecordsModel>($"/admin/business/employee/nationalinsurancerecord/correctnirecordinconsistencies?queryFromDate={request.QueryFromDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// List NI record inconsistencies
        /// </summary>
        /// <remarks>
        /// List all NI records that don't have an open NI record, i.e. that doesn't have a record with ToDate is null.
        /// </remarks>
        public InconsistentNIRecordsModel ListNiRecordInconsistencies(ListNiRecordInconsistenciesQueryModel request)
        {
            return ApiRequest<InconsistentNIRecordsModel>($"/admin/business/employee/nationalinsurancerecord/listnirecordinconsistencies?queryFromDate={request.QueryFromDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// List NI record inconsistencies
        /// </summary>
        /// <remarks>
        /// List all NI records that don't have an open NI record, i.e. that doesn't have a record with ToDate is null.
        /// </remarks>
        public Task<InconsistentNIRecordsModel> ListNiRecordInconsistenciesAsync(ListNiRecordInconsistenciesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<InconsistentNIRecordsModel>($"/admin/business/employee/nationalinsurancerecord/listnirecordinconsistencies?queryFromDate={request.QueryFromDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        public List<RosterLiveLeaveAccruals> ReportsRosterLiveLeaveExport_Get(int businessId, ReportsRosterLiveLeaveExport_GetQueryModel request)
        {
            return ApiRequest<List<RosterLiveLeaveAccruals>>($"/business/{businessId}/report/leavebalancesexport{ConvertEnumerableToQueryString("payScheduleIds", request.PayScheduleIds?.Select(x => x.ToString()))}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        public Task<List<RosterLiveLeaveAccruals>> ReportsRosterLiveLeaveExport_GetAsync(int businessId, ReportsRosterLiveLeaveExport_GetQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<RosterLiveLeaveAccruals>>($"/business/{businessId}/report/leavebalancesexport{ConvertEnumerableToQueryString("payScheduleIds", request.PayScheduleIds?.Select(x => x.ToString()))}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        public List<MLCSuperReportExportModel> ReportsMLCSuper_Get(int businessId, ReportsMLCSuper_GetQueryModel request)
        {
            return ApiRequest<List<MLCSuperReportExportModel>>($"/business/{businessId}/report/mlcsuper{ConvertEnumerableToQueryString("payScheduleIds", request.PayScheduleIds?.Select(x => x.ToString()))}", Method.Get);
        }

        public Task<List<MLCSuperReportExportModel>> ReportsMLCSuper_GetAsync(int businessId, ReportsMLCSuper_GetQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MLCSuperReportExportModel>>($"/business/{businessId}/report/mlcsuper{ConvertEnumerableToQueryString("payScheduleIds", request.PayScheduleIds?.Select(x => x.ToString()))}", Method.Get, cancellationToken);
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

        public List<PayrollExemptReportExportModel> ReportsPayrollExempt_Get(int businessId)
        {
            return ApiRequest<List<PayrollExemptReportExportModel>>($"/business/{businessId}/report/payrollexempt", Method.Get);
        }

        public Task<List<PayrollExemptReportExportModel>> ReportsPayrollExempt_GetAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayrollExemptReportExportModel>>($"/business/{businessId}/report/payrollexempt", Method.Get, cancellationToken);
        }

        public List<PayrollExemptReportExportModel> ReportsPayrollExempt_Get(int businessId, ReportsPayrollExempt_GetQueryModel request)
        {
            return ApiRequest<List<PayrollExemptReportExportModel>>($"/business/{businessId}/report/payrollexempt?state={request.State}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        public Task<List<PayrollExemptReportExportModel>> ReportsPayrollExempt_GetAsync(int businessId, ReportsPayrollExempt_GetQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayrollExemptReportExportModel>>($"/business/{businessId}/report/payrollexempt?state={request.State}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        public List<WorkersCompReportGridModel> ReportsWorkersComp_Get(int businessId, ReportsWorkersComp_GetQueryModel request)
        {
            return ApiRequest<List<WorkersCompReportGridModel>>($"/business/{businessId}/report/workerscomp?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}", Method.Get);
        }

        public Task<List<WorkersCompReportGridModel>> ReportsWorkersComp_GetAsync(int businessId, ReportsWorkersComp_GetQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<WorkersCompReportGridModel>>($"/business/{businessId}/report/workerscomp?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update status event
        /// </summary>
        /// <remarks>
        /// Posts an update status event, the payroll API acts as a transient layer that forwards the event and payload on
        /// to the correct integration adapter. This will then update the user status in the relevant team collaboration app.
        /// </remarks>
        public void UpdateStatusEvent(int businessId, IList<TeamCollaborationUpdateStatusModel> model, UpdateStatusEventQueryModel request)
        {
            ApiRequest($"/business/{businessId}/teamcollaboration/updatestatus?service={request.Service}", model, Method.Post);
        }

        /// <summary>
        /// Update status event
        /// </summary>
        /// <remarks>
        /// Posts an update status event, the payroll API acts as a transient layer that forwards the event and payload on
        /// to the correct integration adapter. This will then update the user status in the relevant team collaboration app.
        /// </remarks>
        public Task UpdateStatusEventAsync(int businessId, IList<TeamCollaborationUpdateStatusModel> model, UpdateStatusEventQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/teamcollaboration/updatestatus?service={request.Service}", model, Method.Post, cancellationToken);
        }

        public List<P11ReportDataModel> UkGetP11ReportDataTest_Generate(int businessId, P11GenerationModel request)
        {
            return ApiRequest<List<P11ReportDataModel>,P11GenerationModel>($"/business/{businessId}/test/report/p11tests/Generate", request, Method.Post);
        }

        public Task<List<P11ReportDataModel>> UkGetP11ReportDataTest_GenerateAsync(int businessId, P11GenerationModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<P11ReportDataModel>,P11GenerationModel>($"/business/{businessId}/test/report/p11tests/Generate", request, Method.Post, cancellationToken);
        }
    }
}
