using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayCategory
{
    public class UkPayCategoryModel
    {
        public bool IsNationalInsuranceExempt { get; set; }
        public MinimumWageCalculationImpact MinimumWageCalculationImpact { get; set; }
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
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
        public PayCategoryType PayCategoryType { get; set; }
    }
}
