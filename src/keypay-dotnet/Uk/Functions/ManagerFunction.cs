using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.Manager;

namespace KeyPayV2.Uk.Functions
{
    public class ManagerFunction : BaseFunction
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
            ApiRequest($"/business/{businessId}/manager/{employeeId}/document/download/{documentId}");
        }

        /// <summary>
        /// Create expense request
        /// </summary>
        /// <remarks>
        /// Creates an expense request for the employee
        /// </remarks>
        public ManagerExpenseRequestModel CreateExpenseRequest(int businessId, int employeeId, ExpenseRequestEditModel expenseRequest)
        {
            return ApiRequest<ManagerExpenseRequestModel,ExpenseRequestEditModel>($"/business/{businessId}/manager/{employeeId}/expense", expenseRequest, Method.POST);
        }

        /// <summary>
        /// Get expense request
        /// </summary>
        /// <remarks>
        /// Gets the expense request  with the specified ID.
        /// </remarks>
        public ManagerExpenseRequestModel GetExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            return ApiRequest<ManagerExpenseRequestModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}");
        }

        /// <summary>
        /// Edit Expense Request
        /// </summary>
        /// <remarks>
        /// Edits the Expense Request with the specified ID.
        /// </remarks>
        public ManagerExpenseRequestModel EditExpenseRequest(int businessId, int employeeId, int expenseRequestId, ExpenseRequestEditModel expenseRequest)
        {
            return ApiRequest<ManagerExpenseRequestModel,ExpenseRequestEditModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", expenseRequest, Method.PUT);
        }

        /// <summary>
        /// Delete Expense Request
        /// </summary>
        /// <remarks>
        /// Deletes the Expense Request with the specified ID.
        /// </remarks>
        public void DeleteExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            ApiRequest($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", Method.DELETE);
        }

        /// <summary>
        /// Approve Expense Request
        /// </summary>
        /// <remarks>
        /// Approves the Expense Request with the specified ID.
        /// </remarks>
        public ManagerExpenseRequestModel ApproveExpenseRequest(int businessId, int employeeId, int expenseRequestId)
        {
            return ApiRequest<ManagerExpenseRequestModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/approve", Method.POST);
        }

        /// <summary>
        /// Upload Attachment to Expense Request
        /// </summary>
        /// <remarks>
        /// Uploads an attachment to the expense request with the specified ID.
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public void UploadAttachmentToExpenseRequest(int businessId, int employeeId, FileUploadModel file, int expenseRequestId, UploadAttachmentToExpenseRequestQueryModel request)
        {
            ApiRequest($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/attachment?fileName={request.FileName}", file, Method.PUT);
        }

        /// <summary>
        /// Decline Expense Request
        /// </summary>
        /// <remarks>
        /// Declines the Expense Request with the specified ID.
        /// </remarks>
        public ManagerExpenseRequestModel DeclineExpenseRequest(int businessId, int employeeId, int expenseRequestId, DeclineReason reason)
        {
            return ApiRequest<ManagerExpenseRequestModel,DeclineReason>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/decline", reason, Method.POST);
        }

        /// <summary>
        /// Get expenses reference data
        /// </summary>
        /// <remarks>
        /// Gets the Tax Codes, Expense Categories, and Locations for this Employee.
        /// </remarks>
        public ExpenseReferenceData GetExpensesReferenceData(int businessId, int employeeId)
        {
            return ApiRequest<ExpenseReferenceData>($"/business/{businessId}/manager/{employeeId}/expense/reference");
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request.
        /// </remarks>
        public ManagerLeaveRequestModel CreateLeaveRequest(int businessId, int employeeId, ManagerLeaveApplicationModel leaveApplication)
        {
            return ApiRequest<ManagerLeaveRequestModel,ManagerLeaveApplicationModel>($"/business/{businessId}/manager/{employeeId}/leaverequest", leaveApplication, Method.POST);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel GetLeaveRequestById(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}");
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel UpdateLeaveRequest(int businessId, int employeeId, int leaveRequestId, ManagerLeaveApplicationModel leaveApplication)
        {
            return ApiRequest<ManagerLeaveRequestModel,ManagerLeaveApplicationModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", leaveApplication, Method.POST);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel DeleteLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}", Method.DELETE);
        }

        /// <summary>
        /// Approve Leave Request
        /// </summary>
        /// <remarks>
        /// Approves the leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel ApproveLeaveRequest(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<ManagerLeaveRequestModel>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/approve", Method.POST);
        }

        /// <summary>
        /// Get Leave Request Attachment
        /// </summary>
        /// <remarks>
        /// Gets the file for an employee leave request by ID.
        /// </remarks>
        public DocumentFile GetLeaveRequestAttachment(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<DocumentFile>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/attachment");
        }

        /// <summary>
        /// Decline Leave Request
        /// </summary>
        /// <remarks>
        /// Declines the leave request with the specified ID.
        /// </remarks>
        public ManagerLeaveRequestModel DeclineLeaveRequest(int businessId, int employeeId, int leaveRequestId, DeclineReason declineReason)
        {
            return ApiRequest<ManagerLeaveRequestModel,DeclineReason>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/decline", declineReason, Method.POST);
        }

        /// <summary>
        /// Overlapping Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the overlapping leave requests for the given date range.
        /// </remarks>
        public List<ManagerLeaveRequestModel> OverlappingLeaveRequests(int businessId, int employeeId, int leaveRequestId)
        {
            return ApiRequest<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/{leaveRequestId}/overlapping");
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public List<LeaveBalanceModel> GetLeaveBalances(int businessId, int employeeId, GetLeaveBalancesQueryModel request)
        {
            return ApiRequest<List<LeaveBalanceModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/balances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}");
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for this employee.
        /// </remarks>
        public List<ManagerLeaveCategoryModel> ListLeaveCategories(int businessId, int employeeId)
        {
            return ApiRequest<List<ManagerLeaveCategoryModel>>($"/business/{businessId}/manager/{employeeId}/leaverequest/categories");
        }

        /// <summary>
        /// Estimate Leave Hours
        /// </summary>
        /// <remarks>
        /// Estimates the number of hours of leave required based on date and leave category.
        /// </remarks>
        public ManagerLeaveEstimate EstimateLeaveHours(int businessId, int employeeId, EstimateLeaveHoursQueryModel request)
        {
            return ApiRequest<ManagerLeaveEstimate>($"/business/{businessId}/manager/{employeeId}/leaverequest/estimate?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&leaveCategoryId={request.LeaveCategoryId}");
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Create an unavailability for an employee.
        /// </remarks>
        public ManagerUnavailabilityModel CreateUnavailability(int businessId, int employeeId, UnavailabilityEditModel model)
        {
            return ApiRequest<ManagerUnavailabilityModel,UnavailabilityEditModel>($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability", model, Method.POST);
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public ManagerUnavailabilityModel UpdateUnavailability(int businessId, int employeeId, int unavailabilityId, UnavailabilityEditModel model)
        {
            return ApiRequest<ManagerUnavailabilityModel,UnavailabilityEditModel>($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability/{unavailabilityId}", model, Method.PUT);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public void DeleteUnavailability(int businessId, int employeeId, int unavailabilityId)
        {
            ApiRequest($"/business/{businessId}/manager/{employeeId}/rostershift/unavailability/{unavailabilityId}", Method.DELETE);
        }

        /// <summary>
        /// Get timesheet
        /// </summary>
        /// <remarks>
        /// Gets the timesheet with the specified ID.
        /// </remarks>
        public ManagerTimesheetLineModel GetTimesheet(int businessId, int employeeId, int timesheetId)
        {
            return ApiRequest<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}");
        }

        /// <summary>
        /// Edit Timesheet
        /// </summary>
        /// <remarks>
        /// Edits the timesheet with the specified ID.
        /// </remarks>
        public ManagerTimesheetLineModel EditTimesheet(int businessId, int employeeId, int timesheetId, ManagerTimesheetSubmitModel timesheet)
        {
            return ApiRequest<ManagerTimesheetLineModel,ManagerTimesheetSubmitModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", timesheet, Method.POST);
        }

        /// <summary>
        /// Delete Timesheet
        /// </summary>
        /// <remarks>
        /// Deletes the timesheet with the specified ID.
        /// </remarks>
        public void DeleteTimesheet(int businessId, int employeeId, int timesheetId)
        {
            ApiRequest($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}", Method.DELETE);
        }

        /// <summary>
        /// Approve Timesheet
        /// </summary>
        /// <remarks>
        /// Approves the timesheet with the specified ID.
        /// </remarks>
        public ManagerTimesheetLineModel ApproveTimesheet(int businessId, int employeeId, int timesheetId)
        {
            return ApiRequest<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}/approve", Method.POST);
        }

        /// <summary>
        /// Reject Timesheet
        /// </summary>
        /// <remarks>
        /// Rejects the timesheet with the specified ID.
        /// </remarks>
        public ManagerTimesheetLineModel RejectTimesheet(int businessId, int employeeId, int timesheetId)
        {
            return ApiRequest<ManagerTimesheetLineModel>($"/business/{businessId}/manager/{employeeId}/timesheet/{timesheetId}/reject", Method.POST);
        }

        /// <summary>
        /// Get timesheet reference data
        /// </summary>
        /// <remarks>
        /// Gets the Work Types, Shift Conditions, Locations and Classifications for this Employee.
        /// </remarks>
        public TimesheetReferenceData GetTimesheetReferenceData(int businessId, int employeeId)
        {
            return ApiRequest<TimesheetReferenceData>($"/business/{businessId}/manager/{employeeId}/timesheet/reference");
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public void GetEmployeeProfileImage(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/manager/employee/{employeeId}/image");
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public ProfileImageMetadata SetEmployeeProfileImage(int businessId, int employeeId)
        {
            return ApiRequest<ProfileImageMetadata>($"/business/{businessId}/manager/employee/{employeeId}/image", Method.POST);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public void DeleteEmployeeProfileImage(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/manager/employee/{employeeId}/image", Method.DELETE);
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
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/employee/{employeeId}/location{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Initiate Employee Self Service Onboarding
        /// </summary>
        /// <remarks>
        /// Initiate the Self Service Onboarding process for an Employee.
        /// If the employee has an existing employee record, the id should be specified. If the Email and Mobile provided
        /// are not the same as those on the employee record, they will be updated.
        /// If the employee does not yet have an employee record do not specify an id, one will be created with the
        /// details provided.
        /// </remarks>
        public void InitiateEmployeeSelfServiceOnboarding(int businessId, InitiateEmployeeOnboardingApiModel model)
        {
            ApiRequest($"/business/{businessId}/manager/employeeonboarding/initiateselfservice", model, Method.POST);
        }

        /// <summary>
        /// Get List of Employees
        /// </summary>
        /// <remarks>
        /// Lists all employees the manager can access.
        /// </remarks>
        public List<EmployeeDetailsModel> GetListOfEmployees(int businessId)
        {
            return ApiRequest<List<EmployeeDetailsModel>>($"/business/{businessId}/manager/employees");
        }

        /// <summary>
        /// Get Business Expense Requests
        /// </summary>
        /// <remarks>
        /// Retrieves expense request for the specified business which manager can access
        /// </remarks>
        public PagedResultModel<ManagerExpenseRequestModel> GetBusinessExpenseRequests(int businessId, GetBusinessExpenseRequestsQueryModel request)
        {
            return ApiRequest<PagedResultModel<ManagerExpenseRequestModel>>($"/business/{businessId}/manager/expense?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employeeId={request.EmployeeId}&locationId={request.LocationId}&expenseCategoryId={request.ExpenseCategoryId}&groupBy={request.GroupBy}&currentPage={request.CurrentPage}&pageSize={request.PageSize}");
        }

        /// <summary>
        /// List Expense Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the expense categories
        /// </remarks>
        public List<ExpenseCategoryResponseModel> ListExpenseCategories(int businessId)
        {
            return ApiRequest<List<ExpenseCategoryResponseModel>>($"/business/{businessId}/manager/expense/categories");
        }

        /// <summary>
        /// List Expense Request Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve expense request permissions on.
        /// </remarks>
        public List<ManagerExpenseEmployeeModel> ListExpenseRequestEmployees(int businessId)
        {
            return ApiRequest<List<ManagerExpenseEmployeeModel>>($"/business/{businessId}/manager/expense/employees");
        }

        /// <summary>
        /// List Expense Request Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has approve expense request permissions on.
        /// </remarks>
        public List<LocationModel> ListExpenseRequestLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/expense/locations");
        }

        /// <summary>
        /// List Tax Codes
        /// </summary>
        /// <remarks>
        /// Lists all of the tax codes
        /// </remarks>
        public List<ExpenseTaxCode> ListTaxCodes(int businessId)
        {
            return ApiRequest<List<ExpenseTaxCode>>($"/business/{businessId}/manager/expense/taxcodes");
        }

        /// <summary>
        /// Get Kiosks
        /// </summary>
        /// <remarks>
        /// Returns all kiosks that the user has access to for this business
        /// </remarks>
        public List<TimeAndAttendanceKioskModel> GetKiosks(int businessId)
        {
            return ApiRequest<List<TimeAndAttendanceKioskModel>>($"/business/{businessId}/manager/kiosk");
        }

        /// <summary>
        /// Get Kiosk by ID
        /// </summary>
        /// <remarks>
        /// Gets the kiosk with the specified ID.
        /// </remarks>
        public TimeAndAttendanceKioskModel GetKioskById(int businessId, int id)
        {
            return ApiRequest<TimeAndAttendanceKioskModel>($"/business/{businessId}/manager/kiosk/{id}");
        }

        /// <summary>
        /// Change PIN
        /// </summary>
        /// <remarks>
        /// Changes the kiosk PIN for an employee, given their old PIN.
        /// </remarks>
        public void ChangePin(int businessId, int kioskId, ChangeKioskPinModel model)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/changepin", model, Method.POST);
        }

        /// <summary>
        /// Check Employee
        /// </summary>
        /// <remarks>
        /// If the specified employee has kiosk access, returns details about the employee and their current shift.
        /// </remarks>
        public void CheckEmployee(int businessId, CheckKioskEmployeeIdModel model, string kioskId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/checkid", model, Method.POST);
        }

        /// <summary>
        /// Verify Kiosk PIN
        /// </summary>
        /// <remarks>
        /// Verifies the employee's kiosk PIN. Returns error code 400 if the PIN is incorrect.
        /// </remarks>
        public void VerifyKioskPin(int businessId, CheckKioskPinModel model, string kioskId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/checkpin", model, Method.POST);
        }

        /// <summary>
        /// Clock Out Employee
        /// </summary>
        /// <remarks>
        /// Clocks out an employee from their existing shift.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public void ClockOutEmployee(int businessId, int kioskId, ClockOffModel request)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/clockoff", request, Method.POST);
        }

        /// <summary>
        /// Clock In Employee
        /// </summary>
        /// <remarks>
        /// Clocks in an employee for a new shift.
        /// </remarks>
        public void ClockInEmployee(int businessId, int kioskId, ClockOnModel request)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/clockon", request, Method.POST);
        }

        /// <summary>
        /// Discard current shift
        /// </summary>
        /// <remarks>
        /// Discards the current shift for an employee.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public void DiscardCurrentShift(int businessId, int kioskId, ClockOffModel request)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/discard", request, Method.POST);
        }

        /// <summary>
        /// Send PIN Reset Email
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by email.
        /// </remarks>
        public void SendPinResetEmail(int businessId, PinResetModel model, string kioskId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/emailreset", model, Method.POST);
        }

        /// <summary>
        /// End Break
        /// </summary>
        /// <remarks>
        /// Ends the employee's current break.
        /// </remarks>
        public void EndBreak(int businessId, int kioskId, EndBreakModel request)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/endbreak", request, Method.POST);
        }

        /// <summary>
        /// Get Employee Lookup Data
        /// </summary>
        /// <remarks>
        /// Gets relevant lookup data for an employee in relation to a kiosk.
        /// </remarks>
        public TimeAndAttendanceLookupDataModel GetEmployeeLookupData(int businessId, int employeeId, int kioskId)
        {
            return ApiRequest<TimeAndAttendanceLookupDataModel>($"/business/{businessId}/manager/kiosk/{kioskId}/lookupdata/{employeeId}");
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets all the notes for a specific shift.
        /// </remarks>
        public void GetShiftNotes(int businessId, int kioskId, int shiftId, GetShiftNotesQueryModel request)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes?employeeId={request.EmployeeId}&isAdminInitiated={request.IsAdminInitiated}&type={request.Type}&visibility={request.Visibility}");
        }

        /// <summary>
        /// Add Note to Shift
        /// </summary>
        /// <remarks>
        /// Adds a note to an existing shift.
        /// </remarks>
        public void AddNoteToShift(int businessId, int kioskId, int shiftId, AddNoteModel model)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes", model, Method.POST);
        }

        /// <summary>
        /// Delete Note from Shift
        /// </summary>
        /// <remarks>
        /// Deletes a note from an existing shift.
        /// </remarks>
        public void DeleteNoteFromShift(int businessId, int kioskId, int shiftId, int noteId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes/{noteId}", Method.DELETE);
        }

        /// <summary>
        /// Mark Shift Notes Read
        /// </summary>
        /// <remarks>
        /// Marks some shift notes as either read or unread.
        /// </remarks>
        public void MarkShiftNotesRead(int businessId, MarkNotesReadViewModel model, string kioskId, string shiftId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes/read-state", model, Method.POST);
        }

        /// <summary>
        /// Send PIN Reset SMS
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by SMS. Note that the current business must have SMS notifications enabled.
        /// </remarks>
        public void SendPinResetSms(int businessId, PinResetModel model, string kioskId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/smsreset", model, Method.POST);
        }

        /// <summary>
        /// List Kiosk Staff
        /// </summary>
        /// <remarks>
        /// Lists all the staff associated with a kiosk.
        /// </remarks>
        public List<BasicKioskEmployeeModel> ListKioskStaff(int businessId, int kioskId)
        {
            return ApiRequest<List<BasicKioskEmployeeModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/staff");
        }

        /// <summary>
        /// Add an Employee
        /// </summary>
        /// <remarks>
        /// Quickly add an employee with minimal details and kiosk enabled.
        /// </remarks>
        public void AddAnEmployee(int businessId, int kioskId, KioskCreateEmployeeModel model)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/staff", model, Method.POST);
        }

        /// <summary>
        /// Start Break
        /// </summary>
        /// <remarks>
        /// Starts a break for an employee who is clocked on for a shift.
        /// </remarks>
        public void StartBreak(int businessId, int kioskId, StartBreakModel request)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/{kioskId}/startbreak", request, Method.POST);
        }

        /// <summary>
        /// Shifts
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public List<TimeAndAttendanceShiftModel> Shifts(int businessId, GetShiftsModel model)
        {
            return ApiRequest<List<TimeAndAttendanceShiftModel>,GetShiftsModel>($"/business/{businessId}/manager/kiosk/shifts", model, Method.POST);
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
            return ApiRequest<List<TimesheetLineModel>>($"/business/{businessId}/manager/kiosk/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create kiosk timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// </remarks>
        public void CreateKioskTimesheetLine(int businessId, IndividualTimesheetLineModel request)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/timesheet", request, Method.POST);
        }

        /// <summary>
        /// Update kiosk timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// </remarks>
        public void UpdateKioskTimesheetLine(int businessId, int timesheetLineId, IndividualTimesheetLineModel request)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/timesheet/{timesheetLineId}", request, Method.PUT);
        }

        /// <summary>
        /// Update comments in a timesheet
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line with comments
        /// </remarks>
        public void UpdateCommentsInATimesheet(int businessId, TimesheetLineCommentsModel request, string timesheetLineId)
        {
            ApiRequest($"/business/{businessId}/manager/kiosk/timesheetcomments/{timesheetLineId}", request, Method.PUT);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the leave requests for this manager.
        /// </remarks>
        public List<ManagerLeaveRequestModel> ListLeaveRequests(int businessId, ListLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest?status={request.Status}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&leaveCategoryId={request.LeaveCategoryId}&locationId={request.LocationId}&employeeId={request.EmployeeId}&groupBy={request.GroupBy}&restrictOverlappingLeave={request.RestrictOverlappingLeave}");
        }

        /// <summary>
        /// List Leave Categories
        /// </summary>
        /// <remarks>
        /// Lists all of the leave categories for this business.
        /// </remarks>
        public List<ManagerLeaveCategoryModel> ListLeaveCategories(int businessId)
        {
            return ApiRequest<List<ManagerLeaveCategoryModel>>($"/business/{businessId}/manager/leaverequest/categories");
        }

        /// <summary>
        /// List Leave Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has leave permissions on.
        /// </remarks>
        public List<ManagerLeaveEmployeeModel> ListLeaveEmployees(int businessId)
        {
            return ApiRequest<List<ManagerLeaveEmployeeModel>>($"/business/{businessId}/manager/leaverequest/employees");
        }

        /// <summary>
        /// List Leave Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has leave permissions on.
        /// </remarks>
        public List<LocationModel> ListLeaveLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/leaverequest/locations");
        }

        /// <summary>
        /// Overlapping Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all the overlapping leave requests for the given date range.
        /// </remarks>
        public List<ManagerLeaveRequestModel> OverlappingLeaveRequests(int businessId, OverlappingLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<ManagerLeaveRequestModel>>($"/business/{businessId}/manager/leaverequest/overlapping?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}");
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
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/location{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Get List of Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations the manager can access.
        /// </remarks>
        public List<LocationModel> GetListOfLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/locations");
        }

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public List<RosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId, GetRosterShiftsQueryModel request)
        {
            return ApiRequest<List<RosterShiftGenerateTimesheetModel>>($"/business/{businessId}/manager/rostershift?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&shiftStatus={request.ShiftStatus}&shiftStatuses={request.ShiftStatuses}&selectedLocations={request.SelectedLocations}&selectedEmployees={request.SelectedEmployees}&selectedRoles={request.SelectedRoles}&employeeId={request.EmployeeId}&locationId={request.LocationId}&employeeGroupId={request.EmployeeGroupId}&unassignedShiftsOnly={request.UnassignedShiftsOnly}&selectAllRoles={request.SelectAllRoles}&excludeShiftsOverlappingFromDate={request.ExcludeShiftsOverlappingFromDate}&pageSize={request.PageSize}&pageNum={request.PageNum}");
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
        public RosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request)
        {
            return ApiRequest<RosterShiftMatchingResultModel>($"/business/{businessId}/manager/rostershift/{employeeId}/matchingclockoff?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}");
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
        public RosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request)
        {
            return ApiRequest<RosterShiftMatchingResultModel>($"/business/{businessId}/manager/rostershift/{employeeId}/matchingclockon?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public List<EssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request)
        {
            return ApiRequest<List<EssRosterShiftModel>>($"/business/{businessId}/manager/rostershift/{employeeId}/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Get Roster Shift by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a roster shift with the specified ID.
        /// </remarks>
        public ManagerRosterShiftModel GetRosterShiftById(int businessId, int rosterShiftId, GetRosterShiftByIdQueryModel request)
        {
            return ApiRequest<ManagerRosterShiftModel>($"/business/{businessId}/manager/rostershift/{rosterShiftId}?includeCosts={request.IncludeCosts}");
        }

        /// <summary>
        /// Stub Shift Timesheets
        /// </summary>
        /// <remarks>
        /// Generates timesheets for the roster shift with the specified ID.
        /// </remarks>
        public void StubShiftTimesheets(int businessId, int rosterShiftId, StubRosterShiftViewModel model)
        {
            ApiRequest($"/business/{businessId}/manager/rostershift/{rosterShiftId}/stub", model, Method.POST);
        }

        /// <summary>
        /// List Roster Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has roster permissions on.
        /// </remarks>
        public List<ManagerRosterEmployeeModel> ListRosterEmployees(int businessId)
        {
            return ApiRequest<List<ManagerRosterEmployeeModel>>($"/business/{businessId}/manager/rostershift/employees");
        }

        /// <summary>
        /// List Roster Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has roster permissions on.
        /// </remarks>
        public List<LocationModel> ListRosterLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/rostershift/locations");
        }

        /// <summary>
        /// Manage Roster Data
        /// </summary>
        /// <remarks>
        /// For the single date selected returns data about all published rostered shifts, published unassigned shifts,
        /// employee unavailablity, and leave requests.
        /// </remarks>
        public ManagerRosterDataModel ManageRosterData(int businessId, ManageRosterDataQueryModel request)
        {
            return ApiRequest<ManagerRosterDataModel>($"/business/{businessId}/manager/rostershift/manage?date={request.Date.ToString("yyyy-MM-ddTHH:mm:ss")}&employeeId={request.EmployeeId}&locationId={request.LocationId}&roleId={request.RoleId}&includeCosts={request.IncludeCosts}&includeSubLocations={request.IncludeSubLocations}");
        }

        /// <summary>
        /// List Manager Roster Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has manage roster permissions on.
        /// </remarks>
        public List<ManagerRosterEmployeeModel> ListManagerRosterEmployees(int businessId)
        {
            return ApiRequest<List<ManagerRosterEmployeeModel>>($"/business/{businessId}/manager/rostershift/manageemployees");
        }

        /// <summary>
        /// Get the list of roles available
        /// </summary>
        public List<RosterShiftRole> GetTheListOfRolesAvailable(int businessId)
        {
            return ApiRequest<List<RosterShiftRole>>($"/business/{businessId}/manager/rostershift/roles");
        }

        /// <summary>
        /// Get Rounding Rules
        /// </summary>
        /// <remarks>
        /// Gets the rounding rules for the business.
        /// </remarks>
        public TimesheetRoundingRulesModel GetRoundingRules(int businessId)
        {
            return ApiRequest<TimesheetRoundingRulesModel>($"/business/{businessId}/manager/roundingrules");
        }

        /// <summary>
        /// Set Rounding Rules
        /// </summary>
        /// <remarks>
        /// Sets the rounding rules for the business.
        /// </remarks>
        public void SetRoundingRules(int businessId, TimesheetRoundingRulesModel roundingRules)
        {
            ApiRequest($"/business/{businessId}/manager/roundingrules", roundingRules, Method.POST);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves timesheets for the specified business which manager can access
        /// </remarks>
        public PagedResultModel<ManagerTimesheetLineModel> GetBusinessTimesheets(int businessId, GetBusinessTimesheetsQueryModel request)
        {
            return ApiRequest<PagedResultModel<ManagerTimesheetLineModel>>($"/business/{businessId}/manager/timesheet?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&status={request.Status}&employeeId={request.EmployeeId}&employeeGroupId={request.EmployeeGroupId}&locationId={request.LocationId}&includeCosts={request.IncludeCosts}&currentPage={request.CurrentPage}&pageSize={request.PageSize}&orderBy={request.OrderBy}");
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// </remarks>
        public void CreateTimesheetLine(int businessId, IndividualTimesheetLineModel request)
        {
            ApiRequest($"/business/{businessId}/manager/timesheet", request, Method.POST);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// </remarks>
        public void UpdateTimesheetLine(int businessId, int timesheetLineId, IndividualTimesheetLineModel request)
        {
            ApiRequest($"/business/{businessId}/manager/timesheet/{timesheetLineId}", request, Method.PUT);
        }

        /// <summary>
        /// List Employee Groups
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve timesheet permissions on.
        /// </remarks>
        public List<ManagerEmployeeGroup> ListEmployeeGroups(int businessId)
        {
            return ApiRequest<List<ManagerEmployeeGroup>>($"/business/{businessId}/manager/timesheet/employeegroups");
        }

        /// <summary>
        /// List Timesheet Employees
        /// </summary>
        /// <remarks>
        /// Lists all of the employees this manager has approve timesheet permissions on.
        /// </remarks>
        public List<ManagerTimesheetEmployeeModel> ListTimesheetEmployees(int businessId)
        {
            return ApiRequest<List<ManagerTimesheetEmployeeModel>>($"/business/{businessId}/manager/timesheet/employees");
        }

        /// <summary>
        /// List Timesheet Locations
        /// </summary>
        /// <remarks>
        /// Lists all locations of employees this manager has approve timesheet permissions on.
        /// </remarks>
        public List<LocationModel> ListTimesheetLocations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/timesheet/locations");
        }

        /// <summary>
        /// Get Businesses
        /// </summary>
        /// <remarks>
        /// Returns all the businesses the user can access.
        /// </remarks>
        public List<AvailableBusinessModel> GetBusinesses()
        {
            return ApiRequest<List<AvailableBusinessModel>>($"/manager/security/businesses");
        }
    }
}
