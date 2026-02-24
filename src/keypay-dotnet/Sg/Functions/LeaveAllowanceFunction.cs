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
using KeyPayV2.Sg.Models.LeaveAllowance;

namespace KeyPayV2.Sg.Functions
{
    public interface ILeaveAllowanceFunction
    {
        SgLeaveAllowanceTemplateModel GetLeaveAllowanceTemplateForEmployee(int businessId, int employeeId);
        Task<SgLeaveAllowanceTemplateModel> GetLeaveAllowanceTemplateForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void AssignLeaveAllowanceTemplate(int businessId, int employeeId, int leaveAllowanceTemplateId);
        Task AssignLeaveAllowanceTemplateAsync(int businessId, int employeeId, int leaveAllowanceTemplateId, CancellationToken cancellationToken = default);
        Dictionary<string, IList<SgLeaveAllowanceModel>> GetLeaveAllowancesForAllEmployees(int businessId);
        Task<Dictionary<string, IList<SgLeaveAllowanceModel>>> GetLeaveAllowancesForAllEmployeesAsync(int businessId, CancellationToken cancellationToken = default);
        SgLeaveAllowanceModel SetLeaveAllowances(int businessId, SgLeaveAllowancesRequest request);
        Task<SgLeaveAllowanceModel> SetLeaveAllowancesAsync(int businessId, SgLeaveAllowancesRequest request, CancellationToken cancellationToken = default);
        Dictionary<string, IList<SgLeaveAllowanceModel>> GetLeaveAllowancesForEmployee(int businessId, int employeeId);
        Task<Dictionary<string, IList<SgLeaveAllowanceModel>>> GetLeaveAllowancesForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<SgLeaveAllowanceTemplateModel> ListLeaveAllowanceTemplates(int businessId, ODataQuery oDataQuery = null);
        Task<List<SgLeaveAllowanceTemplateModel>> ListLeaveAllowanceTemplatesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        SgLeaveAllowanceTemplateModel CreateLeaveAllowanceTemplate(int businessId, SgLeaveAllowanceTemplateModel leaveAllowanceTemplate);
        Task<SgLeaveAllowanceTemplateModel> CreateLeaveAllowanceTemplateAsync(int businessId, SgLeaveAllowanceTemplateModel leaveAllowanceTemplate, CancellationToken cancellationToken = default);
        SgLeaveAllowanceTemplateModel GetLeaveAllowanceTemplateById(int businessId, int id);
        Task<SgLeaveAllowanceTemplateModel> GetLeaveAllowanceTemplateByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        SgLeaveAllowanceTemplateModel UpdateLeaveAllowanceTemplate(int businessId, int id, SgLeaveAllowanceTemplateModel leaveAllowanceTemplate);
        Task<SgLeaveAllowanceTemplateModel> UpdateLeaveAllowanceTemplateAsync(int businessId, int id, SgLeaveAllowanceTemplateModel leaveAllowanceTemplate, CancellationToken cancellationToken = default);
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
        public SgLeaveAllowanceTemplateModel GetLeaveAllowanceTemplateForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<SgLeaveAllowanceTemplateModel>($"/business/{businessId}/employee/{employeeId}/leaveallowancetemplate", Method.Get);
        }

        /// <summary>
        /// Get Leave Allowance Template for Employee
        /// </summary>
        /// <remarks>
        /// Gets the current leave allowance template for the specified employee
        /// </remarks>
        public Task<SgLeaveAllowanceTemplateModel> GetLeaveAllowanceTemplateForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgLeaveAllowanceTemplateModel>($"/business/{businessId}/employee/{employeeId}/leaveallowancetemplate", Method.Get, cancellationToken);
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
        public Dictionary<string, IList<SgLeaveAllowanceModel>> GetLeaveAllowancesForAllEmployees(int businessId)
        {
            return ApiRequest<Dictionary<string, IList<SgLeaveAllowanceModel>>>($"/business/{businessId}/leaveallowances", Method.Get);
        }

        /// <summary>
        /// Get Leave Allowances for All Employees
        /// </summary>
        /// <remarks>
        /// Gets the leave allowances for all employees in the business
        /// </remarks>
        public Task<Dictionary<string, IList<SgLeaveAllowanceModel>>> GetLeaveAllowancesForAllEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<Dictionary<string, IList<SgLeaveAllowanceModel>>>($"/business/{businessId}/leaveallowances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Leave Allowances
        /// </summary>
        /// <remarks>
        /// Sets the leave allowances for the specified employees (dictionary keyed by employee ID).
        /// </remarks>
        public SgLeaveAllowanceModel SetLeaveAllowances(int businessId, SgLeaveAllowancesRequest request)
        {
            return ApiRequest<SgLeaveAllowanceModel,SgLeaveAllowancesRequest>($"/business/{businessId}/leaveallowances", request, Method.Put);
        }

        /// <summary>
        /// Set Leave Allowances
        /// </summary>
        /// <remarks>
        /// Sets the leave allowances for the specified employees (dictionary keyed by employee ID).
        /// </remarks>
        public Task<SgLeaveAllowanceModel> SetLeaveAllowancesAsync(int businessId, SgLeaveAllowancesRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgLeaveAllowanceModel,SgLeaveAllowancesRequest>($"/business/{businessId}/leaveallowances", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Leave Allowances for Employee
        /// </summary>
        /// <remarks>
        /// Get leave Allowances for a single employee
        /// </remarks>
        public Dictionary<string, IList<SgLeaveAllowanceModel>> GetLeaveAllowancesForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<Dictionary<string, IList<SgLeaveAllowanceModel>>>($"/business/{businessId}/leaveallowances/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Get Leave Allowances for Employee
        /// </summary>
        /// <remarks>
        /// Get leave Allowances for a single employee
        /// </remarks>
        public Task<Dictionary<string, IList<SgLeaveAllowanceModel>>> GetLeaveAllowancesForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<Dictionary<string, IList<SgLeaveAllowanceModel>>>($"/business/{businessId}/leaveallowances/{employeeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Leave Allowance Templates
        /// </summary>
        /// <remarks>
        /// Lists all the leave allowance templates for this business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<SgLeaveAllowanceTemplateModel> ListLeaveAllowanceTemplates(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<SgLeaveAllowanceTemplateModel>>($"/business/{businessId}/leaveallowancetemplate{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Leave Allowance Templates
        /// </summary>
        /// <remarks>
        /// Lists all the leave allowance templates for this business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<SgLeaveAllowanceTemplateModel>> ListLeaveAllowanceTemplatesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgLeaveAllowanceTemplateModel>>($"/business/{businessId}/leaveallowancetemplate{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Creates a new leave allowance template for the business.
        /// </remarks>
        public SgLeaveAllowanceTemplateModel CreateLeaveAllowanceTemplate(int businessId, SgLeaveAllowanceTemplateModel leaveAllowanceTemplate)
        {
            return ApiRequest<SgLeaveAllowanceTemplateModel,SgLeaveAllowanceTemplateModel>($"/business/{businessId}/leaveallowancetemplate", leaveAllowanceTemplate, Method.Post);
        }

        /// <summary>
        /// Create Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Creates a new leave allowance template for the business.
        /// </remarks>
        public Task<SgLeaveAllowanceTemplateModel> CreateLeaveAllowanceTemplateAsync(int businessId, SgLeaveAllowanceTemplateModel leaveAllowanceTemplate, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgLeaveAllowanceTemplateModel,SgLeaveAllowanceTemplateModel>($"/business/{businessId}/leaveallowancetemplate", leaveAllowanceTemplate, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Allowance Template by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the leave allowance template with the specified ID.
        /// </remarks>
        public SgLeaveAllowanceTemplateModel GetLeaveAllowanceTemplateById(int businessId, int id)
        {
            return ApiRequest<SgLeaveAllowanceTemplateModel>($"/business/{businessId}/leaveallowancetemplate/{id}", Method.Get);
        }

        /// <summary>
        /// Get Leave Allowance Template by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the leave allowance template with the specified ID.
        /// </remarks>
        public Task<SgLeaveAllowanceTemplateModel> GetLeaveAllowanceTemplateByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgLeaveAllowanceTemplateModel>($"/business/{businessId}/leaveallowancetemplate/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Updates the leave allowance template with the specified ID.
        /// </remarks>
        public SgLeaveAllowanceTemplateModel UpdateLeaveAllowanceTemplate(int businessId, int id, SgLeaveAllowanceTemplateModel leaveAllowanceTemplate)
        {
            return ApiRequest<SgLeaveAllowanceTemplateModel,SgLeaveAllowanceTemplateModel>($"/business/{businessId}/leaveallowancetemplate/{id}", leaveAllowanceTemplate, Method.Put);
        }

        /// <summary>
        /// Update Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Updates the leave allowance template with the specified ID.
        /// </remarks>
        public Task<SgLeaveAllowanceTemplateModel> UpdateLeaveAllowanceTemplateAsync(int businessId, int id, SgLeaveAllowanceTemplateModel leaveAllowanceTemplate, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgLeaveAllowanceTemplateModel,SgLeaveAllowanceTemplateModel>($"/business/{businessId}/leaveallowancetemplate/{id}", leaveAllowanceTemplate, Method.Put, cancellationToken);
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
