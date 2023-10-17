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
using KeyPayV2.Nz.Models.Manager;

namespace KeyPayV2.Nz.Functions
{
    public interface IManagerFunction
    {
        void DownloadDocument(int businessId, int employeeId, int documentId);
        Task DownloadDocumentAsync(int businessId, int employeeId, int documentId, CancellationToken cancellationToken = default);
        ManagerExpenseRequestModel CreateExpenseRequest(int businessId, int employeeId, ExpenseRequestEditModel expenseRequest);
        Task<ManagerExpenseRequestModel> CreateExpenseRequestAsync(int businessId, int employeeId, ExpenseRequestEditModel expenseRequest, CancellationToken cancellationToken = default);
        ManagerExpenseRequestModel GetExpenseRequest(int businessId, int employeeId, int expenseRequestId);
        Task<ManagerExpenseRequestModel> GetExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default);
        ManagerExpenseRequestModel EditExpenseRequest(int businessId, int employeeId, int expenseRequestId, ExpenseRequestEditModel expenseRequest);
        Task<ManagerExpenseRequestModel> EditExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, ExpenseRequestEditModel expenseRequest, CancellationToken cancellationToken = default);
        void DeleteExpenseRequest(int businessId, int employeeId, int expenseRequestId);
        Task DeleteExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default);
        ManagerExpenseRequestModel ApproveExpenseRequest(int businessId, int employeeId, int expenseRequestId);
        Task<ManagerExpenseRequestModel> ApproveExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default);
        AttachmentModel UploadAttachmentToExpenseRequest(int businessId, int employeeId, FileUploadModel file, int expenseRequestId, UploadAttachmentToExpenseRequestQueryModel request);
        Task<AttachmentModel> UploadAttachmentToExpenseRequestAsync(int businessId, int employeeId, FileUploadModel file, int expenseRequestId, UploadAttachmentToExpenseRequestQueryModel request, CancellationToken cancellationToken = default);
        ManagerExpenseRequestModel DeclineExpenseRequest(int businessId, int employeeId, int expenseRequestId, DeclineReason reason);
        Task<ManagerExpenseRequestModel> DeclineExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, DeclineReason reason, CancellationToken cancellationToken = default);
        ExpenseReferenceData GetExpensesReferenceData(int businessId, int employeeId);
        Task<ExpenseReferenceData> GetExpensesReferenceDataAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        ManagerLeaveRequestModel CreateLeaveRequest(int businessId, int employeeId, ManagerLeaveApplicationModel leaveApplication);
        Task<ManagerLeaveRequestModel> CreateLeaveRequestAsync(int businessId, int employeeId, ManagerLeaveApplicationModel leaveApplication, CancellationToken cancellationToken = default);
        ManagerLeaveRequestModel GetLeaveRequestById(int businessId, int employeeId, int leaveRequestId);
        Task<ManagerLeaveRequestModel> GetLeaveRequestByIdAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        ManagerLeaveRequestModel UpdateLeaveRequest(int businessId, int employeeId, int leaveRequestId, ManagerLeaveApplicationModel leaveApplication);
        Task<ManagerLeaveRequestModel> UpdateLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, ManagerLeaveApplicationModel leaveApplication, CancellationToken cancellationToken = default);
        ManagerLeaveRequestModel DeleteLeaveRequest(int businessId, int employeeId, int leaveRequestId);
        Task<ManagerLeaveRequestModel> DeleteLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        ManagerLeaveRequestModel ApproveLeaveRequest(int businessId, int employeeId, int leaveRequestId);
        Task<ManagerLeaveRequestModel> ApproveLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        DocumentFile GetLeaveRequestAttachment(int businessId, int employeeId, int leaveRequestId);
        Task<DocumentFile> GetLeaveRequestAttachmentAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        ManagerLeaveRequestModel DeclineLeaveRequest(int businessId, int employeeId, int leaveRequestId, DeclineReason declineReason);
        Task<ManagerLeaveRequestModel> DeclineLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, DeclineReason declineReason, CancellationToken cancellationToken = default);
        List<ManagerLeaveRequestModel> OverlappingLeaveRequests(int businessId, int employeeId, int leaveRequestId);
        Task<List<ManagerLeaveRequestModel>> OverlappingLeaveRequestsAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default);
        List<LeaveBalanceModel> GetLeaveBalances(int businessId, int employeeId);
        Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<LeaveBalanceModel> GetLeaveBalances(int businessId, int employeeId, GetLeaveBalancesQueryModel request);
        Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int businessId, int employeeId, GetLeaveBalancesQueryModel request, CancellationToken cancellationToken = default);
        List<ManagerLeaveCategoryModel> ListLeaveCategories(int businessId, int employeeId);
        Task<List<ManagerLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        ManagerLeaveEstimate EstimateLeaveHours(int businessId, int employeeId, EstimateLeaveHoursQueryModel request);
        Task<ManagerLeaveEstimate> EstimateLeaveHoursAsync(int businessId, int employeeId, EstimateLeaveHoursQueryModel request, CancellationToken cancellationToken = default);
        ManagerUnavailabilityModel CreateUnavailability(int businessId, int employeeId, UnavailabilityEditModel model);
        Task<ManagerUnavailabilityModel> CreateUnavailabilityAsync(int businessId, int employeeId, UnavailabilityEditModel model, CancellationToken cancellationToken = default);
        ManagerUnavailabilityModel UpdateUnavailability(int businessId, int employeeId, int unavailabilityId, UnavailabilityEditModel model);
        Task<ManagerUnavailabilityModel> UpdateUnavailabilityAsync(int businessId, int employeeId, int unavailabilityId, UnavailabilityEditModel model, CancellationToken cancellationToken = default);
        void DeleteUnavailability(int businessId, int employeeId, int unavailabilityId);
        Task DeleteUnavailabilityAsync(int businessId, int employeeId, int unavailabilityId, CancellationToken cancellationToken = default);
        ManagerTimesheetLineModel GetTimesheet(int businessId, int employeeId, int timesheetId);
        Task<ManagerTimesheetLineModel> GetTimesheetAsync(int businessId, int employeeId, int timesheetId, CancellationToken cancellationToken = default);
        ManagerTimesheetLineModel EditTimesheet(int businessId, int employeeId, int timesheetId, ManagerTimesheetSubmitModel timesheet);
        Task<ManagerTimesheetLineModel> EditTimesheetAsync(int businessId, int employeeId, int timesheetId, ManagerTimesheetSubmitModel timesheet, CancellationToken cancellationToken = default);
        void DeleteTimesheet(int businessId, int employeeId, int timesheetId);
        Task DeleteTimesheetAsync(int businessId, int employeeId, int timesheetId, CancellationToken cancellationToken = default);
        ManagerTimesheetLineModel ApproveTimesheet(int businessId, int employeeId, int timesheetId);
        Task<ManagerTimesheetLineModel> ApproveTimesheetAsync(int businessId, int employeeId, int timesheetId, CancellationToken cancellationToken = default);
        ManagerTimesheetLineModel RejectTimesheet(int businessId, int employeeId, int timesheetId);
        Task<ManagerTimesheetLineModel> RejectTimesheetAsync(int businessId, int employeeId, int timesheetId, CancellationToken cancellationToken = default);
        NzTimesheetReferenceData GetTimesheetReferenceData(int businessId, int employeeId);
        Task<NzTimesheetReferenceData> GetTimesheetReferenceDataAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        ManagerDashboardModel GetDashboard(int businessId);
        Task<ManagerDashboardModel> GetDashboardAsync(int businessId, CancellationToken cancellationToken = default);
        void GetEmployeeProfileImage(int businessId, int employeeId);
        Task GetEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        ProfileImageMetadata SetEmployeeProfileImage(int businessId, int employeeId);
        Task<ProfileImageMetadata> SetEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        void DeleteEmployeeProfileImage(int businessId, int employeeId);
        Task DeleteEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<LocationModel> ListEmployeeLocations(int businessId, int employeeId, ODataQuery oDataQuery = null);
        Task<List<LocationModel>> ListEmployeeLocationsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void InitiateEmployeeSelfSetup(int businessId, NzInitiateEmployeeOnboardingApiModel model);
        Task InitiateEmployeeSelfSetupAsync(int businessId, NzInitiateEmployeeOnboardingApiModel model, CancellationToken cancellationToken = default);
        List<EmployeeDetailsModel> GetListOfEmployees(int businessId);
        Task<List<EmployeeDetailsModel>> GetListOfEmployeesAsync(int businessId, CancellationToken cancellationToken = default);
        PagedResultModel<ManagerExpenseRequestModel> GetBusinessExpenseRequests(int businessId);
        Task<PagedResultModel<ManagerExpenseRequestModel>> GetBusinessExpenseRequestsAsync(int businessId, CancellationToken cancellationToken = default);
        PagedResultModel<ManagerExpenseRequestModel> GetBusinessExpenseRequests(int businessId, GetBusinessExpenseRequestsQueryModel request);
        Task<PagedResultModel<ManagerExpenseRequestModel>> GetBusinessExpenseRequestsAsync(int businessId, GetBusinessExpenseRequestsQueryModel request, CancellationToken cancellationToken = default);
        List<ExpenseCategoryResponseModel> ListExpenseCategories(int businessId);
        Task<List<ExpenseCategoryResponseModel>> ListExpenseCategoriesAsync(int businessId, CancellationToken cancellationToken = default);
        List<ManagerExpenseEmployeeModel> ListExpenseRequestEmployees(int businessId);
        Task<List<ManagerExpenseEmployeeModel>> ListExpenseRequestEmployeesAsync(int businessId, CancellationToken cancellationToken = default);
        List<LocationModel> ListExpenseRequestLocations(int businessId);
        Task<List<LocationModel>> ListExpenseRequestLocationsAsync(int businessId, CancellationToken cancellationToken = default);
        List<ExpenseTaxCode> ListTaxCodes(int businessId);
        Task<List<ExpenseTaxCode>> ListTaxCodesAsync(int businessId, CancellationToken cancellationToken = default);
        List<TimeAndAttendanceKioskModel> GetKiosks(int businessId);
        Task<List<TimeAndAttendanceKioskModel>> GetKiosksAsync(int businessId, CancellationToken cancellationToken = default);
        TimeAndAttendanceKioskModel GetKioskById(int businessId, int id);
        Task<TimeAndAttendanceKioskModel> GetKioskByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        KioskEmployeeModel ChangePin(int businessId, int kioskId, ChangeKioskPinModel model);
        Task<KioskEmployeeModel> ChangePinAsync(int businessId, int kioskId, ChangeKioskPinModel model, CancellationToken cancellationToken = default);
        BasicKioskEmployeeModel CheckEmployee(int businessId, int kioskId, CheckKioskEmployeeIdModel model);
        Task<BasicKioskEmployeeModel> CheckEmployeeAsync(int businessId, int kioskId, CheckKioskEmployeeIdModel model, CancellationToken cancellationToken = default);
        KioskEmployeeModel VerifyKioskPin(int businessId, int kioskId, CheckKioskPinModel model);
        Task<KioskEmployeeModel> VerifyKioskPinAsync(int businessId, int kioskId, CheckKioskPinModel model, CancellationToken cancellationToken = default);
        KioskEmployeeModel ClockOutEmployee(int businessId, int kioskId, ClockOffModel request);
        Task<KioskEmployeeModel> ClockOutEmployeeAsync(int businessId, int kioskId, ClockOffModel request, CancellationToken cancellationToken = default);
        KioskEmployeeModel ClockInEmployee(int businessId, int kioskId, ClockOnModel request);
        Task<KioskEmployeeModel> ClockInEmployeeAsync(int businessId, int kioskId, ClockOnModel request, CancellationToken cancellationToken = default);
        KioskEmployeeModel DiscardCurrentShift(int businessId, int kioskId, ClockOffModel request);
        Task<KioskEmployeeModel> DiscardCurrentShiftAsync(int businessId, int kioskId, ClockOffModel request, CancellationToken cancellationToken = default);
        void SendPinResetEmail(int businessId, PinResetModel model, string kioskId);
        Task SendPinResetEmailAsync(int businessId, PinResetModel model, string kioskId, CancellationToken cancellationToken = default);
        KioskEmployeeModel EndBreak(int businessId, int kioskId, EndBreakModel request);
        Task<KioskEmployeeModel> EndBreakAsync(int businessId, int kioskId, EndBreakModel request, CancellationToken cancellationToken = default);
        NzTimeAndAttendanceLookupDataModel GetEmployeeLookupData(int businessId, int employeeId, int kioskId);
        Task<NzTimeAndAttendanceLookupDataModel> GetEmployeeLookupDataAsync(int businessId, int employeeId, int kioskId, CancellationToken cancellationToken = default);
        List<ShiftNoteViewModel> GetShiftNotes(int businessId, int kioskId, int shiftId);
        Task<List<ShiftNoteViewModel>> GetShiftNotesAsync(int businessId, int kioskId, int shiftId, CancellationToken cancellationToken = default);
        List<ShiftNoteViewModel> GetShiftNotes(int businessId, int kioskId, int shiftId, GetShiftNotesQueryModel request);
        Task<List<ShiftNoteViewModel>> GetShiftNotesAsync(int businessId, int kioskId, int shiftId, GetShiftNotesQueryModel request, CancellationToken cancellationToken = default);
        ShiftNoteViewModel AddNoteToShift(int businessId, int kioskId, int shiftId, AddNoteModel model);
        Task<ShiftNoteViewModel> AddNoteToShiftAsync(int businessId, int kioskId, int shiftId, AddNoteModel model, CancellationToken cancellationToken = default);
        void DeleteNoteFromShift(int businessId, int kioskId, int shiftId, int noteId);
        Task DeleteNoteFromShiftAsync(int businessId, int kioskId, int shiftId, int noteId, CancellationToken cancellationToken = default);
        void MarkShiftNotesRead(int businessId, MarkNotesReadViewModel model, string kioskId, string shiftId);
        Task MarkShiftNotesReadAsync(int businessId, MarkNotesReadViewModel model, string kioskId, string shiftId, CancellationToken cancellationToken = default);
        void SendPinResetSms(int businessId, PinResetModel model, string kioskId);
        Task SendPinResetSmsAsync(int businessId, PinResetModel model, string kioskId, CancellationToken cancellationToken = default);
        List<BasicKioskEmployeeModel> ListKioskStaff(int businessId, int kioskId);
        Task<List<BasicKioskEmployeeModel>> ListKioskStaffAsync(int businessId, int kioskId, CancellationToken cancellationToken = default);
        List<BasicKioskEmployeeModel> ListKioskStaff(int businessId, int kioskId, ListKioskStaffQueryModel request);
        Task<List<BasicKioskEmployeeModel>> ListKioskStaffAsync(int businessId, int kioskId, ListKioskStaffQueryModel request, CancellationToken cancellationToken = default);
        void AddAnEmployee(int businessId, int kioskId, KioskCreateEmployeeModel model);
        Task AddAnEmployeeAsync(int businessId, int kioskId, KioskCreateEmployeeModel model, CancellationToken cancellationToken = default);
        KioskEmployeeModel StartBreak(int businessId, int kioskId, StartBreakModel request);
        Task<KioskEmployeeModel> StartBreakAsync(int businessId, int kioskId, StartBreakModel request, CancellationToken cancellationToken = default);
        List<NzTimeAndAttendanceShiftModel> Shifts(int businessId, GetShiftsModel model);
        Task<List<NzTimeAndAttendanceShiftModel>> ShiftsAsync(int businessId, GetShiftsModel model, CancellationToken cancellationToken = default);
        List<TimesheetLineModel> GetBusinessTimesheets(int businessId, ODataQuery oDataQuery = null);
        Task<List<TimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        void CreateKioskTimesheetLine(int businessId, IndividualTimesheetLineModel request);
        Task CreateKioskTimesheetLineAsync(int businessId, IndividualTimesheetLineModel request, CancellationToken cancellationToken = default);
        void UpdateKioskTimesheetLine(int businessId, int timesheetLineId, IndividualTimesheetLineModel request);
        Task UpdateKioskTimesheetLineAsync(int businessId, int timesheetLineId, IndividualTimesheetLineModel request, CancellationToken cancellationToken = default);
        void UpdateCommentsInATimesheet(int businessId, TimesheetLineCommentsModel request, string timesheetLineId);
        Task UpdateCommentsInATimesheetAsync(int businessId, TimesheetLineCommentsModel request, string timesheetLineId, CancellationToken cancellationToken = default);
        List<ManagerLeaveRequestModel> ListLeaveRequests(int businessId);
        Task<List<ManagerLeaveRequestModel>> ListLeaveRequestsAsync(int businessId, CancellationToken cancellationToken = default);
        List<ManagerLeaveRequestModel> ListLeaveRequests(int businessId, ListLeaveRequestsQueryModel request);
        Task<List<ManagerLeaveRequestModel>> ListLeaveRequestsAsync(int businessId, ListLeaveRequestsQueryModel request, CancellationToken cancellationToken = default);
        List<ManagerLeaveCategoryModel> ListLeaveCategories(int businessId);
        Task<List<ManagerLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, CancellationToken cancellationToken = default);
        List<ManagerLeaveEmployeeModel> ListLeaveEmployees(int businessId);
        Task<List<ManagerLeaveEmployeeModel>> ListLeaveEmployeesAsync(int businessId, CancellationToken cancellationToken = default);
        List<LocationModel> ListLeaveLocations(int businessId);
        Task<List<LocationModel>> ListLeaveLocationsAsync(int businessId, CancellationToken cancellationToken = default);
        List<ManagerLeaveRequestModel> OverlappingLeaveRequests(int businessId, OverlappingLeaveRequestsQueryModel request);
        Task<List<ManagerLeaveRequestModel>> OverlappingLeaveRequestsAsync(int businessId, OverlappingLeaveRequestsQueryModel request, CancellationToken cancellationToken = default);
        List<LocationModel> ListEmployeeLocations(int businessId, ODataQuery oDataQuery = null);
        Task<List<LocationModel>> ListEmployeeLocationsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        List<LocationModel> GetListOfLocations(int businessId);
        Task<List<LocationModel>> GetListOfLocationsAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId);
        Task<List<NzRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId, GetRosterShiftsQueryModel request);
        Task<List<NzRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, GetRosterShiftsQueryModel request, CancellationToken cancellationToken = default);
        void CreateRosterShift(int businessId, RosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request);
        Task CreateRosterShiftAsync(int businessId, RosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        NzRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request);
        Task<NzRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        NzRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request);
        Task<NzRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        List<NzEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request);
        Task<List<NzEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request, CancellationToken cancellationToken = default);
        ManagerRosterShiftModel GetRosterShiftById(int businessId, int rosterShiftId);
        Task<ManagerRosterShiftModel> GetRosterShiftByIdAsync(int businessId, int rosterShiftId, CancellationToken cancellationToken = default);
        ManagerRosterShiftModel GetRosterShiftById(int businessId, int rosterShiftId, GetRosterShiftByIdQueryModel request);
        Task<ManagerRosterShiftModel> GetRosterShiftByIdAsync(int businessId, int rosterShiftId, GetRosterShiftByIdQueryModel request, CancellationToken cancellationToken = default);
        void UpdateRosterShift(int businessId, RosterShiftEditModel shiftModel, int rosterShiftId, UpdateRosterShiftQueryModel request);
        Task UpdateRosterShiftAsync(int businessId, RosterShiftEditModel shiftModel, int rosterShiftId, UpdateRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        void StubShiftTimesheets(int businessId, int rosterShiftId, StubRosterShiftViewModel model);
        Task StubShiftTimesheetsAsync(int businessId, int rosterShiftId, StubRosterShiftViewModel model, CancellationToken cancellationToken = default);
        List<ManagerRosterEmployeeModel> ListRosterEmployees(int businessId);
        Task<List<ManagerRosterEmployeeModel>> ListRosterEmployeesAsync(int businessId, CancellationToken cancellationToken = default);
        List<LocationModel> ListRosterLocations(int businessId);
        Task<List<LocationModel>> ListRosterLocationsAsync(int businessId, CancellationToken cancellationToken = default);
        NzManagerRosterDataModel ManageRosterData(int businessId);
        Task<NzManagerRosterDataModel> ManageRosterDataAsync(int businessId, CancellationToken cancellationToken = default);
        NzManagerRosterDataModel ManageRosterData(int businessId, ManageRosterDataQueryModel request);
        Task<NzManagerRosterDataModel> ManageRosterDataAsync(int businessId, ManageRosterDataQueryModel request, CancellationToken cancellationToken = default);
        List<ManagerRosterEmployeeModel> ListManagerRosterEmployees(int businessId);
        Task<List<ManagerRosterEmployeeModel>> ListManagerRosterEmployeesAsync(int businessId, CancellationToken cancellationToken = default);
        List<RosterShiftRole> GetTheListOfRolesAvailable(int businessId);
        Task<List<RosterShiftRole>> GetTheListOfRolesAvailableAsync(int businessId, CancellationToken cancellationToken = default);
        TimesheetRoundingRulesModel GetRoundingRules(int businessId);
        Task<TimesheetRoundingRulesModel> GetRoundingRulesAsync(int businessId, CancellationToken cancellationToken = default);
        void SetRoundingRules(int businessId, TimesheetRoundingRulesModel roundingRules);
        Task SetRoundingRulesAsync(int businessId, TimesheetRoundingRulesModel roundingRules, CancellationToken cancellationToken = default);
        PagedResultModel<ManagerTimesheetLineModel> GetBusinessTimesheets(int businessId);
        Task<PagedResultModel<ManagerTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, CancellationToken cancellationToken = default);
        PagedResultModel<ManagerTimesheetLineModel> GetBusinessTimesheets(int businessId, GetBusinessTimesheetsQueryModel request);
        Task<PagedResultModel<ManagerTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, GetBusinessTimesheetsQueryModel request, CancellationToken cancellationToken = default);
        void CreateTimesheetLine(int businessId, NzIndividualTimesheetLineModel request);
        Task CreateTimesheetLineAsync(int businessId, NzIndividualTimesheetLineModel request, CancellationToken cancellationToken = default);
        void UpdateTimesheetLine(int businessId, int timesheetLineId, NzIndividualTimesheetLineModel request);
        Task UpdateTimesheetLineAsync(int businessId, int timesheetLineId, NzIndividualTimesheetLineModel request, CancellationToken cancellationToken = default);
        List<ManagerEmployeeGroup> ListEmployeeGroups(int businessId);
        Task<List<ManagerEmployeeGroup>> ListEmployeeGroupsAsync(int businessId, CancellationToken cancellationToken = default);
        List<ManagerTimesheetEmployeeModel> ListTimesheetEmployees(int businessId);
        Task<List<ManagerTimesheetEmployeeModel>> ListTimesheetEmployeesAsync(int businessId, CancellationToken cancellationToken = default);
        List<LocationModel> ListTimesheetLocations(int businessId);
        Task<List<LocationModel>> ListTimesheetLocationsAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzAvailableBusinessModel> ListBusinesses();
        Task<List<NzAvailableBusinessModel>> ListBusinessesAsync(CancellationToken cancellationToken = default);
    }
    public class ManagerFunction : BaseFunction, IManagerFunction
    {
        public ManagerFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Download Document
        /// </summary>
        /// <remarks>
        /// Downloads the document with the specified ID so long as it is visible to the manager.
        /// </remarks>
        public void DownloadDocument(int businessId, int employeeId, int documentId)
        {
            ApiRequest($"/business/{businessId}/manager/{employeeId}/document/download/{documentId}", Method.Get);
        }

        /// <summary>
        /// Download Document
        /// </summary>
        /// <remarks>
        /// Downloads the document with the specified ID so long as it is visible to the manager.
        /// </remarks>
        public Task DownloadDocumentAsync(int businessId, int employeeId, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/{employeeId}/document/download/{documentId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create expense request
        /// </summary>
        /// <remarks>
        /// Creates an expense request for the employee
        /// </remarks>
        public ManagerExpenseRequestModel CreateExpenseRequest(int businessId, int employeeId, ExpenseRequestEditModel expenseRequest)
        {
            return ApiRequest<ManagerExpenseRequestModel,ExpenseRequestEditModel>($"/business/{businessId}/manager/{employeeId}/expense", expenseRequest, Method.Post);
        }

        /// <summary>
        /// Create expense request
        /// </summary>
        /// <remarks>
        /// Creates an expense request for the employee
        /// </remarks>
        public Task<ManagerExpenseRequestModel> CreateExpenseRequestAsync(int businessId, int employeeId, ExpenseRequestEditModel expenseRequest, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerExpenseRequestModel,ExpenseRequestEditModel>($"/business/{businessId}/manager/{employeeId}/expense", expenseRequest, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get expense request
        /// </summary>
        /// <remarks>
        /// Gets the expense request  with the specified ID.
        /// </remarks>
        public ManagerExpenseRequestModel GetExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            return ApiRequest<ManagerExpenseRequestModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", Method.Get);
        }

        /// <summary>
        /// Get expense request
        /// </summary>
        /// <remarks>
        /// Gets the expense request  with the specified ID.
        /// </remarks>
        public Task<ManagerExpenseRequestModel> GetExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerExpenseRequestModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Edit Expense Request
        /// </summary>
        /// <remarks>
        /// Edits the Expense Request with the specified ID.
        /// </remarks>
        public ManagerExpenseRequestModel EditExpenseRequest(int businessId, int employeeId, int expenseRequestId, ExpenseRequestEditModel expenseRequest)
        {
            return ApiRequest<ManagerExpenseRequestModel,ExpenseRequestEditModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", expenseRequest, Method.Put);
        }

        /// <summary>
        /// Edit Expense Request
        /// </summary>
        /// <remarks>
        /// Edits the Expense Request with the specified ID.
        /// </remarks>
        public Task<ManagerExpenseRequestModel> EditExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, ExpenseRequestEditModel expenseRequest, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerExpenseRequestModel,ExpenseRequestEditModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", expenseRequest, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Expense Request
        /// </summary>
        /// <remarks>
        /// Deletes the Expense Request with the specified ID.
        /// </remarks>
        public void DeleteExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            ApiRequest($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", Method.Delete);
        }

        /// <summary>
        /// Delete Expense Request
        /// </summary>
        /// <remarks>
        /// Deletes the Expense Request with the specified ID.
        /// </remarks>
        public Task DeleteExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Approve Expense Request
        /// </summary>
        /// <remarks>
        /// Approves the Expense Request with the specified ID.
        /// </remarks>
        public ManagerExpenseRequestModel ApproveExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            return ApiRequest<ManagerExpenseRequestModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/approve", Method.Post);
        }

        /// <summary>
        /// Approve Expense Request
        /// </summary>
        /// <remarks>
        /// Approves the Expense Request with the specified ID.
        /// </remarks>
        public Task<ManagerExpenseRequestModel> ApproveExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerExpenseRequestModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/approve", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Upload Attachment to Expense Request
        /// </summary>
        /// <remarks>
        /// Uploads an attachment to the expense request with the specified ID.
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public AttachmentModel UploadAttachmentToExpenseRequest(int businessId, int employeeId, FileUploadModel file, int expenseRequestId, UploadAttachmentToExpenseRequestQueryModel request)
        {
            return ApiFileRequest<AttachmentModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/attachment?fileName={request.FileName}", file, Method.Put);
        }

        /// <summary>
        /// Upload Attachment to Expense Request
        /// </summary>
        /// <remarks>
        /// Uploads an attachment to the expense request with the specified ID.
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<AttachmentModel> UploadAttachmentToExpenseRequestAsync(int businessId, int employeeId, FileUploadModel file, int expenseRequestId, UploadAttachmentToExpenseRequestQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiFileRequestAsync<AttachmentModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/attachment?fileName={request.FileName}", file, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Decline Expense Request
        /// </summary>
        /// <remarks>
        /// Declines the Expense Request with the specified ID.
        /// </remarks>
        public ManagerExpenseRequestModel DeclineExpenseRequest(int businessId, int employeeId, int expenseRequestId, DeclineReason reason)
        {
            return ApiRequest<ManagerExpenseRequestModel,DeclineReason>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/decline", reason, Method.Post);
        }

        /// <summary>
        /// Decline Expense Request
        /// </summary>
        /// <remarks>
        /// Declines the Expense Request with the specified ID.
        /// </remarks>
        public Task<ManagerExpenseRequestModel> DeclineExpenseRequestAsync(int businessId, int employeeId, int expenseRequestId, DeclineReason reason, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerExpenseRequestModel,DeclineReason>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/decline", reason, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get expenses reference data
        /// </summary>
        /// <remarks>
        /// Gets the Tax Codes, Expense Categories, and Locations for this Employee.
        /// </remarks>
        public ExpenseReferenceData GetExpensesReferenceData(int businessId, int employeeId)
        {
            return ApiRequest<ExpenseReferenceData>($"/business/{businessId}/manager/{employeeId}/expense/reference", Method.Get);
        }

        /// <summary>
        /// Get expenses reference data
        /// </summary>
        /// <remarks>
        /// Gets the Tax Codes, Expense Categories, and Locations for this Employee.
        /// </remarks>
        public Task<ExpenseReferenceData> GetExpensesReferenceDataAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ExpenseReferenceData>($"/business/{businessId}/manager/{employeeId}/expense/reference", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request.
        /// </remarks>
        public ManagerLeaveRequestModel CreateLeaveRequest(int businessId, int employeeId, ManagerLeaveApplicationModel leaveApplication)
        {
            return ApiRequest<ManagerLeaveRequestModel,ManagerLeaveApplicationModel>($"/business/{businessId}/manager/{employeeId}/leaverequest", leaveApplication, Method.Post);
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request.
        /// </remarks>
        public Task<ManagerLeaveRequestModel> CreateLeaveRequestAsync(int businessId, int employeeId, ManagerLeaveApplicationModel leaveApplication, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveRequestModel,ManagerLeaveApplicationModel>($"/business/{businessId}/manager/{employeeId}/leaverequest", leaveApplication, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel GetLeaveRequestById(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", Method.Get);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public Task<ManagerLeaveRequestModel> GetLeaveRequestByIdAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel UpdateLeaveRequest(int businessId, int employeeId, int leaveRequestId, ManagerLeaveApplicationModel leaveApplication)
        {
            return ApiRequest<ManagerLeaveRequestModel,ManagerLeaveApplicationModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", leaveApplication, Method.Post);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public Task<ManagerLeaveRequestModel> UpdateLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, ManagerLeaveApplicationModel leaveApplication, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveRequestModel,ManagerLeaveApplicationModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", leaveApplication, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel DeleteLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", Method.Delete);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public Task<ManagerLeaveRequestModel> DeleteLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Approve Leave Request
        /// </summary>
        /// <remarks>
        /// Approves the leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel ApproveLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.Post);
        }

        /// <summary>
        /// Approve Leave Request
        /// </summary>
        /// <remarks>
        /// Approves the leave request with the specified ID.
        /// </remarks>
        public Task<ManagerLeaveRequestModel> ApproveLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Leave Request Attachment
        /// </summary>
        /// <remarks>
        /// Gets the file for an employee leave request by ID.
        /// </remarks>
        public DocumentFile GetLeaveRequestAttachment(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<DocumentFile>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/attachment", Method.Get);
        }

        /// <summary>
        /// Get Leave Request Attachment
        /// </summary>
        /// <remarks>
        /// Gets the file for an employee leave request by ID.
        /// </remarks>
        public Task<DocumentFile> GetLeaveRequestAttachmentAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DocumentFile>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/attachment", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Decline Leave Request
        /// </summary>
        /// <remarks>
        /// Declines the leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel DeclineLeaveRequest(int businessId, int employeeId, int leaveRequestId, DeclineReason declineReason)
        {
            return ApiRequest<ManagerLeaveRequestModel,DeclineReason>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/decline", declineReason, Method.Post);
        }

        /// <summary>
        /// Decline Leave Request
        /// </summary>
        /// <remarks>
        /// Declines the leave request with the specified ID.
        /// </remarks>
        public Task<ManagerLeaveRequestModel> DeclineLeaveRequestAsync(int businessId, int employeeId, int leaveRequestId, DeclineReason declineReason, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveRequestModel,DeclineReason>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/decline", declineReason, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Overlapping Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the overlapping leave requests for the given date range.
        /// </remarks>
        public List<ManagerLeaveRequestModel> OverlappingLeaveRequests(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/overlapping", Method.Get);
        }

        /// <summary>
        /// Overlapping Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the overlapping leave requests for the given date range.
        /// </remarks>
        public Task<List<ManagerLeaveRequestModel>> OverlappingLeaveRequestsAsync(int businessId, int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/overlapping", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public List<LeaveBalanceModel> GetLeaveBalances(int businessId, int employeeId)
        {
            return ApiRequest<List<LeaveBalanceModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/balances", Method.Get);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveBalanceModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/balances", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public List<LeaveBalanceModel> GetLeaveBalances(int businessId, int employeeId, GetLeaveBalancesQueryModel request)
        {
            return ApiRequest<List<LeaveBalanceModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/balances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int businessId, int employeeId, GetLeaveBalancesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveBalanceModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/balances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for this employee.
        /// </remarks>
        public List<ManagerLeaveCategoryModel> ListLeaveCategories(int businessId, int employeeId)
        {
            return ApiRequest<List<ManagerLeaveCategoryModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/categories", Method.Get);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for this employee.
        /// </remarks>
        public Task<List<ManagerLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerLeaveCategoryModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/categories", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Estimate Leave Hours
        /// </summary>
        /// <remarks>
        /// Estimates the number of hours of leave required based on date and leave category.
        /// </remarks>
        public ManagerLeaveEstimate EstimateLeaveHours(int businessId, int employeeId, EstimateLeaveHoursQueryModel request)
        {
            return ApiRequest<ManagerLeaveEstimate>($"/business/{businessId}/manager/{employeeId}/leaverequest/estimate?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&leaveCategoryId={request.LeaveCategoryId}", Method.Get);
        }

        /// <summary>
        /// Estimate Leave Hours
        /// </summary>
        /// <remarks>
        /// Estimates the number of hours of leave required based on date and leave category.
        /// </remarks>
        public Task<ManagerLeaveEstimate> EstimateLeaveHoursAsync(int businessId, int employeeId, EstimateLeaveHoursQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerLeaveEstimate>($"/business/{businessId}/manager/{employeeId}/leaverequest/estimate?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&leaveCategoryId={request.LeaveCategoryId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Create an unavailability for an employee.
        /// </remarks>
        public ManagerUnavailabilityModel CreateUnavailability(int businessId, int employeeId, UnavailabilityEditModel model)
        {
            return ApiRequest<ManagerUnavailabilityModel,UnavailabilityEditModel>($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability", model, Method.Post);
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Create an unavailability for an employee.
        /// </remarks>
        public Task<ManagerUnavailabilityModel> CreateUnavailabilityAsync(int businessId, int employeeId, UnavailabilityEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerUnavailabilityModel,UnavailabilityEditModel>($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public ManagerUnavailabilityModel UpdateUnavailability(int businessId, int employeeId, int unavailabilityId, UnavailabilityEditModel model)
        {
            return ApiRequest<ManagerUnavailabilityModel,UnavailabilityEditModel>($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability/{unavailabilityId}", model, Method.Put);
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public Task<ManagerUnavailabilityModel> UpdateUnavailabilityAsync(int businessId, int employeeId, int unavailabilityId, UnavailabilityEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerUnavailabilityModel,UnavailabilityEditModel>($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability/{unavailabilityId}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public void DeleteUnavailability(int businessId, int employeeId, int unavailabilityId)
        {
            ApiRequest($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability/{unavailabilityId}", Method.Delete);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public Task DeleteUnavailabilityAsync(int businessId, int employeeId, int unavailabilityId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability/{unavailabilityId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get timesheet
        /// </summary>
        /// <remarks>
        /// Gets the timesheet with the specified ID.
        /// </remarks>
        public ManagerTimesheetLineModel GetTimesheet(int businessId, int employeeId, int timesheetId)
        {
            return ApiRequest<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", Method.Get);
        }

        /// <summary>
        /// Get timesheet
        /// </summary>
        /// <remarks>
        /// Gets the timesheet with the specified ID.
        /// </remarks>
        public Task<ManagerTimesheetLineModel> GetTimesheetAsync(int businessId, int employeeId, int timesheetId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Edit Timesheet
        /// </summary>
        /// <remarks>
        /// Edits the timesheet with the specified ID.
        /// classificationId field left unspecified or null will not be changed.
        /// To update classificationId field provide the new value, to specifically clear a value use "0".
        /// </remarks>
        public ManagerTimesheetLineModel EditTimesheet(int businessId, int employeeId, int timesheetId, ManagerTimesheetSubmitModel timesheet)
        {
            return ApiRequest<ManagerTimesheetLineModel,ManagerTimesheetSubmitModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", timesheet, Method.Post);
        }

        /// <summary>
        /// Edit Timesheet
        /// </summary>
        /// <remarks>
        /// Edits the timesheet with the specified ID.
        /// classificationId field left unspecified or null will not be changed.
        /// To update classificationId field provide the new value, to specifically clear a value use "0".
        /// </remarks>
        public Task<ManagerTimesheetLineModel> EditTimesheetAsync(int businessId, int employeeId, int timesheetId, ManagerTimesheetSubmitModel timesheet, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerTimesheetLineModel,ManagerTimesheetSubmitModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", timesheet, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Timesheet
        /// </summary>
        /// <remarks>
        /// Deletes the timesheet with the specified ID.
        /// </remarks>
        public void DeleteTimesheet(int businessId, int employeeId, int timesheetId)
        {
            ApiRequest($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", Method.Delete);
        }

        /// <summary>
        /// Delete Timesheet
        /// </summary>
        /// <remarks>
        /// Deletes the timesheet with the specified ID.
        /// </remarks>
        public Task DeleteTimesheetAsync(int businessId, int employeeId, int timesheetId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Approve Timesheet
        /// </summary>
        /// <remarks>
        /// Approves the timesheet with the specified ID.
        /// </remarks>
        public ManagerTimesheetLineModel ApproveTimesheet(int businessId, int employeeId, int timesheetId)
        {
            return ApiRequest<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}/approve", Method.Post);
        }

        /// <summary>
        /// Approve Timesheet
        /// </summary>
        /// <remarks>
        /// Approves the timesheet with the specified ID.
        /// </remarks>
        public Task<ManagerTimesheetLineModel> ApproveTimesheetAsync(int businessId, int employeeId, int timesheetId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}/approve", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Reject Timesheet
        /// </summary>
        /// <remarks>
        /// Rejects the timesheet with the specified ID.
        /// </remarks>
        public ManagerTimesheetLineModel RejectTimesheet(int businessId, int employeeId, int timesheetId)
        {
            return ApiRequest<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}/reject", Method.Post);
        }

        /// <summary>
        /// Reject Timesheet
        /// </summary>
        /// <remarks>
        /// Rejects the timesheet with the specified ID.
        /// </remarks>
        public Task<ManagerTimesheetLineModel> RejectTimesheetAsync(int businessId, int employeeId, int timesheetId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}/reject", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get timesheet reference data
        /// </summary>
        /// <remarks>
        /// Gets the Work Types, Shift Conditions, Locations, and Reporting Dimension Values (if enabled) for this Employee.
        /// </remarks>
        public NzTimesheetReferenceData GetTimesheetReferenceData(int businessId, int employeeId)
        {
            return ApiRequest<NzTimesheetReferenceData>($"/business/{businessId}/manager/{employeeId}/timesheet/reference", Method.Get);
        }

        /// <summary>
        /// Get timesheet reference data
        /// </summary>
        /// <remarks>
        /// Gets the Work Types, Shift Conditions, Locations, and Reporting Dimension Values (if enabled) for this Employee.
        /// </remarks>
        public Task<NzTimesheetReferenceData> GetTimesheetReferenceDataAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzTimesheetReferenceData>($"/business/{businessId}/manager/{employeeId}/timesheet/reference", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Dashboard
        /// </summary>
        /// <remarks>
        /// Gets a set of useful information that the manager may need.
        /// </remarks>
        public ManagerDashboardModel GetDashboard(int businessId)
        {
            return ApiRequest<ManagerDashboardModel>($"/business/{businessId}/manager/dashboard", Method.Get);
        }

        /// <summary>
        /// Get Dashboard
        /// </summary>
        /// <remarks>
        /// Gets a set of useful information that the manager may need.
        /// </remarks>
        public Task<ManagerDashboardModel> GetDashboardAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerDashboardModel>($"/business/{businessId}/manager/dashboard", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public void GetEmployeeProfileImage(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/manager/employee/{employeeId}/image", Method.Get);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public Task GetEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/employee/{employeeId}/image", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public ProfileImageMetadata SetEmployeeProfileImage(int businessId, int employeeId)
        {
            return ApiRequest<ProfileImageMetadata>($"/business/{businessId}/manager/employee/{employeeId}/image", Method.Post);
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<ProfileImageMetadata> SetEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ProfileImageMetadata>($"/business/{businessId}/manager/employee/{employeeId}/image", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public void DeleteEmployeeProfileImage(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/manager/employee/{employeeId}/image", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public Task DeleteEmployeeProfileImageAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/employee/{employeeId}/image", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Employee Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for an employee that are available to the manager.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<LocationModel> ListEmployeeLocations(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/employee/{employeeId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employee Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for an employee that are available to the manager.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<LocationModel>> ListEmployeeLocationsAsync(int businessId, int employeeId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/employee/{employeeId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Initiate Employee Self Setup
        /// </summary>
        /// <remarks>
        /// Initiate the Self Setup process for an Employee.
        /// If the employee has an existing employee record, the id should be specified. If the Email and Mobile provided
        /// are not the same as those on the employee record, they will be updated.
        /// If the employee does not yet have an employee record do not specify an id, one will be created with the
        /// details provided.
        /// </remarks>
        public void InitiateEmployeeSelfSetup(int businessId, NzInitiateEmployeeOnboardingApiModel model)
        {
            ApiRequest($"/business/{businessId}/manager/employeeonboarding/initiateselfservice", model, Method.Post);
        }

        /// <summary>
        /// Initiate Employee Self Setup
        /// </summary>
        /// <remarks>
        /// Initiate the Self Setup process for an Employee.
        /// If the employee has an existing employee record, the id should be specified. If the Email and Mobile provided
        /// are not the same as those on the employee record, they will be updated.
        /// If the employee does not yet have an employee record do not specify an id, one will be created with the
        /// details provided.
        /// </remarks>
        public Task InitiateEmployeeSelfSetupAsync(int businessId, NzInitiateEmployeeOnboardingApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/employeeonboarding/initiateselfservice", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get List of Employees
        /// </summary>
        /// <remarks>
        /// Lists all employees the manager can access.
        /// </remarks>
        public List<EmployeeDetailsModel> GetListOfEmployees(int businessId)
        {
            return ApiRequest<List<EmployeeDetailsModel>>($"/business/{businessId}/manager/employees", Method.Get);
        }

        /// <summary>
        /// Get List of Employees
        /// </summary>
        /// <remarks>
        /// Lists all employees the manager can access.
        /// </remarks>
        public Task<List<EmployeeDetailsModel>> GetListOfEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDetailsModel>>($"/business/{businessId}/manager/employees", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Expense Requests
        /// </summary>
        /// <remarks>
        /// Retrieves expense request for the specified business which manager can access
        /// </remarks>
        public PagedResultModel<ManagerExpenseRequestModel> GetBusinessExpenseRequests(int businessId)
        {
            return ApiRequest<PagedResultModel<ManagerExpenseRequestModel>>($"/business/{businessId}/manager/expense", Method.Get);
        }

        /// <summary>
        /// Get Business Expense Requests
        /// </summary>
        /// <remarks>
        /// Retrieves expense request for the specified business which manager can access
        /// </remarks>
        public Task<PagedResultModel<ManagerExpenseRequestModel>> GetBusinessExpenseRequestsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PagedResultModel<ManagerExpenseRequestModel>>($"/business/{businessId}/manager/expense", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Expense Requests
        /// </summary>
        /// <remarks>
        /// Retrieves expense request for the specified business which manager can access
        /// </remarks>
        public PagedResultModel<ManagerExpenseRequestModel> GetBusinessExpenseRequests(int businessId, GetBusinessExpenseRequestsQueryModel request)
        {
            return ApiRequest<PagedResultModel<ManagerExpenseRequestModel>>($"/business/{businessId}/manager/expense?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employeeId={request.EmployeeId}&locationId={request.LocationId}&expenseCategoryId={request.ExpenseCategoryId}&groupBy={request.GroupBy}&currentPage={request.CurrentPage}&pageSize={request.PageSize}", Method.Get);
        }

        /// <summary>
        /// Get Business Expense Requests
        /// </summary>
        /// <remarks>
        /// Retrieves expense request for the specified business which manager can access
        /// </remarks>
        public Task<PagedResultModel<ManagerExpenseRequestModel>> GetBusinessExpenseRequestsAsync(int businessId, GetBusinessExpenseRequestsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PagedResultModel<ManagerExpenseRequestModel>>($"/business/{businessId}/manager/expense?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employeeId={request.EmployeeId}&locationId={request.LocationId}&expenseCategoryId={request.ExpenseCategoryId}&groupBy={request.GroupBy}&currentPage={request.CurrentPage}&pageSize={request.PageSize}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Expense Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the expense categories
        /// </remarks>
        public List<ExpenseCategoryResponseModel> ListExpenseCategories(int businessId)
        {
            return ApiRequest<List<ExpenseCategoryResponseModel>>($"/business/{businessId}/manager/expense/categories", Method.Get);
        }

        /// <summary>
        /// List Expense Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the expense categories
        /// </remarks>
        public Task<List<ExpenseCategoryResponseModel>> ListExpenseCategoriesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ExpenseCategoryResponseModel>>($"/business/{businessId}/manager/expense/categories", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Expense Request Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve expense request permissions on.
        /// </remarks>
        public List<ManagerExpenseEmployeeModel> ListExpenseRequestEmployees(int businessId)
        {
            return ApiRequest<List<ManagerExpenseEmployeeModel>>($"/business/{businessId}/manager/expense/employees", Method.Get);
        }

        /// <summary>
        /// List Expense Request Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve expense request permissions on.
        /// </remarks>
        public Task<List<ManagerExpenseEmployeeModel>> ListExpenseRequestEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerExpenseEmployeeModel>>($"/business/{businessId}/manager/expense/employees", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Expense Request Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has approve expense request permissions on.
        /// </remarks>
        public List<LocationModel> ListExpenseRequestLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/expense/locations", Method.Get);
        }

        /// <summary>
        /// List Expense Request Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has approve expense request permissions on.
        /// </remarks>
        public Task<List<LocationModel>> ListExpenseRequestLocationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/expense/locations", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Tax Codes
        /// </summary>
        /// <remarks>
        /// Lists all of the tax codes
        /// </remarks>
        public List<ExpenseTaxCode> ListTaxCodes(int businessId)
        {
            return ApiRequest<List<ExpenseTaxCode>>($"/business/{businessId}/manager/expense/taxcodes", Method.Get);
        }

        /// <summary>
        /// List Tax Codes
        /// </summary>
        /// <remarks>
        /// Lists all of the tax codes
        /// </remarks>
        public Task<List<ExpenseTaxCode>> ListTaxCodesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ExpenseTaxCode>>($"/business/{businessId}/manager/expense/taxcodes", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Kiosks
        /// </summary>
        /// <remarks>
        /// Returns all kiosks that the user has access to for this business
        /// </remarks>
        public List<TimeAndAttendanceKioskModel> GetKiosks(int businessId)
        {
            return ApiRequest<List<TimeAndAttendanceKioskModel>>($"/business/{businessId}/manager/kiosk", Method.Get);
        }

        /// <summary>
        /// Get Kiosks
        /// </summary>
        /// <remarks>
        /// Returns all kiosks that the user has access to for this business
        /// </remarks>
        public Task<List<TimeAndAttendanceKioskModel>> GetKiosksAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TimeAndAttendanceKioskModel>>($"/business/{businessId}/manager/kiosk", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Kiosk by ID
        /// </summary>
        /// <remarks>
        /// Gets the kiosk with the specified ID.
        /// </remarks>
        public TimeAndAttendanceKioskModel GetKioskById(int businessId, int id)
        {
            return ApiRequest<TimeAndAttendanceKioskModel>($"/business/{businessId}/manager/kiosk/{id}", Method.Get);
        }

        /// <summary>
        /// Get Kiosk by ID
        /// </summary>
        /// <remarks>
        /// Gets the kiosk with the specified ID.
        /// </remarks>
        public Task<TimeAndAttendanceKioskModel> GetKioskByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TimeAndAttendanceKioskModel>($"/business/{businessId}/manager/kiosk/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Change PIN
        /// </summary>
        /// <remarks>
        /// Changes the kiosk PIN for an employee, given their old PIN.
        /// </remarks>
        public KioskEmployeeModel ChangePin(int businessId, int kioskId, ChangeKioskPinModel model)
        {
            return ApiRequest<KioskEmployeeModel,ChangeKioskPinModel>($"/business/{businessId}/manager/kiosk/{kioskId}/changepin", model, Method.Post);
        }

        /// <summary>
        /// Change PIN
        /// </summary>
        /// <remarks>
        /// Changes the kiosk PIN for an employee, given their old PIN.
        /// </remarks>
        public Task<KioskEmployeeModel> ChangePinAsync(int businessId, int kioskId, ChangeKioskPinModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,ChangeKioskPinModel>($"/business/{businessId}/manager/kiosk/{kioskId}/changepin", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Check Employee
        /// </summary>
        /// <remarks>
        /// If the specified employee has kiosk access, returns details about the employee and their current shift.
        /// </remarks>
        public BasicKioskEmployeeModel CheckEmployee(int businessId, int kioskId, CheckKioskEmployeeIdModel model)
        {
            return ApiRequest<BasicKioskEmployeeModel,CheckKioskEmployeeIdModel>($"/business/{businessId}/manager/kiosk/{kioskId}/checkid", model, Method.Post);
        }

        /// <summary>
        /// Check Employee
        /// </summary>
        /// <remarks>
        /// If the specified employee has kiosk access, returns details about the employee and their current shift.
        /// </remarks>
        public Task<BasicKioskEmployeeModel> CheckEmployeeAsync(int businessId, int kioskId, CheckKioskEmployeeIdModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<BasicKioskEmployeeModel,CheckKioskEmployeeIdModel>($"/business/{businessId}/manager/kiosk/{kioskId}/checkid", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Verify Kiosk PIN
        /// </summary>
        /// <remarks>
        /// Verifies the employee's kiosk PIN. Returns error code 400 if the PIN is incorrect.
        /// </remarks>
        public KioskEmployeeModel VerifyKioskPin(int businessId, int kioskId, CheckKioskPinModel model)
        {
            return ApiRequest<KioskEmployeeModel,CheckKioskPinModel>($"/business/{businessId}/manager/kiosk/{kioskId}/checkpin", model, Method.Post);
        }

        /// <summary>
        /// Verify Kiosk PIN
        /// </summary>
        /// <remarks>
        /// Verifies the employee's kiosk PIN. Returns error code 400 if the PIN is incorrect.
        /// </remarks>
        public Task<KioskEmployeeModel> VerifyKioskPinAsync(int businessId, int kioskId, CheckKioskPinModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,CheckKioskPinModel>($"/business/{businessId}/manager/kiosk/{kioskId}/checkpin", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Clock Out Employee
        /// </summary>
        /// <remarks>
        /// Clocks out an employee from their existing shift.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public KioskEmployeeModel ClockOutEmployee(int businessId, int kioskId, ClockOffModel request)
        {
            return ApiRequest<KioskEmployeeModel,ClockOffModel>($"/business/{businessId}/manager/kiosk/{kioskId}/clockoff", request, Method.Post);
        }

        /// <summary>
        /// Clock Out Employee
        /// </summary>
        /// <remarks>
        /// Clocks out an employee from their existing shift.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public Task<KioskEmployeeModel> ClockOutEmployeeAsync(int businessId, int kioskId, ClockOffModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,ClockOffModel>($"/business/{businessId}/manager/kiosk/{kioskId}/clockoff", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Clock In Employee
        /// </summary>
        /// <remarks>
        /// Clocks in an employee for a new shift.
        /// </remarks>
        public KioskEmployeeModel ClockInEmployee(int businessId, int kioskId, ClockOnModel request)
        {
            return ApiRequest<KioskEmployeeModel,ClockOnModel>($"/business/{businessId}/manager/kiosk/{kioskId}/clockon", request, Method.Post);
        }

        /// <summary>
        /// Clock In Employee
        /// </summary>
        /// <remarks>
        /// Clocks in an employee for a new shift.
        /// </remarks>
        public Task<KioskEmployeeModel> ClockInEmployeeAsync(int businessId, int kioskId, ClockOnModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,ClockOnModel>($"/business/{businessId}/manager/kiosk/{kioskId}/clockon", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Discard current shift
        /// </summary>
        /// <remarks>
        /// Discards the current shift for an employee.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public KioskEmployeeModel DiscardCurrentShift(int businessId, int kioskId, ClockOffModel request)
        {
            return ApiRequest<KioskEmployeeModel,ClockOffModel>($"/business/{businessId}/manager/kiosk/{kioskId}/discard", request, Method.Post);
        }

        /// <summary>
        /// Discard current shift
        /// </summary>
        /// <remarks>
        /// Discards the current shift for an employee.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public Task<KioskEmployeeModel> DiscardCurrentShiftAsync(int businessId, int kioskId, ClockOffModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,ClockOffModel>($"/business/{businessId}/manager/kiosk/{kioskId}/discard", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Send PIN Reset Email
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by email.
        /// </remarks>
        public void SendPinResetEmail(int businessId, PinResetModel model, string kioskId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/emailreset", model, Method.Post);
        }

        /// <summary>
        /// Send PIN Reset Email
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by email.
        /// </remarks>
        public Task SendPinResetEmailAsync(int businessId, PinResetModel model, string kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/{kioskId}/emailreset", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// End Break
        /// </summary>
        /// <remarks>
        /// Ends the employee's current break.
        /// </remarks>
        public KioskEmployeeModel EndBreak(int businessId, int kioskId, EndBreakModel request)
        {
            return ApiRequest<KioskEmployeeModel,EndBreakModel>($"/business/{businessId}/manager/kiosk/{kioskId}/endbreak", request, Method.Post);
        }

        /// <summary>
        /// End Break
        /// </summary>
        /// <remarks>
        /// Ends the employee's current break.
        /// </remarks>
        public Task<KioskEmployeeModel> EndBreakAsync(int businessId, int kioskId, EndBreakModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,EndBreakModel>($"/business/{businessId}/manager/kiosk/{kioskId}/endbreak", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Lookup Data
        /// </summary>
        /// <remarks>
        /// Gets relevant lookup data for an employee in relation to a kiosk.
        /// </remarks>
        public NzTimeAndAttendanceLookupDataModel GetEmployeeLookupData(int businessId, int employeeId, int kioskId)
        {
            return ApiRequest<NzTimeAndAttendanceLookupDataModel>($"/business/{businessId}/manager/kiosk/{kioskId}/lookupdata/{employeeId}", Method.Get);
        }

        /// <summary>
        /// Get Employee Lookup Data
        /// </summary>
        /// <remarks>
        /// Gets relevant lookup data for an employee in relation to a kiosk.
        /// </remarks>
        public Task<NzTimeAndAttendanceLookupDataModel> GetEmployeeLookupDataAsync(int businessId, int employeeId, int kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzTimeAndAttendanceLookupDataModel>($"/business/{businessId}/manager/kiosk/{kioskId}/lookupdata/{employeeId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets all the notes for a specific shift.
        /// </remarks>
        public List<ShiftNoteViewModel> GetShiftNotes(int businessId, int kioskId, int shiftId)
        {
            return ApiRequest<List<ShiftNoteViewModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes", Method.Get);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets all the notes for a specific shift.
        /// </remarks>
        public Task<List<ShiftNoteViewModel>> GetShiftNotesAsync(int businessId, int kioskId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ShiftNoteViewModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets all the notes for a specific shift.
        /// </remarks>
        public List<ShiftNoteViewModel> GetShiftNotes(int businessId, int kioskId, int shiftId, GetShiftNotesQueryModel request)
        {
            return ApiRequest<List<ShiftNoteViewModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes?employeeId={request.EmployeeId}&isAdminInitiated={request.IsAdminInitiated}&type={request.Type}&visibility={request.Visibility}", Method.Get);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets all the notes for a specific shift.
        /// </remarks>
        public Task<List<ShiftNoteViewModel>> GetShiftNotesAsync(int businessId, int kioskId, int shiftId, GetShiftNotesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ShiftNoteViewModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes?employeeId={request.EmployeeId}&isAdminInitiated={request.IsAdminInitiated}&type={request.Type}&visibility={request.Visibility}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Add Note to Shift
        /// </summary>
        /// <remarks>
        /// Adds a note to an existing shift.
        /// </remarks>
        public ShiftNoteViewModel AddNoteToShift(int businessId, int kioskId, int shiftId, AddNoteModel model)
        {
            return ApiRequest<ShiftNoteViewModel,AddNoteModel>($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes", model, Method.Post);
        }

        /// <summary>
        /// Add Note to Shift
        /// </summary>
        /// <remarks>
        /// Adds a note to an existing shift.
        /// </remarks>
        public Task<ShiftNoteViewModel> AddNoteToShiftAsync(int businessId, int kioskId, int shiftId, AddNoteModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ShiftNoteViewModel,AddNoteModel>($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete Note from Shift
        /// </summary>
        /// <remarks>
        /// Deletes a note from an existing shift.
        /// </remarks>
        public void DeleteNoteFromShift(int businessId, int kioskId, int shiftId, int noteId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes/{noteId}", Method.Delete);
        }

        /// <summary>
        /// Delete Note from Shift
        /// </summary>
        /// <remarks>
        /// Deletes a note from an existing shift.
        /// </remarks>
        public Task DeleteNoteFromShiftAsync(int businessId, int kioskId, int shiftId, int noteId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes/{noteId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Mark Shift Notes Read
        /// </summary>
        /// <remarks>
        /// Marks some shift notes as either read or unread.
        /// </remarks>
        public void MarkShiftNotesRead(int businessId, MarkNotesReadViewModel model, string kioskId, string shiftId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes/read-state", model, Method.Post);
        }

        /// <summary>
        /// Mark Shift Notes Read
        /// </summary>
        /// <remarks>
        /// Marks some shift notes as either read or unread.
        /// </remarks>
        public Task MarkShiftNotesReadAsync(int businessId, MarkNotesReadViewModel model, string kioskId, string shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes/read-state", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Send PIN Reset SMS
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by SMS. Note that the current business must have SMS notifications enabled.
        /// </remarks>
        public void SendPinResetSms(int businessId, PinResetModel model, string kioskId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/smsreset", model, Method.Post);
        }

        /// <summary>
        /// Send PIN Reset SMS
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by SMS. Note that the current business must have SMS notifications enabled.
        /// </remarks>
        public Task SendPinResetSmsAsync(int businessId, PinResetModel model, string kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/{kioskId}/smsreset", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Kiosk Staff
        /// </summary>
        /// <remarks>
        /// Lists all the staff associated with a kiosk and their current shifts.
        /// </remarks>
        public List<BasicKioskEmployeeModel> ListKioskStaff(int businessId, int kioskId)
        {
            return ApiRequest<List<BasicKioskEmployeeModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/staff", Method.Get);
        }

        /// <summary>
        /// List Kiosk Staff
        /// </summary>
        /// <remarks>
        /// Lists all the staff associated with a kiosk and their current shifts.
        /// </remarks>
        public Task<List<BasicKioskEmployeeModel>> ListKioskStaffAsync(int businessId, int kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BasicKioskEmployeeModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/staff", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Kiosk Staff
        /// </summary>
        /// <remarks>
        /// Lists all the staff associated with a kiosk and their current shifts.
        /// </remarks>
        public List<BasicKioskEmployeeModel> ListKioskStaff(int businessId, int kioskId, ListKioskStaffQueryModel request)
        {
            return ApiRequest<List<BasicKioskEmployeeModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/staff?restrictCurrentShiftsToCurrentKioskLocation={request.RestrictCurrentShiftsToCurrentKioskLocation}", Method.Get);
        }

        /// <summary>
        /// List Kiosk Staff
        /// </summary>
        /// <remarks>
        /// Lists all the staff associated with a kiosk and their current shifts.
        /// </remarks>
        public Task<List<BasicKioskEmployeeModel>> ListKioskStaffAsync(int businessId, int kioskId, ListKioskStaffQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BasicKioskEmployeeModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/staff?restrictCurrentShiftsToCurrentKioskLocation={request.RestrictCurrentShiftsToCurrentKioskLocation}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Add an Employee
        /// </summary>
        /// <remarks>
        /// Quickly add an employee with minimal details and kiosk enabled. If the employee already exists, the kiosk will be enabled for that employee.
        /// </remarks>
        public void AddAnEmployee(int businessId, int kioskId, KioskCreateEmployeeModel model)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/staff", model, Method.Post);
        }

        /// <summary>
        /// Add an Employee
        /// </summary>
        /// <remarks>
        /// Quickly add an employee with minimal details and kiosk enabled. If the employee already exists, the kiosk will be enabled for that employee.
        /// </remarks>
        public Task AddAnEmployeeAsync(int businessId, int kioskId, KioskCreateEmployeeModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/{kioskId}/staff", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Start Break
        /// </summary>
        /// <remarks>
        /// Starts a break for an employee who is clocked on for a shift.
        /// </remarks>
        public KioskEmployeeModel StartBreak(int businessId, int kioskId, StartBreakModel request)
        {
            return ApiRequest<KioskEmployeeModel,StartBreakModel>($"/business/{businessId}/manager/kiosk/{kioskId}/startbreak", request, Method.Post);
        }

        /// <summary>
        /// Start Break
        /// </summary>
        /// <remarks>
        /// Starts a break for an employee who is clocked on for a shift.
        /// </remarks>
        public Task<KioskEmployeeModel> StartBreakAsync(int businessId, int kioskId, StartBreakModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,StartBreakModel>($"/business/{businessId}/manager/kiosk/{kioskId}/startbreak", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Shifts
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public List<NzTimeAndAttendanceShiftModel> Shifts(int businessId, GetShiftsModel model)
        {
            return ApiRequest<List<NzTimeAndAttendanceShiftModel>,GetShiftsModel>($"/business/{businessId}/manager/kiosk/shifts", model, Method.Post);
        }

        /// <summary>
        /// Shifts
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public Task<List<NzTimeAndAttendanceShiftModel>> ShiftsAsync(int businessId, GetShiftsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzTimeAndAttendanceShiftModel>,GetShiftsModel>($"/business/{businessId}/manager/kiosk/shifts", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves all timesheets that the manager has access to for the specified business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<TimesheetLineModel> GetBusinessTimesheets(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<TimesheetLineModel>>($"/business/{businessId}/manager/kiosk/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves all timesheets that the manager has access to for the specified business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<TimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TimesheetLineModel>>($"/business/{businessId}/manager/kiosk/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create kiosk timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public void CreateKioskTimesheetLine(int businessId, IndividualTimesheetLineModel request)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/timesheet", request, Method.Post);
        }

        /// <summary>
        /// Create kiosk timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task CreateKioskTimesheetLineAsync(int businessId, IndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/timesheet", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Update kiosk timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public void UpdateKioskTimesheetLine(int businessId, int timesheetLineId, IndividualTimesheetLineModel request)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/timesheet/{timesheetLineId}", request, Method.Put);
        }

        /// <summary>
        /// Update kiosk timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task UpdateKioskTimesheetLineAsync(int businessId, int timesheetLineId, IndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/timesheet/{timesheetLineId}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Update comments in a timesheet
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line with comments
        /// </remarks>
        public void UpdateCommentsInATimesheet(int businessId, TimesheetLineCommentsModel request, string timesheetLineId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/timesheetcomments/{timesheetLineId}", request, Method.Put);
        }

        /// <summary>
        /// Update comments in a timesheet
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line with comments
        /// </remarks>
        public Task UpdateCommentsInATimesheetAsync(int businessId, TimesheetLineCommentsModel request, string timesheetLineId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/kiosk/timesheetcomments/{timesheetLineId}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for this manager.
        /// </remarks>
        public List<ManagerLeaveRequestModel> ListLeaveRequests(int businessId)
        {
            return ApiRequest<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest", Method.Get);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for this manager.
        /// </remarks>
        public Task<List<ManagerLeaveRequestModel>> ListLeaveRequestsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for this manager.
        /// </remarks>
        public List<ManagerLeaveRequestModel> ListLeaveRequests(int businessId, ListLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&leaveCategoryId={request.LeaveCategoryId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&groupBy={request.GroupBy}&restrictOverlappingLeave={request.RestrictOverlappingLeave}", Method.Get);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for this manager.
        /// </remarks>
        public Task<List<ManagerLeaveRequestModel>> ListLeaveRequestsAsync(int businessId, ListLeaveRequestsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&leaveCategoryId={request.LeaveCategoryId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&groupBy={request.GroupBy}&restrictOverlappingLeave={request.RestrictOverlappingLeave}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for this business.
        /// </remarks>
        public List<ManagerLeaveCategoryModel> ListLeaveCategories(int businessId)
        {
            return ApiRequest<List<ManagerLeaveCategoryModel>>($"/business/{businessId}/manager/leaverequest/categories", Method.Get);
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for this business.
        /// </remarks>
        public Task<List<ManagerLeaveCategoryModel>> ListLeaveCategoriesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerLeaveCategoryModel>>($"/business/{businessId}/manager/leaverequest/categories", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Leave Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has leave permissions on.
        /// </remarks>
        public List<ManagerLeaveEmployeeModel> ListLeaveEmployees(int businessId)
        {
            return ApiRequest<List<ManagerLeaveEmployeeModel>>($"/business/{businessId}/manager/leaverequest/employees", Method.Get);
        }

        /// <summary>
        /// List Leave Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has leave permissions on.
        /// </remarks>
        public Task<List<ManagerLeaveEmployeeModel>> ListLeaveEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerLeaveEmployeeModel>>($"/business/{businessId}/manager/leaverequest/employees", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Leave Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has leave permissions on.
        /// </remarks>
        public List<LocationModel> ListLeaveLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/leaverequest/locations", Method.Get);
        }

        /// <summary>
        /// List Leave Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has leave permissions on.
        /// </remarks>
        public Task<List<LocationModel>> ListLeaveLocationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/leaverequest/locations", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Overlapping Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the overlapping leave requests for the given date range.
        /// </remarks>
        public List<ManagerLeaveRequestModel> OverlappingLeaveRequests(int businessId, OverlappingLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest/overlapping?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Overlapping Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the overlapping leave requests for the given date range.
        /// </remarks>
        public Task<List<ManagerLeaveRequestModel>> OverlappingLeaveRequestsAsync(int businessId, OverlappingLeaveRequestsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest/overlapping?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Employee Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for an employee that are available to the manager.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<LocationModel> ListEmployeeLocations(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Employee Locations
        /// </summary>
        /// <remarks>
        /// Lists all the locations for an employee that are available to the manager.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<LocationModel>> ListEmployeeLocationsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/location{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get List of Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations the manager can access.
        /// </remarks>
        public List<LocationModel> GetListOfLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/locations", Method.Get);
        }

        /// <summary>
        /// Get List of Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations the manager can access.
        /// </remarks>
        public Task<List<LocationModel>> GetListOfLocationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/locations", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public List<NzRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId)
        {
            return ApiRequest<List<NzRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/manager/rostershift", Method.Get);
        }

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public Task<List<NzRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/manager/rostershift", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public List<NzRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId, GetRosterShiftsQueryModel request)
        {
            return ApiRequest<List<NzRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/manager/rostershift?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&shiftStatus={request.ShiftStatus}{ConvertEnumerableToQueryString("shiftStatuses", request.ShiftStatuses?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedLocations", request.SelectedLocations?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedEmployees", request.SelectedEmployees?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedRoles", request.SelectedRoles?.Select(x => x.ToString()))}&employeeId={request.EmployeeId}&locationId={request.LocationId}&employeeGroupId={request.EmployeeGroupId}&unassignedShiftsOnly={request.UnassignedShiftsOnly}&selectAllRoles={request.SelectAllRoles}&excludeShiftsOverlappingFromDate={request.ExcludeShiftsOverlappingFromDate}&pageSize={request.PageSize}&currentPage={request.CurrentPage}&includeWarnings={request.IncludeWarnings}", Method.Get);
        }

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public Task<List<NzRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, GetRosterShiftsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/manager/rostershift?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&shiftStatus={request.ShiftStatus}{ConvertEnumerableToQueryString("shiftStatuses", request.ShiftStatuses?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedLocations", request.SelectedLocations?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedEmployees", request.SelectedEmployees?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedRoles", request.SelectedRoles?.Select(x => x.ToString()))}&employeeId={request.EmployeeId}&locationId={request.LocationId}&employeeGroupId={request.EmployeeGroupId}&unassignedShiftsOnly={request.UnassignedShiftsOnly}&selectAllRoles={request.SelectAllRoles}&excludeShiftsOverlappingFromDate={request.ExcludeShiftsOverlappingFromDate}&pageSize={request.PageSize}&currentPage={request.CurrentPage}&includeWarnings={request.IncludeWarnings}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create roster shift
        /// </summary>
        /// <remarks>
        /// Create or update an individual roster shift
        /// </remarks>
        public void CreateRosterShift(int businessId, RosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request)
        {
            ApiRequest($"/business/{businessId}/manager/rostershift?publish={request.Publish}", shiftModel, Method.Post);
        }

        /// <summary>
        /// Create roster shift
        /// </summary>
        /// <remarks>
        /// Create or update an individual roster shift
        /// </remarks>
        public Task CreateRosterShiftAsync(int businessId, RosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/rostershift?publish={request.Publish}", shiftModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Find Matching Clock Off Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock off at this time
        /// given kiosk settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public NzRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request)
        {
            return ApiRequest<NzRosterShiftMatchingResultModel>($"/business/{businessId}/manager/rostershift/{employeeId}/matchingclockoff?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Find Matching Clock Off Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock off at this time
        /// given kiosk settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public Task<NzRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzRosterShiftMatchingResultModel>($"/business/{businessId}/manager/rostershift/{employeeId}/matchingclockoff?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Find Matching Clock On Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock on at this time
        /// given kiosk settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public NzRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request)
        {
            return ApiRequest<NzRosterShiftMatchingResultModel>($"/business/{businessId}/manager/rostershift/{employeeId}/matchingclockon?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Find Matching Clock On Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock on at this time
        /// given kiosk settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public Task<NzRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzRosterShiftMatchingResultModel>($"/business/{businessId}/manager/rostershift/{employeeId}/matchingclockon?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public List<NzEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request)
        {
            return ApiRequest<List<NzEssRosterShiftModel>>($"/business/{businessId}/manager/rostershift/{employeeId}/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public Task<List<NzEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzEssRosterShiftModel>>($"/business/{businessId}/manager/rostershift/{employeeId}/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Roster Shift by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a roster shift with the specified ID.
        /// </remarks>
        public ManagerRosterShiftModel GetRosterShiftById(int businessId, int rosterShiftId)
        {
            return ApiRequest<ManagerRosterShiftModel>($"/business/{businessId}/manager/rostershift/{rosterShiftId}", Method.Get);
        }

        /// <summary>
        /// Get Roster Shift by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a roster shift with the specified ID.
        /// </remarks>
        public Task<ManagerRosterShiftModel> GetRosterShiftByIdAsync(int businessId, int rosterShiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerRosterShiftModel>($"/business/{businessId}/manager/rostershift/{rosterShiftId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Roster Shift by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a roster shift with the specified ID.
        /// </remarks>
        public ManagerRosterShiftModel GetRosterShiftById(int businessId, int rosterShiftId, GetRosterShiftByIdQueryModel request)
        {
            return ApiRequest<ManagerRosterShiftModel>($"/business/{businessId}/manager/rostershift/{rosterShiftId}?includeCosts={request.IncludeCosts}", Method.Get);
        }

        /// <summary>
        /// Get Roster Shift by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a roster shift with the specified ID.
        /// </remarks>
        public Task<ManagerRosterShiftModel> GetRosterShiftByIdAsync(int businessId, int rosterShiftId, GetRosterShiftByIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ManagerRosterShiftModel>($"/business/{businessId}/manager/rostershift/{rosterShiftId}?includeCosts={request.IncludeCosts}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update roster shift
        /// </summary>
        /// <remarks>
        /// Update an individual roster shift
        /// </remarks>
        public void UpdateRosterShift(int businessId, RosterShiftEditModel shiftModel, int rosterShiftId, UpdateRosterShiftQueryModel request)
        {
            ApiRequest($"/business/{businessId}/manager/rostershift/{rosterShiftId}?publish={request.Publish}", shiftModel, Method.Put);
        }

        /// <summary>
        /// Update roster shift
        /// </summary>
        /// <remarks>
        /// Update an individual roster shift
        /// </remarks>
        public Task UpdateRosterShiftAsync(int businessId, RosterShiftEditModel shiftModel, int rosterShiftId, UpdateRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/rostershift/{rosterShiftId}?publish={request.Publish}", shiftModel, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Stub Shift Timesheets
        /// </summary>
        /// <remarks>
        /// Generates timesheets for the roster shift with the specified ID.
        /// </remarks>
        public void StubShiftTimesheets(int businessId, int rosterShiftId, StubRosterShiftViewModel model)
        {
            ApiRequest($"/business/{businessId}/manager/rostershift/{rosterShiftId}/stub", model, Method.Post);
        }

        /// <summary>
        /// Stub Shift Timesheets
        /// </summary>
        /// <remarks>
        /// Generates timesheets for the roster shift with the specified ID.
        /// </remarks>
        public Task StubShiftTimesheetsAsync(int businessId, int rosterShiftId, StubRosterShiftViewModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/rostershift/{rosterShiftId}/stub", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Roster Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has roster permissions on.
        /// </remarks>
        public List<ManagerRosterEmployeeModel> ListRosterEmployees(int businessId)
        {
            return ApiRequest<List<ManagerRosterEmployeeModel>>($"/business/{businessId}/manager/rostershift/employees", Method.Get);
        }

        /// <summary>
        /// List Roster Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has roster permissions on.
        /// </remarks>
        public Task<List<ManagerRosterEmployeeModel>> ListRosterEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerRosterEmployeeModel>>($"/business/{businessId}/manager/rostershift/employees", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Roster Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has roster permissions on.
        /// </remarks>
        public List<LocationModel> ListRosterLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/rostershift/locations", Method.Get);
        }

        /// <summary>
        /// List Roster Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has roster permissions on.
        /// </remarks>
        public Task<List<LocationModel>> ListRosterLocationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/rostershift/locations", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Manage Roster Data
        /// </summary>
        /// <remarks>
        /// For the single date selected returns data about all published rostered shifts, published unassigned shifts,
        /// employee unavailablity, and leave requests.
        /// </remarks>
        public NzManagerRosterDataModel ManageRosterData(int businessId)
        {
            return ApiRequest<NzManagerRosterDataModel>($"/business/{businessId}/manager/rostershift/manage", Method.Get);
        }

        /// <summary>
        /// Manage Roster Data
        /// </summary>
        /// <remarks>
        /// For the single date selected returns data about all published rostered shifts, published unassigned shifts,
        /// employee unavailablity, and leave requests.
        /// </remarks>
        public Task<NzManagerRosterDataModel> ManageRosterDataAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzManagerRosterDataModel>($"/business/{businessId}/manager/rostershift/manage", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Manage Roster Data
        /// </summary>
        /// <remarks>
        /// For the single date selected returns data about all published rostered shifts, published unassigned shifts,
        /// employee unavailablity, and leave requests.
        /// </remarks>
        public NzManagerRosterDataModel ManageRosterData(int businessId, ManageRosterDataQueryModel request)
        {
            return ApiRequest<NzManagerRosterDataModel>($"/business/{businessId}/manager/rostershift/manage?date={request.Date.ToString("yyyy-MM-ddTHH:mm:ss")}&employeeId={request.EmployeeId}&locationId={request.LocationId}&roleId={request.RoleId}&includeCosts={request.IncludeCosts}&includeSubLocations={request.IncludeSubLocations}", Method.Get);
        }

        /// <summary>
        /// Manage Roster Data
        /// </summary>
        /// <remarks>
        /// For the single date selected returns data about all published rostered shifts, published unassigned shifts,
        /// employee unavailablity, and leave requests.
        /// </remarks>
        public Task<NzManagerRosterDataModel> ManageRosterDataAsync(int businessId, ManageRosterDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzManagerRosterDataModel>($"/business/{businessId}/manager/rostershift/manage?date={request.Date.ToString("yyyy-MM-ddTHH:mm:ss")}&employeeId={request.EmployeeId}&locationId={request.LocationId}&roleId={request.RoleId}&includeCosts={request.IncludeCosts}&includeSubLocations={request.IncludeSubLocations}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Manager Roster Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has manage roster permissions on.
        /// </remarks>
        public List<ManagerRosterEmployeeModel> ListManagerRosterEmployees(int businessId)
        {
            return ApiRequest<List<ManagerRosterEmployeeModel>>($"/business/{businessId}/manager/rostershift/manageemployees", Method.Get);
        }

        /// <summary>
        /// List Manager Roster Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has manage roster permissions on.
        /// </remarks>
        public Task<List<ManagerRosterEmployeeModel>> ListManagerRosterEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerRosterEmployeeModel>>($"/business/{businessId}/manager/rostershift/manageemployees", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get the list of roles available
        /// </summary>
        public List<RosterShiftRole> GetTheListOfRolesAvailable(int businessId)
        {
            return ApiRequest<List<RosterShiftRole>>($"/business/{businessId}/manager/rostershift/roles", Method.Get);
        }

        /// <summary>
        /// Get the list of roles available
        /// </summary>
        public Task<List<RosterShiftRole>> GetTheListOfRolesAvailableAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<RosterShiftRole>>($"/business/{businessId}/manager/rostershift/roles", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Rounding Rules
        /// </summary>
        /// <remarks>
        /// Gets the rounding rules for the business.
        /// </remarks>
        public TimesheetRoundingRulesModel GetRoundingRules(int businessId)
        {
            return ApiRequest<TimesheetRoundingRulesModel>($"/business/{businessId}/manager/roundingrules", Method.Get);
        }

        /// <summary>
        /// Get Rounding Rules
        /// </summary>
        /// <remarks>
        /// Gets the rounding rules for the business.
        /// </remarks>
        public Task<TimesheetRoundingRulesModel> GetRoundingRulesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TimesheetRoundingRulesModel>($"/business/{businessId}/manager/roundingrules", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Rounding Rules
        /// </summary>
        /// <remarks>
        /// Sets the rounding rules for the business.
        /// </remarks>
        public void SetRoundingRules(int businessId, TimesheetRoundingRulesModel roundingRules)
        {
            ApiRequest($"/business/{businessId}/manager/roundingrules", roundingRules, Method.Post);
        }

        /// <summary>
        /// Set Rounding Rules
        /// </summary>
        /// <remarks>
        /// Sets the rounding rules for the business.
        /// </remarks>
        public Task SetRoundingRulesAsync(int businessId, TimesheetRoundingRulesModel roundingRules, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/roundingrules", roundingRules, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves timesheets for the specified business which manager can access
        /// </remarks>
        public PagedResultModel<ManagerTimesheetLineModel> GetBusinessTimesheets(int businessId)
        {
            return ApiRequest<PagedResultModel<ManagerTimesheetLineModel>>($"/business/{businessId}/manager/timesheet", Method.Get);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves timesheets for the specified business which manager can access
        /// </remarks>
        public Task<PagedResultModel<ManagerTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PagedResultModel<ManagerTimesheetLineModel>>($"/business/{businessId}/manager/timesheet", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves timesheets for the specified business which manager can access
        /// </remarks>
        public PagedResultModel<ManagerTimesheetLineModel> GetBusinessTimesheets(int businessId, GetBusinessTimesheetsQueryModel request)
        {
            return ApiRequest<PagedResultModel<ManagerTimesheetLineModel>>($"/business/{businessId}/manager/timesheet?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&status={request.Status}&employeeId={request.EmployeeId}&employeeGroupId={request.EmployeeGroupId}&locationId={request.LocationId}&includeCosts={request.IncludeCosts}&currentPage={request.CurrentPage}&pageSize={request.PageSize}&orderBy={request.OrderBy}", Method.Get);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves timesheets for the specified business which manager can access
        /// </remarks>
        public Task<PagedResultModel<ManagerTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, GetBusinessTimesheetsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PagedResultModel<ManagerTimesheetLineModel>>($"/business/{businessId}/manager/timesheet?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&status={request.Status}&employeeId={request.EmployeeId}&employeeGroupId={request.EmployeeGroupId}&locationId={request.LocationId}&includeCosts={request.IncludeCosts}&currentPage={request.CurrentPage}&pageSize={request.PageSize}&orderBy={request.OrderBy}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public void CreateTimesheetLine(int businessId, NzIndividualTimesheetLineModel request)
        {
            ApiRequest($"/business/{businessId}/manager/timesheet", request, Method.Post);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task CreateTimesheetLineAsync(int businessId, NzIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/timesheet", request, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public void UpdateTimesheetLine(int businessId, int timesheetLineId, NzIndividualTimesheetLineModel request)
        {
            ApiRequest($"/business/{businessId}/manager/timesheet/{timesheetLineId}", request, Method.Put);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// IMPORTANT NOTICE: If units are specified the start and end time will be changed to midnight
        /// </remarks>
        public Task UpdateTimesheetLineAsync(int businessId, int timesheetLineId, NzIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/manager/timesheet/{timesheetLineId}", request, Method.Put, cancellationToken);
        }

        /// <summary>
        /// List Employee Groups
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve timesheet permissions on.
        /// </remarks>
        public List<ManagerEmployeeGroup> ListEmployeeGroups(int businessId)
        {
            return ApiRequest<List<ManagerEmployeeGroup>>($"/business/{businessId}/manager/timesheet/employeegroups", Method.Get);
        }

        /// <summary>
        /// List Employee Groups
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve timesheet permissions on.
        /// </remarks>
        public Task<List<ManagerEmployeeGroup>> ListEmployeeGroupsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerEmployeeGroup>>($"/business/{businessId}/manager/timesheet/employeegroups", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Timesheet Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve timesheet permissions on.
        /// </remarks>
        public List<ManagerTimesheetEmployeeModel> ListTimesheetEmployees(int businessId)
        {
            return ApiRequest<List<ManagerTimesheetEmployeeModel>>($"/business/{businessId}/manager/timesheet/employees", Method.Get);
        }

        /// <summary>
        /// List Timesheet Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve timesheet permissions on.
        /// </remarks>
        public Task<List<ManagerTimesheetEmployeeModel>> ListTimesheetEmployeesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ManagerTimesheetEmployeeModel>>($"/business/{businessId}/manager/timesheet/employees", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Timesheet Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has approve timesheet permissions on.
        /// </remarks>
        public List<LocationModel> ListTimesheetLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/timesheet/locations", Method.Get);
        }

        /// <summary>
        /// List Timesheet Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has approve timesheet permissions on.
        /// </remarks>
        public Task<List<LocationModel>> ListTimesheetLocationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/business/{businessId}/manager/timesheet/locations", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Businesses
        /// </summary>
        /// <remarks>
        /// Returns all the businesses the user can access.
        /// </remarks>
        public List<NzAvailableBusinessModel> ListBusinesses()
        {
            return ApiRequest<List<NzAvailableBusinessModel>>($"/manager/security/businesses", Method.Get);
        }

        /// <summary>
        /// List Businesses
        /// </summary>
        /// <remarks>
        /// Returns all the businesses the user can access.
        /// </remarks>
        public Task<List<NzAvailableBusinessModel>> ListBusinessesAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzAvailableBusinessModel>>($"/manager/security/businesses", Method.Get, cancellationToken);
        }
    }
}
