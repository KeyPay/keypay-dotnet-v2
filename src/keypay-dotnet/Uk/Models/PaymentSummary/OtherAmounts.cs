using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PaymentSummary
{
    public class OtherAmounts
    {
        public decimal WorkPlaceGiving { get; set; }
        public decimal ExemptForeignExemptIncome { get; set; }
        public decimal DeductibleAmountOfUndeductedAnnuityPrice { get; set; }
    }
}
