using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.DeductionCategories
{
    public class AuDeductionCategoryModel
    {
        public bool TaxExempt { get; set; }
        public string ExpenseGeneralLedgerMappingCode { get; set; }
        public string LiabilityGeneralLedgerMappingCode { get; set; }
        public SGCCalculationImpactEnum SgcCalculationImpact { get; set; }
        public DeductionCategoryPaymentSummaryClassification PaymentSummaryClassification { get; set; }
        public bool IsResc { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string ExternalId { get; set; }
        public bool IsSystem { get; set; }
    }
}
