using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class SgTimeAndAttendanceShiftModel
    {
        public int Id { get; set; }
        public DateTime StartTimeLocal { get; set; }
        public DateTime StartTimeUtc { get; set; }
        public DateTime? EndTimeUtc { get; set; }
        public DateTime? EndTimeLocal { get; set; }
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
        public List<ReportingDimensionValueBaseApiModel> DimensionValues { get; set; }
    }
}
