using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class PayeReportExportModel
    {
        public string Location { get; set; }
        public string Month { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal TaxExemptEarnings { get; set; }
        public decimal PreTaxDeductions { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal Paye { get; set; }
    }
}
