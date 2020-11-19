using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.ChartOfAccounts
{
    public class SgChartOfAccountsDefaultAccountsModel
    {
        public bool PaymentAccountSplitByLocation { get; set; }
        public bool DefaultExpenseSplitByLocation { get; set; }
        public bool EmployeeExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityLiabilitySplitByLocation { get; set; }
        public bool DefaultLiabilitySplitByLocation { get; set; }
        public bool CpfEmployerExpenseSplitByLocation { get; set; }
        public bool CpfEmployerLiabilitySplitByLocation { get; set; }
        public bool CpfEmployeeLiabilitySplitByLocation { get; set; }
        public bool SdlEmployerExpenseSplitByLocation { get; set; }
        public bool SdlEmployerLiabilitySplitByLocation { get; set; }
        public int? CpfEmployerExpenseAccountId { get; set; }
        public int? CpfEmployerLiabilityAccountId { get; set; }
        public int? CpfEmployeeLiabilityAccountId { get; set; }
        public int? SdlEmployerExpenseAccountId { get; set; }
        public int? SdlEmployerLiabilityAccountId { get; set; }
        public int? PaymentAccountId { get; set; }
        public int? DefaultExpenseAccountId { get; set; }
        public int? EmployeeExpenseAccountId { get; set; }
        public int? EmployerLiabilityExpenseAccountId { get; set; }
        public int? EmployerLiabilityLiabilityAccountId { get; set; }
        public int? DefaultLiabilityAccountId { get; set; }
        public int? StudentLoanLiabilityAccountId { get; set; }
        public int? PostgraduateStudentLoanLiabilityAccountId { get; set; }
        public int? EmployerNationalInsuranceLiabilityAccountId { get; set; }
        public int? EmployeeNationalInsuranceLiabilityAccountId { get; set; }
    }
}
