using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class P60ViewModel
    {
        public DateTime? EmployeeEndDate { get; set; }
        public DateTime? NotificationDate { get; set; }
        public string P60Url { get; set; }
        public int FinancialYearEnding { get; set; }
    }
}
