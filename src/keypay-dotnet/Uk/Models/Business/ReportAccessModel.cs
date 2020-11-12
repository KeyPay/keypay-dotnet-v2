using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class ReportAccessModel
    {
        public ReportAccessType AccessType { get; set; }
        public ReportEnum SpecificReports { get; set; }
        public bool NoReportingRestriction { get; set; }
    }
}
