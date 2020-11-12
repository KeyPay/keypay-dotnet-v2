using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PaymentSummary
{
    public class GeneratePaymentSummariesQueryModel
    {
        public int? EmployeeId { get; set; }
        public int? EmployingEntityId { get; set; }
        public int? LocationId { get; set; }
    }
}
