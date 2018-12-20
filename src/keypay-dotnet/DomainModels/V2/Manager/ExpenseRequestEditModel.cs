using System;
using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Manager
{
    class ExpenseRequestEditModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Description { get; set; }
        public List<ExpenseRequestEditLineItemModel> LineItems { get; set; }
        public List<AttachmentModel> Attachments { get; set; }
    }

    public class ExpenseRequestEditLineItemModel
    {
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
