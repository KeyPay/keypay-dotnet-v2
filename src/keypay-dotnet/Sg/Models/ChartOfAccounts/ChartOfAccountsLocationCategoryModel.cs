using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.ChartOfAccounts
{
    public class ChartOfAccountsLocationCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ExpenseAccountId { get; set; }
    }
}
