using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Invoices
{
    public class InvoiceLineItemModel
    {
        public string Abn { get; set; }
        public string BusinessNumber { get; set; }
        public int? BusinessId { get; set; }
        public string BillingPlan { get; set; }
        public string Description { get; set; }
        public decimal? UnitPriceIncludingGst { get; set; }
        public decimal Quantity { get; set; }
        public decimal? TotalIncludingGst { get; set; }
        public List<InvoiceLineItemDetailModel> Details { get; set; }
        public string WhiteLabelName { get; set; }
        public string BrandName { get; set; }
    }
}
