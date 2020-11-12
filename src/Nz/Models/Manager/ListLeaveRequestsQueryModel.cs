using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Manager
{
    public class ListLeaveRequestsQueryModel
    {
        public LeaveRequestStatus? Status { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? LeaveCategoryId { get; set; }
        public int? LocationId { get; set; }
        public int? EmployeeId { get; set; }
        public LeaveRequestGroupBy GroupBy { get; set; }
        public bool RestrictOverlappingLeave { get; set; }
    }
}
