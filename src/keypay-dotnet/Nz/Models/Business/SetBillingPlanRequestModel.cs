using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Business
{
    public class SetBillingPlanRequestModel
    {
        public int BillingPlanId { get; set; }
    }
}
