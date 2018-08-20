using System;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerLeaveRequestFilterModel
    {
        public LeaveRequestStatus? Status { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? LeaveCategoryId { get; set; }
        public int? LocationId { get; set; }
        public int? EmployeeId { get; set; }
        public LeaveRequestGroupBy GroupBy { get; set; }
    }
}