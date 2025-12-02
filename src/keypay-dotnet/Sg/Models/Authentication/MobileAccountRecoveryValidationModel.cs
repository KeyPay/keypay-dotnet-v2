using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Authentication
{
    public class MobileAccountRecoveryValidationModel
    {
        public string TwoFaToken { get; set; }
    }
}
