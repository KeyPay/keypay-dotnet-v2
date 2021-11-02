using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.BenefitCategory;

namespace KeyPayV2.Uk.Functions
{
    public class BenefitCategoryFunction : BaseFunction
    {
        public BenefitCategoryFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Benefit Categories
        /// </summary>
        /// <remarks>
        /// Lists the benefit categories
        /// </remarks>
        public List<UkBenefitCategoryReadModel> ListBenefitCategories(int businessId)
        {
            return ApiRequest<List<UkBenefitCategoryReadModel>>($"/business/{businessId}/benefitcategory", Method.GET);
        }

        /// <summary>
        /// List Benefit Categories
        /// </summary>
        /// <remarks>
        /// Lists the benefit categories
        /// </remarks>
        public Task<List<UkBenefitCategoryReadModel>> ListBenefitCategoriesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkBenefitCategoryReadModel>>($"/business/{businessId}/benefitcategory", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Benefit Category
        /// </summary>
        /// <remarks>
        /// Updates a benefit category
        /// </remarks>
        public UkUpdateBenefitCategoryResult UpdateBenefitCategory(int businessId, UkBenefitCategoryReadModel model)
        {
            return ApiRequest<UkUpdateBenefitCategoryResult,UkBenefitCategoryReadModel>($"/business/{businessId}/benefitcategory", model, Method.PUT);
        }

        /// <summary>
        /// Update Benefit Category
        /// </summary>
        /// <remarks>
        /// Updates a benefit category
        /// </remarks>
        public Task<UkUpdateBenefitCategoryResult> UpdateBenefitCategoryAsync(int businessId, UkBenefitCategoryReadModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUpdateBenefitCategoryResult,UkBenefitCategoryReadModel>($"/business/{businessId}/benefitcategory", model, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Create benefit category
        /// </summary>
        /// <remarks>
        /// Creates a new benefit category
        /// </remarks>
        public UkBenefitCategoryReadModel CreateBenefitCategory(int businessId, UkBenefitCategoryEditModel model)
        {
            return ApiRequest<UkBenefitCategoryReadModel,UkBenefitCategoryEditModel>($"/business/{businessId}/benefitcategory", model, Method.POST);
        }

        /// <summary>
        /// Create benefit category
        /// </summary>
        /// <remarks>
        /// Creates a new benefit category
        /// </remarks>
        public Task<UkBenefitCategoryReadModel> CreateBenefitCategoryAsync(int businessId, UkBenefitCategoryEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBenefitCategoryReadModel,UkBenefitCategoryEditModel>($"/business/{businessId}/benefitcategory", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Benefit Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the benefit category with the specified ID
        /// </remarks>
        public UkBenefitCategoryReadModel GetBenefitCategoryById(int businessId, int id)
        {
            return ApiRequest<UkBenefitCategoryReadModel>($"/business/{businessId}/benefitcategory/{id}", Method.GET);
        }

        /// <summary>
        /// Get Benefit Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the benefit category with the specified ID
        /// </remarks>
        public Task<UkBenefitCategoryReadModel> GetBenefitCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBenefitCategoryReadModel>($"/business/{businessId}/benefitcategory/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Delete benefit category
        /// </summary>
        /// <remarks>
        /// Deletes the benefit category with the specified ID
        /// </remarks>
        public void DeleteBenefitCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/benefitcategory/{id}", Method.DELETE);
        }

        /// <summary>
        /// Delete benefit category
        /// </summary>
        /// <remarks>
        /// Deletes the benefit category with the specified ID
        /// </remarks>
        public Task DeleteBenefitCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/benefitcategory/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Create benefit categories
        /// </summary>
        /// <remarks>
        /// Creates multiple new benefit categories
        /// </remarks>
        public CreateMultipleBenefitCategoriesResult CreateBenefitCategories(int businessId, List<UkBenefitCategoryEditModel> model)
        {
            return ApiRequest<CreateMultipleBenefitCategoriesResult,List<UkBenefitCategoryEditModel>>($"/business/{businessId}/benefitcategory/multiple", model, Method.POST);
        }

        /// <summary>
        /// Create benefit categories
        /// </summary>
        /// <remarks>
        /// Creates multiple new benefit categories
        /// </remarks>
        public Task<CreateMultipleBenefitCategoriesResult> CreateBenefitCategoriesAsync(int businessId, List<UkBenefitCategoryEditModel> model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<CreateMultipleBenefitCategoriesResult,List<UkBenefitCategoryEditModel>>($"/business/{businessId}/benefitcategory/multiple", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get processing options
        /// </summary>
        /// <remarks>
        /// Gets p11d and/or payrolling of benefits active or inactive and registered from tax year
        /// </remarks>
        public UkBenefitCategoriesProcessingOptions GetProcessingOptions(int businessId)
        {
            return ApiRequest<UkBenefitCategoriesProcessingOptions>($"/business/{businessId}/benefitcategory/processingoptions", Method.GET);
        }

        /// <summary>
        /// Get processing options
        /// </summary>
        /// <remarks>
        /// Gets p11d and/or payrolling of benefits active or inactive and registered from tax year
        /// </remarks>
        public Task<UkBenefitCategoriesProcessingOptions> GetProcessingOptionsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBenefitCategoriesProcessingOptions>($"/business/{businessId}/benefitcategory/processingoptions", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Set processing options
        /// </summary>
        /// <remarks>
        /// Sets p11d and/or payrolling of benefits active or inactive and the business as having registered with HMRC from the given tax year
        /// </remarks>
        public void SetProcessingOptions(int businessId, SaveBenefitCategoriesProcessingOptionsModel model)
        {
            ApiRequest($"/business/{businessId}/benefitcategory/processingoptions", model, Method.PUT);
        }

        /// <summary>
        /// Set processing options
        /// </summary>
        /// <remarks>
        /// Sets p11d and/or payrolling of benefits active or inactive and the business as having registered with HMRC from the given tax year
        /// </remarks>
        public Task SetProcessingOptionsAsync(int businessId, SaveBenefitCategoriesProcessingOptionsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/benefitcategory/processingoptions", model, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Get registered from tax year options
        /// </summary>
        public List<BenefitCategoryRegisteredFromTaxYearOption> GetRegisteredFromTaxYearOptions(int businessId)
        {
            return ApiRequest<List<BenefitCategoryRegisteredFromTaxYearOption>>($"/business/{businessId}/benefitcategory/registeredfromtaxyearoptions", Method.GET);
        }

        /// <summary>
        /// Get registered from tax year options
        /// </summary>
        public Task<List<BenefitCategoryRegisteredFromTaxYearOption>> GetRegisteredFromTaxYearOptionsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BenefitCategoryRegisteredFromTaxYearOption>>($"/business/{businessId}/benefitcategory/registeredfromtaxyearoptions", Method.GET, cancellationToken);
        }
    }
}
