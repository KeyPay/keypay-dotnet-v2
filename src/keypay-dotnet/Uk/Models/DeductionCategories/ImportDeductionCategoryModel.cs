using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.DeductionCategories
{
    public class ImportDeductionCategoryModel
    {
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public UkImportDeductionCategoryType DeductionType { get; set; }
        public string ExternalId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MinimumWageDeductionImpact? MinimumWageDeductionImpact { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DeductionCategoryPreTaxPensionImpact? PensionImpact { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DeductionCategoryPreTaxNationalInsuranceImpact? NationalInsuranceImpact { get; set; }
    }
}
