using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.DeductionCategories
{
    public class NzDeductionCategoryModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public DeductionCategoryPaymentSummaryClassification PaymentSummaryClassification { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public string ExternalId { get; set; }
        public bool IsSystem { get; set; }
    }
}
