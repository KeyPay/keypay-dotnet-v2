using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkSmpCalcApiModel
    {
        public SmpEligibilityEnum Status { get; set; }
        public int SmpDays { get; set; }
        public IDictionary<Decimal,Int32> Rates { get; set; }
        public UkSmpPaymentApiModel[] Payments { get; set; }
    }
}
