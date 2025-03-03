using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class PayRunCreateRequest
    {
        public int PayScheduleId { get; set; }
        public DateTime PayPeriodEnding { get; set; }
        public DateTime DatePaid { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TimesheetImportOption? TimesheetImportOption { get; set; }
        public string ExternalId { get; set; }
        public string CallbackUrl { get; set; }
        public bool? CreateWithEmptyPays { get; set; }
        public bool? Adhoc { get; set; }
        public bool? IncludeTerminatedEmployees { get; set; }
    }
}
