using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;

namespace KeyPayV2.Uk.Functions
{
    public interface IWorkTypeFunction
    {
        List<UkWorkTypeModel> ListWorkTypes(int businessId, ODataQuery oDataQuery = null);
        Task<List<UkWorkTypeModel>> ListWorkTypesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        UkWorkTypeModel CreateWorkType(int businessId, UkWorkTypeModel workType);
        Task<UkWorkTypeModel> CreateWorkTypeAsync(int businessId, UkWorkTypeModel workType, CancellationToken cancellationToken = default);
        UkWorkTypeModel GetWorkTypeById(int businessId, int id);
        Task<UkWorkTypeModel> GetWorkTypeByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        UkWorkTypeModel UpdateWorkType(int businessId, int id, UkWorkTypeModel workType);
        Task<UkWorkTypeModel> UpdateWorkTypeAsync(int businessId, int id, UkWorkTypeModel workType, CancellationToken cancellationToken = default);
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
        public List<UkWorkTypeModel> ListWorkTypes(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkWorkTypeModel>>($"/business/{businessId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Work Types
        /// </summary>
        /// <remarks>
        /// Lists all the work types for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<UkWorkTypeModel>> ListWorkTypesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkWorkTypeModel>>($"/business/{businessId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Work Type
        /// </summary>
        /// <remarks>
        /// Creates a new work type for the business.
        /// </remarks>
        public UkWorkTypeModel CreateWorkType(int businessId, UkWorkTypeModel workType)
        {
            return ApiRequest<UkWorkTypeModel,UkWorkTypeModel>($"/business/{businessId}/worktype", workType, Method.Post);
        }

        /// <summary>
        /// Create Work Type
        /// </summary>
        /// <remarks>
        /// Creates a new work type for the business.
        /// </remarks>
        public Task<UkWorkTypeModel> CreateWorkTypeAsync(int businessId, UkWorkTypeModel workType, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkWorkTypeModel,UkWorkTypeModel>($"/business/{businessId}/worktype", workType, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Work Type by ID
        /// </summary>
        /// <remarks>
        /// Gets the work type with the specified ID.
        /// </remarks>
        public UkWorkTypeModel GetWorkTypeById(int businessId, int id)
        {
            return ApiRequest<UkWorkTypeModel>($"/business/{businessId}/worktype/{id}", Method.Get);
        }

        /// <summary>
        /// Get Work Type by ID
        /// </summary>
        /// <remarks>
        /// Gets the work type with the specified ID.
        /// </remarks>
        public Task<UkWorkTypeModel> GetWorkTypeByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkWorkTypeModel>($"/business/{businessId}/worktype/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Work Type
        /// </summary>
        /// <remarks>
        /// Updates the work type with the specified ID.
        /// </remarks>
        public UkWorkTypeModel UpdateWorkType(int businessId, int id, UkWorkTypeModel workType)
        {
            return ApiRequest<UkWorkTypeModel,UkWorkTypeModel>($"/business/{businessId}/worktype/{id}", workType, Method.Put);
        }

        /// <summary>
        /// Update Work Type
        /// </summary>
        /// <remarks>
        /// Updates the work type with the specified ID.
        /// </remarks>
        public Task<UkWorkTypeModel> UpdateWorkTypeAsync(int businessId, int id, UkWorkTypeModel workType, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkWorkTypeModel,UkWorkTypeModel>($"/business/{businessId}/worktype/{id}", workType, Method.Put, cancellationToken);
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
