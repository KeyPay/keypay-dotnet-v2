using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.Timesheets;

namespace KeyPayV2.Uk.Functions
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
        public List<UkTimesheetLineModel> GetBusinessTimesheets(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkTimesheetLineModel>>($"/business/{businessId}/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// </remarks>
        public UkIndividualTimesheetLineModel CreateTimesheetLine(int businessId, UkIndividualTimesheetLineModel request)
        {
            return ApiRequest<UkIndividualTimesheetLineModel,UkIndividualTimesheetLineModel>($"/business/{businessId}/timesheet", request, Method.POST);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// </remarks>
        public UkIndividualTimesheetLineModel UpdateTimesheetLine(int businessId, int timesheetLineId, UkIndividualTimesheetLineModel request)
        {
            return ApiRequest<UkIndividualTimesheetLineModel,UkIndividualTimesheetLineModel>($"/business/{businessId}/timesheet/{timesheetLineId}", request, Method.PUT);
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
        public UkSubmitTimesheetsRequest UpdateReplaceTimesheets(int businessId, UkSubmitTimesheetsRequest request)
        {
            return ApiRequest<UkSubmitTimesheetsRequest,UkSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.PUT);
        }

        /// <summary>
        /// Bulk Insert Timesheets
        /// </summary>
        /// <remarks>
        /// Adds timesheets for the specified business. This will not replace any existing timesheets.
        /// </remarks>
        public UkSubmitTimesheetsRequest BulkInsertTimesheets(int businessId, UkSubmitTimesheetsRequest request)
        {
            return ApiRequest<UkSubmitTimesheetsRequest,UkSubmitTimesheetsRequest>($"/business/{businessId}/timesheet/bulk", request, Method.POST);
        }
    }
}
