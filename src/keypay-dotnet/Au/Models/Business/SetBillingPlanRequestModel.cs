using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Business
{
    public class SetBillingPlanRequestModel
    {
        public int BillingPlanId { get; set; }
    }
}
