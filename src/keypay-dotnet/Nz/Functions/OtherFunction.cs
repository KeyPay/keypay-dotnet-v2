using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.Other;

namespace KeyPayV2.Nz.Functions
{
    public class OtherFunction : BaseFunction
    {
        public OtherFunction(ApiRequestExecutor api) : base(api) {}

        public NzPayRunDetailsModel NzPayRunDetails_Get(int businessId, int payRunId)
        {
            return ApiRequest<NzPayRunDetailsModel>($"/business/{businessId}/payrun/{payRunId}/details", Method.Get);
        }

        public Task<NzPayRunDetailsModel> NzPayRunDetails_GetAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzPayRunDetailsModel>($"/business/{businessId}/payrun/{payRunId}/details", Method.Get, cancellationToken);
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

        public List<ShiftSwappingReportExportModel> ReportsShiftSwapping_Get(int businessId)
        {
            return ApiRequest<List<ShiftSwappingReportExportModel>>($"/business/{businessId}/report/shiftswapping", Method.Get);
        }

        public Task<List<ShiftSwappingReportExportModel>> ReportsShiftSwapping_GetAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ShiftSwappingReportExportModel>>($"/business/{businessId}/report/shiftswapping", Method.Get, cancellationToken);
        }

        public List<ShiftSwappingReportExportModel> ReportsShiftSwapping_Get(int businessId, ReportsShiftSwapping_GetQueryModel request)
        {
            return ApiRequest<List<ShiftSwappingReportExportModel>>($"/business/{businessId}/report/shiftswapping?fromEmployeeId={request.FromEmployeeId}&toEmployeeId={request.ToEmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("statuses", request.Statuses?.Select(x => x.ToString()))}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        public Task<List<ShiftSwappingReportExportModel>> ReportsShiftSwapping_GetAsync(int businessId, ReportsShiftSwapping_GetQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ShiftSwappingReportExportModel>>($"/business/{businessId}/report/shiftswapping?fromEmployeeId={request.FromEmployeeId}&toEmployeeId={request.ToEmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("statuses", request.Statuses?.Select(x => x.ToString()))}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        public List<TasksReportExportModel> ReportsTasksReport_Get(int businessId)
        {
            return ApiRequest<List<TasksReportExportModel>>($"/business/{businessId}/report/tasks", Method.Get);
        }

        public Task<List<TasksReportExportModel>> ReportsTasksReport_GetAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TasksReportExportModel>>($"/business/{businessId}/report/tasks", Method.Get, cancellationToken);
        }

        public List<TasksReportExportModel> ReportsTasksReport_Get(int businessId, ReportsTasksReport_GetQueryModel request)
        {
            return ApiRequest<List<TasksReportExportModel>>($"/business/{businessId}/report/tasks?employeeId={request.EmployeeId}&payRunId={request.PayRunId}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&payScheduleId={request.PayScheduleId}&status={request.Status}", Method.Get);
        }

        public Task<List<TasksReportExportModel>> ReportsTasksReport_GetAsync(int businessId, ReportsTasksReport_GetQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TasksReportExportModel>>($"/business/{businessId}/report/tasks?employeeId={request.EmployeeId}&payRunId={request.PayRunId}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&payScheduleId={request.PayScheduleId}&status={request.Status}", Method.Get, cancellationToken);
        }
    }
}
