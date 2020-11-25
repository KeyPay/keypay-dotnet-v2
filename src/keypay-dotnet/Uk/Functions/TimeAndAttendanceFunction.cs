using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.TimeAndAttendance;

namespace KeyPayV2.Uk.Functions
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
            return ApiRequest<List<TimeAndAttendanceKioskModel>>($"/business/{businessId}/kiosk{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Create Kiosk
        /// </summary>
        /// <remarks>
        /// Creates a new kiosk for the business.
        /// </remarks>
        public void CreateKiosk(int businessId, TimeAndAttendanceKioskModel kiosk)
        {
            ApiRequest($"/business/{businessId}/kiosk", kiosk, Method.POST);
        }

        /// <summary>
        /// Get Kiosk by ID
        /// </summary>
        /// <remarks>
        /// Gets the kiosk with the specified ID.
        /// </remarks>
        public TimeAndAttendanceKioskModel GetKioskById(int businessId, int id)
        {
            return ApiRequest<TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk/{id}");
        }

        /// <summary>
        /// Update Kiosk
        /// </summary>
        /// <remarks>
        /// Updates the kiosk with the specified ID.
        /// </remarks>
        public void UpdateKiosk(int businessId, int id, TimeAndAttendanceKioskModel kiosk)
        {
            ApiRequest($"/business/{businessId}/kiosk/{id}", kiosk, Method.PUT);
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
        /// Add Complete Shift for Employee
        /// </summary>
        /// <remarks>
        /// Clocks in / out an employee for a complete shift.
        /// </remarks>
        public void AddCompleteShiftForEmployee(int businessId, int kioskId, AddShiftModel request)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/addshift", request, Method.POST);
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
        /// Check Employee
        /// </summary>
        /// <remarks>
        /// If the specified employee has kiosk access, returns details about the employee and their current shift.
        /// </remarks>
        public void CheckEmployee(int businessId, CheckKioskEmployeeIdModel model, string kioskId)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/checkid", model, Method.POST);
        }

        /// <summary>
        /// Verify Kiosk PIN
        /// </summary>
        /// <remarks>
        /// Verifies the employee's kiosk PIN. Returns error code 400 if the PIN is incorrect.
        /// </remarks>
        public void VerifyKioskPin(int businessId, CheckKioskPinModel model, string kioskId)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/checkpin", model, Method.POST);
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
        /// Clock In Employee
        /// </summary>
        /// <remarks>
        /// Clocks in an employee for a new shift.
        /// </remarks>
        public void ClockInEmployee(int businessId, int kioskId, ClockOnModel request)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/clockon", request, Method.POST);
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
        /// Get Employee Lookup Data
        /// </summary>
        /// <remarks>
        /// Gets relevant lookup data for an employee in relation to a kiosk.
        /// </remarks>
        public TimeAndAttendanceLookupDataModel GetEmployeeLookupData(int businessId, int employeeId, int kioskId)
        {
            return ApiRequest<TimeAndAttendanceLookupDataModel>($"/business/{businessId}/kiosk/{kioskId}/lookupdata/{employeeId}");
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets all the notes for a specific shift.
        /// </remarks>
        public void GetShiftNotes(int businessId, int kioskId, int shiftId, GetShiftNotesQueryModel request)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/shift/{shiftId}/notes?employeeId={request.EmployeeId}&isAdminInitiated={request.IsAdminInitiated}&type={request.Type}&visibility={request.Visibility}");
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
        /// List Kiosk Staff
        /// </summary>
        /// <remarks>
        /// Lists all the staff associated with a kiosk.
        /// </remarks>
        public List<BasicKioskEmployeeModel> ListKioskStaff(int businessId, int kioskId)
        {
            return ApiRequest<List<BasicKioskEmployeeModel>>($"/business/{businessId}/kiosk/{kioskId}/staff");
        }

        /// <summary>
        /// Add an Employee
        /// </summary>
        /// <remarks>
        /// Quickly add an employee with minimal details and kiosk enabled.
        /// </remarks>
        public void AddAnEmployee(int businessId, int kioskId, KioskCreateEmployeeModel model)
        {
            ApiRequest($"/business/{businessId}/kiosk/{kioskId}/staff", model, Method.POST);
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
        /// Employee Has Access
        /// </summary>
        /// <remarks>
        /// Check if an employee has access to a kiosk.
        /// </remarks>
        public void EmployeeHasAccess(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/kiosk/hasaccess/{employeeId}");
        }

        /// <summary>
        /// Shifts
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public List<TimeAndAttendanceShiftModel> Shifts(int businessId, GetShiftsModel model)
        {
            return ApiRequest<List<TimeAndAttendanceShiftModel>,GetShiftsModel>($"/business/{businessId}/kiosk/shifts", model, Method.POST);
        }
    }
}
