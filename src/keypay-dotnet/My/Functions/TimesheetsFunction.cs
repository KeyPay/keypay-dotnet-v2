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
using KeyPayV2.My.Models.Timesheets;

namespace KeyPayV2.My.Functions
{
    public interface ITimesheetsFunction
    {
        List<MyTimesheetLineModel> GetBusinessTimesheets(int businessId, ODataQuery oDataQuery = null);
        Task<List<MyTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        MyIndividualTimesheetLineModel CreateTimesheetLine(int businessId, MyIndividualTimesheetLineModel request);
        Task<MyIndividualTimesheetLineModel> CreateTimesheetLineAsync(int businessId, MyIndividualTimesheetLineModel request, CancellationToken cancellationToken = default);
        MyIndividualTimesheetLineModel UpdateTimesheetLine(int businessId, int timesheetLineId, MyIndividualTimesheetLineModel request);
        Task<MyIndividualTimesheetLineModel> UpdateTimesheetLineAsync(int businessId, int timesheetLineId, MyIndividualTimesheetLineModel request, CancellationToken cancellationToken = default);
        void DeleteTimesheetLine(int businessId, int timesheetLineId);
        Task DeleteTimesheetLineAsync(int businessId, int timesheetLineId, CancellationToken cancellationToken = default);
        MySubmitTimesheetsResponse UpdateReplaceTimesheets(int businessId, MySubmitTimesheetsRequest request);
        Task<MySubmitTimesheetsResponse> UpdateReplaceTimesheetsAsync(int businessId, MySubmitTimesheetsRequest request, CancellationToken cancellationToken = default);
        MySubmitTimesheetsResponse BulkInsertTimesheets(int businessId, MySubmitTimesheetsRequest request);
        Task<MySubmitTimesheetsResponse> BulkInsertTimesheetsAsync(int businessId, MySubmitTimesheetsRequest request, CancellationToken cancellationToken = default);
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
        public List<MyTimesheetLineModel> GetBusinessTimesheets(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<MyTimesheetLineModel>>($"/business/{businessId}/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves all timesheets for the specified business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<MyTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyTimesheetLineModel>>($"/business/{businessId}/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public MyIndividualTimesheetLineModel CreateTimesheetLine(int businessId, MyIndividualTimesheetLineModel request)
        {
            return ApiRequest<MyIndividualTimesheetLineModel,MyIndividualTimesheetLineModel>($"/business/{businessId}/timesheet", request, Method.Post);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task<MyIndividualTimesheetLineModel> CreateTimesheetLineAsync(int businessId, MyIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyIndividualTimesheetLineModel,MyIndividualTimesheetLineModel>($"/business/{businessId}/timesheet", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public MyIndividualTimesheetLineModel UpdateTimesheetLine(int businessId, int timesheetLineId, MyIndividualTimesheetLineModel request)
        {
            return ApiRequest<MyIndividualTimesheetLineModel,MyIndividualTimesheetLineModel>($"/business/{businessId}/timesheet/{timesheetLineId}", request, Method.Put);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task<MyIndividualTimesheetLineModel> UpdateTimesheetLineAsync(int businessId, int timesheetLineId, MyIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyIndividualTimesheetLineModel,MyIndividualTimesheetLineModel>($"/business/{businessId}/timesheet/{timesheetLineId}", request, Method.Put, cancellationToken);
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
        public MySubmitTimesheetsResponse UpdateReplaceTimesheets(int businessId, MySubmitTimesheetsRequest request)
        {
            return ApiRequest<MySubmitTimesheetsResponse,MySubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Put);
        }

        /// <summary>
        /// Update/Replace timesheets
        /// </summary>
        /// <remarks>
        /// Performs the same action as 'Bulk Insert Timesheets', but any existing timesheets
        /// for the specified employees within the specified time period
        /// (StartTime - EndTime) will be replaced with the timesheets specified.
        /// </remarks>
        public Task<MySubmitTimesheetsResponse> UpdateReplaceTimesheetsAsync(int businessId, MySubmitTimesheetsRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MySubmitTimesheetsResponse,MySubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Put, cancellationToken);
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
        public MySubmitTimesheetsResponse BulkInsertTimesheets(int businessId, MySubmitTimesheetsRequest request)
        {
            return ApiRequest<MySubmitTimesheetsResponse,MySubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Post);
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
        public Task<MySubmitTimesheetsResponse> BulkInsertTimesheetsAsync(int businessId, MySubmitTimesheetsRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MySubmitTimesheetsResponse,MySubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Post, cancellationToken);
        }
    }
}
