using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.BenefitCategory
{
    public class UkBenefitCategoriesProcessingOptionsModel
    {
        public int? RegisteredFromTaxYear { get; set; }
        public bool? IsP11DBenefitsEnabled { get; set; }
        public bool? IsPayrollingBenefitsEnabled { get; set; }
    }
}
