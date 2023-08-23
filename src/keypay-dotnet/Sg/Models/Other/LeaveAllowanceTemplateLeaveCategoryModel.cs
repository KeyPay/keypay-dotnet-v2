using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
{
    public class LeaveAllowanceTemplateLeaveCategoryModel
    {
        public int LeaveCategoryId { get; set; }
        public decimal? Units { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAllowanceUnitEnum? UnitType { get; set; }
        public decimal? LeaveLoading { get; set; }
        public bool CanApplyForLeave { get; set; }
        public decimal? ContingentPeriod { get; set; }
        public decimal? EntitlementPeriod { get; set; }
        public int LeaveAccrualRuleId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualType LeaveAccrualRuleAccrualType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualCapType LeaveAccrualRuleCapType { get; set; }
        public decimal LeaveAccrualRuleUnitCap { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualCarryOverBehaviour LeaveAccrualRuleCarryOverBehaviour { get; set; }
        public decimal LeaveAccrualRuleCarryOverAmount { get; set; }
        public bool LeaveAccrualRuleAccrueInAdvance { get; set; }
    }
}
