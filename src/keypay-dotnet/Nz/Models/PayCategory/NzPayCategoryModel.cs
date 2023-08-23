using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayCategory
{
    public class NzPayCategoryModel
    {
        public bool IsKiwiSaverExempt { get; set; }
        public bool ExcludeFromAverageEarnings { get; set; }
        public bool ExcludeFromOrdinaryEarnings { get; set; }
        public bool IsAccLevyExempt { get; set; }
        public bool IsParentalLeave { get; set; }
        public bool IsGstExempt { get; set; }
        public bool IsSuperannuationFund { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NzPayCategoryType PayCategoryType { get; set; }
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
        public KeyPayV2.Nz.Enums.MidpointRounding? RoundingMethod { get; set; }
        public bool HideUnitsOnPaySlip { get; set; }
        public bool IsPrimary { get; set; }
    }
}
