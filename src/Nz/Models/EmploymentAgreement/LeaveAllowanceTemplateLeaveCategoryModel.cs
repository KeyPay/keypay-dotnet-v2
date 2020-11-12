using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmploymentAgreement
{
    public class LeaveAllowanceTemplateLeaveCategoryModel
    {
        public int LeaveCategoryId { get; set; }
        public decimal? Units { get; set; }
        public LeaveAllowanceUnitEnum? UnitType { get; set; }
        public decimal? LeaveLoading { get; set; }
        public bool CanApplyForLeave { get; set; }
        public decimal? ContingentPeriod { get; set; }
        public decimal? EntitlementPeriod { get; set; }
        public int LeaveAccrualRuleId { get; set; }
        public LeaveAccrualType LeaveAccrualRuleAccrualType { get; set; }
        public LeaveAccrualCapType LeaveAccrualRuleCapType { get; set; }
        public decimal LeaveAccrualRuleUnitCap { get; set; }
        public LeaveAccrualCarryOverBehaviour LeaveAccrualRuleCarryOverBehaviour { get; set; }
        public decimal LeaveAccrualRuleCarryOverAmount { get; set; }
        public bool LeaveAccrualRuleAccrueInAdvance { get; set; }
    }
}
