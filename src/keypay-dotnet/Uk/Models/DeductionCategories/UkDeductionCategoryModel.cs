using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.DeductionCategories
{
    public class UkDeductionCategoryModel
    {
        public bool TaxExempt { get; set; }
        public MinimumWageDeductionImpact MinimumWageDeductionImpact { get; set; }
        public DeductionCategoryPreTaxPensionImpact PensionableEarningsImpact { get; set; }
        public DeductionCategoryPreTaxNationalInsuranceImpact NationalInsuranceImpact { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string ExternalId { get; set; }
        public bool IsSystem { get; set; }
    }
}
