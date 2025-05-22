using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.ChartOfAccounts
{
    public class UkChartOfAccountsEmployingEntityGroupModel
    {
        public ChartOfAccountsLocationAccountsModel DefaultAccounts { get; set; }
        public int EmployingEntityId { get; set; }
        public List<ChartOfAccountsLocationCategoryModel> PayCategories { get; set; }
        public List<ChartOfAccountsLiabilityLocationCategoryModel> DeductionCategories { get; set; }
        public List<ChartOfAccountsLocationCategoryModel> EmployeeExpenseCategories { get; set; }
        public List<ChartOfAccountsLiabilityLocationCategoryModel> EmployerLiabilityCategories { get; set; }
    }
}
