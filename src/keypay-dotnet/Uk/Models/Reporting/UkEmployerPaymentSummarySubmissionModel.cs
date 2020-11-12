using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkEmployerPaymentSummarySubmissionModel
    {
        public DateTime PeriodEnd { get; set; }
        public EpsPaymentDatesViewModel NoPaymentDates { get; set; }
        public bool PeriodOfInactivity { get; set; }
        public DateTime? PeriodOfInactivityToDate { get; set; }
        public bool IsFinalEpsForTaxYear { get; set; }
        public bool PayeSchemeCeased { get; set; }
        public DateTime? PayeSchemeCeasedDate { get; set; }
    }
}
