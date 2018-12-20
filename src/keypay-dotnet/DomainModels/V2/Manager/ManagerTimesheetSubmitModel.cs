using System;
using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerTimesheetSubmitModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public decimal? Units { get; set; }
        public int? LocationId { get; set; }
        public int? WorkTypeId { get; set; }
        public int? PayCategoryId { get; set; }
        public int? LeaveCategoryId { get; set; }
        public int? LeaveRequestId { get; set; }
        public int? ClassificationId { get; set; }
        public IList<int> ShiftConditionIds { get; set; }
        public DateTime? SubmittedStart { get; set; }
        public DateTime? SubmittedEnd { get; set; }
        public decimal? Rate { get; set; }
        public string Comments { get; set; }
        public string HiddenComments { get; set; }
        public IList<ManagerTimesheetBreakModel> Breaks { get; set; }
        public AttachmentModel Attachment { get; set; }
        public string Source { get; set; }
    }
}
