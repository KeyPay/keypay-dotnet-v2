using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.EmployeeAccess;

namespace KeyPayV2.Nz.Functions
{
    public class EmployeeAccessFunction : BaseFunction
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
            return ApiRequest<List<EmployeeAccessModel>>($"/business/{businessId}/employee/{employeeId}/access{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Update Employee Access Record
        /// </summary>
        /// <remarks>
        /// Updates the employee access record for the specified user.
        /// </remarks>
        public void UpdateEmployeeAccessRecord(int businessId, int employeeId, AccessModel viewModel, UpdateEmployeeAccessRecordQueryModel request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/access?email={request.Email}", viewModel, Method.PUT);
        }

        /// <summary>
        /// Grant Employee Access
        /// </summary>
        /// <remarks>
        /// Grants a user access to the employee.
        /// </remarks>
        public void GrantEmployeeAccess(int businessId, int employeeId, CreateEmployeeAccessModel viewModel)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/access", viewModel, Method.POST);
        }

        /// <summary>
        /// Revoke Employee Access
        /// </summary>
        /// <remarks>
        /// Revoke a user's access to the employee.
        /// </remarks>
        public void RevokeEmployeeAccess(int businessId, int employeeId, RevokeEmployeeAccessQueryModel request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/access?email={request.Email}", Method.DELETE);
        }

        /// <summary>
        /// Get Employee Access for User
        /// </summary>
        /// <remarks>
        /// Gets a list of all employees to which the user (specified by email) has access.
        /// </remarks>
        public EmployeeAccessModel GetEmployeeAccessForUser(int businessId, int employeeId, GetEmployeeAccessForUserQueryModel request)
        {
            return ApiRequest<EmployeeAccessModel>($"/business/{businessId}/employee/{employeeId}/access/email?email={request.Email}");
        }
    }
}
