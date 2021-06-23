using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkNIDeductionsSummaryReportModel
    {
        public UkNIDeductionsSummaryReportPeriod NiDeductionsOpeningBalances { get; set; }
        public IList<UkNIDeductionsSummaryReportPeriod> NiReportMonths { get; set; }
        public IList<UkNIDeductionsSummaryReportPeriod> NiReportQuarters { get; set; }
        public UkNIDeductionsSummaryReportPeriod NiReportTotals { get; set; }
    }
}
