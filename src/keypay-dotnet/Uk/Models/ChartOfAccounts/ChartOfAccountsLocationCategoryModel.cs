using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.ChartOfAccounts
{
    public class ChartOfAccountsLocationCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ExpenseAccountId { get; set; }
    }
}
