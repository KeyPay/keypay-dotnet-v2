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
    public class EmployeeLeaveAllowancesFunction : BaseFunction
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
            return ApiRequest<List<AuLeaveAllowanceModel>>($"/business/{businessId}/employee/{employeeId}/leaveallowances");
        }

        /// <summary>
        /// Set Leave Allowances
        /// </summary>
        /// <remarks>
        /// Sets the leave allowances for the specified employee
        /// </remarks>
        public void SetLeaveAllowances(int businessId, int employeeId, IList<AuLeaveAllowanceModel> leaveAllowances)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/leaveallowances", leaveAllowances, Method.PUT);
        }
    }
}
