using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
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
