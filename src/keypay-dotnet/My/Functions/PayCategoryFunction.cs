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
using KeyPayV2.My.Models.PayCategory;

namespace KeyPayV2.My.Functions
{
    public interface IPayCategoryFunction
    {
        List<MyPayCategoryModel> ListPayCategories(int businessId, ODataQuery oDataQuery = null);
        Task<List<MyPayCategoryModel>> ListPayCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        MyPayCategoryModel CreatePayCategory(int businessId, MyPayCategoryModel payCategory);
        Task<MyPayCategoryModel> CreatePayCategoryAsync(int businessId, MyPayCategoryModel payCategory, CancellationToken cancellationToken = default);
        MyPayCategoryModel GetPayCategoryById(int businessId, int id);
        Task<MyPayCategoryModel> GetPayCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        MyPayCategoryModel UpdatePayCategory(int businessId, int id, MyPayCategoryModel payCategory);
        Task<MyPayCategoryModel> UpdatePayCategoryAsync(int businessId, int id, MyPayCategoryModel payCategory, CancellationToken cancellationToken = default);
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
        public List<MyPayCategoryModel> ListPayCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<MyPayCategoryModel>>($"/business/{businessId}/paycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Pay Categories
        /// </summary>
        /// <remarks>
        /// Lists all the pay categories for the business
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<MyPayCategoryModel>> ListPayCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyPayCategoryModel>>($"/business/{businessId}/paycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pay Category
        /// </summary>
        /// <remarks>
        /// Creates a new pay category for the business.
        /// </remarks>
        public MyPayCategoryModel CreatePayCategory(int businessId, MyPayCategoryModel payCategory)
        {
            return ApiRequest<MyPayCategoryModel,MyPayCategoryModel>($"/business/{businessId}/paycategory", payCategory, Method.Post);
        }

        /// <summary>
        /// Create Pay Category
        /// </summary>
        /// <remarks>
        /// Creates a new pay category for the business.
        /// </remarks>
        public Task<MyPayCategoryModel> CreatePayCategoryAsync(int businessId, MyPayCategoryModel payCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyPayCategoryModel,MyPayCategoryModel>($"/business/{businessId}/paycategory", payCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pay Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay category with the specified ID.
        /// </remarks>
        public MyPayCategoryModel GetPayCategoryById(int businessId, int id)
        {
            return ApiRequest<MyPayCategoryModel>($"/business/{businessId}/paycategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Pay Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay category with the specified ID.
        /// </remarks>
        public Task<MyPayCategoryModel> GetPayCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyPayCategoryModel>($"/business/{businessId}/paycategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Pay Category
        /// </summary>
        /// <remarks>
        /// Updates the pay category with the specified ID.
        /// </remarks>
        public MyPayCategoryModel UpdatePayCategory(int businessId, int id, MyPayCategoryModel payCategory)
        {
            return ApiRequest<MyPayCategoryModel,MyPayCategoryModel>($"/business/{businessId}/paycategory/{id}", payCategory, Method.Put);
        }

        /// <summary>
        /// Update Pay Category
        /// </summary>
        /// <remarks>
        /// Updates the pay category with the specified ID.
        /// </remarks>
        public Task<MyPayCategoryModel> UpdatePayCategoryAsync(int businessId, int id, MyPayCategoryModel payCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyPayCategoryModel,MyPayCategoryModel>($"/business/{businessId}/paycategory/{id}", payCategory, Method.Put, cancellationToken);
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
