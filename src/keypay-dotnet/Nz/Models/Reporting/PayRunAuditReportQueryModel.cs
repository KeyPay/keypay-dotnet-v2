using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class PayRunAuditReportQueryModel
    {
        public bool SingleEmployeeWorksheet { get; set; }
        public bool ShowAllSummaryDetails { get; set; }
        public bool ShowAllEmployeeDetails { get; set; }
    }
}
