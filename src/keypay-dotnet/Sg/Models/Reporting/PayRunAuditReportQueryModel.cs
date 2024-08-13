using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class PayRunAuditReportQueryModel
    {
        public bool SingleEmployeeWorksheet { get; set; }
        public bool ShowAllSummaryDetails { get; set; }
        public bool ShowAllEmployeeDetails { get; set; }
    }
}
