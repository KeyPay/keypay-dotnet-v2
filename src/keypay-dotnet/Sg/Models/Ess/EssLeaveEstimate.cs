using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Ess
{
    public class EssLeaveEstimate
    {
        public decimal? LeaveBalance { get; set; }
        public decimal? ApprovedLeave { get; set; }
        public decimal? AvailableBalance { get; set; }
        public UnitAndHourLeaveEstimateModel LeaveRequired { get; set; }
    }
}
