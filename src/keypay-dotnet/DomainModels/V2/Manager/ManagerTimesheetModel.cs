using System;
using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerTimesheetModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public DateTime? SubmittedStart { get; set; }
        public DateTime? SubmittedEnd { get; set; }
        public decimal? Units { get; set; }
        public int? WorkTypeId { get; set; }
        public string WorkType { get; set; }
        public int? LocationId { get; set; }
        public string FullyQualifiedLocationName { get; set; }
        public string Comments { get; set; }
        public List<ManagerTimesheetBreakModel> Breaks { get; set; }
        public TimesheetLineStatus Status { get; set; }
        public decimal? Rate { get; set; }
        public int? LeaveCategoryId { get; set; }
        public int? PayCategoryId { get; set; }
        public int? ClassificationId { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public int? AttachmentId { get; set; }
        public List<string> ShiftConditionIds { get; set; }
        public string Classification { get; set; }
        public List<TimesheetShiftConditionModel> ShiftConditions { get; set; }
        public string HiddenComments { get; set; }

        public int DefaultLocationId { get; set; }
        public string DefaultLocationName { get; set; }
        public int PayScheduleId { get; set; }
        public string PayScheduleName { get; set; }
        public List<ManagerEmployeeGroup> EmployeeGroups { get; set; }
        public AttachmentModel Attachment { get; set; }
        public DateTime? TerminationDate { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanViewCosts { get; set; }
        public string CostFormatted { get; set; }
        public decimal? Cost { get; set; }
    }

    public class ManagerEmployeeGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
