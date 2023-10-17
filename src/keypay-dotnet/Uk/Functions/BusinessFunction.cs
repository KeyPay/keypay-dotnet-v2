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
using KeyPayV2.Uk.Models.Business;

namespace KeyPayV2.Uk.Functions
{
    public interface IBusinessFunction
    {
        List<UkBusinessExportModel> ListBusinesses(ODataQuery oDataQuery = null);
        Task<List<UkBusinessExportModel>> ListBusinessesAsync(ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        UkBusinessExportModel UpdateBusinessDetails(UkEditBusinessDetailsApiModel model);
        Task<UkBusinessExportModel> UpdateBusinessDetailsAsync(UkEditBusinessDetailsApiModel model, CancellationToken cancellationToken = default);
        UkBusinessExportModel CreateNewBusiness(UkBusinessExportModel model);
        Task<UkBusinessExportModel> CreateNewBusinessAsync(UkBusinessExportModel model, CancellationToken cancellationToken = default);
        UkBusinessExportModel CreateNewBusiness(UkBusinessExportModel model, CreateNewBusinessQueryModel request);
        Task<UkBusinessExportModel> CreateNewBusinessAsync(UkBusinessExportModel model, CreateNewBusinessQueryModel request, CancellationToken cancellationToken = default);
        UkBusinessExportModel GetBusinessDetails(int businessId);
        Task<UkBusinessExportModel> GetBusinessDetailsAsync(int businessId, CancellationToken cancellationToken = default);
        void CopyBusinessSettingsFromTemplate(int businessId, int businessTemplateId);
        Task CopyBusinessSettingsFromTemplateAsync(int businessId, int businessTemplateId, CancellationToken cancellationToken = default);
        List<BusinessAccessModel> ListAllBusinessAccessUsers(int businessId, ODataQuery oDataQuery = null);
        Task<List<BusinessAccessModel>> ListAllBusinessAccessUsersAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void UpdateDetailsOfAnAssociatedUser(int businessId, AccessModel viewModel, UpdateDetailsOfAnAssociatedUserQueryModel request);
        Task UpdateDetailsOfAnAssociatedUserAsync(int businessId, AccessModel viewModel, UpdateDetailsOfAnAssociatedUserQueryModel request, CancellationToken cancellationToken = default);
        void AssignBusinessAccess(int businessId, CreateBusinessAccessModel viewModel);
        Task AssignBusinessAccessAsync(int businessId, CreateBusinessAccessModel viewModel, CancellationToken cancellationToken = default);
        void RevokeBusinessAccess(int businessId, RevokeBusinessAccessQueryModel request);
        Task RevokeBusinessAccessAsync(int businessId, RevokeBusinessAccessQueryModel request, CancellationToken cancellationToken = default);
        BusinessAccessModel GetUserBusinessAccess(int businessId, GetUserBusinessAccessQueryModel request);
        Task<BusinessAccessModel> GetUserBusinessAccessAsync(int businessId, GetUserBusinessAccessQueryModel request, CancellationToken cancellationToken = default);
        List<BusinessAction> ListBusinessNotifications(int businessId);
        Task<List<BusinessAction>> ListBusinessNotificationsAsync(int businessId, CancellationToken cancellationToken = default);
        void DismissBusinessNotifications(int businessId, int id);
        Task DismissBusinessNotificationsAsync(int businessId, int id, CancellationToken cancellationToken = default);
        List<UkBacsApiModel> ListBacsSettings(int businessId);
        Task<List<UkBacsApiModel>> ListBacsSettingsAsync(int businessId, CancellationToken cancellationToken = default);
        UkBacsApiModel CreateBacsSettingsRecord(int businessId, UkBacsApiModel model);
        Task<UkBacsApiModel> CreateBacsSettingsRecordAsync(int businessId, UkBacsApiModel model, CancellationToken cancellationToken = default);
        UkBacsApiModel GetBacsSettingsRecordById(int businessId, int id);
        Task<UkBacsApiModel> GetBacsSettingsRecordByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        UkBacsApiModel UpdateBacsSettingsRecord(int businessId, int id, UkBacsApiModel model);
        Task<UkBacsApiModel> UpdateBacsSettingsRecordAsync(int businessId, int id, UkBacsApiModel model, CancellationToken cancellationToken = default);
        void DeleteBacsSettingsRecord(int businessId, int id);
        Task DeleteBacsSettingsRecordAsync(int businessId, int id, CancellationToken cancellationToken = default);
        List<DocumentModel> ListBusinessDocumentDetails(int businessId);
        Task<List<DocumentModel>> ListBusinessDocumentDetailsAsync(int businessId, CancellationToken cancellationToken = default);
        List<DocumentModel> CreateBusinessDocument(int businessId, FileUploadModel file);
        Task<List<DocumentModel>> CreateBusinessDocumentAsync(int businessId, FileUploadModel file, CancellationToken cancellationToken = default);
        List<DocumentModel> CreateBusinessDocument(int businessId, FileUploadModel file, CreateBusinessDocumentQueryModel request);
        Task<List<DocumentModel>> CreateBusinessDocumentAsync(int businessId, FileUploadModel file, CreateBusinessDocumentQueryModel request, CancellationToken cancellationToken = default);
        DocumentModel GetBusinessDocumentDetails(int businessId, int id);
        Task<DocumentModel> GetBusinessDocumentDetailsAsync(int businessId, int id, CancellationToken cancellationToken = default);
        DocumentModel UpdateBusinessDocumentPermissions(int businessId, int id, UpdateDocumentPermissionsModel model);
        Task<DocumentModel> UpdateBusinessDocumentPermissionsAsync(int businessId, int id, UpdateDocumentPermissionsModel model, CancellationToken cancellationToken = default);
        void DeleteBusinessDocument(int businessId, int id);
        Task DeleteBusinessDocumentAsync(int businessId, int id, CancellationToken cancellationToken = default);
        DocumentFile GetBusinessDocumentContent(int businessId, int id);
        Task<DocumentFile> GetBusinessDocumentContentAsync(int businessId, int id, CancellationToken cancellationToken = default);
        List<UkLocationModel> ListEmployeeLocations(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<UkLocationModel>> ListEmployeeLocationsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        EmployeePortalSettingsModel GetEmployeePortalSettings(int businessId);
        Task<EmployeePortalSettingsModel> GetEmployeePortalSettingsAsync(int businessId, CancellationToken cancellationToken = default);
        EmployeePortalSettingsModel UpdateEmployeePortalSettings(int businessId, EmployeePortalSettingsModel model);
        Task<EmployeePortalSettingsModel> UpdateEmployeePortalSettingsAsync(int businessId, EmployeePortalSettingsModel model, CancellationToken cancellationToken = default);
        EntitlementsModel ListEntitlements(int businessId);
        Task<EntitlementsModel> ListEntitlementsAsync(int businessId, CancellationToken cancellationToken = default);
        HmrcSettingsResponseModel GetHmrcSettings(int businessId);
        Task<HmrcSettingsResponseModel> GetHmrcSettingsAsync(int businessId, CancellationToken cancellationToken = default);
        HmrcSettingsResponseModel UpdateHmrcSettings(int businessId, HmrcSettingsRequestModel model);
        Task<HmrcSettingsResponseModel> UpdateHmrcSettingsAsync(int businessId, HmrcSettingsRequestModel model, CancellationToken cancellationToken = default);
        UkEmploymentAllowanceModel GetEmploymentAllowanceSettings(int businessId, GetEmploymentAllowanceSettingsQueryModel request);
        Task<UkEmploymentAllowanceModel> GetEmploymentAllowanceSettingsAsync(int businessId, GetEmploymentAllowanceSettingsQueryModel request, CancellationToken cancellationToken = default);
        UkEmploymentAllowanceModel UpdateEmploymentAllowanceSettings(int businessId, UkEmploymentAllowanceModel model);
        Task<UkEmploymentAllowanceModel> UpdateEmploymentAllowanceSettingsAsync(int businessId, UkEmploymentAllowanceModel model, CancellationToken cancellationToken = default);
        HmrcSettingsRequestModel HmrcSettings_DeleteHmrcPaymentReminder(int businessId);
        Task<HmrcSettingsRequestModel> HmrcSettings_DeleteHmrcPaymentReminderAsync(int businessId, CancellationToken cancellationToken = default);
        HmrcSettingsResponseModel SimpleUpdateEmployerHmrcSettings(int businessId, SimpleHmrcSettingsRequestModel model);
        Task<HmrcSettingsResponseModel> SimpleUpdateEmployerHmrcSettingsAsync(int businessId, SimpleHmrcSettingsRequestModel model, CancellationToken cancellationToken = default);
        void ChangeTheTaxYear(int businessId, ChangeTheTaxYearQueryModel request);
        Task ChangeTheTaxYearAsync(int businessId, ChangeTheTaxYearQueryModel request, CancellationToken cancellationToken = default);
        void GetTheLeaveSettingsForTheBusiness(int businessId);
        Task GetTheLeaveSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default);
        void UpdateTheLeaveSettingsForTheBusiness(int businessId, UkBusinessLeaveSettingsModel model);
        Task UpdateTheLeaveSettingsForTheBusinessAsync(int businessId, UkBusinessLeaveSettingsModel model, CancellationToken cancellationToken = default);
        List<UkLocationModel> ListBusinessLocations(int businessId, ODataQuery oDataQuery = null);
        Task<List<UkLocationModel>> ListBusinessLocationsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        UkLocationModel CreateLocation(int businessId, UkLocationModel location);
        Task<UkLocationModel> CreateLocationAsync(int businessId, UkLocationModel location, CancellationToken cancellationToken = default);
        UkSingleLocationModel GetLocationById(int businessId, int id);
        Task<UkSingleLocationModel> GetLocationByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void UpdateLocation(int businessId, int id, UkLocationModel location);
        Task UpdateLocationAsync(int businessId, int id, UkLocationModel location, CancellationToken cancellationToken = default);
        void DeleteLocation(int businessId, int id);
        Task DeleteLocationAsync(int businessId, int id, CancellationToken cancellationToken = default);
        UkEditBusinessPaySlipApiModel GetPayslipConfiguration(int businessId);
        Task<UkEditBusinessPaySlipApiModel> GetPayslipConfigurationAsync(int businessId, CancellationToken cancellationToken = default);
        void CreatePayslipConfiguration(int businessId, UkEditBusinessPaySlipApiModel model);
        Task CreatePayslipConfigurationAsync(int businessId, UkEditBusinessPaySlipApiModel model, CancellationToken cancellationToken = default);
        TimesheetRoundingRulesModel GetRoundingRules(int businessId);
        Task<TimesheetRoundingRulesModel> GetRoundingRulesAsync(int businessId, CancellationToken cancellationToken = default);
        void SetRoundingRules(int businessId, TimesheetRoundingRulesModel roundingRules);
        Task SetRoundingRulesAsync(int businessId, TimesheetRoundingRulesModel roundingRules, CancellationToken cancellationToken = default);
        List<UkSmpApiRowModel> GetAllStatutoryMaternityLeaveData(int businessId);
        Task<List<UkSmpApiRowModel>> GetAllStatutoryMaternityLeaveDataAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkBillingPlanResponseModel> ListBillingPlans(int businessId);
        Task<List<UkBillingPlanResponseModel>> ListBillingPlansAsync(int businessId, CancellationToken cancellationToken = default);
        UkBillingPlanResponseModel GetBusinessBillingPlans(int businessId);
        Task<UkBillingPlanResponseModel> GetBusinessBillingPlansAsync(int businessId, CancellationToken cancellationToken = default);
        void SetBusinessBillingPlan(int businessId, SetBillingPlanRequestModel model);
        Task SetBusinessBillingPlanAsync(int businessId, SetBillingPlanRequestModel model, CancellationToken cancellationToken = default);
        List<TagViewModel> ListTheBusinessTags(int businessId);
        Task<List<TagViewModel>> ListTheBusinessTagsAsync(int businessId, CancellationToken cancellationToken = default);
        void GetTheTimesheetSettingsForTheBusiness(int businessId);
        Task GetTheTimesheetSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default);
        void UpdateTheTimesheetSettingsForTheBusiness(int businessId, UkBusinessTimesheetSettingsModel model);
        Task UpdateTheTimesheetSettingsForTheBusinessAsync(int businessId, UkBusinessTimesheetSettingsModel model, CancellationToken cancellationToken = default);
        UkBusinessExportModel GetBusinessDetailsByExternalId(GetBusinessDetailsByExternalIdQueryModel request);
        Task<UkBusinessExportModel> GetBusinessDetailsByExternalIdAsync(GetBusinessDetailsByExternalIdQueryModel request, CancellationToken cancellationToken = default);
    }
    public class BusinessFunction : BaseFunction, IBusinessFunction
    {
        public BusinessFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Businesses
        /// </summary>
        /// <remarks>
        /// Lists all the businesses associated with the current user.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<UkBusinessExportModel> ListBusinesses(ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkBusinessExportModel>>($"/business{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Businesses
        /// </summary>
        /// <remarks>
        /// Lists all the businesses associated with the current user.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<UkBusinessExportModel>> ListBusinessesAsync(ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkBusinessExportModel>>($"/business{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Business Details
        /// </summary>
        /// <remarks>
        /// Update some standard business details
        /// </remarks>
        public UkBusinessExportModel UpdateBusinessDetails(UkEditBusinessDetailsApiModel model)
        {
            return ApiRequest<UkBusinessExportModel,UkEditBusinessDetailsApiModel>($"/business", model, Method.Put);
        }

        /// <summary>
        /// Update Business Details
        /// </summary>
        /// <remarks>
        /// Update some standard business details
        /// </remarks>
        public Task<UkBusinessExportModel> UpdateBusinessDetailsAsync(UkEditBusinessDetailsApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBusinessExportModel,UkEditBusinessDetailsApiModel>($"/business", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public UkBusinessExportModel CreateNewBusiness(UkBusinessExportModel model)
        {
            return ApiRequest<UkBusinessExportModel,UkBusinessExportModel>($"/business", model, Method.Post);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public Task<UkBusinessExportModel> CreateNewBusinessAsync(UkBusinessExportModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBusinessExportModel,UkBusinessExportModel>($"/business", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public UkBusinessExportModel CreateNewBusiness(UkBusinessExportModel model, CreateNewBusinessQueryModel request)
        {
            return ApiRequest<UkBusinessExportModel,UkBusinessExportModel>($"/business?setupDefaultData={request.SetupDefaultData}", model, Method.Post);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public Task<UkBusinessExportModel> CreateNewBusinessAsync(UkBusinessExportModel model, CreateNewBusinessQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBusinessExportModel,UkBusinessExportModel>($"/business?setupDefaultData={request.SetupDefaultData}", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Business Details
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified ID.
        /// </remarks>
        public UkBusinessExportModel GetBusinessDetails(int businessId)
        {
            return ApiRequest<UkBusinessExportModel>($"/business/{businessId}", Method.Get);
        }

        /// <summary>
        /// Get Business Details
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified ID.
        /// </remarks>
        public Task<UkBusinessExportModel> GetBusinessDetailsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBusinessExportModel>($"/business/{businessId}", Method.Get, cancellationToken);
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
        /// List All Business Access Users
        /// </summary>
        /// <remarks>
        /// Lists all of the users with access to this business, as well as the types of access they each have.
        /// This operation supports OData queries.
        /// </remarks>
        public List<BusinessAccessModel> ListAllBusinessAccessUsers(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<BusinessAccessModel>>($"/business/{businessId}/access{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List All Business Access Users
        /// </summary>
        /// <remarks>
        /// Lists all of the users with access to this business, as well as the types of access they each have.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<BusinessAccessModel>> ListAllBusinessAccessUsersAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BusinessAccessModel>>($"/business/{businessId}/access{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update details of an associated user
        /// </summary>
        /// <remarks>
        /// Updates the user details (name / email) of a user that is associated with the business.
        /// This endpoint will only work if the user is already associated with the business and is not associated with any other business
        /// </remarks>
        public void UpdateDetailsOfAnAssociatedUser(int businessId, AccessModel viewModel, UpdateDetailsOfAnAssociatedUserQueryModel request)
        {
            ApiRequest($"/business/{businessId}/access?email={request.Email}", viewModel, Method.Put);
        }

        /// <summary>
        /// Update details of an associated user
        /// </summary>
        /// <remarks>
        /// Updates the user details (name / email) of a user that is associated with the business.
        /// This endpoint will only work if the user is already associated with the business and is not associated with any other business
        /// </remarks>
        public Task UpdateDetailsOfAnAssociatedUserAsync(int businessId, AccessModel viewModel, UpdateDetailsOfAnAssociatedUserQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/access?email={request.Email}", viewModel, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Assign Business Access
        /// </summary>
        /// <remarks>
        /// Assigns business access to a name/email.
        /// </remarks>
        public void AssignBusinessAccess(int businessId, CreateBusinessAccessModel viewModel)
        {
            ApiRequest($"/business/{businessId}/access", viewModel, Method.Post);
        }

        /// <summary>
        /// Assign Business Access
        /// </summary>
        /// <remarks>
        /// Assigns business access to a name/email.
        /// </remarks>
        public Task AssignBusinessAccessAsync(int businessId, CreateBusinessAccessModel viewModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/access", viewModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Revoke Business Access
        /// </summary>
        /// <remarks>
        /// Revokes a user's access to the business.
        /// </remarks>
        public void RevokeBusinessAccess(int businessId, RevokeBusinessAccessQueryModel request)
        {
            ApiRequest($"/business/{businessId}/access?email={request.Email}", Method.Delete);
        }

        /// <summary>
        /// Revoke Business Access
        /// </summary>
        /// <remarks>
        /// Revokes a user's access to the business.
        /// </remarks>
        public Task RevokeBusinessAccessAsync(int businessId, RevokeBusinessAccessQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/access?email={request.Email}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get User Business Access
        /// </summary>
        /// <remarks>
        /// Returns the business access assigned to the user with the specified email address.
        /// </remarks>
        public BusinessAccessModel GetUserBusinessAccess(int businessId, GetUserBusinessAccessQueryModel request)
        {
            return ApiRequest<BusinessAccessModel>($"/business/{businessId}/access/user?email={request.Email}", Method.Get);
        }

        /// <summary>
        /// Get User Business Access
        /// </summary>
        /// <remarks>
        /// Returns the business access assigned to the user with the specified email address.
        /// </remarks>
        public Task<BusinessAccessModel> GetUserBusinessAccessAsync(int businessId, GetUserBusinessAccessQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<BusinessAccessModel>($"/business/{businessId}/access/user?email={request.Email}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Business Notifications
        /// </summary>
        /// <remarks>
        /// Lists the notifications, that appear on the Dashboard in the application, for the business.
        /// </remarks>
        public List<BusinessAction> ListBusinessNotifications(int businessId)
        {
            return ApiRequest<List<BusinessAction>>($"/business/{businessId}/actionitems/businessnotifications", Method.Get);
        }

        /// <summary>
        /// List Business Notifications
        /// </summary>
        /// <remarks>
        /// Lists the notifications, that appear on the Dashboard in the application, for the business.
        /// </remarks>
        public Task<List<BusinessAction>> ListBusinessNotificationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BusinessAction>>($"/business/{businessId}/actionitems/businessnotifications", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Dismiss Business Notifications
        /// </summary>
        /// <remarks>
        /// Dismisses a business notification, so that it won't be shown again.
        /// </remarks>
        public void DismissBusinessNotifications(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/actionitems/businessnotifications/{id}/dismiss", Method.Delete);
        }

        /// <summary>
        /// Dismiss Business Notifications
        /// </summary>
        /// <remarks>
        /// Dismisses a business notification, so that it won't be shown again.
        /// </remarks>
        public Task DismissBusinessNotificationsAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/actionitems/businessnotifications/{id}/dismiss", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List BACS Settings
        /// </summary>
        /// <remarks>
        /// Retrieves all the BACS settings associated with the business.
        /// </remarks>
        public List<UkBacsApiModel> ListBacsSettings(int businessId)
        {
            return ApiRequest<List<UkBacsApiModel>>($"/business/{businessId}/bacs", Method.Get);
        }

        /// <summary>
        /// List BACS Settings
        /// </summary>
        /// <remarks>
        /// Retrieves all the BACS settings associated with the business.
        /// </remarks>
        public Task<List<UkBacsApiModel>> ListBacsSettingsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkBacsApiModel>>($"/business/{businessId}/bacs", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create BACS Settings Record
        /// </summary>
        /// <remarks>
        /// Creates a new BACS settings record for the business.
        /// </remarks>
        public UkBacsApiModel CreateBacsSettingsRecord(int businessId, UkBacsApiModel model)
        {
            return ApiRequest<UkBacsApiModel,UkBacsApiModel>($"/business/{businessId}/bacs", model, Method.Post);
        }

        /// <summary>
        /// Create BACS Settings Record
        /// </summary>
        /// <remarks>
        /// Creates a new BACS settings record for the business.
        /// </remarks>
        public Task<UkBacsApiModel> CreateBacsSettingsRecordAsync(int businessId, UkBacsApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBacsApiModel,UkBacsApiModel>($"/business/{businessId}/bacs", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get BACS Settings Record by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the BACS settings record with the specified ID.
        /// </remarks>
        public UkBacsApiModel GetBacsSettingsRecordById(int businessId, int id)
        {
            return ApiRequest<UkBacsApiModel>($"/business/{businessId}/bacs/{id}", Method.Get);
        }

        /// <summary>
        /// Get BACS Settings Record by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the BACS settings record with the specified ID.
        /// </remarks>
        public Task<UkBacsApiModel> GetBacsSettingsRecordByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBacsApiModel>($"/business/{businessId}/bacs/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update BACS Settings Record
        /// </summary>
        /// <remarks>
        /// Updates the BACS settings record with the specified ID of the Bacs record.
        /// </remarks>
        public UkBacsApiModel UpdateBacsSettingsRecord(int businessId, int id, UkBacsApiModel model)
        {
            return ApiRequest<UkBacsApiModel,UkBacsApiModel>($"/business/{businessId}/bacs/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update BACS Settings Record
        /// </summary>
        /// <remarks>
        /// Updates the BACS settings record with the specified ID of the Bacs record.
        /// </remarks>
        public Task<UkBacsApiModel> UpdateBacsSettingsRecordAsync(int businessId, int id, UkBacsApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBacsApiModel,UkBacsApiModel>($"/business/{businessId}/bacs/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete BACS Settings Record
        /// </summary>
        /// <remarks>
        /// Deletes the BACS settings record with the specified ID.
        /// </remarks>
        public void DeleteBacsSettingsRecord(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/bacs/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete BACS Settings Record
        /// </summary>
        /// <remarks>
        /// Deletes the BACS settings record with the specified ID.
        /// </remarks>
        public Task DeleteBacsSettingsRecordAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/bacs/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Business Document Details
        /// </summary>
        /// <remarks>
        /// Lists the details for all of the documents in the business.
        /// </remarks>
        public List<DocumentModel> ListBusinessDocumentDetails(int businessId)
        {
            return ApiRequest<List<DocumentModel>>($"/business/{businessId}/document", Method.Get);
        }

        /// <summary>
        /// List Business Document Details
        /// </summary>
        /// <remarks>
        /// Lists the details for all of the documents in the business.
        /// </remarks>
        public Task<List<DocumentModel>> ListBusinessDocumentDetailsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DocumentModel>>($"/business/{businessId}/document", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Business Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for business. The request should be a MIME multipart file upload request.
        /// </remarks>
        public List<DocumentModel> CreateBusinessDocument(int businessId, FileUploadModel file)
        {
            return ApiRequest<List<DocumentModel>,FileUploadModel>($"/business/{businessId}/document", file, Method.Post);
        }

        /// <summary>
        /// Create Business Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for business. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<List<DocumentModel>> CreateBusinessDocumentAsync(int businessId, FileUploadModel file, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DocumentModel>,FileUploadModel>($"/business/{businessId}/document", file, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Create Business Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for business. The request should be a MIME multipart file upload request.
        /// </remarks>
        public List<DocumentModel> CreateBusinessDocument(int businessId, FileUploadModel file, CreateBusinessDocumentQueryModel request)
        {
            return ApiFileRequest<List<DocumentModel>>($"/business/{businessId}/document?visibleToAll={request.VisibleToAll}", file, Method.Post);
        }

        /// <summary>
        /// Create Business Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for business. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<List<DocumentModel>> CreateBusinessDocumentAsync(int businessId, FileUploadModel file, CreateBusinessDocumentQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiFileRequestAsync<List<DocumentModel>>($"/business/{businessId}/document?visibleToAll={request.VisibleToAll}", file, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Business Document Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the specified business document.
        /// </remarks>
        public DocumentModel GetBusinessDocumentDetails(int businessId, int id)
        {
            return ApiRequest<DocumentModel>($"/business/{businessId}/document/{id}", Method.Get);
        }

        /// <summary>
        /// Get Business Document Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the specified business document.
        /// </remarks>
        public Task<DocumentModel> GetBusinessDocumentDetailsAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DocumentModel>($"/business/{businessId}/document/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Business Document Permissions
        /// </summary>
        /// <remarks>
        /// Updates permissions for the business document with the specified ID.
        /// </remarks>
        public DocumentModel UpdateBusinessDocumentPermissions(int businessId, int id, UpdateDocumentPermissionsModel model)
        {
            return ApiRequest<DocumentModel,UpdateDocumentPermissionsModel>($"/business/{businessId}/document/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Business Document Permissions
        /// </summary>
        /// <remarks>
        /// Updates permissions for the business document with the specified ID.
        /// </remarks>
        public Task<DocumentModel> UpdateBusinessDocumentPermissionsAsync(int businessId, int id, UpdateDocumentPermissionsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DocumentModel,UpdateDocumentPermissionsModel>($"/business/{businessId}/document/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Business Document
        /// </summary>
        /// <remarks>
        /// Deletes the business document with the specified ID.
        /// </remarks>
        public void DeleteBusinessDocument(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/document/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Business Document
        /// </summary>
        /// <remarks>
        /// Deletes the business document with the specified ID.
        /// </remarks>
        public Task DeleteBusinessDocumentAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/document/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Business Document Content
        /// </summary>
        /// <remarks>
        /// Gets the file content for the business document with the specified ID.
        /// </remarks>
        public DocumentFile GetBusinessDocumentContent(int businessId, int id)
        {
            return ApiRequest<DocumentFile>($"/business/{businessId}/document/{id}/content", Method.Get);
        }

        /// <summary>
        /// Get Business Document Content
        /// </summary>
        /// <remarks>
        /// Gets the file content for the business document with the specified ID.
        /// </remarks>
        public Task<DocumentFile> GetBusinessDocumentContentAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DocumentFile>($"/business/{businessId}/document/{id}/content", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Employee Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for an employee.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<UkLocationModel> ListEmployeeLocations(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkLocationModel>>($"/business/{businessId}/employee/{employeeId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employee Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for an employee.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<UkLocationModel>> ListEmployeeLocationsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkLocationModel>>($"/business/{businessId}/employee/{employeeId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public EmployeePortalSettingsModel GetEmployeePortalSettings(int businessId)
        {
            return ApiRequest<EmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", Method.Get);
        }

        /// <summary>
        /// Get Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public Task<EmployeePortalSettingsModel> GetEmployeePortalSettingsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public EmployeePortalSettingsModel UpdateEmployeePortalSettings(int businessId, EmployeePortalSettingsModel model)
        {
            return ApiRequest<EmployeePortalSettingsModel,EmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", model, Method.Post);
        }

        /// <summary>
        /// Update Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public Task<EmployeePortalSettingsModel> UpdateEmployeePortalSettingsAsync(int businessId, EmployeePortalSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeePortalSettingsModel,EmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Entitlements
        /// </summary>
        /// <remarks>
        /// Lists all of the entitlements for the business.
        /// </remarks>
        public EntitlementsModel ListEntitlements(int businessId)
        {
            return ApiRequest<EntitlementsModel>($"/business/{businessId}/entitlements", Method.Get);
        }

        /// <summary>
        /// List Entitlements
        /// </summary>
        /// <remarks>
        /// Lists all of the entitlements for the business.
        /// </remarks>
        public Task<EntitlementsModel> ListEntitlementsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EntitlementsModel>($"/business/{businessId}/entitlements", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get HMRC Settings
        /// </summary>
        /// <remarks>
        /// Gets the HMRC Settings for the business.
        /// </remarks>
        public HmrcSettingsResponseModel GetHmrcSettings(int businessId)
        {
            return ApiRequest<HmrcSettingsResponseModel>($"/business/{businessId}/hmrcsettings", Method.Get);
        }

        /// <summary>
        /// Get HMRC Settings
        /// </summary>
        /// <remarks>
        /// Gets the HMRC Settings for the business.
        /// </remarks>
        public Task<HmrcSettingsResponseModel> GetHmrcSettingsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<HmrcSettingsResponseModel>($"/business/{businessId}/hmrcsettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update HMRC Settings
        /// </summary>
        /// <remarks>
        /// Updates the HMRC Settings for the business.
        /// </remarks>
        public HmrcSettingsResponseModel UpdateHmrcSettings(int businessId, HmrcSettingsRequestModel model)
        {
            return ApiRequest<HmrcSettingsResponseModel,HmrcSettingsRequestModel>($"/business/{businessId}/hmrcsettings", model, Method.Put);
        }

        /// <summary>
        /// Update HMRC Settings
        /// </summary>
        /// <remarks>
        /// Updates the HMRC Settings for the business.
        /// </remarks>
        public Task<HmrcSettingsResponseModel> UpdateHmrcSettingsAsync(int businessId, HmrcSettingsRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<HmrcSettingsResponseModel,HmrcSettingsRequestModel>($"/business/{businessId}/hmrcsettings", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Employment Allowance Settings
        /// </summary>
        /// <remarks>
        /// Get employment allowance settings for the business.
        /// </remarks>
        public UkEmploymentAllowanceModel GetEmploymentAllowanceSettings(int businessId, GetEmploymentAllowanceSettingsQueryModel request)
        {
            return ApiRequest<UkEmploymentAllowanceModel>($"/business/{businessId}/hmrcsettings/employmentallowance?financialYearEnding={request.FinancialYearEnding}", Method.Get);
        }

        /// <summary>
        /// Get Employment Allowance Settings
        /// </summary>
        /// <remarks>
        /// Get employment allowance settings for the business.
        /// </remarks>
        public Task<UkEmploymentAllowanceModel> GetEmploymentAllowanceSettingsAsync(int businessId, GetEmploymentAllowanceSettingsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEmploymentAllowanceModel>($"/business/{businessId}/hmrcsettings/employmentallowance?financialYearEnding={request.FinancialYearEnding}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employment Allowance Settings
        /// </summary>
        /// <remarks>
        /// Update employment allowance settings for the business.
        /// A new effective date can be set each tax year, otherwise the effective date reverts to the start of the tax year.
        /// State aid sectors:
        /// - Agriculture
        /// - FisheriesAndAquaculture
        /// - RoadTransport
        /// - Industrial
        /// </remarks>
        public UkEmploymentAllowanceModel UpdateEmploymentAllowanceSettings(int businessId, UkEmploymentAllowanceModel model)
        {
            return ApiRequest<UkEmploymentAllowanceModel,UkEmploymentAllowanceModel>($"/business/{businessId}/hmrcsettings/employmentallowance", model, Method.Put);
        }

        /// <summary>
        /// Update Employment Allowance Settings
        /// </summary>
        /// <remarks>
        /// Update employment allowance settings for the business.
        /// A new effective date can be set each tax year, otherwise the effective date reverts to the start of the tax year.
        /// State aid sectors:
        /// - Agriculture
        /// - FisheriesAndAquaculture
        /// - RoadTransport
        /// - Industrial
        /// </remarks>
        public Task<UkEmploymentAllowanceModel> UpdateEmploymentAllowanceSettingsAsync(int businessId, UkEmploymentAllowanceModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEmploymentAllowanceModel,UkEmploymentAllowanceModel>($"/business/{businessId}/hmrcsettings/employmentallowance", model, Method.Put, cancellationToken);
        }

        public HmrcSettingsRequestModel HmrcSettings_DeleteHmrcPaymentReminder(int businessId)
        {
            return ApiRequest<HmrcSettingsRequestModel>($"/business/{businessId}/hmrcsettings/hmrcpaymentreminder", Method.Delete);
        }

        public Task<HmrcSettingsRequestModel> HmrcSettings_DeleteHmrcPaymentReminderAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<HmrcSettingsRequestModel>($"/business/{businessId}/hmrcsettings/hmrcpaymentreminder", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Simple Update Employer HMRC Settings
        /// </summary>
        /// <remarks>
        /// Updates a subset of the HMRC Settings for the business.
        /// </remarks>
        public HmrcSettingsResponseModel SimpleUpdateEmployerHmrcSettings(int businessId, SimpleHmrcSettingsRequestModel model)
        {
            return ApiRequest<HmrcSettingsResponseModel,SimpleHmrcSettingsRequestModel>($"/business/{businessId}/hmrcsettings/simple-update", model, Method.Put);
        }

        /// <summary>
        /// Simple Update Employer HMRC Settings
        /// </summary>
        /// <remarks>
        /// Updates a subset of the HMRC Settings for the business.
        /// </remarks>
        public Task<HmrcSettingsResponseModel> SimpleUpdateEmployerHmrcSettingsAsync(int businessId, SimpleHmrcSettingsRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<HmrcSettingsResponseModel,SimpleHmrcSettingsRequestModel>($"/business/{businessId}/hmrcsettings/simple-update", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Change the tax year
        /// </summary>
        /// <remarks>
        /// Changes the initial tax year for the current business. This is the tax year that
        /// </remarks>
        public void ChangeTheTaxYear(int businessId, ChangeTheTaxYearQueryModel request)
        {
            ApiRequest($"/business/{businessId}/initialfinancialyear?year={request.Year}", Method.Post);
        }

        /// <summary>
        /// Change the tax year
        /// </summary>
        /// <remarks>
        /// Changes the initial tax year for the current business. This is the tax year that
        /// </remarks>
        public Task ChangeTheTaxYearAsync(int businessId, ChangeTheTaxYearQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/initialfinancialyear?year={request.Year}", Method.Post, cancellationToken);
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
        public void UpdateTheLeaveSettingsForTheBusiness(int businessId, UkBusinessLeaveSettingsModel model)
        {
            ApiRequest($"/business/{businessId}/leavesettings", model, Method.Put);
        }

        /// <summary>
        /// Update the leave settings for the business
        /// </summary>
        public Task UpdateTheLeaveSettingsForTheBusinessAsync(int businessId, UkBusinessLeaveSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/leavesettings", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// List Business Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for a business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<UkLocationModel> ListBusinessLocations(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkLocationModel>>($"/business/{businessId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Business Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for a business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<UkLocationModel>> ListBusinessLocationsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkLocationModel>>($"/business/{businessId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Location
        /// </summary>
        /// <remarks>
        /// Creates a business location.
        /// </remarks>
        public UkLocationModel CreateLocation(int businessId, UkLocationModel location)
        {
            return ApiRequest<UkLocationModel,UkLocationModel>($"/business/{businessId}/location", location, Method.Post);
        }

        /// <summary>
        /// Create Location
        /// </summary>
        /// <remarks>
        /// Creates a business location.
        /// </remarks>
        public Task<UkLocationModel> CreateLocationAsync(int businessId, UkLocationModel location, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkLocationModel,UkLocationModel>($"/business/{businessId}/location", location, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Location By Id
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the location with the specified ID.
        /// </remarks>
        public UkSingleLocationModel GetLocationById(int businessId, int id)
        {
            return ApiRequest<UkSingleLocationModel>($"/business/{businessId}/location/{id}", Method.Get);
        }

        /// <summary>
        /// Get Location By Id
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the location with the specified ID.
        /// </remarks>
        public Task<UkSingleLocationModel> GetLocationByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSingleLocationModel>($"/business/{businessId}/location/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Location
        /// </summary>
        /// <remarks>
        /// Updates the business location with the specified ID.
        /// </remarks>
        public void UpdateLocation(int businessId, int id, UkLocationModel location)
        {
            ApiRequest($"/business/{businessId}/location/{id}", location, Method.Put);
        }

        /// <summary>
        /// Update Location
        /// </summary>
        /// <remarks>
        /// Updates the business location with the specified ID.
        /// </remarks>
        public Task UpdateLocationAsync(int businessId, int id, UkLocationModel location, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/location/{id}", location, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Location
        /// </summary>
        /// <remarks>
        /// Deletes the location with the specified ID.
        /// </remarks>
        public void DeleteLocation(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/location/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Location
        /// </summary>
        /// <remarks>
        /// Deletes the location with the specified ID.
        /// </remarks>
        public Task DeleteLocationAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/location/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get payslip configuration
        /// </summary>
        /// <remarks>
        /// Gets the payslip configuration for the specified business ID.
        /// </remarks>
        public UkEditBusinessPaySlipApiModel GetPayslipConfiguration(int businessId)
        {
            return ApiRequest<UkEditBusinessPaySlipApiModel>($"/business/{businessId}/payslip", Method.Get);
        }

        /// <summary>
        /// Get payslip configuration
        /// </summary>
        /// <remarks>
        /// Gets the payslip configuration for the specified business ID.
        /// </remarks>
        public Task<UkEditBusinessPaySlipApiModel> GetPayslipConfigurationAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEditBusinessPaySlipApiModel>($"/business/{businessId}/payslip", Method.Get, cancellationToken);
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
        public void CreatePayslipConfiguration(int businessId, UkEditBusinessPaySlipApiModel model)
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
        public Task CreatePayslipConfigurationAsync(int businessId, UkEditBusinessPaySlipApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payslip", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Rounding Rules
        /// </summary>
        /// <remarks>
        /// Gets the rounding rules for the business.
        /// </remarks>
        public TimesheetRoundingRulesModel GetRoundingRules(int businessId)
        {
            return ApiRequest<TimesheetRoundingRulesModel>($"/business/{businessId}/roundingrules", Method.Get);
        }

        /// <summary>
        /// Get Rounding Rules
        /// </summary>
        /// <remarks>
        /// Gets the rounding rules for the business.
        /// </remarks>
        public Task<TimesheetRoundingRulesModel> GetRoundingRulesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TimesheetRoundingRulesModel>($"/business/{businessId}/roundingrules", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Rounding Rules
        /// </summary>
        /// <remarks>
        /// Sets the rounding rules for the business.
        /// </remarks>
        public void SetRoundingRules(int businessId, TimesheetRoundingRulesModel roundingRules)
        {
            ApiRequest($"/business/{businessId}/roundingrules", roundingRules, Method.Post);
        }

        /// <summary>
        /// Set Rounding Rules
        /// </summary>
        /// <remarks>
        /// Sets the rounding rules for the business.
        /// </remarks>
        public Task SetRoundingRulesAsync(int businessId, TimesheetRoundingRulesModel roundingRules, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/roundingrules", roundingRules, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get All Statutory Maternity Leave Data
        /// </summary>
        /// <remarks>
        /// Lists all of the SMP data for a business
        /// </remarks>
        public List<UkSmpApiRowModel> GetAllStatutoryMaternityLeaveData(int businessId)
        {
            return ApiRequest<List<UkSmpApiRowModel>>($"/business/{businessId}/statutorypay", Method.Get);
        }

        /// <summary>
        /// Get All Statutory Maternity Leave Data
        /// </summary>
        /// <remarks>
        /// Lists all of the SMP data for a business
        /// </remarks>
        public Task<List<UkSmpApiRowModel>> GetAllStatutoryMaternityLeaveDataAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkSmpApiRowModel>>($"/business/{businessId}/statutorypay", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Billing Plans
        /// </summary>
        /// <remarks>
        /// Lists all the billing plans for the business.
        /// </remarks>
        public List<UkBillingPlanResponseModel> ListBillingPlans(int businessId)
        {
            return ApiRequest<List<UkBillingPlanResponseModel>>($"/business/{businessId}/subscription/billingplans", Method.Get);
        }

        /// <summary>
        /// List Billing Plans
        /// </summary>
        /// <remarks>
        /// Lists all the billing plans for the business.
        /// </remarks>
        public Task<List<UkBillingPlanResponseModel>> ListBillingPlansAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkBillingPlanResponseModel>>($"/business/{businessId}/subscription/billingplans", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Billing Plans
        /// </summary>
        /// <remarks>
        /// Get the current billing plan for the business.
        /// </remarks>
        public UkBillingPlanResponseModel GetBusinessBillingPlans(int businessId)
        {
            return ApiRequest<UkBillingPlanResponseModel>($"/business/{businessId}/subscription/currentbillingplan", Method.Get);
        }

        /// <summary>
        /// Get Business Billing Plans
        /// </summary>
        /// <remarks>
        /// Get the current billing plan for the business.
        /// </remarks>
        public Task<UkBillingPlanResponseModel> GetBusinessBillingPlansAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBillingPlanResponseModel>($"/business/{businessId}/subscription/currentbillingplan", Method.Get, cancellationToken);
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
        /// Get the timesheet settings for the business
        /// </summary>
        public void GetTheTimesheetSettingsForTheBusiness(int businessId)
        {
            ApiRequest($"/business/{businessId}/timesheetsettings", Method.Get);
        }

        /// <summary>
        /// Get the timesheet settings for the business
        /// </summary>
        public Task GetTheTimesheetSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/timesheetsettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update the timesheet settings for the business
        /// </summary>
        public void UpdateTheTimesheetSettingsForTheBusiness(int businessId, UkBusinessTimesheetSettingsModel model)
        {
            ApiRequest($"/business/{businessId}/timesheetsettings", model, Method.Put);
        }

        /// <summary>
        /// Update the timesheet settings for the business
        /// </summary>
        public Task UpdateTheTimesheetSettingsForTheBusinessAsync(int businessId, UkBusinessTimesheetSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/timesheetsettings", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public UkBusinessExportModel GetBusinessDetailsByExternalId(GetBusinessDetailsByExternalIdQueryModel request)
        {
            return ApiRequest<UkBusinessExportModel>($"/business/externalid?externalId={request.ExternalId}", Method.Get);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public Task<UkBusinessExportModel> GetBusinessDetailsByExternalIdAsync(GetBusinessDetailsByExternalIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBusinessExportModel>($"/business/externalid?externalId={request.ExternalId}", Method.Get, cancellationToken);
        }
    }
}
