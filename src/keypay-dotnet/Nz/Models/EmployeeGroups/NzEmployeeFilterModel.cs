using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmployeeGroups
{
    public class NzEmployeeFilterModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public NzFilterTypeEnum FilterType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FilterOperatorEnum Operator { get; set; }
        public string Value { get; set; }
    }
}
