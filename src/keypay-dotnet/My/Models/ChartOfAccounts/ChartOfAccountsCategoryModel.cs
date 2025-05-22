using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.ChartOfAccounts
{
    public class ChartOfAccountsCategoryModel
    {
        public bool SplitByLocation { get; set; }
        public bool? SplitByEmployingEntity { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ExpenseAccountId { get; set; }
    }
}
