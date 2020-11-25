using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkApprenticeshipLevySummaryReportModel
    {
        public IList<UkApprenticeshipLevySummaryReportPeriod> AppLevyReportMonths { get; set; }
        public IList<UkApprenticeshipLevySummaryReportPeriod> AppLevyReportQuarters { get; set; }
        public UkApprenticeshipLevySummaryReportPeriod AppLevyReportTotals { get; set; }
    }
}
