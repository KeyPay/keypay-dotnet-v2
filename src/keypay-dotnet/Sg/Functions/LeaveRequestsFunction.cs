using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.LeaveRequests;

namespace KeyPayV2.Sg.Functions
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
            return ApiRequest<List<UnitLeaveRequestResponseModel>>($"/business/{businessId}/employee/{employeeId}/leaverequest{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
        }

        /// <summary>
        /// Get Leave Requests for Employee
        /// </summary>
        /// <remarks>
        /// Returns all leave requests for this employee, optionally filtered by OData parameters.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<UnitLeaveRequestResponseModel>> GetLeaveRequestsForEmployeeAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UnitLeaveRequestResponseModel>>($"/business/{businessId}/employee/{employeeId}/leaverequest{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public void UpdateLeaveRequest(int businessId, int employeeId, UnitLeaveRequestModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/leaverequest", model, Method.PUT);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public Task UpdateLeaveRequestAsync(int businessId, int employeeId, UnitLeaveRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/leaverequest", model, Method.PUT, cancellationToken);
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
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request for an employee.
        /// </remarks>
        public Task<UnitLeaveRequestResponseModel> CreateLeaveRequestAsync(int businessId, int employeeId, UnitLeaveRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UnitLeaveRequestResponseModel,UnitLeaveRequestModel>($"/business/{businessId}/employee/{employeeId}/leaverequest", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public UnitLeaveRequestResponseModel GetLeaveRequestById(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<UnitLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.GET);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public Task<UnitLeaveRequestResponseModel> GetLeaveRequestByIdAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UnitLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.GET, cancellationToken);
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
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public Task UpdateLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, UnitLeaveRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", model, Method.PUT, cancellationToken);
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
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public Task<UnitLeaveRequestResponseModel> DeleteLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UnitLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.DELETE, cancellationToken);
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
        /// Approve Leave Request
        /// </summary>
        /// <remarks>
        /// Approves the leave request with the specified ID.
        /// </remarks>
        public Task<UnitLeaveRequestResponseModel> ApproveLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UnitLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.POST, cancellationToken);
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
        /// Decline Leave Request
        /// </summary>
        /// <remarks>
        /// Declines the leave request with the specified ID.
        /// </remarks>
        public Task<UnitLeaveRequestResponseModel> DeclineLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, DeclineLeaveRequest decline, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UnitLeaveRequestResponseModel,DeclineLeaveRequest>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/decline", decline, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Estimate Leave Units
        /// </summary>
        /// <remarks>
        /// Estimates the leave Units required for a leave request between fromDate and toDate.
        /// </remarks>
        public UnitLeaveEstimateModel EstimateLeaveUnits(int businessId, int employeeId, EstimateLeaveUnitsQueryModel request)
        {
            return ApiRequest<UnitLeaveEstimateModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/estimate?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&leaveCategoryId={request.LeaveCategoryId}", Method.GET);
        }

        /// <summary>
        /// Estimate Leave Units
        /// </summary>
        /// <remarks>
        /// Estimates the leave Units required for a leave request between fromDate and toDate.
        /// </remarks>
        public Task<UnitLeaveEstimateModel> EstimateLeaveUnitsAsync(int businessId, int employeeId, EstimateLeaveUnitsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UnitLeaveEstimateModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/estimate?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&leaveCategoryId={request.LeaveCategoryId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for the business.
        /// </remarks>
        public List<UnitLeaveRequestResponseModel> ListLeaveRequests(int businessId, ListLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<UnitLeaveRequestResponseModel>>($"/business/{businessId}/leaverequest?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&leaveCategoryId={request.LeaveCategoryId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&groupBy={request.GroupBy}&restrictOverlappingLeave={request.RestrictOverlappingLeave}", Method.GET);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for the business.
        /// </remarks>
        public Task<List<UnitLeaveRequestResponseModel>> ListLeaveRequestsAsync(int businessId, ListLeaveRequestsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UnitLeaveRequestResponseModel>>($"/business/{businessId}/leaverequest?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&leaveCategoryId={request.LeaveCategoryId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&groupBy={request.GroupBy}&restrictOverlappingLeave={request.RestrictOverlappingLeave}", Method.GET, cancellationToken);
        }
    }
}
