using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Manager
{
    public class ExpenseTaxCode
    {
        public string TaxCode { get; set; }
        public string TaxCodeDisplayName { get; set; }
        public decimal TaxRate { get; set; }
    }
}
