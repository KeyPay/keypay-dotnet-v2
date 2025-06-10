using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkSppCalcApiModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public SppEligibilityEnum Status { get; set; }
        public int SppDays { get; set; }
        public IDictionary<Decimal,Int32> Rates { get; set; }
        public UkSppPaymentApiModel[] Payments { get; set; }
    }
}
