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

namespace KeyPayV2.Sg.Functions
{
    public interface IEmployeeLeaveAllowancesFunction
    {
        List<SgLeaveAllowanceModel> GetLeaveAllowances(int businessId, int employeeId);
        Task<List<SgLeaveAllowanceModel>> GetLeaveAllowancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void SetLeaveAllowances(int businessId, int employeeId, IList<SgLeaveAllowanceModel> leaveAllowances);
        Task SetLeaveAllowancesAsync(int businessId, int employeeId, IList<SgLeaveAllowanceModel> leaveAllowances, CancellationToken cancellationToken = default);
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
        public List<SgLeaveAllowanceModel> GetLeaveAllowances(int businessId, int employeeId)
        {
            return ApiRequest<List<SgLeaveAllowanceModel>>($"/business/{businessId}/employee/{employeeId}/leaveallowances", Method.Get);
        }

        /// <summary>
        /// Get Leave Allowances
        /// </summary>
        /// <remarks>
        /// Gets the leave allowances for the specified employee
        /// </remarks>
        public Task<List<SgLeaveAllowanceModel>> GetLeaveAllowancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgLeaveAllowanceModel>>($"/business/{businessId}/employee/{employeeId}/leaveallowances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Leave Allowances
        /// </summary>
        /// <remarks>
        /// Sets the leave allowances for the specified employee
        /// </remarks>
        public void SetLeaveAllowances(int businessId, int employeeId, IList<SgLeaveAllowanceModel> leaveAllowances)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/leaveallowances", leaveAllowances, Method.Put);
        }

        /// <summary>
        /// Set Leave Allowances
        /// </summary>
        /// <remarks>
        /// Sets the leave allowances for the specified employee
        /// </remarks>
        public Task SetLeaveAllowancesAsync(int businessId, int employeeId, IList<SgLeaveAllowanceModel> leaveAllowances, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/leaveallowances", leaveAllowances, Method.Put, cancellationToken);
        }
    }
}
