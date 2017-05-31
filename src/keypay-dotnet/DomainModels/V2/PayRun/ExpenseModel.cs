namespace KeyPay.DomainModels.V2.PayRun
{
    public class ExpenseModel
    {
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeExpenseCategoryId { get; set; }
        public string EmployeeExpenseCategoryName { get; set; }
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public string TaxCode { get; set; }
        public decimal? TaxRate { get; set; }
        public string TaxCodeDisplayName { get; set; }
    }
}