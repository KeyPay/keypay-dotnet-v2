using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkApprenticeshipLevySummaryReportPeriod
    {
        public string TaxMonth { get; set; }
        public string Date { get; set; }
        public decimal NationalInsuranceEligibleEarnings { get; set; }
        public decimal ApprenticeshipLevy { get; set; }
        public decimal ApprenticeshipLevyAllowance { get; set; }
        public decimal NetApprenticeshipLevy { get; set; }
    }
}
