using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.LeaveRequests
{
    public class UnitLeaveEstimateModel
    {
        public decimal? Units { get; set; }
        public int EmployeeId { get; set; }
        public IList<String> Details { get; set; }
    }
}
