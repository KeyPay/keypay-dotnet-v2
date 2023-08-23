using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Other
{
    public class RosterLiveLeaveAccruals
    {
        public string ReferenceNumber { get; set; }
        public string LeaveCode { get; set; }
        public decimal Balance { get; set; }
    }
}
