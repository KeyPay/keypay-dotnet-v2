using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class SaveBankAccountResponseModel
    {
        public string ValidationWarning { get; set; }
        public BankAccountModel Result { get; set; }
    }
}
