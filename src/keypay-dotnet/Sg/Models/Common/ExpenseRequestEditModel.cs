using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class ExpenseRequestEditModel
    {
        public List<AttachmentModel> Attachments { get; set; }
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Description { get; set; }
        public List<ExpenseRequestEditLineItemModel> LineItems { get; set; }
    }
}
