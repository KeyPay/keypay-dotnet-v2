using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkCISDeductionsSummaryReportPeriod
    {
        public string TaxMonth { get; set; }
        public DateTime Date { get; set; }
        public int CisDeductionsMadeId { get; set; }
        public decimal CisDeductionsMade { get; set; }
        public int CisDeductionsSufferedId { get; set; }
        public decimal CisDeductionsSuffered { get; set; }
        public decimal NetCISDeductions { get; set; }
    }
}
