using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.Other;

namespace KeyPayV2.My.Functions
{
    public interface IOtherFunction
    {
        void AwardPackage_Put(AwardPackage_PutQueryModel request);
        Task AwardPackage_PutAsync(AwardPackage_PutQueryModel request, CancellationToken cancellationToken = default);
        void CreatesANewAwardPackageAndAssignsToTheSpecifiedBusiness(AwardPackageDataModel package, CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessQueryModel request);
        Task CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessAsync(AwardPackageDataModel package, CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessQueryModel request, CancellationToken cancellationToken = default);
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
        MyEssStatutoryDetailsModel EssStatutoryDetails_Get(int employeeId);
        Task<MyEssStatutoryDetailsModel> EssStatutoryDetails_GetAsync(int employeeId, CancellationToken cancellationToken = default);
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

        public MyEssStatutoryDetailsModel EssStatutoryDetails_Get(int employeeId)
        {
            return ApiRequest<MyEssStatutoryDetailsModel>($"/ess/{employeeId}/statutorydetails", Method.Get);
        }

        public Task<MyEssStatutoryDetailsModel> EssStatutoryDetails_GetAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssStatutoryDetailsModel>($"/ess/{employeeId}/statutorydetails", Method.Get, cancellationToken);
        }
    }
}
