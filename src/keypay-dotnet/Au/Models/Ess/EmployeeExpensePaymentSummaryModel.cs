using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class EmployeeExpensePaymentSummaryModel
    {
        public int EmployeeId { get; set; }
        public int ExpenseCategoryId { get; set; }
        public string ExpenseCategoryName { get; set; }
        public decimal YtdAmount { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
