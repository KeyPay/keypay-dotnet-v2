using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.LeaveAllowance
{
    public class AuLeaveAllowancesRequest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType EmployeeIdType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType LeaveCategoryIdType { get; set; }
        public Dictionary<string,IList<AuLeaveAllowanceModel>> LeaveAllowances { get; set; }
    }
}
