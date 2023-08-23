using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class EmployeeExpenseCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public string GeneralLedgerMappingCode { get; set; }
        public string Description { get; set; }
        public string ExternalReferenceId { get; set; }
        public string ExternalTaxCodeId { get; set; }
        public string TaxCode { get; set; }
        public decimal? TaxRate { get; set; }
    }
}
