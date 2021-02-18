using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Business
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
