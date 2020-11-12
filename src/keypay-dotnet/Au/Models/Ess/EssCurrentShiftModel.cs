using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class EssCurrentShiftModel
    {
        public int ShiftId { get; set; }
        public DateTime? ClockOnTimeUtc { get; set; }
        public DateTime? BreakStartTimeUtc { get; set; }
        public TimeAttendanceStatus Status { get; set; }
        public bool LongShift { get; set; }
    }
}
