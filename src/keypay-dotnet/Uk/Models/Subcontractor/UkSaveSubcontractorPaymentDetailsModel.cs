using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Subcontractor
{
    public class UkSaveSubcontractorPaymentDetailsModel
    {
        public int? BankAccountId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BankAccountTypeEnum AccountType { get; set; }
        public string SortCode { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string RollNumber { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public int? PayScheduleId { get; set; }
        public int? PayCategoryId { get; set; }
    }
}
