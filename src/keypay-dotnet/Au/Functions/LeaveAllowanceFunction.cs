using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.LeaveAllowance;

namespace KeyPayV2.Au.Functions
{
    public class LeaveAllowanceFunction : BaseFunction
    {
        public LeaveAllowanceFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Leave Allowances for All Employees
        /// </summary>
        /// <remarks>
        /// Gets the leave allowances for all employees in the business
        /// </remarks>
        public Dictionary<string, IList<AuLeaveAllowanceModel>> GetLeaveAllowancesForAllEmployees(int businessId)
        {
            return ApiRequest<Dictionary<string, IList<AuLeaveAllowanceModel>>>($"/business/{businessId}/leaveallowances");
        }

        /// <summary>
        /// Set Leave Allowances
        /// </summary>
        /// <remarks>
        /// Sets the leave allowances for the specified employees (dictionary keyed by employee ID).
        /// </remarks>
        public AuLeaveAllowanceModel SetLeaveAllowances(int businessId, AuLeaveAllowancesRequest request)
        {
            return ApiRequest<AuLeaveAllowanceModel,AuLeaveAllowancesRequest>($"/business/{businessId}/leaveallowances", request, Method.PUT);
        }

        /// <summary>
        /// Get Leave Allowances for Employee
        /// </summary>
        /// <remarks>
        /// Get leave Allowances for a single employee
        /// </remarks>
        public Dictionary<string, IList<AuLeaveAllowanceModel>> GetLeaveAllowancesForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<Dictionary<string, IList<AuLeaveAllowanceModel>>>($"/business/{businessId}/leaveallowances/{employeeId}");
        }

        /// <summary>
        /// List Leave Allowance Templates
        /// </summary>
        /// <remarks>
        /// Lists all the leave allowance templates for this business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<AuLeaveAllowanceTemplateModel> ListLeaveAllowanceTemplates(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<AuLeaveAllowanceTemplateModel>>($"/business/{businessId}/leaveallowancetemplate{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Creates a new leave allowance template for the business.
        /// </remarks>
        public AuLeaveAllowanceTemplateModel CreateLeaveAllowanceTemplate(int businessId, AuLeaveAllowanceTemplateModel leaveAllowanceTemplate)
        {
            return ApiRequest<AuLeaveAllowanceTemplateModel,AuLeaveAllowanceTemplateModel>($"/business/{businessId}/leaveallowancetemplate", leaveAllowanceTemplate, Method.POST);
        }

        /// <summary>
        /// Get Leave Allowance Template by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the leave allowance template with the specified ID.
        /// </remarks>
        public AuLeaveAllowanceTemplateModel GetLeaveAllowanceTemplateById(int businessId, int id)
        {
            return ApiRequest<AuLeaveAllowanceTemplateModel>($"/business/{businessId}/leaveallowancetemplate/{id}");
        }

        /// <summary>
        /// Update Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Updates the leave allowance template with the specified ID.
        /// </remarks>
        public AuLeaveAllowanceTemplateModel UpdateLeaveAllowanceTemplate(int businessId, int id, AuLeaveAllowanceTemplateModel leaveAllowanceTemplate)
        {
            return ApiRequest<AuLeaveAllowanceTemplateModel,AuLeaveAllowanceTemplateModel>($"/business/{businessId}/leaveallowancetemplate/{id}", leaveAllowanceTemplate, Method.PUT);
        }

        /// <summary>
        /// Delete Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Deletes the leave allowance template with the specified ID.
        /// </remarks>
        public void DeleteLeaveAllowanceTemplate(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/leaveallowancetemplate/{id}", Method.DELETE);
        }

        /// <summary>
        /// Reapply Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Reapply the leave allowance template with the specified ID.
        /// </remarks>
        public void ReapplyLeaveAllowanceTemplate(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/leaveallowancetemplate/reapply/{id}", Method.POST);
        }
    }
}
