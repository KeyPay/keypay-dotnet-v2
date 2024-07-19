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
using KeyPayV2.My.Models.Ess;

namespace KeyPayV2.My.Functions
{
    public interface IEssFunction
    {
        List<MyEssBankAccountModel> ListBankAccounts(int employeeId);
        Task<List<MyEssBankAccountModel>> ListBankAccountsAsync(int employeeId, CancellationToken cancellationToken = default);
        MyEssSaveBankAccountResponseModel CreateBankAccount(int employeeId, MyEssBankAccountModel model);
        Task<MyEssSaveBankAccountResponseModel> CreateBankAccountAsync(int employeeId, MyEssBankAccountModel model, CancellationToken cancellationToken = default);
        MyEssBankAccountModel GetBankAccountById(int employeeId, int bankAccountId);
        Task<MyEssBankAccountModel> GetBankAccountByIdAsync(int employeeId, int bankAccountId, CancellationToken cancellationToken = default);
        MyEssSaveBankAccountResponseModel UpdateBankAccount(int employeeId, int bankAccountId, MyEssBankAccountModel model);
        Task<MyEssSaveBankAccountResponseModel> UpdateBankAccountAsync(int employeeId, int bankAccountId, MyEssBankAccountModel model, CancellationToken cancellationToken = default);
        MyEssSaveBankAccountResponseModel DeleteBankAccount(int employeeId, int bankAccountId);
        Task<MyEssSaveBankAccountResponseModel> DeleteBankAccountAsync(int employeeId, int bankAccountId, CancellationToken cancellationToken = default);
        SaveBankAccountResponseModel UpdateBankAccount(int employeeId, int id, BankAccountModel model);
        Task<SaveBankAccountResponseModel> UpdateBankAccountAsync(int employeeId, int id, BankAccountModel model, CancellationToken cancellationToken = default);
        MyDashboardModel GetDashboard(int employeeId);
        Task<MyDashboardModel> GetDashboardAsync(int employeeId, CancellationToken cancellationToken = default);
        EssEmployeeDetailsModel GetDetails(int employeeId);
        Task<EssEmployeeDetailsModel> GetDetailsAsync(int employeeId, CancellationToken cancellationToken = default);
        MyUnstructuredEmployeeModel SaveDetails(int employeeId, EmployeePartialEditModel model);
        Task<MyUnstructuredEmployeeModel> SaveDetailsAsync(int employeeId, EmployeePartialEditModel model, CancellationToken cancellationToken = default);
        List<EssDocumentModel> ListAllDocuments(int employeeId);
        Task<List<EssDocumentModel>> ListAllDocumentsAsync(int employeeId, CancellationToken cancellationToken = default);
        EssDocumentModel GetDocumentDetailsById(int employeeId, string documentId);
        Task<EssDocumentModel> GetDocumentDetailsByIdAsync(int employeeId, string documentId, CancellationToken cancellationToken = default);
        void AcknowledgeDocument(int employeeId, string documentId);
        Task AcknowledgeDocumentAsync(int employeeId, string documentId, CancellationToken cancellationToken = default);
        void DownloadDocument(int employeeId, string documentId);
        Task DownloadDocumentAsync(int employeeId, string documentId, CancellationToken cancellationToken = default);
        void MyEssDocument_EAForm(int employeeId, int documentId);
        Task MyEssDocument_EAFormAsync(int employeeId, int documentId, CancellationToken cancellationToken = default);
        List<MyEssFormModel> GetEaForms(int employeeId);
        Task<List<MyEssFormModel>> GetEaFormsAsync(int employeeId, CancellationToken cancellationToken = default);
        List<EssPayslipModel> ListPaySlips(int employeeId);
        Task<List<EssPayslipModel>> ListPaySlipsAsync(int employeeId, CancellationToken cancellationToken = default);
        void GetPaySlipByPayRunId(int employeeId, int payrunId);
        Task GetPaySlipByPayRunIdAsync(int employeeId, int payrunId, CancellationToken cancellationToken = default);
        void MyEssDocument_Pcb2Form(int employeeId, int documentId);
        Task MyEssDocument_Pcb2FormAsync(int employeeId, int documentId, CancellationToken cancellationToken = default);
        List<MyEssFormModel> MyEssDocument_Pcb2Forms(int employeeId);
        Task<List<MyEssFormModel>> MyEssDocument_Pcb2FormsAsync(int employeeId, CancellationToken cancellationToken = default);
        EmployeeEmergencyContactsEditModel GetEmergencyContacts(int employeeId);
        Task<EmployeeEmergencyContactsEditModel> GetEmergencyContactsAsync(int employeeId, CancellationToken cancellationToken = default);
        EmployeeEmergencyContactsEditModel UpdateEmergencyContacts(int employeeId, EmployeeEmergencyContactsEditModel model);
        Task<EmployeeEmergencyContactsEditModel> UpdateEmergencyContactsAsync(int employeeId, EmployeeEmergencyContactsEditModel model, CancellationToken cancellationToken = default);
        EmployeeEmergencyContactsEditModel SaveEmergencyContacts(int employeeId, EmployeeEmergencyContactsEditModel model);
        Task<EmployeeEmergencyContactsEditModel> SaveEmergencyContactsAsync(int employeeId, EmployeeEmergencyContactsEditModel model, CancellationToken cancellationToken = default);
        List<EssExpenseRequestResponseModel> GetExpenseRequests(int employeeId);
        Task<List<EssExpenseRequestResponseModel>> GetExpenseRequestsAsync(int employeeId, CancellationToken cancellationToken = default);
        List<EssExpenseRequestResponseModel> GetExpenseRequests(int employeeId, GetExpenseRequestsQueryModel request);
        Task<List<EssExpenseRequestResponseModel>> GetExpenseRequestsAsync(int employeeId, GetExpenseRequestsQueryModel request, CancellationToken cancellationToken = default);
        void CreateExpenseRequest(int employeeId, ExpenseRequestEditModel model);
        Task CreateExpenseRequestAsync(int employeeId, ExpenseRequestEditModel model, CancellationToken cancellationToken = default);
        EssExpenseRequestResponseModel GetExpenseRequestById(int employeeId, int expenseRequestId);
        Task<EssExpenseRequestResponseModel> GetExpenseRequestByIdAsync(int employeeId, int expenseRequestId, CancellationToken cancellationToken = default);
        void UpdateExpenseRequest(int employeeId, int expenseRequestId, ExpenseRequestEditModel model);
        Task UpdateExpenseRequestAsync(int employeeId, int expenseRequestId, ExpenseRequestEditModel model, CancellationToken cancellationToken = default);
        EssExpenseRequestResponseModel DeleteExpenseRequest(int employeeId, int expenseRequestId);
        Task<EssExpenseRequestResponseModel> DeleteExpenseRequestAsync(int employeeId, int expenseRequestId, CancellationToken cancellationToken = default);
        void UploadAttachmentToExpenseRequest(int employeeId, int expenseRequestId, UploadAttachmentToExpenseRequestQueryModel request);
        Task UploadAttachmentToExpenseRequestAsync(int employeeId, int expenseRequestId, UploadAttachmentToExpenseRequestQueryModel request, CancellationToken cancellationToken = default);
        List<ExpenseCategoryResponseModel> GetExpenseCategories(int employeeId);
        Task<List<ExpenseCategoryResponseModel>> GetExpenseCategoriesAsync(int employeeId, CancellationToken cancellationToken = default);
        List<EmployeeExpensePaymentSummaryModel> GetExpensePaymentSummary(int employeeId);
        Task<List<EmployeeExpensePaymentSummaryModel>> GetExpensePaymentSummaryAsync(int employeeId, CancellationToken cancellationToken = default);
        List<JournalServiceTaxCode> GetTaxCodes(int employeeId);
        Task<List<JournalServiceTaxCode>> GetTaxCodesAsync(int employeeId, CancellationToken cancellationToken = default);
        List<EssLeaveRequestModel> ListLeaveRequests(int employeeId);
        Task<List<EssLeaveRequestModel>> ListLeaveRequestsAsync(int employeeId, CancellationToken cancellationToken = default);
        List<EssLeaveRequestModel> ListLeaveRequests(int employeeId, ListLeaveRequestsQueryModel request);
        Task<List<EssLeaveRequestModel>> ListLeaveRequestsAsync(int employeeId, ListLeaveRequestsQueryModel request, CancellationToken cancellationToken = default);
        void CreateLeaveRequest(int employeeId, LeaveApplicationWithAttachmentModel leaveApplication);
        Task CreateLeaveRequestAsync(int employeeId, LeaveApplicationWithAttachmentModel leaveApplication, CancellationToken cancellationToken = default);
        EssLeaveRequestModel GetLeaveRequestById(int employeeId, int leaveRequestId);
        Task<EssLeaveRequestModel> GetLeaveRequestByIdAsync(int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        void UpdateLeaveRequest(int employeeId, int leaveRequestId, LeaveApplicationWithAttachmentModel leaveApplication);
        Task UpdateLeaveRequestAsync(int employeeId, int leaveRequestId, LeaveApplicationWithAttachmentModel leaveApplication, CancellationToken cancellationToken = default);
        void DeleteLeaveRequest(int employeeId, int leaveRequestId);
        Task DeleteLeaveRequestAsync(int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        void UploadAttachmentToLeaveRequest(int employeeId, int leaveRequestId);
        Task UploadAttachmentToLeaveRequestAsync(int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        void DeleteAttachmentFromLeaveRequest(int employeeId, int leaveRequestId);
        Task DeleteAttachmentFromLeaveRequestAsync(int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        List<LeaveBalanceModel> GetLeaveBalances(int employeeId);
        Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int employeeId, CancellationToken cancellationToken = default);
        List<LeaveBalanceModel> GetLeaveBalances(int employeeId, GetLeaveBalancesQueryModel request);
        Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int employeeId, GetLeaveBalancesQueryModel request, CancellationToken cancellationToken = default);
        EssLeaveEstimate EstimateLeaveHours(int employeeId, EstimateLeaveHoursQueryModel request);
        Task<EssLeaveEstimate> EstimateLeaveHoursAsync(int employeeId, EstimateLeaveHoursQueryModel request, CancellationToken cancellationToken = default);
        List<EssLeaveCategoryModel> GetLeaveCategories(int employeeId);
        Task<List<EssLeaveCategoryModel>> GetLeaveCategoriesAsync(int employeeId, CancellationToken cancellationToken = default);
        void MyEssLookup_Addresses(int employeeId, int suburbId);
        Task MyEssLookup_AddressesAsync(int employeeId, int suburbId, CancellationToken cancellationToken = default);
        List<LocationModel> GetLocations(int employeeId);
        Task<List<LocationModel>> GetLocationsAsync(int employeeId, CancellationToken cancellationToken = default);
        List<MyEssWorkTypeModel> GetShiftConditions(int employeeId);
        Task<List<MyEssWorkTypeModel>> GetShiftConditionsAsync(int employeeId, CancellationToken cancellationToken = default);
        SuburbResult GetSuburb(int employeeId, GetSuburbQueryModel request);
        Task<SuburbResult> GetSuburbAsync(int employeeId, GetSuburbQueryModel request, CancellationToken cancellationToken = default);
        PagedResultModel<SuburbModel> SearchSuburbs(int employeeId, SearchSuburbsQueryModel request);
        Task<PagedResultModel<SuburbModel>> SearchSuburbsAsync(int employeeId, SearchSuburbsQueryModel request, CancellationToken cancellationToken = default);
        List<TitleViewModel> GetTitles(int employeeId);
        Task<List<TitleViewModel>> GetTitlesAsync(int employeeId, CancellationToken cancellationToken = default);
        List<MyEssWorkTypeModel> GetWorkTypes(int employeeId);
        Task<List<MyEssWorkTypeModel>> GetWorkTypesAsync(int employeeId, CancellationToken cancellationToken = default);
        MyEssEmployeeDetailsViewModel GetPersonalDetails(int employeeId);
        Task<MyEssEmployeeDetailsViewModel> GetPersonalDetailsAsync(int employeeId, CancellationToken cancellationToken = default);
        MyEssEmployeeDetailsViewModel UpdatePersonalDetails(int employeeId, MyEssEmployeeDetailsEditModel model);
        Task<MyEssEmployeeDetailsViewModel> UpdatePersonalDetailsAsync(int employeeId, MyEssEmployeeDetailsEditModel model, CancellationToken cancellationToken = default);
        void GetEmployeeProfileImage(int employeeId);
        Task GetEmployeeProfileImageAsync(int employeeId, CancellationToken cancellationToken = default);
        ProfileImageMetadata SetEmployeeProfileImage(int employeeId);
        Task<ProfileImageMetadata> SetEmployeeProfileImageAsync(int employeeId, CancellationToken cancellationToken = default);
        void DeleteEmployeeProfileImage(int employeeId);
        Task DeleteEmployeeProfileImageAsync(int employeeId, CancellationToken cancellationToken = default);
        List<PublicHolidayModel> GetPublicHolidays(int employeeId, GetPublicHolidaysQueryModel request);
        Task<List<PublicHolidayModel>> GetPublicHolidaysAsync(int employeeId, GetPublicHolidaysQueryModel request, CancellationToken cancellationToken = default);
        List<EssEmployeeQualificationModel> GetQualificationsForEmployee(int employeeId);
        Task<List<EssEmployeeQualificationModel>> GetQualificationsForEmployeeAsync(int employeeId, CancellationToken cancellationToken = default);
        void AddEmployeeQualification(int employeeId, EssEmployeeQualificationModel qualification);
        Task AddEmployeeQualificationAsync(int employeeId, EssEmployeeQualificationModel qualification, CancellationToken cancellationToken = default);
        void UploadAttachmentToQualification(int employeeId, int employeeQualificationId, UploadAttachmentToQualificationQueryModel request);
        Task UploadAttachmentToQualificationAsync(int employeeId, int employeeQualificationId, UploadAttachmentToQualificationQueryModel request, CancellationToken cancellationToken = default);
        void DeleteAttachmentFromEmployeequalification(int employeeId, int employeeQualificationId, int documentId);
        Task DeleteAttachmentFromEmployeequalificationAsync(int employeeId, int employeeQualificationId, int documentId, CancellationToken cancellationToken = default);
        EssEmployeeQualificationModel GetQualificationDetails(int employeeId, int id);
        Task<EssEmployeeQualificationModel> GetQualificationDetailsAsync(int employeeId, int id, CancellationToken cancellationToken = default);
        void UpdateEmployeeQualification(int employeeId, int id, EssEmployeeQualificationModel qualification);
        Task UpdateEmployeeQualificationAsync(int employeeId, int id, EssEmployeeQualificationModel qualification, CancellationToken cancellationToken = default);
        void DeleteEmployeeQualification(int employeeId, int id);
        Task DeleteEmployeeQualificationAsync(int employeeId, int id, CancellationToken cancellationToken = default);
        List<EssSatisfactionSurvey> GetSatisfactionSurveyResults(int employeeId);
        Task<List<EssSatisfactionSurvey>> GetSatisfactionSurveyResultsAsync(int employeeId, CancellationToken cancellationToken = default);
        List<EssSatisfactionSurvey> GetSatisfactionSurveyResults(int employeeId, GetSatisfactionSurveyResultsQueryModel request);
        Task<List<EssSatisfactionSurvey>> GetSatisfactionSurveyResultsAsync(int employeeId, GetSatisfactionSurveyResultsQueryModel request, CancellationToken cancellationToken = default);
        EmployeeSatisfactionValue SubmitSatisfactionSurvey(int employeeId, EssSatisfactionSurvey survey);
        Task<EmployeeSatisfactionValue> SubmitSatisfactionSurveyAsync(int employeeId, EssSatisfactionSurvey survey, CancellationToken cancellationToken = default);
        List<MyEssRosterShiftModel> ListRosterShifts(int employeeId, ListRosterShiftsQueryModel request);
        Task<List<MyEssRosterShiftModel>> ListRosterShiftsAsync(int employeeId, ListRosterShiftsQueryModel request, CancellationToken cancellationToken = default);
        MyEssRosterShiftModel GetRosterShiftById(int employeeId, int shiftId);
        Task<MyEssRosterShiftModel> GetRosterShiftByIdAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default);
        MyAcceptRosterShiftResponseModel AcceptRosterShift(int employeeId, int shiftId);
        Task<MyAcceptRosterShiftResponseModel> AcceptRosterShiftAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default);
        EssRosterShiftCountModel DeclineRosterShift(int employeeId, int shiftId, EssDeclineRosterShiftModel model);
        Task<EssRosterShiftCountModel> DeclineRosterShiftAsync(int employeeId, int shiftId, EssDeclineRosterShiftModel model, CancellationToken cancellationToken = default);
        MyEssRosterShiftActionResponse AcceptShiftSwap(int employeeId, int shiftId);
        Task<MyEssRosterShiftActionResponse> AcceptShiftSwapAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default);
        MyEssRosterShiftActionResponse CancelShiftSwap(int employeeId, int shiftId);
        Task<MyEssRosterShiftActionResponse> CancelShiftSwapAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default);
        List<EssShiftSwapCandidate> EmployeesEligibleForShiftSwap(int employeeId, int shiftId);
        Task<List<EssShiftSwapCandidate>> EmployeesEligibleForShiftSwapAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default);
        MyEssRosterShiftActionResponse DeclineShiftSwap(int employeeId, int shiftId);
        Task<MyEssRosterShiftActionResponse> DeclineShiftSwapAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default);
        MyAcceptRosterShiftsResponseModel BulkAcceptRosterShifts(int employeeId, EssBulkAcceptRosterShiftsModel model);
        Task<MyAcceptRosterShiftsResponseModel> BulkAcceptRosterShiftsAsync(int employeeId, EssBulkAcceptRosterShiftsModel model, CancellationToken cancellationToken = default);
        EssRosterShiftCountModel BulkDeclineRosterShifts(int employeeId, EssBulkDeclineRosterShiftsModel model);
        Task<EssRosterShiftCountModel> BulkDeclineRosterShiftsAsync(int employeeId, EssBulkDeclineRosterShiftsModel model, CancellationToken cancellationToken = default);
        MyRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int employeeId, FindMatchingClockOffRosterShiftQueryModel request);
        Task<MyRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int employeeId, FindMatchingClockOffRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        MyRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int employeeId, FindMatchingClockOnRosterShiftQueryModel request);
        Task<MyRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int employeeId, FindMatchingClockOnRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        List<MyEssRosterShiftModel> FindNearbyRosterShifts(int employeeId, FindNearbyRosterShiftsQueryModel request);
        Task<List<MyEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int employeeId, FindNearbyRosterShiftsQueryModel request, CancellationToken cancellationToken = default);
        MyEssBulkRosterShiftActionResponse BulkAcceptRosterShiftSwaps(int employeeId, EssBulkRosterShiftSwapModel model);
        Task<MyEssBulkRosterShiftActionResponse> BulkAcceptRosterShiftSwapsAsync(int employeeId, EssBulkRosterShiftSwapModel model, CancellationToken cancellationToken = default);
        MyEssBulkRosterShiftActionResponse BulkCancelRosterShiftSwaps(int employeeId, EssBulkRosterShiftSwapModel model);
        Task<MyEssBulkRosterShiftActionResponse> BulkCancelRosterShiftSwapsAsync(int employeeId, EssBulkRosterShiftSwapModel model, CancellationToken cancellationToken = default);
        MyEssBulkRosterShiftActionResponse BulkDeclineRosterShiftSwaps(int employeeId, EssBulkRosterShiftSwapModel model);
        Task<MyEssBulkRosterShiftActionResponse> BulkDeclineRosterShiftSwapsAsync(int employeeId, EssBulkRosterShiftSwapModel model, CancellationToken cancellationToken = default);
        MyEssRosterShiftActionResponse ProposeShiftSwap(int employeeId, SwapShiftModel model);
        Task<MyEssRosterShiftActionResponse> ProposeShiftSwapAsync(int employeeId, SwapShiftModel model, CancellationToken cancellationToken = default);
        void ClockOutEmployee(int employeeId, ClockOffModel request);
        Task ClockOutEmployeeAsync(int employeeId, ClockOffModel request, CancellationToken cancellationToken = default);
        KioskEmployeeModel ClockInEmployee(int employeeId, MyClockOnModel model);
        Task<KioskEmployeeModel> ClockInEmployeeAsync(int employeeId, MyClockOnModel model, CancellationToken cancellationToken = default);
        void DiscardCurrentShift(int employeeId, ClockOffModel request);
        Task DiscardCurrentShiftAsync(int employeeId, ClockOffModel request, CancellationToken cancellationToken = default);
        void EndBreak(int employeeId, EndBreakModel request);
        Task EndBreakAsync(int employeeId, EndBreakModel request, CancellationToken cancellationToken = default);
        MyTimeAndAttendanceLookupDataModel GetLookupData(int employeeId);
        Task<MyTimeAndAttendanceLookupDataModel> GetLookupDataAsync(int employeeId, CancellationToken cancellationToken = default);
        void GetShiftNotes(int employeeId, int shiftId);
        Task GetShiftNotesAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default);
        void GetShiftNotes(int employeeId, int shiftId, GetShiftNotesQueryModel request);
        Task GetShiftNotesAsync(int employeeId, int shiftId, GetShiftNotesQueryModel request, CancellationToken cancellationToken = default);
        void AddNoteToShift(int employeeId, int shiftId, AddNoteModel model);
        Task AddNoteToShiftAsync(int employeeId, int shiftId, AddNoteModel model, CancellationToken cancellationToken = default);
        void MarkShiftNotesRead(int employeeId, MarkNotesReadViewModel model, string shiftId);
        Task MarkShiftNotesReadAsync(int employeeId, MarkNotesReadViewModel model, string shiftId, CancellationToken cancellationToken = default);
        List<MyTimeAndAttendanceShiftModel> Shifts(int employeeId, GetShiftsModel model);
        Task<List<MyTimeAndAttendanceShiftModel>> ShiftsAsync(int employeeId, GetShiftsModel model, CancellationToken cancellationToken = default);
        void StartBreak(int employeeId, StartBreakModel request);
        Task StartBreakAsync(int employeeId, StartBreakModel request, CancellationToken cancellationToken = default);
        List<EssTimesheetModel> ListTimesheets(int employeeId, ListTimesheetsQueryModel request);
        Task<List<EssTimesheetModel>> ListTimesheetsAsync(int employeeId, ListTimesheetsQueryModel request, CancellationToken cancellationToken = default);
        void SubmitOrUpdateTimesheet(int employeeId, EssTimesheetModel timesheet);
        Task SubmitOrUpdateTimesheetAsync(int employeeId, EssTimesheetModel timesheet, CancellationToken cancellationToken = default);
        void EditTimesheet(int employeeId, int timesheetId, EssTimesheetModel timesheet);
        Task EditTimesheetAsync(int employeeId, int timesheetId, EssTimesheetModel timesheet, CancellationToken cancellationToken = default);
        void DeleteTimesheet(int employeeId, int timesheetId);
        Task DeleteTimesheetAsync(int employeeId, int timesheetId, CancellationToken cancellationToken = default);
        MyEssTimesheetDataModel GetTimesheetCreationData(int employeeId, GetTimesheetCreationDataQueryModel request);
        Task<MyEssTimesheetDataModel> GetTimesheetCreationDataAsync(int employeeId, GetTimesheetCreationDataQueryModel request, CancellationToken cancellationToken = default);
        List<EssUnavailabilityModel> ListUnavailabilities(int employeeId);
        Task<List<EssUnavailabilityModel>> ListUnavailabilitiesAsync(int employeeId, CancellationToken cancellationToken = default);
        List<EssUnavailabilityModel> ListUnavailabilities(int employeeId, ListUnavailabilitiesQueryModel request);
        Task<List<EssUnavailabilityModel>> ListUnavailabilitiesAsync(int employeeId, ListUnavailabilitiesQueryModel request, CancellationToken cancellationToken = default);
        EssUnavailabilityModel CreateUnavailability(int employeeId, UnavailabilityEditModel unavailability);
        Task<EssUnavailabilityModel> CreateUnavailabilityAsync(int employeeId, UnavailabilityEditModel unavailability, CancellationToken cancellationToken = default);
        EssUnavailabilityModel GetUnavailabilityById(int employeeId, int unavailabilityId);
        Task<EssUnavailabilityModel> GetUnavailabilityByIdAsync(int employeeId, int unavailabilityId, CancellationToken cancellationToken = default);
        void UpdateUnavailability(int employeeId, int unavailabilityId, UnavailabilityEditModel unavailability);
        Task UpdateUnavailabilityAsync(int employeeId, int unavailabilityId, UnavailabilityEditModel unavailability, CancellationToken cancellationToken = default);
        void DeleteUnavailability(int employeeId, int unavailabilityId);
        Task DeleteUnavailabilityAsync(int employeeId, int unavailabilityId, CancellationToken cancellationToken = default);
        void RegisterDeviceToken(DeviceTokenModel model);
        Task RegisterDeviceTokenAsync(DeviceTokenModel model, CancellationToken cancellationToken = default);
        void UnregisterDeviceToken(DeviceTokenModel model);
        Task UnregisterDeviceTokenAsync(DeviceTokenModel model, CancellationToken cancellationToken = default);
        List<AvailableEmployeeModel> GetEmployees();
        Task<List<AvailableEmployeeModel>> GetEmployeesAsync(CancellationToken cancellationToken = default);
        void RecoverForgottenPassword(RecoverPasswordModel model);
        Task RecoverForgottenPasswordAsync(RecoverPasswordModel model, CancellationToken cancellationToken = default);
    }
    public class EssFunction : BaseFunction, IEssFunction
    {
        public EssFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Bank Accounts
        /// </summary>
        /// <remarks>
        /// Lists all of the bank accounts for this employee.
        /// </remarks>
        public List<MyEssBankAccountModel> ListBankAccounts(int employeeId)
        {
            return ApiRequest<List<MyEssBankAccountModel>>($"/ess/{employeeId}/bankaccounts", Method.Get);
        }

        /// <summary>
        /// List Bank Accounts
        /// </summary>
        /// <remarks>
        /// Lists all of the bank accounts for this employee.
        /// </remarks>
        public Task<List<MyEssBankAccountModel>> ListBankAccountsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyEssBankAccountModel>>($"/ess/{employeeId}/bankaccounts", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee
        /// </remarks>
        public MyEssSaveBankAccountResponseModel CreateBankAccount(int employeeId, MyEssBankAccountModel model)
        {
            return ApiRequest<MyEssSaveBankAccountResponseModel,MyEssBankAccountModel>($"/ess/{employeeId}/bankaccounts", model, Method.Post);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee
        /// </remarks>
        public Task<MyEssSaveBankAccountResponseModel> CreateBankAccountAsync(int employeeId, MyEssBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssSaveBankAccountResponseModel,MyEssBankAccountModel>($"/ess/{employeeId}/bankaccounts", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public MyEssBankAccountModel GetBankAccountById(int employeeId, int bankAccountId)
        {
            return ApiRequest<MyEssBankAccountModel>($"/ess/{employeeId}/bankaccounts/{bankAccountId}", Method.Get);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public Task<MyEssBankAccountModel> GetBankAccountByIdAsync(int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssBankAccountModel>($"/ess/{employeeId}/bankaccounts/{bankAccountId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID
        /// </remarks>
        public MyEssSaveBankAccountResponseModel UpdateBankAccount(int employeeId, int bankAccountId, MyEssBankAccountModel model)
        {
            return ApiRequest<MyEssSaveBankAccountResponseModel,MyEssBankAccountModel>($"/ess/{employeeId}/bankaccounts/{bankAccountId}", model, Method.Put);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID
        /// </remarks>
        public Task<MyEssSaveBankAccountResponseModel> UpdateBankAccountAsync(int employeeId, int bankAccountId, MyEssBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssSaveBankAccountResponseModel,MyEssBankAccountModel>($"/ess/{employeeId}/bankaccounts/{bankAccountId}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID
        /// </remarks>
        public MyEssSaveBankAccountResponseModel DeleteBankAccount(int employeeId, int bankAccountId)
        {
            return ApiRequest<MyEssSaveBankAccountResponseModel>($"/ess/{employeeId}/bankaccounts/{bankAccountId}", Method.Delete);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID
        /// </remarks>
        public Task<MyEssSaveBankAccountResponseModel> DeleteBankAccountAsync(int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssSaveBankAccountResponseModel>($"/ess/{employeeId}/bankaccounts/{bankAccountId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public SaveBankAccountResponseModel UpdateBankAccount(int employeeId, int id, BankAccountModel model)
        {
            return ApiRequest<SaveBankAccountResponseModel,BankAccountModel>($"/ess/{employeeId}/bankaccounts/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public Task<SaveBankAccountResponseModel> UpdateBankAccountAsync(int employeeId, int id, BankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SaveBankAccountResponseModel,BankAccountModel>($"/ess/{employeeId}/bankaccounts/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Dashboard
        /// </summary>
        /// <remarks>
        /// Gets a set of useful information that the employee may need for self setup tasks.
        /// </remarks>
        public MyDashboardModel GetDashboard(int employeeId)
        {
            return ApiRequest<MyDashboardModel>($"/ess/{employeeId}/dashboard", Method.Get);
        }

        /// <summary>
        /// Get Dashboard
        /// </summary>
        /// <remarks>
        /// Gets a set of useful information that the employee may need for self setup tasks.
        /// </remarks>
        public Task<MyDashboardModel> GetDashboardAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyDashboardModel>($"/ess/{employeeId}/dashboard", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Details
        /// </summary>
        /// <remarks>
        /// Gets ESS details for the specified employee.
        /// </remarks>
        public EssEmployeeDetailsModel GetDetails(int employeeId)
        {
            return ApiRequest<EssEmployeeDetailsModel>($"/ess/{employeeId}/details", Method.Get);
        }

        /// <summary>
        /// Get Details
        /// </summary>
        /// <remarks>
        /// Gets ESS details for the specified employee.
        /// </remarks>
        public Task<EssEmployeeDetailsModel> GetDetailsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssEmployeeDetailsModel>($"/ess/{employeeId}/details", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Save Details
        /// </summary>
        /// <remarks>
        /// Saves any employee details that the employee is allowed to set.
        /// </remarks>
        public MyUnstructuredEmployeeModel SaveDetails(int employeeId, EmployeePartialEditModel model)
        {
            return ApiRequest<MyUnstructuredEmployeeModel,EmployeePartialEditModel>($"/ess/{employeeId}/details", model, Method.Post);
        }

        /// <summary>
        /// Save Details
        /// </summary>
        /// <remarks>
        /// Saves any employee details that the employee is allowed to set.
        /// </remarks>
        public Task<MyUnstructuredEmployeeModel> SaveDetailsAsync(int employeeId, EmployeePartialEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyUnstructuredEmployeeModel,EmployeePartialEditModel>($"/ess/{employeeId}/details", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List all Documents
        /// </summary>
        /// <remarks>
        /// Lists all documents visible to this employee, including both business and employee documents.
        /// </remarks>
        public List<EssDocumentModel> ListAllDocuments(int employeeId)
        {
            return ApiRequest<List<EssDocumentModel>>($"/ess/{employeeId}/document", Method.Get);
        }

        /// <summary>
        /// List all Documents
        /// </summary>
        /// <remarks>
        /// Lists all documents visible to this employee, including both business and employee documents.
        /// </remarks>
        public Task<List<EssDocumentModel>> ListAllDocumentsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssDocumentModel>>($"/ess/{employeeId}/document", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Document Details by ID
        /// </summary>
        /// <remarks>
        /// Gets details for the specified document which is visible to the employee.
        /// </remarks>
        public EssDocumentModel GetDocumentDetailsById(int employeeId, string documentId)
        {
            return ApiRequest<EssDocumentModel>($"/ess/{employeeId}/document/{documentId}", Method.Get);
        }

        /// <summary>
        /// Get Document Details by ID
        /// </summary>
        /// <remarks>
        /// Gets details for the specified document which is visible to the employee.
        /// </remarks>
        public Task<EssDocumentModel> GetDocumentDetailsByIdAsync(int employeeId, string documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssDocumentModel>($"/ess/{employeeId}/document/{documentId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Acknowledge Document
        /// </summary>
        /// <remarks>
        /// Acknowledges the document with the specified ID as having been read by the employee.
        /// </remarks>
        public void AcknowledgeDocument(int employeeId, string documentId)
        {
            ApiRequest($"/ess/{employeeId}/document/acknowledge/{documentId}", Method.Post);
        }

        /// <summary>
        /// Acknowledge Document
        /// </summary>
        /// <remarks>
        /// Acknowledges the document with the specified ID as having been read by the employee.
        /// </remarks>
        public Task AcknowledgeDocumentAsync(int employeeId, string documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/document/acknowledge/{documentId}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Download Document
        /// </summary>
        /// <remarks>
        /// Downloads the document with the specified ID so long as it is visible to the employee.
        /// </remarks>
        public void DownloadDocument(int employeeId, string documentId)
        {
            ApiRequest($"/ess/{employeeId}/document/download/{documentId}", Method.Get);
        }

        /// <summary>
        /// Download Document
        /// </summary>
        /// <remarks>
        /// Downloads the document with the specified ID so long as it is visible to the employee.
        /// </remarks>
        public Task DownloadDocumentAsync(int employeeId, string documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/document/download/{documentId}", Method.Get, cancellationToken);
        }

        public void MyEssDocument_EAForm(int employeeId, int documentId)
        {
            ApiRequest($"/ess/{employeeId}/document/eaform/{documentId}", Method.Get);
        }

        public Task MyEssDocument_EAFormAsync(int employeeId, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/document/eaform/{documentId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get EA Forms
        /// </summary>
        /// <remarks>
        /// List all the employee's published EA Forms
        /// </remarks>
        public List<MyEssFormModel> GetEaForms(int employeeId)
        {
            return ApiRequest<List<MyEssFormModel>>($"/ess/{employeeId}/document/eaforms", Method.Get);
        }

        /// <summary>
        /// Get EA Forms
        /// </summary>
        /// <remarks>
        /// List all the employee's published EA Forms
        /// </remarks>
        public Task<List<MyEssFormModel>> GetEaFormsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyEssFormModel>>($"/ess/{employeeId}/document/eaforms", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Pay Slips
        /// </summary>
        /// <remarks>
        /// Lists all pay slips for the employee.
        /// </remarks>
        public List<EssPayslipModel> ListPaySlips(int employeeId)
        {
            return ApiRequest<List<EssPayslipModel>>($"/ess/{employeeId}/document/payslip", Method.Get);
        }

        /// <summary>
        /// List Pay Slips
        /// </summary>
        /// <remarks>
        /// Lists all pay slips for the employee.
        /// </remarks>
        public Task<List<EssPayslipModel>> ListPaySlipsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssPayslipModel>>($"/ess/{employeeId}/document/payslip", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Pay Slip by Pay Run ID
        /// </summary>
        /// <remarks>
        /// Gets the pay slip for the pay run with the specified ID.
        /// </remarks>
        public void GetPaySlipByPayRunId(int employeeId, int payrunId)
        {
            ApiRequest($"/ess/{employeeId}/document/payslip/{payrunId}", Method.Get);
        }

        /// <summary>
        /// Get Pay Slip by Pay Run ID
        /// </summary>
        /// <remarks>
        /// Gets the pay slip for the pay run with the specified ID.
        /// </remarks>
        public Task GetPaySlipByPayRunIdAsync(int employeeId, int payrunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/document/payslip/{payrunId}", Method.Get, cancellationToken);
        }

        public void MyEssDocument_Pcb2Form(int employeeId, int documentId)
        {
            ApiRequest($"/ess/{employeeId}/document/pcb2form/{documentId}", Method.Get);
        }

        public Task MyEssDocument_Pcb2FormAsync(int employeeId, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/document/pcb2form/{documentId}", Method.Get, cancellationToken);
        }

        public List<MyEssFormModel> MyEssDocument_Pcb2Forms(int employeeId)
        {
            return ApiRequest<List<MyEssFormModel>>($"/ess/{employeeId}/document/pcb2forms", Method.Get);
        }

        public Task<List<MyEssFormModel>> MyEssDocument_Pcb2FormsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyEssFormModel>>($"/ess/{employeeId}/document/pcb2forms", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Gets emergency contacts for the specified employee.
        /// </remarks>
        public EmployeeEmergencyContactsEditModel GetEmergencyContacts(int employeeId)
        {
            return ApiRequest<EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", Method.Get);
        }

        /// <summary>
        /// Get Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Gets emergency contacts for the specified employee.
        /// </remarks>
        public Task<EmployeeEmergencyContactsEditModel> GetEmergencyContactsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Saves the employee's emergency contact details.
        /// </remarks>
        public EmployeeEmergencyContactsEditModel UpdateEmergencyContacts(int employeeId, EmployeeEmergencyContactsEditModel model)
        {
            return ApiRequest<EmployeeEmergencyContactsEditModel,EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", model, Method.Put);
        }

        /// <summary>
        /// Update Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Saves the employee's emergency contact details.
        /// </remarks>
        public Task<EmployeeEmergencyContactsEditModel> UpdateEmergencyContactsAsync(int employeeId, EmployeeEmergencyContactsEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeEmergencyContactsEditModel,EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Save Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Saves the employee's emergency contact details.
        /// </remarks>
        public EmployeeEmergencyContactsEditModel SaveEmergencyContacts(int employeeId, EmployeeEmergencyContactsEditModel model)
        {
            return ApiRequest<EmployeeEmergencyContactsEditModel,EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", model, Method.Post);
        }

        /// <summary>
        /// Save Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Saves the employee's emergency contact details.
        /// </remarks>
        public Task<EmployeeEmergencyContactsEditModel> SaveEmergencyContactsAsync(int employeeId, EmployeeEmergencyContactsEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeEmergencyContactsEditModel,EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Expense Requests
        /// </summary>
        /// <remarks>
        /// Gets a paged view of expense requests for this employee.
        /// </remarks>
        public List<EssExpenseRequestResponseModel> GetExpenseRequests(int employeeId)
        {
            return ApiRequest<List<EssExpenseRequestResponseModel>>($"/ess/{employeeId}/expense", Method.Get);
        }

        /// <summary>
        /// Get Expense Requests
        /// </summary>
        /// <remarks>
        /// Gets a paged view of expense requests for this employee.
        /// </remarks>
        public Task<List<EssExpenseRequestResponseModel>> GetExpenseRequestsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssExpenseRequestResponseModel>>($"/ess/{employeeId}/expense", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Expense Requests
        /// </summary>
        /// <remarks>
        /// Gets a paged view of expense requests for this employee.
        /// </remarks>
        public List<EssExpenseRequestResponseModel> GetExpenseRequests(int employeeId, GetExpenseRequestsQueryModel request)
        {
            return ApiRequest<List<EssExpenseRequestResponseModel>>($"/ess/{employeeId}/expense?currentPage={request.CurrentPage}&pageSize={request.PageSize}", Method.Get);
        }

        /// <summary>
        /// Get Expense Requests
        /// </summary>
        /// <remarks>
        /// Gets a paged view of expense requests for this employee.
        /// </remarks>
        public Task<List<EssExpenseRequestResponseModel>> GetExpenseRequestsAsync(int employeeId, GetExpenseRequestsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssExpenseRequestResponseModel>>($"/ess/{employeeId}/expense?currentPage={request.CurrentPage}&pageSize={request.PageSize}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Expense Request
        /// </summary>
        /// <remarks>
        /// Creates a new expense request for the employee.
        /// </remarks>
        public void CreateExpenseRequest(int employeeId, ExpenseRequestEditModel model)
        {
            ApiRequest($"/ess/{employeeId}/expense", model, Method.Post);
        }

        /// <summary>
        /// Create Expense Request
        /// </summary>
        /// <remarks>
        /// Creates a new expense request for the employee.
        /// </remarks>
        public Task CreateExpenseRequestAsync(int employeeId, ExpenseRequestEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/expense", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Expense Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the expense request with the specified ID.
        /// </remarks>
        public EssExpenseRequestResponseModel GetExpenseRequestById(int employeeId, int expenseRequestId)
        {
            return ApiRequest<EssExpenseRequestResponseModel>($"/ess/{employeeId}/expense/{expenseRequestId}", Method.Get);
        }

        /// <summary>
        /// Get Expense Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the expense request with the specified ID.
        /// </remarks>
        public Task<EssExpenseRequestResponseModel> GetExpenseRequestByIdAsync(int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssExpenseRequestResponseModel>($"/ess/{employeeId}/expense/{expenseRequestId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Expense Request
        /// </summary>
        /// <remarks>
        /// Updates the expense request with the specified ID.
        /// </remarks>
        public void UpdateExpenseRequest(int employeeId, int expenseRequestId, ExpenseRequestEditModel model)
        {
            ApiRequest($"/ess/{employeeId}/expense/{expenseRequestId}", model, Method.Put);
        }

        /// <summary>
        /// Update Expense Request
        /// </summary>
        /// <remarks>
        /// Updates the expense request with the specified ID.
        /// </remarks>
        public Task UpdateExpenseRequestAsync(int employeeId, int expenseRequestId, ExpenseRequestEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/expense/{expenseRequestId}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Expense Request
        /// </summary>
        /// <remarks>
        /// Deletes the expense request with the specified ID.
        /// </remarks>
        public EssExpenseRequestResponseModel DeleteExpenseRequest(int employeeId, int expenseRequestId)
        {
            return ApiRequest<EssExpenseRequestResponseModel>($"/ess/{employeeId}/expense/{expenseRequestId}", Method.Delete);
        }

        /// <summary>
        /// Delete Expense Request
        /// </summary>
        /// <remarks>
        /// Deletes the expense request with the specified ID.
        /// </remarks>
        public Task<EssExpenseRequestResponseModel> DeleteExpenseRequestAsync(int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssExpenseRequestResponseModel>($"/ess/{employeeId}/expense/{expenseRequestId}", Method.Delete, cancellationToken);
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
            ApiRequest($"/ess/{employeeId}/expense/{expenseRequestId}/attachment?fileName={request.FileName}", Method.Put);
        }

        /// <summary>
        /// Upload Attachment to Expense Request
        /// </summary>
        /// <remarks>
        /// Uploads an attachment to the expense request with the specified ID.
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task UploadAttachmentToExpenseRequestAsync(int employeeId, int expenseRequestId, UploadAttachmentToExpenseRequestQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/expense/{expenseRequestId}/attachment?fileName={request.FileName}", Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Expense Categories
        /// </summary>
        /// <remarks>
        /// Gets all the expense categories for the employee.
        /// </remarks>
        public List<ExpenseCategoryResponseModel> GetExpenseCategories(int employeeId)
        {
            return ApiRequest<List<ExpenseCategoryResponseModel>>($"/ess/{employeeId}/expense/categories", Method.Get);
        }

        /// <summary>
        /// Get Expense Categories
        /// </summary>
        /// <remarks>
        /// Gets all the expense categories for the employee.
        /// </remarks>
        public Task<List<ExpenseCategoryResponseModel>> GetExpenseCategoriesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ExpenseCategoryResponseModel>>($"/ess/{employeeId}/expense/categories", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Expense Payment Summary
        /// </summary>
        /// <remarks>
        /// Gets a summary of the employee's expense payments.
        /// </remarks>
        public List<EmployeeExpensePaymentSummaryModel> GetExpensePaymentSummary(int employeeId)
        {
            return ApiRequest<List<EmployeeExpensePaymentSummaryModel>>($"/ess/{employeeId}/expense/summary", Method.Get);
        }

        /// <summary>
        /// Get Expense Payment Summary
        /// </summary>
        /// <remarks>
        /// Gets a summary of the employee's expense payments.
        /// </remarks>
        public Task<List<EmployeeExpensePaymentSummaryModel>> GetExpensePaymentSummaryAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeExpensePaymentSummaryModel>>($"/ess/{employeeId}/expense/summary", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Tax Codes
        /// </summary>
        /// <remarks>
        /// Gets all the tax codes for the employee.
        /// </remarks>
        public List<JournalServiceTaxCode> GetTaxCodes(int employeeId)
        {
            return ApiRequest<List<JournalServiceTaxCode>>($"/ess/{employeeId}/expense/taxcodes", Method.Get);
        }

        /// <summary>
        /// Get Tax Codes
        /// </summary>
        /// <remarks>
        /// Gets all the tax codes for the employee.
        /// </remarks>
        public Task<List<JournalServiceTaxCode>> GetTaxCodesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<JournalServiceTaxCode>>($"/ess/{employeeId}/expense/taxcodes", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all leave requests for this employee, with optional filters
        /// </remarks>
        public List<EssLeaveRequestModel> ListLeaveRequests(int employeeId)
        {
            return ApiRequest<List<EssLeaveRequestModel>>($"/ess/{employeeId}/leave", Method.Get);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all leave requests for this employee, with optional filters
        /// </remarks>
        public Task<List<EssLeaveRequestModel>> ListLeaveRequestsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssLeaveRequestModel>>($"/ess/{employeeId}/leave", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all leave requests for this employee, with optional filters
        /// </remarks>
        public List<EssLeaveRequestModel> ListLeaveRequests(int employeeId, ListLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<EssLeaveRequestModel>>($"/ess/{employeeId}/leave?showOtherEmployees={request.ShowOtherEmployees}&approvedOnly={request.ApprovedOnly}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all leave requests for this employee, with optional filters
        /// </remarks>
        public Task<List<EssLeaveRequestModel>> ListLeaveRequestsAsync(int employeeId, ListLeaveRequestsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssLeaveRequestModel>>($"/ess/{employeeId}/leave?showOtherEmployees={request.ShowOtherEmployees}&approvedOnly={request.ApprovedOnly}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request for the employee.
        /// </remarks>
        public void CreateLeaveRequest(int employeeId, LeaveApplicationWithAttachmentModel leaveApplication)
        {
            ApiRequest($"/ess/{employeeId}/leave", leaveApplication, Method.Post);
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request for the employee.
        /// </remarks>
        public Task CreateLeaveRequestAsync(int employeeId, LeaveApplicationWithAttachmentModel leaveApplication, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/leave", leaveApplication, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public EssLeaveRequestModel GetLeaveRequestById(int employeeId, int leaveRequestId)
        {
            return ApiRequest<EssLeaveRequestModel>($"/ess/{employeeId}/leave/{leaveRequestId}", Method.Get);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public Task<EssLeaveRequestModel> GetLeaveRequestByIdAsync(int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssLeaveRequestModel>($"/ess/{employeeId}/leave/{leaveRequestId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public void UpdateLeaveRequest(int employeeId, int leaveRequestId, LeaveApplicationWithAttachmentModel leaveApplication)
        {
            ApiRequest($"/ess/{employeeId}/leave/{leaveRequestId}", leaveApplication, Method.Post);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public Task UpdateLeaveRequestAsync(int employeeId, int leaveRequestId, LeaveApplicationWithAttachmentModel leaveApplication, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/leave/{leaveRequestId}", leaveApplication, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public void DeleteLeaveRequest(int employeeId, int leaveRequestId)
        {
            ApiRequest($"/ess/{employeeId}/leave/{leaveRequestId}", Method.Delete);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public Task DeleteLeaveRequestAsync(int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/leave/{leaveRequestId}", Method.Delete, cancellationToken);
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
            ApiRequest($"/ess/{employeeId}/leave/{leaveRequestId}/attachment", Method.Put);
        }

        /// <summary>
        /// Upload Attachment to Leave Request
        /// </summary>
        /// <remarks>
        /// Uploads a file as a new employee document, and attaches it to the leave request with the specified ID. 
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task UploadAttachmentToLeaveRequestAsync(int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/leave/{leaveRequestId}/attachment", Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Attachment from Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the attachment on the leave request with the specified ID.
        /// </remarks>
        public void DeleteAttachmentFromLeaveRequest(int employeeId, int leaveRequestId)
        {
            ApiRequest($"/ess/{employeeId}/leave/{leaveRequestId}/attachment", Method.Delete);
        }

        /// <summary>
        /// Delete Attachment from Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the attachment on the leave request with the specified ID.
        /// </remarks>
        public Task DeleteAttachmentFromLeaveRequestAsync(int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/leave/{leaveRequestId}/attachment", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public List<LeaveBalanceModel> GetLeaveBalances(int employeeId)
        {
            return ApiRequest<List<LeaveBalanceModel>>($"/ess/{employeeId}/leave/balances", Method.Get);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveBalanceModel>>($"/ess/{employeeId}/leave/balances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public List<LeaveBalanceModel> GetLeaveBalances(int employeeId, GetLeaveBalancesQueryModel request)
        {
            return ApiRequest<List<LeaveBalanceModel>>($"/ess/{employeeId}/leave/balances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int employeeId, GetLeaveBalancesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveBalanceModel>>($"/ess/{employeeId}/leave/balances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Estimate Leave Hours
        /// </summary>
        /// <remarks>
        /// Estimates the number of hours of leave required based on date and leave category.
        /// </remarks>
        public EssLeaveEstimate EstimateLeaveHours(int employeeId, EstimateLeaveHoursQueryModel request)
        {
            return ApiRequest<EssLeaveEstimate>($"/ess/{employeeId}/leave/estimate?leaveCategoryId={request.LeaveCategoryId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Estimate Leave Hours
        /// </summary>
        /// <remarks>
        /// Estimates the number of hours of leave required based on date and leave category.
        /// </remarks>
        public Task<EssLeaveEstimate> EstimateLeaveHoursAsync(int employeeId, EstimateLeaveHoursQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssLeaveEstimate>($"/ess/{employeeId}/leave/estimate?leaveCategoryId={request.LeaveCategoryId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Leave Categories
        /// </summary>
        /// <remarks>
        /// Gets the available leave categories for the employee.
        /// </remarks>
        public List<EssLeaveCategoryModel> GetLeaveCategories(int employeeId)
        {
            return ApiRequest<List<EssLeaveCategoryModel>>($"/ess/{employeeId}/leave/leavecategories", Method.Get);
        }

        /// <summary>
        /// Get Leave Categories
        /// </summary>
        /// <remarks>
        /// Gets the available leave categories for the employee.
        /// </remarks>
        public Task<List<EssLeaveCategoryModel>> GetLeaveCategoriesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssLeaveCategoryModel>>($"/ess/{employeeId}/leave/leavecategories", Method.Get, cancellationToken);
        }

        public void MyEssLookup_Addresses(int employeeId, int suburbId)
        {
            ApiRequest($"/ess/{employeeId}/lookup/addresses/{suburbId}", Method.Get);
        }

        public Task MyEssLookup_AddressesAsync(int employeeId, int suburbId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/lookup/addresses/{suburbId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Locations
        /// </summary>
        /// <remarks>
        /// Gets all the locations for the employee.
        /// </remarks>
        public List<LocationModel> GetLocations(int employeeId)
        {
            return ApiRequest<List<LocationModel>>($"/ess/{employeeId}/lookup/location", Method.Get);
        }

        /// <summary>
        /// Get Locations
        /// </summary>
        /// <remarks>
        /// Gets all the locations for the employee.
        /// </remarks>
        public Task<List<LocationModel>> GetLocationsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/ess/{employeeId}/lookup/location", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Shift Conditions
        /// </summary>
        /// <remarks>
        /// Get all the shift conditions for the employee.
        /// </remarks>
        public List<MyEssWorkTypeModel> GetShiftConditions(int employeeId)
        {
            return ApiRequest<List<MyEssWorkTypeModel>>($"/ess/{employeeId}/lookup/shiftcondition", Method.Get);
        }

        /// <summary>
        /// Get Shift Conditions
        /// </summary>
        /// <remarks>
        /// Get all the shift conditions for the employee.
        /// </remarks>
        public Task<List<MyEssWorkTypeModel>> GetShiftConditionsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyEssWorkTypeModel>>($"/ess/{employeeId}/lookup/shiftcondition", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Suburb
        /// </summary>
        /// <remarks>
        /// Gets the suburb for the criteria passed in
        /// </remarks>
        public SuburbResult GetSuburb(int employeeId, GetSuburbQueryModel request)
        {
            return ApiRequest<SuburbResult>($"/ess/{employeeId}/lookup/suburb?suburb={request.Suburb}&state={request.State}&postCode={request.PostCode}&countryId={request.CountryId}", Method.Get);
        }

        /// <summary>
        /// Get Suburb
        /// </summary>
        /// <remarks>
        /// Gets the suburb for the criteria passed in
        /// </remarks>
        public Task<SuburbResult> GetSuburbAsync(int employeeId, GetSuburbQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SuburbResult>($"/ess/{employeeId}/lookup/suburb?suburb={request.Suburb}&state={request.State}&postCode={request.PostCode}&countryId={request.CountryId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Search Suburbs
        /// </summary>
        /// <remarks>
        /// Gets a list of suburbs that match the search term.
        /// </remarks>
        public PagedResultModel<SuburbModel> SearchSuburbs(int employeeId, SearchSuburbsQueryModel request)
        {
            return ApiRequest<PagedResultModel<SuburbModel>>($"/ess/{employeeId}/lookup/suburbs?term={request.Term}&pageNum={request.PageNum}&pageSize={request.PageSize}&countryId={request.CountryId}", Method.Get);
        }

        /// <summary>
        /// Search Suburbs
        /// </summary>
        /// <remarks>
        /// Gets a list of suburbs that match the search term.
        /// </remarks>
        public Task<PagedResultModel<SuburbModel>> SearchSuburbsAsync(int employeeId, SearchSuburbsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PagedResultModel<SuburbModel>>($"/ess/{employeeId}/lookup/suburbs?term={request.Term}&pageNum={request.PageNum}&pageSize={request.PageSize}&countryId={request.CountryId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Titles
        /// </summary>
        /// <remarks>
        /// Gets list of valid personal titles
        /// </remarks>
        public List<TitleViewModel> GetTitles(int employeeId)
        {
            return ApiRequest<List<TitleViewModel>>($"/ess/{employeeId}/lookup/title", Method.Get);
        }

        /// <summary>
        /// Get Titles
        /// </summary>
        /// <remarks>
        /// Gets list of valid personal titles
        /// </remarks>
        public Task<List<TitleViewModel>> GetTitlesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TitleViewModel>>($"/ess/{employeeId}/lookup/title", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Work Types
        /// </summary>
        /// <remarks>
        /// Gets all the work types for the employee.
        /// </remarks>
        public List<MyEssWorkTypeModel> GetWorkTypes(int employeeId)
        {
            return ApiRequest<List<MyEssWorkTypeModel>>($"/ess/{employeeId}/lookup/worktype", Method.Get);
        }

        /// <summary>
        /// Get Work Types
        /// </summary>
        /// <remarks>
        /// Gets all the work types for the employee.
        /// </remarks>
        public Task<List<MyEssWorkTypeModel>> GetWorkTypesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyEssWorkTypeModel>>($"/ess/{employeeId}/lookup/worktype", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Personal Details
        /// </summary>
        /// <remarks>
        /// Gets Personal details for the specified employee.
        /// </remarks>
        public MyEssEmployeeDetailsViewModel GetPersonalDetails(int employeeId)
        {
            return ApiRequest<MyEssEmployeeDetailsViewModel>($"/ess/{employeeId}/personaldetails", Method.Get);
        }

        /// <summary>
        /// Get Personal Details
        /// </summary>
        /// <remarks>
        /// Gets Personal details for the specified employee.
        /// </remarks>
        public Task<MyEssEmployeeDetailsViewModel> GetPersonalDetailsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssEmployeeDetailsViewModel>($"/ess/{employeeId}/personaldetails", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Personal Details
        /// </summary>
        /// <remarks>
        /// Updates the personal details for the specified employee
        /// </remarks>
        public MyEssEmployeeDetailsViewModel UpdatePersonalDetails(int employeeId, MyEssEmployeeDetailsEditModel model)
        {
            return ApiRequest<MyEssEmployeeDetailsViewModel,MyEssEmployeeDetailsEditModel>($"/ess/{employeeId}/personaldetails", model, Method.Put);
        }

        /// <summary>
        /// Update Personal Details
        /// </summary>
        /// <remarks>
        /// Updates the personal details for the specified employee
        /// </remarks>
        public Task<MyEssEmployeeDetailsViewModel> UpdatePersonalDetailsAsync(int employeeId, MyEssEmployeeDetailsEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssEmployeeDetailsViewModel,MyEssEmployeeDetailsEditModel>($"/ess/{employeeId}/personaldetails", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public void GetEmployeeProfileImage(int employeeId)
        {
            ApiRequest($"/ess/{employeeId}/profileimage", Method.Get);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public Task GetEmployeeProfileImageAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/profileimage", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public ProfileImageMetadata SetEmployeeProfileImage(int employeeId)
        {
            return ApiRequest<ProfileImageMetadata>($"/ess/{employeeId}/profileimage", Method.Post);
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<ProfileImageMetadata> SetEmployeeProfileImageAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ProfileImageMetadata>($"/ess/{employeeId}/profileimage", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public void DeleteEmployeeProfileImage(int employeeId)
        {
            ApiRequest($"/ess/{employeeId}/profileimage", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public Task DeleteEmployeeProfileImageAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/profileimage", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get public holidays
        /// </summary>
        /// <remarks>
        /// Lists relevant public holiday for an employee
        /// </remarks>
        public List<PublicHolidayModel> GetPublicHolidays(int employeeId, GetPublicHolidaysQueryModel request)
        {
            return ApiRequest<List<PublicHolidayModel>>($"/ess/{employeeId}/publicHolidays?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Get public holidays
        /// </summary>
        /// <remarks>
        /// Lists relevant public holiday for an employee
        /// </remarks>
        public Task<List<PublicHolidayModel>> GetPublicHolidaysAsync(int employeeId, GetPublicHolidaysQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PublicHolidayModel>>($"/ess/{employeeId}/publicHolidays?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Qualifications for Employee
        /// </summary>
        /// <remarks>
        /// Retrieves the qualification details for a single employee.
        /// </remarks>
        public List<EssEmployeeQualificationModel> GetQualificationsForEmployee(int employeeId)
        {
            return ApiRequest<List<EssEmployeeQualificationModel>>($"/ess/{employeeId}/qualification", Method.Get);
        }

        /// <summary>
        /// Get Qualifications for Employee
        /// </summary>
        /// <remarks>
        /// Retrieves the qualification details for a single employee.
        /// </remarks>
        public Task<List<EssEmployeeQualificationModel>> GetQualificationsForEmployeeAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssEmployeeQualificationModel>>($"/ess/{employeeId}/qualification", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Add Employee Qualification
        /// </summary>
        /// <remarks>
        /// Creates a qualification for an employee.
        /// </remarks>
        public void AddEmployeeQualification(int employeeId, EssEmployeeQualificationModel qualification)
        {
            ApiRequest($"/ess/{employeeId}/qualification", qualification, Method.Post);
        }

        /// <summary>
        /// Add Employee Qualification
        /// </summary>
        /// <remarks>
        /// Creates a qualification for an employee.
        /// </remarks>
        public Task AddEmployeeQualificationAsync(int employeeId, EssEmployeeQualificationModel qualification, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/qualification", qualification, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Upload attachment to qualification
        /// </summary>
        /// <remarks>
        /// Uploads an attachment to the qualification with the specified ID.
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public void UploadAttachmentToQualification(int employeeId, int employeeQualificationId, UploadAttachmentToQualificationQueryModel request)
        {
            ApiRequest($"/ess/{employeeId}/qualification/{employeeQualificationId}/attachment?fileName={request.FileName}", Method.Put);
        }

        /// <summary>
        /// Upload attachment to qualification
        /// </summary>
        /// <remarks>
        /// Uploads an attachment to the qualification with the specified ID.
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task UploadAttachmentToQualificationAsync(int employeeId, int employeeQualificationId, UploadAttachmentToQualificationQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/qualification/{employeeQualificationId}/attachment?fileName={request.FileName}", Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete attachment from EmployeeQualification
        /// </summary>
        /// <remarks>
        /// Deletes the attachment on the EmployeeQualification with the specified ID.
        /// </remarks>
        public void DeleteAttachmentFromEmployeequalification(int employeeId, int employeeQualificationId, int documentId)
        {
            ApiRequest($"/ess/{employeeId}/qualification/{employeeQualificationId}/attachment/{documentId}", Method.Delete);
        }

        /// <summary>
        /// Delete attachment from EmployeeQualification
        /// </summary>
        /// <remarks>
        /// Deletes the attachment on the EmployeeQualification with the specified ID.
        /// </remarks>
        public Task DeleteAttachmentFromEmployeequalificationAsync(int employeeId, int employeeQualificationId, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/qualification/{employeeQualificationId}/attachment/{documentId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Qualification Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the qualification with a specific EmployeeQualification ID.
        /// </remarks>
        public EssEmployeeQualificationModel GetQualificationDetails(int employeeId, int id)
        {
            return ApiRequest<EssEmployeeQualificationModel>($"/ess/{employeeId}/qualification/{id}", Method.Get);
        }

        /// <summary>
        /// Get Qualification Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the qualification with a specific EmployeeQualification ID.
        /// </remarks>
        public Task<EssEmployeeQualificationModel> GetQualificationDetailsAsync(int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssEmployeeQualificationModel>($"/ess/{employeeId}/qualification/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Qualification
        /// </summary>
        /// <remarks>
        /// Updates a qualification for an employee.
        /// </remarks>
        public void UpdateEmployeeQualification(int employeeId, int id, EssEmployeeQualificationModel qualification)
        {
            ApiRequest($"/ess/{employeeId}/qualification/{id}", qualification, Method.Put);
        }

        /// <summary>
        /// Update Employee Qualification
        /// </summary>
        /// <remarks>
        /// Updates a qualification for an employee.
        /// </remarks>
        public Task UpdateEmployeeQualificationAsync(int employeeId, int id, EssEmployeeQualificationModel qualification, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/qualification/{id}", qualification, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Qualification
        /// </summary>
        /// <remarks>
        /// Deletes an employee qualification. Denotes that the employee is no longer qualified for the specified qualification.
        /// </remarks>
        public void DeleteEmployeeQualification(int employeeId, int id)
        {
            ApiRequest($"/ess/{employeeId}/qualification/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Qualification
        /// </summary>
        /// <remarks>
        /// Deletes an employee qualification. Denotes that the employee is no longer qualified for the specified qualification.
        /// </remarks>
        public Task DeleteEmployeeQualificationAsync(int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/qualification/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Satisfaction Survey Results
        /// </summary>
        /// <remarks>
        /// Gets satisfaction survey results for the employee
        /// </remarks>
        public List<EssSatisfactionSurvey> GetSatisfactionSurveyResults(int employeeId)
        {
            return ApiRequest<List<EssSatisfactionSurvey>>($"/ess/{employeeId}/satisfaction", Method.Get);
        }

        /// <summary>
        /// Get Satisfaction Survey Results
        /// </summary>
        /// <remarks>
        /// Gets satisfaction survey results for the employee
        /// </remarks>
        public Task<List<EssSatisfactionSurvey>> GetSatisfactionSurveyResultsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssSatisfactionSurvey>>($"/ess/{employeeId}/satisfaction", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Satisfaction Survey Results
        /// </summary>
        /// <remarks>
        /// Gets satisfaction survey results for the employee
        /// </remarks>
        public List<EssSatisfactionSurvey> GetSatisfactionSurveyResults(int employeeId, GetSatisfactionSurveyResultsQueryModel request)
        {
            return ApiRequest<List<EssSatisfactionSurvey>>($"/ess/{employeeId}/satisfaction?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Get Satisfaction Survey Results
        /// </summary>
        /// <remarks>
        /// Gets satisfaction survey results for the employee
        /// </remarks>
        public Task<List<EssSatisfactionSurvey>> GetSatisfactionSurveyResultsAsync(int employeeId, GetSatisfactionSurveyResultsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssSatisfactionSurvey>>($"/ess/{employeeId}/satisfaction?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Submit Satisfaction Survey
        /// </summary>
        /// <remarks>
        /// Submit a satisfaction survey for this employee.
        /// </remarks>
        public EmployeeSatisfactionValue SubmitSatisfactionSurvey(int employeeId, EssSatisfactionSurvey survey)
        {
            return ApiRequest<EmployeeSatisfactionValue,EssSatisfactionSurvey>($"/ess/{employeeId}/satisfaction", survey, Method.Post);
        }

        /// <summary>
        /// Submit Satisfaction Survey
        /// </summary>
        /// <remarks>
        /// Submit a satisfaction survey for this employee.
        /// </remarks>
        public Task<EmployeeSatisfactionValue> SubmitSatisfactionSurveyAsync(int employeeId, EssSatisfactionSurvey survey, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeSatisfactionValue,EssSatisfactionSurvey>($"/ess/{employeeId}/satisfaction", survey, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets the employee's roster shifts within the date range.
        /// </remarks>
        public List<MyEssRosterShiftModel> ListRosterShifts(int employeeId, ListRosterShiftsQueryModel request)
        {
            return ApiRequest<List<MyEssRosterShiftModel>>($"/ess/{employeeId}/shift?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// List Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets the employee's roster shifts within the date range.
        /// </remarks>
        public Task<List<MyEssRosterShiftModel>> ListRosterShiftsAsync(int employeeId, ListRosterShiftsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyEssRosterShiftModel>>($"/ess/{employeeId}/shift?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Roster Shift by ID
        /// </summary>
        /// <remarks>
        /// Gets the roster shift with the specified ID (as long as it is assigned to this employee).
        /// </remarks>
        public MyEssRosterShiftModel GetRosterShiftById(int employeeId, int shiftId)
        {
            return ApiRequest<MyEssRosterShiftModel>($"/ess/{employeeId}/shift/{shiftId}", Method.Get);
        }

        /// <summary>
        /// Get Roster Shift by ID
        /// </summary>
        /// <remarks>
        /// Gets the roster shift with the specified ID (as long as it is assigned to this employee).
        /// </remarks>
        public Task<MyEssRosterShiftModel> GetRosterShiftByIdAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssRosterShiftModel>($"/ess/{employeeId}/shift/{shiftId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Accept Roster Shift
        /// </summary>
        /// <remarks>
        /// Accepts the roster shift with the specified ID.
        /// </remarks>
        public MyAcceptRosterShiftResponseModel AcceptRosterShift(int employeeId, int shiftId)
        {
            return ApiRequest<MyAcceptRosterShiftResponseModel>($"/ess/{employeeId}/shift/{shiftId}/accept", Method.Post);
        }

        /// <summary>
        /// Accept Roster Shift
        /// </summary>
        /// <remarks>
        /// Accepts the roster shift with the specified ID.
        /// </remarks>
        public Task<MyAcceptRosterShiftResponseModel> AcceptRosterShiftAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyAcceptRosterShiftResponseModel>($"/ess/{employeeId}/shift/{shiftId}/accept", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Decline Roster Shift
        /// </summary>
        /// <remarks>
        /// Declines the roster shift with the specified ID.
        /// </remarks>
        public EssRosterShiftCountModel DeclineRosterShift(int employeeId, int shiftId, EssDeclineRosterShiftModel model)
        {
            return ApiRequest<EssRosterShiftCountModel,EssDeclineRosterShiftModel>($"/ess/{employeeId}/shift/{shiftId}/decline", model, Method.Post);
        }

        /// <summary>
        /// Decline Roster Shift
        /// </summary>
        /// <remarks>
        /// Declines the roster shift with the specified ID.
        /// </remarks>
        public Task<EssRosterShiftCountModel> DeclineRosterShiftAsync(int employeeId, int shiftId, EssDeclineRosterShiftModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssRosterShiftCountModel,EssDeclineRosterShiftModel>($"/ess/{employeeId}/shift/{shiftId}/decline", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Accept Shift Swap
        /// </summary>
        /// <remarks>
        /// Accept a shift swap
        /// </remarks>
        public MyEssRosterShiftActionResponse AcceptShiftSwap(int employeeId, int shiftId)
        {
            return ApiRequest<MyEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/accept", Method.Post);
        }

        /// <summary>
        /// Accept Shift Swap
        /// </summary>
        /// <remarks>
        /// Accept a shift swap
        /// </remarks>
        public Task<MyEssRosterShiftActionResponse> AcceptShiftSwapAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/accept", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Cancel Shift Swap
        /// </summary>
        /// <remarks>
        /// Cancel a shift swap
        /// </remarks>
        public MyEssRosterShiftActionResponse CancelShiftSwap(int employeeId, int shiftId)
        {
            return ApiRequest<MyEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/cancel", Method.Post);
        }

        /// <summary>
        /// Cancel Shift Swap
        /// </summary>
        /// <remarks>
        /// Cancel a shift swap
        /// </remarks>
        public Task<MyEssRosterShiftActionResponse> CancelShiftSwapAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/cancel", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Employees Eligible For Shift Swap
        /// </summary>
        /// <remarks>
        /// List the employees that are eligible for a shift swap
        /// </remarks>
        public List<EssShiftSwapCandidate> EmployeesEligibleForShiftSwap(int employeeId, int shiftId)
        {
            return ApiRequest<List<EssShiftSwapCandidate>>($"/ess/{employeeId}/shift/{shiftId}/swap/candidates", Method.Get);
        }

        /// <summary>
        /// Employees Eligible For Shift Swap
        /// </summary>
        /// <remarks>
        /// List the employees that are eligible for a shift swap
        /// </remarks>
        public Task<List<EssShiftSwapCandidate>> EmployeesEligibleForShiftSwapAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssShiftSwapCandidate>>($"/ess/{employeeId}/shift/{shiftId}/swap/candidates", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Decline Shift Swap
        /// </summary>
        /// <remarks>
        /// Decline a shift swap
        /// </remarks>
        public MyEssRosterShiftActionResponse DeclineShiftSwap(int employeeId, int shiftId)
        {
            return ApiRequest<MyEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/decline", Method.Post);
        }

        /// <summary>
        /// Decline Shift Swap
        /// </summary>
        /// <remarks>
        /// Decline a shift swap
        /// </remarks>
        public Task<MyEssRosterShiftActionResponse> DeclineShiftSwapAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/decline", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Bulk Accept Roster Shifts
        /// </summary>
        /// <remarks>
        /// Accepts a number of roster shifts by ID.
        /// </remarks>
        public MyAcceptRosterShiftsResponseModel BulkAcceptRosterShifts(int employeeId, EssBulkAcceptRosterShiftsModel model)
        {
            return ApiRequest<MyAcceptRosterShiftsResponseModel,EssBulkAcceptRosterShiftsModel>($"/ess/{employeeId}/shift/accept", model, Method.Post);
        }

        /// <summary>
        /// Bulk Accept Roster Shifts
        /// </summary>
        /// <remarks>
        /// Accepts a number of roster shifts by ID.
        /// </remarks>
        public Task<MyAcceptRosterShiftsResponseModel> BulkAcceptRosterShiftsAsync(int employeeId, EssBulkAcceptRosterShiftsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyAcceptRosterShiftsResponseModel,EssBulkAcceptRosterShiftsModel>($"/ess/{employeeId}/shift/accept", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Bulk Decline Roster Shifts
        /// </summary>
        /// <remarks>
        /// Declines a number of roster shifts by ID.
        /// </remarks>
        public EssRosterShiftCountModel BulkDeclineRosterShifts(int employeeId, EssBulkDeclineRosterShiftsModel model)
        {
            return ApiRequest<EssRosterShiftCountModel,EssBulkDeclineRosterShiftsModel>($"/ess/{employeeId}/shift/decline", model, Method.Post);
        }

        /// <summary>
        /// Bulk Decline Roster Shifts
        /// </summary>
        /// <remarks>
        /// Declines a number of roster shifts by ID.
        /// </remarks>
        public Task<EssRosterShiftCountModel> BulkDeclineRosterShiftsAsync(int employeeId, EssBulkDeclineRosterShiftsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssRosterShiftCountModel,EssBulkDeclineRosterShiftsModel>($"/ess/{employeeId}/shift/decline", model, Method.Post, cancellationToken);
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
        public MyRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int employeeId, FindMatchingClockOffRosterShiftQueryModel request)
        {
            return ApiRequest<MyRosterShiftMatchingResultModel>($"/ess/{employeeId}/shift/matchingclockoff?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
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
        public Task<MyRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int employeeId, FindMatchingClockOffRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyRosterShiftMatchingResultModel>($"/ess/{employeeId}/shift/matchingclockoff?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Find Matching Clock On Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock on at this time
        /// given ESS settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// However, if allowNotEnded is set to true, the ongoing shift will be returned.
        /// </remarks>
        public MyRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int employeeId, FindMatchingClockOnRosterShiftQueryModel request)
        {
            return ApiRequest<MyRosterShiftMatchingResultModel>($"/ess/{employeeId}/shift/matchingclockon?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}&allowNotEnded={request.AllowNotEnded}", Method.Get);
        }

        /// <summary>
        /// Find Matching Clock On Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock on at this time
        /// given ESS settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// However, if allowNotEnded is set to true, the ongoing shift will be returned.
        /// </remarks>
        public Task<MyRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int employeeId, FindMatchingClockOnRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyRosterShiftMatchingResultModel>($"/ess/{employeeId}/shift/matchingclockon?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}&allowNotEnded={request.AllowNotEnded}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public List<MyEssRosterShiftModel> FindNearbyRosterShifts(int employeeId, FindNearbyRosterShiftsQueryModel request)
        {
            return ApiRequest<List<MyEssRosterShiftModel>>($"/ess/{employeeId}/shift/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public Task<List<MyEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int employeeId, FindNearbyRosterShiftsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyEssRosterShiftModel>>($"/ess/{employeeId}/shift/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Bulk Accept Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Accepts a number of roster shift swaps by shift ID.
        /// </remarks>
        public MyEssBulkRosterShiftActionResponse BulkAcceptRosterShiftSwaps(int employeeId, EssBulkRosterShiftSwapModel model)
        {
            return ApiRequest<MyEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/accept", model, Method.Post);
        }

        /// <summary>
        /// Bulk Accept Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Accepts a number of roster shift swaps by shift ID.
        /// </remarks>
        public Task<MyEssBulkRosterShiftActionResponse> BulkAcceptRosterShiftSwapsAsync(int employeeId, EssBulkRosterShiftSwapModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/accept", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Bulk Cancel Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Cancels a number of roster shift swaps by shift ID.
        /// </remarks>
        public MyEssBulkRosterShiftActionResponse BulkCancelRosterShiftSwaps(int employeeId, EssBulkRosterShiftSwapModel model)
        {
            return ApiRequest<MyEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/cancel", model, Method.Post);
        }

        /// <summary>
        /// Bulk Cancel Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Cancels a number of roster shift swaps by shift ID.
        /// </remarks>
        public Task<MyEssBulkRosterShiftActionResponse> BulkCancelRosterShiftSwapsAsync(int employeeId, EssBulkRosterShiftSwapModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/cancel", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Bulk Decline Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Declines a number of roster shift swaps by shift ID.
        /// </remarks>
        public MyEssBulkRosterShiftActionResponse BulkDeclineRosterShiftSwaps(int employeeId, EssBulkRosterShiftSwapModel model)
        {
            return ApiRequest<MyEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/decline", model, Method.Post);
        }

        /// <summary>
        /// Bulk Decline Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Declines a number of roster shift swaps by shift ID.
        /// </remarks>
        public Task<MyEssBulkRosterShiftActionResponse> BulkDeclineRosterShiftSwapsAsync(int employeeId, EssBulkRosterShiftSwapModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/decline", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Propose Shift Swap
        /// </summary>
        /// <remarks>
        /// Propose a shift swap
        /// </remarks>
        public MyEssRosterShiftActionResponse ProposeShiftSwap(int employeeId, SwapShiftModel model)
        {
            return ApiRequest<MyEssRosterShiftActionResponse,SwapShiftModel>($"/ess/{employeeId}/shift/swap/propose", model, Method.Post);
        }

        /// <summary>
        /// Propose Shift Swap
        /// </summary>
        /// <remarks>
        /// Propose a shift swap
        /// </remarks>
        public Task<MyEssRosterShiftActionResponse> ProposeShiftSwapAsync(int employeeId, SwapShiftModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssRosterShiftActionResponse,SwapShiftModel>($"/ess/{employeeId}/shift/swap/propose", model, Method.Post, cancellationToken);
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
            ApiRequest($"/ess/{employeeId}/timeandattendance/clockoff", request, Method.Post);
        }

        /// <summary>
        /// Clock Out Employee
        /// </summary>
        /// <remarks>
        /// Clocks out the employee from their existing shift.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public Task ClockOutEmployeeAsync(int employeeId, ClockOffModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/clockoff", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Clock In Employee
        /// </summary>
        /// <remarks>
        /// Clocks in an employee for a new shift.
        /// </remarks>
        public KioskEmployeeModel ClockInEmployee(int employeeId, MyClockOnModel model)
        {
            return ApiRequest<KioskEmployeeModel,MyClockOnModel>($"/ess/{employeeId}/timeandattendance/clockon", model, Method.Post);
        }

        /// <summary>
        /// Clock In Employee
        /// </summary>
        /// <remarks>
        /// Clocks in an employee for a new shift.
        /// </remarks>
        public Task<KioskEmployeeModel> ClockInEmployeeAsync(int employeeId, MyClockOnModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,MyClockOnModel>($"/ess/{employeeId}/timeandattendance/clockon", model, Method.Post, cancellationToken);
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
            ApiRequest($"/ess/{employeeId}/timeandattendance/discard", request, Method.Post);
        }

        /// <summary>
        /// Discard current shift
        /// </summary>
        /// <remarks>
        /// Discards the current shift for an employee.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public Task DiscardCurrentShiftAsync(int employeeId, ClockOffModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/discard", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// End Break
        /// </summary>
        /// <remarks>
        /// Ends the employee's current break.
        /// </remarks>
        public void EndBreak(int employeeId, EndBreakModel request)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/endbreak", request, Method.Post);
        }

        /// <summary>
        /// End Break
        /// </summary>
        /// <remarks>
        /// Ends the employee's current break.
        /// </remarks>
        public Task EndBreakAsync(int employeeId, EndBreakModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/endbreak", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Lookup Data
        /// </summary>
        /// <remarks>
        /// Gets relevant lookup data for the employee in relation to a kiosk.
        /// </remarks>
        public MyTimeAndAttendanceLookupDataModel GetLookupData(int employeeId)
        {
            return ApiRequest<MyTimeAndAttendanceLookupDataModel>($"/ess/{employeeId}/timeandattendance/lookupdata", Method.Get);
        }

        /// <summary>
        /// Get Lookup Data
        /// </summary>
        /// <remarks>
        /// Gets relevant lookup data for the employee in relation to a kiosk.
        /// </remarks>
        public Task<MyTimeAndAttendanceLookupDataModel> GetLookupDataAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyTimeAndAttendanceLookupDataModel>($"/ess/{employeeId}/timeandattendance/lookupdata", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public void GetShiftNotes(int employeeId, int shiftId)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes", Method.Get);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public Task GetShiftNotesAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public void GetShiftNotes(int employeeId, int shiftId, GetShiftNotesQueryModel request)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes?employeeId={request.EmployeeId}&isAdminInitiated={request.IsAdminInitiated}&type={request.Type}&visibility={request.Visibility}", Method.Get);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public Task GetShiftNotesAsync(int employeeId, int shiftId, GetShiftNotesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes?employeeId={request.EmployeeId}&isAdminInitiated={request.IsAdminInitiated}&type={request.Type}&visibility={request.Visibility}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Add Note to Shift
        /// </summary>
        /// <remarks>
        /// Adds a note to an existing shift.
        /// </remarks>
        public void AddNoteToShift(int employeeId, int shiftId, AddNoteModel model)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes", model, Method.Post);
        }

        /// <summary>
        /// Add Note to Shift
        /// </summary>
        /// <remarks>
        /// Adds a note to an existing shift.
        /// </remarks>
        public Task AddNoteToShiftAsync(int employeeId, int shiftId, AddNoteModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Mark Shift Notes Read
        /// </summary>
        /// <remarks>
        /// Marks some shift notes as either read or unread.
        /// </remarks>
        public void MarkShiftNotesRead(int employeeId, MarkNotesReadViewModel model, string shiftId)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes/read-state", model, Method.Post);
        }

        /// <summary>
        /// Mark Shift Notes Read
        /// </summary>
        /// <remarks>
        /// Marks some shift notes as either read or unread.
        /// </remarks>
        public Task MarkShiftNotesReadAsync(int employeeId, MarkNotesReadViewModel model, string shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes/read-state", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Shifts
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public List<MyTimeAndAttendanceShiftModel> Shifts(int employeeId, GetShiftsModel model)
        {
            return ApiRequest<List<MyTimeAndAttendanceShiftModel>,GetShiftsModel>($"/ess/{employeeId}/timeandattendance/shifts", model, Method.Post);
        }

        /// <summary>
        /// Shifts
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public Task<List<MyTimeAndAttendanceShiftModel>> ShiftsAsync(int employeeId, GetShiftsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyTimeAndAttendanceShiftModel>,GetShiftsModel>($"/ess/{employeeId}/timeandattendance/shifts", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Start Break
        /// </summary>
        /// <remarks>
        /// Starts a break for the employee who is clocked on for a shift.
        /// </remarks>
        public void StartBreak(int employeeId, StartBreakModel request)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/startbreak", request, Method.Post);
        }

        /// <summary>
        /// Start Break
        /// </summary>
        /// <remarks>
        /// Starts a break for the employee who is clocked on for a shift.
        /// </remarks>
        public Task StartBreakAsync(int employeeId, StartBreakModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/startbreak", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Timesheets
        /// </summary>
        /// <remarks>
        /// Lists timesheets for the employee.
        /// </remarks>
        public List<EssTimesheetModel> ListTimesheets(int employeeId, ListTimesheetsQueryModel request)
        {
            return ApiRequest<List<EssTimesheetModel>>($"/ess/{employeeId}/timesheet?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// List Timesheets
        /// </summary>
        /// <remarks>
        /// Lists timesheets for the employee.
        /// </remarks>
        public Task<List<EssTimesheetModel>> ListTimesheetsAsync(int employeeId, ListTimesheetsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssTimesheetModel>>($"/ess/{employeeId}/timesheet?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
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
            ApiRequest($"/ess/{employeeId}/timesheet", timesheet, Method.Post);
        }

        /// <summary>
        /// Submit or Update Timesheet
        /// </summary>
        /// <remarks>
        /// If no ID is specified, create a new timesheet for the employee. 
        /// Otherwise, update the timesheet with the specified ID.
        /// </remarks>
        public Task SubmitOrUpdateTimesheetAsync(int employeeId, EssTimesheetModel timesheet, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timesheet", timesheet, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Edit Timesheet
        /// </summary>
        /// <remarks>
        /// Edits the timesheet with the specified ID.
        /// </remarks>
        public void EditTimesheet(int employeeId, int timesheetId, EssTimesheetModel timesheet)
        {
            ApiRequest($"/ess/{employeeId}/timesheet/{timesheetId}", timesheet, Method.Post);
        }

        /// <summary>
        /// Edit Timesheet
        /// </summary>
        /// <remarks>
        /// Edits the timesheet with the specified ID.
        /// </remarks>
        public Task EditTimesheetAsync(int employeeId, int timesheetId, EssTimesheetModel timesheet, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timesheet/{timesheetId}", timesheet, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Timesheet
        /// </summary>
        /// <remarks>
        /// Deletes the timesheet with the specified ID.
        /// </remarks>
        public void DeleteTimesheet(int employeeId, int timesheetId)
        {
            ApiRequest($"/ess/{employeeId}/timesheet/{timesheetId}", Method.Delete);
        }

        /// <summary>
        /// Delete Timesheet
        /// </summary>
        /// <remarks>
        /// Deletes the timesheet with the specified ID.
        /// </remarks>
        public Task DeleteTimesheetAsync(int employeeId, int timesheetId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timesheet/{timesheetId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Timesheet Creation Data
        /// </summary>
        /// <remarks>
        /// Lists relevant timesheet, leave and shift data for an employee, to allow for intuitive timesheet creation.
        /// </remarks>
        public MyEssTimesheetDataModel GetTimesheetCreationData(int employeeId, GetTimesheetCreationDataQueryModel request)
        {
            return ApiRequest<MyEssTimesheetDataModel>($"/ess/{employeeId}/timesheet/data?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Get Timesheet Creation Data
        /// </summary>
        /// <remarks>
        /// Lists relevant timesheet, leave and shift data for an employee, to allow for intuitive timesheet creation.
        /// </remarks>
        public Task<MyEssTimesheetDataModel> GetTimesheetCreationDataAsync(int employeeId, GetTimesheetCreationDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEssTimesheetDataModel>($"/ess/{employeeId}/timesheet/data?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this employee, with optional filters.
        /// </remarks>
        public List<EssUnavailabilityModel> ListUnavailabilities(int employeeId)
        {
            return ApiRequest<List<EssUnavailabilityModel>>($"/ess/{employeeId}/unavailability", Method.Get);
        }

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this employee, with optional filters.
        /// </remarks>
        public Task<List<EssUnavailabilityModel>> ListUnavailabilitiesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssUnavailabilityModel>>($"/ess/{employeeId}/unavailability", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this employee, with optional filters.
        /// </remarks>
        public List<EssUnavailabilityModel> ListUnavailabilities(int employeeId, ListUnavailabilitiesQueryModel request)
        {
            return ApiRequest<List<EssUnavailabilityModel>>($"/ess/{employeeId}/unavailability?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this employee, with optional filters.
        /// </remarks>
        public Task<List<EssUnavailabilityModel>> ListUnavailabilitiesAsync(int employeeId, ListUnavailabilitiesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssUnavailabilityModel>>($"/ess/{employeeId}/unavailability?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Creates a new unavailability for the employee.
        /// </remarks>
        public EssUnavailabilityModel CreateUnavailability(int employeeId, UnavailabilityEditModel unavailability)
        {
            return ApiRequest<EssUnavailabilityModel,UnavailabilityEditModel>($"/ess/{employeeId}/unavailability", unavailability, Method.Post);
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Creates a new unavailability for the employee.
        /// </remarks>
        public Task<EssUnavailabilityModel> CreateUnavailabilityAsync(int employeeId, UnavailabilityEditModel unavailability, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssUnavailabilityModel,UnavailabilityEditModel>($"/ess/{employeeId}/unavailability", unavailability, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get unavailability by ID
        /// </summary>
        /// <remarks>
        /// Gets the unavailability with the specified ID (so long as the unavailability is from the specified employee).
        /// </remarks>
        public EssUnavailabilityModel GetUnavailabilityById(int employeeId, int unavailabilityId)
        {
            return ApiRequest<EssUnavailabilityModel>($"/ess/{employeeId}/unavailability/{unavailabilityId}", Method.Get);
        }

        /// <summary>
        /// Get unavailability by ID
        /// </summary>
        /// <remarks>
        /// Gets the unavailability with the specified ID (so long as the unavailability is from the specified employee).
        /// </remarks>
        public Task<EssUnavailabilityModel> GetUnavailabilityByIdAsync(int employeeId, int unavailabilityId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssUnavailabilityModel>($"/ess/{employeeId}/unavailability/{unavailabilityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public void UpdateUnavailability(int employeeId, int unavailabilityId, UnavailabilityEditModel unavailability)
        {
            ApiRequest($"/ess/{employeeId}/unavailability/{unavailabilityId}", unavailability, Method.Put);
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public Task UpdateUnavailabilityAsync(int employeeId, int unavailabilityId, UnavailabilityEditModel unavailability, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/unavailability/{unavailabilityId}", unavailability, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public void DeleteUnavailability(int employeeId, int unavailabilityId)
        {
            ApiRequest($"/ess/{employeeId}/unavailability/{unavailabilityId}", Method.Delete);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public Task DeleteUnavailabilityAsync(int employeeId, int unavailabilityId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/unavailability/{unavailabilityId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Register Device Token
        /// </summary>
        /// <remarks>
        /// Registers a device token.
        /// </remarks>
        public void RegisterDeviceToken(DeviceTokenModel model)
        {
            ApiRequest($"/ess/devicetoken/register", model, Method.Post);
        }

        /// <summary>
        /// Register Device Token
        /// </summary>
        /// <remarks>
        /// Registers a device token.
        /// </remarks>
        public Task RegisterDeviceTokenAsync(DeviceTokenModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/devicetoken/register", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Unregister Device Token
        /// </summary>
        /// <remarks>
        /// Unregisters a device token.
        /// </remarks>
        public void UnregisterDeviceToken(DeviceTokenModel model)
        {
            ApiRequest($"/ess/devicetoken/unregister", model, Method.Post);
        }

        /// <summary>
        /// Unregister Device Token
        /// </summary>
        /// <remarks>
        /// Unregisters a device token.
        /// </remarks>
        public Task UnregisterDeviceTokenAsync(DeviceTokenModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/devicetoken/unregister", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employees
        /// </summary>
        /// <remarks>
        /// Returns all the employees the user can access.
        /// </remarks>
        public List<AvailableEmployeeModel> GetEmployees()
        {
            return ApiRequest<List<AvailableEmployeeModel>>($"/ess/security/employees", Method.Get);
        }

        /// <summary>
        /// Get Employees
        /// </summary>
        /// <remarks>
        /// Returns all the employees the user can access.
        /// </remarks>
        public Task<List<AvailableEmployeeModel>> GetEmployeesAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AvailableEmployeeModel>>($"/ess/security/employees", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Recover Forgotten Password
        /// </summary>
        /// <remarks>
        /// Sends an email so that the user can reset their password
        /// </remarks>
        public void RecoverForgottenPassword(RecoverPasswordModel model)
        {
            ApiRequest($"/ess/security/forgottenpassword", model, Method.Post);
        }

        /// <summary>
        /// Recover Forgotten Password
        /// </summary>
        /// <remarks>
        /// Sends an email so that the user can reset their password
        /// </remarks>
        public Task RecoverForgottenPasswordAsync(RecoverPasswordModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/security/forgottenpassword", model, Method.Post, cancellationToken);
        }
    }
}
