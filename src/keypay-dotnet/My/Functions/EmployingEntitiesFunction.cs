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
using KeyPayV2.My.Models.EmployingEntities;

namespace KeyPayV2.My.Functions
{
    public interface IEmployingEntitiesFunction
    {
        List<MyEmployingEntityModel> ListEmployingEntities(int businessId, ODataQuery oDataQuery = null);
        Task<List<MyEmployingEntityModel>> ListEmployingEntitiesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        MyEmployingEntityModel CreateEmployingEntity(int businessId, MyEmployingEntityModel employingEntity);
        Task<MyEmployingEntityModel> CreateEmployingEntityAsync(int businessId, MyEmployingEntityModel employingEntity, CancellationToken cancellationToken = default);
        MyEmployingEntityModel GetEmployingEntityById(int businessId, int id);
        Task<MyEmployingEntityModel> GetEmployingEntityByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        MyEmployingEntityModel UpdateEmployingEntity(int businessId, int id, MyEmployingEntityModel employingEntity);
        Task<MyEmployingEntityModel> UpdateEmployingEntityAsync(int businessId, int id, MyEmployingEntityModel employingEntity, CancellationToken cancellationToken = default);
        void DeleteEmployingEntity(int businessId, int id);
        Task DeleteEmployingEntityAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class EmployingEntitiesFunction : BaseFunction, IEmployingEntitiesFunction
    {
        public EmployingEntitiesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Employing Entities
        /// </summary>
        /// <remarks>
        /// Lists all the employing entities for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<MyEmployingEntityModel> ListEmployingEntities(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<MyEmployingEntityModel>>($"/business/{businessId}/employingentity{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employing Entities
        /// </summary>
        /// <remarks>
        /// Lists all the employing entities for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<MyEmployingEntityModel>> ListEmployingEntitiesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyEmployingEntityModel>>($"/business/{businessId}/employingentity{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employing Entity
        /// </summary>
        /// <remarks>
        /// Creates a new employing entity for the business.
        /// </remarks>
        public MyEmployingEntityModel CreateEmployingEntity(int businessId, MyEmployingEntityModel employingEntity)
        {
            return ApiRequest<MyEmployingEntityModel,MyEmployingEntityModel>($"/business/{businessId}/employingentity", employingEntity, Method.Post);
        }

        /// <summary>
        /// Create Employing Entity
        /// </summary>
        /// <remarks>
        /// Creates a new employing entity for the business.
        /// </remarks>
        public Task<MyEmployingEntityModel> CreateEmployingEntityAsync(int businessId, MyEmployingEntityModel employingEntity, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEmployingEntityModel,MyEmployingEntityModel>($"/business/{businessId}/employingentity", employingEntity, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employing Entity By ID
        /// </summary>
        /// <remarks>
        /// Gets the employing entity with the specified ID.
        /// </remarks>
        public MyEmployingEntityModel GetEmployingEntityById(int businessId, int id)
        {
            return ApiRequest<MyEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employing Entity By ID
        /// </summary>
        /// <remarks>
        /// Gets the employing entity with the specified ID.
        /// </remarks>
        public Task<MyEmployingEntityModel> GetEmployingEntityByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employing Entity
        /// </summary>
        /// <remarks>
        /// Updates the employing entity with the specified ID.
        /// </remarks>
        public MyEmployingEntityModel UpdateEmployingEntity(int businessId, int id, MyEmployingEntityModel employingEntity)
        {
            return ApiRequest<MyEmployingEntityModel,MyEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", employingEntity, Method.Put);
        }

        /// <summary>
        /// Update Employing Entity
        /// </summary>
        /// <remarks>
        /// Updates the employing entity with the specified ID.
        /// </remarks>
        public Task<MyEmployingEntityModel> UpdateEmployingEntityAsync(int businessId, int id, MyEmployingEntityModel employingEntity, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEmployingEntityModel,MyEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", employingEntity, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employing Entity
        /// </summary>
        /// <remarks>
        /// Deletes the employing entity with the specified ID.
        /// </remarks>
        public void DeleteEmployingEntity(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/employingentity/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employing Entity
        /// </summary>
        /// <remarks>
        /// Deletes the employing entity with the specified ID.
        /// </remarks>
        public Task DeleteEmployingEntityAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employingentity/{id}", Method.Delete, cancellationToken);
        }
    }
}
