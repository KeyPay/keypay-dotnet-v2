using System;
using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerExpenseRequestModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public List<ExpenseRequestLineItemModel> LineItems { get; set; }
        public List<AttachmentModel> Attachments { get; set; }
        public virtual string StatusUpdatedByUser { get; set; }
        public virtual string StatusUpdateNotes { get; set; }
        public virtual DateTime DateStatusUpdated { get; set; }
        public bool CanCancel { get; set; }
        public bool CanModify { get; set; }
    }

    public class ExpenseRequestLineItemModel
    {
        public int? Id { get; set; }
        public int ExpenseCategoryId { get; set; }
        public string ExpenseCategoryName { get; set; }
        public int? LocationId { get; set; }
        public string LocationName { get; set; }
        public string Notes { get; set; }
        public string TaxCode { get; set; }
        public string TaxCodeDisplayName { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateIncurred { get; set; }
    }
}
