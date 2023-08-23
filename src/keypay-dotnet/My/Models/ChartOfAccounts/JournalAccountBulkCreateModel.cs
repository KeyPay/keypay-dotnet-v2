using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.ChartOfAccounts
{
    public class JournalAccountBulkCreateModel
    {
        public List<String> ErrorMessages { get; set; }
        public List<JournalAccountModel> CreatedJournalAccounts { get; set; }
    }
}
