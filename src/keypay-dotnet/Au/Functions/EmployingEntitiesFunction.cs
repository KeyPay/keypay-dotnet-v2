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
using KeyPayV2.Au.Models.EmployingEntities;

namespace KeyPayV2.Au.Functions
{
    public interface IEmployingEntitiesFunction
    {
        List<AuEmployingEntityModel> ListEmployingEntities(int businessId, ODataQuery oDataQuery = null);
        Task<List<AuEmployingEntityModel>> ListEmployingEntitiesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        AuEmployingEntityModel CreateEmployingEntity(int businessId, AuEmployingEntityModel employingEntity);
        Task<AuEmployingEntityModel> CreateEmployingEntityAsync(int businessId, AuEmployingEntityModel employingEntity, CancellationToken cancellationToken = default);
        AuEmployingEntityModel GetEmployingEntityById(int businessId, int id);
        Task<AuEmployingEntityModel> GetEmployingEntityByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        AuEmployingEntityModel UpdateEmployingEntity(int businessId, int id, AuEmployingEntityModel employingEntity);
        Task<AuEmployingEntityModel> UpdateEmployingEntityAsync(int businessId, int id, AuEmployingEntityModel employingEntity, CancellationToken cancellationToken = default);
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
        public List<AuEmployingEntityModel> ListEmployingEntities(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<AuEmployingEntityModel>>($"/business/{businessId}/employingentity{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employing Entities
        /// </summary>
        /// <remarks>
        /// Lists all the employing entities for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<AuEmployingEntityModel>> ListEmployingEntitiesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuEmployingEntityModel>>($"/business/{businessId}/employingentity{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employing Entity
        /// </summary>
        /// <remarks>
        /// Creates a new employing entity for the business.
        /// </remarks>
        public AuEmployingEntityModel CreateEmployingEntity(int businessId, AuEmployingEntityModel employingEntity)
        {
            return ApiRequest<AuEmployingEntityModel,AuEmployingEntityModel>($"/business/{businessId}/employingentity", employingEntity, Method.Post);
        }

        /// <summary>
        /// Create Employing Entity
        /// </summary>
        /// <remarks>
        /// Creates a new employing entity for the business.
        /// </remarks>
        public Task<AuEmployingEntityModel> CreateEmployingEntityAsync(int businessId, AuEmployingEntityModel employingEntity, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuEmployingEntityModel,AuEmployingEntityModel>($"/business/{businessId}/employingentity", employingEntity, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employing Entity By ID
        /// </summary>
        /// <remarks>
        /// Gets the employing entity with the specified ID.
        /// </remarks>
        public AuEmployingEntityModel GetEmployingEntityById(int businessId, int id)
        {
            return ApiRequest<AuEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employing Entity By ID
        /// </summary>
        /// <remarks>
        /// Gets the employing entity with the specified ID.
        /// </remarks>
        public Task<AuEmployingEntityModel> GetEmployingEntityByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employing Entity
        /// </summary>
        /// <remarks>
        /// Updates the employing entity with the specified ID.
        /// </remarks>
        public AuEmployingEntityModel UpdateEmployingEntity(int businessId, int id, AuEmployingEntityModel employingEntity)
        {
            return ApiRequest<AuEmployingEntityModel,AuEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", employingEntity, Method.Put);
        }

        /// <summary>
        /// Update Employing Entity
        /// </summary>
        /// <remarks>
        /// Updates the employing entity with the specified ID.
        /// </remarks>
        public Task<AuEmployingEntityModel> UpdateEmployingEntityAsync(int businessId, int id, AuEmployingEntityModel employingEntity, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuEmployingEntityModel,AuEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", employingEntity, Method.Put, cancellationToken);
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
