using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayCondition
{
    public class CreateUpdatePayConditionRuleSetPeriodRequest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public RuleSetPeriodType PeriodType { get; set; }
        public DateTime? PeriodEnding { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DayOfWeek? DayOfWeekEnding { get; set; }
        public int? DayOfMonthEnding { get; set; }
        public int PayScheduleId { get; set; }
    }
}
