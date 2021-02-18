using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayCategory
{
    public class SgPayCategoryModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public PayCategoryPaymentSummaryClassification? PaymentSummaryClassification { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public CpfClassification? CpfClassification { get; set; }
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
        [JsonConverter(typeof(StringEnumConverter))]
        public PayCategoryType PayCategoryType { get; set; }
        public bool HideUnitsOnPaySlip { get; set; }
        public bool IsPrimary { get; set; }
    }
}
