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
using KeyPayV2.Nz.Models.PayCondition;

namespace KeyPayV2.Nz.Functions
{
    public interface IPayConditionFunction
    {
        List<NzPayConditionRuleSetApiModel> ListPayConditionRuleSets(int businessId, ODataQuery oDataQuery = null);
        Task<List<NzPayConditionRuleSetApiModel>> ListPayConditionRuleSetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        NzPayConditionRuleSetApiModel CreatePayConditionRuleSet(int businessId, CreateUpdatePayConditionRuleSetRequest request);
        Task<NzPayConditionRuleSetApiModel> CreatePayConditionRuleSetAsync(int businessId, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default);
        NzPayConditionRuleSetApiModel GetPayConditionRuleSetById(int businessId, int id);
        Task<NzPayConditionRuleSetApiModel> GetPayConditionRuleSetByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        NzPayConditionRuleSetApiModel UpdatePayConditionRuleSet(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request);
        Task<NzPayConditionRuleSetApiModel> UpdatePayConditionRuleSetAsync(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default);
        NzPayConditionRuleSetApiModel ClonePayConditionRuleSet(int businessId, ClonePayConditionRuleSetRequest request);
        Task<NzPayConditionRuleSetApiModel> ClonePayConditionRuleSetAsync(int businessId, ClonePayConditionRuleSetRequest request, CancellationToken cancellationToken = default);
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
        public List<NzPayConditionRuleSetApiModel> ListPayConditionRuleSets(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzPayConditionRuleSetApiModel>>($"/business/{businessId}/payconditionruleset{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Pay Condition Rule Sets
        /// </summary>
        /// <remarks>
        /// Lists all pay condition rule sets for the business. Supports OData queries ($filter, $orderby, $top, $skip).
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzPayConditionRuleSetApiModel>> ListPayConditionRuleSetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzPayConditionRuleSetApiModel>>($"/business/{businessId}/payconditionruleset{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Creates a new pay condition rule set. Note: Cannot create award-based rule sets via API.
        /// </remarks>
        public NzPayConditionRuleSetApiModel CreatePayConditionRuleSet(int businessId, CreateUpdatePayConditionRuleSetRequest request)
        {
            return ApiRequest<NzPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset", request, Method.Post);
        }

        /// <summary>
        /// Create Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Creates a new pay condition rule set. Note: Cannot create award-based rule sets via API.
        /// </remarks>
        public Task<NzPayConditionRuleSetApiModel> CreatePayConditionRuleSetAsync(int businessId, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pay Condition Rule Set by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay condition rule set with the specified ID.
        /// </remarks>
        public NzPayConditionRuleSetApiModel GetPayConditionRuleSetById(int businessId, int id)
        {
            return ApiRequest<NzPayConditionRuleSetApiModel>($"/business/{businessId}/payconditionruleset/{id}", Method.Get);
        }

        /// <summary>
        /// Get Pay Condition Rule Set by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay condition rule set with the specified ID.
        /// </remarks>
        public Task<NzPayConditionRuleSetApiModel> GetPayConditionRuleSetByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzPayConditionRuleSetApiModel>($"/business/{businessId}/payconditionruleset/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Updates the pay condition rule set with the specified ID. Cannot modify locked award-based rule sets.
        /// </remarks>
        public NzPayConditionRuleSetApiModel UpdatePayConditionRuleSet(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request)
        {
            return ApiRequest<NzPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/{id}", request, Method.Put);
        }

        /// <summary>
        /// Update Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Updates the pay condition rule set with the specified ID. Cannot modify locked award-based rule sets.
        /// </remarks>
        public Task<NzPayConditionRuleSetApiModel> UpdatePayConditionRuleSetAsync(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/{id}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Clone Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Clones an existing pay condition rule set. The cloned rule set will have the same rules and settings as the original,
        /// but will not be associated with any award package. If no name is provided, the name will be '{original name} - Copy'.
        /// </remarks>
        public NzPayConditionRuleSetApiModel ClonePayConditionRuleSet(int businessId, ClonePayConditionRuleSetRequest request)
        {
            return ApiRequest<NzPayConditionRuleSetApiModel,ClonePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/clone", request, Method.Post);
        }

        /// <summary>
        /// Clone Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Clones an existing pay condition rule set. The cloned rule set will have the same rules and settings as the original,
        /// but will not be associated with any award package. If no name is provided, the name will be '{original name} - Copy'.
        /// </remarks>
        public Task<NzPayConditionRuleSetApiModel> ClonePayConditionRuleSetAsync(int businessId, ClonePayConditionRuleSetRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzPayConditionRuleSetApiModel,ClonePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/clone", request, Method.Post, cancellationToken);
        }
    }
}
