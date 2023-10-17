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
using KeyPayV2.My.Models.LeaveCategories;

namespace KeyPayV2.My.Functions
{
    public interface ILeaveCategoriesFunction
    {
        List<MyLeaveCategoryModel> ListLeaveCategories(int businessId, ODataQuery oDataQuery = null);
        Task<List<MyLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        MyLeaveCategoryModel CreateLeaveCategory(int businessId, MyLeaveCategoryModel leaveCategory);
        Task<MyLeaveCategoryModel> CreateLeaveCategoryAsync(int businessId, MyLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default);
        MyLeaveCategoryModel GetLeaveCategoryById(int businessId, int id);
        Task<MyLeaveCategoryModel> GetLeaveCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        MyLeaveCategoryModel UpdateLeaveCategory(int businessId, int id, MyLeaveCategoryModel leaveCategory);
        Task<MyLeaveCategoryModel> UpdateLeaveCategoryAsync(int businessId, int id, MyLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default);
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
        public List<MyLeaveCategoryModel> ListLeaveCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<MyLeaveCategoryModel>>($"/business/{businessId}/leavecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<MyLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyLeaveCategoryModel>>($"/business/{businessId}/leavecategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Leave Category
        /// </summary>
        /// <remarks>
        /// Creates a new leave category for the business.
        /// </remarks>
        public MyLeaveCategoryModel CreateLeaveCategory(int businessId, MyLeaveCategoryModel leaveCategory)
        {
            return ApiRequest<MyLeaveCategoryModel,MyLeaveCategoryModel>($"/business/{businessId}/leavecategory", leaveCategory, Method.Post);
        }

        /// <summary>
        /// Create Leave Category
        /// </summary>
        /// <remarks>
        /// Creates a new leave category for the business.
        /// </remarks>
        public Task<MyLeaveCategoryModel> CreateLeaveCategoryAsync(int businessId, MyLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyLeaveCategoryModel,MyLeaveCategoryModel>($"/business/{businessId}/leavecategory", leaveCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the leave category with the specified ID.
        /// </remarks>
        public MyLeaveCategoryModel GetLeaveCategoryById(int businessId, int id)
        {
            return ApiRequest<MyLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Leave Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the leave category with the specified ID.
        /// </remarks>
        public Task<MyLeaveCategoryModel> GetLeaveCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Leave Category
        /// </summary>
        /// <remarks>
        /// Updates the leave category with the specified ID.
        /// </remarks>
        public MyLeaveCategoryModel UpdateLeaveCategory(int businessId, int id, MyLeaveCategoryModel leaveCategory)
        {
            return ApiRequest<MyLeaveCategoryModel,MyLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", leaveCategory, Method.Put);
        }

        /// <summary>
        /// Update Leave Category
        /// </summary>
        /// <remarks>
        /// Updates the leave category with the specified ID.
        /// </remarks>
        public Task<MyLeaveCategoryModel> UpdateLeaveCategoryAsync(int businessId, int id, MyLeaveCategoryModel leaveCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyLeaveCategoryModel,MyLeaveCategoryModel>($"/business/{businessId}/leavecategory/{id}", leaveCategory, Method.Put, cancellationToken);
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
