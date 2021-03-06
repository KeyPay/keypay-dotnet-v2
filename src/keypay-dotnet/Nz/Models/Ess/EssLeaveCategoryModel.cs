using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class EssLeaveCategoryModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveUnitTypeEnum UnitType { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
