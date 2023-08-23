using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class SubmitPayRunEmployeeExpenseRequest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType LocationIdType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType EmployeeExpenseCategoryIdType { get; set; }
        public Dictionary<string,List<EmployeeExpenseModel>> Expenses { get; set; }
        public int PayRunId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType EmployeeIdType { get; set; }
        public bool ReplaceExisting { get; set; }
        public bool SuppressCalculations { get; set; }
    }
}
