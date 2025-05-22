using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.LeaveRequests
{
    public class UkUnitLeaveRequestModel
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
