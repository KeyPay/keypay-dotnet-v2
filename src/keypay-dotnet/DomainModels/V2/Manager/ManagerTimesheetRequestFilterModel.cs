using System;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerTimesheetRequestFilterModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public TimesheetLineStatus? Status { get; set; }
        public int? EmployeeId { get; set; }
        public int? EmployeeGroupId { get; set; }
        public int? LocationId { get; set; }
        public bool? IncludeCosts { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }
    }
}