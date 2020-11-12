using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class AuLeaveAllowanceModel
    {
        public decimal LeaveLoading { get; set; }
        public LeaveAccrualRuleModel LeaveAccrualRule { get; set; }
        public string LeaveCategoryId { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal? Units { get; set; }
        public string UnitType { get; set; }
        public decimal HoursPerYear { get; set; }
        public bool AutomaticallyAccrues { get; set; }
    }
}
