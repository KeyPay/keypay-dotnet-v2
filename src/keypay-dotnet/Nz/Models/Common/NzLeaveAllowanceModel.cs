using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class NzLeaveAllowanceModel
    {
        public NzLeaveAccrualRuleModel LeaveAccrualRule { get; set; }
        public DateTime LeaveAnniversaryDate { get; set; }
        public string LeaveCategoryId { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal? Units { get; set; }
        public string UnitType { get; set; }
        public string LeaveUnitType { get; set; }
        public decimal HoursPerYear { get; set; }
        public bool AutomaticallyAccrues { get; set; }
        public bool CanApplyForLeave { get; set; }
    }
}
