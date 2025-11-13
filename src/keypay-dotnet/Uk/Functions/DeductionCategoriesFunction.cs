using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.DeductionCategories;

namespace KeyPayV2.Uk.Functions
{
    public interface IDeductionCategoriesFunction
    {
        UkDeductionCategoryModel GetDeductionCategoryById(int businessId, int id);
        Task<UkDeductionCategoryModel> GetDeductionCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        UkDeductionCategoryModel UpdateDeductionCategory(int businessId, int id, UkDeductionCategoryModel deductionCategory);
        Task<UkDeductionCategoryModel> UpdateDeductionCategoryAsync(int businessId, int id, UkDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default);
        void DeleteDeductionCategory(int businessId, int id);
        Task DeleteDeductionCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default);
        List<UkDeductionCategoryModel> ListDeductionCategories(int businessId, ODataQuery oDataQuery = null);
        Task<List<UkDeductionCategoryModel>> ListDeductionCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        UkDeductionCategoryModel CreateDeductionCategory(int businessId, UkDeductionCategoryModel deductionCategory);
        Task<UkDeductionCategoryModel> CreateDeductionCategoryAsync(int businessId, UkDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default);
        PagedResultModel<UkDeductionCategoryModel> ListDeductionCategoriesWithPagination(int businessId, ODataQuery oDataQuery = null);
        Task<PagedResultModel<UkDeductionCategoryModel>> ListDeductionCategoriesWithPaginationAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        DeductionCategoryEditModel CreateImportDeductionCategories(int businessId, ImportDeductionCategoryModel importModel);
        Task<DeductionCategoryEditModel> CreateImportDeductionCategoriesAsync(int businessId, ImportDeductionCategoryModel importModel, CancellationToken cancellationToken = default);
    }
    public class DeductionCategoriesFunction : BaseFunction, IDeductionCategoriesFunction
    {
        public DeductionCategoriesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Deduction Category By ID
        /// </summary>
        /// <remarks>
        /// Gets the deduction category with the specified ID.
        /// </remarks>
        public UkDeductionCategoryModel GetDeductionCategoryById(int businessId, int id)
        {
            return ApiRequest<UkDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Deduction Category By ID
        /// </summary>
        /// <remarks>
        /// Gets the deduction category with the specified ID.
        /// </remarks>
        public Task<UkDeductionCategoryModel> GetDeductionCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Deduction Category
        /// </summary>
        /// <remarks>
        /// Updates the deduction category with the specified ID.
        /// </remarks>
        public UkDeductionCategoryModel UpdateDeductionCategory(int businessId, int id, UkDeductionCategoryModel deductionCategory)
        {
            return ApiRequest<UkDeductionCategoryModel,UkDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", deductionCategory, Method.Put);
        }

        /// <summary>
        /// Update Deduction Category
        /// </summary>
        /// <remarks>
        /// Updates the deduction category with the specified ID.
        /// </remarks>
        public Task<UkDeductionCategoryModel> UpdateDeductionCategoryAsync(int businessId, int id, UkDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkDeductionCategoryModel,UkDeductionCategoryModel>($"/business/{businessId}/deductioncategory/{id}", deductionCategory, Method.Put, cancellationToken);
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

        /// <summary>
        /// List Deduction Categories
        /// </summary>
        /// <remarks>
        /// Lists all the deduction categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<UkDeductionCategoryModel> ListDeductionCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkDeductionCategoryModel>>($"/business/{businessId}/deductioncategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Deduction Categories
        /// </summary>
        /// <remarks>
        /// Lists all the deduction categories for the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<UkDeductionCategoryModel>> ListDeductionCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkDeductionCategoryModel>>($"/business/{businessId}/deductioncategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Deduction Category
        /// </summary>
        /// <remarks>
        /// Creates a deduction category for the business.
        /// </remarks>
        public UkDeductionCategoryModel CreateDeductionCategory(int businessId, UkDeductionCategoryModel deductionCategory)
        {
            return ApiRequest<UkDeductionCategoryModel,UkDeductionCategoryModel>($"/business/{businessId}/deductioncategory", deductionCategory, Method.Post);
        }

        /// <summary>
        /// Create Deduction Category
        /// </summary>
        /// <remarks>
        /// Creates a deduction category for the business.
        /// </remarks>
        public Task<UkDeductionCategoryModel> CreateDeductionCategoryAsync(int businessId, UkDeductionCategoryModel deductionCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkDeductionCategoryModel,UkDeductionCategoryModel>($"/business/{businessId}/deductioncategory", deductionCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Deduction Categories with Pagination
        /// </summary>
        /// <remarks>
        /// Lists all the deduction categories for the business with pagination.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public PagedResultModel<UkDeductionCategoryModel> ListDeductionCategoriesWithPagination(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<PagedResultModel<UkDeductionCategoryModel>>($"/business/{businessId}/deductioncategory/paged{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Deduction Categories with Pagination
        /// </summary>
        /// <remarks>
        /// Lists all the deduction categories for the business with pagination.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<PagedResultModel<UkDeductionCategoryModel>> ListDeductionCategoriesWithPaginationAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PagedResultModel<UkDeductionCategoryModel>>($"/business/{businessId}/deductioncategory/paged{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Import Deduction Categories
        /// </summary>
        /// <remarks>
        /// Creates a new deduction category by importing from external data. The API validates the import model
        /// and maps it to the appropriate deduction category structure based on the deduction type.
        /// Deduction Types:
        /// - PreTax: Deducted before tax calculations (requires PensionImpact and NationalInsuranceImpact)
        /// - PostTax: Deducted after tax calculations (PensionImpact and NationalInsuranceImpact must be null)
        /// - PreCis: CIS deduction before tax (requires PensionImpact and NationalInsuranceImpact, MinimumWageDeductionImpact must be null)
        /// - PostCis: CIS deduction after tax (all impact fields must be null)
        /// Example requests:
        /// PostTax Deduction:
        /// ```json
        /// {
        ///   "name": "Union Dues",
        ///   "externalId": "UNION_001",
        ///   "deductionType": "PostTax",
        ///   "minimumWageDeductionImpact": "NoImpact",
        ///   "pensionImpact": null,
        ///   "nationalInsuranceImpact": null
        /// }
        /// ```
        /// PreTax Deduction:
        /// ```json
        /// {
        ///   "name": "Salary Sacrifice Pension",
        ///   "externalId": "PENSION_001",
        ///   "deductionType": "PreTax",
        ///   "minimumWageDeductionImpact": "ReduceMinimumWage",
        ///   "pensionImpact": "ReducesPensionableEarnings",
        ///   "nationalInsuranceImpact": "AffectsNationalInsurance"
        /// }
        /// ```
        /// PreCis Deduction:
        /// ```json
        /// {
        ///   "name": "CIS Materials Deduction",
        ///   "externalId": "CIS_PRE_001",
        ///   "deductionType": "PreCis",
        ///   "minimumWageDeductionImpact": null,
        ///   "pensionImpact": "NoImpactOnPensionableEarnings",
        ///   "nationalInsuranceImpact": "NoImpactOnNationalInsurance"
        /// }
        /// ```
        /// PostCis Deduction:
        /// ```json
        /// {
        ///   "name": "CIS Labour Deduction",
        ///   "externalId": "CIS_POST_001",
        ///   "deductionType": "PostCis",
        ///   "minimumWageDeductionImpact": null,
        ///   "pensionImpact": null,
        ///   "nationalInsuranceImpact": null
        /// }
        /// ```
        /// Validation Rules:
        /// - name: Required, cannot be empty
        /// - deductionType: Must be a valid enum value
        /// - minimumWageDeductionImpact: Required for non-CIS types (PreTax, PostTax), must be null for CIS types (PreCis, PostCis)
        /// - pensionImpact: Required for PreTax types (PreTax, PreCis), must be null for PostTax types (PostTax, PostCis)
        /// - nationalInsuranceImpact: Required for PreTax types (PreTax, PreCis), must be null for PostTax types (PostTax, PostCis)
        /// - externalId: Optional external reference identifier
        /// On success, returns the mapped DeductionCategoryEditModel with appropriate CIS type and tax exempt flags set.
        /// On validation failure, returns 400 Bad Request with detailed validation errors.
        /// </remarks>
        public DeductionCategoryEditModel CreateImportDeductionCategories(int businessId, ImportDeductionCategoryModel importModel)
        {
            return ApiRequest<DeductionCategoryEditModel,ImportDeductionCategoryModel>($"/business/{businessId}/import/deduction-categories", importModel, Method.Post);
        }

        /// <summary>
        /// Create Import Deduction Categories
        /// </summary>
        /// <remarks>
        /// Creates a new deduction category by importing from external data. The API validates the import model
        /// and maps it to the appropriate deduction category structure based on the deduction type.
        /// Deduction Types:
        /// - PreTax: Deducted before tax calculations (requires PensionImpact and NationalInsuranceImpact)
        /// - PostTax: Deducted after tax calculations (PensionImpact and NationalInsuranceImpact must be null)
        /// - PreCis: CIS deduction before tax (requires PensionImpact and NationalInsuranceImpact, MinimumWageDeductionImpact must be null)
        /// - PostCis: CIS deduction after tax (all impact fields must be null)
        /// Example requests:
        /// PostTax Deduction:
        /// ```json
        /// {
        ///   "name": "Union Dues",
        ///   "externalId": "UNION_001",
        ///   "deductionType": "PostTax",
        ///   "minimumWageDeductionImpact": "NoImpact",
        ///   "pensionImpact": null,
        ///   "nationalInsuranceImpact": null
        /// }
        /// ```
        /// PreTax Deduction:
        /// ```json
        /// {
        ///   "name": "Salary Sacrifice Pension",
        ///   "externalId": "PENSION_001",
        ///   "deductionType": "PreTax",
        ///   "minimumWageDeductionImpact": "ReduceMinimumWage",
        ///   "pensionImpact": "ReducesPensionableEarnings",
        ///   "nationalInsuranceImpact": "AffectsNationalInsurance"
        /// }
        /// ```
        /// PreCis Deduction:
        /// ```json
        /// {
        ///   "name": "CIS Materials Deduction",
        ///   "externalId": "CIS_PRE_001",
        ///   "deductionType": "PreCis",
        ///   "minimumWageDeductionImpact": null,
        ///   "pensionImpact": "NoImpactOnPensionableEarnings",
        ///   "nationalInsuranceImpact": "NoImpactOnNationalInsurance"
        /// }
        /// ```
        /// PostCis Deduction:
        /// ```json
        /// {
        ///   "name": "CIS Labour Deduction",
        ///   "externalId": "CIS_POST_001",
        ///   "deductionType": "PostCis",
        ///   "minimumWageDeductionImpact": null,
        ///   "pensionImpact": null,
        ///   "nationalInsuranceImpact": null
        /// }
        /// ```
        /// Validation Rules:
        /// - name: Required, cannot be empty
        /// - deductionType: Must be a valid enum value
        /// - minimumWageDeductionImpact: Required for non-CIS types (PreTax, PostTax), must be null for CIS types (PreCis, PostCis)
        /// - pensionImpact: Required for PreTax types (PreTax, PreCis), must be null for PostTax types (PostTax, PostCis)
        /// - nationalInsuranceImpact: Required for PreTax types (PreTax, PreCis), must be null for PostTax types (PostTax, PostCis)
        /// - externalId: Optional external reference identifier
        /// On success, returns the mapped DeductionCategoryEditModel with appropriate CIS type and tax exempt flags set.
        /// On validation failure, returns 400 Bad Request with detailed validation errors.
        /// </remarks>
        public Task<DeductionCategoryEditModel> CreateImportDeductionCategoriesAsync(int businessId, ImportDeductionCategoryModel importModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DeductionCategoryEditModel,ImportDeductionCategoryModel>($"/business/{businessId}/import/deduction-categories", importModel, Method.Post, cancellationToken);
        }
    }
}
