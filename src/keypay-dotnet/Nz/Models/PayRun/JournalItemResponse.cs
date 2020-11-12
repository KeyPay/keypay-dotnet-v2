using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class JournalItemResponse
    {
        public string ExternalAccountReferenceId { get; set; }
        public decimal Units { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountUnrounded { get; set; }
        public string Reference { get; set; }
        public JournalItemType JournalItemType { get; set; }
        public string TaxCode { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string Details { get; set; }
        public string Location { get; set; }
        public bool IsCredit { get; set; }
        public bool IsDebit { get; set; }
    }
}
