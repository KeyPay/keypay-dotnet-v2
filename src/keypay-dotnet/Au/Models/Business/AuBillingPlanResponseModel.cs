using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Business
{
    public class AuBillingPlanResponseModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public SuperInclusionTypeEnum SuperInclusion { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FunctionToggle FunctionPayConditions { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FunctionToggle FunctionAwards { get; set; }
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
    }
}
