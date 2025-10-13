using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.DeductionCategories
{
    public class DeductionCategoryEditModel
    {
        public int Id { get; set; }
        public string DeductionCategoryName { get; set; }
        public bool TaxExempt { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public string ExternalReferenceId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SGCCalculationImpactEnum SgcCalculationImpact { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MinimumWageDeductionImpact MinimumWageDeductionImpact { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DeductionCategoryPreTaxPensionImpact PensionableEarningsImpact { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DeductionCategoryPreTaxNationalInsuranceImpact NationalInsuranceImpact { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DeductionCategoryPaymentSummaryClassification PaymentSummaryClassification { get; set; }
        public string ExpenseGeneralLedgerMappingCode { get; set; }
        public string LiabilityGeneralLedgerMappingCode { get; set; }
        public bool IsSystem { get; set; }
        public bool IsInUse { get; set; }
        public bool IsResc { get; set; }
        public bool IsNameReadOnly { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DeductionCategoryCisType CisType { get; set; }
        public List<Int32> T4Boxes { get; set; }
    }
}
