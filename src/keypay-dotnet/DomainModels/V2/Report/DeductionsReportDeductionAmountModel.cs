namespace KeyPay.DomainModels.V2.Report
{
    public class DeductionsReportDeductionAmountModel
    {
        public int DeductionCategoryId { get; set; }
        public string DeductionCategoryName { get; set; }
        public decimal Amount { get; set; }
    }
}