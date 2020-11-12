using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class UkChartOfAccountsGroupModel
    {
        public UkChartOfAccountsDefaultAccountsModel DefaultAccounts { get; set; }
        public List<ChartOfAccountsCategoryModel> PayCategories { get; set; }
        public List<ChartOfAccountsLiabilityCategoryModel> DeductionCategories { get; set; }
        public List<ChartOfAccountsCategoryModel> EmployeeExpenseCategories { get; set; }
        public List<ChartOfAccountsLiabilityCategoryModel> EmployerLiabilityCategories { get; set; }
    }
}
