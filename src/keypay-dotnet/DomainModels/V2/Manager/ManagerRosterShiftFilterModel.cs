using System;

namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerRosterShiftFilterModel
    {
        public DateTime Date { get; set; }
        public int? EmployeeId { get; set; }
        public int? LocationId { get; set; }
        public int? RoleId { get; set; }
        public bool? IncludeSubLocations { get; set; }
        public bool? IncludeCosts { get; set; }
    }
}