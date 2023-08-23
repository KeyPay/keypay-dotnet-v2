using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class TimesheetRoundingRulesModel
    {
        public int Id { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public RoundingDirectionEnum ShiftStartRoundingDirection { get; set; }
        public int ShiftStartRoundingInterval { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public RoundingDirectionEnum ShiftEndRoundingDirection { get; set; }
        public int ShiftEndRoundingInterval { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public RoundingDirectionEnum BreakStartRoundingDirection { get; set; }
        public int BreakStartRoundingInterval { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public RoundingDirectionEnum BreakEndRoundingDirection { get; set; }
        public int BreakEndRoundingInterval { get; set; }
        public int? RoundUpToShiftStartTimeRoundingInterval { get; set; }
        public int? RoundDownToShiftStartTimeRoundingInterval { get; set; }
        public int? RoundUpToShiftEndTimeRoundingInterval { get; set; }
        public int? RoundDownToShiftEndTimeRoundingInterval { get; set; }
    }
}
