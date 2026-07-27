using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.DeductionCategories;

namespace KeyPayV2.Nz.Functions
{
    public interface IDeductionCategoriesFunction
    {
        List<NzDeductionCategoryModel> ListDeductionCategories(int businessId, ODataQuery oDataQuery = null);
        Task<List<NzDeductionCategoryModel>> ListDeductionCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        NzDeductionCategoryModel CreateDeductionCategory(int businessId, NzDeductionCategoryModel deductionCategory);
        Task<NzDeductionCategoryModel> CreateDeductionCategoryAsync(int businessId, NzDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default);
        NzDeductionCategoryModel GetDeductionCategoryById(int businessId, int id);
        Task<NzDeductionCategoryModel> GetDeductionCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        NzDeductionCategoryModel UpdateDeductionCategory(int businessId, int id, NzDeductionCategoryModel deductionCategory);
        Task<NzDeductionCategoryModel> UpdateDeductionCategoryAsync(int businessId, int id, NzDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default);
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
        public List<NzDeductionCategoryModel> ListDeductionCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzDeductionCategoryModel>>($"/business/{businessId}/deductioncategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Deduction Categories
        /// </summary>
        /// <remarks>
        /// Lists all the deduction categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzDeductionCategoryModel>> ListDeductionCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzDeductionCategoryModel>>($"/business/{businessId}/deductioncategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Deduction Category
        /// </summary>
        /// <remarks>
        /// Creates a deduction category for the business.
        /// </remarks>
        public NzDeductionCategoryModel CreateDeductionCategory(int businessId, NzDeductionCategoryModel deductionCategory)
        {
            return ApiRequest<NzDeductionCategoryModel,NzDeductionCategoryModel>($"/business/{businessId}/deductioncategory", deductionCategory, Method.Post);
        }

        /// <summary>
        /// Create Deduction Category
        /// </summary>
        /// <remarks>
        /// Creates a deduction category for the business.
        /// </remarks>
        public Task<NzDeductionCategoryModel> CreateDeductionCategoryAsync(int businessId, NzDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzDeductionCategoryModel,NzDeductionCategoryModel>($"/business/{businessId}/deductioncategory", deductionCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Deduction Category By ID
        /// </summary>
        /// <remarks>
        /// Gets the deduction category with the specified ID.
        /// </remarks>
        public NzDeductionCategoryModel GetDeductionCategoryById(int businessId, int id)
        {
            return ApiRequest<NzDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Deduction Category By ID
        /// </summary>
        /// <remarks>
        /// Gets the deduction category with the specified ID.
        /// </remarks>
        public Task<NzDeductionCategoryModel> GetDeductionCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Deduction Category
        /// </summary>
        /// <remarks>
        /// Updates the deduction category with the specified ID.
        /// </remarks>
        public NzDeductionCategoryModel UpdateDeductionCategory(int businessId, int id, NzDeductionCategoryModel deductionCategory)
        {
            return ApiRequest<NzDeductionCategoryModel,NzDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", deductionCategory, Method.Put);
        }

        /// <summary>
        /// Update Deduction Category
        /// </summary>
        /// <remarks>
        /// Updates the deduction category with the specified ID.
        /// </remarks>
        public Task<NzDeductionCategoryModel> UpdateDeductionCategoryAsync(int businessId, int id, NzDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzDeductionCategoryModel,NzDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", deductionCategory, Method.Put, cancellationToken);
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
