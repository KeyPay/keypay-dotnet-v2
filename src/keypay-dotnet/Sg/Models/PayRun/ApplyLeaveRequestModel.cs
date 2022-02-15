using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
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
