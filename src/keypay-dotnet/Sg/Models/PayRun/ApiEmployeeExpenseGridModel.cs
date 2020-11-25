using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class ApiEmployeeExpenseGridModel
    {
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public string LocationName { get; set; }
        public string EmployeeExpenseCategoryName { get; set; }
    }
}
