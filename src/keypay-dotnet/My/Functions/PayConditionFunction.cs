using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.PayCondition;

namespace KeyPayV2.My.Functions
{
    public interface IPayConditionFunction
    {
        List<MyPayConditionRuleSetApiModel> ListPayConditionRuleSets(int businessId, ODataQuery oDataQuery = null);
        Task<List<MyPayConditionRuleSetApiModel>> ListPayConditionRuleSetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        MyPayConditionRuleSetApiModel CreatePayConditionRuleSet(int businessId, CreateUpdatePayConditionRuleSetRequest request);
        Task<MyPayConditionRuleSetApiModel> CreatePayConditionRuleSetAsync(int businessId, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default);
        MyPayConditionRuleSetApiModel GetPayConditionRuleSetById(int businessId, int id);
        Task<MyPayConditionRuleSetApiModel> GetPayConditionRuleSetByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        MyPayConditionRuleSetApiModel UpdatePayConditionRuleSet(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request);
        Task<MyPayConditionRuleSetApiModel> UpdatePayConditionRuleSetAsync(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default);
        MyPayConditionRuleSetApiModel ClonePayConditionRuleSet(int businessId, ClonePayConditionRuleSetRequest request);
        Task<MyPayConditionRuleSetApiModel> ClonePayConditionRuleSetAsync(int businessId, ClonePayConditionRuleSetRequest request, CancellationToken cancellationToken = default);
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
        public List<MyPayConditionRuleSetApiModel> ListPayConditionRuleSets(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<MyPayConditionRuleSetApiModel>>($"/business/{businessId}/payconditionruleset{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Pay Condition Rule Sets
        /// </summary>
        /// <remarks>
        /// Lists all pay condition rule sets for the business. Supports OData queries ($filter, $orderby, $top, $skip).
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<MyPayConditionRuleSetApiModel>> ListPayConditionRuleSetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyPayConditionRuleSetApiModel>>($"/business/{businessId}/payconditionruleset{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Creates a new pay condition rule set. Note: Cannot create award-based rule sets via API.
        /// </remarks>
        public MyPayConditionRuleSetApiModel CreatePayConditionRuleSet(int businessId, CreateUpdatePayConditionRuleSetRequest request)
        {
            return ApiRequest<MyPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset", request, Method.Post);
        }

        /// <summary>
        /// Create Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Creates a new pay condition rule set. Note: Cannot create award-based rule sets via API.
        /// </remarks>
        public Task<MyPayConditionRuleSetApiModel> CreatePayConditionRuleSetAsync(int businessId, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pay Condition Rule Set by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay condition rule set with the specified ID.
        /// </remarks>
        public MyPayConditionRuleSetApiModel GetPayConditionRuleSetById(int businessId, int id)
        {
            return ApiRequest<MyPayConditionRuleSetApiModel>($"/business/{businessId}/payconditionruleset/{id}", Method.Get);
        }

        /// <summary>
        /// Get Pay Condition Rule Set by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay condition rule set with the specified ID.
        /// </remarks>
        public Task<MyPayConditionRuleSetApiModel> GetPayConditionRuleSetByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyPayConditionRuleSetApiModel>($"/business/{businessId}/payconditionruleset/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Updates the pay condition rule set with the specified ID. Cannot modify locked award-based rule sets.
        /// </remarks>
        public MyPayConditionRuleSetApiModel UpdatePayConditionRuleSet(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request)
        {
            return ApiRequest<MyPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/{id}", request, Method.Put);
        }

        /// <summary>
        /// Update Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Updates the pay condition rule set with the specified ID. Cannot modify locked award-based rule sets.
        /// </remarks>
        public Task<MyPayConditionRuleSetApiModel> UpdatePayConditionRuleSetAsync(int businessId, int id, CreateUpdatePayConditionRuleSetRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyPayConditionRuleSetApiModel,CreateUpdatePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/{id}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Clone Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Clones an existing pay condition rule set. The cloned rule set will have the same rules and settings as the original,
        /// but will not be associated with any award package. If no name is provided, the name will be '{original name} - Copy'.
        /// </remarks>
        public MyPayConditionRuleSetApiModel ClonePayConditionRuleSet(int businessId, ClonePayConditionRuleSetRequest request)
        {
            return ApiRequest<MyPayConditionRuleSetApiModel,ClonePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/clone", request, Method.Post);
        }

        /// <summary>
        /// Clone Pay Condition Rule Set
        /// </summary>
        /// <remarks>
        /// Clones an existing pay condition rule set. The cloned rule set will have the same rules and settings as the original,
        /// but will not be associated with any award package. If no name is provided, the name will be '{original name} - Copy'.
        /// </remarks>
        public Task<MyPayConditionRuleSetApiModel> ClonePayConditionRuleSetAsync(int businessId, ClonePayConditionRuleSetRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyPayConditionRuleSetApiModel,ClonePayConditionRuleSetRequest>($"/business/{businessId}/payconditionruleset/clone", request, Method.Post, cancellationToken);
        }
    }
}
