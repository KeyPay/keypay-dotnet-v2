using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Employee
{
    public class OpeningBalancesTaxReliefItemModel
    {
        public int ReliefNumber { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TaxReliefTypeEnum Type { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal Threshold { get; set; }
        public bool Override { get; set; }
        public decimal Total { get; set; }
    }
}
