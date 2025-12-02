using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Authentication
{
    public class AttemptAccountRecoveryRequestModel
    {
        public string TwoFaToken { get; set; }
        public int BrandId { get; set; }
    }
}
