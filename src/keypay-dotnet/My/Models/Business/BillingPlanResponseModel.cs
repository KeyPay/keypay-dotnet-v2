using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Business
{
    public class BillingPlanResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PricingModelTypeEnum Type { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal PricePerSms { get; set; }
        public int IncludedEmployees { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FunctionToggle FunctionRostering { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FunctionToggle FunctionTimeAndAttendance { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FunctionToggle FunctionEmployeeOnboarding { get; set; }
        public string Description { get; set; }
        public bool IsHidden { get; set; }
    }
}
