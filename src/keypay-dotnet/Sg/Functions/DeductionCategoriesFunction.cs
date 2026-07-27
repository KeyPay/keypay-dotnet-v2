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
using KeyPayV2.Sg.Models.DeductionCategories;

namespace KeyPayV2.Sg.Functions
{
    public interface IDeductionCategoriesFunction
    {
        List<SgDeductionCategoryModel> ListDeductionCategories(int businessId, ODataQuery oDataQuery = null);
        Task<List<SgDeductionCategoryModel>> ListDeductionCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        SgDeductionCategoryModel CreateDeductionCategory(int businessId, SgDeductionCategoryModel deductionCategory);
        Task<SgDeductionCategoryModel> CreateDeductionCategoryAsync(int businessId, SgDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default);
        SgDeductionCategoryModel GetDeductionCategoryById(int businessId, int id);
        Task<SgDeductionCategoryModel> GetDeductionCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        SgDeductionCategoryModel UpdateDeductionCategory(int businessId, int id, SgDeductionCategoryModel deductionCategory);
        Task<SgDeductionCategoryModel> UpdateDeductionCategoryAsync(int businessId, int id, SgDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default);
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
        public List<SgDeductionCategoryModel> ListDeductionCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<SgDeductionCategoryModel>>($"/business/{businessId}/deductioncategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Deduction Categories
        /// </summary>
        /// <remarks>
        /// Lists all the deduction categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<SgDeductionCategoryModel>> ListDeductionCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgDeductionCategoryModel>>($"/business/{businessId}/deductioncategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Deduction Category
        /// </summary>
        /// <remarks>
        /// Creates a deduction category for the business.
        /// </remarks>
        public SgDeductionCategoryModel CreateDeductionCategory(int businessId, SgDeductionCategoryModel deductionCategory)
        {
            return ApiRequest<SgDeductionCategoryModel,SgDeductionCategoryModel>($"/business/{businessId}/deductioncategory", deductionCategory, Method.Post);
        }

        /// <summary>
        /// Create Deduction Category
        /// </summary>
        /// <remarks>
        /// Creates a deduction category for the business.
        /// </remarks>
        public Task<SgDeductionCategoryModel> CreateDeductionCategoryAsync(int businessId, SgDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgDeductionCategoryModel,SgDeductionCategoryModel>($"/business/{businessId}/deductioncategory", deductionCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Deduction Category By ID
        /// </summary>
        /// <remarks>
        /// Gets the deduction category with the specified ID.
        /// </remarks>
        public SgDeductionCategoryModel GetDeductionCategoryById(int businessId, int id)
        {
            return ApiRequest<SgDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Deduction Category By ID
        /// </summary>
        /// <remarks>
        /// Gets the deduction category with the specified ID.
        /// </remarks>
        public Task<SgDeductionCategoryModel> GetDeductionCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Deduction Category
        /// </summary>
        /// <remarks>
        /// Updates the deduction category with the specified ID.
        /// </remarks>
        public SgDeductionCategoryModel UpdateDeductionCategory(int businessId, int id, SgDeductionCategoryModel deductionCategory)
        {
            return ApiRequest<SgDeductionCategoryModel,SgDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", deductionCategory, Method.Put);
        }

        /// <summary>
        /// Update Deduction Category
        /// </summary>
        /// <remarks>
        /// Updates the deduction category with the specified ID.
        /// </remarks>
        public Task<SgDeductionCategoryModel> UpdateDeductionCategoryAsync(int businessId, int id, SgDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgDeductionCategoryModel,SgDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", deductionCategory, Method.Put, cancellationToken);
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
