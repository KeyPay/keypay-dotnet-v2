using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class UkClockOnModel
    {
        public int? LocationId { get; set; }
        public int? WorkTypeId { get; set; }
        public IList<Int32> ShiftConditionIds { get; set; }
        public string Note { get; set; }
        public IList<Int32> DimensionValueIds { get; set; }
        public int? EmployeeId { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? KioskId { get; set; }
        public string IpAddress { get; set; }
        public Byte[] Image { get; set; }
        public bool IsAdminInitiated { get; set; }
        public DateTime? RecordedTimeUtc { get; set; }
        public TimeSpan? UtcOffset { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeAttendanceShiftNoteVisibility? NoteVisibility { get; set; }
    }
}
