using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmployeeIrasLumpSum
{
    public class SgIrasLumpSumModel
    {
        public int Id { get; set; }
        public int? EmployingEntityId { get; set; }
        public int BasisPeriod { get; set; }
        public bool? Approved { get; set; }
        public DateTime? DateOfApproval { get; set; }
        public string PaymentReason { get; set; }
        public string ServiceLength { get; set; }
        public string PaymentBasis { get; set; }
        public string RetirementBenefitsFund { get; set; }
    }
}
