using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.ChartOfAccounts
{
    public class AuChartOfAccountsEmployingEntityGroupModel
    {
        public AuChartOfAccountsLocationAccountsModel DefaultAccounts { get; set; }
        public List<ChartOfAccountsLocationLeaveCategoryModel> LeaveCategories { get; set; }
        public int EmployingEntityId { get; set; }
        public List<ChartOfAccountsLocationCategoryModel> PayCategories { get; set; }
        public List<ChartOfAccountsLiabilityLocationCategoryModel> DeductionCategories { get; set; }
        public List<ChartOfAccountsLocationCategoryModel> EmployeeExpenseCategories { get; set; }
        public List<ChartOfAccountsLiabilityLocationCategoryModel> EmployerLiabilityCategories { get; set; }
    }
}
