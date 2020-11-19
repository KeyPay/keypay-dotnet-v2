using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class LeaveHistoryReportDetailModel
    {
        public string PayPeriod { get; set; }
        public string Notes { get; set; }
        public decimal LeaveAccrued { get; set; }
        public decimal LeaveTaken { get; set; }
    }
}
