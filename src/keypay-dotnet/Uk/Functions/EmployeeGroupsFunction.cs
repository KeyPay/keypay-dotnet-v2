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
using KeyPayV2.Uk.Models.EmployeeGroups;

namespace KeyPayV2.Uk.Functions
{
    public interface IEmployeeGroupsFunction
    {
        List<UkEmployeeGroupModel> ListEmployeeGroups(int businessId, ODataQuery oDataQuery = null);
        Task<List<UkEmployeeGroupModel>> ListEmployeeGroupsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        UkEmployeeGroupModel CreateEmployeeGroup(int businessId, UkEmployeeGroupModel employeeGroup);
        Task<UkEmployeeGroupModel> CreateEmployeeGroupAsync(int businessId, UkEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default);
        UkDetailedEmployeeGroupModel GetEmployeeGroupById(int businessId, int id);
        Task<UkDetailedEmployeeGroupModel> GetEmployeeGroupByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        UkEmployeeGroupModel UpdateEmployeeGroup(int businessId, int id, UkEmployeeGroupModel employeeGroup);
        Task<UkEmployeeGroupModel> UpdateEmployeeGroupAsync(int businessId, int id, UkEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default);
        void DeleteEmployeeGroup(int businessId, int id);
        Task DeleteEmployeeGroupAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class EmployeeGroupsFunction : BaseFunction, IEmployeeGroupsFunction
    {
        public EmployeeGroupsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Employee Groups
        /// </summary>
        /// <remarks>
        /// Lists all the employee groups for the business.
        /// This operation supports OData queries.
        /// </remarks>
        public List<UkEmployeeGroupModel> ListEmployeeGroups(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkEmployeeGroupModel>>($"/business/{businessId}/employeegroup{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employee Groups
        /// </summary>
        /// <remarks>
        /// Lists all the employee groups for the business.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<UkEmployeeGroupModel>> ListEmployeeGroupsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkEmployeeGroupModel>>($"/business/{businessId}/employeegroup{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Group
        /// </summary>
        /// <remarks>
        /// Creates a new employee group for the business.
        /// </remarks>
        public UkEmployeeGroupModel CreateEmployeeGroup(int businessId, UkEmployeeGroupModel employeeGroup)
        {
            return ApiRequest<UkEmployeeGroupModel,UkEmployeeGroupModel>($"/business/{businessId}/employeegroup", employeeGroup, Method.Post);
        }

        /// <summary>
        /// Create Employee Group
        /// </summary>
        /// <remarks>
        /// Creates a new employee group for the business.
        /// </remarks>
        public Task<UkEmployeeGroupModel> CreateEmployeeGroupAsync(int businessId, UkEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEmployeeGroupModel,UkEmployeeGroupModel>($"/business/{businessId}/employeegroup", employeeGroup, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Group by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee group with the specified ID.
        /// </remarks>
        public UkDetailedEmployeeGroupModel GetEmployeeGroupById(int businessId, int id)
        {
            return ApiRequest<UkDetailedEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Group by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee group with the specified ID.
        /// </remarks>
        public Task<UkDetailedEmployeeGroupModel> GetEmployeeGroupByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkDetailedEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Group
        /// </summary>
        /// <remarks>
        /// Updates the specified employee group.
        /// </remarks>
        public UkEmployeeGroupModel UpdateEmployeeGroup(int businessId, int id, UkEmployeeGroupModel employeeGroup)
        {
            return ApiRequest<UkEmployeeGroupModel,UkEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", employeeGroup, Method.Put);
        }

        /// <summary>
        /// Update Employee Group
        /// </summary>
        /// <remarks>
        /// Updates the specified employee group.
        /// </remarks>
        public Task<UkEmployeeGroupModel> UpdateEmployeeGroupAsync(int businessId, int id, UkEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEmployeeGroupModel,UkEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", employeeGroup, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Group
        /// </summary>
        /// <remarks>
        /// Deletes the employee group with the specified ID.
        /// </remarks>
        public void DeleteEmployeeGroup(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/employeegroup/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Group
        /// </summary>
        /// <remarks>
        /// Deletes the employee group with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeGroupAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employeegroup/{id}", Method.Delete, cancellationToken);
        }
    }
}
