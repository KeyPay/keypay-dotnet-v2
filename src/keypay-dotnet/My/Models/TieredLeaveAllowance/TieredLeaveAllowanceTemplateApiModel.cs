using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.TieredLeaveAllowance
{
    public class TieredLeaveAllowanceTemplateApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TierOptionEnum? TierOption { get; set; }
        public bool Deleted { get; set; }
        public List<TieredLeaveAllowanceTemplateTierApiModel> LeaveAllowanceTemplateTiers { get; set; }
    }
}
