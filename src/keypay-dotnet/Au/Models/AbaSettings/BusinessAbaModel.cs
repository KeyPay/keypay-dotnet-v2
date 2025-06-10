using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.AbaSettings
{
    public class BusinessAbaModel
    {
        public int Id { get; set; }
        public string Bsb { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string FinancialInstitutionCode { get; set; }
        public string LodgementReference { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public bool IncludeSelfBalancingTransaction { get; set; }
        public bool MergeMultipleAccountPayments { get; set; }
        public string BalanceLodgementReference { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentFilePaymentAdditionalContent? PaymentAdditionalContent { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentFileBalanceAdditionalContent? BalanceAdditionalContent { get; set; }
    }
}
