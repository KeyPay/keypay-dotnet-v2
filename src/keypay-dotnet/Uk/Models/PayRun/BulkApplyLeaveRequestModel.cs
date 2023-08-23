using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class BulkApplyLeaveRequestModel
    {
        public List<Int32> LeaveRequestIds { get; set; }
        public bool AlignToPayRunPeriod { get; set; }
    }
}
