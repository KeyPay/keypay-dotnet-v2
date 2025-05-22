using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkStatutorySharedParentalLeaveInfoModel
    {
        public string PartnerFirstName { get; set; }
        public string PartnerSurname { get; set; }
        public string PartnerNino { get; set; }
        public List<UkStatutorySharedParentalPaymentOptionModel> PaymentOptions { get; set; }
    }
}
