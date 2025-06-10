using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmployeeBankAccount
{
    public class AuSaveBankAccountResponseModel
    {
        public string ValidationWarning { get; set; }
        public AuBankAccountModel Result { get; set; }
    }
}
