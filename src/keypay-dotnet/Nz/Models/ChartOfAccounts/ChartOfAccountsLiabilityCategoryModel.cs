using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.ChartOfAccounts
{
    public class ChartOfAccountsLiabilityCategoryModel
    {
        public int? LiabilityAccountId { get; set; }
        public bool SplitByLocation { get; set; }
        public bool? SplitByEmployingEntity { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ExpenseAccountId { get; set; }
    }
}
