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
using KeyPayV2.Au.Models.Employee;

namespace KeyPayV2.Au.Functions
{
    public interface IEmployeeFunction
    {
        AuOpeningBalancesModel GetOpeningBalances(int businessId, int employeeId);
        Task<AuOpeningBalancesModel> GetOpeningBalancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void SetOpeningBalances(int businessId, int employeeId, AuOpeningBalancesModel model);
        Task SetOpeningBalancesAsync(int businessId, int employeeId, AuOpeningBalancesModel model, CancellationToken cancellationToken = default);
    }
    public class EmployeeFunction : BaseFunction, IEmployeeFunction
    {
        public EmployeeFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Opening Balances
        /// </summary>
        /// <remarks>
        /// Gets the opening balances for this employee.
        /// </remarks>
        public AuOpeningBalancesModel GetOpeningBalances(int businessId, int employeeId)
        {
            return ApiRequest<AuOpeningBalancesModel>($"/business/{businessId}/employee/{employeeId}/openingbalances", Method.Get);
        }

        /// <summary>
        /// Get Opening Balances
        /// </summary>
        /// <remarks>
        /// Gets the opening balances for this employee.
        /// </remarks>
        public Task<AuOpeningBalancesModel> GetOpeningBalancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuOpeningBalancesModel>($"/business/{businessId}/employee/{employeeId}/openingbalances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Opening Balances
        /// </summary>
        /// <remarks>
        /// Sets the opening balances for this employee.
        /// </remarks>
        public void SetOpeningBalances(int businessId, int employeeId, AuOpeningBalancesModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/openingbalances", model, Method.Post);
        }

        /// <summary>
        /// Set Opening Balances
        /// </summary>
        /// <remarks>
        /// Sets the opening balances for this employee.
        /// </remarks>
        public Task SetOpeningBalancesAsync(int businessId, int employeeId, AuOpeningBalancesModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/openingbalances", model, Method.Post, cancellationToken);
        }
    }
}
