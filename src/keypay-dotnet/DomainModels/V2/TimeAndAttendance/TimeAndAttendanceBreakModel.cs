using System;

namespace KeyPay.DomainModels.V2.TimeAndAttendance
{
    public class TimeAndAttendanceBreakModel
    {
        public DateTime StartTimeUtc { get; set; }
        public DateTime StartTimeLocal { get; set; }
        public DateTime? EndTimeUtc { get; set; }
        public DateTime? EndTimeLocal { get; set; }
    }
}