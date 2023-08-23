using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class MyLeaveAllowanceModel
    {
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
