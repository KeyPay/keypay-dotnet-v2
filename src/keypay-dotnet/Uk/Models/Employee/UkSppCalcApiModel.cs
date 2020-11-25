using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkSppCalcApiModel
    {
        public SppEligibilityEnum Status { get; set; }
        public int SppDays { get; set; }
        public IDictionary<Decimal,Int32> Rates { get; set; }
        public UkSppPaymentApiModel[] Payments { get; set; }
    }
}
