using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;

namespace KeyPayV2.Uk.Functions
{
    public class WorkTypeFunction : BaseFunction
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
            return ApiRequest<List<UkWorkTypeModel>>($"/business/{businessId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Work Type
        /// </summary>
        /// <remarks>
        /// Creates a new work type for the business.
        /// </remarks>
        public UkWorkTypeModel CreateWorkType(int businessId, UkWorkTypeModel workType)
        {
            return ApiRequest<UkWorkTypeModel,UkWorkTypeModel>($"/business/{businessId}/worktype", workType, Method.POST);
        }

        /// <summary>
        /// Get Work Type by ID
        /// </summary>
        /// <remarks>
        /// Gets the work type with the specified ID.
        /// </remarks>
        public UkWorkTypeModel GetWorkTypeById(int businessId, int id)
        {
            return ApiRequest<UkWorkTypeModel>($"/business/{businessId}/worktype/{id}");
        }

        /// <summary>
        /// Update Work Type
        /// </summary>
        /// <remarks>
        /// Updates the work type with the specified ID.
        /// </remarks>
        public UkWorkTypeModel UpdateWorkType(int businessId, int id, UkWorkTypeModel workType)
        {
            return ApiRequest<UkWorkTypeModel,UkWorkTypeModel>($"/business/{businessId}/worktype/{id}", workType, Method.PUT);
        }

        /// <summary>
        /// Delete Work Type
        /// </summary>
        /// <remarks>
        /// Deletes the work type with the specified ID.
        /// </remarks>
        public void DeleteWorkType(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/worktype/{id}", Method.DELETE);
        }
    }
}
