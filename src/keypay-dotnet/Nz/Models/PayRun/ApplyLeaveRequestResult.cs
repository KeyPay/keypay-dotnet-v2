using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class ApplyLeaveRequestResult
    {
        public IList<Int32> UpdatedPayRunTotals { get; set; }
        public IList<ApplyLeaveRequestModel> FailedLeaveRequests { get; set; }
    }
}
