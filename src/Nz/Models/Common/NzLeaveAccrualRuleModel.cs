using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class NzLeaveAccrualRuleModel
    {
        public int? LeaveYearOffsetAmount { get; set; }
        public int Id { get; set; }
        public LeaveAccrualCapType CapType { get; set; }
        public decimal UnitCap { get; set; }
        public LeaveAccrualCarryOverBehaviour CarryOverBehaviour { get; set; }
        public decimal CarryOverAmount { get; set; }
        public bool AccrueInAdvance { get; set; }
        public LeaveAccrualType AccrualType { get; set; }
    }
}
