using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class SgLeaveAccrualRuleModel
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
