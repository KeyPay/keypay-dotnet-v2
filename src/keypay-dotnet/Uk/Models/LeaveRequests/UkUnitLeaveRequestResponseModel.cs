using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.LeaveRequests
{
    public class UkUnitLeaveRequestResponseModel
    {
        public decimal TotalUnits { get; set; }
        public decimal UnitsApplied { get; set; }
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveCategoryId { get; set; }
        public string Employee { get; set; }
        public string LeaveCategory { get; set; }
        public DateTime FromDate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public int? AttachmentId { get; set; }
    }
}
