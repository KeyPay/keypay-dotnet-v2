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
using KeyPayV2.Nz.Models.EmployingEntities;

namespace KeyPayV2.Nz.Functions
{
    public interface IEmployingEntitiesFunction
    {
        List<NzEmployingEntityModel> ListEmployingEntities(int businessId, ODataQuery oDataQuery = null);
        Task<List<NzEmployingEntityModel>> ListEmployingEntitiesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        NzEmployingEntityModel CreateEmployingEntity(int businessId, NzEmployingEntityModel employingEntity);
        Task<NzEmployingEntityModel> CreateEmployingEntityAsync(int businessId, NzEmployingEntityModel employingEntity, CancellationToken cancellationToken = default);
        NzEmployingEntityModel GetEmployingEntityById(int businessId, int id);
        Task<NzEmployingEntityModel> GetEmployingEntityByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        NzEmployingEntityModel UpdateEmployingEntity(int businessId, int id, NzEmployingEntityModel employingEntity);
        Task<NzEmployingEntityModel> UpdateEmployingEntityAsync(int businessId, int id, NzEmployingEntityModel employingEntity, CancellationToken cancellationToken = default);
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
        public List<NzEmployingEntityModel> ListEmployingEntities(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzEmployingEntityModel>>($"/business/{businessId}/employingentity{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employing Entities
        /// </summary>
        /// <remarks>
        /// Lists all the employing entities for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzEmployingEntityModel>> ListEmployingEntitiesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzEmployingEntityModel>>($"/business/{businessId}/employingentity{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employing Entity
        /// </summary>
        /// <remarks>
        /// Creates a new employing entity for the business.
        /// </remarks>
        public NzEmployingEntityModel CreateEmployingEntity(int businessId, NzEmployingEntityModel employingEntity)
        {
            return ApiRequest<NzEmployingEntityModel,NzEmployingEntityModel>($"/business/{businessId}/employingentity", employingEntity, Method.Post);
        }

        /// <summary>
        /// Create Employing Entity
        /// </summary>
        /// <remarks>
        /// Creates a new employing entity for the business.
        /// </remarks>
        public Task<NzEmployingEntityModel> CreateEmployingEntityAsync(int businessId, NzEmployingEntityModel employingEntity, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzEmployingEntityModel,NzEmployingEntityModel>($"/business/{businessId}/employingentity", employingEntity, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employing Entity By ID
        /// </summary>
        /// <remarks>
        /// Gets the employing entity with the specified ID.
        /// </remarks>
        public NzEmployingEntityModel GetEmployingEntityById(int businessId, int id)
        {
            return ApiRequest<NzEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employing Entity By ID
        /// </summary>
        /// <remarks>
        /// Gets the employing entity with the specified ID.
        /// </remarks>
        public Task<NzEmployingEntityModel> GetEmployingEntityByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employing Entity
        /// </summary>
        /// <remarks>
        /// Updates the employing entity with the specified ID.
        /// </remarks>
        public NzEmployingEntityModel UpdateEmployingEntity(int businessId, int id, NzEmployingEntityModel employingEntity)
        {
            return ApiRequest<NzEmployingEntityModel,NzEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", employingEntity, Method.Put);
        }

        /// <summary>
        /// Update Employing Entity
        /// </summary>
        /// <remarks>
        /// Updates the employing entity with the specified ID.
        /// </remarks>
        public Task<NzEmployingEntityModel> UpdateEmployingEntityAsync(int businessId, int id, NzEmployingEntityModel employingEntity, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzEmployingEntityModel,NzEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", employingEntity, Method.Put, cancellationToken);
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
