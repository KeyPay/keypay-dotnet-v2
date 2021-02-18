using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.LeaveAllowance
{
    public class LeaveAllowancesRequest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType EmployeeIdType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType LeaveCategoryIdType { get; set; }
        public Dictionary<string,List<LeaveAllowanceApiModel>> LeaveAllowances { get; set; }
    }
}
