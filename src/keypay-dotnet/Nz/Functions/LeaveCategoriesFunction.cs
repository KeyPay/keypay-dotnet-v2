using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.LeaveCategories;

namespace KeyPayV2.Nz.Functions
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
        public List<NzLeaveCategoryModel> ListLeaveCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzLeaveCategoryModel>>($"/business/{businessId}/leavecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzLeaveCategoryModel>>($"/business/{businessId}/leavecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Leave Category
        /// </summary>
        /// <remarks>
        /// Creates a new leave category for the business.
        /// </remarks>
        public NzLeaveCategoryModel CreateLeaveCategory(int businessId, NzLeaveCategoryModel leaveCategory)
        {
            return ApiRequest<NzLeaveCategoryModel,NzLeaveCategoryModel>($"/business/{businessId}/leavecategory", leaveCategory, Method.Post);
        }

        /// <summary>
        /// Create Leave Category
        /// </summary>
        /// <remarks>
        /// Creates a new leave category for the business.
        /// </remarks>
        public Task<NzLeaveCategoryModel> CreateLeaveCategoryAsync(int businessId, NzLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzLeaveCategoryModel,NzLeaveCategoryModel>($"/business/{businessId}/leavecategory", leaveCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the leave category with the specified ID.
        /// </remarks>
        public NzLeaveCategoryModel GetLeaveCategoryById(int businessId, int id)
        {
            return ApiRequest<NzLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Leave Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the leave category with the specified ID.
        /// </remarks>
        public Task<NzLeaveCategoryModel> GetLeaveCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Leave Category
        /// </summary>
        /// <remarks>
        /// Updates the leave category with the specified ID.
        /// </remarks>
        public NzLeaveCategoryModel UpdateLeaveCategory(int businessId, int id, NzLeaveCategoryModel leaveCategory)
        {
            return ApiRequest<NzLeaveCategoryModel,NzLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", leaveCategory, Method.Put);
        }

        /// <summary>
        /// Update Leave Category
        /// </summary>
        /// <remarks>
        /// Updates the leave category with the specified ID.
        /// </remarks>
        public Task<NzLeaveCategoryModel> UpdateLeaveCategoryAsync(int businessId, int id, NzLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzLeaveCategoryModel,NzLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", leaveCategory, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Leave Category
        /// </summary>
        /// <remarks>
        /// Deletes the leave category with the specified ID.
        /// </remarks>
        public void DeleteLeaveCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/leavecategory/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Leave Category
        /// </summary>
        /// <remarks>
        /// Deletes the leave category with the specified ID.
        /// </remarks>
        public Task DeleteLeaveCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/leavecategory/{id}", Method.Delete, cancellationToken);
        }
    }
}
