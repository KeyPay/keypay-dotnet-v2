using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.LeaveRequests
{
    public class UnitLeaveRequestModel
    {
        public decimal Units { get; set; }
        public bool AutomaticallyApprove { get; set; }
        public int EmployeeId { get; set; }
        public bool RequireNotesForLeaveRequests { get; set; }
        public AttachmentModel Attachment { get; set; }
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? LeaveCategoryId { get; set; }
        public string Notes { get; set; }
    }
}
