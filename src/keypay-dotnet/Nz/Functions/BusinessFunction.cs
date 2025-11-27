using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.Business;

namespace KeyPayV2.Nz.Functions
{
    public interface IBusinessFunction
    {
        void ChangeTheTaxYear(int businessId);
        Task ChangeTheTaxYearAsync(int businessId, CancellationToken cancellationToken = default);
        void ChangeTheTaxYear(int businessId, ChangeTheTaxYearQueryModel request);
        Task ChangeTheTaxYearAsync(int businessId, ChangeTheTaxYearQueryModel request, CancellationToken cancellationToken = default);
        DateTime GetTheInitialTaxYear(int businessId);
        Task<DateTime> GetTheInitialTaxYearAsync(int businessId, CancellationToken cancellationToken = default);
        List<TagViewModel> ListTheBusinessTags(int businessId);
        Task<List<TagViewModel>> ListTheBusinessTagsAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzBusinessExportModel> ListBusinesses(ODataQuery oDataQuery = null);
        Task<List<NzBusinessExportModel>> ListBusinessesAsync(ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        NzBusinessExportModel CreateNewBusiness(NzBusinessExportModel model);
        Task<NzBusinessExportModel> CreateNewBusinessAsync(NzBusinessExportModel model, CancellationToken cancellationToken = default);
        NzBusinessExportModel CreateNewBusiness(NzBusinessExportModel model, CreateNewBusinessQueryModel request);
        Task<NzBusinessExportModel> CreateNewBusinessAsync(NzBusinessExportModel model, CreateNewBusinessQueryModel request, CancellationToken cancellationToken = default);
        NzBusinessExportModel GetBusinessDetails(int businessId);
        Task<NzBusinessExportModel> GetBusinessDetailsAsync(int businessId, CancellationToken cancellationToken = default);
        NzBusinessExportModel GetBusinessDetailsByExternalId();
        Task<NzBusinessExportModel> GetBusinessDetailsByExternalIdAsync(CancellationToken cancellationToken = default);
        NzBusinessExportModel GetBusinessDetailsByExternalId(GetBusinessDetailsByExternalIdQueryModel request);
        Task<NzBusinessExportModel> GetBusinessDetailsByExternalIdAsync(GetBusinessDetailsByExternalIdQueryModel request, CancellationToken cancellationToken = default);
        void CopyBusinessSettingsFromTemplate(int businessId, int businessTemplateId);
        Task CopyBusinessSettingsFromTemplateAsync(int businessId, int businessTemplateId, CancellationToken cancellationToken = default);
        NzBusinessTimesheetSettingsModel GetTheTimesheetSettingsForTheBusiness(int businessId);
        Task<NzBusinessTimesheetSettingsModel> GetTheTimesheetSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default);
        NzBusinessTimesheetSettingsModel UpdateTheTimesheetSettingsForTheBusiness(int businessId, NzBusinessTimesheetSettingsModel model);
        Task<NzBusinessTimesheetSettingsModel> UpdateTheTimesheetSettingsForTheBusinessAsync(int businessId, NzBusinessTimesheetSettingsModel model, CancellationToken cancellationToken = default);
        NzEmployeePortalSettingsModel GetEmployeePortalSettings(int businessId);
        Task<NzEmployeePortalSettingsModel> GetEmployeePortalSettingsAsync(int businessId, CancellationToken cancellationToken = default);
        NzEmployeePortalSettingsModel UpdateEmployeePortalSettings(int businessId, NzEmployeePortalSettingsModel model);
        Task<NzEmployeePortalSettingsModel> UpdateEmployeePortalSettingsAsync(int businessId, NzEmployeePortalSettingsModel model, CancellationToken cancellationToken = default);
        NzEditBusinessPaySlipApiModel GetPayslipConfiguration(int businessId);
        Task<NzEditBusinessPaySlipApiModel> GetPayslipConfigurationAsync(int businessId, CancellationToken cancellationToken = default);
        void CreatePayslipConfiguration(int businessId, NzEditBusinessPaySlipApiModel model);
        Task CreatePayslipConfigurationAsync(int businessId, NzEditBusinessPaySlipApiModel model, CancellationToken cancellationToken = default);
        List<BillingPlanResponseModel> ListBillingPlans(int businessId);
        Task<List<BillingPlanResponseModel>> ListBillingPlansAsync(int businessId, CancellationToken cancellationToken = default);
        BillingPlanResponseModel GetBusinessBillingPlan(int businessId);
        Task<BillingPlanResponseModel> GetBusinessBillingPlanAsync(int businessId, CancellationToken cancellationToken = default);
        void SetBusinessBillingPlan(int businessId, SetBillingPlanRequestModel model);
        Task SetBusinessBillingPlanAsync(int businessId, SetBillingPlanRequestModel model, CancellationToken cancellationToken = default);
    }
    public class BusinessFunction : BaseFunction, IBusinessFunction
    {
        public BusinessFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Change the tax year
        /// </summary>
        /// <remarks>
        /// Changes the initial tax year for the current business.
        /// </remarks>
        public void ChangeTheTaxYear(int businessId)
        {
            ApiRequest($"/business/{businessId}/initialfinancialyear", Method.Post);
        }

        /// <summary>
        /// Change the tax year
        /// </summary>
        /// <remarks>
        /// Changes the initial tax year for the current business.
        /// </remarks>
        public Task ChangeTheTaxYearAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/initialfinancialyear", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Change the tax year
        /// </summary>
        /// <remarks>
        /// Changes the initial tax year for the current business.
        /// </remarks>
        public void ChangeTheTaxYear(int businessId, ChangeTheTaxYearQueryModel request)
        {
            ApiRequest($"/business/{businessId}/initialfinancialyear?year={request.Year}", Method.Post);
        }

        /// <summary>
        /// Change the tax year
        /// </summary>
        /// <remarks>
        /// Changes the initial tax year for the current business.
        /// </remarks>
        public Task ChangeTheTaxYearAsync(int businessId, ChangeTheTaxYearQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/initialfinancialyear?year={request.Year}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get the initial tax year
        /// </summary>
        /// <remarks>
        /// Retrieves the initial tax year for the business.
        /// </remarks>
        public DateTime GetTheInitialTaxYear(int businessId)
        {
            return ApiRequest<DateTime>($"/business/{businessId}/initialfinancialyear", Method.Get);
        }

        /// <summary>
        /// Get the initial tax year
        /// </summary>
        /// <remarks>
        /// Retrieves the initial tax year for the business.
        /// </remarks>
        public Task<DateTime> GetTheInitialTaxYearAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DateTime>($"/business/{businessId}/initialfinancialyear", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List the Business tags
        /// </summary>
        public List<TagViewModel> ListTheBusinessTags(int businessId)
        {
            return ApiRequest<List<TagViewModel>>($"/business/{businessId}/tags", Method.Get);
        }

        /// <summary>
        /// List the Business tags
        /// </summary>
        public Task<List<TagViewModel>> ListTheBusinessTagsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TagViewModel>>($"/business/{businessId}/tags", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Businesses
        /// </summary>
        /// <remarks>
        /// Lists all the businesses associated with the current user.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<NzBusinessExportModel> ListBusinesses(ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<NzBusinessExportModel>>($"/business{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Businesses
        /// </summary>
        /// <remarks>
        /// Lists all the businesses associated with the current user.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<NzBusinessExportModel>> ListBusinessesAsync(ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzBusinessExportModel>>($"/business{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public NzBusinessExportModel CreateNewBusiness(NzBusinessExportModel model)
        {
            return ApiRequest<NzBusinessExportModel,NzBusinessExportModel>($"/business", model, Method.Post);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public Task<NzBusinessExportModel> CreateNewBusinessAsync(NzBusinessExportModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzBusinessExportModel,NzBusinessExportModel>($"/business", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public NzBusinessExportModel CreateNewBusiness(NzBusinessExportModel model, CreateNewBusinessQueryModel request)
        {
            return ApiRequest<NzBusinessExportModel,NzBusinessExportModel>($"/business?setupDefaultData={request.SetupDefaultData}", model, Method.Post);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public Task<NzBusinessExportModel> CreateNewBusinessAsync(NzBusinessExportModel model, CreateNewBusinessQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzBusinessExportModel,NzBusinessExportModel>($"/business?setupDefaultData={request.SetupDefaultData}", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Business Details
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified ID.
        /// </remarks>
        public NzBusinessExportModel GetBusinessDetails(int businessId)
        {
            return ApiRequest<NzBusinessExportModel>($"/business/{businessId}", Method.Get);
        }

        /// <summary>
        /// Get Business Details
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified ID.
        /// </remarks>
        public Task<NzBusinessExportModel> GetBusinessDetailsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzBusinessExportModel>($"/business/{businessId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public NzBusinessExportModel GetBusinessDetailsByExternalId()
        {
            return ApiRequest<NzBusinessExportModel>($"/business/externalid", Method.Get);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public Task<NzBusinessExportModel> GetBusinessDetailsByExternalIdAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzBusinessExportModel>($"/business/externalid", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public NzBusinessExportModel GetBusinessDetailsByExternalId(GetBusinessDetailsByExternalIdQueryModel request)
        {
            return ApiRequest<NzBusinessExportModel>($"/business/externalid?externalId={request.ExternalId}", Method.Get);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public Task<NzBusinessExportModel> GetBusinessDetailsByExternalIdAsync(GetBusinessDetailsByExternalIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzBusinessExportModel>($"/business/externalid?externalId={request.ExternalId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Copy Business Settings From Template
        /// </summary>
        public void CopyBusinessSettingsFromTemplate(int businessId, int businessTemplateId)
        {
            ApiRequest($"/business/{businessId}/{businessTemplateId}", Method.Post);
        }

        /// <summary>
        /// Copy Business Settings From Template
        /// </summary>
        public Task CopyBusinessSettingsFromTemplateAsync(int businessId, int businessTemplateId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/{businessTemplateId}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get the timesheet settings for the business
        /// </summary>
        public NzBusinessTimesheetSettingsModel GetTheTimesheetSettingsForTheBusiness(int businessId)
        {
            return ApiRequest<NzBusinessTimesheetSettingsModel>($"/business/{businessId}/timesheetsettings", Method.Get);
        }

        /// <summary>
        /// Get the timesheet settings for the business
        /// </summary>
        public Task<NzBusinessTimesheetSettingsModel> GetTheTimesheetSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzBusinessTimesheetSettingsModel>($"/business/{businessId}/timesheetsettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update the timesheet settings for the business
        /// </summary>
        public NzBusinessTimesheetSettingsModel UpdateTheTimesheetSettingsForTheBusiness(int businessId, NzBusinessTimesheetSettingsModel model)
        {
            return ApiRequest<NzBusinessTimesheetSettingsModel,NzBusinessTimesheetSettingsModel>($"/business/{businessId}/timesheetsettings", model, Method.Put);
        }

        /// <summary>
        /// Update the timesheet settings for the business
        /// </summary>
        public Task<NzBusinessTimesheetSettingsModel> UpdateTheTimesheetSettingsForTheBusinessAsync(int businessId, NzBusinessTimesheetSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzBusinessTimesheetSettingsModel,NzBusinessTimesheetSettingsModel>($"/business/{businessId}/timesheetsettings", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public NzEmployeePortalSettingsModel GetEmployeePortalSettings(int businessId)
        {
            return ApiRequest<NzEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", Method.Get);
        }

        /// <summary>
        /// Get Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public Task<NzEmployeePortalSettingsModel> GetEmployeePortalSettingsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public NzEmployeePortalSettingsModel UpdateEmployeePortalSettings(int businessId, NzEmployeePortalSettingsModel model)
        {
            return ApiRequest<NzEmployeePortalSettingsModel,NzEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", model, Method.Post);
        }

        /// <summary>
        /// Update Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public Task<NzEmployeePortalSettingsModel> UpdateEmployeePortalSettingsAsync(int businessId, NzEmployeePortalSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzEmployeePortalSettingsModel,NzEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get payslip configuration
        /// </summary>
        /// <remarks>
        /// Gets the payslip configuration for the specified business ID.
        /// </remarks>
        public NzEditBusinessPaySlipApiModel GetPayslipConfiguration(int businessId)
        {
            return ApiRequest<NzEditBusinessPaySlipApiModel>($"/business/{businessId}/payslip", Method.Get);
        }

        /// <summary>
        /// Get payslip configuration
        /// </summary>
        /// <remarks>
        /// Gets the payslip configuration for the specified business ID.
        /// </remarks>
        public Task<NzEditBusinessPaySlipApiModel> GetPayslipConfigurationAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzEditBusinessPaySlipApiModel>($"/business/{businessId}/payslip", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create payslip configuration
        /// </summary>
        /// <remarks>
        /// Creates the payslip configuration for the specified business ID.
        /// ShowLineNotes field must be enabled in order to enable the ShowLocationInLineNotes field.
        /// An example of what you would populate the EmailBodyMessage field with would be:
        /// <p>Hi {{FirstName}},</p><p>{{BusinessName}} has just processed your pay and a new pay slip is available.</p><p>Regards {{BusinessName}}</p>
        /// </remarks>
        public void CreatePayslipConfiguration(int businessId, NzEditBusinessPaySlipApiModel model)
        {
            ApiRequest($"/business/{businessId}/payslip", model, Method.Post);
        }

        /// <summary>
        /// Create payslip configuration
        /// </summary>
        /// <remarks>
        /// Creates the payslip configuration for the specified business ID.
        /// ShowLineNotes field must be enabled in order to enable the ShowLocationInLineNotes field.
        /// An example of what you would populate the EmailBodyMessage field with would be:
        /// <p>Hi {{FirstName}},</p><p>{{BusinessName}} has just processed your pay and a new pay slip is available.</p><p>Regards {{BusinessName}}</p>
        /// </remarks>
        public Task CreatePayslipConfigurationAsync(int businessId, NzEditBusinessPaySlipApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payslip", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Billing Plans
        /// </summary>
        /// <remarks>
        /// Lists all the billing plans for the business.
        /// </remarks>
        public List<BillingPlanResponseModel> ListBillingPlans(int businessId)
        {
            return ApiRequest<List<BillingPlanResponseModel>>($"/business/{businessId}/subscription/billingplans", Method.Get);
        }

        /// <summary>
        /// List Billing Plans
        /// </summary>
        /// <remarks>
        /// Lists all the billing plans for the business.
        /// </remarks>
        public Task<List<BillingPlanResponseModel>> ListBillingPlansAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BillingPlanResponseModel>>($"/business/{businessId}/subscription/billingplans", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Billing Plan
        /// </summary>
        /// <remarks>
        /// Get the current billing plan for the business.
        /// </remarks>
        public BillingPlanResponseModel GetBusinessBillingPlan(int businessId)
        {
            return ApiRequest<BillingPlanResponseModel>($"/business/{businessId}/subscription/currentbillingplan", Method.Get);
        }

        /// <summary>
        /// Get Business Billing Plan
        /// </summary>
        /// <remarks>
        /// Get the current billing plan for the business.
        /// </remarks>
        public Task<BillingPlanResponseModel> GetBusinessBillingPlanAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<BillingPlanResponseModel>($"/business/{businessId}/subscription/currentbillingplan", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Business Billing Plan
        /// </summary>
        /// <remarks>
        /// Sets the current billing plan for a business
        /// </remarks>
        public void SetBusinessBillingPlan(int businessId, SetBillingPlanRequestModel model)
        {
            ApiRequest($"/business/{businessId}/subscription/setbillingplan", model, Method.Post);
        }

        /// <summary>
        /// Set Business Billing Plan
        /// </summary>
        /// <remarks>
        /// Sets the current billing plan for a business
        /// </remarks>
        public Task SetBusinessBillingPlanAsync(int businessId, SetBillingPlanRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/subscription/setbillingplan", model, Method.Post, cancellationToken);
        }
    }
}
