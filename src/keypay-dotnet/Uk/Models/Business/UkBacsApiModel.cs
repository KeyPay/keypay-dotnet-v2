using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class UkBacsApiModel
    {
        public int Id { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BacsFileFormat FileFormat { get; set; }
        public string ServiceUserNumber { get; set; }
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string LodgementReference { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentFilePaymentAdditionalContent PaymentAdditionalContent { get; set; }
        public bool ExcludeFooter { get; set; }
        public bool MergeMultipleAccountPayments { get; set; }
        public bool PayHmrc { get; set; }
        public int? PaymentDate { get; set; }
        public string HmrcSortCode { get; set; }
        public string HmrcAccountNumber { get; set; }
        public string HmrcAccountName { get; set; }
    }
}
