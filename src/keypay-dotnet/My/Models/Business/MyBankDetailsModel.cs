using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Business
{
    public class MyBankDetailsModel
    {
        public int? Id { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BankFileFormatMy FileFormat { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string BranchCode { get; set; }
        public string OrganisationCode { get; set; }
        public string LodgementReference { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentFilePaymentAdditionalContent PaymentAdditionalContent { get; set; }
        public string HsbcConnectCustomerId { get; set; }
        public string PaymentCode { get; set; }
        public string HsbcnetCustomerId { get; set; }
        public string BankCode { get; set; }
        public string CorporateId { get; set; }
        public int? ValueDateDaysBeforeDatePaid { get; set; }
    }
}
