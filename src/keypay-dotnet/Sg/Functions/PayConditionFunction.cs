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
using KeyPayV2.Sg.Models.PayCondition;

namespace KeyPayV2.Sg.Functions
{
    public interface IPayConditionFunction
    {
        List<SgPayConditionRuleSetApiModel> ListPayConditionRuleSets(int businessId, ODataQuery oDataQuery = null);
        Task<List<SgPayConditionRuleSetApiModel>> ListPayConditionRuleSetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        SgPayConditionRuleSetApiModel CreatePayConditionRuleSet(int businessId, CreateUpdatePayConditionRuleSetRequest request);
        Task<SgPayConditionRuleSetApiModel> CreatePayConditionRuleSetAsync(int businessId, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default);
        SgPayConditionRuleSetApiModel GetPayConditionRuleSetById(int businessId, int id);
        Task<SgPayConditionRuleSetApiModel> GetPayConditionRuleSetByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        SgPayConditionRuleSetApiModel UpdatePayConditionRuleSet(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request);
        Task<SgPayConditionRuleSetApiModel> UpdatePayConditionRuleSetAsync(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default);
        SgPayConditionRuleSetApiModel ClonePayConditionRuleSet(int businessId, ClonePayConditionRuleSetRequest request);
        Task<SgPayConditionRuleSetApiModel> ClonePayConditionRuleSetAsync(int businessId, ClonePayConditionRuleSetRequest request, CancellationToken cancellationToken = default);
    }
    public class PayConditionFunction : BaseFunction, IPayConditionFunction
    {
        public PayConditionFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Pay Condition Rule Sets
        /// </summary>
        /// <remarks>
        /// Lists all pay condition rule sets for the business. Supports OData queries ($filter, $orderby, $top, $skip).
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<SgPayConditionRuleSetApiModel> ListPayConditionRuleSets(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<SgPayConditionRuleSetApiModel>>($"/business/{businessId}/payconditionruleset{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Pay Condition Rule Sets
        /// </summary>
        /// <remarks>
        /// Lists all pay condition rule sets for the business. Supports OData queries ($filter, $orderby, $top, $skip).
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<SgPayConditionRuleSetApiModel>> ListPayConditionRuleSetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgPayConditionRuleSetApiModel>>($"/business/{businessId}/payconditionruleset{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Creates a new pay condition rule set. Note: Cannot create award-based rule sets via API.
        /// </remarks>
        public SgPayConditionRuleSetApiModel CreatePayConditionRuleSet(int businessId, CreateUpdatePayConditionRuleSetRequest request)
        {
            return ApiRequest<SgPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset", request, Method.Post);
        }

        /// <summary>
        /// Create Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Creates a new pay condition rule set. Note: Cannot create award-based rule sets via API.
        /// </remarks>
        public Task<SgPayConditionRuleSetApiModel> CreatePayConditionRuleSetAsync(int businessId, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pay Condition Rule Set by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay condition rule set with the specified ID.
        /// </remarks>
        public SgPayConditionRuleSetApiModel GetPayConditionRuleSetById(int businessId, int id)
        {
            return ApiRequest<SgPayConditionRuleSetApiModel>($"/business/{businessId}/payconditionruleset/{id}", Method.Get);
        }

        /// <summary>
        /// Get Pay Condition Rule Set by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay condition rule set with the specified ID.
        /// </remarks>
        public Task<SgPayConditionRuleSetApiModel> GetPayConditionRuleSetByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayConditionRuleSetApiModel>($"/business/{businessId}/payconditionruleset/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Updates the pay condition rule set with the specified ID. Cannot modify locked award-based rule sets.
        /// </remarks>
        public SgPayConditionRuleSetApiModel UpdatePayConditionRuleSet(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request)
        {
            return ApiRequest<SgPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/{id}", request, Method.Put);
        }

        /// <summary>
        /// Update Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Updates the pay condition rule set with the specified ID. Cannot modify locked award-based rule sets.
        /// </remarks>
        public Task<SgPayConditionRuleSetApiModel> UpdatePayConditionRuleSetAsync(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/{id}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Clone Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Clones an existing pay condition rule set. The cloned rule set will have the same rules and settings as the original,
        /// but will not be associated with any award package. If no name is provided, the name will be '{original name} - Copy'.
        /// </remarks>
        public SgPayConditionRuleSetApiModel ClonePayConditionRuleSet(int businessId, ClonePayConditionRuleSetRequest request)
        {
            return ApiRequest<SgPayConditionRuleSetApiModel,ClonePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/clone", request, Method.Post);
        }

        /// <summary>
        /// Clone Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Clones an existing pay condition rule set. The cloned rule set will have the same rules and settings as the original,
        /// but will not be associated with any award package. If no name is provided, the name will be '{original name} - Copy'.
        /// </remarks>
        public Task<SgPayConditionRuleSetApiModel> ClonePayConditionRuleSetAsync(int businessId, ClonePayConditionRuleSetRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayConditionRuleSetApiModel,ClonePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/clone", request, Method.Post, cancellationToken);
        }
    }
}
