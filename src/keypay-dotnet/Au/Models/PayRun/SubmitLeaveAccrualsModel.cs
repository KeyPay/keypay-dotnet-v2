using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class SubmitLeaveAccrualsModel
    {
        public bool ReplaceExisting { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType EmployeeIdType { get; set; }
        public bool SuppressCalculations { get; set; }
        public Dictionary<string,List<SaveLeaveAccrualModel>> Leave { get; set; }
    }
}
