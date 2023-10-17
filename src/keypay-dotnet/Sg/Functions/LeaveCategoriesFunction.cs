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
using KeyPayV2.Sg.Models.LeaveCategories;

namespace KeyPayV2.Sg.Functions
{
    public interface ILeaveCategoriesFunction
    {
        List<SgLeaveCategoryModel> ListLeaveCategories(int businessId, ODataQuery oDataQuery = null);
        Task<List<SgLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        SgLeaveCategoryModel CreateLeaveCategory(int businessId, SgLeaveCategoryModel leaveCategory);
        Task<SgLeaveCategoryModel> CreateLeaveCategoryAsync(int businessId, SgLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default);
        SgLeaveCategoryModel GetLeaveCategoryById(int businessId, int id);
        Task<SgLeaveCategoryModel> GetLeaveCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        SgLeaveCategoryModel UpdateLeaveCategory(int businessId, int id, SgLeaveCategoryModel leaveCategory);
        Task<SgLeaveCategoryModel> UpdateLeaveCategoryAsync(int businessId, int id, SgLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default);
        void DeleteLeaveCategory(int businessId, int id);
        Task DeleteLeaveCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class LeaveCategoriesFunction : BaseFunction, ILeaveCategoriesFunction
    {
        public LeaveCategoriesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<SgLeaveCategoryModel> ListLeaveCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<SgLeaveCategoryModel>>($"/business/{businessId}/leavecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<SgLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgLeaveCategoryModel>>($"/business/{businessId}/leavecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Leave Category
        /// </summary>
        /// <remarks>
        /// Creates a new leave category for the business.
        /// </remarks>
        public SgLeaveCategoryModel CreateLeaveCategory(int businessId, SgLeaveCategoryModel leaveCategory)
        {
            return ApiRequest<SgLeaveCategoryModel,SgLeaveCategoryModel>($"/business/{businessId}/leavecategory", leaveCategory, Method.Post);
        }

        /// <summary>
        /// Create Leave Category
        /// </summary>
        /// <remarks>
        /// Creates a new leave category for the business.
        /// </remarks>
        public Task<SgLeaveCategoryModel> CreateLeaveCategoryAsync(int businessId, SgLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgLeaveCategoryModel,SgLeaveCategoryModel>($"/business/{businessId}/leavecategory", leaveCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the leave category with the specified ID.
        /// </remarks>
        public SgLeaveCategoryModel GetLeaveCategoryById(int businessId, int id)
        {
            return ApiRequest<SgLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Leave Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the leave category with the specified ID.
        /// </remarks>
        public Task<SgLeaveCategoryModel> GetLeaveCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Leave Category
        /// </summary>
        /// <remarks>
        /// Updates the leave category with the specified ID.
        /// </remarks>
        public SgLeaveCategoryModel UpdateLeaveCategory(int businessId, int id, SgLeaveCategoryModel leaveCategory)
        {
            return ApiRequest<SgLeaveCategoryModel,SgLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", leaveCategory, Method.Put);
        }

        /// <summary>
        /// Update Leave Category
        /// </summary>
        /// <remarks>
        /// Updates the leave category with the specified ID.
        /// </remarks>
        public Task<SgLeaveCategoryModel> UpdateLeaveCategoryAsync(int businessId, int id, SgLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgLeaveCategoryModel,SgLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", leaveCategory, Method.Put, cancellationToken);
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
