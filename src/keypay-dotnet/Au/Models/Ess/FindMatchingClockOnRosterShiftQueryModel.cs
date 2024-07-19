using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class FindMatchingClockOnRosterShiftQueryModel
    {
        public DateTime LocalTime { get; set; }
        public bool? AllowNotEnded { get; set; }
    }
}
