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
using KeyPayV2.Sg.Models.Timesheets;

namespace KeyPayV2.Sg.Functions
{
    public interface ITimesheetsFunction
    {
        List<SgTimesheetLineModel> GetBusinessTimesheets(int businessId, ODataQuery oDataQuery = null);
        Task<List<SgTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        SgIndividualTimesheetLineModel CreateTimesheetLine(int businessId, SgIndividualTimesheetLineModel request);
        Task<SgIndividualTimesheetLineModel> CreateTimesheetLineAsync(int businessId, SgIndividualTimesheetLineModel request, CancellationToken cancellationToken = default);
        SgIndividualTimesheetLineModel UpdateTimesheetLine(int businessId, int timesheetLineId, SgIndividualTimesheetLineModel request);
        Task<SgIndividualTimesheetLineModel> UpdateTimesheetLineAsync(int businessId, int timesheetLineId, SgIndividualTimesheetLineModel request, CancellationToken cancellationToken = default);
        void DeleteTimesheetLine(int businessId, int timesheetLineId);
        Task DeleteTimesheetLineAsync(int businessId, int timesheetLineId, CancellationToken cancellationToken = default);
        SgSubmitTimesheetsResponse UpdateReplaceTimesheets(int businessId, SgSubmitTimesheetsRequest request);
        Task<SgSubmitTimesheetsResponse> UpdateReplaceTimesheetsAsync(int businessId, SgSubmitTimesheetsRequest request, CancellationToken cancellationToken = default);
        SgSubmitTimesheetsResponse BulkInsertTimesheets(int businessId, SgSubmitTimesheetsRequest request);
        Task<SgSubmitTimesheetsResponse> BulkInsertTimesheetsAsync(int businessId, SgSubmitTimesheetsRequest request, CancellationToken cancellationToken = default);
    }
    public class TimesheetsFunction : BaseFunction, ITimesheetsFunction
    {
        public TimesheetsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves all timesheets for the specified business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<SgTimesheetLineModel> GetBusinessTimesheets(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<SgTimesheetLineModel>>($"/business/{businessId}/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves all timesheets for the specified business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<SgTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgTimesheetLineModel>>($"/business/{businessId}/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public SgIndividualTimesheetLineModel CreateTimesheetLine(int businessId, SgIndividualTimesheetLineModel request)
        {
            return ApiRequest<SgIndividualTimesheetLineModel,SgIndividualTimesheetLineModel>($"/business/{businessId}/timesheet", request, Method.Post);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task<SgIndividualTimesheetLineModel> CreateTimesheetLineAsync(int businessId, SgIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgIndividualTimesheetLineModel,SgIndividualTimesheetLineModel>($"/business/{businessId}/timesheet", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public SgIndividualTimesheetLineModel UpdateTimesheetLine(int businessId, int timesheetLineId, SgIndividualTimesheetLineModel request)
        {
            return ApiRequest<SgIndividualTimesheetLineModel,SgIndividualTimesheetLineModel>($"/business/{businessId}/timesheet/{timesheetLineId}", request, Method.Put);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task<SgIndividualTimesheetLineModel> UpdateTimesheetLineAsync(int businessId, int timesheetLineId, SgIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgIndividualTimesheetLineModel,SgIndividualTimesheetLineModel>($"/business/{businessId}/timesheet/{timesheetLineId}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete timesheet line
        /// </summary>
        /// <remarks>
        /// Delete an individual timesheet line.
        /// Note: You cannot delete a Processed timesheet line.
        /// </remarks>
        public void DeleteTimesheetLine(int businessId, int timesheetLineId)
        {
            ApiRequest($"/business/{businessId}/timesheet/{timesheetLineId}", Method.Delete);
        }

        /// <summary>
        /// Delete timesheet line
        /// </summary>
        /// <remarks>
        /// Delete an individual timesheet line.
        /// Note: You cannot delete a Processed timesheet line.
        /// </remarks>
        public Task DeleteTimesheetLineAsync(int businessId, int timesheetLineId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/timesheet/{timesheetLineId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Update/Replace timesheets
        /// </summary>
        /// <remarks>
        /// Performs the same action as 'Bulk Insert Timesheets', but any existing timesheets
        /// for the specified employees within the specified time period
        /// (StartTime - EndTime) will be replaced with the timesheets specified.
        /// </remarks>
        public SgSubmitTimesheetsResponse UpdateReplaceTimesheets(int businessId, SgSubmitTimesheetsRequest request)
        {
            return ApiRequest<SgSubmitTimesheetsResponse,SgSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Put);
        }

        /// <summary>
        /// Update/Replace timesheets
        /// </summary>
        /// <remarks>
        /// Performs the same action as 'Bulk Insert Timesheets', but any existing timesheets
        /// for the specified employees within the specified time period
        /// (StartTime - EndTime) will be replaced with the timesheets specified.
        /// </remarks>
        public Task<SgSubmitTimesheetsResponse> UpdateReplaceTimesheetsAsync(int businessId, SgSubmitTimesheetsRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgSubmitTimesheetsResponse,SgSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Bulk Insert Timesheets
        /// </summary>
        /// <remarks>
        /// Adds timesheets for the specified business. This will not replace any existing timesheets.
        /// The timesheets should be grouped by their associated employee IDs, with the key for the timesheet array
        /// being the employee ID. For a Standard Employee ID Type, make sure the employee ID is an integer.
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public SgSubmitTimesheetsResponse BulkInsertTimesheets(int businessId, SgSubmitTimesheetsRequest request)
        {
            return ApiRequest<SgSubmitTimesheetsResponse,SgSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Post);
        }

        /// <summary>
        /// Bulk Insert Timesheets
        /// </summary>
        /// <remarks>
        /// Adds timesheets for the specified business. This will not replace any existing timesheets.
        /// The timesheets should be grouped by their associated employee IDs, with the key for the timesheet array
        /// being the employee ID. For a Standard Employee ID Type, make sure the employee ID is an integer.
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task<SgSubmitTimesheetsResponse> BulkInsertTimesheetsAsync(int businessId, SgSubmitTimesheetsRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgSubmitTimesheetsResponse,SgSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Post, cancellationToken);
        }
    }
}
