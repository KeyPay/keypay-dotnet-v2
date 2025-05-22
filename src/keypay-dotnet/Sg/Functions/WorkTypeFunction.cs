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

namespace KeyPayV2.Sg.Functions
{
    public interface IWorkTypeFunction
    {
        List<SgWorkTypeModel> ListWorkTypes(int businessId, ODataQuery oDataQuery = null);
        Task<List<SgWorkTypeModel>> ListWorkTypesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        SgWorkTypeModel CreateWorkType(int businessId, SgWorkTypeModel workType);
        Task<SgWorkTypeModel> CreateWorkTypeAsync(int businessId, SgWorkTypeModel workType, CancellationToken cancellationToken = default);
        SgWorkTypeModel GetWorkTypeById(int businessId, int id);
        Task<SgWorkTypeModel> GetWorkTypeByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        SgWorkTypeModel UpdateWorkType(int businessId, int id, SgWorkTypeModel workType);
        Task<SgWorkTypeModel> UpdateWorkTypeAsync(int businessId, int id, SgWorkTypeModel workType, CancellationToken cancellationToken = default);
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
        public List<SgWorkTypeModel> ListWorkTypes(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<SgWorkTypeModel>>($"/business/{businessId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Work Types
        /// </summary>
        /// <remarks>
        /// Lists all the work types for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<SgWorkTypeModel>> ListWorkTypesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgWorkTypeModel>>($"/business/{businessId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Work Type
        /// </summary>
        /// <remarks>
        /// Creates a new work type for the business.
        /// </remarks>
        public SgWorkTypeModel CreateWorkType(int businessId, SgWorkTypeModel workType)
        {
            return ApiRequest<SgWorkTypeModel,SgWorkTypeModel>($"/business/{businessId}/worktype", workType, Method.Post);
        }

        /// <summary>
        /// Create Work Type
        /// </summary>
        /// <remarks>
        /// Creates a new work type for the business.
        /// </remarks>
        public Task<SgWorkTypeModel> CreateWorkTypeAsync(int businessId, SgWorkTypeModel workType, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgWorkTypeModel,SgWorkTypeModel>($"/business/{businessId}/worktype", workType, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Work Type by ID
        /// </summary>
        /// <remarks>
        /// Gets the work type with the specified ID.
        /// </remarks>
        public SgWorkTypeModel GetWorkTypeById(int businessId, int id)
        {
            return ApiRequest<SgWorkTypeModel>($"/business/{businessId}/worktype/{id}", Method.Get);
        }

        /// <summary>
        /// Get Work Type by ID
        /// </summary>
        /// <remarks>
        /// Gets the work type with the specified ID.
        /// </remarks>
        public Task<SgWorkTypeModel> GetWorkTypeByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgWorkTypeModel>($"/business/{businessId}/worktype/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Work Type
        /// </summary>
        /// <remarks>
        /// Updates the work type with the specified ID.
        /// </remarks>
        public SgWorkTypeModel UpdateWorkType(int businessId, int id, SgWorkTypeModel workType)
        {
            return ApiRequest<SgWorkTypeModel,SgWorkTypeModel>($"/business/{businessId}/worktype/{id}", workType, Method.Put);
        }

        /// <summary>
        /// Update Work Type
        /// </summary>
        /// <remarks>
        /// Updates the work type with the specified ID.
        /// </remarks>
        public Task<SgWorkTypeModel> UpdateWorkTypeAsync(int businessId, int id, SgWorkTypeModel workType, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgWorkTypeModel,SgWorkTypeModel>($"/business/{businessId}/worktype/{id}", workType, Method.Put, cancellationToken);
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
