using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Employee
{
    public class OpeningBalancesLumpSumPaymentModel
    {
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayCategoryType PayCategoryType { get; set; }
        public decimal? TaxFreeComponent { get; set; }
        public decimal? TaxableComponent { get; set; }
        public decimal? TaxWithheld { get; set; }
    }
}
