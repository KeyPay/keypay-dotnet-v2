using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class UkBacsApiModel
    {
        public int Id { get; set; }
        public BacsFileFormat FileFormat { get; set; }
        public string ServiceUserNumber { get; set; }
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string LodgementReference { get; set; }
        public PaymentFilePaymentAdditionalContent PaymentAdditionalContent { get; set; }
    }
}
