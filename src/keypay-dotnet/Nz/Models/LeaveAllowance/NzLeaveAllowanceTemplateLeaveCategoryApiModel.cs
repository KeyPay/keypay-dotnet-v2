using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.LeaveAllowance
{
    public class NzLeaveAllowanceTemplateLeaveCategoryApiModel
    {
        public int? AccrualRuleLeaveYearOffsetAmount { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NzLeaveAllowanceUnitType? UnitType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveUnitTypeEnum? LeaveUnitType { get; set; }
        public int LeaveCategoryId { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal? Units { get; set; }
        public bool CanApplyForLeave { get; set; }
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
