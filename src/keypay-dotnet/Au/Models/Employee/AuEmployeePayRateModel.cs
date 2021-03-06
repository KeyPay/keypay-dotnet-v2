using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Employee
{
    public class AuEmployeePayRateModel
    {
        public bool HasSuperRateOverride { get; set; }
        public decimal? SuperRate { get; set; }
        public int PayCategoryId { get; set; }
        public string PayCategoryName { get; set; }
        public bool IsPrimaryPayCategory { get; set; }
        public bool AccruesLeave { get; set; }
        public string RateUnit { get; set; }
        public decimal Rate { get; set; }
        public decimal CalculatedRate { get; set; }
    }
}
