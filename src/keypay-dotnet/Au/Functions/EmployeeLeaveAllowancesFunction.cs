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
    public interface IEmployeeLeaveAllowancesFunction
    {
        List<AuLeaveAllowanceModel> GetLeaveAllowances(int businessId, int employeeId);
        Task<List<AuLeaveAllowanceModel>> GetLeaveAllowancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void SetLeaveAllowances(int businessId, int employeeId, IList<AuLeaveAllowanceModel> leaveAllowances);
        Task SetLeaveAllowancesAsync(int businessId, int employeeId, IList<AuLeaveAllowanceModel> leaveAllowances, CancellationToken cancellationToken = default);
    }
    public class EmployeeLeaveAllowancesFunction : BaseFunction, IEmployeeLeaveAllowancesFunction
    {
        public EmployeeLeaveAllowancesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Leave Allowances
        /// </summary>
        /// <remarks>
        /// Gets the leave allowances for the specified employee
        /// </remarks>
        public List<AuLeaveAllowanceModel> GetLeaveAllowances(int businessId, int employeeId)
        {
            return ApiRequest<List<AuLeaveAllowanceModel>>($"/business/{businessId}/employee/{employeeId}/leaveallowances", Method.Get);
        }

        /// <summary>
        /// Get Leave Allowances
        /// </summary>
        /// <remarks>
        /// Gets the leave allowances for the specified employee
        /// </remarks>
        public Task<List<AuLeaveAllowanceModel>> GetLeaveAllowancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuLeaveAllowanceModel>>($"/business/{businessId}/employee/{employeeId}/leaveallowances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Leave Allowances
        /// </summary>
        /// <remarks>
        /// Sets the leave allowances for the specified employee
        /// </remarks>
        public void SetLeaveAllowances(int businessId, int employeeId, IList<AuLeaveAllowanceModel> leaveAllowances)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/leaveallowances", leaveAllowances, Method.Put);
        }

        /// <summary>
        /// Set Leave Allowances
        /// </summary>
        /// <remarks>
        /// Sets the leave allowances for the specified employee
        /// </remarks>
        public Task SetLeaveAllowancesAsync(int businessId, int employeeId, IList<AuLeaveAllowanceModel> leaveAllowances, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/leaveallowances", leaveAllowances, Method.Put, cancellationToken);
        }
    }
}
