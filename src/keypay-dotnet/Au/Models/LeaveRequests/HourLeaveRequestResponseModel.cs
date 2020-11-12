using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.LeaveRequests
{
    public class HourLeaveRequestResponseModel
    {
        public decimal TotalHours { get; set; }
        public decimal HoursApplied { get; set; }
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveCategoryId { get; set; }
        public string Employee { get; set; }
        public string LeaveCategory { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public int? AttachmentId { get; set; }
    }
}
