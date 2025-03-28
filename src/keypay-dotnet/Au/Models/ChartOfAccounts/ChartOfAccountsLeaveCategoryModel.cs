using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.ChartOfAccounts
{
    public class ChartOfAccountsLeaveCategoryModel
    {
        public int? LiabilityAccountId { get; set; }
        public bool AccrueFromContingentPeriod { get; set; }
        public bool SplitByLocation { get; set; }
        public bool? SplitByEmployingEntity { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ExpenseAccountId { get; set; }
    }
}
