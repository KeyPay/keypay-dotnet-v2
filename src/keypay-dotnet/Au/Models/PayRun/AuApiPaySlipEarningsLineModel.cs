using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class AuApiPaySlipEarningsLineModel
    {
        public decimal SuperContribution { get; set; }
        public string PayCategoryName { get; set; }
        public decimal Units { get; set; }
        public bool IsFixed { get; set; }
        public bool IsTaxExempt { get; set; }
        public decimal Rate { get; set; }
        public string Notes { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal TaxableEarnings { get; set; }
        public string LocationName { get; set; }
    }
}
