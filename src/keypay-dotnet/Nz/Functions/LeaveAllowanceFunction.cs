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
using KeyPayV2.Nz.Models.LeaveAllowance;

namespace KeyPayV2.Nz.Functions
{
    public interface ILeaveAllowanceFunction
    {
        NzLeaveAllowanceTemplateModel GetLeaveAllowanceTemplateForEmployee(int businessId, int employeeId);
        Task<NzLeaveAllowanceTemplateModel> GetLeaveAllowanceTemplateForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void AssignLeaveAllowanceTemplate(int businessId, int employeeId, int leaveAllowanceTemplateId);
        Task AssignLeaveAllowanceTemplateAsync(int businessId, int employeeId, int leaveAllowanceTemplateId, CancellationToken cancellationToken = default);
        Dictionary<string, IList<NzLeaveAllowanceModel>> GetLeaveAllowancesForAllEmployees(int businessId);
        Task<Dictionary<string, IList<NzLeaveAllowanceModel>>> GetLeaveAllowancesForAllEmployeesAsync(int businessId, CancellationToken cancellationToken = default);
        NzLeaveAllowanceModel SetLeaveAllowances(int businessId, NzLeaveAllowancesRequest request);
        Task<NzLeaveAllowanceModel> SetLeaveAllowancesAsync(int businessId, NzLeaveAllowancesRequest request, CancellationToken cancellationToken = default);
        Dictionary<string, IList<NzLeaveAllowanceModel>> GetLeaveAllowancesForEmployee(int businessId, int employeeId);
        Task<Dictionary<string, IList<NzLeaveAllowanceModel>>> GetLeaveAllowancesForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<NzLeaveAllowanceTemplateModel> ListLeaveAllowanceTemplates(int businessId, ODataQuery oDataQuery = null);
        Task<List<NzLeaveAllowanceTemplateModel>> ListLeaveAllowanceTemplatesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void CreateLeaveAllowanceTemplate(int businessId, NzLeaveAllowanceTemplateModel leaveAllowanceTemplate);
        Task CreateLeaveAllowanceTemplateAsync(int businessId, NzLeaveAllowanceTemplateModel leaveAllowanceTemplate, CancellationToken cancellationToken = default);
        NzLeaveAllowanceTemplateModel GetLeaveAllowanceTemplateById(int businessId, int id);
        Task<NzLeaveAllowanceTemplateModel> GetLeaveAllowanceTemplateByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void UpdateLeaveAllowanceTemplate(int businessId, int id, NzLeaveAllowanceTemplateModel leaveAllowanceTemplate);
        Task UpdateLeaveAllowanceTemplateAsync(int businessId, int id, NzLeaveAllowanceTemplateModel leaveAllowanceTemplate, CancellationToken cancellationToken = default);
        void DeleteLeaveAllowanceTemplate(int businessId, int id);
        Task DeleteLeaveAllowanceTemplateAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void ReapplyLeaveAllowanceTemplate(int businessId, int id);
        Task ReapplyLeaveAllowanceTemplateAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class LeaveAllowanceFunction : BaseFunction, ILeaveAllowanceFunction
    {
        public LeaveAllowanceFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Leave Allowance Template for Employee
        /// </summary>
        /// <remarks>
        /// Gets the current leave allowance template for the specified employee
        /// </remarks>
        public NzLeaveAllowanceTemplateModel GetLeaveAllowanceTemplateForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<NzLeaveAllowanceTemplateModel>($"/business/{businessId}/employee/{employeeId}/leaveallowancetemplate", Method.Get);
        }

        /// <summary>
        /// Get Leave Allowance Template for Employee
        /// </summary>
        /// <remarks>
        /// Gets the current leave allowance template for the specified employee
        /// </remarks>
        public Task<NzLeaveAllowanceTemplateModel> GetLeaveAllowanceTemplateForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzLeaveAllowanceTemplateModel>($"/business/{businessId}/employee/{employeeId}/leaveallowancetemplate", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Assign Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Assigns employee to existing leave allowance template
        /// </remarks>
        public void AssignLeaveAllowanceTemplate(int businessId, int employeeId, int leaveAllowanceTemplateId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/leaveallowancetemplate/assign/{leaveAllowanceTemplateId}", Method.Post);
        }

        /// <summary>
        /// Assign Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Assigns employee to existing leave allowance template
        /// </remarks>
        public Task AssignLeaveAllowanceTemplateAsync(int businessId, int employeeId, int leaveAllowanceTemplateId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/leaveallowancetemplate/assign/{leaveAllowanceTemplateId}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Allowances for All Employees
        /// </summary>
        /// <remarks>
        /// Gets the leave allowances for all employees in the business
        /// </remarks>
        public Dictionary<string, IList<NzLeaveAllowanceModel>> GetLeaveAllowancesForAllEmployees(int businessId)
        {
            return ApiRequest<Dictionary<string, IList<NzLeaveAllowanceModel>>>($"/business/{businessId}/leaveallowances", Method.Get);
        }

        /// <summary>
        /// Get Leave Allowances for All Employees
        /// </summary>
        /// <remarks>
        /// Gets the leave allowances for all employees in the business
        /// </remarks>
        public Task<Dictionary<string, IList<NzLeaveAllowanceModel>>> GetLeaveAllowancesForAllEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<Dictionary<string, IList<NzLeaveAllowanceModel>>>($"/business/{businessId}/leaveallowances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Leave Allowances
        /// </summary>
        /// <remarks>
        /// Sets the leave allowances for the specified employees (dictionary keyed by employee ID).
        /// </remarks>
        public NzLeaveAllowanceModel SetLeaveAllowances(int businessId, NzLeaveAllowancesRequest request)
        {
            return ApiRequest<NzLeaveAllowanceModel,NzLeaveAllowancesRequest>($"/business/{businessId}/leaveallowances", request, Method.Put);
        }

        /// <summary>
        /// Set Leave Allowances
        /// </summary>
        /// <remarks>
        /// Sets the leave allowances for the specified employees (dictionary keyed by employee ID).
        /// </remarks>
        public Task<NzLeaveAllowanceModel> SetLeaveAllowancesAsync(int businessId, NzLeaveAllowancesRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzLeaveAllowanceModel,NzLeaveAllowancesRequest>($"/business/{businessId}/leaveallowances", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Leave Allowances for Employee
        /// </summary>
        /// <remarks>
        /// Get leave Allowances for a single employee
        /// </remarks>
        public Dictionary<string, IList<NzLeaveAllowanceModel>> GetLeaveAllowancesForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<Dictionary<string, IList<NzLeaveAllowanceModel>>>($"/business/{businessId}/leaveallowances/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Get Leave Allowances for Employee
        /// </summary>
        /// <remarks>
        /// Get leave Allowances for a single employee
        /// </remarks>
        public Task<Dictionary<string, IList<NzLeaveAllowanceModel>>> GetLeaveAllowancesForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<Dictionary<string, IList<NzLeaveAllowanceModel>>>($"/business/{businessId}/leaveallowances/{employeeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Leave Allowance Templates
        /// </summary>
        /// <remarks>
        /// Lists all the leave allowance templates for this business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<NzLeaveAllowanceTemplateModel> ListLeaveAllowanceTemplates(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzLeaveAllowanceTemplateModel>>($"/business/{businessId}/leaveallowancetemplate{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Leave Allowance Templates
        /// </summary>
        /// <remarks>
        /// Lists all the leave allowance templates for this business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzLeaveAllowanceTemplateModel>> ListLeaveAllowanceTemplatesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzLeaveAllowanceTemplateModel>>($"/business/{businessId}/leaveallowancetemplate{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Creates a new leave allowance template for the business.
        /// </remarks>
        public void CreateLeaveAllowanceTemplate(int businessId, NzLeaveAllowanceTemplateModel leaveAllowanceTemplate)
        {
            ApiRequest($"/business/{businessId}/leaveallowancetemplate", leaveAllowanceTemplate, Method.Post);
        }

        /// <summary>
        /// Create Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Creates a new leave allowance template for the business.
        /// </remarks>
        public Task CreateLeaveAllowanceTemplateAsync(int businessId, NzLeaveAllowanceTemplateModel leaveAllowanceTemplate, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/leaveallowancetemplate", leaveAllowanceTemplate, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Allowance Template by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the leave allowance template with the specified ID.
        /// </remarks>
        public NzLeaveAllowanceTemplateModel GetLeaveAllowanceTemplateById(int businessId, int id)
        {
            return ApiRequest<NzLeaveAllowanceTemplateModel>($"/business/{businessId}/leaveallowancetemplate/{id}", Method.Get);
        }

        /// <summary>
        /// Get Leave Allowance Template by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the leave allowance template with the specified ID.
        /// </remarks>
        public Task<NzLeaveAllowanceTemplateModel> GetLeaveAllowanceTemplateByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzLeaveAllowanceTemplateModel>($"/business/{businessId}/leaveallowancetemplate/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Updates the leave allowance template with the specified ID.
        /// </remarks>
        public void UpdateLeaveAllowanceTemplate(int businessId, int id, NzLeaveAllowanceTemplateModel leaveAllowanceTemplate)
        {
            ApiRequest($"/business/{businessId}/leaveallowancetemplate/{id}", leaveAllowanceTemplate, Method.Put);
        }

        /// <summary>
        /// Update Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Updates the leave allowance template with the specified ID.
        /// </remarks>
        public Task UpdateLeaveAllowanceTemplateAsync(int businessId, int id, NzLeaveAllowanceTemplateModel leaveAllowanceTemplate, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/leaveallowancetemplate/{id}", leaveAllowanceTemplate, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Deletes the leave allowance template with the specified ID.
        /// </remarks>
        public void DeleteLeaveAllowanceTemplate(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/leaveallowancetemplate/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Deletes the leave allowance template with the specified ID.
        /// </remarks>
        public Task DeleteLeaveAllowanceTemplateAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/leaveallowancetemplate/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Reapply Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Reapply the leave allowance template with the specified ID.
        /// </remarks>
        public void ReapplyLeaveAllowanceTemplate(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/leaveallowancetemplate/reapply/{id}", Method.Post);
        }

        /// <summary>
        /// Reapply Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Reapply the leave allowance template with the specified ID.
        /// </remarks>
        public Task ReapplyLeaveAllowanceTemplateAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/leaveallowancetemplate/reapply/{id}", Method.Post, cancellationToken);
        }
    }
}
