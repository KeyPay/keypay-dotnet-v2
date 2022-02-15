using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class BulkApplyLeaveRequestModel
    {
        public List<Int32> LeaveRequestIds { get; set; }
    }
}
