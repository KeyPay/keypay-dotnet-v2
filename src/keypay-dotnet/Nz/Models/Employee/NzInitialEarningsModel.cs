using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Employee
{
    public class NzInitialEarningsModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public NzPayCategoryType PayCategoryType { get; set; }
        public int PayCategoryId { get; set; }
        public bool IsStandardPayCategory { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
