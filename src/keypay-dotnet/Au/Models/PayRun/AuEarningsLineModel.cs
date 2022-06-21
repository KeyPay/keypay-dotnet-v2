using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class AuEarningsLineModel
    {
        public decimal Super { get; set; }
        public decimal Sfss { get; set; }
        public decimal Help { get; set; }
        public decimal Payg { get; set; }
        public string PayCategoryId { get; set; }
        public string PayCategoryName { get; set; }
        public decimal Units { get; set; }
        public string Notes { get; set; }
        public decimal? Rate { get; set; }
        public decimal Earnings { get; set; }
        public decimal LumpSumNumberOfPayPeriods { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LumpSumCalculationMethod? LumpSumCalculationMethod { get; set; }
        public int? LumpSumEFinancialYear { get; set; }
        public int? TimesheetLineId { get; set; }
        public string TimesheetLineExternalId { get; set; }
        public long Id { get; set; }
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeExternalId { get; set; }
    }
}
