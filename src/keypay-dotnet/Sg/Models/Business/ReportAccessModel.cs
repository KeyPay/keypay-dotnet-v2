using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Business
{
    public class ReportAccessModel
    {
        public ReportAccessType AccessType { get; set; }
        public ReportEnum SpecificReports { get; set; }
        public bool NoReportingRestriction { get; set; }
    }
}
