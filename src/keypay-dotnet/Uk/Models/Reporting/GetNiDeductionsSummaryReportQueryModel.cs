using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class GetNiDeductionsSummaryReportQueryModel
    {
        public int FinancialYearEnding { get; set; }
        public int? PayeSchemeId { get; set; }
        public DateTime Date { get; set; }
    }
}
