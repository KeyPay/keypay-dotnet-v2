using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class LeaveBalanceModel
    {
        public int LeaveCategoryId { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal AccruedAmount { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveUnitTypeEnum UnitType { get; set; }
    }
}
