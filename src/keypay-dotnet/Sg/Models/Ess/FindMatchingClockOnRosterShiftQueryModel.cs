using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class FindMatchingClockOnRosterShiftQueryModel
    {
        public DateTime LocalTime { get; set; }
        public bool? AllowNotEnded { get; set; }
    }
}
