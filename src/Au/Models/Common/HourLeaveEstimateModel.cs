using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class HourLeaveEstimateModel
    {
        public decimal? Hours { get; set; }
        public int EmployeeId { get; set; }
        public IList<String> Details { get; set; }
    }
}
