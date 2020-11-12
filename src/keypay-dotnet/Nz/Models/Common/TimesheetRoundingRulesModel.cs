using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class TimesheetRoundingRulesModel
    {
        public int Id { get; set; }
        public RoundingDirectionEnum ShiftStartRoundingDirection { get; set; }
        public int ShiftStartRoundingInterval { get; set; }
        public RoundingDirectionEnum ShiftEndRoundingDirection { get; set; }
        public int ShiftEndRoundingInterval { get; set; }
        public RoundingDirectionEnum BreakStartRoundingDirection { get; set; }
        public int BreakStartRoundingInterval { get; set; }
        public RoundingDirectionEnum BreakEndRoundingDirection { get; set; }
        public int BreakEndRoundingInterval { get; set; }
        public int? RoundUpToShiftStartTimeRoundingInterval { get; set; }
        public int? RoundDownToShiftStartTimeRoundingInterval { get; set; }
        public int? RoundUpToShiftEndTimeRoundingInterval { get; set; }
        public int? RoundDownToShiftEndTimeRoundingInterval { get; set; }
    }
}
