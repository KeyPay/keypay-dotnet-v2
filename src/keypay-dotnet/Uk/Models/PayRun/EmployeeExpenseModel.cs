using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class EmployeeExpenseModel
    {
        public string EmployeeExpenseCategoryId { get; set; }
        public string EmployeeExpenseCategoryName { get; set; }
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public string TaxCode { get; set; }
        public decimal? TaxRate { get; set; }
        public string TaxCodeDisplayName { get; set; }
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeExternalId { get; set; }
    }
}
