using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;
using MidpointRounding = KeyPayV2.Nz.Enums.MidpointRounding;

namespace KeyPayV2.Nz.Models.ChartOfAccounts
{
    public class JournalAccountBulkCreateModel
    {
        public List<String> ErrorMessages { get; set; }
        public List<JournalAccountModel> CreatedJournalAccounts { get; set; }
    }
}
