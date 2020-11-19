using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PaymentSummary
{
    public class GeneratePaymentSummariesQueryModel
    {
        public int? EmployeeId { get; set; }
        public int? EmployingEntityId { get; set; }
        public int? LocationId { get; set; }
    }
}
