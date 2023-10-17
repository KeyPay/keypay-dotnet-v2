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
using KeyPayV2.Au.Models.RosterShift;

namespace KeyPayV2.Au.Functions
{
    public interface IRosterShiftFunction
    {
        List<AuRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId);
        Task<List<AuRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, CancellationToken cancellationToken = default);
        List<AuRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId, GetRosterShiftsQueryModel request);
        Task<List<AuRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, GetRosterShiftsQueryModel request, CancellationToken cancellationToken = default);
        void CreateRosterShift(int businessId, AuRosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request);
        Task CreateRosterShiftAsync(int businessId, AuRosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        AuRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request);
        Task<AuRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        AuRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request);
        Task<AuRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        List<AuEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request);
        Task<List<AuEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request, CancellationToken cancellationToken = default);
        void UpdateRosterShift(int businessId, AuRosterShiftEditModel shiftModel, int rosterShiftId, UpdateRosterShiftQueryModel request);
        Task UpdateRosterShiftAsync(int businessId, AuRosterShiftEditModel shiftModel, int rosterShiftId, UpdateRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        void StubShiftTimesheets(int businessId, int rosterShiftId, StubRosterShiftViewModel model);
        Task StubShiftTimesheetsAsync(int businessId, int rosterShiftId, StubRosterShiftViewModel model, CancellationToken cancellationToken = default);
    }
    public class RosterShiftFunction : BaseFunction, IRosterShiftFunction
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
        public List<AuRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId)
        {
            return ApiRequest<List<AuRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/rostershift", Method.Get);
        }

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public Task<List<AuRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/rostershift", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public List<AuRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId, GetRosterShiftsQueryModel request)
        {
            return ApiRequest<List<AuRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/rostershift?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&shiftStatus={request.ShiftStatus}{ConvertEnumerableToQueryString("shiftStatuses", request.ShiftStatuses?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedLocations", request.SelectedLocations?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedEmployees", request.SelectedEmployees?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedRoles", request.SelectedRoles?.Select(x => x.ToString()))}&employeeId={request.EmployeeId}&locationId={request.LocationId}&employeeGroupId={request.EmployeeGroupId}&unassignedShiftsOnly={request.UnassignedShiftsOnly}&selectAllRoles={request.SelectAllRoles}&excludeShiftsOverlappingFromDate={request.ExcludeShiftsOverlappingFromDate}&pageSize={request.PageSize}&currentPage={request.CurrentPage}&includeWarnings={request.IncludeWarnings}", Method.Get);
        }

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public Task<List<AuRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, GetRosterShiftsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/rostershift?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&shiftStatus={request.ShiftStatus}{ConvertEnumerableToQueryString("shiftStatuses", request.ShiftStatuses?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedLocations", request.SelectedLocations?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedEmployees", request.SelectedEmployees?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("selectedRoles", request.SelectedRoles?.Select(x => x.ToString()))}&employeeId={request.EmployeeId}&locationId={request.LocationId}&employeeGroupId={request.EmployeeGroupId}&unassignedShiftsOnly={request.UnassignedShiftsOnly}&selectAllRoles={request.SelectAllRoles}&excludeShiftsOverlappingFromDate={request.ExcludeShiftsOverlappingFromDate}&pageSize={request.PageSize}&currentPage={request.CurrentPage}&includeWarnings={request.IncludeWarnings}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create roster shift
        /// </summary>
        /// <remarks>
        /// Create or update an individual roster shift
        /// </remarks>
        public void CreateRosterShift(int businessId, AuRosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request)
        {
            ApiRequest($"/business/{businessId}/rostershift?publish={request.Publish}", shiftModel, Method.Post);
        }

        /// <summary>
        /// Create roster shift
        /// </summary>
        /// <remarks>
        /// Create or update an individual roster shift
        /// </remarks>
        public Task CreateRosterShiftAsync(int businessId, AuRosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/rostershift?publish={request.Publish}", shiftModel, Method.Post, cancellationToken);
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
        public AuRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request)
        {
            return ApiRequest<AuRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockoff?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
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
        public Task<AuRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockoff?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
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
        public AuRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request)
        {
            return ApiRequest<AuRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockon?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
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
        public Task<AuRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockon?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public List<AuEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request)
        {
            return ApiRequest<List<AuEssRosterShiftModel>>($"/business/{businessId}/rostershift/{employeeId}/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public Task<List<AuEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuEssRosterShiftModel>>($"/business/{businessId}/rostershift/{employeeId}/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update roster shift
        /// </summary>
        /// <remarks>
        /// Update an individual roster shift
        /// </remarks>
        public void UpdateRosterShift(int businessId, AuRosterShiftEditModel shiftModel, int rosterShiftId, UpdateRosterShiftQueryModel request)
        {
            ApiRequest($"/business/{businessId}/rostershift/{rosterShiftId}?publish={request.Publish}", shiftModel, Method.Put);
        }

        /// <summary>
        /// Update roster shift
        /// </summary>
        /// <remarks>
        /// Update an individual roster shift
        /// </remarks>
        public Task UpdateRosterShiftAsync(int businessId, AuRosterShiftEditModel shiftModel, int rosterShiftId, UpdateRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/rostershift/{rosterShiftId}?publish={request.Publish}", shiftModel, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Stub Shift Timesheets
        /// </summary>
        /// <remarks>
        /// Generates timesheets for the roster shift with the specified ID.
        /// </remarks>
        public void StubShiftTimesheets(int businessId, int rosterShiftId, StubRosterShiftViewModel model)
        {
            ApiRequest($"/business/{businessId}/rostershift/{rosterShiftId}/stub", model, Method.Post);
        }

        /// <summary>
        /// Stub Shift Timesheets
        /// </summary>
        /// <remarks>
        /// Generates timesheets for the roster shift with the specified ID.
        /// </remarks>
        public Task StubShiftTimesheetsAsync(int businessId, int rosterShiftId, StubRosterShiftViewModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/rostershift/{rosterShiftId}/stub", model, Method.Post, cancellationToken);
        }
    }
}
