using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.Business;

namespace KeyPayV2.Au.Functions
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
        List<AuBusinessExportModel> ListBusinesses(ODataQuery oDataQuery = null);
        Task<List<AuBusinessExportModel>> ListBusinessesAsync(ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        AuBusinessExportModel CreateNewBusiness(AuBusinessExportModel model);
        Task<AuBusinessExportModel> CreateNewBusinessAsync(AuBusinessExportModel model, CancellationToken cancellationToken = default);
        AuBusinessExportModel CreateNewBusiness(AuBusinessExportModel model, CreateNewBusinessQueryModel request);
        Task<AuBusinessExportModel> CreateNewBusinessAsync(AuBusinessExportModel model, CreateNewBusinessQueryModel request, CancellationToken cancellationToken = default);
        AuBusinessExportModel GetBusinessDetails(int businessId);
        Task<AuBusinessExportModel> GetBusinessDetailsAsync(int businessId, CancellationToken cancellationToken = default);
        AuBusinessExportModel GetBusinessDetailsByExternalId();
        Task<AuBusinessExportModel> GetBusinessDetailsByExternalIdAsync(CancellationToken cancellationToken = default);
        AuBusinessExportModel GetBusinessDetailsByExternalId(GetBusinessDetailsByExternalIdQueryModel request);
        Task<AuBusinessExportModel> GetBusinessDetailsByExternalIdAsync(GetBusinessDetailsByExternalIdQueryModel request, CancellationToken cancellationToken = default);
        void CopyBusinessSettingsFromTemplate(int businessId, int businessTemplateId);
        Task CopyBusinessSettingsFromTemplateAsync(int businessId, int businessTemplateId, CancellationToken cancellationToken = default);
        AuBusinessTimesheetSettingsModel GetTheTimesheetSettingsForTheBusiness(int businessId);
        Task<AuBusinessTimesheetSettingsModel> GetTheTimesheetSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default);
        AuBusinessTimesheetSettingsModel UpdateTheTimesheetSettingsForTheBusiness(int businessId, AuBusinessTimesheetSettingsModel model);
        Task<AuBusinessTimesheetSettingsModel> UpdateTheTimesheetSettingsForTheBusinessAsync(int businessId, AuBusinessTimesheetSettingsModel model, CancellationToken cancellationToken = default);
        AuEmployeePortalSettingsModel GetEmployeePortalSettings(int businessId);
        Task<AuEmployeePortalSettingsModel> GetEmployeePortalSettingsAsync(int businessId, CancellationToken cancellationToken = default);
        AuEmployeePortalSettingsModel UpdateEmployeePortalSettings(int businessId, AuEmployeePortalSettingsModel model);
        Task<AuEmployeePortalSettingsModel> UpdateEmployeePortalSettingsAsync(int businessId, AuEmployeePortalSettingsModel model, CancellationToken cancellationToken = default);
        AuEditBusinessPaySlipApiModel GetPayslipConfiguration(int businessId);
        Task<AuEditBusinessPaySlipApiModel> GetPayslipConfigurationAsync(int businessId, CancellationToken cancellationToken = default);
        void CreatePayslipConfiguration(int businessId, AuEditBusinessPaySlipApiModel model);
        Task CreatePayslipConfigurationAsync(int businessId, AuEditBusinessPaySlipApiModel model, CancellationToken cancellationToken = default);
        List<AuBillingPlanResponseModel> ListBillingPlans(int businessId);
        Task<List<AuBillingPlanResponseModel>> ListBillingPlansAsync(int businessId, CancellationToken cancellationToken = default);
        AuBillingPlanResponseModel GetBusinessBillingPlan(int businessId);
        Task<AuBillingPlanResponseModel> GetBusinessBillingPlanAsync(int businessId, CancellationToken cancellationToken = default);
        void SetBusinessBillingPlan(int businessId, SetBillingPlanRequestModel model);
        Task SetBusinessBillingPlanAsync(int businessId, SetBillingPlanRequestModel model, CancellationToken cancellationToken = default);
        BusinessAtoSupplierModel GetAtoDetails(int businessId);
        Task<BusinessAtoSupplierModel> GetAtoDetailsAsync(int businessId, CancellationToken cancellationToken = default);
        BusinessAtoSupplierModel SetAtoDetails(int businessId, BusinessAtoSupplierModel model);
        Task<BusinessAtoSupplierModel> SetAtoDetailsAsync(int businessId, BusinessAtoSupplierModel model, CancellationToken cancellationToken = default);
        void GetTheLeaveSettingsForTheBusiness(int businessId);
        Task GetTheLeaveSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default);
        void UpdateTheLeaveSettingsForTheBusiness(int businessId, AuBusinessLeaveSettingsModel model);
        Task UpdateTheLeaveSettingsForTheBusinessAsync(int businessId, AuBusinessLeaveSettingsModel model, CancellationToken cancellationToken = default);
        AuStpRegistrationModel GetStpRegistrationDetails(int businessId);
        Task<AuStpRegistrationModel> GetStpRegistrationDetailsAsync(int businessId, CancellationToken cancellationToken = default);
        AuStpRegistrationModel ApplyStpRegistrationDetails(int businessId, AuStpRegistrationModel stpRegistrationModel);
        Task<AuStpRegistrationModel> ApplyStpRegistrationDetailsAsync(int businessId, AuStpRegistrationModel stpRegistrationModel, CancellationToken cancellationToken = default);
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
        public List<AuBusinessExportModel> ListBusinesses(ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<AuBusinessExportModel>>($"/business{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Businesses
        /// </summary>
        /// <remarks>
        /// Lists all the businesses associated with the current user.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<AuBusinessExportModel>> ListBusinessesAsync(ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuBusinessExportModel>>($"/business{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public AuBusinessExportModel CreateNewBusiness(AuBusinessExportModel model)
        {
            return ApiRequest<AuBusinessExportModel,AuBusinessExportModel>($"/business", model, Method.Post);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public Task<AuBusinessExportModel> CreateNewBusinessAsync(AuBusinessExportModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuBusinessExportModel,AuBusinessExportModel>($"/business", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public AuBusinessExportModel CreateNewBusiness(AuBusinessExportModel model, CreateNewBusinessQueryModel request)
        {
            return ApiRequest<AuBusinessExportModel,AuBusinessExportModel>($"/business?setupDefaultData={request.SetupDefaultData}", model, Method.Post);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public Task<AuBusinessExportModel> CreateNewBusinessAsync(AuBusinessExportModel model, CreateNewBusinessQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuBusinessExportModel,AuBusinessExportModel>($"/business?setupDefaultData={request.SetupDefaultData}", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Business Details
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified ID.
        /// </remarks>
        public AuBusinessExportModel GetBusinessDetails(int businessId)
        {
            return ApiRequest<AuBusinessExportModel>($"/business/{businessId}", Method.Get);
        }

        /// <summary>
        /// Get Business Details
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified ID.
        /// </remarks>
        public Task<AuBusinessExportModel> GetBusinessDetailsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuBusinessExportModel>($"/business/{businessId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public AuBusinessExportModel GetBusinessDetailsByExternalId()
        {
            return ApiRequest<AuBusinessExportModel>($"/business/externalid", Method.Get);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public Task<AuBusinessExportModel> GetBusinessDetailsByExternalIdAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuBusinessExportModel>($"/business/externalid", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public AuBusinessExportModel GetBusinessDetailsByExternalId(GetBusinessDetailsByExternalIdQueryModel request)
        {
            return ApiRequest<AuBusinessExportModel>($"/business/externalid?externalId={request.ExternalId}", Method.Get);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public Task<AuBusinessExportModel> GetBusinessDetailsByExternalIdAsync(GetBusinessDetailsByExternalIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuBusinessExportModel>($"/business/externalid?externalId={request.ExternalId}", Method.Get, cancellationToken);
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
        public AuBusinessTimesheetSettingsModel GetTheTimesheetSettingsForTheBusiness(int businessId)
        {
            return ApiRequest<AuBusinessTimesheetSettingsModel>($"/business/{businessId}/timesheetsettings", Method.Get);
        }

        /// <summary>
        /// Get the timesheet settings for the business
        /// </summary>
        public Task<AuBusinessTimesheetSettingsModel> GetTheTimesheetSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuBusinessTimesheetSettingsModel>($"/business/{businessId}/timesheetsettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update the timesheet settings for the business
        /// </summary>
        public AuBusinessTimesheetSettingsModel UpdateTheTimesheetSettingsForTheBusiness(int businessId, AuBusinessTimesheetSettingsModel model)
        {
            return ApiRequest<AuBusinessTimesheetSettingsModel,AuBusinessTimesheetSettingsModel>($"/business/{businessId}/timesheetsettings", model, Method.Put);
        }

        /// <summary>
        /// Update the timesheet settings for the business
        /// </summary>
        public Task<AuBusinessTimesheetSettingsModel> UpdateTheTimesheetSettingsForTheBusinessAsync(int businessId, AuBusinessTimesheetSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuBusinessTimesheetSettingsModel,AuBusinessTimesheetSettingsModel>($"/business/{businessId}/timesheetsettings", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public AuEmployeePortalSettingsModel GetEmployeePortalSettings(int businessId)
        {
            return ApiRequest<AuEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", Method.Get);
        }

        /// <summary>
        /// Get Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public Task<AuEmployeePortalSettingsModel> GetEmployeePortalSettingsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public AuEmployeePortalSettingsModel UpdateEmployeePortalSettings(int businessId, AuEmployeePortalSettingsModel model)
        {
            return ApiRequest<AuEmployeePortalSettingsModel,AuEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", model, Method.Post);
        }

        /// <summary>
        /// Update Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public Task<AuEmployeePortalSettingsModel> UpdateEmployeePortalSettingsAsync(int businessId, AuEmployeePortalSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuEmployeePortalSettingsModel,AuEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get payslip configuration
        /// </summary>
        /// <remarks>
        /// Gets the payslip configuration for the specified business ID.
        /// </remarks>
        public AuEditBusinessPaySlipApiModel GetPayslipConfiguration(int businessId)
        {
            return ApiRequest<AuEditBusinessPaySlipApiModel>($"/business/{businessId}/payslip", Method.Get);
        }

        /// <summary>
        /// Get payslip configuration
        /// </summary>
        /// <remarks>
        /// Gets the payslip configuration for the specified business ID.
        /// </remarks>
        public Task<AuEditBusinessPaySlipApiModel> GetPayslipConfigurationAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuEditBusinessPaySlipApiModel>($"/business/{businessId}/payslip", Method.Get, cancellationToken);
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
        public void CreatePayslipConfiguration(int businessId, AuEditBusinessPaySlipApiModel model)
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
        public Task CreatePayslipConfigurationAsync(int businessId, AuEditBusinessPaySlipApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payslip", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Billing Plans
        /// </summary>
        /// <remarks>
        /// Lists all the billing plans available for the current business.
        /// </remarks>
        public List<AuBillingPlanResponseModel> ListBillingPlans(int businessId)
        {
            return ApiRequest<List<AuBillingPlanResponseModel>>($"/business/{businessId}/subscription/billingplans", Method.Get);
        }

        /// <summary>
        /// List Billing Plans
        /// </summary>
        /// <remarks>
        /// Lists all the billing plans available for the current business.
        /// </remarks>
        public Task<List<AuBillingPlanResponseModel>> ListBillingPlansAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuBillingPlanResponseModel>>($"/business/{businessId}/subscription/billingplans", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Billing PLan
        /// </summary>
        /// <remarks>
        /// Get the current billing plan for the business.
        /// </remarks>
        public AuBillingPlanResponseModel GetBusinessBillingPlan(int businessId)
        {
            return ApiRequest<AuBillingPlanResponseModel>($"/business/{businessId}/subscription/currentbillingplan", Method.Get);
        }

        /// <summary>
        /// Get Business Billing PLan
        /// </summary>
        /// <remarks>
        /// Get the current billing plan for the business.
        /// </remarks>
        public Task<AuBillingPlanResponseModel> GetBusinessBillingPlanAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuBillingPlanResponseModel>($"/business/{businessId}/subscription/currentbillingplan", Method.Get, cancellationToken);
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

        /// <summary>
        /// Get ATO Details
        /// </summary>
        /// <remarks>
        /// Gets the ATO details for the business.
        /// </remarks>
        public BusinessAtoSupplierModel GetAtoDetails(int businessId)
        {
            return ApiRequest<BusinessAtoSupplierModel>($"/business/{businessId}/ato", Method.Get);
        }

        /// <summary>
        /// Get ATO Details
        /// </summary>
        /// <remarks>
        /// Gets the ATO details for the business.
        /// </remarks>
        public Task<BusinessAtoSupplierModel> GetAtoDetailsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<BusinessAtoSupplierModel>($"/business/{businessId}/ato", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set ATO Details
        /// </summary>
        /// <remarks>
        /// Sets the ATO details for the business.
        /// </remarks>
        public BusinessAtoSupplierModel SetAtoDetails(int businessId, BusinessAtoSupplierModel model)
        {
            return ApiRequest<BusinessAtoSupplierModel,BusinessAtoSupplierModel>($"/business/{businessId}/ato", model, Method.Post);
        }

        /// <summary>
        /// Set ATO Details
        /// </summary>
        /// <remarks>
        /// Sets the ATO details for the business.
        /// </remarks>
        public Task<BusinessAtoSupplierModel> SetAtoDetailsAsync(int businessId, BusinessAtoSupplierModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<BusinessAtoSupplierModel,BusinessAtoSupplierModel>($"/business/{businessId}/ato", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get the leave settings for the business
        /// </summary>
        public void GetTheLeaveSettingsForTheBusiness(int businessId)
        {
            ApiRequest($"/business/{businessId}/leavesettings", Method.Get);
        }

        /// <summary>
        /// Get the leave settings for the business
        /// </summary>
        public Task GetTheLeaveSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/leavesettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update the leave settings for the business
        /// </summary>
        public void UpdateTheLeaveSettingsForTheBusiness(int businessId, AuBusinessLeaveSettingsModel model)
        {
            ApiRequest($"/business/{businessId}/leavesettings", model, Method.Put);
        }

        /// <summary>
        /// Update the leave settings for the business
        /// </summary>
        public Task UpdateTheLeaveSettingsForTheBusinessAsync(int businessId, AuBusinessLeaveSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/leavesettings", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get STP Registration Details
        /// </summary>
        /// <remarks>
        /// Gets the ATO settings already applied for this business
        /// </remarks>
        public AuStpRegistrationModel GetStpRegistrationDetails(int businessId)
        {
            return ApiRequest<AuStpRegistrationModel>($"/business/{businessId}/stpregister", Method.Get);
        }

        /// <summary>
        /// Get STP Registration Details
        /// </summary>
        /// <remarks>
        /// Gets the ATO settings already applied for this business
        /// </remarks>
        public Task<AuStpRegistrationModel> GetStpRegistrationDetailsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuStpRegistrationModel>($"/business/{businessId}/stpregister", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Apply STP Registration Details
        /// </summary>
        /// <remarks>
        /// Registers the business for STP using the ATO settings supplied
        /// </remarks>
        public AuStpRegistrationModel ApplyStpRegistrationDetails(int businessId, AuStpRegistrationModel stpRegistrationModel)
        {
            return ApiRequest<AuStpRegistrationModel,AuStpRegistrationModel>($"/business/{businessId}/stpregister", stpRegistrationModel, Method.Post);
        }

        /// <summary>
        /// Apply STP Registration Details
        /// </summary>
        /// <remarks>
        /// Registers the business for STP using the ATO settings supplied
        /// </remarks>
        public Task<AuStpRegistrationModel> ApplyStpRegistrationDetailsAsync(int businessId, AuStpRegistrationModel stpRegistrationModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuStpRegistrationModel,AuStpRegistrationModel>($"/business/{businessId}/stpregister", stpRegistrationModel, Method.Post, cancellationToken);
        }
    }
}
