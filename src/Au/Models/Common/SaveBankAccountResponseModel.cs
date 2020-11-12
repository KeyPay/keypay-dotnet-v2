using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class SaveBankAccountResponseModel
    {
        public string ValidationWarning { get; set; }
        public BankAccountModel Result { get; set; }
    }
}
