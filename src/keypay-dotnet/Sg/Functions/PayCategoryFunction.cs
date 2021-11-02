using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.PayCategory;

namespace KeyPayV2.Sg.Functions
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
        public List<SgPayCategoryModel> ListPayCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<SgPayCategoryModel>>($"/business/{businessId}/paycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
        }

        /// <summary>
        /// List Pay Categories
        /// </summary>
        /// <remarks>
        /// Lists all the pay categories for the business
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<SgPayCategoryModel>> ListPayCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgPayCategoryModel>>($"/business/{businessId}/paycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Pay Category
        /// </summary>
        /// <remarks>
        /// Creates a new pay category for the business.
        /// </remarks>
        public SgPayCategoryModel CreatePayCategory(int businessId, SgPayCategoryModel payCategory)
        {
            return ApiRequest<SgPayCategoryModel,SgPayCategoryModel>($"/business/{businessId}/paycategory", payCategory, Method.POST);
        }

        /// <summary>
        /// Create Pay Category
        /// </summary>
        /// <remarks>
        /// Creates a new pay category for the business.
        /// </remarks>
        public Task<SgPayCategoryModel> CreatePayCategoryAsync(int businessId, SgPayCategoryModel payCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayCategoryModel,SgPayCategoryModel>($"/business/{businessId}/paycategory", payCategory, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Pay Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay category with the specified ID.
        /// </remarks>
        public SgPayCategoryModel GetPayCategoryById(int businessId, int id)
        {
            return ApiRequest<SgPayCategoryModel>($"/business/{businessId}/paycategory/{id}", Method.GET);
        }

        /// <summary>
        /// Get Pay Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay category with the specified ID.
        /// </remarks>
        public Task<SgPayCategoryModel> GetPayCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayCategoryModel>($"/business/{businessId}/paycategory/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Pay Category
        /// </summary>
        /// <remarks>
        /// Updates the pay category with the specified ID.
        /// </remarks>
        public SgPayCategoryModel UpdatePayCategory(int businessId, int id, SgPayCategoryModel payCategory)
        {
            return ApiRequest<SgPayCategoryModel,SgPayCategoryModel>($"/business/{businessId}/paycategory/{id}", payCategory, Method.PUT);
        }

        /// <summary>
        /// Update Pay Category
        /// </summary>
        /// <remarks>
        /// Updates the pay category with the specified ID.
        /// </remarks>
        public Task<SgPayCategoryModel> UpdatePayCategoryAsync(int businessId, int id, SgPayCategoryModel payCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayCategoryModel,SgPayCategoryModel>($"/business/{businessId}/paycategory/{id}", payCategory, Method.PUT, cancellationToken);
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

        /// <summary>
        /// Delete Pay Category
        /// </summary>
        /// <remarks>
        /// Deletes the pay category with the specified ID.
        /// </remarks>
        public Task DeletePayCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paycategory/{id}", Method.DELETE, cancellationToken);
        }
    }
}
