using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class TimesheetBreakModelv3
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsPaidBreak { get; set; }
    }
}
