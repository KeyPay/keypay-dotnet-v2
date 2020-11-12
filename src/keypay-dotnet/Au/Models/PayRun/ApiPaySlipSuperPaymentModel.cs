using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class ApiPaySlipSuperPaymentModel
    {
        public string FundName { get; set; }
        public string MemberNumber { get; set; }
        public decimal Amount { get; set; }
    }
}
