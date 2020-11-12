using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Employee
{
    public class OpeningBalancesEtpModel
    {
        public decimal? TaxFreeComponent { get; set; }
        public decimal? TaxableComponent { get; set; }
        public decimal? TaxWithheld { get; set; }
        public decimal? LumpSumD { get; set; }
        public bool IsAmended { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool GeneratePaymentSummary { get; set; }
    }
}
