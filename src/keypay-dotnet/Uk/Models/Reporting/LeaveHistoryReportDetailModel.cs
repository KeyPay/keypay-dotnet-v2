using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class LeaveHistoryReportDetailModel
    {
        public string PayPeriod { get; set; }
        public string Notes { get; set; }
        public decimal LeaveAccrued { get; set; }
        public decimal LeaveTaken { get; set; }
    }
}
