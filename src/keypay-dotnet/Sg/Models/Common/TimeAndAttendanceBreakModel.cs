using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class TimeAndAttendanceBreakModel
    {
        public DateTime StartTimeUtc { get; set; }
        public DateTime StartTimeLocal { get; set; }
        public DateTime? EndTimeUtc { get; set; }
        public DateTime? EndTimeLocal { get; set; }
        public bool IsPaidBreak { get; set; }
    }
}
