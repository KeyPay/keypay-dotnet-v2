using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class ReportAccessModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ReportAccessType AccessType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ReportEnum SpecificReports { get; set; }
        public bool NoReportingRestriction { get; set; }
    }
}
