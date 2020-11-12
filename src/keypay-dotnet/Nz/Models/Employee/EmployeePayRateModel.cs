using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Employee
{
    public class EmployeePayRateModel
    {
        public int PayCategoryId { get; set; }
        public string PayCategoryName { get; set; }
        public bool IsPrimaryPayCategory { get; set; }
        public bool AccruesLeave { get; set; }
        public string RateUnit { get; set; }
        public decimal Rate { get; set; }
        public decimal CalculatedRate { get; set; }
        public bool HasSuperRateOverride { get; set; }
        public decimal? SuperRate { get; set; }
    }
}
