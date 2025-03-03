using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.ChartOfAccounts
{
    public class MyChartOfAccountsGroupModel
    {
        public MyChartOfAccountsDefaultAccountsModel DefaultAccounts { get; set; }
        public List<ChartOfAccountsCategoryModel> PayCategories { get; set; }
        public List<ChartOfAccountsLiabilityCategoryModel> DeductionCategories { get; set; }
        public List<ChartOfAccountsCategoryModel> EmployeeExpenseCategories { get; set; }
        public List<ChartOfAccountsLiabilityCategoryModel> EmployerLiabilityCategories { get; set; }
    }
}
