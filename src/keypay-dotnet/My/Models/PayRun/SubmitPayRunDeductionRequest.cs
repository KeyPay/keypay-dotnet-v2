using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class SubmitPayRunDeductionRequest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType DeductionCategoryIdType { get; set; }
        public Dictionary<string,List<DeductionModel>> Deductions { get; set; }
        public int PayRunId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType EmployeeIdType { get; set; }
        public bool ReplaceExisting { get; set; }
        public bool SuppressCalculations { get; set; }
    }
}
