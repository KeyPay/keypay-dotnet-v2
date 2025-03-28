using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class DeprecatedPayRunAuditReportQueryModel
    {
        public bool SingleEmployeeWorksheet { get; set; }
        public bool ShowAllSummaryDetails { get; set; }
        public bool ShowAllEmployeeDetails { get; set; }
    }
}
