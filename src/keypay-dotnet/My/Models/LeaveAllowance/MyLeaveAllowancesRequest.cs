using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.LeaveAllowance
{
    public class MyLeaveAllowancesRequest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType EmployeeIdType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType LeaveCategoryIdType { get; set; }
        public Dictionary<string,List<MyLeaveAllowanceModel>> LeaveAllowances { get; set; }
    }
}
