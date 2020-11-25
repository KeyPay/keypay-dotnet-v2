using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class EmployerPaymentSummaryRequest
    {
        public int BusinessId { get; set; }
        public int TaxYear { get; set; }
        public DateTime JobDate { get; set; }
        public DateTime PeriodEnd { get; set; }
        public bool IsTest { get; set; }
        public EpsPaymentDatesModel NoPaymentDates { get; set; }
        public bool PeriodOfInactivity { get; set; }
        public DateTime? PeriodOfInactivityToDate { get; set; }
        public bool IsFinalEps { get; set; }
        public bool PayeSchemeCeased { get; set; }
        public DateTime? PayeSchemeCeasedDate { get; set; }
        public bool IsAutomaticSubmission { get; set; }
    }
}
