using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkEarningsLineModel
    {
        public decimal Paye { get; set; }
        public decimal StudentLoan { get; set; }
        public decimal PostGradLoan { get; set; }
        public decimal EmployeeNationalInsuranceContribution { get; set; }
        public decimal EmployerNationalInsuranceContribution { get; set; }
        public decimal EmployeePensionContribution { get; set; }
        public decimal EmployerPensionContribution { get; set; }
        public bool PayRateNetPaymentEarningsLineDeleted { get; set; }
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
        public IList<Int32> ReportingDimensionValueIds { get; set; }
        public IDictionary<string,IList<string>> ReportingDimensionValueNames { get; set; }
        public decimal NetPayment { get; set; }
        public long Id { get; set; }
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeExternalId { get; set; }
    }
}
