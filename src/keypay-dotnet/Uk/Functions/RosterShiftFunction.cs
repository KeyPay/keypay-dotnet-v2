using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.RosterShift;

namespace KeyPayV2.Uk.Functions
{
    public interface IRosterShiftFunction
    {
        List<UkRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId);
        Task<List<UkRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, CancellationToken cancellationToken = default);
        List<UkRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId, GetRosterShiftsQueryModel request);
        Task<List<UkRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, GetRosterShiftsQueryModel request, CancellationToken cancellationToken = default);
        UkEssRosterShiftModel CreateRosterShift(int businessId, RosterShiftEditModel shiftModel);
        Task<UkEssRosterShiftModel> CreateRosterShiftAsync(int businessId, RosterShiftEditModel shiftModel, CancellationToken cancellationToken = default);
        UkEssRosterShiftModel CreateRosterShift(int businessId, RosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request);
        Task<UkEssRosterShiftModel> CreateRosterShiftAsync(int businessId, RosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        void StubShiftTimesheets(int businessId, int rosterShiftId, StubRosterShiftViewModel model);
        Task StubShiftTimesheetsAsync(int businessId, int rosterShiftId, StubRosterShiftViewModel model, CancellationToken cancellationToken = default);
        List<UkEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId);
        Task<List<UkEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<UkEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request);
        Task<List<UkEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request, CancellationToken cancellationToken = default);
        UkRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId);
        Task<UkRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        UkRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request);
        Task<UkRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        UkRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId);
        Task<UkRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        UkRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request);
        Task<UkRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        UkEssRosterShiftModel UpdateRosterShift(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel);
        Task<UkEssRosterShiftModel> UpdateRosterShiftAsync(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel, CancellationToken cancellationToken = default);
        UkEssRosterShiftModel UpdateRosterShift(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel, UpdateRosterShiftQueryModel request);
        Task<UkEssRosterShiftModel> UpdateRosterShiftAsync(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel, UpdateRosterShiftQueryModel request, CancellationToken cancellationToken = default);
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
        public List<UkRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId)
        {
            return ApiRequest<List<UkRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/rostershift", Method.Get);
        }

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public Task<List<UkRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/rostershift", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public List<UkRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId, GetRosterShiftsQueryModel request)
        {
            return ApiRequest<List<UkRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/rostershift?FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ShiftStatus={request.ShiftStatus}{ConvertEnumerableToQueryString("ShiftStatuses", request.ShiftStatuses?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("SelectedLocations", request.SelectedLocations?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("SelectedEmployees", request.SelectedEmployees?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("SelectedRoles", request.SelectedRoles?.Select(x => x.ToString()))}&EmployeeId={request.EmployeeId}&LocationId={request.LocationId}&EmployeeGroupId={request.EmployeeGroupId}&UnassignedShiftsOnly={request.UnassignedShiftsOnly}&SelectAllRoles={request.SelectAllRoles}&ExcludeShiftsOverlappingFromDate={request.ExcludeShiftsOverlappingFromDate}&PageSize={request.PageSize}&CurrentPage={request.CurrentPage}&IncludeWarnings={request.IncludeWarnings}", Method.Get);
        }

        /// <summary>
        /// Get Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets roster shifts, optionally filtered by a number of parameters. Query parameters 'fromDate' and 'toDate' are required.
        /// NOTE: By default, only shifts with no role assigned are returned. To return shifts with roles, either specify some SelectedRoles,
        /// or specify SelectAllRoles = true.
        /// </remarks>
        public Task<List<UkRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, GetRosterShiftsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/rostershift?FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ShiftStatus={request.ShiftStatus}{ConvertEnumerableToQueryString("ShiftStatuses", request.ShiftStatuses?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("SelectedLocations", request.SelectedLocations?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("SelectedEmployees", request.SelectedEmployees?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("SelectedRoles", request.SelectedRoles?.Select(x => x.ToString()))}&EmployeeId={request.EmployeeId}&LocationId={request.LocationId}&EmployeeGroupId={request.EmployeeGroupId}&UnassignedShiftsOnly={request.UnassignedShiftsOnly}&SelectAllRoles={request.SelectAllRoles}&ExcludeShiftsOverlappingFromDate={request.ExcludeShiftsOverlappingFromDate}&PageSize={request.PageSize}&CurrentPage={request.CurrentPage}&IncludeWarnings={request.IncludeWarnings}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create roster shift
        /// </summary>
        /// <remarks>
        /// Create or update an individual roster shift
        /// </remarks>
        public UkEssRosterShiftModel CreateRosterShift(int businessId, RosterShiftEditModel shiftModel)
        {
            return ApiRequest<UkEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift", shiftModel, Method.Post);
        }

        /// <summary>
        /// Create roster shift
        /// </summary>
        /// <remarks>
        /// Create or update an individual roster shift
        /// </remarks>
        public Task<UkEssRosterShiftModel> CreateRosterShiftAsync(int businessId, RosterShiftEditModel shiftModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift", shiftModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Create roster shift
        /// </summary>
        /// <remarks>
        /// Create or update an individual roster shift
        /// </remarks>
        public UkEssRosterShiftModel CreateRosterShift(int businessId, RosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request)
        {
            return ApiRequest<UkEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift?publish={request.Publish}", shiftModel, Method.Post);
        }

        /// <summary>
        /// Create roster shift
        /// </summary>
        /// <remarks>
        /// Create or update an individual roster shift
        /// </remarks>
        public Task<UkEssRosterShiftModel> CreateRosterShiftAsync(int businessId, RosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift?publish={request.Publish}", shiftModel, Method.Post, cancellationToken);
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

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public List<UkEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId)
        {
            return ApiRequest<List<UkEssRosterShiftModel>>($"/business/{businessId}/rostershift/{employeeId}/nearby", Method.Get);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public Task<List<UkEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkEssRosterShiftModel>>($"/business/{businessId}/rostershift/{employeeId}/nearby", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public List<UkEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request)
        {
            return ApiRequest<List<UkEssRosterShiftModel>>($"/business/{businessId}/rostershift/{employeeId}/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public Task<List<UkEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkEssRosterShiftModel>>($"/business/{businessId}/rostershift/{employeeId}/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
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
        public UkRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId)
        {
            return ApiRequest<UkRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockon", Method.Get);
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
        public Task<UkRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockon", Method.Get, cancellationToken);
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
        public UkRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request)
        {
            return ApiRequest<UkRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockon?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
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
        public Task<UkRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockon?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
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
        public UkRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId)
        {
            return ApiRequest<UkRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockoff", Method.Get);
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
        public Task<UkRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockoff", Method.Get, cancellationToken);
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
        public UkRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request)
        {
            return ApiRequest<UkRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockoff?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
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
        public Task<UkRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockoff?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update roster shift
        /// </summary>
        /// <remarks>
        /// Update an individual roster shift
        /// </remarks>
        public UkEssRosterShiftModel UpdateRosterShift(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel)
        {
            return ApiRequest<UkEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift/{rosterShiftId}", shiftModel, Method.Put);
        }

        /// <summary>
        /// Update roster shift
        /// </summary>
        /// <remarks>
        /// Update an individual roster shift
        /// </remarks>
        public Task<UkEssRosterShiftModel> UpdateRosterShiftAsync(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift/{rosterShiftId}", shiftModel, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Update roster shift
        /// </summary>
        /// <remarks>
        /// Update an individual roster shift
        /// </remarks>
        public UkEssRosterShiftModel UpdateRosterShift(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel, UpdateRosterShiftQueryModel request)
        {
            return ApiRequest<UkEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift/{rosterShiftId}?publish={request.Publish}&clearBreaks={request.ClearBreaks}", shiftModel, Method.Put);
        }

        /// <summary>
        /// Update roster shift
        /// </summary>
        /// <remarks>
        /// Update an individual roster shift
        /// </remarks>
        public Task<UkEssRosterShiftModel> UpdateRosterShiftAsync(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel, UpdateRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift/{rosterShiftId}?publish={request.Publish}&clearBreaks={request.ClearBreaks}", shiftModel, Method.Put, cancellationToken);
        }
    }
}
