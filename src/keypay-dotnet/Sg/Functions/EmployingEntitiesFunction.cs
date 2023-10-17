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
using KeyPayV2.Sg.Models.EmployingEntities;

namespace KeyPayV2.Sg.Functions
{
    public interface IEmployingEntitiesFunction
    {
        List<SgEmployingEntityModel> ListEmployingEntities(int businessId, ODataQuery oDataQuery = null);
        Task<List<SgEmployingEntityModel>> ListEmployingEntitiesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        SgEmployingEntityModel CreateEmployingEntity(int businessId, SgEmployingEntityModel employingEntity);
        Task<SgEmployingEntityModel> CreateEmployingEntityAsync(int businessId, SgEmployingEntityModel employingEntity, CancellationToken cancellationToken = default);
        SgEmployingEntityModel GetEmployingEntityById(int businessId, int id);
        Task<SgEmployingEntityModel> GetEmployingEntityByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        SgEmployingEntityModel UpdateEmployingEntity(int businessId, int id, SgEmployingEntityModel employingEntity);
        Task<SgEmployingEntityModel> UpdateEmployingEntityAsync(int businessId, int id, SgEmployingEntityModel employingEntity, CancellationToken cancellationToken = default);
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
        public List<SgEmployingEntityModel> ListEmployingEntities(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<SgEmployingEntityModel>>($"/business/{businessId}/employingentity{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employing Entities
        /// </summary>
        /// <remarks>
        /// Lists all the employing entities for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<SgEmployingEntityModel>> ListEmployingEntitiesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgEmployingEntityModel>>($"/business/{businessId}/employingentity{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employing Entity
        /// </summary>
        /// <remarks>
        /// Creates a new employing entity for the business.
        /// </remarks>
        public SgEmployingEntityModel CreateEmployingEntity(int businessId, SgEmployingEntityModel employingEntity)
        {
            return ApiRequest<SgEmployingEntityModel,SgEmployingEntityModel>($"/business/{businessId}/employingentity", employingEntity, Method.Post);
        }

        /// <summary>
        /// Create Employing Entity
        /// </summary>
        /// <remarks>
        /// Creates a new employing entity for the business.
        /// </remarks>
        public Task<SgEmployingEntityModel> CreateEmployingEntityAsync(int businessId, SgEmployingEntityModel employingEntity, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgEmployingEntityModel,SgEmployingEntityModel>($"/business/{businessId}/employingentity", employingEntity, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employing Entity By ID
        /// </summary>
        /// <remarks>
        /// Gets the employing entity with the specified ID.
        /// </remarks>
        public SgEmployingEntityModel GetEmployingEntityById(int businessId, int id)
        {
            return ApiRequest<SgEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employing Entity By ID
        /// </summary>
        /// <remarks>
        /// Gets the employing entity with the specified ID.
        /// </remarks>
        public Task<SgEmployingEntityModel> GetEmployingEntityByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employing Entity
        /// </summary>
        /// <remarks>
        /// Updates the employing entity with the specified ID.
        /// </remarks>
        public SgEmployingEntityModel UpdateEmployingEntity(int businessId, int id, SgEmployingEntityModel employingEntity)
        {
            return ApiRequest<SgEmployingEntityModel,SgEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", employingEntity, Method.Put);
        }

        /// <summary>
        /// Update Employing Entity
        /// </summary>
        /// <remarks>
        /// Updates the employing entity with the specified ID.
        /// </remarks>
        public Task<SgEmployingEntityModel> UpdateEmployingEntityAsync(int businessId, int id, SgEmployingEntityModel employingEntity, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgEmployingEntityModel,SgEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", employingEntity, Method.Put, cancellationToken);
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
