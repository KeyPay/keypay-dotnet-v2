using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Timesheets
{
    public class MyTimesheetLineModel
    {
        public bool LocationIsDeleted { get; set; }
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? Units { get; set; }
        public string WorkTypeId { get; set; }
        public string LocationId { get; set; }
        public string Comments { get; set; }
        public IList<TimesheetBreakModelv3> Breaks { get; set; }
        public string Status { get; set; }
        public decimal? Rate { get; set; }
        public string LeaveCategoryId { get; set; }
        public string PayCategoryId { get; set; }
        public string ExternalId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public int? AttachmentId { get; set; }
        public IList<String> ShiftConditionIds { get; set; }
        public string WorkType { get; set; }
        public string FullyQualifiedLocationName { get; set; }
        public List<TimesheetShiftConditionModelv3> ShiftConditions { get; set; }
        public string HiddenComments { get; set; }
        public Attachment Attachment { get; set; }
        public string SubmittedByUser { get; set; }
        public IList<Int32> DimensionValueIds { get; set; }
    }
}
