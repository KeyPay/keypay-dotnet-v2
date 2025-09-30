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
using KeyPayV2.Nz.Models.RosterShift;

namespace KeyPayV2.Nz.Functions
{
    public interface IRosterShiftFunction
    {
        List<NzRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId);
        Task<List<NzRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, CancellationToken cancellationToken = default);
        List<NzRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId, GetRosterShiftsQueryModel request);
        Task<List<NzRosterShiftGenerateTimesheetModel>> GetRosterShiftsAsync(int businessId, GetRosterShiftsQueryModel request, CancellationToken cancellationToken = default);
        NzEssRosterShiftModel CreateRosterShift(int businessId, RosterShiftEditModel shiftModel);
        Task<NzEssRosterShiftModel> CreateRosterShiftAsync(int businessId, RosterShiftEditModel shiftModel, CancellationToken cancellationToken = default);
        NzEssRosterShiftModel CreateRosterShift(int businessId, RosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request);
        Task<NzEssRosterShiftModel> CreateRosterShiftAsync(int businessId, RosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        void StubShiftTimesheets(int businessId, int rosterShiftId, StubRosterShiftViewModel model);
        Task StubShiftTimesheetsAsync(int businessId, int rosterShiftId, StubRosterShiftViewModel model, CancellationToken cancellationToken = default);
        List<NzEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId);
        Task<List<NzEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        List<NzEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request);
        Task<List<NzEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request, CancellationToken cancellationToken = default);
        NzRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId);
        Task<NzRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        NzRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request);
        Task<NzRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOnRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        NzRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId);
        Task<NzRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        NzRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request);
        Task<NzRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int businessId, int employeeId, FindMatchingClockOffRosterShiftQueryModel request, CancellationToken cancellationToken = default);
        NzEssRosterShiftModel UpdateRosterShift(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel);
        Task<NzEssRosterShiftModel> UpdateRosterShiftAsync(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel, CancellationToken cancellationToken = default);
        NzEssRosterShiftModel UpdateRosterShift(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel, UpdateRosterShiftQueryModel request);
        Task<NzEssRosterShiftModel> UpdateRosterShiftAsync(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel, UpdateRosterShiftQueryModel request, CancellationToken cancellationToken = default);
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
        public List<NzRosterShiftGenerateTimesheetModel> GetRosterShifts(int businessId)
        {
            return ApiRequest<List<NzRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/rostershift", Method.Get);
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
            return ApiRequestAsync<List<NzRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/rostershift", Method.Get, cancellationToken);
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
            return ApiRequest<List<NzRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/rostershift?FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ShiftStatus={request.ShiftStatus}{ConvertEnumerableToQueryString("ShiftStatuses", request.ShiftStatuses?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("SelectedLocations", request.SelectedLocations?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("SelectedEmployees", request.SelectedEmployees?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("SelectedRoles", request.SelectedRoles?.Select(x => x.ToString()))}&EmployeeId={request.EmployeeId}&LocationId={request.LocationId}&EmployeeGroupId={request.EmployeeGroupId}&UnassignedShiftsOnly={request.UnassignedShiftsOnly}&SelectAllRoles={request.SelectAllRoles}&ExcludeShiftsOverlappingFromDate={request.ExcludeShiftsOverlappingFromDate}&PageSize={request.PageSize}&CurrentPage={request.CurrentPage}&IncludeWarnings={request.IncludeWarnings}", Method.Get);
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
            return ApiRequestAsync<List<NzRosterShiftGenerateTimesheetModel>>($"/business/{businessId}/rostershift?FromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ToDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&ShiftStatus={request.ShiftStatus}{ConvertEnumerableToQueryString("ShiftStatuses", request.ShiftStatuses?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("SelectedLocations", request.SelectedLocations?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("SelectedEmployees", request.SelectedEmployees?.Select(x => x.ToString()))}{ConvertEnumerableToQueryString("SelectedRoles", request.SelectedRoles?.Select(x => x.ToString()))}&EmployeeId={request.EmployeeId}&LocationId={request.LocationId}&EmployeeGroupId={request.EmployeeGroupId}&UnassignedShiftsOnly={request.UnassignedShiftsOnly}&SelectAllRoles={request.SelectAllRoles}&ExcludeShiftsOverlappingFromDate={request.ExcludeShiftsOverlappingFromDate}&PageSize={request.PageSize}&CurrentPage={request.CurrentPage}&IncludeWarnings={request.IncludeWarnings}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create roster shift
        /// </summary>
        /// <remarks>
        /// Create or update an individual roster shift
        /// </remarks>
        public NzEssRosterShiftModel CreateRosterShift(int businessId, RosterShiftEditModel shiftModel)
        {
            return ApiRequest<NzEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift", shiftModel, Method.Post);
        }

        /// <summary>
        /// Create roster shift
        /// </summary>
        /// <remarks>
        /// Create or update an individual roster shift
        /// </remarks>
        public Task<NzEssRosterShiftModel> CreateRosterShiftAsync(int businessId, RosterShiftEditModel shiftModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift", shiftModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Create roster shift
        /// </summary>
        /// <remarks>
        /// Create or update an individual roster shift
        /// </remarks>
        public NzEssRosterShiftModel CreateRosterShift(int businessId, RosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request)
        {
            return ApiRequest<NzEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift?publish={request.Publish}", shiftModel, Method.Post);
        }

        /// <summary>
        /// Create roster shift
        /// </summary>
        /// <remarks>
        /// Create or update an individual roster shift
        /// </remarks>
        public Task<NzEssRosterShiftModel> CreateRosterShiftAsync(int businessId, RosterShiftEditModel shiftModel, CreateRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift?publish={request.Publish}", shiftModel, Method.Post, cancellationToken);
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
        public List<NzEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId)
        {
            return ApiRequest<List<NzEssRosterShiftModel>>($"/business/{businessId}/rostershift/{employeeId}/nearby", Method.Get);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public Task<List<NzEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzEssRosterShiftModel>>($"/business/{businessId}/rostershift/{employeeId}/nearby", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public List<NzEssRosterShiftModel> FindNearbyRosterShifts(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request)
        {
            return ApiRequest<List<NzEssRosterShiftModel>>($"/business/{businessId}/rostershift/{employeeId}/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public Task<List<NzEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int businessId, int employeeId, FindNearbyRosterShiftsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzEssRosterShiftModel>>($"/business/{businessId}/rostershift/{employeeId}/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
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
        public NzRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int businessId, int employeeId)
        {
            return ApiRequest<NzRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockon", Method.Get);
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
        public Task<NzRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockon", Method.Get, cancellationToken);
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
            return ApiRequest<NzRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockon?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
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
            return ApiRequestAsync<NzRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockon?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
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
        public NzRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int businessId, int employeeId)
        {
            return ApiRequest<NzRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockoff", Method.Get);
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
        public Task<NzRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockoff", Method.Get, cancellationToken);
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
            return ApiRequest<NzRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockoff?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get);
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
            return ApiRequestAsync<NzRosterShiftMatchingResultModel>($"/business/{businessId}/rostershift/{employeeId}/matchingclockoff?kioskId={request.KioskId}&dateUtc={request.DateUtc.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update roster shift
        /// </summary>
        /// <remarks>
        /// Update an individual roster shift
        /// </remarks>
        public NzEssRosterShiftModel UpdateRosterShift(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel)
        {
            return ApiRequest<NzEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift/{rosterShiftId}", shiftModel, Method.Put);
        }

        /// <summary>
        /// Update roster shift
        /// </summary>
        /// <remarks>
        /// Update an individual roster shift
        /// </remarks>
        public Task<NzEssRosterShiftModel> UpdateRosterShiftAsync(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift/{rosterShiftId}", shiftModel, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Update roster shift
        /// </summary>
        /// <remarks>
        /// Update an individual roster shift
        /// </remarks>
        public NzEssRosterShiftModel UpdateRosterShift(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel, UpdateRosterShiftQueryModel request)
        {
            return ApiRequest<NzEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift/{rosterShiftId}?publish={request.Publish}&clearBreaks={request.ClearBreaks}", shiftModel, Method.Put);
        }

        /// <summary>
        /// Update roster shift
        /// </summary>
        /// <remarks>
        /// Update an individual roster shift
        /// </remarks>
        public Task<NzEssRosterShiftModel> UpdateRosterShiftAsync(int businessId, int rosterShiftId, RosterShiftEditModel shiftModel, UpdateRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzEssRosterShiftModel,RosterShiftEditModel>($"/business/{businessId}/rostershift/{rosterShiftId}?publish={request.Publish}&clearBreaks={request.ClearBreaks}", shiftModel, Method.Put, cancellationToken);
        }
    }
}
