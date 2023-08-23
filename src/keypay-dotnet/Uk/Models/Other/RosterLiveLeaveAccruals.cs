using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class RosterLiveLeaveAccruals
    {
        public string ReferenceNumber { get; set; }
        public string LeaveCode { get; set; }
        public decimal Balance { get; set; }
    }
}
