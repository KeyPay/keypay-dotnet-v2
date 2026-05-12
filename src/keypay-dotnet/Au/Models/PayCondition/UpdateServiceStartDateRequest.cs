using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayCondition
{
    public class UpdateServiceStartDateRequest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ComparisonStartDateType? ServiceStartDateType { get; set; }
        public DateTime? ServiceStartDate { get; set; }
    }
}
