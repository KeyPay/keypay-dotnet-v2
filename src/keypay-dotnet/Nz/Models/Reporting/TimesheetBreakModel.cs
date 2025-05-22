using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class TimesheetBreakModel
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsPaidBreak { get; set; }
    }
}
