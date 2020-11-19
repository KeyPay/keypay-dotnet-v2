using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.LeaveCategories;

namespace KeyPayV2.Uk.Functions
{
    public class LeaveCategoriesFunction : BaseFunction
    {
        public LeaveCategoriesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<LeaveCategoryModel> ListLeaveCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<LeaveCategoryModel>>($"/business/{businessId}/leavecategory{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Leave Category
        /// </summary>
        /// <remarks>
        /// Creates a new leave category for the business.
        /// </remarks>
        public LeaveCategoryModel CreateLeaveCategory(int businessId, LeaveCategoryModel leaveCategory)
        {
            return ApiRequest<LeaveCategoryModel,LeaveCategoryModel>($"/business/{businessId}/leavecategory", leaveCategory, Method.POST);
        }

        /// <summary>
        /// Get Leave Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the leave category with the specified ID.
        /// </remarks>
        public LeaveCategoryModel GetLeaveCategoryById(int businessId, int id)
        {
            return ApiRequest<LeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}");
        }

        /// <summary>
        /// Update Leave Category
        /// </summary>
        /// <remarks>
        /// Updates the leave category with the specified ID.
        /// </remarks>
        public LeaveCategoryModel UpdateLeaveCategory(int businessId, int id, LeaveCategoryModel leaveCategory)
        {
            return ApiRequest<LeaveCategoryModel,LeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", leaveCategory, Method.PUT);
        }

        /// <summary>
        /// Delete Leave Category
        /// </summary>
        /// <remarks>
        /// Deletes the leave category with the specified ID.
        /// </remarks>
        public void DeleteLeaveCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/leavecategory/{id}", Method.DELETE);
        }
    }
}
