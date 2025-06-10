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
using KeyPayV2.Uk.Models.PensionSettings;

namespace KeyPayV2.Uk.Functions
{
    public interface IPensionSettingsFunction
    {
        List<PensionSchemeApiModel> ListPensionSchemes(int businessId);
        Task<List<PensionSchemeApiModel>> ListPensionSchemesAsync(int businessId, CancellationToken cancellationToken = default);
        PensionSchemeApiModel CreatePensionScheme(int businessId, PensionSchemeApiModel model);
        Task<PensionSchemeApiModel> CreatePensionSchemeAsync(int businessId, PensionSchemeApiModel model, CancellationToken cancellationToken = default);
        PensionSchemeApiModel GetPensionScheme(int businessId, int id);
        Task<PensionSchemeApiModel> GetPensionSchemeAsync(int businessId, int id, CancellationToken cancellationToken = default);
        PensionSchemeApiModel UpdatePensionScheme(int businessId, int id, PensionSchemeApiModel model);
        Task<PensionSchemeApiModel> UpdatePensionSchemeAsync(int businessId, int id, PensionSchemeApiModel model, CancellationToken cancellationToken = default);
        void DeletePensionScheme(int businessId, int id);
        Task DeletePensionSchemeAsync(int businessId, int id, CancellationToken cancellationToken = default);
        List<PensionSchemeContributionPlanApiModel> ListPensionSchemeContributionPlans(int businessId, int schemeId);
        Task<List<PensionSchemeContributionPlanApiModel>> ListPensionSchemeContributionPlansAsync(int businessId, int schemeId, CancellationToken cancellationToken = default);
        PensionSchemeContributionPlanApiModel CreatePensionSchemeContributionPlan(int businessId, int schemeId, PensionSchemeContributionPlanApiModel contributionPlan);
        Task<PensionSchemeContributionPlanApiModel> CreatePensionSchemeContributionPlanAsync(int businessId, int schemeId, PensionSchemeContributionPlanApiModel contributionPlan, CancellationToken cancellationToken = default);
        PensionSchemeContributionPlanApiModel GetPensionSchemeContributionPlan(int businessId, int schemeId, int planId);
        Task<PensionSchemeContributionPlanApiModel> GetPensionSchemeContributionPlanAsync(int businessId, int schemeId, int planId, CancellationToken cancellationToken = default);
        PensionSchemeContributionPlanApiModel UpdatePensionSchemeContributionPlan(int businessId, int schemeId, int planId, PensionSchemeContributionPlanApiModel contributionPlan);
        Task<PensionSchemeContributionPlanApiModel> UpdatePensionSchemeContributionPlanAsync(int businessId, int schemeId, int planId, PensionSchemeContributionPlanApiModel contributionPlan, CancellationToken cancellationToken = default);
        PensionSchemeStagingModel SetPensionSchemeDates(int businessId, PensionSchemeStagingModel model);
        Task<PensionSchemeStagingModel> SetPensionSchemeDatesAsync(int businessId, PensionSchemeStagingModel model, CancellationToken cancellationToken = default);
    }
    public class PensionSettingsFunction : BaseFunction, IPensionSettingsFunction
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
            return ApiRequest<List<PensionSchemeApiModel>>($"/business/{businessId}/pensionscheme", Method.Get);
        }

        /// <summary>
        /// List Pension Schemes
        /// </summary>
        /// <remarks>
        /// List Pension Schemes for business
        /// </remarks>
        public Task<List<PensionSchemeApiModel>> ListPensionSchemesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PensionSchemeApiModel>>($"/business/{businessId}/pensionscheme", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pension Scheme
        /// </summary>
        /// <remarks>
        /// Create Pension Scheme for business
        /// </remarks>
        public PensionSchemeApiModel CreatePensionScheme(int businessId, PensionSchemeApiModel model)
        {
            return ApiRequest<PensionSchemeApiModel,PensionSchemeApiModel>($"/business/{businessId}/pensionscheme", model, Method.Post);
        }

        /// <summary>
        /// Create Pension Scheme
        /// </summary>
        /// <remarks>
        /// Create Pension Scheme for business
        /// </remarks>
        public Task<PensionSchemeApiModel> CreatePensionSchemeAsync(int businessId, PensionSchemeApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PensionSchemeApiModel,PensionSchemeApiModel>($"/business/{businessId}/pensionscheme", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pension Scheme
        /// </summary>
        /// <remarks>
        /// Get Pension Scheme for business
        /// </remarks>
        public PensionSchemeApiModel GetPensionScheme(int businessId, int id)
        {
            return ApiRequest<PensionSchemeApiModel>($"/business/{businessId}/pensionscheme/{id}", Method.Get);
        }

        /// <summary>
        /// Get Pension Scheme
        /// </summary>
        /// <remarks>
        /// Get Pension Scheme for business
        /// </remarks>
        public Task<PensionSchemeApiModel> GetPensionSchemeAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PensionSchemeApiModel>($"/business/{businessId}/pensionscheme/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Pension Scheme
        /// </summary>
        /// <remarks>
        /// Update Pension Scheme for business
        /// </remarks>
        public PensionSchemeApiModel UpdatePensionScheme(int businessId, int id, PensionSchemeApiModel model)
        {
            return ApiRequest<PensionSchemeApiModel,PensionSchemeApiModel>($"/business/{businessId}/pensionscheme/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Pension Scheme
        /// </summary>
        /// <remarks>
        /// Update Pension Scheme for business
        /// </remarks>
        public Task<PensionSchemeApiModel> UpdatePensionSchemeAsync(int businessId, int id, PensionSchemeApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PensionSchemeApiModel,PensionSchemeApiModel>($"/business/{businessId}/pensionscheme/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Pension Scheme
        /// </summary>
        /// <remarks>
        /// Delete Pension Scheme for business
        /// </remarks>
        public void DeletePensionScheme(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/pensionscheme/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Pension Scheme
        /// </summary>
        /// <remarks>
        /// Delete Pension Scheme for business
        /// </remarks>
        public Task DeletePensionSchemeAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/pensionscheme/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Pension Scheme Contribution Plans
        /// </summary>
        /// <remarks>
        /// List all Contribution Plans for a Pension Scheme
        /// </remarks>
        public List<PensionSchemeContributionPlanApiModel> ListPensionSchemeContributionPlans(int businessId, int schemeId)
        {
            return ApiRequest<List<PensionSchemeContributionPlanApiModel>>($"/business/{businessId}/pensionscheme/{schemeId}/plan", Method.Get);
        }

        /// <summary>
        /// List Pension Scheme Contribution Plans
        /// </summary>
        /// <remarks>
        /// List all Contribution Plans for a Pension Scheme
        /// </remarks>
        public Task<List<PensionSchemeContributionPlanApiModel>> ListPensionSchemeContributionPlansAsync(int businessId, int schemeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PensionSchemeContributionPlanApiModel>>($"/business/{businessId}/pensionscheme/{schemeId}/plan", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pension Scheme Contribution Plan
        /// </summary>
        /// <remarks>
        /// Create Contribution Plan for Pension Scheme
        /// </remarks>
        public PensionSchemeContributionPlanApiModel CreatePensionSchemeContributionPlan(int businessId, int schemeId, PensionSchemeContributionPlanApiModel contributionPlan)
        {
            return ApiRequest<PensionSchemeContributionPlanApiModel,PensionSchemeContributionPlanApiModel>($"/business/{businessId}/pensionscheme/{schemeId}/plan", contributionPlan, Method.Post);
        }

        /// <summary>
        /// Create Pension Scheme Contribution Plan
        /// </summary>
        /// <remarks>
        /// Create Contribution Plan for Pension Scheme
        /// </remarks>
        public Task<PensionSchemeContributionPlanApiModel> CreatePensionSchemeContributionPlanAsync(int businessId, int schemeId, PensionSchemeContributionPlanApiModel contributionPlan, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PensionSchemeContributionPlanApiModel,PensionSchemeContributionPlanApiModel>($"/business/{businessId}/pensionscheme/{schemeId}/plan", contributionPlan, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pension Scheme Contribution Plan
        /// </summary>
        /// <remarks>
        /// Get specified Pension Scheme Contribution Plan for business
        /// </remarks>
        public PensionSchemeContributionPlanApiModel GetPensionSchemeContributionPlan(int businessId, int schemeId, int planId)
        {
            return ApiRequest<PensionSchemeContributionPlanApiModel>($"/business/{businessId}/pensionscheme/{schemeId}/plan/{planId}", Method.Get);
        }

        /// <summary>
        /// Get Pension Scheme Contribution Plan
        /// </summary>
        /// <remarks>
        /// Get specified Pension Scheme Contribution Plan for business
        /// </remarks>
        public Task<PensionSchemeContributionPlanApiModel> GetPensionSchemeContributionPlanAsync(int businessId, int schemeId, int planId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PensionSchemeContributionPlanApiModel>($"/business/{businessId}/pensionscheme/{schemeId}/plan/{planId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Pension Scheme Contribution Plan
        /// </summary>
        /// <remarks>
        /// UpdateContribution Plan for Pension Scheme
        /// </remarks>
        public PensionSchemeContributionPlanApiModel UpdatePensionSchemeContributionPlan(int businessId, int schemeId, int planId, PensionSchemeContributionPlanApiModel contributionPlan)
        {
            return ApiRequest<PensionSchemeContributionPlanApiModel,PensionSchemeContributionPlanApiModel>($"/business/{businessId}/pensionscheme/{schemeId}/plan/{planId}", contributionPlan, Method.Put);
        }

        /// <summary>
        /// Update Pension Scheme Contribution Plan
        /// </summary>
        /// <remarks>
        /// UpdateContribution Plan for Pension Scheme
        /// </remarks>
        public Task<PensionSchemeContributionPlanApiModel> UpdatePensionSchemeContributionPlanAsync(int businessId, int schemeId, int planId, PensionSchemeContributionPlanApiModel contributionPlan, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PensionSchemeContributionPlanApiModel,PensionSchemeContributionPlanApiModel>($"/business/{businessId}/pensionscheme/{schemeId}/plan/{planId}", contributionPlan, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Set Pension Scheme Dates
        /// </summary>
        /// <remarks>
        /// Save auto enrollment staging and re-enrolment dates for business
        /// </remarks>
        public PensionSchemeStagingModel SetPensionSchemeDates(int businessId, PensionSchemeStagingModel model)
        {
            return ApiRequest<PensionSchemeStagingModel,PensionSchemeStagingModel>($"/business/{businessId}/pensionscheme/dates", model, Method.Post);
        }

        /// <summary>
        /// Set Pension Scheme Dates
        /// </summary>
        /// <remarks>
        /// Save auto enrollment staging and re-enrolment dates for business
        /// </remarks>
        public Task<PensionSchemeStagingModel> SetPensionSchemeDatesAsync(int businessId, PensionSchemeStagingModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PensionSchemeStagingModel,PensionSchemeStagingModel>($"/business/{businessId}/pensionscheme/dates", model, Method.Post, cancellationToken);
        }
    }
}
