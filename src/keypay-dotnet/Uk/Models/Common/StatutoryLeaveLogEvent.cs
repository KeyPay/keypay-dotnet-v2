using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class StatutoryLeaveLogEvent
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public StatutoryLeaveLogEventTypeEnum Type { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public StatutoryLeaveLogCategoryEnum Category { get; set; }
        public String[] Messages { get; set; }
        public string Message { get; set; }
    }
}
