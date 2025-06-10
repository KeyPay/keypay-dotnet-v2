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
using KeyPayV2.Au.Models.Timesheets;

namespace KeyPayV2.Au.Functions
{
    public interface ITimesheetsFunction
    {
        List<AuTimesheetLineModel> GetBusinessTimesheets(int businessId, ODataQuery oDataQuery = null);
        Task<List<AuTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        AuIndividualTimesheetLineModel CreateTimesheetLine(int businessId, AuIndividualTimesheetLineModel request);
        Task<AuIndividualTimesheetLineModel> CreateTimesheetLineAsync(int businessId, AuIndividualTimesheetLineModel request, CancellationToken cancellationToken = default);
        AuIndividualTimesheetLineModel UpdateTimesheetLine(int businessId, int timesheetLineId, AuIndividualTimesheetLineModel request);
        Task<AuIndividualTimesheetLineModel> UpdateTimesheetLineAsync(int businessId, int timesheetLineId, AuIndividualTimesheetLineModel request, CancellationToken cancellationToken = default);
        void DeleteTimesheetLine(int businessId, int timesheetLineId);
        Task DeleteTimesheetLineAsync(int businessId, int timesheetLineId, CancellationToken cancellationToken = default);
        AuSubmitTimesheetsResponse UpdateReplaceTimesheets(int businessId, AuSubmitTimesheetsRequest request);
        Task<AuSubmitTimesheetsResponse> UpdateReplaceTimesheetsAsync(int businessId, AuSubmitTimesheetsRequest request, CancellationToken cancellationToken = default);
        AuSubmitTimesheetsResponse BulkInsertTimesheets(int businessId, AuSubmitTimesheetsRequest request);
        Task<AuSubmitTimesheetsResponse> BulkInsertTimesheetsAsync(int businessId, AuSubmitTimesheetsRequest request, CancellationToken cancellationToken = default);
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
        public List<AuTimesheetLineModel> GetBusinessTimesheets(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<AuTimesheetLineModel>>($"/business/{businessId}/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves all timesheets for the specified business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<AuTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuTimesheetLineModel>>($"/business/{businessId}/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public AuIndividualTimesheetLineModel CreateTimesheetLine(int businessId, AuIndividualTimesheetLineModel request)
        {
            return ApiRequest<AuIndividualTimesheetLineModel,AuIndividualTimesheetLineModel>($"/business/{businessId}/timesheet", request, Method.Post);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task<AuIndividualTimesheetLineModel> CreateTimesheetLineAsync(int businessId, AuIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuIndividualTimesheetLineModel,AuIndividualTimesheetLineModel>($"/business/{businessId}/timesheet", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public AuIndividualTimesheetLineModel UpdateTimesheetLine(int businessId, int timesheetLineId, AuIndividualTimesheetLineModel request)
        {
            return ApiRequest<AuIndividualTimesheetLineModel,AuIndividualTimesheetLineModel>($"/business/{businessId}/timesheet/{timesheetLineId}", request, Method.Put);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task<AuIndividualTimesheetLineModel> UpdateTimesheetLineAsync(int businessId, int timesheetLineId, AuIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuIndividualTimesheetLineModel,AuIndividualTimesheetLineModel>($"/business/{businessId}/timesheet/{timesheetLineId}", request, Method.Put, cancellationToken);
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
        public AuSubmitTimesheetsResponse UpdateReplaceTimesheets(int businessId, AuSubmitTimesheetsRequest request)
        {
            return ApiRequest<AuSubmitTimesheetsResponse,AuSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Put);
        }

        /// <summary>
        /// Update/Replace timesheets
        /// </summary>
        /// <remarks>
        /// Performs the same action as 'Bulk Insert Timesheets', but any existing timesheets
        /// for the specified employees within the specified time period
        /// (StartTime - EndTime) will be replaced with the timesheets specified.
        /// </remarks>
        public Task<AuSubmitTimesheetsResponse> UpdateReplaceTimesheetsAsync(int businessId, AuSubmitTimesheetsRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuSubmitTimesheetsResponse,AuSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Put, cancellationToken);
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
        public AuSubmitTimesheetsResponse BulkInsertTimesheets(int businessId, AuSubmitTimesheetsRequest request)
        {
            return ApiRequest<AuSubmitTimesheetsResponse,AuSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Post);
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
        public Task<AuSubmitTimesheetsResponse> BulkInsertTimesheetsAsync(int businessId, AuSubmitTimesheetsRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuSubmitTimesheetsResponse,AuSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.Post, cancellationToken);
        }
    }
}
