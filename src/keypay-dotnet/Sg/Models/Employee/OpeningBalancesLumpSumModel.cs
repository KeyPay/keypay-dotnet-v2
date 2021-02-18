using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Employee
{
    public class OpeningBalancesLumpSumModel
    {
        public string PaymentReason { get; set; }
        public string ServiceLength { get; set; }
        public string PaymentBasis { get; set; }
        public IList<OpeningBalancesLumpSumPaymentModel> LumpSumPaymentModels { get; set; }
    }
}
