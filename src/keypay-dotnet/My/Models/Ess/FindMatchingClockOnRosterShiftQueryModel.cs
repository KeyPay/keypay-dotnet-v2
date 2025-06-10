using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class FindMatchingClockOnRosterShiftQueryModel
    {
        public DateTime LocalTime { get; set; }
        public bool? AllowNotEnded { get; set; }
    }
}
