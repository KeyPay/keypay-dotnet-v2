using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.DeductionCategories
{
    public class AuDeductionCategoryModel
    {
        public SGCCalculationImpactEnum SgcCalculationImpact { get; set; }
        public DeductionCategoryPaymentSummaryClassification PaymentSummaryClassification { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool TaxExempt { get; set; }
        public string Source { get; set; }
        public string ExternalId { get; set; }
        public string ExpenseGeneralLedgerMappingCode { get; set; }
        public string LiabilityGeneralLedgerMappingCode { get; set; }
    }
}
