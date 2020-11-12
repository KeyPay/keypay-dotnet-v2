using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmployeeRecurringTransactions
{
    public class EmployeeRecurringExpenseModel
    {
        public string Name { get; set; }
        public int ExpenseCategoryId { get; set; }
        public int LocationId { get; set; }
        public string TaxCode { get; set; }
        public string TaxCodeDisplayName { get; set; }
        public decimal? TaxRate { get; set; }
        public int? Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime FromDate { get; set; }
        public decimal? MaximumAmountPaid { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
    }
}
