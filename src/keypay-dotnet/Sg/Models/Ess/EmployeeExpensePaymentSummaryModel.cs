using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Ess
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
