using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerExpenseRequestEditModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Description { get; set; }
        public List<ExpenseRequestEditLineItemModel> LineItems { get; set; }
        public List<AttachmentModel> Attachments { get; set; }
    }
}
