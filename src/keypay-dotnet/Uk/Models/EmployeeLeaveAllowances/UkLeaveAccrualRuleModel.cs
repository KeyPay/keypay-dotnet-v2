using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.EmployeeLeaveAllowances
{
    public class UkLeaveAccrualRuleModel
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
    }
}
