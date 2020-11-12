using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkPayRunTotalModel
    {
        public decimal PayeWithheld { get; set; }
        public decimal StudentLoanAmount { get; set; }
        public decimal EmployerPensionContribution { get; set; }
        public decimal EmployeePensionContribution { get; set; }
        public decimal EmployeeNationalInsuranceContribution { get; set; }
        public decimal EmployerNationalInsuranceContribution { get; set; }
        public int Id { get; set; }
        public decimal TotalHours { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal PreTaxDeductions { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal PostTaxDeductions { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal TotalEmployeeExpenses { get; set; }
        public decimal TotalEmployerLiabilities { get; set; }
        public bool IsPublished { get; set; }
        public int PayRunId { get; set; }
        public string Notation { get; set; }
    }
}
