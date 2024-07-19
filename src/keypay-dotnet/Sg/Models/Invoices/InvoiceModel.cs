using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Invoices
{
    public class InvoiceModel
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal? TotalExcludingGst { get; set; }
        public decimal? Gst { get; set; }
        public decimal? TotalIncludingGst { get; set; }
        public string CultureName { get; set; }
        public string Currency { get; set; }
        public List<InvoiceLineItemModel> LineItems { get; set; }
    }
}
