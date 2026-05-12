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
using KeyPayV2.Au.Models.PayCondition;

namespace KeyPayV2.Au.Functions
{
    public interface IPayConditionFunction
    {
        List<PayConditionComparisonApiModel> GetEmployeePayConditionComparisons(int businessId, int employeeId);
        Task<List<PayConditionComparisonApiModel>> GetEmployeePayConditionComparisonsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        PayConditionComparisonApiModel CreatePayConditionComparison(int businessId, int employeeId, CreatePayConditionComparisonRequest request);
        Task<PayConditionComparisonApiModel> CreatePayConditionComparisonAsync(int businessId, int employeeId, CreatePayConditionComparisonRequest request, CancellationToken cancellationToken = default);
        InitialServiceDateResponse GetInitialServiceDate(int businessId, int employeeId);
        Task<InitialServiceDateResponse> GetInitialServiceDateAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void UpdateInitialServiceDate(int businessId, int employeeId, UpdateServiceStartDateRequest request);
        Task UpdateInitialServiceDateAsync(int businessId, int employeeId, UpdateServiceStartDateRequest request, CancellationToken cancellationToken = default);
        void DeletePayConditionComparison(int businessId, int employeeId, int id);
        Task DeletePayConditionComparisonAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default);
        List<AuPayConditionRuleSetApiModel> ListPayConditionRuleSets(int businessId, ODataQuery oDataQuery = null);
        Task<List<AuPayConditionRuleSetApiModel>> ListPayConditionRuleSetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        AuPayConditionRuleSetApiModel CreatePayConditionRuleSet(int businessId, CreateUpdatePayConditionRuleSetRequest request);
        Task<AuPayConditionRuleSetApiModel> CreatePayConditionRuleSetAsync(int businessId, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default);
        AuPayConditionRuleSetApiModel ClonePayConditionRuleSet(int businessId, ClonePayConditionRuleSetRequest request);
        Task<AuPayConditionRuleSetApiModel> ClonePayConditionRuleSetAsync(int businessId, ClonePayConditionRuleSetRequest request, CancellationToken cancellationToken = default);
        AuPayConditionRuleSetApiModel GetPayConditionRuleSetById(int businessId, int id);
        Task<AuPayConditionRuleSetApiModel> GetPayConditionRuleSetByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        AuPayConditionRuleSetApiModel UpdatePayConditionRuleSet(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request);
        Task<AuPayConditionRuleSetApiModel> UpdatePayConditionRuleSetAsync(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default);
    }
    public class PayConditionFunction : BaseFunction, IPayConditionFunction
    {
        public PayConditionFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Employee Pay Condition Comparisons
        /// </summary>
        /// <remarks>
        /// Gets all non-deleted pay condition comparisons for the specified employee.
        /// </remarks>
        public List<PayConditionComparisonApiModel> GetEmployeePayConditionComparisons(int businessId, int employeeId)
        {
            return ApiRequest<List<PayConditionComparisonApiModel>>($"/business/{businessId}/employee/{employeeId}/payconditionscomparison", Method.Get);
        }

        /// <summary>
        /// Get Employee Pay Condition Comparisons
        /// </summary>
        /// <remarks>
        /// Gets all non-deleted pay condition comparisons for the specified employee.
        /// </remarks>
        public Task<List<PayConditionComparisonApiModel>> GetEmployeePayConditionComparisonsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayConditionComparisonApiModel>>($"/business/{businessId}/employee/{employeeId}/payconditionscomparison", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pay Condition Comparison
        /// </summary>
        /// <remarks>
        /// Creates a new pay condition comparison for the specified employee.
        /// </remarks>
        public PayConditionComparisonApiModel CreatePayConditionComparison(int businessId, int employeeId, CreatePayConditionComparisonRequest request)
        {
            return ApiRequest<PayConditionComparisonApiModel,CreatePayConditionComparisonRequest>($"/business/{businessId}/employee/{employeeId}/payconditionscomparison", request, Method.Post);
        }

        /// <summary>
        /// Create Pay Condition Comparison
        /// </summary>
        /// <remarks>
        /// Creates a new pay condition comparison for the specified employee.
        /// </remarks>
        public Task<PayConditionComparisonApiModel> CreatePayConditionComparisonAsync(int businessId, int employeeId, CreatePayConditionComparisonRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayConditionComparisonApiModel,CreatePayConditionComparisonRequest>($"/business/{businessId}/employee/{employeeId}/payconditionscomparison", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Initial Service Date
        /// </summary>
        /// <remarks>
        /// Gets the initial service date for the specified employee's pay condition comparison.
        /// </remarks>
        public InitialServiceDateResponse GetInitialServiceDate(int businessId, int employeeId)
        {
            return ApiRequest<InitialServiceDateResponse>($"/business/{businessId}/employee/{employeeId}/payconditionscomparison/initialservicedate", Method.Get);
        }

        /// <summary>
        /// Get Initial Service Date
        /// </summary>
        /// <remarks>
        /// Gets the initial service date for the specified employee's pay condition comparison.
        /// </remarks>
        public Task<InitialServiceDateResponse> GetInitialServiceDateAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<InitialServiceDateResponse>($"/business/{businessId}/employee/{employeeId}/payconditionscomparison/initialservicedate", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Initial Service Date
        /// </summary>
        /// <remarks>
        /// Updates the initial service date for the specified employee's pay condition comparison.
        /// </remarks>
        public void UpdateInitialServiceDate(int businessId, int employeeId, UpdateServiceStartDateRequest request)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/payconditionscomparison/initialservicedate", request, Method.Post);
        }

        /// <summary>
        /// Update Initial Service Date
        /// </summary>
        /// <remarks>
        /// Updates the initial service date for the specified employee's pay condition comparison.
        /// </remarks>
        public Task UpdateInitialServiceDateAsync(int businessId, int employeeId, UpdateServiceStartDateRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/payconditionscomparison/initialservicedate", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Pay Condition Comparison
        /// </summary>
        /// <remarks>
        /// Deletes the pay condition comparison with the specified ID for the specified employee.
        /// </remarks>
        public void DeletePayConditionComparison(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/payconditionscomparison/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Pay Condition Comparison
        /// </summary>
        /// <remarks>
        /// Deletes the pay condition comparison with the specified ID for the specified employee.
        /// </remarks>
        public Task DeletePayConditionComparisonAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/payconditionscomparison/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Pay Condition Rule Sets
        /// </summary>
        /// <remarks>
        /// Lists all pay condition rule sets for the business. Supports OData queries ($filter, $orderby, $top, $skip).
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<AuPayConditionRuleSetApiModel> ListPayConditionRuleSets(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<AuPayConditionRuleSetApiModel>>($"/business/{businessId}/payconditionruleset{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Pay Condition Rule Sets
        /// </summary>
        /// <remarks>
        /// Lists all pay condition rule sets for the business. Supports OData queries ($filter, $orderby, $top, $skip).
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<AuPayConditionRuleSetApiModel>> ListPayConditionRuleSetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuPayConditionRuleSetApiModel>>($"/business/{businessId}/payconditionruleset{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Creates a new pay condition rule set. Note: Cannot create award-based rule sets via API.
        /// </remarks>
        public AuPayConditionRuleSetApiModel CreatePayConditionRuleSet(int businessId, CreateUpdatePayConditionRuleSetRequest request)
        {
            return ApiRequest<AuPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset", request, Method.Post);
        }

        /// <summary>
        /// Create Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Creates a new pay condition rule set. Note: Cannot create award-based rule sets via API.
        /// </remarks>
        public Task<AuPayConditionRuleSetApiModel> CreatePayConditionRuleSetAsync(int businessId, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Clone Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Clones an existing pay condition rule set. The cloned rule set will have the same rules and settings as the original,
        /// but will not be associated with any award package. If no name is provided, the name will be '{original name} - Copy'.
        /// </remarks>
        public AuPayConditionRuleSetApiModel ClonePayConditionRuleSet(int businessId, ClonePayConditionRuleSetRequest request)
        {
            return ApiRequest<AuPayConditionRuleSetApiModel,ClonePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/clone", request, Method.Post);
        }

        /// <summary>
        /// Clone Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Clones an existing pay condition rule set. The cloned rule set will have the same rules and settings as the original,
        /// but will not be associated with any award package. If no name is provided, the name will be '{original name} - Copy'.
        /// </remarks>
        public Task<AuPayConditionRuleSetApiModel> ClonePayConditionRuleSetAsync(int businessId, ClonePayConditionRuleSetRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuPayConditionRuleSetApiModel,ClonePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/clone", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pay Condition Rule Set by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay condition rule set with the specified ID.
        /// </remarks>
        public AuPayConditionRuleSetApiModel GetPayConditionRuleSetById(int businessId, int id)
        {
            return ApiRequest<AuPayConditionRuleSetApiModel>($"/business/{businessId}/payconditionruleset/{id}", Method.Get);
        }

        /// <summary>
        /// Get Pay Condition Rule Set by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay condition rule set with the specified ID.
        /// </remarks>
        public Task<AuPayConditionRuleSetApiModel> GetPayConditionRuleSetByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuPayConditionRuleSetApiModel>($"/business/{businessId}/payconditionruleset/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Updates the pay condition rule set with the specified ID. Cannot modify locked award-based rule sets.
        /// </remarks>
        public AuPayConditionRuleSetApiModel UpdatePayConditionRuleSet(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request)
        {
            return ApiRequest<AuPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/{id}", request, Method.Put);
        }

        /// <summary>
        /// Update Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Updates the pay condition rule set with the specified ID. Cannot modify locked award-based rule sets.
        /// </remarks>
        public Task<AuPayConditionRuleSetApiModel> UpdatePayConditionRuleSetAsync(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/{id}", request, Method.Put, cancellationToken);
        }
    }
}
