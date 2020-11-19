using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.DeductionCategories;

namespace KeyPayV2.Sg.Functions
{
    public class DeductionCategoriesFunction : BaseFunction
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
            return ApiRequest<List<SgDeductionCategoryModel>>($"/business/{businessId}/deductioncategory{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Deduction Category
        /// </summary>
        /// <remarks>
        /// Creates a deduction category for the business.
        /// </remarks>
        public SgDeductionCategoryModel CreateDeductionCategory(int businessId, SgDeductionCategoryModel deductionCategory)
        {
            return ApiRequest<SgDeductionCategoryModel,SgDeductionCategoryModel>($"/business/{businessId}/deductioncategory", deductionCategory, Method.POST);
        }

        /// <summary>
        /// Get Deduction Category By ID
        /// </summary>
        /// <remarks>
        /// Gets the deduction category with the specified ID.
        /// </remarks>
        public SgDeductionCategoryModel GetDeductionCategoryById(int businessId, int id)
        {
            return ApiRequest<SgDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}");
        }

        /// <summary>
        /// Update Deduction Category
        /// </summary>
        /// <remarks>
        /// Updates the deduction category with the specified ID.
        /// </remarks>
        public SgDeductionCategoryModel UpdateDeductionCategory(int businessId, int id, SgDeductionCategoryModel deductionCategory)
        {
            return ApiRequest<SgDeductionCategoryModel,SgDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", deductionCategory, Method.PUT);
        }

        /// <summary>
        /// Delete Deduction Category
        /// </summary>
        /// <remarks>
        /// Deletes the deduction category with the specified ID.
        /// </remarks>
        public void DeleteDeductionCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/deductioncategory/{id}", Method.DELETE);
        }
    }
}
