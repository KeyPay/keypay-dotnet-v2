using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class JournalItemResponse
    {
        public string ExternalAccountReferenceId { get; set; }
        public decimal Units { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountUnrounded { get; set; }
        public string Reference { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public JournalItemType JournalItemType { get; set; }
        public string TaxCode { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string Details { get; set; }
        public string Location { get; set; }
        public string LocationExternalReferenceId { get; set; }
        public bool IsCredit { get; set; }
        public bool IsDebit { get; set; }
    }
}
