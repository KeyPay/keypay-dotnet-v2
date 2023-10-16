using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.LeaveCategories
{
    public class LeaveEntitlementTierModel
    {
        public int Id { get; set; }
        public int AccrualStartAfter { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveEntitlementAccrualStartDateUnitType AccrualStartAfterUnitType { get; set; }
        public decimal AccrualAmount { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveEntitlementAccrualUnitType AccrualUnitType { get; set; }
        public bool IsDeleted { get; set; }
    }
}
