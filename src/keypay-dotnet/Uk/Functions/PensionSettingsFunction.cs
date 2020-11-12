using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.PensionSettings;

namespace KeyPayV2.Uk.Functions
{
    public class PensionSettingsFunction : BaseFunction
    {
        public PensionSettingsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Pension Schemes
        /// </summary>
        /// <remarks>
        /// List Pension Schemes for business
        /// </remarks>
        public List<PensionSchemeApiModel> ListPensionSchemes(int businessId)
        {
            return ApiRequest<List<PensionSchemeApiModel>>($"/business/{businessId}/pensionscheme");
        }

        /// <summary>
        /// Create Pension Scheme
        /// </summary>
        /// <remarks>
        /// Create Pension Scheme for business
        /// </remarks>
        public PensionSchemeApiModel CreatePensionScheme(int businessId, PensionSchemeApiModel model)
        {
            return ApiRequest<PensionSchemeApiModel,PensionSchemeApiModel>($"/business/{businessId}/pensionscheme", model, Method.POST);
        }

        /// <summary>
        /// Get Pension Scheme
        /// </summary>
        /// <remarks>
        /// Get Pension Scheme for business
        /// </remarks>
        public PensionSchemeApiModel GetPensionScheme(int businessId, int id)
        {
            return ApiRequest<PensionSchemeApiModel>($"/business/{businessId}/pensionscheme/{id}");
        }

        /// <summary>
        /// Update Pension Scheme
        /// </summary>
        /// <remarks>
        /// Update Pension Scheme for business
        /// </remarks>
        public PensionSchemeApiModel UpdatePensionScheme(int businessId, int id, PensionSchemeApiModel model)
        {
            return ApiRequest<PensionSchemeApiModel,PensionSchemeApiModel>($"/business/{businessId}/pensionscheme/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Delete Pension Scheme
        /// </summary>
        /// <remarks>
        /// Delete Pension Scheme for business
        /// </remarks>
        public void DeletePensionScheme(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/pensionscheme/{id}", Method.DELETE);
        }

        /// <summary>
        /// List Pension Scheme Contribution Plans
        /// </summary>
        /// <remarks>
        /// List all Contribution Plans for a Pension Scheme
        /// </remarks>
        public List<PensionSchemeContributionPlanApiModel> ListPensionSchemeContributionPlans(int businessId, int schemeId)
        {
            return ApiRequest<List<PensionSchemeContributionPlanApiModel>>($"/business/{businessId}/pensionscheme/{schemeId}/plan");
        }

        /// <summary>
        /// Create Pension Scheme Contribution Plan
        /// </summary>
        /// <remarks>
        /// Create Contribution Plan for Pension Scheme
        /// </remarks>
        public PensionSchemeContributionPlanApiModel CreatePensionSchemeContributionPlan(int businessId, int schemeId, PensionSchemeContributionPlanApiModel contributionPlan)
        {
            return ApiRequest<PensionSchemeContributionPlanApiModel,PensionSchemeContributionPlanApiModel>($"/business/{businessId}/pensionscheme/{schemeId}/plan", contributionPlan, Method.POST);
        }

        /// <summary>
        /// Get Pension Scheme Contribution Plan
        /// </summary>
        /// <remarks>
        /// Get specified Pension Scheme Contribution Plan for business
        /// </remarks>
        public PensionSchemeContributionPlanApiModel GetPensionSchemeContributionPlan(int businessId, int schemeId, int planId)
        {
            return ApiRequest<PensionSchemeContributionPlanApiModel>($"/business/{businessId}/pensionscheme/{schemeId}/plan/{planId}");
        }

        /// <summary>
        /// Update Pension Scheme Contribution Plan
        /// </summary>
        /// <remarks>
        /// UpdateContribution Plan for Pension Scheme
        /// </remarks>
        public PensionSchemeContributionPlanApiModel UpdatePensionSchemeContributionPlan(int businessId, int schemeId, int planId, PensionSchemeContributionPlanApiModel contributionPlan)
        {
            return ApiRequest<PensionSchemeContributionPlanApiModel,PensionSchemeContributionPlanApiModel>($"/business/{businessId}/pensionscheme/{schemeId}/plan/{planId}", contributionPlan, Method.PUT);
        }

        /// <summary>
        /// Set Pension Scheme Dates
        /// </summary>
        /// <remarks>
        /// Save auto enrollment staging and re-enrolment dates for business
        /// </remarks>
        public PensionSchemeStagingModel SetPensionSchemeDates(int businessId, PensionSchemeStagingModel model)
        {
            return ApiRequest<PensionSchemeStagingModel,PensionSchemeStagingModel>($"/business/{businessId}/pensionscheme/dates", model, Method.POST);
        }
    }
}
