using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PaymentSummary
{
    public class PublishPaymentSummariesQueryModel
    {
        public int? EmployeeId { get; set; }
        public int? EmployingEntityId { get; set; }
        public int? LocationId { get; set; }
    }
}
