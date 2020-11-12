using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class StartBreakModel
    {
        public int? EmployeeId { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? KioskId { get; set; }
        public string IpAddress { get; set; }
        public Byte[] Image { get; set; }
        public bool IsAdminInitiated { get; set; }
        public DateTime? RecordedTimeUtc { get; set; }
        public TimeSpan? UtcOffset { get; set; }
        public TimeAttendanceShiftNoteVisibility? NoteVisibility { get; set; }
    }
}
