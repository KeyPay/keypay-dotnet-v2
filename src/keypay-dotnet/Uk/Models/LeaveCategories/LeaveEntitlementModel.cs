using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.LeaveCategories
{
    public class LeaveEntitlementModel
    {
        public int Id { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveEntitlementCarryOverType CarryOverType { get; set; }
        public decimal CarryOverAmount { get; set; }
        public bool IsProRata { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveEntitlementLeaveBalanceType LeaveBalanceType { get; set; }
        public IList<LeaveEntitlementTierModel> LeaveEntitlementTiers { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveEntitlementForfeitureType ForfeitureType { get; set; }
        public decimal ForfeitureAmount { get; set; }
        public int ForfeitureMonthsStartAfter { get; set; }
        public decimal StandardAllowanceUnitTypeAmount { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveEntitlementAccrualUnitType StandardAllowanceUnitType { get; set; }
    }
}
