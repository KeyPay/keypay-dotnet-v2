using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.Business;

namespace KeyPayV2.Uk.Functions
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
        public List<UkBusinessExportModel> ListBusinesses(ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkBusinessExportModel>>($"/business{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Update Business Details
        /// </summary>
        /// <remarks>
        /// Update some standard business details
        /// </remarks>
        public UkBusinessExportModel UpdateBusinessDetails(EditBusinessDetailsApiModel model)
        {
            return ApiRequest<UkBusinessExportModel,EditBusinessDetailsApiModel>($"/business", model, Method.PUT);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public UkBusinessExportModel CreateNewBusiness(UkBusinessExportModel model, CreateNewBusinessQueryModel request)
        {
            return ApiRequest<UkBusinessExportModel,UkBusinessExportModel>($"/business?setupDefaultData={request.SetupDefaultData}", model, Method.POST);
        }

        /// <summary>
        /// Get Business Details
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified ID.
        /// </remarks>
        public UkBusinessExportModel GetBusinessDetails(int businessId)
        {
            return ApiRequest<UkBusinessExportModel>($"/business/{businessId}");
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
        /// List BACS Settings
        /// </summary>
        /// <remarks>
        /// Retrieves all the BACS settings associated with the business.
        /// </remarks>
        public List<UkBacsApiModel> ListBacsSettings(int businessId)
        {
            return ApiRequest<List<UkBacsApiModel>>($"/business/{businessId}/bacs");
        }

        /// <summary>
        /// Create BACS Settings Record
        /// </summary>
        /// <remarks>
        /// Creates a new BACS settings record for the business.
        /// </remarks>
        public UkBacsApiModel CreateBacsSettingsRecord(int businessId, UkBacsApiModel model)
        {
            return ApiRequest<UkBacsApiModel,UkBacsApiModel>($"/business/{businessId}/bacs", model, Method.POST);
        }

        /// <summary>
        /// Get BACS Settings Record by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the BACS settings record with the specified ID.
        /// </remarks>
        public UkBacsApiModel GetBacsSettingsRecordById(int businessId, int id)
        {
            return ApiRequest<UkBacsApiModel>($"/business/{businessId}/bacs/{id}");
        }

        /// <summary>
        /// Update BACS Settings Record
        /// </summary>
        /// <remarks>
        /// Updates the BACS settings record with the specified ID of the Bacs record.
        /// </remarks>
        public UkBacsApiModel UpdateBacsSettingsRecord(int businessId, int id, UkBacsApiModel model)
        {
            return ApiRequest<UkBacsApiModel,UkBacsApiModel>($"/business/{businessId}/bacs/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Delete BACS Settings Record
        /// </summary>
        /// <remarks>
        /// Deletes the BACS settings record with the specified ID.
        /// </remarks>
        public void DeleteBacsSettingsRecord(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/bacs/{id}", Method.DELETE);
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
        /// List Employee Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for an employee.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<UkLocationModel> ListEmployeeLocations(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkLocationModel>>($"/business/{businessId}/employee/{employeeId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Get Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public EmployeePortalSettingsModel GetEmployeePortalSettings(int businessId)
        {
            return ApiRequest<EmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings");
        }

        /// <summary>
        /// Update Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public EmployeePortalSettingsModel UpdateEmployeePortalSettings(int businessId, EmployeePortalSettingsModel model)
        {
            return ApiRequest<EmployeePortalSettingsModel,EmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", model, Method.POST);
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
        /// Get HMRC Settings
        /// </summary>
        /// <remarks>
        /// Gets the HMRC Settings for the business.
        /// </remarks>
        public HmrcSettingsResponseModel GetHmrcSettings(int businessId)
        {
            return ApiRequest<HmrcSettingsResponseModel>($"/business/{businessId}/hmrcsettings");
        }

        /// <summary>
        /// Update HMRC Settings
        /// </summary>
        /// <remarks>
        /// Updates the HMRC Settings for the business.
        /// </remarks>
        public HmrcSettingsResponseModel UpdateHmrcSettings(int businessId, HmrcSettingsRequestModel model)
        {
            return ApiRequest<HmrcSettingsResponseModel,HmrcSettingsRequestModel>($"/business/{businessId}/hmrcsettings", model, Method.PUT);
        }

        /// <summary>
        /// Get Employment Allowance Settings
        /// </summary>
        /// <remarks>
        /// Get employment allowance settings for the business.
        /// </remarks>
        public UkEmploymentAllowanceModel GetEmploymentAllowanceSettings(int businessId, GetEmploymentAllowanceSettingsQueryModel request)
        {
            return ApiRequest<UkEmploymentAllowanceModel>($"/business/{businessId}/hmrcsettings/employmentallowance?financialYearEnding={request.FinancialYearEnding}");
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
            return ApiRequest<UkEmploymentAllowanceModel,UkEmploymentAllowanceModel>($"/business/{businessId}/hmrcsettings/employmentallowance", model, Method.PUT);
        }

        public HmrcSettingsRequestModel HmrcSettings_DeleteHmrcPaymentReminder(int businessId)
        {
            return ApiRequest<HmrcSettingsRequestModel>($"/business/{businessId}/hmrcsettings/hmrcpaymentreminder", Method.DELETE);
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
        /// List Business Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for a business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<UkLocationModel> ListBusinessLocations(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkLocationModel>>($"/business/{businessId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Location
        /// </summary>
        /// <remarks>
        /// Creates a business location.
        /// </remarks>
        public UkLocationModel CreateLocation(int businessId, UkLocationModel location)
        {
            return ApiRequest<UkLocationModel,UkLocationModel>($"/business/{businessId}/location", location, Method.POST);
        }

        /// <summary>
        /// Get Location By Id
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the location with the specified ID.
        /// </remarks>
        public UkSingleLocationModel GetLocationById(int businessId, int id)
        {
            return ApiRequest<UkSingleLocationModel>($"/business/{businessId}/location/{id}");
        }

        /// <summary>
        /// Update Location
        /// </summary>
        /// <remarks>
        /// Updates the business location with the specified ID.
        /// </remarks>
        public void UpdateLocation(int businessId, int id, UkLocationModel location)
        {
            ApiRequest($"/business/{businessId}/location/{id}", location, Method.PUT);
        }

        /// <summary>
        /// Delete Location
        /// </summary>
        /// <remarks>
        /// Deletes the location with the specified ID.
        /// </remarks>
        public void DeleteLocation(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/location/{id}", Method.DELETE);
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
        /// Get All Statutory Maternity Leave Data
        /// </summary>
        /// <remarks>
        /// Lists all of the SMP data for a business
        /// </remarks>
        public List<UkSmpApiRowModel> GetAllStatutoryMaternityLeaveData(int businessId)
        {
            return ApiRequest<List<UkSmpApiRowModel>>($"/business/{businessId}/statutorypay");
        }

        /// <summary>
        /// List billing plans
        /// </summary>
        /// <remarks>
        /// Lists all the billing plans for the business.
        /// </remarks>
        public List<UkBillingPlanResponseModel> ListBillingPlans(int businessId)
        {
            return ApiRequest<List<UkBillingPlanResponseModel>>($"/business/{businessId}/subscription/billingplans");
        }

        /// <summary>
        /// Get the current billing plan for a business
        /// </summary>
        /// <remarks>
        /// Get the current billing plan for the business.
        /// </remarks>
        public UkBillingPlanResponseModel GetTheCurrentBillingPlanForABusiness(int businessId)
        {
            return ApiRequest<UkBillingPlanResponseModel>($"/business/{businessId}/subscription/currentbillingplan");
        }

        /// <summary>
        /// Set billing plan
        /// </summary>
        /// <remarks>
        /// Sets the current billing plan for a business
        /// </remarks>
        public void SetBillingPlan(int businessId, SetBillingPlanRequestModel model)
        {
            ApiRequest($"/business/{businessId}/subscription/setbillingplan", model, Method.POST);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public UkBusinessExportModel GetBusinessDetailsByExternalId(GetBusinessDetailsByExternalIdQueryModel request)
        {
            return ApiRequest<UkBusinessExportModel>($"/business/externalid?externalId={request.ExternalId}");
        }
    }
}
