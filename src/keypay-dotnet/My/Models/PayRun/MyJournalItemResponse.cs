using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class MyJournalItemResponse
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public JournalItemType JournalItemType { get; set; }
        public string ExternalAccountReferenceId { get; set; }
        public decimal Units { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountUnrounded { get; set; }
        public string Reference { get; set; }
        public string TaxCode { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string Details { get; set; }
        public string Location { get; set; }
        public bool IsCredit { get; set; }
        public bool IsDebit { get; set; }
        public string LocationExternalReferenceId { get; set; }
    }
}
