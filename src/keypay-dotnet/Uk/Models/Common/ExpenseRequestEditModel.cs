using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Common
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
