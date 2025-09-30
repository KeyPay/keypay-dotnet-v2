using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
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
        public IList<Int32> ReportingDimensionValueIds { get; set; }
        public IDictionary<string,IList<string>> ReportingDimensionValueNames { get; set; }
        public int EmployeeExpenseRequestId { get; set; }
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeExternalId { get; set; }
    }
}
