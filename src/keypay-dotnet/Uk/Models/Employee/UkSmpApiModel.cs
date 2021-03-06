using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkSmpApiModel
    {
        public int DaysPaid { get; set; }
        public int PayRunId { get; set; }
        public decimal? Earnings { get; set; }
    }
}
