using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class BasicKioskEmployeeModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public bool HasEmail { get; set; }
        public string ProfileImageUrl { get; set; }
        public bool HasProfileImage { get; set; }
        public string MobileNumber { get; set; }
        public TimeAttendanceStatus Status { get; set; }
        public bool LongShift { get; set; }
        public DateTime? ClockOnTimeUtc { get; set; }
        public DateTime? BreakStartTimeUtc { get; set; }
        public DateTime? RecordedTimeUtc { get; set; }
        public int? CurrentShiftId { get; set; }
        public IList<Int32> EmployeeGroupIds { get; set; }
    }
}
