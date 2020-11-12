using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.EmploymentAgreement
{
    public class ShiftCostingsRequestShiftModel
    {
        public string State { get; set; }
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? Units { get; set; }
        public string WorkTypeId { get; set; }
        public string LocationId { get; set; }
        public string Comments { get; set; }
        public IList<TimesheetBreakModel> Breaks { get; set; }
        public string Status { get; set; }
        public decimal? Rate { get; set; }
        public string LeaveCategoryId { get; set; }
        public string PayCategoryId { get; set; }
        public string ClassificationId { get; set; }
        public string ExternalId { get; set; }
        public ExternalService Source { get; set; }
        public int? AttachmentId { get; set; }
        public IList<String> ShiftConditionIds { get; set; }
        public string WorkType { get; set; }
        public string FullyQualifiedLocationName { get; set; }
        public string Classification { get; set; }
        public List<TimesheetShiftConditionModel> ShiftConditions { get; set; }
        public string HiddenComments { get; set; }
        public string SubmittedByUser { get; set; }
    }
}
