using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class PayRunVarianceReportQueryModel
    {
        public int? PayRunId1 { get; set; }
        public int? PayRunId2 { get; set; }
        public DateTime? PayPeriodFrom1 { get; set; }
        public DateTime? PayPeriodTo1 { get; set; }
        public DateTime? PayPeriodFrom2 { get; set; }
        public DateTime? PayPeriodTo2 { get; set; }
        public PayRunComparisonType ComparisonType { get; set; }
        public decimal HighlightVariancePercentage { get; set; }
        public bool OnlyShowVariances { get; set; }
    }
}
