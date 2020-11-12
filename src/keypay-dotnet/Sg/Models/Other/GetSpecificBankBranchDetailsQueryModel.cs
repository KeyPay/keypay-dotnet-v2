using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
{
    public class GetSpecificBankBranchDetailsQueryModel
    {
        public string BankSwift { get; set; }
        public string BranchCode { get; set; }
        public string AccountNumber { get; set; }
    }
}
