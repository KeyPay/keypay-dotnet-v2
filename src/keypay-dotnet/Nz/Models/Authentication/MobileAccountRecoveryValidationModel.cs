using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Authentication
{
    public class MobileAccountRecoveryValidationModel
    {
        public string TwoFaToken { get; set; }
    }
}
