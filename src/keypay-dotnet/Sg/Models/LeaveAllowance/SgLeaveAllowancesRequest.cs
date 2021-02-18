using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.LeaveAllowance
{
    public class SgLeaveAllowancesRequest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType EmployeeIdType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType LeaveCategoryIdType { get; set; }
        public Dictionary<string,List<SgLeaveAllowanceModel>> LeaveAllowances { get; set; }
    }
}
