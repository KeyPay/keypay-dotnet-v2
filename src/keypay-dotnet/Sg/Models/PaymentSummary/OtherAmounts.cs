using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.PaymentSummary
{
    public class OtherAmounts
    {
        public decimal WorkPlaceGiving { get; set; }
        public decimal ExemptForeignExemptIncome { get; set; }
        public decimal DeductibleAmountOfUndeductedAnnuityPrice { get; set; }
    }
}
