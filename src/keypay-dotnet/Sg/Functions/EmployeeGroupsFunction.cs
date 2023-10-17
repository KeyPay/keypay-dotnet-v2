using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.EmployeeGroups;

namespace KeyPayV2.Sg.Functions
{
    public interface IEmployeeGroupsFunction
    {
        List<SgEmployeeGroupModel> ListEmployeeGroups(int businessId, ODataQuery oDataQuery = null);
        Task<List<SgEmployeeGroupModel>> ListEmployeeGroupsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        SgEmployeeGroupModel CreateEmployeeGroup(int businessId, SgEmployeeGroupModel employeeGroup);
        Task<SgEmployeeGroupModel> CreateEmployeeGroupAsync(int businessId, SgEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default);
        SgDetailedEmployeeGroupModel GetEmployeeGroupById(int businessId, int id);
        Task<SgDetailedEmployeeGroupModel> GetEmployeeGroupByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        SgEmployeeGroupModel UpdateEmployeeGroup(int businessId, int id, SgEmployeeGroupModel employeeGroup);
        Task<SgEmployeeGroupModel> UpdateEmployeeGroupAsync(int businessId, int id, SgEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default);
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
        public List<SgEmployeeGroupModel> ListEmployeeGroups(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<SgEmployeeGroupModel>>($"/business/{businessId}/employeegroup{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employee Groups
        /// </summary>
        /// <remarks>
        /// Lists all the employee groups for the business.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<SgEmployeeGroupModel>> ListEmployeeGroupsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgEmployeeGroupModel>>($"/business/{businessId}/employeegroup{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Group
        /// </summary>
        /// <remarks>
        /// Creates a new employee group for the business.
        /// </remarks>
        public SgEmployeeGroupModel CreateEmployeeGroup(int businessId, SgEmployeeGroupModel employeeGroup)
        {
            return ApiRequest<SgEmployeeGroupModel,SgEmployeeGroupModel>($"/business/{businessId}/employeegroup", employeeGroup, Method.Post);
        }

        /// <summary>
        /// Create Employee Group
        /// </summary>
        /// <remarks>
        /// Creates a new employee group for the business.
        /// </remarks>
        public Task<SgEmployeeGroupModel> CreateEmployeeGroupAsync(int businessId, SgEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgEmployeeGroupModel,SgEmployeeGroupModel>($"/business/{businessId}/employeegroup", employeeGroup, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Group by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee group with the specified ID.
        /// </remarks>
        public SgDetailedEmployeeGroupModel GetEmployeeGroupById(int businessId, int id)
        {
            return ApiRequest<SgDetailedEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Group by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee group with the specified ID.
        /// </remarks>
        public Task<SgDetailedEmployeeGroupModel> GetEmployeeGroupByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgDetailedEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Group
        /// </summary>
        /// <remarks>
        /// Updates the specified employee group.
        /// </remarks>
        public SgEmployeeGroupModel UpdateEmployeeGroup(int businessId, int id, SgEmployeeGroupModel employeeGroup)
        {
            return ApiRequest<SgEmployeeGroupModel,SgEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", employeeGroup, Method.Put);
        }

        /// <summary>
        /// Update Employee Group
        /// </summary>
        /// <remarks>
        /// Updates the specified employee group.
        /// </remarks>
        public Task<SgEmployeeGroupModel> UpdateEmployeeGroupAsync(int businessId, int id, SgEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgEmployeeGroupModel,SgEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", employeeGroup, Method.Put, cancellationToken);
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
