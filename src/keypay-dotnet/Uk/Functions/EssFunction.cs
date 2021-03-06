using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.Ess;

namespace KeyPayV2.Uk.Functions
{
    public class EssFunction : BaseFunction
    {
        public EssFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Bank Accounts
        /// </summary>
        /// <remarks>
        /// Lists all of the bank accounts for this employee.
        /// </remarks>
        public List<UkEssBankAccountModel> ListBankAccounts(int employeeId)
        {
            return ApiRequest<List<UkEssBankAccountModel>>($"/ess/{employeeId}/bankaccounts");
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public UkEssSaveBankAccountResponseModel CreateBankAccount(int employeeId, UkEssBankAccountModel model)
        {
            return ApiRequest<UkEssSaveBankAccountResponseModel,UkEssBankAccountModel>($"/ess/{employeeId}/bankaccounts", model, Method.POST);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public UkEssBankAccountModel GetBankAccountById(int employeeId, int bankAccountId)
        {
            return ApiRequest<UkEssBankAccountModel>($"/ess/{employeeId}/bankaccounts/{bankAccountId}");
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public UkEssSaveBankAccountResponseModel DeleteBankAccount(int employeeId, int bankAccountId)
        {
            return ApiRequest<UkEssSaveBankAccountResponseModel>($"/ess/{employeeId}/bankaccounts/{bankAccountId}", Method.DELETE);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public UkEssSaveBankAccountResponseModel UpdateBankAccount(int employeeId, int id, UkEssBankAccountModel model)
        {
            return ApiRequest<UkEssSaveBankAccountResponseModel,UkEssBankAccountModel>($"/ess/{employeeId}/bankaccounts/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Get Dashboard
        /// </summary>
        /// <remarks>
        /// Gets a set of useful information that the employee may need for self service tasks.
        /// </remarks>
        public UkDashboardModel GetDashboard(int employeeId)
        {
            return ApiRequest<UkDashboardModel>($"/ess/{employeeId}/dashboard");
        }

        /// <summary>
        /// Get Details
        /// </summary>
        /// <remarks>
        /// Gets ESS details for the specified employee.
        /// </remarks>
        public EssEmployeeDetailsModel GetDetails(int employeeId)
        {
            return ApiRequest<EssEmployeeDetailsModel>($"/ess/{employeeId}/details");
        }

        /// <summary>
        /// Save Details
        /// </summary>
        /// <remarks>
        /// Saves any employee details that the employee is allowed to set.
        /// </remarks>
        public UkUnstructuredEmployeeModel SaveDetails(int employeeId, EmployeePartialEditModel model)
        {
            return ApiRequest<UkUnstructuredEmployeeModel,EmployeePartialEditModel>($"/ess/{employeeId}/details", model, Method.POST);
        }

        /// <summary>
        /// List all Documents
        /// </summary>
        /// <remarks>
        /// Lists all documents visible to this employee, including both business and employee documents.
        /// </remarks>
        public List<EssDocumentModel> ListAllDocuments(int employeeId)
        {
            return ApiRequest<List<EssDocumentModel>>($"/ess/{employeeId}/document");
        }

        /// <summary>
        /// Get Document Details by ID
        /// </summary>
        /// <remarks>
        /// Gets details for the specified document which is visible to the employee.
        /// </remarks>
        public EssDocumentModel GetDocumentDetailsById(int employeeId, string documentId)
        {
            return ApiRequest<EssDocumentModel>($"/ess/{employeeId}/document/{documentId}");
        }

        /// <summary>
        /// Acknowledge Document
        /// </summary>
        /// <remarks>
        /// Acknowledges the document with the specified ID as having been read by the employee.
        /// </remarks>
        public void AcknowledgeDocument(int employeeId, string documentId)
        {
            ApiRequest($"/ess/{employeeId}/document/acknowledge/{documentId}", Method.POST);
        }

        /// <summary>
        /// Download Document
        /// </summary>
        /// <remarks>
        /// Downloads the document with the specified ID so long as it is visible to the employee.
        /// </remarks>
        public byte[] DownloadDocument(int employeeId, string documentId)
        {
            return ApiByteArrayRequest($"/ess/{employeeId}/document/download/{documentId}");
        }

        /// <summary>
        /// Get Leaving employee form PDF
        /// </summary>
        /// <remarks>
        /// Gets the PDF for the leaving employee form
        /// </remarks>
        public byte[] GetLeavingEmployeeFormPdf(int employeeId)
        {
            return ApiByteArrayRequest($"/ess/{employeeId}/document/LeavingEmployeeForm");
        }

        /// <summary>
        /// Get P60 certificate PDF
        /// </summary>
        /// <remarks>
        /// Gets the PDF for the P60 certificate with the specified ID.
        /// </remarks>
        public byte[] GetP60CertificatePdf(int employeeId, int documentId)
        {
            return ApiByteArrayRequest($"/ess/{employeeId}/document/P60/{documentId}");
        }

        /// <summary>
        /// Get P60 certificates
        /// </summary>
        /// <remarks>
        /// List all the employee's P60 certificates.
        /// </remarks>
        public List<EssP60Model> GetP60Certificates(int employeeId)
        {
            return ApiRequest<List<EssP60Model>>($"/ess/{employeeId}/document/p60s");
        }

        /// <summary>
        /// List Pay Slips
        /// </summary>
        /// <remarks>
        /// Lists all pay slips for the employee.
        /// </remarks>
        public List<EssPayslipModel> ListPaySlips(int employeeId)
        {
            return ApiRequest<List<EssPayslipModel>>($"/ess/{employeeId}/document/payslip");
        }

        /// <summary>
        /// Get Pay Slip by Pay Run ID
        /// </summary>
        /// <remarks>
        /// Gets the pay slip for the pay run with the specified ID.
        /// </remarks>
        public byte[] GetPaySlipByPayRunId(int employeeId, int payrunId)
        {
            return ApiByteArrayRequest($"/ess/{employeeId}/document/payslip/{payrunId}");
        }

        /// <summary>
        /// Get Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Gets emergency contacts for the specified employee.
        /// </remarks>
        public EmployeeEmergencyContactsEditModel GetEmergencyContacts(int employeeId)
        {
            return ApiRequest<EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts");
        }

        /// <summary>
        /// Update Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Saves the employee's emergency contact details.
        /// </remarks>
        public EmployeeEmergencyContactsEditModel UpdateEmergencyContacts(int employeeId, EmployeeEmergencyContactsEditModel model)
        {
            return ApiRequest<EmployeeEmergencyContactsEditModel,EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", model, Method.PUT);
        }

        /// <summary>
        /// Save Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Saves the employee's emergency contact details.
        /// </remarks>
        public EmployeeEmergencyContactsEditModel SaveEmergencyContacts(int employeeId, EmployeeEmergencyContactsEditModel model)
        {
            return ApiRequest<EmployeeEmergencyContactsEditModel,EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", model, Method.POST);
        }

        /// <summary>
        /// Get Expense Requests
        /// </summary>
        /// <remarks>
        /// Gets a paged view of expense requests for this employee.
        /// </remarks>
        public List<EssExpenseRequestResponseModel> GetExpenseRequests(int employeeId, GetExpenseRequestsQueryModel request)
        {
            return ApiRequest<List<EssExpenseRequestResponseModel>>($"/ess/{employeeId}/expense?currentPage={request.CurrentPage}&pageSize={request.PageSize}");
        }

        /// <summary>
        /// Create Expense Request
        /// </summary>
        /// <remarks>
        /// Creates a new expense request for the employee.
        /// </remarks>
        public void CreateExpenseRequest(int employeeId, ExpenseRequestEditModel model)
        {
            ApiRequest($"/ess/{employeeId}/expense", model, Method.POST);
        }

        /// <summary>
        /// Get Expense Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the expense request with the specified ID.
        /// </remarks>
        public EssExpenseRequestResponseModel GetExpenseRequestById(int employeeId, int expenseRequestId)
        {
            return ApiRequest<EssExpenseRequestResponseModel>($"/ess/{employeeId}/expense/{expenseRequestId}");
        }

        /// <summary>
        /// Update Expense Request
        /// </summary>
        /// <remarks>
        /// Updates the expense request with the specified ID.
        /// </remarks>
        public void UpdateExpenseRequest(int employeeId, int expenseRequestId, ExpenseRequestEditModel model)
        {
            ApiRequest($"/ess/{employeeId}/expense/{expenseRequestId}", model, Method.PUT);
        }

        /// <summary>
        /// Delete Expense Request
        /// </summary>
        /// <remarks>
        /// Deletes the expense request with the specified ID.
        /// </remarks>
        public EssExpenseRequestResponseModel DeleteExpenseRequest(int employeeId, int expenseRequestId)
        {
            return ApiRequest<EssExpenseRequestResponseModel>($"/ess/{employeeId}/expense/{expenseRequestId}", Method.DELETE);
        }

        /// <summary>
        /// Upload Attachment to Expense Request
        /// </summary>
        /// <remarks>
        /// Uploads an attachment to the expense request with the specified ID.
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public void UploadAttachmentToExpenseRequest(int employeeId, int expenseRequestId, UploadAttachmentToExpenseRequestQueryModel request)
        {
            ApiRequest($"/ess/{employeeId}/expense/{expenseRequestId}/attachment?fileName={request.FileName}", Method.PUT);
        }

        /// <summary>
        /// Get Expense Categories
        /// </summary>
        /// <remarks>
        /// Gets all the expense categories for the employee.
        /// </remarks>
        public List<ExpenseCategoryResponseModel> GetExpenseCategories(int employeeId)
        {
            return ApiRequest<List<ExpenseCategoryResponseModel>>($"/ess/{employeeId}/expense/categories");
        }

        /// <summary>
        /// Get Expense Payment Summary
        /// </summary>
        /// <remarks>
        /// Gets a summary of the employee's expense payments.
        /// </remarks>
        public List<EmployeeExpensePaymentSummaryModel> GetExpensePaymentSummary(int employeeId)
        {
            return ApiRequest<List<EmployeeExpensePaymentSummaryModel>>($"/ess/{employeeId}/expense/summary");
        }

        /// <summary>
        /// Get Tax Codes
        /// </summary>
        /// <remarks>
        /// Gets all the tax codes for the employee.
        /// </remarks>
        public List<JournalServiceTaxCode> GetTaxCodes(int employeeId)
        {
            return ApiRequest<List<JournalServiceTaxCode>>($"/ess/{employeeId}/expense/taxcodes");
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all leave requests for this employee, with optional filters
        /// </remarks>
        public List<EssLeaveRequestModel> ListLeaveRequests(int employeeId, ListLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<EssLeaveRequestModel>>($"/ess/{employeeId}/leave?showOtherEmployees={request.ShowOtherEmployees}&approvedOnly={request.ApprovedOnly}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}");
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request for the employee.
        /// </remarks>
        public void CreateLeaveRequest(int employeeId, LeaveApplicationWithAttachmentModel leaveApplication)
        {
            ApiRequest($"/ess/{employeeId}/leave", leaveApplication, Method.POST);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public EssLeaveRequestModel GetLeaveRequestById(int employeeId, int leaveRequestId)
        {
            return ApiRequest<EssLeaveRequestModel>($"/ess/{employeeId}/leave/{leaveRequestId}");
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public void UpdateLeaveRequest(int employeeId, int leaveRequestId, LeaveApplicationWithAttachmentModel leaveApplication)
        {
            ApiRequest($"/ess/{employeeId}/leave/{leaveRequestId}", leaveApplication, Method.POST);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public void DeleteLeaveRequest(int employeeId, int leaveRequestId)
        {
            ApiRequest($"/ess/{employeeId}/leave/{leaveRequestId}", Method.DELETE);
        }

        /// <summary>
        /// Upload Attachment to Leave Request
        /// </summary>
        /// <remarks>
        /// Uploads a file as a new employee document, and attaches it to the leave request with the specified ID. 
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public void UploadAttachmentToLeaveRequest(int employeeId, int leaveRequestId)
        {
            ApiRequest($"/ess/{employeeId}/leave/{leaveRequestId}/attachment", Method.PUT);
        }

        /// <summary>
        /// Delete Attachment from Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the attachment on the leave request with the specified ID.
        /// </remarks>
        public void DeleteAttachmentFromLeaveRequest(int employeeId, int leaveRequestId)
        {
            ApiRequest($"/ess/{employeeId}/leave/{leaveRequestId}/attachment", Method.DELETE);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public List<LeaveBalanceModel> GetLeaveBalances(int employeeId, GetLeaveBalancesQueryModel request)
        {
            return ApiRequest<List<LeaveBalanceModel>>($"/ess/{employeeId}/leave/balances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}");
        }

        /// <summary>
        /// Estimate Leave Hours
        /// </summary>
        /// <remarks>
        /// Estimates the number of hours of leave required based on date and leave category.
        /// </remarks>
        public EssLeaveEstimate EstimateLeaveHours(int employeeId, EstimateLeaveHoursQueryModel request)
        {
            return ApiRequest<EssLeaveEstimate>($"/ess/{employeeId}/leave/estimate?leaveCategoryId={request.LeaveCategoryId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Get Leave Categories
        /// </summary>
        /// <remarks>
        /// Gets the available leave categories for the employee.
        /// </remarks>
        public List<EssLeaveCategoryModel> GetLeaveCategories(int employeeId)
        {
            return ApiRequest<List<EssLeaveCategoryModel>>($"/ess/{employeeId}/leave/leavecategories");
        }

        public void UkEssLookup_Addresses(int employeeId, int suburbId)
        {
            ApiRequest($"/ess/{employeeId}/lookup/addresses/{suburbId}");
        }

        /// <summary>
        /// Get Locations
        /// </summary>
        /// <remarks>
        /// Gets all the locations for the employee.
        /// </remarks>
        public List<LocationModel> GetLocations(int employeeId)
        {
            return ApiRequest<List<LocationModel>>($"/ess/{employeeId}/lookup/location");
        }

        /// <summary>
        /// Get Shift Conditions
        /// </summary>
        /// <remarks>
        /// Gets all the shift conditions for the employee.
        /// </remarks>
        public List<UkWorkTypeModel> GetShiftConditions(int employeeId)
        {
            return ApiRequest<List<UkWorkTypeModel>>($"/ess/{employeeId}/lookup/shiftcondition");
        }

        /// <summary>
        /// Get Suburb
        /// </summary>
        /// <remarks>
        /// Gets the suburb for the criteria passed in
        /// </remarks>
        public SuburbResult GetSuburb(int employeeId, GetSuburbQueryModel request)
        {
            return ApiRequest<SuburbResult>($"/ess/{employeeId}/lookup/suburb?suburb={request.Suburb}&state={request.State}&postCode={request.PostCode}&countryId={request.CountryId}");
        }

        /// <summary>
        /// Search Suburbs
        /// </summary>
        /// <remarks>
        /// Gets a list of suburbs that match the search term.
        /// </remarks>
        public PagedResultModel<SuburbModel> SearchSuburbs(int employeeId, SearchSuburbsQueryModel request)
        {
            return ApiRequest<PagedResultModel<SuburbModel>>($"/ess/{employeeId}/lookup/suburbs?term={request.Term}&pageNum={request.PageNum}&pageSize={request.PageSize}&countryId={request.CountryId}");
        }

        /// <summary>
        /// Get Titles
        /// </summary>
        /// <remarks>
        /// Gets list of valid personal titles
        /// </remarks>
        public List<TitleViewModel> GetTitles(int employeeId)
        {
            return ApiRequest<List<TitleViewModel>>($"/ess/{employeeId}/lookup/title");
        }

        /// <summary>
        /// Get Work Types
        /// </summary>
        /// <remarks>
        /// Gets all the work types for the employee.
        /// </remarks>
        public List<UkWorkTypeModel> GetWorkTypes(int employeeId)
        {
            return ApiRequest<List<UkWorkTypeModel>>($"/ess/{employeeId}/lookup/worktype");
        }

        /// <summary>
        /// Get Personal Details
        /// </summary>
        /// <remarks>
        /// Gets Personal details for the specified employee.
        /// </remarks>
        public UkEssEmployeeDetailsViewModel GetPersonalDetails(int employeeId)
        {
            return ApiRequest<UkEssEmployeeDetailsViewModel>($"/ess/{employeeId}/personaldetails");
        }

        /// <summary>
        /// Update Personal Details
        /// </summary>
        /// <remarks>
        /// Updates the personal details for the employee
        /// </remarks>
        public UkEssEmployeeDetailsViewModel UpdatePersonalDetails(int employeeId, UkEssEmployeeDetailsEditModel model)
        {
            return ApiRequest<UkEssEmployeeDetailsViewModel,UkEssEmployeeDetailsEditModel>($"/ess/{employeeId}/personaldetails", model, Method.PUT);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public void GetEmployeeProfileImage(int employeeId)
        {
            ApiRequest($"/ess/{employeeId}/profileimage");
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public ProfileImageMetadata SetEmployeeProfileImage(int employeeId)
        {
            return ApiRequest<ProfileImageMetadata>($"/ess/{employeeId}/profileimage", Method.POST);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public void DeleteEmployeeProfileImage(int employeeId)
        {
            ApiRequest($"/ess/{employeeId}/profileimage", Method.DELETE);
        }

        /// <summary>
        /// Get public holidays
        /// </summary>
        /// <remarks>
        /// Lists relevant public holiday for an employee
        /// </remarks>
        public List<PublicHolidayModel> GetPublicHolidays(int employeeId, GetPublicHolidaysQueryModel request)
        {
            return ApiRequest<List<PublicHolidayModel>>($"/ess/{employeeId}/publicHolidays?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Get Satisfaction Survey Results
        /// </summary>
        /// <remarks>
        /// Gets satisfaction survey results for the employee
        /// </remarks>
        public List<EssSatisfactionSurvey> GetSatisfactionSurveyResults(int employeeId, GetSatisfactionSurveyResultsQueryModel request)
        {
            return ApiRequest<List<EssSatisfactionSurvey>>($"/ess/{employeeId}/satisfaction?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}");
        }

        /// <summary>
        /// Submit Satisfaction Survey
        /// </summary>
        /// <remarks>
        /// Submit a satisfaction survey for this employee.
        /// </remarks>
        public EmployeeSatisfactionValue SubmitSatisfactionSurvey(int employeeId, EssSatisfactionSurvey survey)
        {
            return ApiRequest<EmployeeSatisfactionValue,EssSatisfactionSurvey>($"/ess/{employeeId}/satisfaction", survey, Method.POST);
        }

        /// <summary>
        /// Get Enabled Features
        /// </summary>
        /// <remarks>
        /// Gets details as to which ESS features are enabled for the business.
        /// </remarks>
        public UkFeaturesModel GetEnabledFeatures(int employeeId)
        {
            return ApiRequest<UkFeaturesModel>($"/ess/{employeeId}/security/features");
        }

        /// <summary>
        /// List Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets the employee's roster shifts within the date range.
        /// </remarks>
        public List<UkEssRosterShiftModel> ListRosterShifts(int employeeId, ListRosterShiftsQueryModel request)
        {
            return ApiRequest<List<UkEssRosterShiftModel>>($"/ess/{employeeId}/shift?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Get Roster Shift by ID
        /// </summary>
        /// <remarks>
        /// Gets the roster shift with the specified ID (as long as it is assigned to this employee).
        /// </remarks>
        public UkEssRosterShiftModel GetRosterShiftById(int employeeId, int shiftId)
        {
            return ApiRequest<UkEssRosterShiftModel>($"/ess/{employeeId}/shift/{shiftId}");
        }

        /// <summary>
        /// Accept Roster Shift
        /// </summary>
        /// <remarks>
        /// Accepts the roster shift with the specified ID.
        /// </remarks>
        public UkAcceptRosterShiftResponseModel AcceptRosterShift(int employeeId, int shiftId)
        {
            return ApiRequest<UkAcceptRosterShiftResponseModel>($"/ess/{employeeId}/shift/{shiftId}/accept", Method.POST);
        }

        /// <summary>
        /// Decline Roster Shift
        /// </summary>
        /// <remarks>
        /// Declines the roster shift with the specified ID.
        /// </remarks>
        public EssRosterShiftCountModel DeclineRosterShift(int employeeId, int shiftId, EssDeclineRosterShiftModel model)
        {
            return ApiRequest<EssRosterShiftCountModel,EssDeclineRosterShiftModel>($"/ess/{employeeId}/shift/{shiftId}/decline", model, Method.POST);
        }

        /// <summary>
        /// Accept Shift Swap
        /// </summary>
        /// <remarks>
        /// Accept a shift swap
        /// </remarks>
        public UkEssRosterShiftActionResponse AcceptShiftSwap(int employeeId, int shiftId)
        {
            return ApiRequest<UkEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/accept", Method.POST);
        }

        /// <summary>
        /// Cancel Shift Swap
        /// </summary>
        /// <remarks>
        /// Cancel a shift swap
        /// </remarks>
        public UkEssRosterShiftActionResponse CancelShiftSwap(int employeeId, int shiftId)
        {
            return ApiRequest<UkEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/cancel", Method.POST);
        }

        /// <summary>
        /// Employees Eligible For Shift Swap
        /// </summary>
        /// <remarks>
        /// List the employees that are eligible for a shift swap
        /// </remarks>
        public List<EssShiftSwapCandidate> EmployeesEligibleForShiftSwap(int employeeId, int shiftId)
        {
            return ApiRequest<List<EssShiftSwapCandidate>>($"/ess/{employeeId}/shift/{shiftId}/swap/candidates");
        }

        /// <summary>
        /// Decline Shift Swap
        /// </summary>
        /// <remarks>
        /// Decline a shift swap
        /// </remarks>
        public UkEssRosterShiftActionResponse DeclineShiftSwap(int employeeId, int shiftId)
        {
            return ApiRequest<UkEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/decline", Method.POST);
        }

        /// <summary>
        /// Bulk Accept Roster Shifts
        /// </summary>
        /// <remarks>
        /// Accepts a number of roster shifts by ID.
        /// </remarks>
        public UkAcceptRosterShiftsResponseModel BulkAcceptRosterShifts(int employeeId, EssBulkAcceptRosterShiftsModel model)
        {
            return ApiRequest<UkAcceptRosterShiftsResponseModel,EssBulkAcceptRosterShiftsModel>($"/ess/{employeeId}/shift/accept", model, Method.POST);
        }

        /// <summary>
        /// Bulk Decline Roster Shifts
        /// </summary>
        /// <remarks>
        /// Declines a number of roster shifts by ID.
        /// </remarks>
        public EssRosterShiftCountModel BulkDeclineRosterShifts(int employeeId, EssBulkDeclineRosterShiftsModel model)
        {
            return ApiRequest<EssRosterShiftCountModel,EssBulkDeclineRosterShiftsModel>($"/ess/{employeeId}/shift/decline", model, Method.POST);
        }

        /// <summary>
        /// Find Matching Clock Off Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock off at this time
        /// given ESS settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public UkRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int employeeId, FindMatchingClockOffRosterShiftQueryModel request)
        {
            return ApiRequest<UkRosterShiftMatchingResultModel>($"/ess/{employeeId}/shift/matchingclockoff?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Find Matching Clock On Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock on at this time
        /// given ESS settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public UkRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int employeeId, FindMatchingClockOnRosterShiftQueryModel request)
        {
            return ApiRequest<UkRosterShiftMatchingResultModel>($"/ess/{employeeId}/shift/matchingclockon?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public List<UkEssRosterShiftModel> FindNearbyRosterShifts(int employeeId, FindNearbyRosterShiftsQueryModel request)
        {
            return ApiRequest<List<UkEssRosterShiftModel>>($"/ess/{employeeId}/shift/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Bulk Accept Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Accepts a number of roster shift swaps by shift ID.
        /// </remarks>
        public UkEssBulkRosterShiftActionResponse BulkAcceptRosterShiftSwaps(int employeeId, EssBulkRosterShiftSwapModel model)
        {
            return ApiRequest<UkEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/accept", model, Method.POST);
        }

        /// <summary>
        /// Bulk Cancel Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Cancels a number of roster shift swaps by shift ID.
        /// </remarks>
        public UkEssBulkRosterShiftActionResponse BulkCancelRosterShiftSwaps(int employeeId, EssBulkRosterShiftSwapModel model)
        {
            return ApiRequest<UkEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/cancel", model, Method.POST);
        }

        /// <summary>
        /// Bulk Decline Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Declines a number of roster shift swaps by shift ID.
        /// </remarks>
        public UkEssBulkRosterShiftActionResponse BulkDeclineRosterShiftSwaps(int employeeId, EssBulkRosterShiftSwapModel model)
        {
            return ApiRequest<UkEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/decline", model, Method.POST);
        }

        /// <summary>
        /// Propose Shift Swap
        /// </summary>
        /// <remarks>
        /// Propose a shift swap
        /// </remarks>
        public UkEssRosterShiftActionResponse ProposeShiftSwap(int employeeId, SwapShiftModel model)
        {
            return ApiRequest<UkEssRosterShiftActionResponse,SwapShiftModel>($"/ess/{employeeId}/shift/swap/propose", model, Method.POST);
        }

        /// <summary>
        /// Clock Out Employee
        /// </summary>
        /// <remarks>
        /// Clocks out the employee from their existing shift.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public void ClockOutEmployee(int employeeId, ClockOffModel request)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/clockoff", request, Method.POST);
        }

        /// <summary>
        /// Clock In Employee
        /// </summary>
        /// <remarks>
        /// Clocks in an employee for a new shift.
        /// </remarks>
        public KioskEmployeeModel ClockInEmployee(int employeeId, UkClockOnModel model)
        {
            return ApiRequest<KioskEmployeeModel,UkClockOnModel>($"/ess/{employeeId}/timeandattendance/clockon", model, Method.POST);
        }

        /// <summary>
        /// Discard current shift
        /// </summary>
        /// <remarks>
        /// Discards the current shift for an employee.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public void DiscardCurrentShift(int employeeId, ClockOffModel request)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/discard", request, Method.POST);
        }

        /// <summary>
        /// End Break
        /// </summary>
        /// <remarks>
        /// Ends the employee's current break.
        /// </remarks>
        public void EndBreak(int employeeId, EndBreakModel request)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/endbreak", request, Method.POST);
        }

        /// <summary>
        /// Get Lookup Data
        /// </summary>
        /// <remarks>
        /// Gets relevant lookup data for the employee in relation to a kiosk.
        /// </remarks>
        public UkTimeAndAttendanceLookupDataModel GetLookupData(int employeeId)
        {
            return ApiRequest<UkTimeAndAttendanceLookupDataModel>($"/ess/{employeeId}/timeandattendance/lookupdata");
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public void GetShiftNotes(int employeeId, int shiftId, GetShiftNotesQueryModel request)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes?employeeId={request.EmployeeId}&isAdminInitiated={request.IsAdminInitiated}&type={request.Type}&visibility={request.Visibility}");
        }

        /// <summary>
        /// Add Note to Shift
        /// </summary>
        /// <remarks>
        /// Adds a note to an existing shift.
        /// </remarks>
        public void AddNoteToShift(int employeeId, int shiftId, AddNoteModel model)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes", model, Method.POST);
        }

        /// <summary>
        /// Mark Shift Notes Read
        /// </summary>
        /// <remarks>
        /// Marks some shift notes as either read or unread.
        /// </remarks>
        public void MarkShiftNotesRead(int employeeId, MarkNotesReadViewModel model, string shiftId)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes/read-state", model, Method.POST);
        }

        /// <summary>
        /// Shifts
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public List<UkTimeAndAttendanceShiftModel> Shifts(int employeeId, GetShiftsModel model)
        {
            return ApiRequest<List<UkTimeAndAttendanceShiftModel>,GetShiftsModel>($"/ess/{employeeId}/timeandattendance/shifts", model, Method.POST);
        }

        /// <summary>
        /// Start Break
        /// </summary>
        /// <remarks>
        /// Starts a break for the employee who is clocked on for a shift.
        /// </remarks>
        public void StartBreak(int employeeId, StartBreakModel request)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/startbreak", request, Method.POST);
        }

        /// <summary>
        /// List Timesheets
        /// </summary>
        /// <remarks>
        /// Lists timesheets for the employee.
        /// </remarks>
        public List<EssTimesheetModel> ListTimesheets(int employeeId, ListTimesheetsQueryModel request)
        {
            return ApiRequest<List<EssTimesheetModel>>($"/ess/{employeeId}/timesheet?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Submit or Update Timesheet
        /// </summary>
        /// <remarks>
        /// If no ID is specified, create a new timesheet for the employee. 
        /// Otherwise, update the timesheet with the specified ID.
        /// </remarks>
        public void SubmitOrUpdateTimesheet(int employeeId, EssTimesheetModel timesheet)
        {
            ApiRequest($"/ess/{employeeId}/timesheet", timesheet, Method.POST);
        }

        /// <summary>
        /// Edit Timesheet
        /// </summary>
        /// <remarks>
        /// Edits the timesheet with the specified ID.
        /// </remarks>
        public void EditTimesheet(int employeeId, int timesheetId, EssTimesheetModel timesheet)
        {
            ApiRequest($"/ess/{employeeId}/timesheet/{timesheetId}", timesheet, Method.POST);
        }

        /// <summary>
        /// Delete Timesheet
        /// </summary>
        /// <remarks>
        /// Deletes the timesheet with the specified ID.
        /// </remarks>
        public void DeleteTimesheet(int employeeId, int timesheetId)
        {
            ApiRequest($"/ess/{employeeId}/timesheet/{timesheetId}", Method.DELETE);
        }

        /// <summary>
        /// Get Timesheet Creation Data
        /// </summary>
        /// <remarks>
        /// Lists relevant timesheet, leave and shift data for an employee, to allow for intuitive timesheet creation.
        /// </remarks>
        public UkEssTimesheetDataModel GetTimesheetCreationData(int employeeId, GetTimesheetCreationDataQueryModel request)
        {
            return ApiRequest<UkEssTimesheetDataModel>($"/ess/{employeeId}/timesheet/data?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this employee, with optional filters.
        /// </remarks>
        public List<EssUnavailabilityModel> ListUnavailabilities(int employeeId, ListUnavailabilitiesQueryModel request)
        {
            return ApiRequest<List<EssUnavailabilityModel>>($"/ess/{employeeId}/unavailability?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}");
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Creates a new unavailability for the employee.
        /// </remarks>
        public EssUnavailabilityModel CreateUnavailability(int employeeId, UnavailabilityEditModel unavailability)
        {
            return ApiRequest<EssUnavailabilityModel,UnavailabilityEditModel>($"/ess/{employeeId}/unavailability", unavailability, Method.POST);
        }

        /// <summary>
        /// Get unavailability by ID
        /// </summary>
        /// <remarks>
        /// Gets the unavailability with the specified ID (so long as the unavailability is from the specified employee).
        /// </remarks>
        public EssUnavailabilityModel GetUnavailabilityById(int employeeId, int unavailabilityId)
        {
            return ApiRequest<EssUnavailabilityModel>($"/ess/{employeeId}/unavailability/{unavailabilityId}");
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public void UpdateUnavailability(int employeeId, int unavailabilityId, UnavailabilityEditModel unavailability)
        {
            ApiRequest($"/ess/{employeeId}/unavailability/{unavailabilityId}", unavailability, Method.PUT);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public void DeleteUnavailability(int employeeId, int unavailabilityId)
        {
            ApiRequest($"/ess/{employeeId}/unavailability/{unavailabilityId}", Method.DELETE);
        }

        /// <summary>
        /// Register Device Token
        /// </summary>
        /// <remarks>
        /// Registers a device token.
        /// </remarks>
        public void RegisterDeviceToken(DeviceTokenModel model)
        {
            ApiRequest($"/ess/devicetoken/register", model, Method.POST);
        }

        /// <summary>
        /// Unregister Device Token
        /// </summary>
        /// <remarks>
        /// Unregisters a device token.
        /// </remarks>
        public void UnregisterDeviceToken(DeviceTokenModel model)
        {
            ApiRequest($"/ess/devicetoken/unregister", model, Method.POST);
        }

        /// <summary>
        /// Get Employees
        /// </summary>
        /// <remarks>
        /// Returns all the employees the user can access.
        /// </remarks>
        public List<AvailableEmployeeModel> GetEmployees()
        {
            return ApiRequest<List<AvailableEmployeeModel>>($"/ess/security/employees");
        }

        /// <summary>
        /// Recover Forgotten Password
        /// </summary>
        /// <remarks>
        /// Sends an email so that the user can reset their password
        /// </remarks>
        public void RecoverForgottenPassword(RecoverPasswordModel model)
        {
            ApiRequest($"/ess/security/forgottenpassword", model, Method.POST);
        }
    }
}
