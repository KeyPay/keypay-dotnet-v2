using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Invoices
{
    public class InvoiceLineItemDetailModel
    {
        public string GroupName { get; set; }
        public string Description { get; set; }
    }
}
