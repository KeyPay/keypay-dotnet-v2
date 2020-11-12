using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.LeaveRequests;

namespace KeyPayV2.Au.Functions
{
    public class LeaveRequestsFunction : BaseFunction
    {
        public LeaveRequestsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Leave Requests for Employee
        /// </summary>
        /// <remarks>
        /// Returns all leave requests for this employee, optionally filtered by OData parameters.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<HourLeaveRequestResponseModel> GetLeaveRequestsForEmployee(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<HourLeaveRequestResponseModel>>($"/business/{businessId}/employee/{employeeId}/leaverequest{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request for an employee.
        /// </remarks>
        public HourLeaveRequestResponseModel CreateLeaveRequest(int businessId, int employeeId, HourLeaveRequestModel model)
        {
            return ApiRequest<HourLeaveRequestResponseModel,HourLeaveRequestModel>($"/business/{businessId}/employee/{employeeId}/leaverequest", model, Method.POST);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public HourLeaveRequestResponseModel GetLeaveRequestById(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<HourLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}");
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public void UpdateLeaveRequest(int businessId, int employeeId, int leaveRequestId, HourLeaveRequestModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", model, Method.PUT);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public HourLeaveRequestResponseModel DeleteLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<HourLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.DELETE);
        }

        /// <summary>
        /// Approve Leave Request
        /// </summary>
        /// <remarks>
        /// Approves the leave request with the specified ID.
        /// </remarks>
        public HourLeaveRequestResponseModel ApproveLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<HourLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.POST);
        }

        /// <summary>
        /// Decline Leave Request
        /// </summary>
        /// <remarks>
        /// Declines the leave request with the specified ID.
        /// </remarks>
        public HourLeaveRequestResponseModel DeclineLeaveRequest(int businessId, int employeeId, int leaveRequestId, DeclineLeaveRequest decline)
        {
            return ApiRequest<HourLeaveRequestResponseModel,DeclineLeaveRequest>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/decline", decline, Method.POST);
        }

        /// <summary>
        /// Estimate Leave Hours
        /// </summary>
        /// <remarks>
        /// Estimates the leave hours required for a leave request between fromDate and toDate.
        /// </remarks>
        public HourLeaveEstimateModel EstimateLeaveHours(int businessId, int employeeId, EstimateLeaveHoursQueryModel request)
        {
            return ApiRequest<HourLeaveEstimateModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/estimate?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&leaveCategoryId={request.LeaveCategoryId}");
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for the business.
        /// </remarks>
        public List<HourLeaveRequestResponseModel> ListLeaveRequests(int businessId, ListLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<HourLeaveRequestResponseModel>>($"/business/{businessId}/leaverequest?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&leaveCategoryId={request.LeaveCategoryId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&groupBy={request.GroupBy}&restrictOverlappingLeave={request.RestrictOverlappingLeave}");
        }
    }
}
