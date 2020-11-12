using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class UkPayRunGrandTotalModel
    {
        public decimal EmployerNationalInsuranceContribution { get; set; }
        public decimal EmployeeNationalInsuranceContribution { get; set; }
        public decimal Pension { get; set; }
        public decimal EmployeePensionContributionAmount { get; set; }
        public decimal EmployerPensionContributionAmount { get; set; }
        public decimal StudentLoanAmount { get; set; }
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
