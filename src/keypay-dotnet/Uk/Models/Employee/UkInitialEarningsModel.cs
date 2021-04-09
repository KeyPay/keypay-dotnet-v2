using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkInitialEarningsModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public UkPayCategoryType PayCategoryType { get; set; }
        public int PayCategoryId { get; set; }
        public bool IsStandardPayCategory { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
