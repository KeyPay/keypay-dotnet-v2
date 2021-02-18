using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class ShiftLiabilityModel
    {
        public string LiabilityCategoryName { get; set; }
        public int LiabilityCategoryId { get; set; }
        public bool IncludeInShiftCost { get; set; }
        public decimal Amount { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ShiftAllowanceOption Option { get; set; }
        public decimal Cost { get; set; }
    }
}
