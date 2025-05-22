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
        public bool TaxLiabilitySplitByLocation { get; set; }
        public bool? TaxLiabilitySplitByEmployingEntity { get; set; }
        public bool? PaymentAccountSplitByEmployingEntity { get; set; }
        public bool? DefaultExpenseSplitByEmployingEntity { get; set; }
        public bool? EmployeeExpenseSplitByEmployingEntity { get; set; }
        public bool? EmployerLiabilityExpenseSplitByEmployingEntity { get; set; }
        public bool? EmployerLiabilityLiabilitySplitByEmployingEntity { get; set; }
        public bool? DefaultLiabilitySplitByEmployingEntity { get; set; }
        public bool? CpfEmployerExpenseSplitByEmployingEntity { get; set; }
        public bool? CpfEmployerLiabilitySplitByEmployingEntity { get; set; }
        public bool? CpfEmployeeLiabilitySplitByEmployingEntity { get; set; }
        public bool? SdlEmployerExpenseSplitByEmployingEntity { get; set; }
        public bool? SdlEmployerLiabilitySplitByEmployingEntity { get; set; }
        public int? CpfEmployerExpenseAccountId { get; set; }
        public int? CpfEmployerLiabilityAccountId { get; set; }
        public int? CpfEmployeeLiabilityAccountId { get; set; }
        public int? SdlEmployerExpenseAccountId { get; set; }
        public int? SdlEmployerLiabilityAccountId { get; set; }
        public int? TaxLiabilityAccountId { get; set; }
        public int? PaymentAccountId { get; set; }
        public int? DefaultExpenseAccountId { get; set; }
        public int? EmployeeExpenseAccountId { get; set; }
        public int? EmployerLiabilityExpenseAccountId { get; set; }
        public int? EmployerLiabilityLiabilityAccountId { get; set; }
        public int? DefaultLiabilityAccountId { get; set; }
    }
}
