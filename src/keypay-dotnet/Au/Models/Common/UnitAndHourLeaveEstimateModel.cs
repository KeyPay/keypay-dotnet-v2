using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class UnitAndHourLeaveEstimateModel
    {
        public decimal? Hours { get; set; }
        public decimal? Units { get; set; }
        public int EmployeeId { get; set; }
        public IList<String> Details { get; set; }
    }
}
