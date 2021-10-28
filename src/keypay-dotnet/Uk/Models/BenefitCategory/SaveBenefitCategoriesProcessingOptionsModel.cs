using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.BenefitCategory
{
    public class SaveBenefitCategoriesProcessingOptionsModel
    {
        public int? RegisteredFromTaxYear { get; set; }
        public bool? IsP11dBenefitsEnabled { get; set; }
        public bool? IsPayrollingBenefitsEnabled { get; set; }
    }
}
