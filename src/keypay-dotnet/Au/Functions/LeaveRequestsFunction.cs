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
using KeyPayV2.Au.Models.LeaveRequests;

namespace KeyPayV2.Au.Functions
{
    public interface ILeaveRequestsFunction
    {
        List<HourLeaveRequestResponseModel> GetLeaveRequestsForEmployee(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<HourLeaveRequestResponseModel>> GetLeaveRequestsForEmployeeAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void UpdateLeaveRequest(int businessId, int employeeId, HourLeaveRequestModel model);
        Task UpdateLeaveRequestAsync(int businessId, int employeeId, HourLeaveRequestModel model, CancellationToken cancellationToken = default);
        HourLeaveRequestResponseModel CreateLeaveRequest(int businessId, int employeeId, HourLeaveRequestModel model);
        Task<HourLeaveRequestResponseModel> CreateLeaveRequestAsync(int businessId, int employeeId, HourLeaveRequestModel model, CancellationToken cancellationToken = default);
        HourLeaveRequestResponseModel GetLeaveRequestById(int businessId, int employeeId, int leaveRequestId);
        Task<HourLeaveRequestResponseModel> GetLeaveRequestByIdAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        void UpdateLeaveRequest(int businessId, int employeeId, int leaveRequestId, HourLeaveRequestModel model);
        Task UpdateLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, HourLeaveRequestModel model, CancellationToken cancellationToken = default);
        HourLeaveRequestResponseModel DeleteLeaveRequest(int businessId, int employeeId, int leaveRequestId);
        Task<HourLeaveRequestResponseModel> DeleteLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        HourLeaveRequestResponseModel ApproveLeaveRequest(int businessId, int employeeId, int leaveRequestId);
        Task<HourLeaveRequestResponseModel> ApproveLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        HourLeaveRequestResponseModel DeclineLeaveRequest(int businessId, int employeeId, int leaveRequestId, DeclineLeaveRequest decline);
        Task<HourLeaveRequestResponseModel> DeclineLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, DeclineLeaveRequest decline, CancellationToken cancellationToken = default);
        HourLeaveEstimateModel EstimateLeaveHours(int businessId, int employeeId, EstimateLeaveHoursQueryModel request);
        Task<HourLeaveEstimateModel> EstimateLeaveHoursAsync(int businessId, int employeeId, EstimateLeaveHoursQueryModel request, CancellationToken cancellationToken = default);
        List<HourLeaveRequestResponseModel> ListLeaveRequests(int businessId);
        Task<List<HourLeaveRequestResponseModel>> ListLeaveRequestsAsync(int businessId, CancellationToken cancellationToken = default);
        List<HourLeaveRequestResponseModel> ListLeaveRequests(int businessId, ListLeaveRequestsQueryModel request);
        Task<List<HourLeaveRequestResponseModel>> ListLeaveRequestsAsync(int businessId, ListLeaveRequestsQueryModel request, CancellationToken cancellationToken = default);
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
        public List<HourLeaveRequestResponseModel> GetLeaveRequestsForEmployee(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<HourLeaveRequestResponseModel>>($"/business/{businessId}/employee/{employeeId}/leaverequest{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// Get Leave Requests for Employee
        /// </summary>
        /// <remarks>
        /// Returns all leave requests for this employee, optionally filtered by OData parameters.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<HourLeaveRequestResponseModel>> GetLeaveRequestsForEmployeeAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<HourLeaveRequestResponseModel>>($"/business/{businessId}/employee/{employeeId}/leaverequest{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public void UpdateLeaveRequest(int businessId, int employeeId, HourLeaveRequestModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/leaverequest", model, Method.Put);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public Task UpdateLeaveRequestAsync(int businessId, int employeeId, HourLeaveRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/leaverequest", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request for an employee.
        /// </remarks>
        public HourLeaveRequestResponseModel CreateLeaveRequest(int businessId, int employeeId, HourLeaveRequestModel model)
        {
            return ApiRequest<HourLeaveRequestResponseModel,HourLeaveRequestModel>($"/business/{businessId}/employee/{employeeId}/leaverequest", model, Method.Post);
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request for an employee.
        /// </remarks>
        public Task<HourLeaveRequestResponseModel> CreateLeaveRequestAsync(int businessId, int employeeId, HourLeaveRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<HourLeaveRequestResponseModel,HourLeaveRequestModel>($"/business/{businessId}/employee/{employeeId}/leaverequest", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public HourLeaveRequestResponseModel GetLeaveRequestById(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<HourLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.Get);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public Task<HourLeaveRequestResponseModel> GetLeaveRequestByIdAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<HourLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public void UpdateLeaveRequest(int businessId, int employeeId, int leaveRequestId, HourLeaveRequestModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", model, Method.Put);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public Task UpdateLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, HourLeaveRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public HourLeaveRequestResponseModel DeleteLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<HourLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.Delete);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public Task<HourLeaveRequestResponseModel> DeleteLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<HourLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Approve Leave Request
        /// </summary>
        /// <remarks>
        /// Approves the leave request with the specified ID.
        /// </remarks>
        public HourLeaveRequestResponseModel ApproveLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<HourLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.Post);
        }

        /// <summary>
        /// Approve Leave Request
        /// </summary>
        /// <remarks>
        /// Approves the leave request with the specified ID.
        /// </remarks>
        public Task<HourLeaveRequestResponseModel> ApproveLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<HourLeaveRequestResponseModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Decline Leave Request
        /// </summary>
        /// <remarks>
        /// Declines the leave request with the specified ID.
        /// </remarks>
        public HourLeaveRequestResponseModel DeclineLeaveRequest(int businessId, int employeeId, int leaveRequestId, DeclineLeaveRequest decline)
        {
            return ApiRequest<HourLeaveRequestResponseModel,DeclineLeaveRequest>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/decline", decline, Method.Post);
        }

        /// <summary>
        /// Decline Leave Request
        /// </summary>
        /// <remarks>
        /// Declines the leave request with the specified ID.
        /// </remarks>
        public Task<HourLeaveRequestResponseModel> DeclineLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, DeclineLeaveRequest decline, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<HourLeaveRequestResponseModel,DeclineLeaveRequest>($"/business/{businessId}/employee/{employeeId}/leaverequest/{leaveRequestId}/decline", decline, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Estimate Leave Hours
        /// </summary>
        /// <remarks>
        /// Estimates the leave hours required for a leave request between fromDate and toDate.
        /// </remarks>
        public HourLeaveEstimateModel EstimateLeaveHours(int businessId, int employeeId, EstimateLeaveHoursQueryModel request)
        {
            return ApiRequest<HourLeaveEstimateModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/estimate?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&leaveCategoryId={request.LeaveCategoryId}", Method.Get);
        }

        /// <summary>
        /// Estimate Leave Hours
        /// </summary>
        /// <remarks>
        /// Estimates the leave hours required for a leave request between fromDate and toDate.
        /// </remarks>
        public Task<HourLeaveEstimateModel> EstimateLeaveHoursAsync(int businessId, int employeeId, EstimateLeaveHoursQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<HourLeaveEstimateModel>($"/business/{businessId}/employee/{employeeId}/leaverequest/estimate?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&leaveCategoryId={request.LeaveCategoryId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for the business.
        /// </remarks>
        public List<HourLeaveRequestResponseModel> ListLeaveRequests(int businessId)
        {
            return ApiRequest<List<HourLeaveRequestResponseModel>>($"/business/{businessId}/leaverequest", Method.Get);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for the business.
        /// </remarks>
        public Task<List<HourLeaveRequestResponseModel>> ListLeaveRequestsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<HourLeaveRequestResponseModel>>($"/business/{businessId}/leaverequest", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for the business.
        /// </remarks>
        public List<HourLeaveRequestResponseModel> ListLeaveRequests(int businessId, ListLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<HourLeaveRequestResponseModel>>($"/business/{businessId}/leaverequest?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&leaveCategoryId={request.LeaveCategoryId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&groupBy={request.GroupBy}&restrictOverlappingLeave={request.RestrictOverlappingLeave}", Method.Get);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for the business.
        /// </remarks>
        public Task<List<HourLeaveRequestResponseModel>> ListLeaveRequestsAsync(int businessId, ListLeaveRequestsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<HourLeaveRequestResponseModel>>($"/business/{businessId}/leaverequest?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&leaveCategoryId={request.LeaveCategoryId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&groupBy={request.GroupBy}&restrictOverlappingLeave={request.RestrictOverlappingLeave}", Method.Get, cancellationToken);
        }
    }
}
