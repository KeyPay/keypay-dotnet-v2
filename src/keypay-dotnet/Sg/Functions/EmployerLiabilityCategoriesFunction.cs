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
using KeyPayV2.Sg.Models.EmployerLiabilityCategories;

namespace KeyPayV2.Sg.Functions
{
    public interface IEmployerLiabilityCategoriesFunction
    {
        List<EmployerLiabilityCategoryModel> ListEmployerLiabilityCategories(int businessId, ODataQuery oDataQuery = null);
        Task<List<EmployerLiabilityCategoryModel>> ListEmployerLiabilityCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void CreateEmployerLiabilityCategory(int businessId, EmployerLiabilityCategoryModel employerLiabilityCategory);
        Task CreateEmployerLiabilityCategoryAsync(int businessId, EmployerLiabilityCategoryModel employerLiabilityCategory, CancellationToken cancellationToken = default);
        EmployerLiabilityCategoryModel GetEmployerLiabilityCategory(int businessId, int id);
        Task<EmployerLiabilityCategoryModel> GetEmployerLiabilityCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void UpdateEmployerLiabilityCategory(int businessId, int id, EmployerLiabilityCategoryModel employerLiabilityCategory);
        Task UpdateEmployerLiabilityCategoryAsync(int businessId, int id, EmployerLiabilityCategoryModel employerLiabilityCategory, CancellationToken cancellationToken = default);
        void DeleteEmployerLiabilityCategory(int businessId, int id);
        Task DeleteEmployerLiabilityCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default);
    }
    public class EmployerLiabilityCategoriesFunction : BaseFunction, IEmployerLiabilityCategoriesFunction
    {
        public EmployerLiabilityCategoriesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Employer Liability Categories
        /// </summary>
        /// <remarks>
        /// Lists all the employer liability categories for this business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<EmployerLiabilityCategoryModel> ListEmployerLiabilityCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<EmployerLiabilityCategoryModel>>($"/business/{businessId}/employerliabilitycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employer Liability Categories
        /// </summary>
        /// <remarks>
        /// Lists all the employer liability categories for this business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<EmployerLiabilityCategoryModel>> ListEmployerLiabilityCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployerLiabilityCategoryModel>>($"/business/{businessId}/employerliabilitycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Creates an employer liability category for the business.
        /// </remarks>
        public void CreateEmployerLiabilityCategory(int businessId, EmployerLiabilityCategoryModel employerLiabilityCategory)
        {
            ApiRequest($"/business/{businessId}/employerliabilitycategory", employerLiabilityCategory, Method.Post);
        }

        /// <summary>
        /// Create Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Creates an employer liability category for the business.
        /// </remarks>
        public Task CreateEmployerLiabilityCategoryAsync(int businessId, EmployerLiabilityCategoryModel employerLiabilityCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employerliabilitycategory", employerLiabilityCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Gets the employer liability category with the specified ID.
        /// </remarks>
        public EmployerLiabilityCategoryModel GetEmployerLiabilityCategory(int businessId, int id)
        {
            return ApiRequest<EmployerLiabilityCategoryModel>($"/business/{businessId}/employerliabilitycategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Gets the employer liability category with the specified ID.
        /// </remarks>
        public Task<EmployerLiabilityCategoryModel> GetEmployerLiabilityCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployerLiabilityCategoryModel>($"/business/{businessId}/employerliabilitycategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Updates the employer liability category with the specified ID.
        /// </remarks>
        public void UpdateEmployerLiabilityCategory(int businessId, int id, EmployerLiabilityCategoryModel employerLiabilityCategory)
        {
            ApiRequest($"/business/{businessId}/employerliabilitycategory/{id}", employerLiabilityCategory, Method.Put);
        }

        /// <summary>
        /// Update Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Updates the employer liability category with the specified ID.
        /// </remarks>
        public Task UpdateEmployerLiabilityCategoryAsync(int businessId, int id, EmployerLiabilityCategoryModel employerLiabilityCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employerliabilitycategory/{id}", employerLiabilityCategory, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Deletes the employer liability category with the specified ID.
        /// </remarks>
        public void DeleteEmployerLiabilityCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/employerliabilitycategory/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Deletes the employer liability category with the specified ID.
        /// </remarks>
        public Task DeleteEmployerLiabilityCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employerliabilitycategory/{id}", Method.Delete, cancellationToken);
        }
    }
}
