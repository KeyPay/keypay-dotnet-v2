using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Employee
{
    public class AuInitialEarningsModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public AuPayCategoryType PayCategoryType { get; set; }
        public int PayCategoryId { get; set; }
        public bool IsStandardPayCategory { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
