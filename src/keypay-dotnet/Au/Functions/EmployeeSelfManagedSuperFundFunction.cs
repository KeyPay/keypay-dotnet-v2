using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;

namespace KeyPayV2.Au.Functions
{
    public class EmployeeSelfManagedSuperFundFunction : BaseFunction
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
            return ApiRequest<List<SelfManagedSuperFundModel>>($"/business/{businessId}/employee/{employeeId}/selfmanagedsuperfund{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Employee Self Managed Super Fund
        /// </summary>
        /// <remarks>
        /// Creates a new self managed super fund for the employee.
        /// </remarks>
        public void CreateEmployeeSelfManagedSuperFund(int businessId, int employeeId, SelfManagedSuperFundModel fund)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/selfmanagedsuperfund", fund, Method.POST);
        }

        /// <summary>
        /// Get Employee Self Managed Super Fund by id
        /// </summary>
        /// <remarks>
        /// Gets the Self Managed Super Fund by the specified id.
        /// </remarks>
        public SelfManagedSuperFundModel GetEmployeeSelfManagedSuperFundById(int businessId, int employeeId, int id)
        {
            return ApiRequest<SelfManagedSuperFundModel>($"/business/{businessId}/employee/{employeeId}/selfmanagedsuperfund/{id}");
        }

        /// <summary>
        /// Update Employee Self Managed Super Fund
        /// </summary>
        /// <remarks>
        /// Updates the Self Managed Super Fund with the specified ID.
        /// </remarks>
        public void UpdateEmployeeSelfManagedSuperFund(int businessId, int employeeId, int id, SelfManagedSuperFundModel fund)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/selfmanagedsuperfund/{id}", fund, Method.PUT);
        }
    }
}
