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

namespace KeyPayV2.My.Functions
{
    public interface IWorkTypeFunction
    {
        List<MyWorkTypeModel> ListWorkTypes(int businessId, ODataQuery oDataQuery = null);
        Task<List<MyWorkTypeModel>> ListWorkTypesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        MyWorkTypeModel CreateWorkType(int businessId, MyWorkTypeModel workType);
        Task<MyWorkTypeModel> CreateWorkTypeAsync(int businessId, MyWorkTypeModel workType, CancellationToken cancellationToken = default);
        MyWorkTypeModel GetWorkTypeById(int businessId, int id);
        Task<MyWorkTypeModel> GetWorkTypeByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        MyWorkTypeModel UpdateWorkType(int businessId, int id, MyWorkTypeModel workType);
        Task<MyWorkTypeModel> UpdateWorkTypeAsync(int businessId, int id, MyWorkTypeModel workType, CancellationToken cancellationToken = default);
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
        public List<MyWorkTypeModel> ListWorkTypes(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<MyWorkTypeModel>>($"/business/{businessId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Work Types
        /// </summary>
        /// <remarks>
        /// Lists all the work types for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<MyWorkTypeModel>> ListWorkTypesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyWorkTypeModel>>($"/business/{businessId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Work Type
        /// </summary>
        /// <remarks>
        /// Creates a new work type for the business.
        /// </remarks>
        public MyWorkTypeModel CreateWorkType(int businessId, MyWorkTypeModel workType)
        {
            return ApiRequest<MyWorkTypeModel,MyWorkTypeModel>($"/business/{businessId}/worktype", workType, Method.Post);
        }

        /// <summary>
        /// Create Work Type
        /// </summary>
        /// <remarks>
        /// Creates a new work type for the business.
        /// </remarks>
        public Task<MyWorkTypeModel> CreateWorkTypeAsync(int businessId, MyWorkTypeModel workType, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyWorkTypeModel,MyWorkTypeModel>($"/business/{businessId}/worktype", workType, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Work Type by ID
        /// </summary>
        /// <remarks>
        /// Gets the work type with the specified ID.
        /// </remarks>
        public MyWorkTypeModel GetWorkTypeById(int businessId, int id)
        {
            return ApiRequest<MyWorkTypeModel>($"/business/{businessId}/worktype/{id}", Method.Get);
        }

        /// <summary>
        /// Get Work Type by ID
        /// </summary>
        /// <remarks>
        /// Gets the work type with the specified ID.
        /// </remarks>
        public Task<MyWorkTypeModel> GetWorkTypeByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyWorkTypeModel>($"/business/{businessId}/worktype/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Work Type
        /// </summary>
        /// <remarks>
        /// Updates the work type with the specified ID.
        /// </remarks>
        public MyWorkTypeModel UpdateWorkType(int businessId, int id, MyWorkTypeModel workType)
        {
            return ApiRequest<MyWorkTypeModel,MyWorkTypeModel>($"/business/{businessId}/worktype/{id}", workType, Method.Put);
        }

        /// <summary>
        /// Update Work Type
        /// </summary>
        /// <remarks>
        /// Updates the work type with the specified ID.
        /// </remarks>
        public Task<MyWorkTypeModel> UpdateWorkTypeAsync(int businessId, int id, MyWorkTypeModel workType, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyWorkTypeModel,MyWorkTypeModel>($"/business/{businessId}/worktype/{id}", workType, Method.Put, cancellationToken);
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
