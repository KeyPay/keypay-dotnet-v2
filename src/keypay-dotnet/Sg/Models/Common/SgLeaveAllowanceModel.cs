using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Common
{
    public class SgLeaveAllowanceModel
    {
        public SgLeaveAccrualRuleModel LeaveAccrualRule { get; set; }
        public string LeaveCategoryId { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal? Units { get; set; }
        public string UnitType { get; set; }
        public decimal HoursPerYear { get; set; }
        public bool AutomaticallyAccrues { get; set; }
        public bool CanApplyForLeave { get; set; }
    }
}
