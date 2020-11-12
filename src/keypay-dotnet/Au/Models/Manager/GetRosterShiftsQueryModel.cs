using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Manager
{
    public class GetRosterShiftsQueryModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public RosterShiftStatus ShiftStatus { get; set; }
        public IList<RosterShiftStatus> ShiftStatuses { get; set; }
        public IList<String> SelectedLocations { get; set; }
        public IList<String> SelectedEmployees { get; set; }
        public IList<String> SelectedRoles { get; set; }
        public int? EmployeeId { get; set; }
        public int? LocationId { get; set; }
        public int? EmployeeGroupId { get; set; }
        public bool UnassignedShiftsOnly { get; set; }
        public bool SelectAllRoles { get; set; }
        public bool ExcludeShiftsOverlappingFromDate { get; set; }
    }
}
