using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayCategory
{
    public class AuPayCategoryModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public PayCategoryPaymentSummaryClassification? PaymentSummaryClassification { get; set; }
        public string AllowanceDescription { get; set; }
        public decimal DefaultSuperRate { get; set; }
        public string SuperExpenseMappingCode { get; set; }
        public string SuperLiabilityMappingCode { get; set; }
        public bool IsPayrollTaxExempt { get; set; }
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public RateUnitEnum RateUnit { get; set; }
        public bool AccruesLeave { get; set; }
        public decimal RateLoadingPercent { get; set; }
        public decimal PenaltyLoadingPercent { get; set; }
        public bool IsTaxExempt { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public string GeneralLedgerMappingCode { get; set; }
        public bool IsSystemPayCategory { get; set; }
        public int? NumberOfDecimalPlaces { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public KeyPayV2.Au.Enums.MidpointRounding? RoundingMethod { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayCategoryType PayCategoryType { get; set; }
        public bool HideUnitsOnPaySlip { get; set; }
        public bool IsPrimary { get; set; }
    }
}
