using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.ChartOfAccounts
{
    public class AuChartOfAccountsGroupModel
    {
        public AuChartOfAccountsDefaultAccountsModel DefaultAccounts { get; set; }
        public List<ChartOfAccountsLeaveCategoryModel> LeaveCategories { get; set; }
        public List<ChartOfAccountsCategoryModel> PayCategories { get; set; }
        public List<ChartOfAccountsLiabilityCategoryModel> DeductionCategories { get; set; }
        public List<ChartOfAccountsCategoryModel> EmployeeExpenseCategories { get; set; }
        public List<ChartOfAccountsLiabilityCategoryModel> EmployerLiabilityCategories { get; set; }
    }
}
