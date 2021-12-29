using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.TimeAndAttendance;

namespace KeyPayV2.My.Functions
{
    public class TimeAndAttendanceFunction : BaseFunction
    {
        public TimeAndAttendanceFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Kiosks
        /// </summary>
        /// <remarks>
        /// Lists all kiosks for the specified business.
        /// This operation supports OData queries.
        /// </remarks>
        public List<TimeAndAttendanceKioskModel> ListKiosks(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<TimeAndAttendanceKioskModel>>($"/business/{businessId}/kiosk{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
        }

        /// <summary>
        /// List Kiosks
        /// </summary>
        /// <remarks>
        /// Lists all kiosks for the specified business.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<TimeAndAttendanceKioskModel>> ListKiosksAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TimeAndAttendanceKioskModel>>($"/business/{businessId}/kiosk{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Kiosk
        /// </summary>
        /// <remarks>
        /// Creates a new kiosk for the business.
        /// </remarks>
        public TimeAndAttendanceKioskModel CreateKiosk(int businessId, TimeAndAttendanceKioskModel kiosk)
        {
            return ApiRequest<TimeAndAttendanceKioskModel,TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk", kiosk, Method.POST);
        }

        /// <summary>
        /// Create Kiosk
        /// </summary>
        /// <remarks>
        /// Creates a new kiosk for the business.
        /// </remarks>
        public Task<TimeAndAttendanceKioskModel> CreateKioskAsync(int businessId, TimeAndAttendanceKioskModel kiosk, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TimeAndAttendanceKioskModel,TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk", kiosk, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Kiosk by ID
        /// </summary>
        /// <remarks>
        /// Gets the kiosk with the specified ID.
        /// </remarks>
        public TimeAndAttendanceKioskModel GetKioskById(int businessId, int id)
        {
            return ApiRequest<TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk/{id}", Method.GET);
        }

        /// <summary>
        /// Get Kiosk by ID
        /// </summary>
        /// <remarks>
        /// Gets the kiosk with the specified ID.
        /// </remarks>
        public Task<TimeAndAttendanceKioskModel> GetKioskByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Kiosk
        /// </summary>
        /// <remarks>
        /// Updates the kiosk with the specified ID.
        /// </remarks>
        public TimeAndAttendanceKioskModel UpdateKiosk(int businessId, int id, TimeAndAttendanceKioskModel kiosk)
        {
            return ApiRequest<TimeAndAttendanceKioskModel,TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk/{id}", kiosk, Method.PUT);
        }

        /// <summary>
        /// Update Kiosk
        /// </summary>
        /// <remarks>
        /// Updates the kiosk with the specified ID.
        /// </remarks>
        public Task<TimeAndAttendanceKioskModel> UpdateKioskAsync(int businessId, int id, TimeAndAttendanceKioskModel kiosk, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TimeAndAttendanceKioskModel,TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk/{id}", kiosk, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Kiosk
        /// </summary>
        /// <remarks>
        /// Deletes the kiosk with the specified ID.
        /// </remarks>
        public void DeleteKiosk(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/kiosk/{id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Kiosk
        /// </summary>
        /// <remarks>
        /// Deletes the kiosk with the specified ID.
        /// </remarks>
        public Task DeleteKioskAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Add Complete Shift for Employee
        /// </summary>
        /// <remarks>
        /// Clocks in / out an employee for a complete shift.
        /// </remarks>
        public void AddCompleteShiftForEmployee(int businessId, int kioskId, AuAddShiftModel model)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/addshift", model, Method.POST);
        }

        /// <summary>
        /// Add Complete Shift for Employee
        /// </summary>
        /// <remarks>
        /// Clocks in / out an employee for a complete shift.
        /// </remarks>
        public Task AddCompleteShiftForEmployeeAsync(int businessId, int kioskId, AuAddShiftModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/addshift", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Change PIN
        /// </summary>
        /// <remarks>
        /// Changes the kiosk PIN for an employee, given their old PIN.
        /// </remarks>
        public void ChangePin(int businessId, int kioskId, ChangeKioskPinModel model)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/changepin", model, Method.POST);
        }

        /// <summary>
        /// Change PIN
        /// </summary>
        /// <remarks>
        /// Changes the kiosk PIN for an employee, given their old PIN.
        /// </remarks>
        public Task ChangePinAsync(int businessId, int kioskId, ChangeKioskPinModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/changepin", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Check Employee
        /// </summary>
        /// <remarks>
        /// If the specified employee has kiosk access, returns details about the employee and their current shift.
        /// </remarks>
        public void CheckEmployee(int businessId, BasicKioskEmployeeModel model, string kioskId)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/checkid", model, Method.POST);
        }

        /// <summary>
        /// Check Employee
        /// </summary>
        /// <remarks>
        /// If the specified employee has kiosk access, returns details about the employee and their current shift.
        /// </remarks>
        public Task CheckEmployeeAsync(int businessId, BasicKioskEmployeeModel model, string kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/checkid", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Verify Kiosk PIN
        /// </summary>
        /// <remarks>
        /// Verifies the employee's kiosk PIN. Returns error code 400 if the PIN is incorrect.
        /// </remarks>
        public KioskEmployeeModel VerifyKioskPin(int businessId, CheckKioskPinModel model, string kioskId)
        {
            return ApiRequest<KioskEmployeeModel,CheckKioskPinModel>($"/business/{businessId}/kiosk/{kioskId}/checkpin", model, Method.POST);
        }

        /// <summary>
        /// Verify Kiosk PIN
        /// </summary>
        /// <remarks>
        /// Verifies the employee's kiosk PIN. Returns error code 400 if the PIN is incorrect.
        /// </remarks>
        public Task<KioskEmployeeModel> VerifyKioskPinAsync(int businessId, CheckKioskPinModel model, string kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,CheckKioskPinModel>($"/business/{businessId}/kiosk/{kioskId}/checkpin", model, Method.POST, cancellationToken);
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
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/clockoff", request, Method.POST);
        }

        /// <summary>
        /// Clock Out Employee
        /// </summary>
        /// <remarks>
        /// Clocks out an employee from their existing shift.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public Task ClockOutEmployeeAsync(int businessId, int kioskId, ClockOffModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/clockoff", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Clock In Employee
        /// </summary>
        /// <remarks>
        /// Clocks in an employee for a new shift.
        /// </remarks>
        public void ClockInEmployee(int businessId, int kioskId, AuClockOnModel model)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/clockon", model, Method.POST);
        }

        /// <summary>
        /// Clock In Employee
        /// </summary>
        /// <remarks>
        /// Clocks in an employee for a new shift.
        /// </remarks>
        public Task ClockInEmployeeAsync(int businessId, int kioskId, AuClockOnModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/clockon", model, Method.POST, cancellationToken);
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
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/discard", request, Method.POST);
        }

        /// <summary>
        /// Discard current shift
        /// </summary>
        /// <remarks>
        /// Discards the current shift for an employee.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public Task DiscardCurrentShiftAsync(int businessId, int kioskId, ClockOffModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/discard", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Send PIN Reset Email
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by email.
        /// </remarks>
        public void SendPinResetEmail(int businessId, PinResetModel model, string kioskId)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/emailreset", model, Method.POST);
        }

        /// <summary>
        /// Send PIN Reset Email
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by email.
        /// </remarks>
        public Task SendPinResetEmailAsync(int businessId, PinResetModel model, string kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/emailreset", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// End Break
        /// </summary>
        /// <remarks>
        /// Ends the employee's current break.
        /// </remarks>
        public void EndBreak(int businessId, int kioskId, EndBreakModel request)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/endbreak", request, Method.POST);
        }

        /// <summary>
        /// End Break
        /// </summary>
        /// <remarks>
        /// Ends the employee's current break.
        /// </remarks>
        public Task EndBreakAsync(int businessId, int kioskId, EndBreakModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/endbreak", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employee Lookup Data
        /// </summary>
        /// <remarks>
        /// Gets relevant lookup data for an employee in relation to a kiosk.
        /// </remarks>
        public MyTimeAndAttendanceLookupDataModel GetEmployeeLookupData(int businessId, int employeeId, int kioskId)
        {
            return ApiRequest<MyTimeAndAttendanceLookupDataModel>($"/business/{businessId}/kiosk/{kioskId}/lookupdata/{employeeId}", Method.GET);
        }

        /// <summary>
        /// Get Employee Lookup Data
        /// </summary>
        /// <remarks>
        /// Gets relevant lookup data for an employee in relation to a kiosk.
        /// </remarks>
        public Task<MyTimeAndAttendanceLookupDataModel> GetEmployeeLookupDataAsync(int businessId, int employeeId, int kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyTimeAndAttendanceLookupDataModel>($"/business/{businessId}/kiosk/{kioskId}/lookupdata/{employeeId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets all the notes for a specific shift.
        /// </remarks>
        public void GetShiftNotes(int businessId, int kioskId, int shiftId, GetShiftNotesQueryModel request)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/shift/{shiftId}/notes?employeeId={request.EmployeeId}&isAdminInitiated={request.IsAdminInitiated}&type={request.Type}&visibility={request.Visibility}", Method.GET);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets all the notes for a specific shift.
        /// </remarks>
        public Task GetShiftNotesAsync(int businessId, int kioskId, int shiftId, GetShiftNotesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/shift/{shiftId}/notes?employeeId={request.EmployeeId}&isAdminInitiated={request.IsAdminInitiated}&type={request.Type}&visibility={request.Visibility}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Add Note to Shift
        /// </summary>
        /// <remarks>
        /// Adds a note to an existing shift.
        /// </remarks>
        public void AddNoteToShift(int businessId, int kioskId, int shiftId, AddNoteModel model)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/shift/{shiftId}/notes", model, Method.POST);
        }

        /// <summary>
        /// Add Note to Shift
        /// </summary>
        /// <remarks>
        /// Adds a note to an existing shift.
        /// </remarks>
        public Task AddNoteToShiftAsync(int businessId, int kioskId, int shiftId, AddNoteModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/shift/{shiftId}/notes", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Note from Shift
        /// </summary>
        /// <remarks>
        /// Deletes a note from an existing shift.
        /// </remarks>
        public void DeleteNoteFromShift(int businessId, int kioskId, int shiftId, int noteId)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/shift/{shiftId}/notes/{noteId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Note from Shift
        /// </summary>
        /// <remarks>
        /// Deletes a note from an existing shift.
        /// </remarks>
        public Task DeleteNoteFromShiftAsync(int businessId, int kioskId, int shiftId, int noteId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/shift/{shiftId}/notes/{noteId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Mark Shift Notes Read
        /// </summary>
        /// <remarks>
        /// Marks some shift notes as either read or unread.
        /// </remarks>
        public void MarkShiftNotesRead(int businessId, MarkNotesReadViewModel model, string kioskId, string shiftId)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/shift/{shiftId}/notes/read-state", model, Method.POST);
        }

        /// <summary>
        /// Mark Shift Notes Read
        /// </summary>
        /// <remarks>
        /// Marks some shift notes as either read or unread.
        /// </remarks>
        public Task MarkShiftNotesReadAsync(int businessId, MarkNotesReadViewModel model, string kioskId, string shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/shift/{shiftId}/notes/read-state", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Send PIN Reset SMS
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by SMS. Note that the current business must have SMS notifications enabled.
        /// </remarks>
        public void SendPinResetSms(int businessId, PinResetModel model, string kioskId)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/smsreset", model, Method.POST);
        }

        /// <summary>
        /// Send PIN Reset SMS
        /// </summary>
        /// <remarks>
        /// Sends kiosk PIN reset instructions to an employee by SMS. Note that the current business must have SMS notifications enabled.
        /// </remarks>
        public Task SendPinResetSmsAsync(int businessId, PinResetModel model, string kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/smsreset", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// List Kiosk Staff
        /// </summary>
        /// <remarks>
        /// Lists all the staff associated with a kiosk.
        /// </remarks>
        public List<BasicKioskEmployeeModel> ListKioskStaff(int businessId, int kioskId)
        {
            return ApiRequest<List<BasicKioskEmployeeModel>>($"/business/{businessId}/kiosk/{kioskId}/staff", Method.GET);
        }

        /// <summary>
        /// List Kiosk Staff
        /// </summary>
        /// <remarks>
        /// Lists all the staff associated with a kiosk.
        /// </remarks>
        public Task<List<BasicKioskEmployeeModel>> ListKioskStaffAsync(int businessId, int kioskId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BasicKioskEmployeeModel>>($"/business/{businessId}/kiosk/{kioskId}/staff", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Add an Employee
        /// </summary>
        /// <remarks>
        /// Quickly add an employee with minimal details and kiosk enabled.
        /// </remarks>
        public BasicKioskEmployeeModel AddAnEmployee(int businessId, int kioskId, KioskCreateEmployeeModel model)
        {
            return ApiRequest<BasicKioskEmployeeModel,KioskCreateEmployeeModel>($"/business/{businessId}/kiosk/{kioskId}/staff", model, Method.POST);
        }

        /// <summary>
        /// Add an Employee
        /// </summary>
        /// <remarks>
        /// Quickly add an employee with minimal details and kiosk enabled.
        /// </remarks>
        public Task<BasicKioskEmployeeModel> AddAnEmployeeAsync(int businessId, int kioskId, KioskCreateEmployeeModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<BasicKioskEmployeeModel,KioskCreateEmployeeModel>($"/business/{businessId}/kiosk/{kioskId}/staff", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Start Break
        /// </summary>
        /// <remarks>
        /// Starts a break for an employee who is clocked on for a shift.
        /// </remarks>
        public void StartBreak(int businessId, int kioskId, StartBreakModel request)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/startbreak", request, Method.POST);
        }

        /// <summary>
        /// Start Break
        /// </summary>
        /// <remarks>
        /// Starts a break for an employee who is clocked on for a shift.
        /// </remarks>
        public Task StartBreakAsync(int businessId, int kioskId, StartBreakModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/{kioskId}/startbreak", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Employee Has Access
        /// </summary>
        /// <remarks>
        /// Check if an employee has access to a kiosk.
        /// </remarks>
        public void EmployeeHasAccess(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/kiosk/hasaccess/{employeeId}", Method.GET);
        }

        /// <summary>
        /// Employee Has Access
        /// </summary>
        /// <remarks>
        /// Check if an employee has access to a kiosk.
        /// </remarks>
        public Task EmployeeHasAccessAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/kiosk/hasaccess/{employeeId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Shifts
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public List<MyTimeAndAttendanceShiftModel> Shifts(int businessId, GetShiftsModel model)
        {
            return ApiRequest<List<MyTimeAndAttendanceShiftModel>,GetShiftsModel>($"/business/{businessId}/kiosk/shifts", model, Method.POST);
        }

        /// <summary>
        /// Shifts
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public Task<List<MyTimeAndAttendanceShiftModel>> ShiftsAsync(int businessId, GetShiftsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyTimeAndAttendanceShiftModel>,GetShiftsModel>($"/business/{businessId}/kiosk/shifts", model, Method.POST, cancellationToken);
        }
    }
}
