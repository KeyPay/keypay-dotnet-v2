using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class YearToDateGrossPaySection
    {
        public decimal Amount { get; set; }
        public decimal? PrevAmount { get; set; }
        public string Name { get; set; }
        public YearToDateGrossPayComponent[] Components { get; set; }
    }
}
