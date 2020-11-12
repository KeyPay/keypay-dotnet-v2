using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class IndividualTimesheetLineModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? Units { get; set; }
        public int? WorkTypeId { get; set; }
        public int? LocationId { get; set; }
        public string Comments { get; set; }
        public IList<TimesheetBreakModel> Breaks { get; set; }
        public string Status { get; set; }
        public decimal? Rate { get; set; }
        public int? LeaveCategoryId { get; set; }
        public int? PayCategoryId { get; set; }
        public int? ClassificationId { get; set; }
        public string ExternalId { get; set; }
        public ExternalService Source { get; set; }
        public int? AttachmentId { get; set; }
        public IList<Int32> ShiftConditionIds { get; set; }
        public string WorkType { get; set; }
        public string FullyQualifiedLocationName { get; set; }
        public string Classification { get; set; }
        public List<TimesheetShiftConditionModel> ShiftConditions { get; set; }
        public string HiddenComments { get; set; }
    }
}
