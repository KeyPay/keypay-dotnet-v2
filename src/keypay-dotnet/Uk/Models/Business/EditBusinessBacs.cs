using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class EditBusinessBacs
    {
        public int? Id { get; set; }
        public string ServiceUserNumber { get; set; }
        public string OriginatingSortCode { get; set; }
        public string OriginatingAccountNumber { get; set; }
        public string OriginatingAccountName { get; set; }
        public string LodgementReference { get; set; }
        public BacsFileFormat FileFormat { get; set; }
        public string DisplayName { get; set; }
        public bool MergeMultipleAccountPayments { get; set; }
        public PaymentFilePaymentAdditionalContent PaymentAdditionalContent { get; set; }
    }
}
