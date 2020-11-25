using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.LeaveAllowance
{
    public class SgLeaveAllowanceTemplateLeaveCategoryApiModel
    {
        public int? AccrualRuleLeaveYearOffsetAmount { get; set; }
        public int LeaveCategoryId { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal? Units { get; set; }
        public LeaveAllowanceUnitEnum? UnitType { get; set; }
        public bool CanApplyForLeave { get; set; }
        public decimal? ContingentPeriod { get; set; }
        public decimal? EntitlementPeriod { get; set; }
        public LeaveAccrualType LeaveAccrualRuleAccrualType { get; set; }
        public LeaveAccrualCapType LeaveAccrualRuleCapType { get; set; }
        public decimal LeaveAccrualRuleUnitCap { get; set; }
        public LeaveAccrualCarryOverBehaviour LeaveAccrualRuleCarryOverBehaviour { get; set; }
        public decimal LeaveAccrualRuleCarryOverAmount { get; set; }
        public bool LeaveAccrualRuleAccrueInAdvance { get; set; }
    }
}
