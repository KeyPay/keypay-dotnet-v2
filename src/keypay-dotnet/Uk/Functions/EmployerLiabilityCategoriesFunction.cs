using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.EmployerLiabilityCategories;

namespace KeyPayV2.Uk.Functions
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
            return ApiRequest<List<EmployerLiabilityCategoryModel>>($"/business/{businessId}/employerliabilitycategory{ODataQuery.ToQueryString(oDataQuery, "?")}");
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
        /// Get Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Gets the employer liability category with the specified ID.
        /// </remarks>
        public EmployerLiabilityCategoryModel GetEmployerLiabilityCategory(int businessId, int id)
        {
            return ApiRequest<EmployerLiabilityCategoryModel>($"/business/{businessId}/employerliabilitycategory/{id}");
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
        /// Delete Employer Liability Category
        /// </summary>
        /// <remarks>
        /// Deletes the employer liability category with the specified ID.
        /// </remarks>
        public void DeleteEmployerLiabilityCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/employerliabilitycategory/{id}", Method.DELETE);
        }
    }
}
