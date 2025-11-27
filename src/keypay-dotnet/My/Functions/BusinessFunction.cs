using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.Business;

namespace KeyPayV2.My.Functions
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
        List<MyBusinessExportModel> ListBusinesses(ODataQuery oDataQuery = null);
        Task<List<MyBusinessExportModel>> ListBusinessesAsync(ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        MyBusinessExportModel CreateNewBusiness(MyBusinessExportModel model);
        Task<MyBusinessExportModel> CreateNewBusinessAsync(MyBusinessExportModel model, CancellationToken cancellationToken = default);
        MyBusinessExportModel CreateNewBusiness(MyBusinessExportModel model, CreateNewBusinessQueryModel request);
        Task<MyBusinessExportModel> CreateNewBusinessAsync(MyBusinessExportModel model, CreateNewBusinessQueryModel request, CancellationToken cancellationToken = default);
        MyBusinessExportModel UpdateBusinessDetails(MyEditBusinessDetailsApiModel model);
        Task<MyBusinessExportModel> UpdateBusinessDetailsAsync(MyEditBusinessDetailsApiModel model, CancellationToken cancellationToken = default);
        MyBusinessExportModel GetBusinessDetails(int businessId);
        Task<MyBusinessExportModel> GetBusinessDetailsAsync(int businessId, CancellationToken cancellationToken = default);
        MyBusinessExportModel GetBusinessDetailsByExternalId();
        Task<MyBusinessExportModel> GetBusinessDetailsByExternalIdAsync(CancellationToken cancellationToken = default);
        MyBusinessExportModel GetBusinessDetailsByExternalId(GetBusinessDetailsByExternalIdQueryModel request);
        Task<MyBusinessExportModel> GetBusinessDetailsByExternalIdAsync(GetBusinessDetailsByExternalIdQueryModel request, CancellationToken cancellationToken = default);
        void CopyBusinessSettingsFromTemplate(int businessId, int businessTemplateId);
        Task CopyBusinessSettingsFromTemplateAsync(int businessId, int businessTemplateId, CancellationToken cancellationToken = default);
        MyBusinessTimesheetSettingsModel GetTheTimesheetSettingsForTheBusiness(int businessId);
        Task<MyBusinessTimesheetSettingsModel> GetTheTimesheetSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default);
        MyBusinessTimesheetSettingsModel UpdateTheTimesheetSettingsForTheBusiness(int businessId, MyBusinessTimesheetSettingsModel model);
        Task<MyBusinessTimesheetSettingsModel> UpdateTheTimesheetSettingsForTheBusinessAsync(int businessId, MyBusinessTimesheetSettingsModel model, CancellationToken cancellationToken = default);
        MyEmployeePortalSettingsModel GetEmployeePortalSettings(int businessId);
        Task<MyEmployeePortalSettingsModel> GetEmployeePortalSettingsAsync(int businessId, CancellationToken cancellationToken = default);
        MyEmployeePortalSettingsModel UpdateEmployeePortalSettings(int businessId, MyEmployeePortalSettingsModel model);
        Task<MyEmployeePortalSettingsModel> UpdateEmployeePortalSettingsAsync(int businessId, MyEmployeePortalSettingsModel model, CancellationToken cancellationToken = default);
        MyEditBusinessPaySlipApiModel GetPayslipConfiguration(int businessId);
        Task<MyEditBusinessPaySlipApiModel> GetPayslipConfigurationAsync(int businessId, CancellationToken cancellationToken = default);
        void CreatePayslipConfiguration(int businessId, MyEditBusinessPaySlipApiModel model);
        Task CreatePayslipConfigurationAsync(int businessId, MyEditBusinessPaySlipApiModel model, CancellationToken cancellationToken = default);
        List<BillingPlanResponseModel> ListBillingPlans(int businessId);
        Task<List<BillingPlanResponseModel>> ListBillingPlansAsync(int businessId, CancellationToken cancellationToken = default);
        BillingPlanResponseModel GetBusinessBillingPlan(int businessId);
        Task<BillingPlanResponseModel> GetBusinessBillingPlanAsync(int businessId, CancellationToken cancellationToken = default);
        void SetBusinessBillingPlan(int businessId, SetBillingPlanRequestModel model);
        Task SetBusinessBillingPlanAsync(int businessId, SetBillingPlanRequestModel model, CancellationToken cancellationToken = default);
        List<MyBankDetailsModel> ListPaymentFiles(int businessId, ODataQuery oDataQuery = null);
        Task<List<MyBankDetailsModel>> ListPaymentFilesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void CreateNewPaymentFileRecord(int businessId, MyBankDetailsModel model);
        Task CreateNewPaymentFileRecordAsync(int businessId, MyBankDetailsModel model, CancellationToken cancellationToken = default);
        MyBankDetailsModel GetPaymentFileById(int businessId, int id);
        Task<MyBankDetailsModel> GetPaymentFileByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void UpdatePaymentFileRecord(int businessId, int id, MyBankDetailsModel model);
        Task UpdatePaymentFileRecordAsync(int businessId, int id, MyBankDetailsModel model, CancellationToken cancellationToken = default);
        void DeletePaymentFileRecord(int businessId, int id);
        Task DeletePaymentFileRecordAsync(int businessId, int id, CancellationToken cancellationToken = default);
        MyBusinessStatutorySettingsModel GetStatutorySettings(int businessId);
        Task<MyBusinessStatutorySettingsModel> GetStatutorySettingsAsync(int businessId, CancellationToken cancellationToken = default);
        MyBusinessStatutorySettingsModel SetStatutorySettings(int businessId, MyBusinessStatutorySettingsModel model);
        Task<MyBusinessStatutorySettingsModel> SetStatutorySettingsAsync(int businessId, MyBusinessStatutorySettingsModel model, CancellationToken cancellationToken = default);
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
        public List<MyBusinessExportModel> ListBusinesses(ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<MyBusinessExportModel>>($"/business{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Businesses
        /// </summary>
        /// <remarks>
        /// Lists all the businesses associated with the current user.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<MyBusinessExportModel>> ListBusinessesAsync(ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyBusinessExportModel>>($"/business{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public MyBusinessExportModel CreateNewBusiness(MyBusinessExportModel model)
        {
            return ApiRequest<MyBusinessExportModel,MyBusinessExportModel>($"/business", model, Method.Post);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public Task<MyBusinessExportModel> CreateNewBusinessAsync(MyBusinessExportModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessExportModel,MyBusinessExportModel>($"/business", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public MyBusinessExportModel CreateNewBusiness(MyBusinessExportModel model, CreateNewBusinessQueryModel request)
        {
            return ApiRequest<MyBusinessExportModel,MyBusinessExportModel>($"/business?setupDefaultData={request.SetupDefaultData}", model, Method.Post);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public Task<MyBusinessExportModel> CreateNewBusinessAsync(MyBusinessExportModel model, CreateNewBusinessQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessExportModel,MyBusinessExportModel>($"/business?setupDefaultData={request.SetupDefaultData}", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Update Business Details
        /// </summary>
        /// <remarks>
        /// Update some standard business details
        /// </remarks>
        public MyBusinessExportModel UpdateBusinessDetails(MyEditBusinessDetailsApiModel model)
        {
            return ApiRequest<MyBusinessExportModel,MyEditBusinessDetailsApiModel>($"/business", model, Method.Put);
        }

        /// <summary>
        /// Update Business Details
        /// </summary>
        /// <remarks>
        /// Update some standard business details
        /// </remarks>
        public Task<MyBusinessExportModel> UpdateBusinessDetailsAsync(MyEditBusinessDetailsApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessExportModel,MyEditBusinessDetailsApiModel>($"/business", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Business Details
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified ID.
        /// </remarks>
        public MyBusinessExportModel GetBusinessDetails(int businessId)
        {
            return ApiRequest<MyBusinessExportModel>($"/business/{businessId}", Method.Get);
        }

        /// <summary>
        /// Get Business Details
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified ID.
        /// </remarks>
        public Task<MyBusinessExportModel> GetBusinessDetailsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessExportModel>($"/business/{businessId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public MyBusinessExportModel GetBusinessDetailsByExternalId()
        {
            return ApiRequest<MyBusinessExportModel>($"/business/externalid", Method.Get);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public Task<MyBusinessExportModel> GetBusinessDetailsByExternalIdAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessExportModel>($"/business/externalid", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public MyBusinessExportModel GetBusinessDetailsByExternalId(GetBusinessDetailsByExternalIdQueryModel request)
        {
            return ApiRequest<MyBusinessExportModel>($"/business/externalid?externalId={request.ExternalId}", Method.Get);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public Task<MyBusinessExportModel> GetBusinessDetailsByExternalIdAsync(GetBusinessDetailsByExternalIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessExportModel>($"/business/externalid?externalId={request.ExternalId}", Method.Get, cancellationToken);
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
        public MyBusinessTimesheetSettingsModel GetTheTimesheetSettingsForTheBusiness(int businessId)
        {
            return ApiRequest<MyBusinessTimesheetSettingsModel>($"/business/{businessId}/timesheetsettings", Method.Get);
        }

        /// <summary>
        /// Get the timesheet settings for the business
        /// </summary>
        public Task<MyBusinessTimesheetSettingsModel> GetTheTimesheetSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessTimesheetSettingsModel>($"/business/{businessId}/timesheetsettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update the timesheet settings for the business
        /// </summary>
        public MyBusinessTimesheetSettingsModel UpdateTheTimesheetSettingsForTheBusiness(int businessId, MyBusinessTimesheetSettingsModel model)
        {
            return ApiRequest<MyBusinessTimesheetSettingsModel,MyBusinessTimesheetSettingsModel>($"/business/{businessId}/timesheetsettings", model, Method.Put);
        }

        /// <summary>
        /// Update the timesheet settings for the business
        /// </summary>
        public Task<MyBusinessTimesheetSettingsModel> UpdateTheTimesheetSettingsForTheBusinessAsync(int businessId, MyBusinessTimesheetSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessTimesheetSettingsModel,MyBusinessTimesheetSettingsModel>($"/business/{businessId}/timesheetsettings", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public MyEmployeePortalSettingsModel GetEmployeePortalSettings(int businessId)
        {
            return ApiRequest<MyEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", Method.Get);
        }

        /// <summary>
        /// Get Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public Task<MyEmployeePortalSettingsModel> GetEmployeePortalSettingsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public MyEmployeePortalSettingsModel UpdateEmployeePortalSettings(int businessId, MyEmployeePortalSettingsModel model)
        {
            return ApiRequest<MyEmployeePortalSettingsModel,MyEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", model, Method.Post);
        }

        /// <summary>
        /// Update Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public Task<MyEmployeePortalSettingsModel> UpdateEmployeePortalSettingsAsync(int businessId, MyEmployeePortalSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEmployeePortalSettingsModel,MyEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get payslip configuration
        /// </summary>
        /// <remarks>
        /// Gets the payslip configuration for the specified business ID.
        /// </remarks>
        public MyEditBusinessPaySlipApiModel GetPayslipConfiguration(int businessId)
        {
            return ApiRequest<MyEditBusinessPaySlipApiModel>($"/business/{businessId}/payslip", Method.Get);
        }

        /// <summary>
        /// Get payslip configuration
        /// </summary>
        /// <remarks>
        /// Gets the payslip configuration for the specified business ID.
        /// </remarks>
        public Task<MyEditBusinessPaySlipApiModel> GetPayslipConfigurationAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEditBusinessPaySlipApiModel>($"/business/{businessId}/payslip", Method.Get, cancellationToken);
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
        public void CreatePayslipConfiguration(int businessId, MyEditBusinessPaySlipApiModel model)
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
        public Task CreatePayslipConfigurationAsync(int businessId, MyEditBusinessPaySlipApiModel model, CancellationToken cancellationToken = default)
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

        /// <summary>
        /// List payment files
        /// </summary>
        /// <remarks>
        /// Retrieves all the payment files associated with the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<MyBankDetailsModel> ListPaymentFiles(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<MyBankDetailsModel>>($"/business/{businessId}/paymentfiles{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List payment files
        /// </summary>
        /// <remarks>
        /// Retrieves all the payment files associated with the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<MyBankDetailsModel>> ListPaymentFilesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyBankDetailsModel>>($"/business/{businessId}/paymentfiles{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create new payment file record
        /// </summary>
        /// <remarks>
        /// Creates a new payment file record for the business.
        /// </remarks>
        public void CreateNewPaymentFileRecord(int businessId, MyBankDetailsModel model)
        {
            ApiRequest($"/business/{businessId}/paymentfiles", model, Method.Post);
        }

        /// <summary>
        /// Create new payment file record
        /// </summary>
        /// <remarks>
        /// Creates a new payment file record for the business.
        /// </remarks>
        public Task CreateNewPaymentFileRecordAsync(int businessId, MyBankDetailsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paymentfiles", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get payment file by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the payment file with the specified ID.
        /// </remarks>
        public MyBankDetailsModel GetPaymentFileById(int businessId, int id)
        {
            return ApiRequest<MyBankDetailsModel>($"/business/{businessId}/paymentfiles/{id}", Method.Get);
        }

        /// <summary>
        /// Get payment file by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the payment file with the specified ID.
        /// </remarks>
        public Task<MyBankDetailsModel> GetPaymentFileByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBankDetailsModel>($"/business/{businessId}/paymentfiles/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update payment file record
        /// </summary>
        /// <remarks>
        /// Updates the payment file record with the specified ID.
        /// </remarks>
        public void UpdatePaymentFileRecord(int businessId, int id, MyBankDetailsModel model)
        {
            ApiRequest($"/business/{businessId}/paymentfiles/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update payment file record
        /// </summary>
        /// <remarks>
        /// Updates the payment file record with the specified ID.
        /// </remarks>
        public Task UpdatePaymentFileRecordAsync(int businessId, int id, MyBankDetailsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paymentfiles/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete payment file record
        /// </summary>
        /// <remarks>
        /// Deletes the payment file record with the specified ID.
        /// </remarks>
        public void DeletePaymentFileRecord(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/paymentfiles/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete payment file record
        /// </summary>
        /// <remarks>
        /// Deletes the payment file record with the specified ID.
        /// </remarks>
        public Task DeletePaymentFileRecordAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paymentfiles/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Settings
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Settings for the business
        /// </remarks>
        public MyBusinessStatutorySettingsModel GetStatutorySettings(int businessId)
        {
            return ApiRequest<MyBusinessStatutorySettingsModel>($"/business/{businessId}/statutorysettings", Method.Get);
        }

        /// <summary>
        /// Get Statutory Settings
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Settings for the business
        /// </remarks>
        public Task<MyBusinessStatutorySettingsModel> GetStatutorySettingsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessStatutorySettingsModel>($"/business/{businessId}/statutorysettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Statutory Settings
        /// </summary>
        /// <remarks>
        /// Sets the Statutory Settings for the business
        /// </remarks>
        public MyBusinessStatutorySettingsModel SetStatutorySettings(int businessId, MyBusinessStatutorySettingsModel model)
        {
            return ApiRequest<MyBusinessStatutorySettingsModel,MyBusinessStatutorySettingsModel>($"/business/{businessId}/statutorysettings", model, Method.Post);
        }

        /// <summary>
        /// Set Statutory Settings
        /// </summary>
        /// <remarks>
        /// Sets the Statutory Settings for the business
        /// </remarks>
        public Task<MyBusinessStatutorySettingsModel> SetStatutorySettingsAsync(int businessId, MyBusinessStatutorySettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessStatutorySettingsModel,MyBusinessStatutorySettingsModel>($"/business/{businessId}/statutorysettings", model, Method.Post, cancellationToken);
        }
    }
}
