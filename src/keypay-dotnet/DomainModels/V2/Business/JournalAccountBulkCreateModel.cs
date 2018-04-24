using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Business
{
    public class JournalAccountBulkCreateModel
    {
        public List<string> ErrorMessages { get; set; }
        public List<JournalAccountModel> CreatedJournalAccounts { get; set; }
    }
}