using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class UkSspApiModel
    {
        public int Id { get; set; }
        public int? WaitingDays { get; set; }
        public int QualifyingDays { get; set; }
        public bool QualifiesForSsp { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DoNotPaySspReasonEnum? DoNotPayReason { get; set; }
        public IList<DayOfWeek> Week1QualifyingDays { get; set; }
        public IList<DayOfWeek> Week2QualifyingDays { get; set; }
        public decimal? AverageWeeklyEarningsOverride { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BasicPayAdjustmentTypeEnum? BasicPayAdjustmentType { get; set; }
        public bool IsLinkedToOccupationalAbsence { get; set; }
        public int? MaximumOffsetDays { get; set; }
    }
}
