using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Manager
{
    public class ManagerLeaveEstimate
    {
        public decimal? LeaveBalance { get; set; }
        public decimal? ApprovedLeave { get; set; }
        public decimal? AvailableBalance { get; set; }
        public UnitAndHourLeaveEstimateModel LeaveRequired { get; set; }
    }
}
