using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Business
{
    public class ChartOfAccountsLocationGroupModel
    {
        public int LocationId { get; set; }
        public ChartOfAccountsLocationAccountsModel DefaultAccounts { get; set; }
        public List<ChartOfAccountsLocationCategoryModel> PayCategories { get; set; }
        public List<ChartOfAccountsLiabilityLocationCategoryModel> DeductionCategories { get; set; }
        public List<ChartOfAccountsLocationCategoryModel> EmployeeExpenseCategories { get; set; }
        public List<ChartOfAccountsLiabilityLocationCategoryModel> EmployerLiabilityCategories { get; set; }
    }

    public class ChartOfAccountsLocationAccountsModel
    {
        public int? PaymentAccountId { get; set; }
        public int? PaygLiabilityAccountId { get; set; }
        public int? PaygExpenseAccountId { get; set; }
        public int? SuperannuationExpenseAccountId { get; set; }
        public int? SuperannuationLiabilityAccountId { get; set; }
        public int? DefaultExpenseAccountId { get; set; }
        public int? EmployeeExpenseAccountId { get; set; }
        public int? EmployerLiabilityExpenseAccountId { get; set; }
        public int? EmployerLiabilityLiabilityAccountId { get; set; }
        public int? DefaultLiabilityAccountId { get; set; }
    }

    public class ChartOfAccountsLocationCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ExpenseAccountId { get; set; }
    }

    public class ChartOfAccountsLiabilityLocationCategoryModel: ChartOfAccountsLocationCategoryModel
    {
        public int? LiabilityAccountId { get; set; }
    }
}