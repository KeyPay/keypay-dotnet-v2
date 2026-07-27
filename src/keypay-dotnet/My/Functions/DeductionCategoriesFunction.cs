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
using KeyPayV2.My.Models.DeductionCategories;

namespace KeyPayV2.My.Functions
{
    public interface IDeductionCategoriesFunction
    {
        List<MyDeductionCategoryModel> ListDeductionCategories(int businessId, ODataQuery oDataQuery = null);
        Task<List<MyDeductionCategoryModel>> ListDeductionCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        MyDeductionCategoryModel CreateDeductionCategory(int businessId, MyDeductionCategoryModel deductionCategory);
        Task<MyDeductionCategoryModel> CreateDeductionCategoryAsync(int businessId, MyDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default);
        MyDeductionCategoryModel GetDeductionCategoryById(int businessId, int id);
        Task<MyDeductionCategoryModel> GetDeductionCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        MyDeductionCategoryModel UpdateDeductionCategory(int businessId, int id, MyDeductionCategoryModel deductionCategory);
        Task<MyDeductionCategoryModel> UpdateDeductionCategoryAsync(int businessId, int id, MyDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default);
        void DeleteDeductionCategory(int businessId, int id);
        Task DeleteDeductionCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class DeductionCategoriesFunction : BaseFunction, IDeductionCategoriesFunction
    {
        public DeductionCategoriesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Deduction Categories
        /// </summary>
        /// <remarks>
        /// Lists all the deduction categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<MyDeductionCategoryModel> ListDeductionCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<MyDeductionCategoryModel>>($"/business/{businessId}/deductioncategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Deduction Categories
        /// </summary>
        /// <remarks>
        /// Lists all the deduction categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<MyDeductionCategoryModel>> ListDeductionCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyDeductionCategoryModel>>($"/business/{businessId}/deductioncategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Deduction Category
        /// </summary>
        /// <remarks>
        /// Creates a deduction category for the business.
        /// </remarks>
        public MyDeductionCategoryModel CreateDeductionCategory(int businessId, MyDeductionCategoryModel deductionCategory)
        {
            return ApiRequest<MyDeductionCategoryModel,MyDeductionCategoryModel>($"/business/{businessId}/deductioncategory", deductionCategory, Method.Post);
        }

        /// <summary>
        /// Create Deduction Category
        /// </summary>
        /// <remarks>
        /// Creates a deduction category for the business.
        /// </remarks>
        public Task<MyDeductionCategoryModel> CreateDeductionCategoryAsync(int businessId, MyDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyDeductionCategoryModel,MyDeductionCategoryModel>($"/business/{businessId}/deductioncategory", deductionCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Deduction Category By ID
        /// </summary>
        /// <remarks>
        /// Gets the deduction category with the specified ID.
        /// </remarks>
        public MyDeductionCategoryModel GetDeductionCategoryById(int businessId, int id)
        {
            return ApiRequest<MyDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Deduction Category By ID
        /// </summary>
        /// <remarks>
        /// Gets the deduction category with the specified ID.
        /// </remarks>
        public Task<MyDeductionCategoryModel> GetDeductionCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Deduction Category
        /// </summary>
        /// <remarks>
        /// Updates the deduction category with the specified ID.
        /// </remarks>
        public MyDeductionCategoryModel UpdateDeductionCategory(int businessId, int id, MyDeductionCategoryModel deductionCategory)
        {
            return ApiRequest<MyDeductionCategoryModel,MyDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", deductionCategory, Method.Put);
        }

        /// <summary>
        /// Update Deduction Category
        /// </summary>
        /// <remarks>
        /// Updates the deduction category with the specified ID.
        /// </remarks>
        public Task<MyDeductionCategoryModel> UpdateDeductionCategoryAsync(int businessId, int id, MyDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyDeductionCategoryModel,MyDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", deductionCategory, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Deduction Category
        /// </summary>
        /// <remarks>
        /// Deletes the deduction category with the specified ID.
        /// </remarks>
        public void DeleteDeductionCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/deductioncategory/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Deduction Category
        /// </summary>
        /// <remarks>
        /// Deletes the deduction category with the specified ID.
        /// </remarks>
        public Task DeleteDeductionCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/deductioncategory/{id}", Method.Delete, cancellationToken);
        }
    }
}
