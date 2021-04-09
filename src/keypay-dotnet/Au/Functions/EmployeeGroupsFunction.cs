using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.EmployeeGroups;

namespace KeyPayV2.Au.Functions
{
    public class EmployeeGroupsFunction : BaseFunction
    {
        public EmployeeGroupsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Employee Groups
        /// </summary>
        /// <remarks>
        /// Lists all the employee groups for the business.
        /// This operation supports OData queries.
        /// </remarks>
        public List<AuEmployeeGroupModel> ListEmployeeGroups(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<AuEmployeeGroupModel>>($"/business/{businessId}/employeegroup{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Employee Group
        /// </summary>
        /// <remarks>
        /// Creates a new employee group for the business.
        /// </remarks>
        public AuEmployeeGroupModel CreateEmployeeGroup(int businessId, AuEmployeeGroupModel employeeGroup)
        {
            return ApiRequest<AuEmployeeGroupModel,AuEmployeeGroupModel>($"/business/{businessId}/employeegroup", employeeGroup, Method.POST);
        }

        /// <summary>
        /// Get Employee Group by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee group with the specified ID.
        /// </remarks>
        public AuDetailedEmployeeGroupModel GetEmployeeGroupById(int businessId, int id)
        {
            return ApiRequest<AuDetailedEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}");
        }

        /// <summary>
        /// Update Employee Group
        /// </summary>
        /// <remarks>
        /// Updates the specified employee group.
        /// </remarks>
        public AuEmployeeGroupModel UpdateEmployeeGroup(int businessId, int id, AuEmployeeGroupModel employeeGroup)
        {
            return ApiRequest<AuEmployeeGroupModel,AuEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", employeeGroup, Method.PUT);
        }

        /// <summary>
        /// Delete Employee Group
        /// </summary>
        /// <remarks>
        /// Deletes the employee group with the specified ID.
        /// </remarks>
        public void DeleteEmployeeGroup(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/employeegroup/{id}", Method.DELETE);
        }
    }
}
