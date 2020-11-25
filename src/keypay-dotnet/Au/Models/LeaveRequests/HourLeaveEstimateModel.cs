using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.LeaveRequests
{
    public class HourLeaveEstimateModel
    {
        public decimal? Hours { get; set; }
        public int EmployeeId { get; set; }
        public IList<String> Details { get; set; }
    }
}
