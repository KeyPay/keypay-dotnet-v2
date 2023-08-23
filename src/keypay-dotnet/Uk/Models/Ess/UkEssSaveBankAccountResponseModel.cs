using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class UkEssSaveBankAccountResponseModel
    {
        public string ValidationWarning { get; set; }
        public UkEssBankAccountModel Result { get; set; }
    }
}
