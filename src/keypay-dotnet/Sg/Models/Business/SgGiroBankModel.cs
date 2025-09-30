using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Business
{
    public class SgGiroBankModel
    {
        public int Id { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public GiroBankFileFormat FileFormat { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string BulkCustomerReference { get; set; }
        public string LodgementReference { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentFilePaymentAdditionalContent PaymentAdditionalContent { get; set; }
        public string BankSwift { get; set; }
        public string BranchCode { get; set; }
        public string PaymentCode { get; set; }
        public string CustomerReference { get; set; }
        public string AlternateCustomerReference { get; set; }
        public int? ValueDateDaysBeforeDatePaid { get; set; }
        public bool? ConfidentialIndicator { get; set; }
        public bool? EnablePaymentNotifications { get; set; }
    }
}
