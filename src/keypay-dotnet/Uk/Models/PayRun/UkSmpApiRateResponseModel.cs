using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkSmpApiRateResponseModel
    {
        public decimal Amount { get; set; }
        public int Days { get; set; }
    }
}
