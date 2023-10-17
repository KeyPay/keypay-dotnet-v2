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
        List<AuBusinessExportModel> ListBusinesses(ODataQuery oDataQuery = null);
        Task<List<AuBusinessExportModel>> ListBusinessesAsync(ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        AuBusinessExportModel CreateNewBusiness(AuBusinessExportModel model);
        Task<AuBusinessExportModel> CreateNewBusinessAsync(AuBusinessExportModel model, CancellationToken cancellationToken = default);
        AuBusinessExportModel CreateNewBusiness(AuBusinessExportModel model, CreateNewBusinessQueryModel request);
        Task<AuBusinessExportModel> CreateNewBusinessAsync(AuBusinessExportModel model, CreateNewBusinessQueryModel request, CancellationToken cancellationToken = default);
        AuBusinessExportModel GetBusinessDetails(int businessId);
        Task<AuBusinessExportModel> GetBusinessDetailsAsync(int businessId, CancellationToken cancellationToken = default);
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
        BusinessAtoSupplierModel GetAtoDetails(int businessId);
        Task<BusinessAtoSupplierModel> GetAtoDetailsAsync(int businessId, CancellationToken cancellationToken = default);
        BusinessAtoSupplierModel SetAtoDetails(int businessId, BusinessAtoSupplierModel model);
        Task<BusinessAtoSupplierModel> SetAtoDetailsAsync(int businessId, BusinessAtoSupplierModel model, CancellationToken cancellationToken = default);
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
        AuEmployeePortalSettingsModel GetEmployeePortalSettings(int businessId);
        Task<AuEmployeePortalSettingsModel> GetEmployeePortalSettingsAsync(int businessId, CancellationToken cancellationToken = default);
        AuEmployeePortalSettingsModel UpdateEmployeePortalSettings(int businessId, AuEmployeePortalSettingsModel model);
        Task<AuEmployeePortalSettingsModel> UpdateEmployeePortalSettingsAsync(int businessId, AuEmployeePortalSettingsModel model, CancellationToken cancellationToken = default);
        EntitlementsModel ListEntitlements(int businessId);
        Task<EntitlementsModel> ListEntitlementsAsync(int businessId, CancellationToken cancellationToken = default);
        void ChangeTheTaxYear(int businessId, ChangeTheTaxYearQueryModel request);
        Task ChangeTheTaxYearAsync(int businessId, ChangeTheTaxYearQueryModel request, CancellationToken cancellationToken = default);
        void GetTheLeaveSettingsForTheBusiness(int businessId);
        Task GetTheLeaveSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default);
        void UpdateTheLeaveSettingsForTheBusiness(int businessId, AuBusinessLeaveSettingsModel model);
        Task UpdateTheLeaveSettingsForTheBusinessAsync(int businessId, AuBusinessLeaveSettingsModel model, CancellationToken cancellationToken = default);
        AuEditBusinessPaySlipApiModel GetPayslipConfiguration(int businessId);
        Task<AuEditBusinessPaySlipApiModel> GetPayslipConfigurationAsync(int businessId, CancellationToken cancellationToken = default);
        void CreatePayslipConfiguration(int businessId, AuEditBusinessPaySlipApiModel model);
        Task CreatePayslipConfigurationAsync(int businessId, AuEditBusinessPaySlipApiModel model, CancellationToken cancellationToken = default);
        TimesheetRoundingRulesModel GetRoundingRules(int businessId);
        Task<TimesheetRoundingRulesModel> GetRoundingRulesAsync(int businessId, CancellationToken cancellationToken = default);
        void SetRoundingRules(int businessId, TimesheetRoundingRulesModel roundingRules);
        Task SetRoundingRulesAsync(int businessId, TimesheetRoundingRulesModel roundingRules, CancellationToken cancellationToken = default);
        AuStpRegistrationModel GetStpRegistrationDetails(int businessId);
        Task<AuStpRegistrationModel> GetStpRegistrationDetailsAsync(int businessId, CancellationToken cancellationToken = default);
        AuStpRegistrationModel ApplyStpRegistrationDetails(int businessId, AuStpRegistrationModel stpRegistrationModel);
        Task<AuStpRegistrationModel> ApplyStpRegistrationDetailsAsync(int businessId, AuStpRegistrationModel stpRegistrationModel, CancellationToken cancellationToken = default);
        List<AuBillingPlanResponseModel> ListBillingPlans(int businessId);
        Task<List<AuBillingPlanResponseModel>> ListBillingPlansAsync(int businessId, CancellationToken cancellationToken = default);
        AuBillingPlanResponseModel GetBusinessBillingPlan(int businessId);
        Task<AuBillingPlanResponseModel> GetBusinessBillingPlanAsync(int businessId, CancellationToken cancellationToken = default);
        void SetBusinessBillingPlan(int businessId, SetBillingPlanRequestModel model);
        Task SetBusinessBillingPlanAsync(int businessId, SetBillingPlanRequestModel model, CancellationToken cancellationToken = default);
        List<TagViewModel> ListTheBusinessTags(int businessId);
        Task<List<TagViewModel>> ListTheBusinessTagsAsync(int businessId, CancellationToken cancellationToken = default);
        void GetTheTimesheetSettingsForTheBusiness(int businessId);
        Task GetTheTimesheetSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default);
        void UpdateTheTimesheetSettingsForTheBusiness(int businessId, AuBusinessTimesheetSettingsModel model);
        Task UpdateTheTimesheetSettingsForTheBusinessAsync(int businessId, AuBusinessTimesheetSettingsModel model, CancellationToken cancellationToken = default);
        AuBusinessExportModel GetBusinessDetailsByExternalId(GetBusinessDetailsByExternalIdQueryModel request);
        Task<AuBusinessExportModel> GetBusinessDetailsByExternalIdAsync(GetBusinessDetailsByExternalIdQueryModel request, CancellationToken cancellationToken = default);
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
        public void UpdateTheTimesheetSettingsForTheBusiness(int businessId, AuBusinessTimesheetSettingsModel model)
        {
            ApiRequest($"/business/{businessId}/timesheetsettings", model, Method.Put);
        }

        /// <summary>
        /// Update the timesheet settings for the business
        /// </summary>
        public Task UpdateTheTimesheetSettingsForTheBusinessAsync(int businessId, AuBusinessTimesheetSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/timesheetsettings", model, Method.Put, cancellationToken);
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
    }
}
