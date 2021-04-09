using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.RosterShift;

namespace KeyPayV2.Sg.Functions
{
    public class RosterShiftFunction : BaseFunction
    {
        public RosterShiftFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public List<SgRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId, GetRosterShiftsQueryModel request)
        {
            return ApiRequest<List<SgRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/rostershift?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&shiftStatus={request.ShiftStatus}&shiftStatuses={request.ShiftStatuses}&selectedLocations={request.SelectedLocations}&selectedEmployees={request.SelectedEmployees}&selectedRoles={request.SelectedRoles}&employeeId={request.EmployeeId}&locationId={request.LocationId}&employeeGroupId={request.EmployeeGroupId}&unassignedShiftsOnly={request.UnassignedShiftsOnly}&selectAllRoles={request.SelectAllRoles}&excludeShiftsOverlappingFromDate={request.ExcludeShiftsOverlappingFromDate}&pageSize={request.PageSize}&pageNum={request.PageNum}");
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
        public SgRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request)
        {
            return ApiRequest<SgRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockoff?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}");
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
        public SgRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request)
        {
            return ApiRequest<SgRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockon?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public List<SgEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request)
        {
            return ApiRequest<List<SgEssRosterShiftModel>>($"/business/{businessId}/rostershift/{employeeId}/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}");
        }

        /// <summary>
        /// Stub Shift Timesheets
        /// </summary>
        /// <remarks>
        /// Generates timesheets for the roster shift with the specified ID.
        /// </remarks>
        public void StubShiftTimesheets(int businessId, int rosterShiftId, StubRosterShiftViewModel model)
        {
            ApiRequest($"/business/{businessId}/rostershift/{rosterShiftId}/stub", model, Method.POST);
        }
    }
}
