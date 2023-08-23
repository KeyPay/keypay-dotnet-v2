using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Other
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
