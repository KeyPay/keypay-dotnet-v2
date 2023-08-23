using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
{
    public class LeaveAccrualRuleViewModel
    {
        public int Id { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualCapType CapType { get; set; }
        public decimal UnitCap { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualCarryOverBehaviour CarryOverBehaviour { get; set; }
        public decimal CarryOverAmount { get; set; }
        public bool AccrueInAdvance { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualType AccrualType { get; set; }
        public int? LeaveYearOffsetAmount { get; set; }
    }
}
