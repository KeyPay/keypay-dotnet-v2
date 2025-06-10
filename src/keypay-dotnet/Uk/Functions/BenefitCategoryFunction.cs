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
using KeyPayV2.Uk.Models.BenefitCategory;

namespace KeyPayV2.Uk.Functions
{
    public interface IBenefitCategoryFunction
    {
        List<UkBenefitCategoryReadModel> ListBenefitCategories(int businessId);
        Task<List<UkBenefitCategoryReadModel>> ListBenefitCategoriesAsync(int businessId, CancellationToken cancellationToken = default);
        UkUpdateBenefitCategoryResult UpdateBenefitCategory(int businessId, UkBenefitCategoryReadModel model);
        Task<UkUpdateBenefitCategoryResult> UpdateBenefitCategoryAsync(int businessId, UkBenefitCategoryReadModel model, CancellationToken cancellationToken = default);
        UkBenefitCategoryReadModel CreateBenefitCategory(int businessId, UkBenefitCategoryEditModel model);
        Task<UkBenefitCategoryReadModel> CreateBenefitCategoryAsync(int businessId, UkBenefitCategoryEditModel model, CancellationToken cancellationToken = default);
        UkBenefitCategoryReadModel GetBenefitCategoryById(int businessId, int id);
        Task<UkBenefitCategoryReadModel> GetBenefitCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void DeleteBenefitCategory(int businessId, int id);
        Task DeleteBenefitCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default);
        CreateMultipleBenefitCategoriesResult UkBenefitCategory_CreateMultiple(int businessId, List<UkBenefitCategoryEditModel> model);
        Task<CreateMultipleBenefitCategoriesResult> UkBenefitCategory_CreateMultipleAsync(int businessId, List<UkBenefitCategoryEditModel> model, CancellationToken cancellationToken = default);
        UkBenefitCategoriesProcessingOptions GetProcessingOptions(int businessId);
        Task<UkBenefitCategoriesProcessingOptions> GetProcessingOptionsAsync(int businessId, CancellationToken cancellationToken = default);
        void SetProcessingOptions(int businessId, SaveBenefitCategoriesProcessingOptionsModel model);
        Task SetProcessingOptionsAsync(int businessId, SaveBenefitCategoriesProcessingOptionsModel model, CancellationToken cancellationToken = default);
        List<BenefitCategoryRegisteredFromTaxYearOption> GetRegisteredFromTaxYearOptions(int businessId);
        Task<List<BenefitCategoryRegisteredFromTaxYearOption>> GetRegisteredFromTaxYearOptionsAsync(int businessId, CancellationToken cancellationToken = default);
    }
    public class BenefitCategoryFunction : BaseFunction, IBenefitCategoryFunction
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
            return ApiRequest<List<UkBenefitCategoryReadModel>>($"/business/{businessId}/benefitcategory", Method.Get);
        }

        /// <summary>
        /// List Benefit Categories
        /// </summary>
        /// <remarks>
        /// Lists the benefit categories
        /// </remarks>
        public Task<List<UkBenefitCategoryReadModel>> ListBenefitCategoriesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkBenefitCategoryReadModel>>($"/business/{businessId}/benefitcategory", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Benefit Category
        /// </summary>
        /// <remarks>
        /// Updates a benefit category
        /// </remarks>
        public UkUpdateBenefitCategoryResult UpdateBenefitCategory(int businessId, UkBenefitCategoryReadModel model)
        {
            return ApiRequest<UkUpdateBenefitCategoryResult,UkBenefitCategoryReadModel>($"/business/{businessId}/benefitcategory", model, Method.Put);
        }

        /// <summary>
        /// Update Benefit Category
        /// </summary>
        /// <remarks>
        /// Updates a benefit category
        /// </remarks>
        public Task<UkUpdateBenefitCategoryResult> UpdateBenefitCategoryAsync(int businessId, UkBenefitCategoryReadModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUpdateBenefitCategoryResult,UkBenefitCategoryReadModel>($"/business/{businessId}/benefitcategory", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Create benefit category
        /// </summary>
        /// <remarks>
        /// Creates a new benefit category
        /// </remarks>
        public UkBenefitCategoryReadModel CreateBenefitCategory(int businessId, UkBenefitCategoryEditModel model)
        {
            return ApiRequest<UkBenefitCategoryReadModel,UkBenefitCategoryEditModel>($"/business/{businessId}/benefitcategory", model, Method.Post);
        }

        /// <summary>
        /// Create benefit category
        /// </summary>
        /// <remarks>
        /// Creates a new benefit category
        /// </remarks>
        public Task<UkBenefitCategoryReadModel> CreateBenefitCategoryAsync(int businessId, UkBenefitCategoryEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBenefitCategoryReadModel,UkBenefitCategoryEditModel>($"/business/{businessId}/benefitcategory", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Benefit Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the benefit category with the specified ID
        /// </remarks>
        public UkBenefitCategoryReadModel GetBenefitCategoryById(int businessId, int id)
        {
            return ApiRequest<UkBenefitCategoryReadModel>($"/business/{businessId}/benefitcategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Benefit Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the benefit category with the specified ID
        /// </remarks>
        public Task<UkBenefitCategoryReadModel> GetBenefitCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBenefitCategoryReadModel>($"/business/{businessId}/benefitcategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Delete benefit category
        /// </summary>
        /// <remarks>
        /// Deletes the benefit category with the specified ID
        /// </remarks>
        public void DeleteBenefitCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/benefitcategory/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete benefit category
        /// </summary>
        /// <remarks>
        /// Deletes the benefit category with the specified ID
        /// </remarks>
        public Task DeleteBenefitCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/benefitcategory/{id}", Method.Delete, cancellationToken);
        }

        public CreateMultipleBenefitCategoriesResult UkBenefitCategory_CreateMultiple(int businessId, List<UkBenefitCategoryEditModel> model)
        {
            return ApiRequest<CreateMultipleBenefitCategoriesResult,List<UkBenefitCategoryEditModel>>($"/business/{businessId}/benefitcategory/multiple", model, Method.Post);
        }

        public Task<CreateMultipleBenefitCategoriesResult> UkBenefitCategory_CreateMultipleAsync(int businessId, List<UkBenefitCategoryEditModel> model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<CreateMultipleBenefitCategoriesResult,List<UkBenefitCategoryEditModel>>($"/business/{businessId}/benefitcategory/multiple", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get processing options
        /// </summary>
        /// <remarks>
        /// Gets p11d and/or payrolling of benefits active or inactive and registered from tax year
        /// </remarks>
        public UkBenefitCategoriesProcessingOptions GetProcessingOptions(int businessId)
        {
            return ApiRequest<UkBenefitCategoriesProcessingOptions>($"/business/{businessId}/benefitcategory/processingoptions", Method.Get);
        }

        /// <summary>
        /// Get processing options
        /// </summary>
        /// <remarks>
        /// Gets p11d and/or payrolling of benefits active or inactive and registered from tax year
        /// </remarks>
        public Task<UkBenefitCategoriesProcessingOptions> GetProcessingOptionsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBenefitCategoriesProcessingOptions>($"/business/{businessId}/benefitcategory/processingoptions", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set processing options
        /// </summary>
        /// <remarks>
        /// Sets p11d and/or payrolling of benefits active or inactive and the business as having registered with HMRC from the given tax year
        /// </remarks>
        public void SetProcessingOptions(int businessId, SaveBenefitCategoriesProcessingOptionsModel model)
        {
            ApiRequest($"/business/{businessId}/benefitcategory/processingoptions", model, Method.Put);
        }

        /// <summary>
        /// Set processing options
        /// </summary>
        /// <remarks>
        /// Sets p11d and/or payrolling of benefits active or inactive and the business as having registered with HMRC from the given tax year
        /// </remarks>
        public Task SetProcessingOptionsAsync(int businessId, SaveBenefitCategoriesProcessingOptionsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/benefitcategory/processingoptions", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get registered from tax year options
        /// </summary>
        public List<BenefitCategoryRegisteredFromTaxYearOption> GetRegisteredFromTaxYearOptions(int businessId)
        {
            return ApiRequest<List<BenefitCategoryRegisteredFromTaxYearOption>>($"/business/{businessId}/benefitcategory/registeredfromtaxyearoptions", Method.Get);
        }

        /// <summary>
        /// Get registered from tax year options
        /// </summary>
        public Task<List<BenefitCategoryRegisteredFromTaxYearOption>> GetRegisteredFromTaxYearOptionsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BenefitCategoryRegisteredFromTaxYearOption>>($"/business/{businessId}/benefitcategory/registeredfromtaxyearoptions", Method.Get, cancellationToken);
        }
    }
}
