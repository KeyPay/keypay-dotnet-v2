using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Employee
{
    public class StandardHoursDayModel
    {
        public int Id { get; set; }
        public int Week { get; set; }
        public int DayOfWeek { get; set; }
        public string DayName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string BreakStartTime { get; set; }
        public string BreakEndTime { get; set; }
        public int? LocationId { get; set; }
        public int? WorkTypeId { get; set; }
        public decimal Hours { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public WorkDayType? WorkDayType { get; set; }
    }
}
