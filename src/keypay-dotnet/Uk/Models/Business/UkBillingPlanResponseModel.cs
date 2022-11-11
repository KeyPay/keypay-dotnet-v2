using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class UkBillingPlanResponseModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public FunctionToggle FunctionSimpleSetup { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FunctionToggle FunctionPayrollingBenefits { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FunctionToggle FunctionIR35Contractors { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FunctionToggle FunctionOccupationalAbsence { get; set; }
        public decimal PricePerP11D { get; set; }
        public bool FunctionEnableCis { get; set; }
        public decimal PricePerCisSubContractor { get; set; }
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
