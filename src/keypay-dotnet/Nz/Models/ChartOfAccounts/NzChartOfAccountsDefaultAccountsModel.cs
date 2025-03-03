using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
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
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountSplit PaymentAccountSplit { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountSplit DefaultExpenseSplit { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountSplit EmployeeExpenseSplit { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountSplit EmployerLiabilityExpenseSplit { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountSplit EmployerLiabilityLiabilitySplit { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountSplit DefaultLiabilitySplit { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountSplit PayeLiabilityAccountSplit { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountSplit PayeExpenseSplit { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountSplit KiwiSaverEmployerExpenseSplit { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountSplit KiwiSaverEmployerLiabilitySplit { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountSplit KiwiSaverEmployeeLiabilitySplit { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountSplit StudentLoanLiabilitySplit { get; set; }
        public bool? PaymentAccountSplitByEmployingEntity { get; set; }
        public bool? DefaultExpenseSplitByEmployingEntity { get; set; }
        public bool? EmployeeExpenseSplitByEmployingEntity { get; set; }
        public bool? EmployerLiabilityExpenseSplitByEmployingEntity { get; set; }
        public bool? EmployerLiabilityLiabilitySplitByEmployingEntity { get; set; }
        public bool? DefaultLiabilitySplitByEmployingEntity { get; set; }
        public bool? PayeLiabilityAccountSplitByEmployingEntity { get; set; }
        public bool? PayeExpenseSplitByEmployingEntity { get; set; }
        public bool? KiwiSaverEmployerExpenseSplitByEmployingEntity { get; set; }
        public bool? KiwiSaverEmployerLiabilitySplitByEmployingEntity { get; set; }
        public bool? KiwiSaverEmployeeLiabilitySplitByEmployingEntity { get; set; }
        public bool? StudentLoanLiabilitySplitByEmployingEntity { get; set; }
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
