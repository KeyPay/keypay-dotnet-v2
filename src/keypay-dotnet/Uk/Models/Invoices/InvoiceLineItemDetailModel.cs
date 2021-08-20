using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Invoices
{
    public class InvoiceLineItemDetailModel
    {
        public string GroupName { get; set; }
        public string Description { get; set; }
    }
}
