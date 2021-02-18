using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkSpbpCalcApiModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public SpbpEligibilityEnum Status { get; set; }
        public int SpbpDays { get; set; }
        public IDictionary<Decimal,Int32> Rates { get; set; }
        public UkSpbpPaymentApiModel[] Payments { get; set; }
    }
}
