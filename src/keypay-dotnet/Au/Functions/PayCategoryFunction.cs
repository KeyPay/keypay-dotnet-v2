using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
    public interface IPayCategoryFunction
    {
        List<AuPayCategoryModel> ListPayCategories(int businessId, ODataQuery oDataQuery = null);
        Task<List<AuPayCategoryModel>> ListPayCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        AuPayCategoryModel CreatePayCategory(int businessId, AuPayCategoryModel payCategory);
        Task<AuPayCategoryModel> CreatePayCategoryAsync(int businessId, AuPayCategoryModel payCategory, CancellationToken cancellationToken = default);
        AuPayCategoryModel GetPayCategoryById(int businessId, int id);
        Task<AuPayCategoryModel> GetPayCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        AuPayCategoryModel UpdatePayCategory(int businessId, int id, AuPayCategoryModel payCategory);
        Task<AuPayCategoryModel> UpdatePayCategoryAsync(int businessId, int id, AuPayCategoryModel payCategory, CancellationToken cancellationToken = default);
        void DeletePayCategory(int businessId, int id);
        Task DeletePayCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class PayCategoryFunction : BaseFunction, IPayCategoryFunction
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
            return ApiRequest<List<AuPayCategoryModel>>($"/business/{businessId}/paycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
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
            return ApiRequestAsync<List<AuPayCategoryModel>>($"/business/{businessId}/paycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pay Category
        /// </summary>
        /// <remarks>
        /// Creates a new pay category for the business.
        /// </remarks>
        public AuPayCategoryModel CreatePayCategory(int businessId, AuPayCategoryModel payCategory)
        {
            return ApiRequest<AuPayCategoryModel,AuPayCategoryModel>($"/business/{businessId}/paycategory", payCategory, Method.Post);
        }

        /// <summary>
        /// Create Pay Category
        /// </summary>
        /// <remarks>
        /// Creates a new pay category for the business.
        /// </remarks>
        public Task<AuPayCategoryModel> CreatePayCategoryAsync(int businessId, AuPayCategoryModel payCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuPayCategoryModel,AuPayCategoryModel>($"/business/{businessId}/paycategory", payCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pay Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay category with the specified ID.
        /// </remarks>
        public AuPayCategoryModel GetPayCategoryById(int businessId, int id)
        {
            return ApiRequest<AuPayCategoryModel>($"/business/{businessId}/paycategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Pay Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay category with the specified ID.
        /// </remarks>
        public Task<AuPayCategoryModel> GetPayCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuPayCategoryModel>($"/business/{businessId}/paycategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Pay Category
        /// </summary>
        /// <remarks>
        /// Updates the pay category with the specified ID.
        /// </remarks>
        public AuPayCategoryModel UpdatePayCategory(int businessId, int id, AuPayCategoryModel payCategory)
        {
            return ApiRequest<AuPayCategoryModel,AuPayCategoryModel>($"/business/{businessId}/paycategory/{id}", payCategory, Method.Put);
        }

        /// <summary>
        /// Update Pay Category
        /// </summary>
        /// <remarks>
        /// Updates the pay category with the specified ID.
        /// </remarks>
        public Task<AuPayCategoryModel> UpdatePayCategoryAsync(int businessId, int id, AuPayCategoryModel payCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuPayCategoryModel,AuPayCategoryModel>($"/business/{businessId}/paycategory/{id}", payCategory, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Pay Category
        /// </summary>
        /// <remarks>
        /// Deletes the pay category with the specified ID.
        /// </remarks>
        public void DeletePayCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/paycategory/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Pay Category
        /// </summary>
        /// <remarks>
        /// Deletes the pay category with the specified ID.
        /// </remarks>
        public Task DeletePayCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paycategory/{id}", Method.Delete, cancellationToken);
        }
    }
}
