using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class MyApiPaySlipBankPaymentModel
    {
        public string BankCode { get; set; }
        public string BranchCode { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string LodgementReference { get; set; }
        public decimal Amount { get; set; }
    }
}
