using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class YearToDatePensionSection
    {
        public decimal Amount { get; set; }
        public string Name { get; set; }
        public YearToDateComponent[] Components { get; set; }
    }
}
