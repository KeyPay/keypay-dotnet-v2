using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmployeeBankAccount
{
    public class NzSaveBankAccountResponseModel
    {
        public string ValidationWarning { get; set; }
        public NzBankAccountModel Result { get; set; }
    }
}
