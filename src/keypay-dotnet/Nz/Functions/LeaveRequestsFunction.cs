using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.LeaveRequests;

namespace KeyPayV2.Nz.Functions
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
        public List<UnitLeaveRequestResponseModel> GetLeaveRequestsForEmployee(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UnitLeaveRequestResponseModel>>($"/business/{businessId}/employee/{employeeId}/leaverequest{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request for an employee.
        /// </remarks>
        public UnitLeaveRequestResponseModel CreateLeaveRequest(int businessId, int employeeId, UnitLeaveRequestModel model)
        {
            return ApiRequest<UnitLeaveRequestResponseModel,UnitLeaveRequestModel>($"/business/{businessId}/employee/{employeeId}/leaverequest", model, Method.POST);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public UnitLeaveRequestResponseModel GetLeaveRequestById(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<UnitLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}");
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public void UpdateLeaveRequest(int businessId, int employeeId, int leaveRequestId, UnitLeaveRequestModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", model, Method.PUT);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public UnitLeaveRequestResponseModel DeleteLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<UnitLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.DELETE);
        }

        /// <summary>
        /// Approve Leave Request
        /// </summary>
        /// <remarks>
        /// Approves the leave request with the specified ID.
        /// </remarks>
        public UnitLeaveRequestResponseModel ApproveLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<UnitLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.POST);
        }

        /// <summary>
        /// Decline Leave Request
        /// </summary>
        /// <remarks>
        /// Declines the leave request with the specified ID.
        /// </remarks>
        public UnitLeaveRequestResponseModel DeclineLeaveRequest(int businessId, int employeeId, int leaveRequestId, DeclineLeaveRequest decline)
        {
            return ApiRequest<UnitLeaveRequestResponseModel,DeclineLeaveRequest>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/decline", decline, Method.POST);
        }

        /// <summary>
        /// Estimate Leave Units
        /// </summary>
        /// <remarks>
        /// Estimates the leave Units required for a leave request between fromDate and toDate.
        /// </remarks>
        public UnitLeaveEstimateModel EstimateLeaveUnits(int businessId, int employeeId, EstimateLeaveUnitsQueryModel request)
        {
            return ApiRequest<UnitLeaveEstimateModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/estimate?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&leaveCategoryId={request.LeaveCategoryId}");
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for the business.
        /// </remarks>
        public List<UnitLeaveRequestResponseModel> ListLeaveRequests(int businessId, ListLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<UnitLeaveRequestResponseModel>>($"/business/{businessId}/leaverequest?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&leaveCategoryId={request.LeaveCategoryId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&groupBy={request.GroupBy}&restrictOverlappingLeave={request.RestrictOverlappingLeave}");
        }
    }
}
