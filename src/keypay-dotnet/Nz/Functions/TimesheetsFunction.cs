using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.Timesheets;

namespace KeyPayV2.Nz.Functions
{
    public class TimesheetsFunction : BaseFunction
    {
        public TimesheetsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves all timesheets for the specified business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<NzTimesheetLineModel> GetBusinessTimesheets(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzTimesheetLineModel>>($"/business/{businessId}/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// </remarks>
        public NzIndividualTimesheetLineModel CreateTimesheetLine(int businessId, NzIndividualTimesheetLineModel request)
        {
            return ApiRequest<NzIndividualTimesheetLineModel,NzIndividualTimesheetLineModel>($"/business/{businessId}/timesheet", request, Method.POST);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// </remarks>
        public NzIndividualTimesheetLineModel UpdateTimesheetLine(int businessId, int timesheetLineId, NzIndividualTimesheetLineModel request)
        {
            return ApiRequest<NzIndividualTimesheetLineModel,NzIndividualTimesheetLineModel>($"/business/{businessId}/timesheet/{timesheetLineId}", request, Method.PUT);
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
            ApiRequest($"/business/{businessId}/timesheet/{timesheetLineId}", Method.DELETE);
        }

        /// <summary>
        /// Update/Replace timesheets
        /// </summary>
        /// <remarks>
        /// Performs the same action as 'Bulk Insert Timesheets', but any existing timesheets
        /// for the specified employees within the specified time period
        /// (StartTime - EndTime) will be replaced with the timesheets specified.
        /// </remarks>
        public NzSubmitTimesheetsRequest UpdateReplaceTimesheets(int businessId, NzSubmitTimesheetsRequest request)
        {
            return ApiRequest<NzSubmitTimesheetsRequest,NzSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.PUT);
        }

        /// <summary>
        /// Bulk Insert Timesheets
        /// </summary>
        /// <remarks>
        /// Adds timesheets for the specified business. This will not replace any existing timesheets.
        /// </remarks>
        public NzSubmitTimesheetsRequest BulkInsertTimesheets(int businessId, NzSubmitTimesheetsRequest request)
        {
            return ApiRequest<NzSubmitTimesheetsRequest,NzSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.POST);
        }
    }
}
