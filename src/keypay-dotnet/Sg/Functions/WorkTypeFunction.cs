using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;

namespace KeyPayV2.Sg.Functions
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
        public List<SgWorkTypeModel> ListWorkTypes(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<SgWorkTypeModel>>($"/business/{businessId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Work Type
        /// </summary>
        /// <remarks>
        /// Creates a new work type for the business.
        /// </remarks>
        public SgWorkTypeModel CreateWorkType(int businessId, SgWorkTypeModel workType)
        {
            return ApiRequest<SgWorkTypeModel,SgWorkTypeModel>($"/business/{businessId}/worktype", workType, Method.POST);
        }

        /// <summary>
        /// Get Work Type by ID
        /// </summary>
        /// <remarks>
        /// Gets the work type with the specified ID.
        /// </remarks>
        public SgWorkTypeModel GetWorkTypeById(int businessId, int id)
        {
            return ApiRequest<SgWorkTypeModel>($"/business/{businessId}/worktype/{id}");
        }

        /// <summary>
        /// Update Work Type
        /// </summary>
        /// <remarks>
        /// Updates the work type with the specified ID.
        /// </remarks>
        public SgWorkTypeModel UpdateWorkType(int businessId, int id, SgWorkTypeModel workType)
        {
            return ApiRequest<SgWorkTypeModel,SgWorkTypeModel>($"/business/{businessId}/worktype/{id}", workType, Method.PUT);
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
