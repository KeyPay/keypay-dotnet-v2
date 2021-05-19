using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Business
{
    public class ReportAccessModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ReportAccessType AccessType { get; set; }
        public string SpecificReports { get; set; }
        public bool NoReportingRestriction { get; set; }
    }
}
