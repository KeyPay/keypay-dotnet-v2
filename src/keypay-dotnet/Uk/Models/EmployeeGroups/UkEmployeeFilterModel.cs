using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.EmployeeGroups
{
    public class UkEmployeeFilterModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public UkFilterTypeEnum FilterType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FilterOperatorEnum Operator { get; set; }
        public string Value { get; set; }
    }
}
