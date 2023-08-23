using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class DetailedPayRunWarningModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunWarningType WarningType { get; set; }
        public string WarningTypeDescription { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Warning { get; set; }
    }
}
