using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class BulkApplyLeaveRequestModel
    {
        public List<Int32> LeaveRequestIds { get; set; }
        public bool AlignToPayRunPeriod { get; set; }
    }
}
