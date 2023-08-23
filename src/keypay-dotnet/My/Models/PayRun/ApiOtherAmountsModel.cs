using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class ApiOtherAmountsModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public PayslipCategory Category { get; set; }
        public string Name { get; set; }
        public decimal? Amount { get; set; }
        public decimal? YtdAmount { get; set; }
    }
}
