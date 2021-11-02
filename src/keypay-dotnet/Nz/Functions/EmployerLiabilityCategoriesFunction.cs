using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.EmployerLiabilityCategories;

namespace KeyPayV2.Nz.Functions
{
    public class EmployerLiabilityCategoriesFunction : BaseFunction
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
            return ApiRequest<List<EmployerLiabilityCategoryModel>>($"/business/{businessId}/employerliabilitycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
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
            return ApiRequestAsync<List<EmployerLiabilityCategoryModel>>($"/business/{businessId}/employerliabilitycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Creates an employer liability category for the business.
        /// </remarks>
        public void CreateEmployerLiabilityCategory(int businessId, EmployerLiabilityCategoryModel employerLiabilityCategory)
        {
            ApiRequest($"/business/{businessId}/employerliabilitycategory", employerLiabilityCategory, Method.POST);
        }

        /// <summary>
        /// Create Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Creates an employer liability category for the business.
        /// </remarks>
        public Task CreateEmployerLiabilityCategoryAsync(int businessId, EmployerLiabilityCategoryModel employerLiabilityCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employerliabilitycategory", employerLiabilityCategory, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Gets the employer liability category with the specified ID.
        /// </remarks>
        public EmployerLiabilityCategoryModel GetEmployerLiabilityCategory(int businessId, int id)
        {
            return ApiRequest<EmployerLiabilityCategoryModel>($"/business/{businessId}/employerliabilitycategory/{id}", Method.GET);
        }

        /// <summary>
        /// Get Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Gets the employer liability category with the specified ID.
        /// </remarks>
        public Task<EmployerLiabilityCategoryModel> GetEmployerLiabilityCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployerLiabilityCategoryModel>($"/business/{businessId}/employerliabilitycategory/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Updates the employer liability category with the specified ID.
        /// </remarks>
        public void UpdateEmployerLiabilityCategory(int businessId, int id, EmployerLiabilityCategoryModel employerLiabilityCategory)
        {
            ApiRequest($"/business/{businessId}/employerliabilitycategory/{id}", employerLiabilityCategory, Method.PUT);
        }

        /// <summary>
        /// Update Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Updates the employer liability category with the specified ID.
        /// </remarks>
        public Task UpdateEmployerLiabilityCategoryAsync(int businessId, int id, EmployerLiabilityCategoryModel employerLiabilityCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employerliabilitycategory/{id}", employerLiabilityCategory, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Deletes the employer liability category with the specified ID.
        /// </remarks>
        public void DeleteEmployerLiabilityCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/employerliabilitycategory/{id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Deletes the employer liability category with the specified ID.
        /// </remarks>
        public Task DeleteEmployerLiabilityCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employerliabilitycategory/{id}", Method.DELETE, cancellationToken);
        }
    }
}
