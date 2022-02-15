using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayCategory
{
    public class UkPayCategoryModel
    {
        public bool IsNationalInsuranceExempt { get; set; }
        public bool IsEmployeePensionable { get; set; }
        public bool IsEmployerPensionable { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MinimumWageCalculationImpact MinimumWageCalculationImpact { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public UkPayCategoryType PayCategoryType { get; set; }
        public bool IsClass1ANIable { get; set; }
        public bool Is52WeekAverageEnabled { get; set; }
        public bool IsNetPayment { get; set; }
        public bool CisCategory { get; set; }
        public bool ApplyCisDeduction { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayCategoryCisType CisType { get; set; }
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
        public KeyPayV2.Uk.Enums.MidpointRounding? RoundingMethod { get; set; }
        public bool HideUnitsOnPaySlip { get; set; }
        public bool IsPrimary { get; set; }
    }
}
