using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
{
    public class RosterLiveLeaveAccruals
    {
        public string ReferenceNumber { get; set; }
        public string LeaveCode { get; set; }
        public decimal Balance { get; set; }
    }
}
