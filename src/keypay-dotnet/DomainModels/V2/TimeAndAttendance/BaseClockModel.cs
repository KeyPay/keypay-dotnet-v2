using System;
using System.Collections.Generic;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.TimeAndAttendance
{
    public class BaseClockModel
    {
        public int? EmployeeId { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? KioskId { get; set; }
        public string IpAddress { get; set; }
        public byte[] Image { get; set; }
        public bool IsAdminInitiated { get; set; }

        public DateTime? RecordedTimeUtc { get; set; }
        public TimeSpan? UtcOffset { get; set; }
        public TimeAttendanceShiftNoteVisibility? NoteVisibility { get; set; }
    }
    
    public class ClockOnModel : BaseClockModel
    {
        public int? LocationId { get; set; }
        public int? ClassificationId { get; set; }
        public int? WorkTypeId { get; set; }
        public IList<int> ShiftConditionIds { get; set; }
        public string Note { get; set; }
    }
    
    public class ClockOffModel : BaseClockModel
    {
        public string Note { get; set; }
    }
    
    public class StartBreakModel : BaseClockModel
    {
    }
    
    public class EndBreakModel : BaseClockModel
    {
    }
}