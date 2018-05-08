using System;
using System.Collections.Generic;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Business
{
    public class RosterShiftFilterModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public IList<RosterShiftStatus> ShiftStatuses { get; set; }
        public IList<string> SelectedLocations { get; set; }
        public IList<string> SelectedEmployees { get; set; }
        public IList<string> SelectedRoles { get; set; }
        public int? EmployeeId { get; set; }
        public int? LocationId { get; set; }
        public int? EmployeeGroupId { get; set; }
        public bool UnassignedShiftsOnly { get; set; }
        public bool SelectAllRoles { get; set; }
    }
}