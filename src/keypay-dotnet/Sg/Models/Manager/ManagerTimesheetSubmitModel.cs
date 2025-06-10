using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Manager
{
    public class ManagerTimesheetSubmitModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int? LocationId { get; set; }
        public int? WorkTypeId { get; set; }
        public int? PayCategoryId { get; set; }
        public int? LeaveCategoryId { get; set; }
        public int? LeaveRequestId { get; set; }
        public int? ClassificationId { get; set; }
        public IList<Int32> ShiftConditionIds { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public DateTime? SubmittedStart { get; set; }
        public DateTime? SubmittedEnd { get; set; }
        public decimal? Units { get; set; }
        public decimal? Rate { get; set; }
        public string Comments { get; set; }
        public string HiddenComments { get; set; }
        public IList<TimesheetBreakSubmitModel> Breaks { get; set; }
        public Attachment Attachment { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService? Source { get; set; }
        public bool LocationIsDeleted { get; set; }
        public IList<Int32> DimensionValueIds { get; set; }
    }
}
