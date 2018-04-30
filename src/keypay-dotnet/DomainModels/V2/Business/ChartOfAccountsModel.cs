using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Business
{
    public class ChartOfAccountsModel
    {
        public bool Complete { get; set; }
        public ChartOfAccountsGroupModel ChartofAccounts { get; set; }
        public List<ChartOfAccountsLocationGroupModel> LocationSpecificChartOfAccounts { get; set; }
    }

    public class ChartOfAccountsGroupModel
    {
        public ChartOfAccountsDefaultAccountsModel DefaultAccounts { get; set; }
        public List<ChartOfAccountsCategoryModel> PayCategories { get; set; }
        public List<ChartOfAccountsLiabilityCategoryModel> DeductionCategories { get; set; }
        public List<ChartOfAccountsCategoryModel> EmployeeExpenseCategories { get; set; }
        public List<ChartOfAccountsLiabilityCategoryModel> EmployerLiabilityCategories { get; set; }
    }

    public class ChartOfAccountsDefaultAccountsModel : ChartOfAccountsLocationAccountsModel
    {
        public bool PaymentAccountSplitByLocation { get; set; }
        public bool PaygLiabilityAccountSplitByLocation { get; set; }
        public bool PaygExpenseSplitByLocation { get; set; }
        public bool SuperannuationExpenseSplitByLocation { get; set; }
        public bool SuperannuationLiabilitySplitByLocation { get; set; }
        public bool DefaultExpenseSplitByLocation { get; set; }
        public bool EmployeeExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityLiabilitySplitByLocation { get; set; }
        public bool DefaultLiabilitySplitByLocation { get; set; }
    }

    public class ChartOfAccountsCategoryModel : ChartOfAccountsLocationCategoryModel
    {
        public bool SplitByLocation { get; set; }
    }

    public class ChartOfAccountsLiabilityCategoryModel: ChartOfAccountsCategoryModel
    {
        public int? LiabilityAccountId { get; set; }
    }
}