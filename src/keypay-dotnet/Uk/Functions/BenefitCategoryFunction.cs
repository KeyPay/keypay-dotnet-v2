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
        public CreateMultipleBenefitCategoriesResult CreateBenefitCategories(int businessId, UkBenefitCategoryEditModel[] model)
        {
            return ApiRequest<CreateMultipleBenefitCategoriesResult,UkBenefitCategoryEditModel[]>($"/business/{businessId}/benefitcategory/multiple", model, Method.POST);
        }

        /// <summary>
        /// Set registered from tax year
        /// </summary>
        /// <remarks>
        /// Sets the business as having registered with HMRC from the given tax year
        /// </remarks>
        public void SetRegisteredFromTaxYear(int businessId, int fromYear)
        {
            ApiRequest($"/business/{businessId}/benefitcategory/registeredfromtaxyear/{fromYear}", Method.POST);
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
