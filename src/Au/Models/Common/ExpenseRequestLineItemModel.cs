using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class ExpenseRequestLineItemModel
    {
        public string ExpenseCategoryName { get; set; }
        public string LocationName { get; set; }
        public int? Id { get; set; }
        public int ExpenseCategoryId { get; set; }
        public int? LocationId { get; set; }
        public string Notes { get; set; }
        public string TaxCode { get; set; }
        public string TaxCodeDisplayName { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateIncurred { get; set; }
    }
}
