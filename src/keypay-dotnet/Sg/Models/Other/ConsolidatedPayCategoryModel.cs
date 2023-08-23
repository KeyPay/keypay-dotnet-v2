using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
{
    public class ConsolidatedPayCategoryModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public PayCategoryPaymentSummaryClassification? PaymentSummaryClassification { get; set; }
        public string AllowanceDescription { get; set; }
        public decimal DefaultSuperRate { get; set; }
        public string SuperExpenseMappingCode { get; set; }
        public string SuperLiabilityMappingCode { get; set; }
        public bool IsPayrollTaxExempt { get; set; }
        public string AwardName { get; set; }
        public int? AwardId { get; set; }
        public bool IsNationalInsuranceExempt { get; set; }
        public bool IsEmployeePensionable { get; set; }
        public bool IsEmployerPensionable { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MinimumWageCalculationImpact MinimumWageCalculationImpact { get; set; }
        public bool IsClass1ANIable { get; set; }
        public bool IsKiwiSaverExempt { get; set; }
        public bool ExcludeFromAverageEarnings { get; set; }
        public bool ExcludeFromOrdinaryEarnings { get; set; }
        public bool IsAccLevyExempt { get; set; }
        public bool IsSuperannuationFund { get; set; }
        public bool IsParentalLeave { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public CpfClassification? CpfClassification { get; set; }
        public bool IsShgExempt { get; set; }
        public bool IsSdlExempt { get; set; }
        public bool IsGstExempt { get; set; }
        public bool IsNetPayment { get; set; }
        public bool CisCategory { get; set; }
        public bool Is52WeekAverageEnabled { get; set; }
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
        public KeyPayV2.Sg.Enums.MidpointRounding? RoundingMethod { get; set; }
        public bool HideUnitsOnPaySlip { get; set; }
        public bool IsPrimary { get; set; }
    }
}
