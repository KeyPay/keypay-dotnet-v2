using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class MyApiPaySlipBenefitsInKindAdjustmentModel
    {
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public string BenefitsInKindType { get; set; }
    }
}
