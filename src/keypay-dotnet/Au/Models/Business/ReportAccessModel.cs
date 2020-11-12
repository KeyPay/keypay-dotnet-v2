using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Business
{
    public class ReportAccessModel
    {
        public ReportAccessType AccessType { get; set; }
        public ReportEnum SpecificReports { get; set; }
        public bool NoReportingRestriction { get; set; }
    }
}
