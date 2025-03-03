using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.ChartOfAccounts
{
    public class UkChartOfAccountsDefaultAccountsModel
    {
        public bool PayeLiabilityAccountSplitByLocation { get; set; }
        public bool PayeExpenseSplitByLocation { get; set; }
        public bool PaymentAccountSplitByLocation { get; set; }
        public bool DefaultExpenseSplitByLocation { get; set; }
        public bool EmployeeExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityLiabilitySplitByLocation { get; set; }
        public bool DefaultLiabilitySplitByLocation { get; set; }
        public bool EmployerPensionLiabilitySplitByLocation { get; set; }
        public bool EmployerPensionExpenseSplitByLocation { get; set; }
        public bool NationalInsuranceLiabilitySplitByLocation { get; set; }
        public bool NationalInsuranceExpenseSplitByLocation { get; set; }
        public bool EmployerNationalInsuranceLiabilitySplitByLocation { get; set; }
        public bool EmployeeNationalInsuranceLiabilitySplitByLocation { get; set; }
        public bool EmployeePensionLiabilitySplitByLocation { get; set; }
        public bool StudentLoanLiabilitySplitByLocation { get; set; }
        public bool PostgraduateStudentLoanLiabilitySplitByLocation { get; set; }
        public bool? PayeLiabilityAccountSplitByEmployingEntity { get; set; }
        public bool? PayeExpenseSplitByEmployingEntity { get; set; }
        public bool? PaymentAccountSplitByEmployingEntity { get; set; }
        public bool? DefaultExpenseSplitByEmployingEntity { get; set; }
        public bool? EmployeeExpenseSplitByEmployingEntity { get; set; }
        public bool? EmployerLiabilityExpenseSplitByEmployingEntity { get; set; }
        public bool? EmployerLiabilityLiabilitySplitByEmployingEntity { get; set; }
        public bool? DefaultLiabilitySplitByEmployingEntity { get; set; }
        public bool? EmployerPensionLiabilitySplitByEmployingEntity { get; set; }
        public bool? EmployerPensionExpenseSplitByEmployingEntity { get; set; }
        public bool? NationalInsuranceLiabilitySplitByEmployingEntity { get; set; }
        public bool? NationalInsuranceExpenseSplitByEmployingEntity { get; set; }
        public bool? EmployerNationalInsuranceLiabilitySplitByEmployingEntity { get; set; }
        public bool? EmployeeNationalInsuranceLiabilitySplitByEmployingEntity { get; set; }
        public bool? EmployeePensionLiabilitySplitByEmployingEntity { get; set; }
        public bool? StudentLoanLiabilitySplitByEmployingEntity { get; set; }
        public bool? PostgraduateStudentLoanLiabilitySplitByEmployingEntity { get; set; }
        public int? PayeLiabilityAccountId { get; set; }
        public int? PayeExpenseAccountId { get; set; }
        public int? EmployerPensionLiabilityAccountId { get; set; }
        public int? EmployerPensionExpenseAccountId { get; set; }
        public int? NationalInsuranceLiabilityAccountId { get; set; }
        public int? NationalInsuranceExpenseAccountId { get; set; }
        public int? EmployeePensionLiabilityAccountId { get; set; }
        public int? StudentLoanLiabilityAccountId { get; set; }
        public int? PostgraduateStudentLoanLiabilityAccountId { get; set; }
        public int? EmployeeNationalInsuranceLiabilityAccountId { get; set; }
        public int? PaymentAccountId { get; set; }
        public int? DefaultExpenseAccountId { get; set; }
        public int? EmployeeExpenseAccountId { get; set; }
        public int? EmployerLiabilityExpenseAccountId { get; set; }
        public int? EmployerLiabilityLiabilityAccountId { get; set; }
        public int? DefaultLiabilityAccountId { get; set; }
    }
}
