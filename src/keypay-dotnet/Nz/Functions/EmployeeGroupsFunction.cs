using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.EmployeeGroups;

namespace KeyPayV2.Nz.Functions
{
    public interface IEmployeeGroupsFunction
    {
        List<NzEmployeeGroupModel> ListEmployeeGroups(int businessId);
        Task<List<NzEmployeeGroupModel>> ListEmployeeGroupsAsync(int businessId, CancellationToken cancellationToken = default);
        void CreateEmployeeGroup(int businessId, NzEmployeeGroupModel employeeGroup);
        Task CreateEmployeeGroupAsync(int businessId, NzEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default);
        NzDetailedEmployeeGroupModel GetEmployeeGroupById(int businessId, int id);
        Task<NzDetailedEmployeeGroupModel> GetEmployeeGroupByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void UpdateEmployeeGroup(int businessId, int id, NzEmployeeGroupModel employeeGroup);
        Task UpdateEmployeeGroupAsync(int businessId, int id, NzEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default);
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
        /// </remarks>
        public List<NzEmployeeGroupModel> ListEmployeeGroups(int businessId)
        {
            return ApiRequest<List<NzEmployeeGroupModel>>($"/business/{businessId}/employeegroup", Method.Get);
        }

        /// <summary>
        /// List Employee Groups
        /// </summary>
        /// <remarks>
        /// Lists all the employee groups for the business.
        /// </remarks>
        public Task<List<NzEmployeeGroupModel>> ListEmployeeGroupsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzEmployeeGroupModel>>($"/business/{businessId}/employeegroup", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Group
        /// </summary>
        /// <remarks>
        /// Creates a new employee group for the business.
        /// </remarks>
        public void CreateEmployeeGroup(int businessId, NzEmployeeGroupModel employeeGroup)
        {
            ApiRequest($"/business/{businessId}/employeegroup", employeeGroup, Method.Post);
        }

        /// <summary>
        /// Create Employee Group
        /// </summary>
        /// <remarks>
        /// Creates a new employee group for the business.
        /// </remarks>
        public Task CreateEmployeeGroupAsync(int businessId, NzEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employeegroup", employeeGroup, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Group by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee group with the specified ID.
        /// </remarks>
        public NzDetailedEmployeeGroupModel GetEmployeeGroupById(int businessId, int id)
        {
            return ApiRequest<NzDetailedEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Group by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee group with the specified ID.
        /// </remarks>
        public Task<NzDetailedEmployeeGroupModel> GetEmployeeGroupByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzDetailedEmployeeGroupModel>($"/business/{businessId}/employeegroup/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Group
        /// </summary>
        /// <remarks>
        /// Updates the specified employee group.
        /// </remarks>
        public void UpdateEmployeeGroup(int businessId, int id, NzEmployeeGroupModel employeeGroup)
        {
            ApiRequest($"/business/{businessId}/employeegroup/{id}", employeeGroup, Method.Put);
        }

        /// <summary>
        /// Update Employee Group
        /// </summary>
        /// <remarks>
        /// Updates the specified employee group.
        /// </remarks>
        public Task UpdateEmployeeGroupAsync(int businessId, int id, NzEmployeeGroupModel employeeGroup, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employeegroup/{id}", employeeGroup, Method.Put, cancellationToken);
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
