using System;
using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.TimeAndAttendance
{
    public class TimeAndAttendanceShiftModel
    {
        public int Id { get; set; }
        public DateTime StartTimeLocal { get; set; }
        public DateTime StartTimeUtc { get; set; }
        public DateTime? EndTimeUtc { get; set; }
        public DateTime? EndTimeLocal { get; set; }
        public int? ClassificationId { get; set; }
        public string ClassificationName { get; set; }
        public int LocationId { get; set; }
        public string LocationFullyQualifiedName { get; set; }
        public int? WorkTypeId { get; set; }
        public string WorkTypeName { get; set; }
        public int KioskId { get; set; }
        public string KioskName { get; set; }
        public int? TimesheetLineId { get; set; }
        public BasicKioskEmployeeModel Employee { get; set; }
        public IList<TimeAndAttendanceBreakModel> Breaks { get; set; }
        public IList<ShiftConditionModel> ShiftConditions { get; set; }
    }
}