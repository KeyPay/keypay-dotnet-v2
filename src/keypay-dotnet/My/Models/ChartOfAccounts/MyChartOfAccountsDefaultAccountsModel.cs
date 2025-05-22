using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.ChartOfAccounts
{
    public class MyChartOfAccountsDefaultAccountsModel
    {
        public bool PaymentAccountSplitByLocation { get; set; }
        public bool DefaultExpenseSplitByLocation { get; set; }
        public bool EmployeeExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityLiabilitySplitByLocation { get; set; }
        public bool DefaultLiabilitySplitByLocation { get; set; }
        public bool PcbLiabilitySplitByLocation { get; set; }
        public bool EpfEmployerExpenseSplitByLocation { get; set; }
        public bool EpfEmployerLiabilitySplitByLocation { get; set; }
        public bool EpfEmployeeLiabilitySplitByLocation { get; set; }
        public bool EisEmployerExpenseSplitByLocation { get; set; }
        public bool EisEmployerLiabilitySplitByLocation { get; set; }
        public bool EisEmployeeLiabilitySplitByLocation { get; set; }
        public bool SocsoEmployerExpenseSplitByLocation { get; set; }
        public bool SocsoEmployerLiabilitySplitByLocation { get; set; }
        public bool SocsoEmployeeLiabilitySplitByLocation { get; set; }
        public bool HrdfEmployerExpenseSplitByLocation { get; set; }
        public bool HrdfEmployerLiabilitySplitByLocation { get; set; }
        public bool PcbBorneByEmployerExpenseSplitByLocation { get; set; }
        public bool PcbBorneByEmployerLiabilitySplitByLocation { get; set; }
        public bool Cp38ExpenseSplitByLocation { get; set; }
        public bool Cp38LiabilitySplitByLocation { get; set; }
        public bool BenefitsInKindExpenseSplitByLocation { get; set; }
        public bool BenefitsInKindLiabilitySplitByLocation { get; set; }
        public bool? PaymentAccountSplitByEmployingEntity { get; set; }
        public bool? DefaultExpenseSplitByEmployingEntity { get; set; }
        public bool? EmployeeExpenseSplitByEmployingEntity { get; set; }
        public bool? EmployerLiabilityExpenseSplitByEmployingEntity { get; set; }
        public bool? EmployerLiabilityLiabilitySplitByEmployingEntity { get; set; }
        public bool? DefaultLiabilitySplitByEmployingEntity { get; set; }
        public bool? PcbLiabilitySplitByEmployingEntity { get; set; }
        public bool? EpfEmployerExpenseSplitByEmployingEntity { get; set; }
        public bool? EpfEmployerLiabilitySplitByEmployingEntity { get; set; }
        public bool? EpfEmployeeLiabilitySplitByEmployingEntity { get; set; }
        public bool? EisEmployerExpenseSplitByEmployingEntity { get; set; }
        public bool? EisEmployerLiabilitySplitByEmployingEntity { get; set; }
        public bool? EisEmployeeLiabilitySplitByEmployingEntity { get; set; }
        public bool? SocsoEmployerExpenseSplitByEmployingEntity { get; set; }
        public bool? SocsoEmployerLiabilitySplitByEmployingEntity { get; set; }
        public bool? SocsoEmployeeLiabilitySplitByEmployingEntity { get; set; }
        public bool? HrdfEmployerExpenseSplitByEmployingEntity { get; set; }
        public bool? HrdfEmployerLiabilitySplitByEmployingEntity { get; set; }
        public bool? PcbBorneByEmployerExpenseSplitByEmployingEntity { get; set; }
        public bool? PcbBorneByEmployerLiabilitySplitByEmployingEntity { get; set; }
        public bool? Cp38ExpenseSplitByEmployingEntity { get; set; }
        public bool? Cp38LiabilitySplitByEmployingEntity { get; set; }
        public bool? BenefitsInKindExpenseSplitByEmployingEntity { get; set; }
        public bool? BenefitsInKindLiabilitySplitByEmployingEntity { get; set; }
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
