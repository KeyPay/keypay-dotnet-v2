using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Unavailability
{
    public class UnavailabilitySaveModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Reason { get; set; }
        public bool Recurring { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DayOfWeek? RecurringDay { get; set; }
    }
}
