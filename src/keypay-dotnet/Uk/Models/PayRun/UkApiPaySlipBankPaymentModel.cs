using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkApiPaySlipBankPaymentModel
    {
        public string SortCode { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string LodgementReference { get; set; }
        public decimal Amount { get; set; }
    }
}
