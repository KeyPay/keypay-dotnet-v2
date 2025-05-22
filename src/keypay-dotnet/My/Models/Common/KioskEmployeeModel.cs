using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class KioskEmployeeModel
    {
        public bool PinExpired { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public bool HasEmail { get; set; }
        public string ProfileImageUrl { get; set; }
        public string MobileNumber { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeAttendanceStatus Status { get; set; }
        public bool LongShift { get; set; }
        public DateTime? ClockOnTimeUtc { get; set; }
        public DateTime? BreakStartTimeUtc { get; set; }
        public DateTime? RecordedTimeUtc { get; set; }
        public int? CurrentShiftId { get; set; }
        public IList<Int32> EmployeeGroupIds { get; set; }
        public DateTime? EmployeeStartDate { get; set; }
    }
}
