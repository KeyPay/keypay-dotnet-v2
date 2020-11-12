using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class AuApiPaySlipBankPaymentModel
    {
        public string Bsb { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string LodgementReference { get; set; }
        public decimal Amount { get; set; }
    }
}
