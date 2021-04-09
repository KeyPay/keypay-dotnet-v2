using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Employee
{
    public class SgInitialEarningsModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public PayCategoryType PayCategoryType { get; set; }
        public int PayCategoryId { get; set; }
        public bool IsStandardPayCategory { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
