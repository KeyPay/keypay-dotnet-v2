using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class ListP60sResult
    {
        public List<String> Errors { get; set; }
        public List<P60CertificateApiModel> P60s { get; set; }
        public decimal PayThisEmploymentTotal { get; set; }
        public decimal TaxThisEmploymentTotal { get; set; }
        public decimal TotalPayTotal { get; set; }
        public decimal TotalTaxTotal { get; set; }
        public decimal StatutoryPaymentsTotal { get; set; }
        public decimal StudentLoanTotal { get; set; }
        public decimal PostgraduateLoanTotal { get; set; }
    }
}
