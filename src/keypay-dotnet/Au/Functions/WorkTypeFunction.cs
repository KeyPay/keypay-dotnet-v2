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
    public interface IWorkTypeFunction
    {
        List<AuWorkTypeModel> ListWorkTypes(int businessId, ODataQuery oDataQuery = null);
        Task<List<AuWorkTypeModel>> ListWorkTypesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        AuWorkTypeModel CreateWorkType(int businessId, AuWorkTypeModel workType);
        Task<AuWorkTypeModel> CreateWorkTypeAsync(int businessId, AuWorkTypeModel workType, CancellationToken cancellationToken = default);
        AuWorkTypeModel GetWorkTypeById(int businessId, int id);
        Task<AuWorkTypeModel> GetWorkTypeByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        AuWorkTypeModel UpdateWorkType(int businessId, int id, AuWorkTypeModel workType);
        Task<AuWorkTypeModel> UpdateWorkTypeAsync(int businessId, int id, AuWorkTypeModel workType, CancellationToken cancellationToken = default);
        void DeleteWorkType(int businessId, int id);
        Task DeleteWorkTypeAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class WorkTypeFunction : BaseFunction, IWorkTypeFunction
    {
        public WorkTypeFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Work Types
        /// </summary>
        /// <remarks>
        /// Lists all the work types for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<AuWorkTypeModel> ListWorkTypes(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<AuWorkTypeModel>>($"/business/{businessId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Work Types
        /// </summary>
        /// <remarks>
        /// Lists all the work types for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<AuWorkTypeModel>> ListWorkTypesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuWorkTypeModel>>($"/business/{businessId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Work Type
        /// </summary>
        /// <remarks>
        /// Creates a new work type for the business.
        /// </remarks>
        public AuWorkTypeModel CreateWorkType(int businessId, AuWorkTypeModel workType)
        {
            return ApiRequest<AuWorkTypeModel,AuWorkTypeModel>($"/business/{businessId}/worktype", workType, Method.Post);
        }

        /// <summary>
        /// Create Work Type
        /// </summary>
        /// <remarks>
        /// Creates a new work type for the business.
        /// </remarks>
        public Task<AuWorkTypeModel> CreateWorkTypeAsync(int businessId, AuWorkTypeModel workType, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuWorkTypeModel,AuWorkTypeModel>($"/business/{businessId}/worktype", workType, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Work Type by ID
        /// </summary>
        /// <remarks>
        /// Gets the work type with the specified ID.
        /// </remarks>
        public AuWorkTypeModel GetWorkTypeById(int businessId, int id)
        {
            return ApiRequest<AuWorkTypeModel>($"/business/{businessId}/worktype/{id}", Method.Get);
        }

        /// <summary>
        /// Get Work Type by ID
        /// </summary>
        /// <remarks>
        /// Gets the work type with the specified ID.
        /// </remarks>
        public Task<AuWorkTypeModel> GetWorkTypeByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuWorkTypeModel>($"/business/{businessId}/worktype/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Work Type
        /// </summary>
        /// <remarks>
        /// Updates the work type with the specified ID.
        /// </remarks>
        public AuWorkTypeModel UpdateWorkType(int businessId, int id, AuWorkTypeModel workType)
        {
            return ApiRequest<AuWorkTypeModel,AuWorkTypeModel>($"/business/{businessId}/worktype/{id}", workType, Method.Put);
        }

        /// <summary>
        /// Update Work Type
        /// </summary>
        /// <remarks>
        /// Updates the work type with the specified ID.
        /// </remarks>
        public Task<AuWorkTypeModel> UpdateWorkTypeAsync(int businessId, int id, AuWorkTypeModel workType, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuWorkTypeModel,AuWorkTypeModel>($"/business/{businessId}/worktype/{id}", workType, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Work Type
        /// </summary>
        /// <remarks>
        /// Deletes the work type with the specified ID.
        /// </remarks>
        public void DeleteWorkType(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/worktype/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Work Type
        /// </summary>
        /// <remarks>
        /// Deletes the work type with the specified ID.
        /// </remarks>
        public Task DeleteWorkTypeAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/worktype/{id}", Method.Delete, cancellationToken);
        }
    }
}
