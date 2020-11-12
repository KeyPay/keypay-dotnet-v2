using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.DeductionCategories
{
    public class SgDeductionCategoryModel
    {
        public DeductionCategoryPaymentSummaryClassification PaymentSummaryClassification { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string ExternalId { get; set; }
    }
}
