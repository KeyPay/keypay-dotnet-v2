using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkApprenticeshipLevySummaryReportModel
    {
        public UkApprenticeshipLevySummaryReportPeriod AppLevyOpeningBalances { get; set; }
        public IList<UkApprenticeshipLevySummaryReportPeriod> AppLevyReportMonths { get; set; }
        public IList<UkApprenticeshipLevySummaryReportPeriod> AppLevyReportQuarters { get; set; }
        public UkApprenticeshipLevySummaryReportPeriod AppLevyReportTotals { get; set; }
    }
}
