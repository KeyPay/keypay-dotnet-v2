using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class EssUnavailabilityModel
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Reason { get; set; }
        public bool Recurring { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DayOfWeek? RecurringDay { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DayOfWeekFlagsEnum? RecurringDays { get; set; }
        public string RecurringDaysCsv { get; set; }
        public bool IsAllDay { get; set; }
        public bool ViewOnly { get; set; }
    }
}
