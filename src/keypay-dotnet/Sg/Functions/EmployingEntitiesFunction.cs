using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.EmployingEntities;

namespace KeyPayV2.Sg.Functions
{
    public class EmployingEntitiesFunction : BaseFunction
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
            return ApiRequest<List<SgEmployingEntityModel>>($"/business/{businessId}/employingentity{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Employing Entity
        /// </summary>
        /// <remarks>
        /// Creates a new employing entity for the business.
        /// </remarks>
        public SgEmployingEntityModel CreateEmployingEntity(int businessId, SgEmployingEntityModel employingEntity)
        {
            return ApiRequest<SgEmployingEntityModel,SgEmployingEntityModel>($"/business/{businessId}/employingentity", employingEntity, Method.POST);
        }

        /// <summary>
        /// Get Employing Entity By ID
        /// </summary>
        /// <remarks>
        /// Gets the employing entity with the specified ID.
        /// </remarks>
        public SgEmployingEntityModel GetEmployingEntityById(int businessId, int id)
        {
            return ApiRequest<SgEmployingEntityModel>($"/business/{businessId}/employingentity/{id}");
        }

        /// <summary>
        /// Update Employing Entity
        /// </summary>
        /// <remarks>
        /// Updates the employing entity with the specified ID.
        /// </remarks>
        public SgEmployingEntityModel UpdateEmployingEntity(int businessId, int id, SgEmployingEntityModel employingEntity)
        {
            return ApiRequest<SgEmployingEntityModel,SgEmployingEntityModel>($"/business/{businessId}/employingentity/{id}", employingEntity, Method.PUT);
        }

        /// <summary>
        /// Delete Employing Entity
        /// </summary>
        /// <remarks>
        /// Deletes the employing entity with the specified ID.
        /// </remarks>
        public void DeleteEmployingEntity(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/employingentity/{id}", Method.DELETE);
        }
    }
}
