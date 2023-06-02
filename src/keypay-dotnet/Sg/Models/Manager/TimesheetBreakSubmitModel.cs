using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Manager
{
    public class TimesheetBreakSubmitModel
    {
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public bool IsPaidBreak { get; set; }
    }
}
