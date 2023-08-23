using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkApplySapPaymentsApiModel
    {
        public SapPayment[] Payments { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DoNotPaySapReasonEnum? DoNotPayReason { get; set; }
    }
}
