using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayCategory
{
    public class MyPayCategoryModel
    {
        public bool IsEpfExempt { get; set; }
        public bool IsSocsoExempt { get; set; }
        public bool IsEisExempt { get; set; }
        public bool IsHrdfExempt { get; set; }
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
        public KeyPayV2.My.Enums.MidpointRounding? RoundingMethod { get; set; }
        public bool HideUnitsOnPaySlip { get; set; }
        public bool IsPrimary { get; set; }
    }
}
