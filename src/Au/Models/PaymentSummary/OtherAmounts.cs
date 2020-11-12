using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PaymentSummary
{
    public class OtherAmounts
    {
        public decimal WorkPlaceGiving { get; set; }
        public decimal ExemptForeignExemptIncome { get; set; }
        public decimal DeductibleAmountOfUndeductedAnnuityPrice { get; set; }
    }
}
