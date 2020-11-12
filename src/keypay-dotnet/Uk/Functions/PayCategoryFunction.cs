using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.PayCategory;

namespace KeyPayV2.Uk.Functions
{
    public class PayCategoryFunction : BaseFunction
    {
        public PayCategoryFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Pay Categories
        /// </summary>
        /// <remarks>
        /// Lists all the pay categories for the business
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<UkPayCategoryModel> ListPayCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkPayCategoryModel>>($"/business/{businessId}/paycategory{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Pay Category
        /// </summary>
        /// <remarks>
        /// Creates a new pay category for the business.
        /// </remarks>
        public UkPayCategoryModel CreatePayCategory(int businessId, UkPayCategoryModel payCategory)
        {
            return ApiRequest<UkPayCategoryModel,UkPayCategoryModel>($"/business/{businessId}/paycategory", payCategory, Method.POST);
        }

        /// <summary>
        /// Get Pay Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay category with the specified ID.
        /// </remarks>
        public UkPayCategoryModel GetPayCategoryById(int businessId, int id)
        {
            return ApiRequest<UkPayCategoryModel>($"/business/{businessId}/paycategory/{id}");
        }

        /// <summary>
        /// Update Pay Category
        /// </summary>
        /// <remarks>
        /// Updates the pay category with the specified ID.
        /// </remarks>
        public UkPayCategoryModel UpdatePayCategory(int businessId, int id, UkPayCategoryModel payCategory)
        {
            return ApiRequest<UkPayCategoryModel,UkPayCategoryModel>($"/business/{businessId}/paycategory/{id}", payCategory, Method.PUT);
        }

        /// <summary>
        /// Delete Pay Category
        /// </summary>
        /// <remarks>
        /// Deletes the pay category with the specified ID.
        /// </remarks>
        public void DeletePayCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/paycategory/{id}", Method.DELETE);
        }
    }
}
