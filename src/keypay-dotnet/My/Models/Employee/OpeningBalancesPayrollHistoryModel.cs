using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Employee
{
    public class OpeningBalancesPayrollHistoryModel
    {
        public bool HasPayrollHistory { get; set; }
        public decimal TotalGrossEarnings { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalAllowances { get; set; }
        public decimal TotalDeductions { get; set; }
        public decimal TotalEPFEmployer { get; set; }
        public decimal TotalEPFEmployee { get; set; }
        public decimal TotalSocsoEmployer { get; set; }
        public decimal TotalSocsoEmployee { get; set; }
        public decimal TotalCP38 { get; set; }
        public decimal TotalZakat { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayCycleFrequencyEnum? PayPeriod { get; set; }
        public DateTime? AnnualEarningsStartDate { get; set; }
        public DateTime? AnnualEarningsEndDate { get; set; }
        public int NumberOfPeriods { get; set; }
        public decimal TotalBiksTaxable { get; set; }
        public decimal TotalBiksTaxExempt { get; set; }
    }
}
