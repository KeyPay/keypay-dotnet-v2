using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class ApplyLeaveRequestModel
    {
        public int PayRunTotalId { get; set; }
        public int LeaveRequestId { get; set; }
        public decimal Units { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
