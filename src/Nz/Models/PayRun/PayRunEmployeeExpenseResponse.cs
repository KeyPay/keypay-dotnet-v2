using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class PayRunEmployeeExpenseResponse
    {
        public Dictionary<string,List<EmployeeExpenseModel>> EmployeeExpenses { get; set; }
        public int PayRunId { get; set; }
    }
}
