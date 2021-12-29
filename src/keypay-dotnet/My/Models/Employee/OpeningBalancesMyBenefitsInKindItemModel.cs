using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Employee
{
    public class OpeningBalancesMyBenefitsInKindItemModel
    {
        public decimal Amount { get; set; }
        public bool TaxExempt { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MyBenefitsInKindType BenefitsInKindType { get; set; }
        public string Description { get; set; }
    }
}
