using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.TieredLongServiceLeave
{
    public class AuTieredLongServiceLeaveTemplateApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LeaveCategoryId { get; set; }
        public string LeaveCategoryName { get; set; }
        public int ContingentPeriod { get; set; }
        public IList<AuTieredLongServiceLeaveTierApiModel> Tiers { get; set; }
        public string ExternalId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public int? AwardId { get; set; }
        public string AwardName { get; set; }
    }
}
