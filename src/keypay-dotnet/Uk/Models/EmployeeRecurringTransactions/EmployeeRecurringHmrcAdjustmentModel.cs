using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.EmployeeRecurringTransactions
{
    public class EmployeeRecurringHmrcAdjustmentModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public HmrcContributionType ContributionType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public HmrcAdjustmentTypeEnum Type { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NationalInsuranceType? NationalInsuranceType { get; set; }
        public string ExternalId { get; set; }
        public bool Deleted { get; set; }
        public bool IsFromNIBackCalculation { get; set; }
        public bool ApplyTaxRelief { get; set; }
        public int? Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime FromDate { get; set; }
        public decimal? MaximumAmountPaid { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
    }
}
