using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkCISDeductionsSummaryReportModel
    {
        public IList<UkCISDeductionsSummaryReportPeriod> CisReportMonths { get; set; }
        public IList<UkCISDeductionsSummaryReportPeriod> CisReportQuarters { get; set; }
        public UkCISDeductionsSummaryReportPeriod CisReportTotals { get; set; }
    }
}
