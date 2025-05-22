using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Manager
{
    public class TimesheetLineModel
    {
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
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public int? AttachmentId { get; set; }
        public IList<String> ShiftConditionIds { get; set; }
        public string WorkType { get; set; }
        public string FullyQualifiedLocationName { get; set; }
        public string Classification { get; set; }
        public List<TimesheetShiftConditionModel> ShiftConditions { get; set; }
        public string HiddenComments { get; set; }
        public string SubmittedByUser { get; set; }
        public List<ReportingDimensionValueBaseApiModel> DimensionValues { get; set; }
    }
}
