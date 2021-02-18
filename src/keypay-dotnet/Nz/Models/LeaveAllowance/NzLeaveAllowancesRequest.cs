using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.LeaveAllowance
{
    public class NzLeaveAllowancesRequest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType EmployeeIdType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType LeaveCategoryIdType { get; set; }
        public Dictionary<string,List<NzLeaveAllowanceModel>> LeaveAllowances { get; set; }
    }
}
