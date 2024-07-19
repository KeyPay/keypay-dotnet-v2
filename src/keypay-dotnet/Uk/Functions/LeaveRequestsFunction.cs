using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.LeaveRequests;

namespace KeyPayV2.Uk.Functions
{
    public interface ILeaveRequestsFunction
    {
        List<UkUnitLeaveRequestResponseModel> GetLeaveRequestsForEmployee(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<UkUnitLeaveRequestResponseModel>> GetLeaveRequestsForEmployeeAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void UpdateLeaveRequest(int businessId, int employeeId, UkUnitLeaveRequestModel model);
        Task UpdateLeaveRequestAsync(int businessId, int employeeId, UkUnitLeaveRequestModel model, CancellationToken cancellationToken = default);
        UkUnitLeaveRequestResponseModel CreateLeaveRequest(int businessId, int employeeId, UkUnitLeaveRequestModel model);
        Task<UkUnitLeaveRequestResponseModel> CreateLeaveRequestAsync(int businessId, int employeeId, UkUnitLeaveRequestModel model, CancellationToken cancellationToken = default);
        UkUnitLeaveRequestResponseModel GetLeaveRequestById(int businessId, int employeeId, int leaveRequestId);
        Task<UkUnitLeaveRequestResponseModel> GetLeaveRequestByIdAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        void UpdateLeaveRequest(int businessId, int employeeId, int leaveRequestId, UkUnitLeaveRequestModel model);
        Task UpdateLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, UkUnitLeaveRequestModel model, CancellationToken cancellationToken = default);
        UkUnitLeaveRequestResponseModel DeleteLeaveRequest(int businessId, int employeeId, int leaveRequestId);
        Task<UkUnitLeaveRequestResponseModel> DeleteLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        UkUnitLeaveRequestResponseModel ApproveLeaveRequest(int businessId, int employeeId, int leaveRequestId);
        Task<UkUnitLeaveRequestResponseModel> ApproveLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        UkUnitLeaveRequestResponseModel DeclineLeaveRequest(int businessId, int employeeId, int leaveRequestId, DeclineLeaveRequest decline);
        Task<UkUnitLeaveRequestResponseModel> DeclineLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, DeclineLeaveRequest decline, CancellationToken cancellationToken = default);
        UnitLeaveEstimateModel EstimateLeaveUnits(int businessId, int employeeId, EstimateLeaveUnitsQueryModel request);
        Task<UnitLeaveEstimateModel> EstimateLeaveUnitsAsync(int businessId, int employeeId, EstimateLeaveUnitsQueryModel request, CancellationToken cancellationToken = default);
        List<UnitLeaveRequestResponseModel> ListLeaveRequests(int businessId);
        Task<List<UnitLeaveRequestResponseModel>> ListLeaveRequestsAsync(int businessId, CancellationToken cancellationToken = default);
        List<UnitLeaveRequestResponseModel> ListLeaveRequests(int businessId, ListLeaveRequestsQueryModel request);
        Task<List<UnitLeaveRequestResponseModel>> ListLeaveRequestsAsync(int businessId, ListLeaveRequestsQueryModel request, CancellationToken cancellationToken = default);
    }
    public class LeaveRequestsFunction : BaseFunction, ILeaveRequestsFunction
    {
        public LeaveRequestsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Leave Requests for Employee
        /// </summary>
        /// <remarks>
        /// Returns all leave requests for this employee, optionally filtered by OData parameters.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<UkUnitLeaveRequestResponseModel> GetLeaveRequestsForEmployee(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkUnitLeaveRequestResponseModel>>($"/business/{businessId}/employee/{employeeId}/leaverequest{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// Get Leave Requests for Employee
        /// </summary>
        /// <remarks>
        /// Returns all leave requests for this employee, optionally filtered by OData parameters.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<UkUnitLeaveRequestResponseModel>> GetLeaveRequestsForEmployeeAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkUnitLeaveRequestResponseModel>>($"/business/{businessId}/employee/{employeeId}/leaverequest{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public void UpdateLeaveRequest(int businessId, int employeeId, UkUnitLeaveRequestModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/leaverequest", model, Method.Put);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public Task UpdateLeaveRequestAsync(int businessId, int employeeId, UkUnitLeaveRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/leaverequest", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request for an employee.
        /// </remarks>
        public UkUnitLeaveRequestResponseModel CreateLeaveRequest(int businessId, int employeeId, UkUnitLeaveRequestModel model)
        {
            return ApiRequest<UkUnitLeaveRequestResponseModel,UkUnitLeaveRequestModel>($"/business/{businessId}/employee/{employeeId}/leaverequest", model, Method.Post);
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request for an employee.
        /// </remarks>
        public Task<UkUnitLeaveRequestResponseModel> CreateLeaveRequestAsync(int businessId, int employeeId, UkUnitLeaveRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnitLeaveRequestResponseModel,UkUnitLeaveRequestModel>($"/business/{businessId}/employee/{employeeId}/leaverequest", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public UkUnitLeaveRequestResponseModel GetLeaveRequestById(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<UkUnitLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.Get);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public Task<UkUnitLeaveRequestResponseModel> GetLeaveRequestByIdAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnitLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public void UpdateLeaveRequest(int businessId, int employeeId, int leaveRequestId, UkUnitLeaveRequestModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", model, Method.Put);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public Task UpdateLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, UkUnitLeaveRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public UkUnitLeaveRequestResponseModel DeleteLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<UkUnitLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.Delete);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public Task<UkUnitLeaveRequestResponseModel> DeleteLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnitLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Approve Leave Request
        /// </summary>
        /// <remarks>
        /// Approves the leave request with the specified ID.
        /// </remarks>
        public UkUnitLeaveRequestResponseModel ApproveLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<UkUnitLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.Post);
        }

        /// <summary>
        /// Approve Leave Request
        /// </summary>
        /// <remarks>
        /// Approves the leave request with the specified ID.
        /// </remarks>
        public Task<UkUnitLeaveRequestResponseModel> ApproveLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnitLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Decline Leave Request
        /// </summary>
        /// <remarks>
        /// Declines the leave request with the specified ID.
        /// </remarks>
        public UkUnitLeaveRequestResponseModel DeclineLeaveRequest(int businessId, int employeeId, int leaveRequestId, DeclineLeaveRequest decline)
        {
            return ApiRequest<UkUnitLeaveRequestResponseModel,DeclineLeaveRequest>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/decline", decline, Method.Post);
        }

        /// <summary>
        /// Decline Leave Request
        /// </summary>
        /// <remarks>
        /// Declines the leave request with the specified ID.
        /// </remarks>
        public Task<UkUnitLeaveRequestResponseModel> DeclineLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, DeclineLeaveRequest decline, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnitLeaveRequestResponseModel,DeclineLeaveRequest>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/decline", decline, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Estimate Leave Units
        /// </summary>
        /// <remarks>
        /// Estimates the leave Units required for a leave request between fromDate and toDate.
        /// </remarks>
        public UnitLeaveEstimateModel EstimateLeaveUnits(int businessId, int employeeId, EstimateLeaveUnitsQueryModel request)
        {
            return ApiRequest<UnitLeaveEstimateModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/estimate?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&leaveCategoryId={request.LeaveCategoryId}", Method.Get);
        }

        /// <summary>
        /// Estimate Leave Units
        /// </summary>
        /// <remarks>
        /// Estimates the leave Units required for a leave request between fromDate and toDate.
        /// </remarks>
        public Task<UnitLeaveEstimateModel> EstimateLeaveUnitsAsync(int businessId, int employeeId, EstimateLeaveUnitsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UnitLeaveEstimateModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/estimate?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&leaveCategoryId={request.LeaveCategoryId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for the business.
        /// </remarks>
        public List<UnitLeaveRequestResponseModel> ListLeaveRequests(int businessId)
        {
            return ApiRequest<List<UnitLeaveRequestResponseModel>>($"/business/{businessId}/leaverequest", Method.Get);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for the business.
        /// </remarks>
        public Task<List<UnitLeaveRequestResponseModel>> ListLeaveRequestsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UnitLeaveRequestResponseModel>>($"/business/{businessId}/leaverequest", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for the business.
        /// </remarks>
        public List<UnitLeaveRequestResponseModel> ListLeaveRequests(int businessId, ListLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<UnitLeaveRequestResponseModel>>($"/business/{businessId}/leaverequest?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&leaveCategoryId={request.LeaveCategoryId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&groupBy={request.GroupBy}&restrictOverlappingLeave={request.RestrictOverlappingLeave}", Method.Get);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for the business.
        /// </remarks>
        public Task<List<UnitLeaveRequestResponseModel>> ListLeaveRequestsAsync(int businessId, ListLeaveRequestsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UnitLeaveRequestResponseModel>>($"/business/{businessId}/leaverequest?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&leaveCategoryId={request.LeaveCategoryId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&groupBy={request.GroupBy}&restrictOverlappingLeave={request.RestrictOverlappingLeave}", Method.Get, cancellationToken);
        }
    }
}
