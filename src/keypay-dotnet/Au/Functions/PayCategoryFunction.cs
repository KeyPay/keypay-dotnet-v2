using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.PayCategory;

namespace KeyPayV2.Au.Functions
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
        public List<AuPayCategoryModel> ListPayCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<AuPayCategoryModel>>($"/business/{businessId}/paycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
        }

        /// <summary>
        /// List Pay Categories
        /// </summary>
        /// <remarks>
        /// Lists all the pay categories for the business
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<AuPayCategoryModel>> ListPayCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuPayCategoryModel>>($"/business/{businessId}/paycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Pay Category
        /// </summary>
        /// <remarks>
        /// Creates a new pay category for the business.
        /// </remarks>
        public AuPayCategoryModel CreatePayCategory(int businessId, AuPayCategoryModel payCategory)
        {
            return ApiRequest<AuPayCategoryModel,AuPayCategoryModel>($"/business/{businessId}/paycategory", payCategory, Method.POST);
        }

        /// <summary>
        /// Create Pay Category
        /// </summary>
        /// <remarks>
        /// Creates a new pay category for the business.
        /// </remarks>
        public Task<AuPayCategoryModel> CreatePayCategoryAsync(int businessId, AuPayCategoryModel payCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuPayCategoryModel,AuPayCategoryModel>($"/business/{businessId}/paycategory", payCategory, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Pay Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay category with the specified ID.
        /// </remarks>
        public AuPayCategoryModel GetPayCategoryById(int businessId, int id)
        {
            return ApiRequest<AuPayCategoryModel>($"/business/{businessId}/paycategory/{id}", Method.GET);
        }

        /// <summary>
        /// Get Pay Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay category with the specified ID.
        /// </remarks>
        public Task<AuPayCategoryModel> GetPayCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuPayCategoryModel>($"/business/{businessId}/paycategory/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Pay Category
        /// </summary>
        /// <remarks>
        /// Updates the pay category with the specified ID.
        /// </remarks>
        public AuPayCategoryModel UpdatePayCategory(int businessId, int id, AuPayCategoryModel payCategory)
        {
            return ApiRequest<AuPayCategoryModel,AuPayCategoryModel>($"/business/{businessId}/paycategory/{id}", payCategory, Method.PUT);
        }

        /// <summary>
        /// Update Pay Category
        /// </summary>
        /// <remarks>
        /// Updates the pay category with the specified ID.
        /// </remarks>
        public Task<AuPayCategoryModel> UpdatePayCategoryAsync(int businessId, int id, AuPayCategoryModel payCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuPayCategoryModel,AuPayCategoryModel>($"/business/{businessId}/paycategory/{id}", payCategory, Method.PUT, cancellationToken);
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
