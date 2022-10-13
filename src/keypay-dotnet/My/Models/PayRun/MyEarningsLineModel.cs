using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class MyEarningsLineModel
    {
        public decimal Cp38Amount { get; set; }
        public decimal MandatoryEmployeeEpfAmount { get; set; }
        public decimal MandatoryEmployerEpfAmount { get; set; }
        public decimal AdditionalEmployeeEpfAmount { get; set; }
        public decimal AdditionalEmployerEpfAmount { get; set; }
        public decimal EmployeeEisAmount { get; set; }
        public decimal EmployerEisAmount { get; set; }
        public decimal EmployeeSocsoAmount { get; set; }
        public decimal EmployerSocsoAmount { get; set; }
        public decimal HrdfAmount { get; set; }
        public decimal PcbBorneByEmployerAmount { get; set; }
        public int? ArrearsForYear { get; set; }
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
        public long Id { get; set; }
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeExternalId { get; set; }
    }
}
