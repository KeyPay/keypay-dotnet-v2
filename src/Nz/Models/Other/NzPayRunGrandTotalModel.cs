using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Other
{
    public class NzPayRunGrandTotalModel
    {
        public decimal KiwiSaverEmployerContributionAmount { get; set; }
        public decimal KiwiSaverEmployeeContributionAmount { get; set; }
        public decimal EsctContributionAmount { get; set; }
        public decimal StudentLoanAmount { get; set; }
        public decimal StudentLoanAdditionalMandatoryAmount { get; set; }
        public decimal StudentLoanAdditionalVoluntaryAmount { get; set; }
        public decimal PayeWithholdingAmount { get; set; }
        public int NumberOfEmployees { get; set; }
        public decimal TotalHours { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal PreTaxDeductionAmount { get; set; }
        public decimal PostTaxDeductionAmount { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal EmployeeExpensesTotal { get; set; }
        public decimal EmployerLiabilitiesTotal { get; set; }
    }
}
