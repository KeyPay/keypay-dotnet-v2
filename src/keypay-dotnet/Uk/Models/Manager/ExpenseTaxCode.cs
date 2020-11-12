using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Manager
{
    public class ExpenseTaxCode
    {
        public string TaxCode { get; set; }
        public string TaxCodeDisplayName { get; set; }
        public decimal TaxRate { get; set; }
    }
}
