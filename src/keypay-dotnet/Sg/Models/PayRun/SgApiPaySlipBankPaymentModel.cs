using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class SgApiPaySlipBankPaymentModel
    {
        public string BankSwift { get; set; }
        public string BranchCode { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string LodgementReference { get; set; }
        public decimal Amount { get; set; }
    }
}
