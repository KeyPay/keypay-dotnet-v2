using System;
using System.Collections.Generic;
using System.Linq;
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
            return ApiRequest<List<UkBenefitCategoryReadModel>>($"/business/{businessId}/benefitcategory");
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
        /// Get Benefit Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the benefit category with the specified ID
        /// </remarks>
        public UkBenefitCategoryReadModel GetBenefitCategoryById(int businessId, int id)
        {
            return ApiRequest<UkBenefitCategoryReadModel>($"/business/{businessId}/benefitcategory/{id}");
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
        /// Get processing options
        /// </summary>
        /// <remarks>
        /// Gets p11d and/or payrolling of benefits active or inactive and registered from tax year
        /// </remarks>
        public UkBenefitCategoriesProcessingOptions GetProcessingOptions(int businessId)
        {
            return ApiRequest<UkBenefitCategoriesProcessingOptions>($"/business/{businessId}/benefitcategory/processingoptions");
        }

        /// <summary>
        /// Set processing options
        /// </summary>
        /// <remarks>
        /// Sets p11d and/or payrolling of benefits active or inactive and the business as having registered with HMRC from the given tax year
        /// </remarks>
        public void SetProcessingOptions(int businessId, UkBenefitCategoriesProcessingOptionsModel model)
        {
            ApiRequest($"/business/{businessId}/benefitcategory/processingoptions", model, Method.PUT);
        }

        /// <summary>
        /// Get registered from tax year options
        /// </summary>
        public List<BenefitCategoryRegisteredFromTaxYearOption> GetRegisteredFromTaxYearOptions(int businessId)
        {
            return ApiRequest<List<BenefitCategoryRegisteredFromTaxYearOption>>($"/business/{businessId}/benefitcategory/registeredfromtaxyearoptions");
        }
    }
}
