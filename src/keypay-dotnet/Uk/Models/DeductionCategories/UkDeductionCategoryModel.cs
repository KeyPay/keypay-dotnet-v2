using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.DeductionCategories
{
    public class UkDeductionCategoryModel
    {
        public bool TaxExempt { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MinimumWageDeductionImpact MinimumWageDeductionImpact { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DeductionCategoryPreTaxPensionImpact PensionableEarningsImpact { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DeductionCategoryPreTaxNationalInsuranceImpact NationalInsuranceImpact { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string ExternalId { get; set; }
        public bool IsSystem { get; set; }
    }
}
