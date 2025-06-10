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
using KeyPayV2.Uk.Models.EmployeeAccess;

namespace KeyPayV2.Uk.Functions
{
    public interface IEmployeeAccessFunction
    {
        List<EmployeeAccessModel> GetUsersWithAccessToEmployee(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<EmployeeAccessModel>> GetUsersWithAccessToEmployeeAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void UpdateEmployeeAccessRecord(int businessId, int employeeId, AccessModel viewModel, UpdateEmployeeAccessRecordQueryModel request);
        Task UpdateEmployeeAccessRecordAsync(int businessId, int employeeId, AccessModel viewModel, UpdateEmployeeAccessRecordQueryModel request, CancellationToken cancellationToken = default);
        void GrantEmployeeAccess(int businessId, int employeeId, CreateEmployeeAccessModel viewModel);
        Task GrantEmployeeAccessAsync(int businessId, int employeeId, CreateEmployeeAccessModel viewModel, CancellationToken cancellationToken = default);
        void RevokeEmployeeAccess(int businessId, int employeeId, RevokeEmployeeAccessQueryModel request);
        Task RevokeEmployeeAccessAsync(int businessId, int employeeId, RevokeEmployeeAccessQueryModel request, CancellationToken cancellationToken = default);
        EmployeeAccessModel GetEmployeeAccessForUser(int businessId, int employeeId, GetEmployeeAccessForUserQueryModel request);
        Task<EmployeeAccessModel> GetEmployeeAccessForUserAsync(int businessId, int employeeId, GetEmployeeAccessForUserQueryModel request, CancellationToken cancellationToken = default);
    }
    public class EmployeeAccessFunction : BaseFunction, IEmployeeAccessFunction
    {
        public EmployeeAccessFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Users With Access to Employee
        /// </summary>
        /// <remarks>
        /// Gets a list of all users with access to this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public List<EmployeeAccessModel> GetUsersWithAccessToEmployee(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<EmployeeAccessModel>>($"/business/{businessId}/employee/{employeeId}/access{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// Get Users With Access to Employee
        /// </summary>
        /// <remarks>
        /// Gets a list of all users with access to this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<EmployeeAccessModel>> GetUsersWithAccessToEmployeeAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeAccessModel>>($"/business/{businessId}/employee/{employeeId}/access{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Access Record
        /// </summary>
        /// <remarks>
        /// Updates the employee access record for the specified user.
        /// </remarks>
        public void UpdateEmployeeAccessRecord(int businessId, int employeeId, AccessModel viewModel, UpdateEmployeeAccessRecordQueryModel request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/access?email={request.Email}", viewModel, Method.Put);
        }

        /// <summary>
        /// Update Employee Access Record
        /// </summary>
        /// <remarks>
        /// Updates the employee access record for the specified user.
        /// </remarks>
        public Task UpdateEmployeeAccessRecordAsync(int businessId, int employeeId, AccessModel viewModel, UpdateEmployeeAccessRecordQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/access?email={request.Email}", viewModel, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Grant Employee Access
        /// </summary>
        /// <remarks>
        /// Grants a user access to the employee.
        /// </remarks>
        public void GrantEmployeeAccess(int businessId, int employeeId, CreateEmployeeAccessModel viewModel)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/access", viewModel, Method.Post);
        }

        /// <summary>
        /// Grant Employee Access
        /// </summary>
        /// <remarks>
        /// Grants a user access to the employee.
        /// </remarks>
        public Task GrantEmployeeAccessAsync(int businessId, int employeeId, CreateEmployeeAccessModel viewModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/access", viewModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Revoke Employee Access
        /// </summary>
        /// <remarks>
        /// Revoke a user's access to the employee.
        /// </remarks>
        public void RevokeEmployeeAccess(int businessId, int employeeId, RevokeEmployeeAccessQueryModel request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/access?email={request.Email}", Method.Delete);
        }

        /// <summary>
        /// Revoke Employee Access
        /// </summary>
        /// <remarks>
        /// Revoke a user's access to the employee.
        /// </remarks>
        public Task RevokeEmployeeAccessAsync(int businessId, int employeeId, RevokeEmployeeAccessQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/access?email={request.Email}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Employee Access for User
        /// </summary>
        /// <remarks>
        /// Gets a list of all employees to which the user (specified by email) has access.
        /// </remarks>
        public EmployeeAccessModel GetEmployeeAccessForUser(int businessId, int employeeId, GetEmployeeAccessForUserQueryModel request)
        {
            return ApiRequest<EmployeeAccessModel>($"/business/{businessId}/employee/{employeeId}/access/email?email={request.Email}", Method.Get);
        }

        /// <summary>
        /// Get Employee Access for User
        /// </summary>
        /// <remarks>
        /// Gets a list of all employees to which the user (specified by email) has access.
        /// </remarks>
        public Task<EmployeeAccessModel> GetEmployeeAccessForUserAsync(int businessId, int employeeId, GetEmployeeAccessForUserQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeAccessModel>($"/business/{businessId}/employee/{employeeId}/access/email?email={request.Email}", Method.Get, cancellationToken);
        }
    }
}
