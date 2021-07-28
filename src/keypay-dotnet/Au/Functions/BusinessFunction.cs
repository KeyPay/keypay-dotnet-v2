using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.Business;

namespace KeyPayV2.Au.Functions
{
    public class BusinessFunction : BaseFunction
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
            return ApiRequest<List<AuBusinessExportModel>>($"/business{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public AuBusinessExportModel CreateNewBusiness(AuBusinessExportModel model)
        {
            return ApiRequest<AuBusinessExportModel,AuBusinessExportModel>($"/business", model, Method.POST);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public AuBusinessExportModel CreateNewBusiness(AuBusinessExportModel model, CreateNewBusinessQueryModel request)
        {
            return ApiRequest<AuBusinessExportModel,AuBusinessExportModel>($"/business?setupDefaultData={request.SetupDefaultData}", model, Method.POST);
        }

        /// <summary>
        /// Get Business Details
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified ID.
        /// </remarks>
        public AuBusinessExportModel GetBusinessDetails(int businessId)
        {
            return ApiRequest<AuBusinessExportModel>($"/business/{businessId}");
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
            return ApiRequest<List<BusinessAccessModel>>($"/business/{businessId}/access{ODataQuery.ToQueryString(oDataQuery, "?")}");
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
            ApiRequest($"/business/{businessId}/access?email={request.Email}", viewModel, Method.PUT);
        }

        /// <summary>
        /// Assign Business Access
        /// </summary>
        /// <remarks>
        /// Assigns business access to a name/email.
        /// </remarks>
        public void AssignBusinessAccess(int businessId, CreateBusinessAccessModel viewModel)
        {
            ApiRequest($"/business/{businessId}/access", viewModel, Method.POST);
        }

        /// <summary>
        /// Revoke Business Access
        /// </summary>
        /// <remarks>
        /// Revokes a user's access to the business.
        /// </remarks>
        public void RevokeBusinessAccess(int businessId, RevokeBusinessAccessQueryModel request)
        {
            ApiRequest($"/business/{businessId}/access?email={request.Email}", Method.DELETE);
        }

        /// <summary>
        /// Get User Business Access
        /// </summary>
        /// <remarks>
        /// Returns the business access assigned to the user with the specified email address.
        /// </remarks>
        public BusinessAccessModel GetUserBusinessAccess(int businessId, GetUserBusinessAccessQueryModel request)
        {
            return ApiRequest<BusinessAccessModel>($"/business/{businessId}/access/user?email={request.Email}");
        }

        /// <summary>
        /// List Business Notifications
        /// </summary>
        /// <remarks>
        /// Lists the notifications, that appear on the Dashboard in the application, for the business.
        /// </remarks>
        public List<BusinessAction> ListBusinessNotifications(int businessId)
        {
            return ApiRequest<List<BusinessAction>>($"/business/{businessId}/actionitems/businessnotifications");
        }

        /// <summary>
        /// Dismiss Business Notifications
        /// </summary>
        /// <remarks>
        /// Dismisses a business notification, so that it won't be shown again.
        /// </remarks>
        public void DismissBusinessNotifications(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/actionitems/businessnotifications/{id}/dismiss", Method.DELETE);
        }

        /// <summary>
        /// Get ATO Details
        /// </summary>
        /// <remarks>
        /// Gets the ATO details for the business.
        /// </remarks>
        public BusinessAtoSupplierModel GetAtoDetails(int businessId)
        {
            return ApiRequest<BusinessAtoSupplierModel>($"/business/{businessId}/ato");
        }

        /// <summary>
        /// Set ATO Details
        /// </summary>
        /// <remarks>
        /// Sets the ATO details for the business.
        /// </remarks>
        public BusinessAtoSupplierModel SetAtoDetails(int businessId, BusinessAtoSupplierModel model)
        {
            return ApiRequest<BusinessAtoSupplierModel,BusinessAtoSupplierModel>($"/business/{businessId}/ato", model, Method.POST);
        }

        /// <summary>
        /// List Business Document Details
        /// </summary>
        /// <remarks>
        /// Lists the details for all of the documents in the business.
        /// </remarks>
        public List<DocumentModel> ListBusinessDocumentDetails(int businessId)
        {
            return ApiRequest<List<DocumentModel>>($"/business/{businessId}/document");
        }

        /// <summary>
        /// Create Business Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for business. The request should be a MIME multipart file upload request.
        /// </remarks>
        public List<DocumentModel> CreateBusinessDocument(int businessId, FileUploadModel file)
        {
            return ApiRequest<List<DocumentModel>,FileUploadModel>($"/business/{businessId}/document", file, Method.POST);
        }

        /// <summary>
        /// Create Business Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for business. The request should be a MIME multipart file upload request.
        /// </remarks>
        public List<DocumentModel> CreateBusinessDocument(int businessId, FileUploadModel file, CreateBusinessDocumentQueryModel request)
        {
            return ApiFileRequest<List<DocumentModel>>($"/business/{businessId}/document?visibleToAll={request.VisibleToAll}", file);
        }

        /// <summary>
        /// Get Business Document Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the specified business document.
        /// </remarks>
        public DocumentModel GetBusinessDocumentDetails(int businessId, int id)
        {
            return ApiRequest<DocumentModel>($"/business/{businessId}/document/{id}");
        }

        /// <summary>
        /// Update Business Document Permissions
        /// </summary>
        /// <remarks>
        /// Updates permissions for the business document with the specified ID.
        /// </remarks>
        public DocumentModel UpdateBusinessDocumentPermissions(int businessId, int id, UpdateDocumentPermissionsModel model)
        {
            return ApiRequest<DocumentModel,UpdateDocumentPermissionsModel>($"/business/{businessId}/document/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Delete Business Document
        /// </summary>
        /// <remarks>
        /// Deletes the business document with the specified ID.
        /// </remarks>
        public void DeleteBusinessDocument(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/document/{id}", Method.DELETE);
        }

        /// <summary>
        /// Get Business Document Content
        /// </summary>
        /// <remarks>
        /// Gets the file content for the business document with the specified ID.
        /// </remarks>
        public DocumentFile GetBusinessDocumentContent(int businessId, int id)
        {
            return ApiRequest<DocumentFile>($"/business/{businessId}/document/{id}/content");
        }

        /// <summary>
        /// Get Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public AuEmployeePortalSettingsModel GetEmployeePortalSettings(int businessId)
        {
            return ApiRequest<AuEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings");
        }

        /// <summary>
        /// Update Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public AuEmployeePortalSettingsModel UpdateEmployeePortalSettings(int businessId, AuEmployeePortalSettingsModel model)
        {
            return ApiRequest<AuEmployeePortalSettingsModel,AuEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", model, Method.POST);
        }

        /// <summary>
        /// List Entitlements
        /// </summary>
        /// <remarks>
        /// Lists all of the entitlements for the business.
        /// </remarks>
        public EntitlementsModel ListEntitlements(int businessId)
        {
            return ApiRequest<EntitlementsModel>($"/business/{businessId}/entitlements");
        }

        /// <summary>
        /// Change the tax year
        /// </summary>
        /// <remarks>
        /// Changes the initial tax year for the current business. This is the tax year that
        /// </remarks>
        public void ChangeTheTaxYear(int businessId, ChangeTheTaxYearQueryModel request)
        {
            ApiRequest($"/business/{businessId}/initialfinancialyear?year={request.Year}", Method.POST);
        }

        /// <summary>
        /// Get Rounding Rules
        /// </summary>
        /// <remarks>
        /// Gets the rounding rules for the business.
        /// </remarks>
        public TimesheetRoundingRulesModel GetRoundingRules(int businessId)
        {
            return ApiRequest<TimesheetRoundingRulesModel>($"/business/{businessId}/roundingrules");
        }

        /// <summary>
        /// Set Rounding Rules
        /// </summary>
        /// <remarks>
        /// Sets the rounding rules for the business.
        /// </remarks>
        public void SetRoundingRules(int businessId, TimesheetRoundingRulesModel roundingRules)
        {
            ApiRequest($"/business/{businessId}/roundingrules", roundingRules, Method.POST);
        }

        /// <summary>
        /// Get STP Registration Details
        /// </summary>
        /// <remarks>
        /// Gets the ATO settings already applied for this business
        /// </remarks>
        public AuStpRegistrationModel GetStpRegistrationDetails(int businessId)
        {
            return ApiRequest<AuStpRegistrationModel>($"/business/{businessId}/stpregister");
        }

        /// <summary>
        /// Apply STP Registration Details
        /// </summary>
        /// <remarks>
        /// Registers the business for STP using the ATO settings supplied
        /// </remarks>
        public AuStpRegistrationModel ApplyStpRegistrationDetails(int businessId, AuStpRegistrationModel stpRegistrationModel)
        {
            return ApiRequest<AuStpRegistrationModel,AuStpRegistrationModel>($"/business/{businessId}/stpregister", stpRegistrationModel, Method.POST);
        }

        /// <summary>
        /// List Billing Plans
        /// </summary>
        /// <remarks>
        /// Lists all the billing plans available for the current business.
        /// </remarks>
        public List<AuBillingPlanResponseModel> ListBillingPlans(int businessId)
        {
            return ApiRequest<List<AuBillingPlanResponseModel>>($"/business/{businessId}/subscription/billingplans");
        }

        /// <summary>
        /// Get Business Billing PLan
        /// </summary>
        /// <remarks>
        /// Get the current billing plan for the business.
        /// </remarks>
        public AuBillingPlanResponseModel GetBusinessBillingPlan(int businessId)
        {
            return ApiRequest<AuBillingPlanResponseModel>($"/business/{businessId}/subscription/currentbillingplan");
        }

        /// <summary>
        /// Set Business Billing Plan
        /// </summary>
        /// <remarks>
        /// Sets the current billing plan for a business
        /// </remarks>
        public void SetBusinessBillingPlan(int businessId, SetBillingPlanRequestModel model)
        {
            ApiRequest($"/business/{businessId}/subscription/setbillingplan", model, Method.POST);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public AuBusinessExportModel GetBusinessDetailsByExternalId(GetBusinessDetailsByExternalIdQueryModel request)
        {
            return ApiRequest<AuBusinessExportModel>($"/business/externalid?externalId={request.ExternalId}");
        }
    }
}
