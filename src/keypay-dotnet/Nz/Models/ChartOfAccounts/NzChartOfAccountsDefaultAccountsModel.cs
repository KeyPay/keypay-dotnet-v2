using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.ChartOfAccounts
{
    public class NzChartOfAccountsDefaultAccountsModel
    {
        public bool PaymentAccountSplitByLocation { get; set; }
        public bool DefaultExpenseSplitByLocation { get; set; }
        public bool EmployeeExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityLiabilitySplitByLocation { get; set; }
        public bool DefaultLiabilitySplitByLocation { get; set; }
        public bool PayeLiabilityAccountSplitByLocation { get; set; }
        public bool PayeExpenseSplitByLocation { get; set; }
        public bool KiwiSaverEmployerExpenseSplitByLocation { get; set; }
        public bool KiwiSaverEmployerLiabilitySplitByLocation { get; set; }
        public bool KiwiSaverEmployeeLiabilitySplitByLocation { get; set; }
        public bool StudentLoanLiabilitySplitByLocation { get; set; }
        public int? PayeLiabilityAccountId { get; set; }
        public int? PayeExpenseAccountId { get; set; }
        public int? KiwiSaverEmployerExpenseAccountId { get; set; }
        public int? KiwiSaverEmployerLiabilityAccountId { get; set; }
        public int? KiwiSaverEmployeeLiabilityAccountId { get; set; }
        public int? StudentLoanLiabilityAccountId { get; set; }
        public int? PaymentAccountId { get; set; }
        public int? DefaultExpenseAccountId { get; set; }
        public int? EmployeeExpenseAccountId { get; set; }
        public int? EmployerLiabilityExpenseAccountId { get; set; }
        public int? EmployerLiabilityLiabilityAccountId { get; set; }
        public int? DefaultLiabilityAccountId { get; set; }
    }
}
