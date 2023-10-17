using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.EmployeeGroups;

namespace KeyPayV2.My.Functions
{
    public interface IEmployeeGroupsFunction
    {
        List<MyEmployeeGroupModel> ListEmployeeGroups(int businessId, ODataQuery oDataQuery = null);
        Task<List<MyEmployeeGroupModel>> ListEmployeeGroupsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        MyEmployeeGroupModel CreateEmployeeGroup(int businessId, MyEmployeeGroupModel employeeGroup);
        Task<MyEmployeeGroupModel> CreateEmployeeGroupAsync(int businessId, MyEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default);
        MyDetailedEmployeeGroupModel GetEmployeeGroupById(int businessId, int id);
        Task<MyDetailedEmployeeGroupModel> GetEmployeeGroupByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        MyEmployeeGroupModel UpdateEmployeeGroup(int businessId, int id, MyEmployeeGroupModel employeeGroup);
        Task<MyEmployeeGroupModel> UpdateEmployeeGroupAsync(int businessId, int id, MyEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default);
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
        public List<MyEmployeeGroupModel> ListEmployeeGroups(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<MyEmployeeGroupModel>>($"/business/{businessId}/employeegroup{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employee Groups
        /// </summary>
        /// <remarks>
        /// Lists all the employee groups for the business.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<MyEmployeeGroupModel>> ListEmployeeGroupsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyEmployeeGroupModel>>($"/business/{businessId}/employeegroup{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Group
        /// </summary>
        /// <remarks>
        /// Creates a new employee group for the business.
        /// </remarks>
        public MyEmployeeGroupModel CreateEmployeeGroup(int businessId, MyEmployeeGroupModel employeeGroup)
        {
            return ApiRequest<MyEmployeeGroupModel,MyEmployeeGroupModel>($"/business/{businessId}/employeegroup", employeeGroup, Method.Post);
        }

        /// <summary>
        /// Create Employee Group
        /// </summary>
        /// <remarks>
        /// Creates a new employee group for the business.
        /// </remarks>
        public Task<MyEmployeeGroupModel> CreateEmployeeGroupAsync(int businessId, MyEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEmployeeGroupModel,MyEmployeeGroupModel>($"/business/{businessId}/employeegroup", employeeGroup, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Group by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee group with the specified ID.
        /// </remarks>
        public MyDetailedEmployeeGroupModel GetEmployeeGroupById(int businessId, int id)
        {
            return ApiRequest<MyDetailedEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Group by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee group with the specified ID.
        /// </remarks>
        public Task<MyDetailedEmployeeGroupModel> GetEmployeeGroupByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyDetailedEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Group
        /// </summary>
        /// <remarks>
        /// Updates the specified employee group.
        /// </remarks>
        public MyEmployeeGroupModel UpdateEmployeeGroup(int businessId, int id, MyEmployeeGroupModel employeeGroup)
        {
            return ApiRequest<MyEmployeeGroupModel,MyEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", employeeGroup, Method.Put);
        }

        /// <summary>
        /// Update Employee Group
        /// </summary>
        /// <remarks>
        /// Updates the specified employee group.
        /// </remarks>
        public Task<MyEmployeeGroupModel> UpdateEmployeeGroupAsync(int businessId, int id, MyEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEmployeeGroupModel,MyEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", employeeGroup, Method.Put, cancellationToken);
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
