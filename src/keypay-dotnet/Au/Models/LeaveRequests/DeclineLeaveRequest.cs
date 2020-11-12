using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.LeaveRequests
{
    public class DeclineLeaveRequest
    {
        public string Reason { get; set; }
    }
}
