using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.DeductionCategories
{
    public class DeductionCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool TaxExempt { get; set; }
        public string Source { get; set; }
        public string ExternalId { get; set; }
        public string ExpenseGeneralLedgerMappingCode { get; set; }
        public string LiabilityGeneralLedgerMappingCode { get; set; }
    }
}
