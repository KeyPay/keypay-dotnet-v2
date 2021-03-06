using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmployeeGroups
{
    public class AuEmployeeFilterModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public AuFilterTypeEnum FilterType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FilterOperatorEnum Operator { get; set; }
        public string Value { get; set; }
    }
}
