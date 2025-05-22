using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class ShiftAllowanceModel
    {
        public string PayCategory { get; set; }
        public int PayCategoryId { get; set; }
        public decimal Units { get; set; }
        public decimal Cost { get; set; }
        public decimal RateMultiplier { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ShiftAllowanceOption Option { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ShiftAllowanceType Type { get; set; }
        public NominalClassification Classification { get; set; }
    }
}
