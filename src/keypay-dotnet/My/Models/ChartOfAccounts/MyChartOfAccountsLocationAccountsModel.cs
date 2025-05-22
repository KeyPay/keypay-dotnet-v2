using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.ChartOfAccounts
{
    public class MyChartOfAccountsLocationAccountsModel
    {
        public int? PcbLiabilityAccountId { get; set; }
        public int? EpfEmployerExpenseAccountId { get; set; }
        public int? EpfEmployerLiabilityAccountId { get; set; }
        public int? EpfEmployeeLiabilityAccountId { get; set; }
        public int? EisEmployerExpenseAccountId { get; set; }
        public int? EisEmployerLiabilityAccountId { get; set; }
        public int? EisEmployeeLiabilityAccountId { get; set; }
        public int? SocsoEmployerExpenseAccountId { get; set; }
        public int? SocsoEmployerLiabilityAccountId { get; set; }
        public int? SocsoEmployeeLiabilityAccountId { get; set; }
        public int? HrdfEmployerExpenseAccountId { get; set; }
        public int? HrdfEmployerLiabilityAccountId { get; set; }
        public int? PcbBorneByEmployerExpenseAccountId { get; set; }
        public int? PcbBorneByEmployerLiabilityAccountId { get; set; }
        public int? Cp38ExpenseAccountId { get; set; }
        public int? Cp38LiabilityAccountId { get; set; }
        public int? BenefitsInKindExpenseAccountId { get; set; }
        public int? BenefitsInKindLiabilityAccountId { get; set; }
        public int? PaymentAccountId { get; set; }
        public int? DefaultExpenseAccountId { get; set; }
        public int? EmployeeExpenseAccountId { get; set; }
        public int? EmployerLiabilityExpenseAccountId { get; set; }
        public int? EmployerLiabilityLiabilityAccountId { get; set; }
        public int? DefaultLiabilityAccountId { get; set; }
    }
}
