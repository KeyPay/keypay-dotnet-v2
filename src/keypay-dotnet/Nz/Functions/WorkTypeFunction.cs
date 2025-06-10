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

namespace KeyPayV2.Nz.Functions
{
    public interface IWorkTypeFunction
    {
        List<NzWorkTypeModel> ListWorkTypes(int businessId, ODataQuery oDataQuery = null);
        Task<List<NzWorkTypeModel>> ListWorkTypesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        NzWorkTypeModel CreateWorkType(int businessId, NzWorkTypeModel workType);
        Task<NzWorkTypeModel> CreateWorkTypeAsync(int businessId, NzWorkTypeModel workType, CancellationToken cancellationToken = default);
        NzWorkTypeModel GetWorkTypeById(int businessId, int id);
        Task<NzWorkTypeModel> GetWorkTypeByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        NzWorkTypeModel UpdateWorkType(int businessId, int id, NzWorkTypeModel workType);
        Task<NzWorkTypeModel> UpdateWorkTypeAsync(int businessId, int id, NzWorkTypeModel workType, CancellationToken cancellationToken = default);
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
        public List<NzWorkTypeModel> ListWorkTypes(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzWorkTypeModel>>($"/business/{businessId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Work Types
        /// </summary>
        /// <remarks>
        /// Lists all the work types for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzWorkTypeModel>> ListWorkTypesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzWorkTypeModel>>($"/business/{businessId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Work Type
        /// </summary>
        /// <remarks>
        /// Creates a new work type for the business.
        /// </remarks>
        public NzWorkTypeModel CreateWorkType(int businessId, NzWorkTypeModel workType)
        {
            return ApiRequest<NzWorkTypeModel,NzWorkTypeModel>($"/business/{businessId}/worktype", workType, Method.Post);
        }

        /// <summary>
        /// Create Work Type
        /// </summary>
        /// <remarks>
        /// Creates a new work type for the business.
        /// </remarks>
        public Task<NzWorkTypeModel> CreateWorkTypeAsync(int businessId, NzWorkTypeModel workType, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzWorkTypeModel,NzWorkTypeModel>($"/business/{businessId}/worktype", workType, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Work Type by ID
        /// </summary>
        /// <remarks>
        /// Gets the work type with the specified ID.
        /// </remarks>
        public NzWorkTypeModel GetWorkTypeById(int businessId, int id)
        {
            return ApiRequest<NzWorkTypeModel>($"/business/{businessId}/worktype/{id}", Method.Get);
        }

        /// <summary>
        /// Get Work Type by ID
        /// </summary>
        /// <remarks>
        /// Gets the work type with the specified ID.
        /// </remarks>
        public Task<NzWorkTypeModel> GetWorkTypeByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzWorkTypeModel>($"/business/{businessId}/worktype/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Work Type
        /// </summary>
        /// <remarks>
        /// Updates the work type with the specified ID.
        /// </remarks>
        public NzWorkTypeModel UpdateWorkType(int businessId, int id, NzWorkTypeModel workType)
        {
            return ApiRequest<NzWorkTypeModel,NzWorkTypeModel>($"/business/{businessId}/worktype/{id}", workType, Method.Put);
        }

        /// <summary>
        /// Update Work Type
        /// </summary>
        /// <remarks>
        /// Updates the work type with the specified ID.
        /// </remarks>
        public Task<NzWorkTypeModel> UpdateWorkTypeAsync(int businessId, int id, NzWorkTypeModel workType, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzWorkTypeModel,NzWorkTypeModel>($"/business/{businessId}/worktype/{id}", workType, Method.Put, cancellationToken);
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
