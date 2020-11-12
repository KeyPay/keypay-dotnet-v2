using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class ApiEmployeeExpenseGridModel
    {
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public string LocationName { get; set; }
        public string EmployeeExpenseCategoryName { get; set; }
    }
}
