using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class PayRunInclusionExportModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public string PrimaryLocation { get; set; }
        public string Location { get; set; }
        public string DeductionCategory { get; set; }
        public string ExpenseCategory { get; set; }
        public string EmployerLiabilityCategory { get; set; }
        public string PayCategory { get; set; }
        public string TaxAdjustmentType { get; set; }
        public string StartDate { get; set; }
        public string Expiry { get; set; }
        public decimal? Amount { get; set; }
        public string AmountType { get; set; }
        public string Paid { get; set; }
        public string PreservedEarnings { get; set; }
        public decimal? Units { get; set; }
        public string Rate { get; set; }
        public string Total { get; set; }
        public string Notes { get; set; }
    }
}
