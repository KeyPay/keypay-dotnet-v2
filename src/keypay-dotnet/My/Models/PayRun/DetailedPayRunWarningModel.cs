using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
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
