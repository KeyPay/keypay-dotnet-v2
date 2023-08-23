using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class P11ReportDataRow
    {
        public string TaxPeriodNumber { get; set; }
        public DateTime? PayDate { get; set; }
        public string PayCycleName { get; set; }
        public int PayCycleFrequencyId { get; set; }
        public bool IsOpeningBalance { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NationalInsuranceType NiCategory { get; set; }
        public decimal NIablePay { get; set; }
        public decimal NIablePayAtTheLel { get; set; }
        public decimal NIablePayLelToPt { get; set; }
        public decimal NIablePayLelToSt { get; set; }
        public decimal NIablePayPtToFust { get; set; }
        public decimal NIablePayStToFust { get; set; }
        public decimal NIablePayFustToUel { get; set; }
        public decimal NIablePayFustToUst { get; set; }
        public decimal NIablePayAboveUel { get; set; }
        public decimal NIablePayAboveUst { get; set; }
        public decimal EmployeeContribution { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal TaxablePay { get; set; }
        public decimal TaxDueThisPeriod { get; set; }
        public string TaxCodeApplied { get; set; }
        public decimal StudentLoan { get; set; }
        public decimal PostGradLoan { get; set; }
    }
}
