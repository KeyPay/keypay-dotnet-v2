using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class ApplyLeaveRequestResult
    {
        public IList<Int32> UpdatedPayRunTotals { get; set; }
        public IList<ApplyLeaveRequestModel> FailedLeaveRequests { get; set; }
    }
}
