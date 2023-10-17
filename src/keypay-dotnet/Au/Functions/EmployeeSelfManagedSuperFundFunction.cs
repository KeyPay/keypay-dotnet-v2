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

namespace KeyPayV2.Au.Functions
{
    public interface IEmployeeSelfManagedSuperFundFunction
    {
        List<SelfManagedSuperFundModel> ListSelfManagedSuperFunds(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<SelfManagedSuperFundModel>> ListSelfManagedSuperFundsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void CreateEmployeeSelfManagedSuperFund(int businessId, int employeeId, SelfManagedSuperFundModel fund);
        Task CreateEmployeeSelfManagedSuperFundAsync(int businessId, int employeeId, SelfManagedSuperFundModel fund, CancellationToken cancellationToken = default);
        SelfManagedSuperFundModel GetEmployeeSelfManagedSuperFundById(int businessId, int employeeId, int id);
        Task<SelfManagedSuperFundModel> GetEmployeeSelfManagedSuperFundByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        void UpdateEmployeeSelfManagedSuperFund(int businessId, int employeeId, int id, SelfManagedSuperFundModel fund);
        Task UpdateEmployeeSelfManagedSuperFundAsync(int businessId, int employeeId, int id, SelfManagedSuperFundModel fund, CancellationToken cancellationToken = default);
    }
    public class EmployeeSelfManagedSuperFundFunction : BaseFunction, IEmployeeSelfManagedSuperFundFunction
    {
        public EmployeeSelfManagedSuperFundFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Self Managed Super Funds
        /// </summary>
        /// <remarks>
        /// Lists all the self managed super funds for the employee.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<SelfManagedSuperFundModel> ListSelfManagedSuperFunds(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<SelfManagedSuperFundModel>>($"/business/{businessId}/employee/{employeeId}/selfmanagedsuperfund{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Self Managed Super Funds
        /// </summary>
        /// <remarks>
        /// Lists all the self managed super funds for the employee.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<SelfManagedSuperFundModel>> ListSelfManagedSuperFundsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SelfManagedSuperFundModel>>($"/business/{businessId}/employee/{employeeId}/selfmanagedsuperfund{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Self Managed Super Fund
        /// </summary>
        /// <remarks>
        /// Create a new self managed super fund for the employee. 
        /// To update existing self managed super funds, please use the PUT method.
        /// </remarks>
        public void CreateEmployeeSelfManagedSuperFund(int businessId, int employeeId, SelfManagedSuperFundModel fund)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/selfmanagedsuperfund", fund, Method.Post);
        }

        /// <summary>
        /// Create Employee Self Managed Super Fund
        /// </summary>
        /// <remarks>
        /// Create a new self managed super fund for the employee. 
        /// To update existing self managed super funds, please use the PUT method.
        /// </remarks>
        public Task CreateEmployeeSelfManagedSuperFundAsync(int businessId, int employeeId, SelfManagedSuperFundModel fund, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/selfmanagedsuperfund", fund, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Self Managed Super Fund by id
        /// </summary>
        /// <remarks>
        /// Gets the Self Managed Super Fund by the specified id.
        /// </remarks>
        public SelfManagedSuperFundModel GetEmployeeSelfManagedSuperFundById(int businessId, int employeeId, int id)
        {
            return ApiRequest<SelfManagedSuperFundModel>($"/business/{businessId}/employee/{employeeId}/selfmanagedsuperfund/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Self Managed Super Fund by id
        /// </summary>
        /// <remarks>
        /// Gets the Self Managed Super Fund by the specified id.
        /// </remarks>
        public Task<SelfManagedSuperFundModel> GetEmployeeSelfManagedSuperFundByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SelfManagedSuperFundModel>($"/business/{businessId}/employee/{employeeId}/selfmanagedsuperfund/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Self Managed Super Fund
        /// </summary>
        /// <remarks>
        /// Updates the Self Managed Super Fund with the specified ID.
        /// </remarks>
        public void UpdateEmployeeSelfManagedSuperFund(int businessId, int employeeId, int id, SelfManagedSuperFundModel fund)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/selfmanagedsuperfund/{id}", fund, Method.Put);
        }

        /// <summary>
        /// Update Employee Self Managed Super Fund
        /// </summary>
        /// <remarks>
        /// Updates the Self Managed Super Fund with the specified ID.
        /// </remarks>
        public Task UpdateEmployeeSelfManagedSuperFundAsync(int businessId, int employeeId, int id, SelfManagedSuperFundModel fund, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/selfmanagedsuperfund/{id}", fund, Method.Put, cancellationToken);
        }
    }
}
